// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: prediction_service.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Tensorflow.Serving {
  /// <summary>
  /// open source marker; do not remove
  /// PredictionService provides access to machine-learned models loaded by
  /// model_servers.
  /// </summary>
  public static partial class PredictionService
  {
    static readonly string __ServiceName = "tensorflow.serving.PredictionService";

    static readonly grpc::Marshaller<global::Tensorflow.Serving.ClassificationRequest> __Marshaller_ClassificationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tensorflow.Serving.ClassificationRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tensorflow.Serving.ClassificationResponse> __Marshaller_ClassificationResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tensorflow.Serving.ClassificationResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tensorflow.Serving.RegressionRequest> __Marshaller_RegressionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tensorflow.Serving.RegressionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tensorflow.Serving.RegressionResponse> __Marshaller_RegressionResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tensorflow.Serving.RegressionResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tensorflow.Serving.PredictRequest> __Marshaller_PredictRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tensorflow.Serving.PredictRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tensorflow.Serving.PredictResponse> __Marshaller_PredictResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tensorflow.Serving.PredictResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tensorflow.Serving.MultiInferenceRequest> __Marshaller_MultiInferenceRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tensorflow.Serving.MultiInferenceRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tensorflow.Serving.MultiInferenceResponse> __Marshaller_MultiInferenceResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tensorflow.Serving.MultiInferenceResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tensorflow.Serving.GetModelMetadataRequest> __Marshaller_GetModelMetadataRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tensorflow.Serving.GetModelMetadataRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tensorflow.Serving.GetModelMetadataResponse> __Marshaller_GetModelMetadataResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tensorflow.Serving.GetModelMetadataResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Tensorflow.Serving.ClassificationRequest, global::Tensorflow.Serving.ClassificationResponse> __Method_Classify = new grpc::Method<global::Tensorflow.Serving.ClassificationRequest, global::Tensorflow.Serving.ClassificationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Classify",
        __Marshaller_ClassificationRequest,
        __Marshaller_ClassificationResponse);

    static readonly grpc::Method<global::Tensorflow.Serving.RegressionRequest, global::Tensorflow.Serving.RegressionResponse> __Method_Regress = new grpc::Method<global::Tensorflow.Serving.RegressionRequest, global::Tensorflow.Serving.RegressionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Regress",
        __Marshaller_RegressionRequest,
        __Marshaller_RegressionResponse);

    static readonly grpc::Method<global::Tensorflow.Serving.PredictRequest, global::Tensorflow.Serving.PredictResponse> __Method_Predict = new grpc::Method<global::Tensorflow.Serving.PredictRequest, global::Tensorflow.Serving.PredictResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Predict",
        __Marshaller_PredictRequest,
        __Marshaller_PredictResponse);

    static readonly grpc::Method<global::Tensorflow.Serving.MultiInferenceRequest, global::Tensorflow.Serving.MultiInferenceResponse> __Method_MultiInference = new grpc::Method<global::Tensorflow.Serving.MultiInferenceRequest, global::Tensorflow.Serving.MultiInferenceResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MultiInference",
        __Marshaller_MultiInferenceRequest,
        __Marshaller_MultiInferenceResponse);

    static readonly grpc::Method<global::Tensorflow.Serving.GetModelMetadataRequest, global::Tensorflow.Serving.GetModelMetadataResponse> __Method_GetModelMetadata = new grpc::Method<global::Tensorflow.Serving.GetModelMetadataRequest, global::Tensorflow.Serving.GetModelMetadataResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetModelMetadata",
        __Marshaller_GetModelMetadataRequest,
        __Marshaller_GetModelMetadataResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Tensorflow.Serving.PredictionServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PredictionService</summary>
    public abstract partial class PredictionServiceBase
    {
      /// <summary>
      /// Classify.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Tensorflow.Serving.ClassificationResponse> Classify(global::Tensorflow.Serving.ClassificationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Regress.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Tensorflow.Serving.RegressionResponse> Regress(global::Tensorflow.Serving.RegressionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Predict -- provides access to loaded TensorFlow model.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Tensorflow.Serving.PredictResponse> Predict(global::Tensorflow.Serving.PredictRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// MultiInference API for multi-headed models.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Tensorflow.Serving.MultiInferenceResponse> MultiInference(global::Tensorflow.Serving.MultiInferenceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// GetModelMetadata - provides access to metadata for loaded models.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Tensorflow.Serving.GetModelMetadataResponse> GetModelMetadata(global::Tensorflow.Serving.GetModelMetadataRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PredictionService</summary>
    public partial class PredictionServiceClient : grpc::ClientBase<PredictionServiceClient>
    {
      /// <summary>Creates a new client for PredictionService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PredictionServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PredictionService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PredictionServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PredictionServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PredictionServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Classify.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tensorflow.Serving.ClassificationResponse Classify(global::Tensorflow.Serving.ClassificationRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Classify(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Classify.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tensorflow.Serving.ClassificationResponse Classify(global::Tensorflow.Serving.ClassificationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Classify, null, options, request);
      }
      /// <summary>
      /// Classify.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tensorflow.Serving.ClassificationResponse> ClassifyAsync(global::Tensorflow.Serving.ClassificationRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ClassifyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Classify.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tensorflow.Serving.ClassificationResponse> ClassifyAsync(global::Tensorflow.Serving.ClassificationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Classify, null, options, request);
      }
      /// <summary>
      /// Regress.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tensorflow.Serving.RegressionResponse Regress(global::Tensorflow.Serving.RegressionRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Regress(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Regress.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tensorflow.Serving.RegressionResponse Regress(global::Tensorflow.Serving.RegressionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Regress, null, options, request);
      }
      /// <summary>
      /// Regress.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tensorflow.Serving.RegressionResponse> RegressAsync(global::Tensorflow.Serving.RegressionRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RegressAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Regress.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tensorflow.Serving.RegressionResponse> RegressAsync(global::Tensorflow.Serving.RegressionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Regress, null, options, request);
      }
      /// <summary>
      /// Predict -- provides access to loaded TensorFlow model.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tensorflow.Serving.PredictResponse Predict(global::Tensorflow.Serving.PredictRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Predict(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Predict -- provides access to loaded TensorFlow model.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tensorflow.Serving.PredictResponse Predict(global::Tensorflow.Serving.PredictRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Predict, null, options, request);
      }
      /// <summary>
      /// Predict -- provides access to loaded TensorFlow model.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tensorflow.Serving.PredictResponse> PredictAsync(global::Tensorflow.Serving.PredictRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PredictAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Predict -- provides access to loaded TensorFlow model.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tensorflow.Serving.PredictResponse> PredictAsync(global::Tensorflow.Serving.PredictRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Predict, null, options, request);
      }
      /// <summary>
      /// MultiInference API for multi-headed models.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tensorflow.Serving.MultiInferenceResponse MultiInference(global::Tensorflow.Serving.MultiInferenceRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MultiInference(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// MultiInference API for multi-headed models.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tensorflow.Serving.MultiInferenceResponse MultiInference(global::Tensorflow.Serving.MultiInferenceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MultiInference, null, options, request);
      }
      /// <summary>
      /// MultiInference API for multi-headed models.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tensorflow.Serving.MultiInferenceResponse> MultiInferenceAsync(global::Tensorflow.Serving.MultiInferenceRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MultiInferenceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// MultiInference API for multi-headed models.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tensorflow.Serving.MultiInferenceResponse> MultiInferenceAsync(global::Tensorflow.Serving.MultiInferenceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MultiInference, null, options, request);
      }
      /// <summary>
      /// GetModelMetadata - provides access to metadata for loaded models.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tensorflow.Serving.GetModelMetadataResponse GetModelMetadata(global::Tensorflow.Serving.GetModelMetadataRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetModelMetadata(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GetModelMetadata - provides access to metadata for loaded models.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tensorflow.Serving.GetModelMetadataResponse GetModelMetadata(global::Tensorflow.Serving.GetModelMetadataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetModelMetadata, null, options, request);
      }
      /// <summary>
      /// GetModelMetadata - provides access to metadata for loaded models.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tensorflow.Serving.GetModelMetadataResponse> GetModelMetadataAsync(global::Tensorflow.Serving.GetModelMetadataRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetModelMetadataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GetModelMetadata - provides access to metadata for loaded models.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tensorflow.Serving.GetModelMetadataResponse> GetModelMetadataAsync(global::Tensorflow.Serving.GetModelMetadataRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetModelMetadata, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PredictionServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PredictionServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PredictionServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Classify, serviceImpl.Classify)
          .AddMethod(__Method_Regress, serviceImpl.Regress)
          .AddMethod(__Method_Predict, serviceImpl.Predict)
          .AddMethod(__Method_MultiInference, serviceImpl.MultiInference)
          .AddMethod(__Method_GetModelMetadata, serviceImpl.GetModelMetadata).Build();
    }

  }
}
#endregion