// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/lifegame.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Lifegame {
  public static partial class LifeGame
  {
    static readonly string __ServiceName = "lifegame.LifeGame";

    static readonly grpc::Marshaller<global::Lifegame.FieldSizeRequest> __Marshaller_lifegame_FieldSizeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Lifegame.FieldSizeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Lifegame.FieldSizeResponse> __Marshaller_lifegame_FieldSizeResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Lifegame.FieldSizeResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Lifegame.CellsRequest> __Marshaller_lifegame_CellsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Lifegame.CellsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Lifegame.CellsResponse> __Marshaller_lifegame_CellsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Lifegame.CellsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Lifegame.UpdateRequest> __Marshaller_lifegame_UpdateRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Lifegame.UpdateRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Lifegame.UpdateResponse> __Marshaller_lifegame_UpdateResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Lifegame.UpdateResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Lifegame.ResetRequest> __Marshaller_lifegame_ResetRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Lifegame.ResetRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Lifegame.ResetResponse> __Marshaller_lifegame_ResetResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Lifegame.ResetResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Lifegame.FieldSizeRequest, global::Lifegame.FieldSizeResponse> __Method_GetFieldSize = new grpc::Method<global::Lifegame.FieldSizeRequest, global::Lifegame.FieldSizeResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetFieldSize",
        __Marshaller_lifegame_FieldSizeRequest,
        __Marshaller_lifegame_FieldSizeResponse);

    static readonly grpc::Method<global::Lifegame.CellsRequest, global::Lifegame.CellsResponse> __Method_GetCells = new grpc::Method<global::Lifegame.CellsRequest, global::Lifegame.CellsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCells",
        __Marshaller_lifegame_CellsRequest,
        __Marshaller_lifegame_CellsResponse);

    static readonly grpc::Method<global::Lifegame.UpdateRequest, global::Lifegame.UpdateResponse> __Method_Update = new grpc::Method<global::Lifegame.UpdateRequest, global::Lifegame.UpdateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_lifegame_UpdateRequest,
        __Marshaller_lifegame_UpdateResponse);

    static readonly grpc::Method<global::Lifegame.ResetRequest, global::Lifegame.ResetResponse> __Method_ResetCells = new grpc::Method<global::Lifegame.ResetRequest, global::Lifegame.ResetResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ResetCells",
        __Marshaller_lifegame_ResetRequest,
        __Marshaller_lifegame_ResetResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Lifegame.LifegameReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of LifeGame</summary>
    public abstract partial class LifeGameBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Lifegame.FieldSizeResponse> GetFieldSize(global::Lifegame.FieldSizeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Lifegame.CellsResponse> GetCells(global::Lifegame.CellsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Lifegame.UpdateResponse> Update(global::Lifegame.UpdateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Lifegame.ResetResponse> ResetCells(global::Lifegame.ResetRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for LifeGame</summary>
    public partial class LifeGameClient : grpc::ClientBase<LifeGameClient>
    {
      /// <summary>Creates a new client for LifeGame</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public LifeGameClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for LifeGame that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public LifeGameClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected LifeGameClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected LifeGameClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Lifegame.FieldSizeResponse GetFieldSize(global::Lifegame.FieldSizeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFieldSize(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Lifegame.FieldSizeResponse GetFieldSize(global::Lifegame.FieldSizeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFieldSize, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Lifegame.FieldSizeResponse> GetFieldSizeAsync(global::Lifegame.FieldSizeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFieldSizeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Lifegame.FieldSizeResponse> GetFieldSizeAsync(global::Lifegame.FieldSizeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFieldSize, null, options, request);
      }
      public virtual global::Lifegame.CellsResponse GetCells(global::Lifegame.CellsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCells(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Lifegame.CellsResponse GetCells(global::Lifegame.CellsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCells, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Lifegame.CellsResponse> GetCellsAsync(global::Lifegame.CellsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCellsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Lifegame.CellsResponse> GetCellsAsync(global::Lifegame.CellsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCells, null, options, request);
      }
      public virtual global::Lifegame.UpdateResponse Update(global::Lifegame.UpdateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Update(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Lifegame.UpdateResponse Update(global::Lifegame.UpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Update, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Lifegame.UpdateResponse> UpdateAsync(global::Lifegame.UpdateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Lifegame.UpdateResponse> UpdateAsync(global::Lifegame.UpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Update, null, options, request);
      }
      public virtual global::Lifegame.ResetResponse ResetCells(global::Lifegame.ResetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ResetCells(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Lifegame.ResetResponse ResetCells(global::Lifegame.ResetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ResetCells, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Lifegame.ResetResponse> ResetCellsAsync(global::Lifegame.ResetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ResetCellsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Lifegame.ResetResponse> ResetCellsAsync(global::Lifegame.ResetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ResetCells, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override LifeGameClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new LifeGameClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(LifeGameBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetFieldSize, serviceImpl.GetFieldSize)
          .AddMethod(__Method_GetCells, serviceImpl.GetCells)
          .AddMethod(__Method_Update, serviceImpl.Update)
          .AddMethod(__Method_ResetCells, serviceImpl.ResetCells).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, LifeGameBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetFieldSize, serviceImpl.GetFieldSize);
      serviceBinder.AddMethod(__Method_GetCells, serviceImpl.GetCells);
      serviceBinder.AddMethod(__Method_Update, serviceImpl.Update);
      serviceBinder.AddMethod(__Method_ResetCells, serviceImpl.ResetCells);
    }

  }
}
#endregion
