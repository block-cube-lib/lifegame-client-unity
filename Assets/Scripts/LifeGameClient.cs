using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using System.Linq;

/// <summary>
/// ライフゲームの結果を受け取る
/// </summary>
public class LifegameClient : MonoBehaviour
{
    /// <summary>
    /// ライフゲームのセル群
    /// </summary>
    [SerializeField]
    GridLayoutGroup field = null;

    /// <summary>
    /// Cellのコピー元
    /// </summary>
    [SerializeField]
    Cell cellPrefab = null;

    /// <summary>
    /// チャンネル
    /// </summary>
    Channel channel = null;

    /// <summary>
    /// クライアント
    /// </summary>
    Lifegame.Lifegame.LifegameClient client = null;

    /// <summary>
    /// 表示しているセルのリスト
    /// </summary>
    List<Cell> cells = new List<Cell>();

    /// <summary>
    /// セルを取得したときの戻り値
    /// </summary>
    Lifegame.CellsResponse cellsResponce = null;

    void Update()
    {
        if (this.cellsResponce == null)
        {
            return;
        }

        var responce = cellsResponce;
        for (int i = 0; i < this.cells.Count; ++i)
        {
            this.cells[i].SetState(responce.Cells[i]);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Task.Run(() => client.Reset(new Lifegame.ResetRequest()));
        }
    }

    async Task GetCellsLoop()
    {
        var sleepTime = System.TimeSpan.FromMilliseconds(10);
        while (channel != null)
        {
            this.cellsResponce = await client.GetCellsAsync(new Lifegame.CellsRequest());
            Thread.Sleep(sleepTime);
            System.GC.Collect();
        }
    }

    /// <summary>
    /// 初期化
    /// </summary>
    void Initialize()
    {
        channel = new Channel($"127.0.0.1:50051", ChannelCredentials.Insecure);
        client = new Lifegame.Lifegame.LifegameClient(channel);

        var size = client.GetFieldSize(new Lifegame.FieldSizeRequest());
        field.constraintCount = (int)size.Width;
        field.cellSize = Vector2.one * (field.GetComponent<RectTransform>().rect.height / size.Height / 2);
        for (int i = 0; i < size.Height * size.Width; ++i)
        {
            this.cells.Add(Instantiate(cellPrefab, field.transform));
        }
        this.cellsResponce = client.GetCells(new Lifegame.CellsRequest());
    }

    void OnEnable()
    {
        Initialize();
        Task.Run(this.GetCellsLoop);
    }

    void OnDisable()
    {
        channel.ShutdownAsync().Wait();
        channel = null;
    }
}
