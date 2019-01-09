using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using System.Linq;

public class LifeGameClient : MonoBehaviour
{
    [SerializeField]
    GridLayoutGroup field = null;

    [SerializeField]
    Cell cellPrefab = null;

    Channel channel = null;
    Lifegame.LifeGame.LifeGameClient client = null;

    List<Cell> cells = new List<Cell>();

    Lifegame.UpdateResponse updateResponse = null;

    int count = 0;

    void Update()
    {
        if (this.updateResponse != null)
        {
            var responce = updateResponse;
            for (int i = 0; i < this.cells.Count; ++i)
            {
                this.cells[i].SetState(responce.Cells[i]);
            }

            if (Input.anyKeyDown)
            {
                //this.updateResponse = client.Update(new Lifegame.UpdateRequest());
                client.ResetCells(new Lifegame.ResetRequest());
            }
            Debug.Log($"update count = {count}, alive cell count: {this.cells.Count(e => e.State == Lifegame.Cell.Alive)}");
        }
    }

    async Task Run()
    {
        while(channel != null)
        {
            count++;
            this.updateResponse = await client.UpdateAsync(new Lifegame.UpdateRequest());
        }
    }

    void Initialize()
    {
        channel = new Channel ($"127.0.0.1:50051", ChannelCredentials.Insecure);
        client = new Lifegame.LifeGame.LifeGameClient (channel);

        var size = client.GetFieldSize(new Lifegame.FieldSizeRequest());
        field.constraintCount = (int)size.Width;
        field.cellSize = Vector2.one * (field.GetComponent<RectTransform>().rect.height / size.Height / 2);
        for (int i = 0; i < size.Height * size.Width; ++i)
        {
            this.cells.Add(Instantiate(cellPrefab, field.transform));
        }
        this.updateResponse = client.Update(new Lifegame.UpdateRequest());
    }

    // Update is called once per frame
    void OnEnable()
    {
        Initialize();
        Task.Run(this.Run);
    }

    void OnDisable()
    {
        channel.ShutdownAsync().Wait();
        channel = null;
    }
}
