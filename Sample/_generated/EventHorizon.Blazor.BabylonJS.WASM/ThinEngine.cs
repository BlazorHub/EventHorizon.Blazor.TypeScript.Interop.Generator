/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class ThinEngine : CachedEntityObject
    {
        #region Static Accessors
        
        public static string NpmPackage
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "ThinEngine.NpmPackage"
                );
            }
        }

        
        public static string Version
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "ThinEngine.Version"
                );
            }
        }

        
        public static string ShadersRepository
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    "BABYLON",
                    "ThinEngine.ShadersRepository"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    "ThinEngine.ShadersRepository",
                    value
                );
            }
        }
        #endregion

        #region Static Properties
        
        public static CachedEntity[] ExceptionList
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<CachedEntity>(
                    "BABYLON",
                    ".ThinEngine.ExceptionList"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    ".ThinEngine.ExceptionList",
                    value
                );
            }
        }

        
        public static decimal CollisionsEpsilon
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    "BABYLON",
                    ".ThinEngine.CollisionsEpsilon"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    "BABYLON",
                    ".ThinEngine.CollisionsEpsilon",
                    value
                );
            }
        }
        #endregion

        #region Static Methods
        public static bool isSupported()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { "BABYLON", "ThinEngine", "isSupported" }
                }
            );
        }

        public static decimal CeilingPOT(decimal x)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "ThinEngine", "CeilingPOT" }, x
                }
            );
        }

        public static decimal FloorPOT(decimal x)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "ThinEngine", "FloorPOT" }, x
                }
            );
        }

        public static decimal NearestPOT(decimal x)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "ThinEngine", "NearestPOT" }, x
                }
            );
        }

        public static decimal GetExponentOfTwo(decimal value, decimal max, System.Nullable<decimal> mode = null)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { "BABYLON", "ThinEngine", "GetExponentOfTwo" }, value, max, mode
                }
            );
        }

        #region QueueNewFrame TODO: Get Comments as metadata identification
        private static bool IsQueueNewFrameEnabled = false;
        private static readonly IDictionary<string, Func<Task>> QueueNewFrameActionMap = new Dictionary<string, Func<Task>>();

        public static string QueueNewFrame(
            Func<Task> callback
        )
        {
            SetupQueueNewFrameStaticLoop();

            var handle = Guid.NewGuid().ToString();
            QueueNewFrameActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private static void SetupQueueNewFrameStaticLoop()
        {
            if (IsQueueNewFrameEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.AssemblyFuncCallback(
                "EventHorizon.Blazor.BabylonJS.WASM",
                "BABYLON.ThinEngine.QueueNewFrame",
                "CallQueueNewFrameStaticActions"
            );
            IsQueueNewFrameEnabled = true;
        }

        [JSInvokable]
        public static async Task CallQueueNewFrameStaticActions()
        {
            foreach (var action in QueueNewFrameActionMap.Values)
            {
                await action();
            }
        }
        #endregion
        #endregion

        #region Accessors
        
        public string description
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "description"
                );
            }
        }

        
        public bool supportsUniformBuffers
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "supportsUniformBuffers"
                );
            }
        }

        
        public bool needPOTTextures
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "needPOTTextures"
                );
            }
        }

        
        public bool doNotHandleContextLost
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "doNotHandleContextLost"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "doNotHandleContextLost",
                    value
                );
            }
        }

        
        public string[] texturesSupported
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<string>(
                    this.___guid,
                    "texturesSupported"
                );
            }
        }

        
        public string textureFormatInUse
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<string>(
                    this.___guid,
                    "textureFormatInUse"
                );
            }
        }

        private IViewportLike __currentViewport;
        public IViewportLike currentViewport
        {
            get
            {
            if(__currentViewport == null)
            {
                __currentViewport = EventHorizonBlazorInteropt.GetClass<IViewportLike>(
                    this.___guid,
                    "currentViewport",
                    (entity) =>
                    {
                        return new IViewportLikeCachedEntity(entity);
                    }
                );
            }
            return __currentViewport;
            }
        }

        private InternalTexture __emptyTexture;
        public InternalTexture emptyTexture
        {
            get
            {
            if(__emptyTexture == null)
            {
                __emptyTexture = EventHorizonBlazorInteropt.GetClass<InternalTexture>(
                    this.___guid,
                    "emptyTexture",
                    (entity) =>
                    {
                        return new InternalTexture(entity);
                    }
                );
            }
            return __emptyTexture;
            }
        }

        private InternalTexture __emptyTexture3D;
        public InternalTexture emptyTexture3D
        {
            get
            {
            if(__emptyTexture3D == null)
            {
                __emptyTexture3D = EventHorizonBlazorInteropt.GetClass<InternalTexture>(
                    this.___guid,
                    "emptyTexture3D",
                    (entity) =>
                    {
                        return new InternalTexture(entity);
                    }
                );
            }
            return __emptyTexture3D;
            }
        }

        private InternalTexture __emptyTexture2DArray;
        public InternalTexture emptyTexture2DArray
        {
            get
            {
            if(__emptyTexture2DArray == null)
            {
                __emptyTexture2DArray = EventHorizonBlazorInteropt.GetClass<InternalTexture>(
                    this.___guid,
                    "emptyTexture2DArray",
                    (entity) =>
                    {
                        return new InternalTexture(entity);
                    }
                );
            }
            return __emptyTexture2DArray;
            }
        }

        private InternalTexture __emptyCubeTexture;
        public InternalTexture emptyCubeTexture
        {
            get
            {
            if(__emptyCubeTexture == null)
            {
                __emptyCubeTexture = EventHorizonBlazorInteropt.GetClass<InternalTexture>(
                    this.___guid,
                    "emptyCubeTexture",
                    (entity) =>
                    {
                        return new InternalTexture(entity);
                    }
                );
            }
            return __emptyCubeTexture;
            }
        }

        
        public decimal webGLVersion
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "webGLVersion"
                );
            }
        }

        
        public bool isStencilEnable
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isStencilEnable"
                );
            }
        }

        private DepthCullingState __depthCullingState;
        public DepthCullingState depthCullingState
        {
            get
            {
            if(__depthCullingState == null)
            {
                __depthCullingState = EventHorizonBlazorInteropt.GetClass<DepthCullingState>(
                    this.___guid,
                    "depthCullingState",
                    (entity) =>
                    {
                        return new DepthCullingState(entity);
                    }
                );
            }
            return __depthCullingState;
            }
        }

        private AlphaState __alphaState;
        public AlphaState alphaState
        {
            get
            {
            if(__alphaState == null)
            {
                __alphaState = EventHorizonBlazorInteropt.GetClass<AlphaState>(
                    this.___guid,
                    "alphaState",
                    (entity) =>
                    {
                        return new AlphaState(entity);
                    }
                );
            }
            return __alphaState;
            }
        }

        private StencilState __stencilState;
        public StencilState stencilState
        {
            get
            {
            if(__stencilState == null)
            {
                __stencilState = EventHorizonBlazorInteropt.GetClass<StencilState>(
                    this.___guid,
                    "stencilState",
                    (entity) =>
                    {
                        return new StencilState(entity);
                    }
                );
            }
            return __stencilState;
            }
        }
        #endregion

        #region Properties
        
        public bool forcePOTTextures
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "forcePOTTextures"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "forcePOTTextures",
                    value
                );
            }
        }

        
        public bool isFullscreen
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "isFullscreen"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "isFullscreen",
                    value
                );
            }
        }

        
        public bool cullBackFaces
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "cullBackFaces"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "cullBackFaces",
                    value
                );
            }
        }

        
        public bool renderEvenInBackground
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "renderEvenInBackground"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "renderEvenInBackground",
                    value
                );
            }
        }

        
        public bool preventCacheWipeBetweenFrames
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "preventCacheWipeBetweenFrames"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "preventCacheWipeBetweenFrames",
                    value
                );
            }
        }

        
        public bool validateShaderPrograms
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "validateShaderPrograms"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "validateShaderPrograms",
                    value
                );
            }
        }

        
        public bool useReverseDepthBuffer
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "useReverseDepthBuffer"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "useReverseDepthBuffer",
                    value
                );
            }
        }

        
        public bool disableUniformBuffers
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "disableUniformBuffers"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "disableUniformBuffers",
                    value
                );
            }
        }

        private Observable __onContextLostObservable;
        public Observable onContextLostObservable
        {
            get
            {
            if(__onContextLostObservable == null)
            {
                __onContextLostObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onContextLostObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onContextLostObservable;
            }
            set
            {
__onContextLostObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onContextLostObservable",
                    value
                );
            }
        }

        private Observable __onContextRestoredObservable;
        public Observable onContextRestoredObservable
        {
            get
            {
            if(__onContextRestoredObservable == null)
            {
                __onContextRestoredObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onContextRestoredObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onContextRestoredObservable;
            }
            set
            {
__onContextRestoredObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onContextRestoredObservable",
                    value
                );
            }
        }

        
        public bool disableVertexArrayObjects
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "disableVertexArrayObjects"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "disableVertexArrayObjects",
                    value
                );
            }
        }

        
        public bool premultipliedAlpha
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "premultipliedAlpha"
                );
            }
        }

        private Observable __onBeforeTextureInitObservable;
        public Observable onBeforeTextureInitObservable
        {
            get
            {
            if(__onBeforeTextureInitObservable == null)
            {
                __onBeforeTextureInitObservable = EventHorizonBlazorInteropt.GetClass<Observable>(
                    this.___guid,
                    "onBeforeTextureInitObservable",
                    (entity) =>
                    {
                        return new Observable(entity);
                    }
                );
            }
            return __onBeforeTextureInitObservable;
            }
            set
            {
__onBeforeTextureInitObservable = null;
                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "onBeforeTextureInitObservable",
                    value
                );
            }
        }

        
        public bool enableUnpackFlipYCached
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "enableUnpackFlipYCached"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "enableUnpackFlipYCached",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public ThinEngine() : base() { } 

        public ThinEngine(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public ThinEngine(
            object canvasOrContext, System.Nullable<bool> antialias = null, EngineOptions options = null, System.Nullable<bool> adaptToDeviceRatio = null
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "ThinEngine" },
                canvasOrContext, antialias, options, adaptToDeviceRatio
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public bool areAllEffectsReady()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "areAllEffectsReady" }
                }
            );
        }

        public string getClassName()
        {
            return EventHorizonBlazorInteropt.Func<string>(
                new object[] 
                {
                    new string[] { this.___guid, "getClassName" }
                }
            );
        }

        public void resetTextureCache()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resetTextureCache" }
                }
            );
        }

        public CachedEntity getGlInfo()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "getGlInfo" }
                }
            );
        }

        public void setHardwareScalingLevel(decimal level)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setHardwareScalingLevel" }, level
                }
            );
        }

        public decimal getHardwareScalingLevel()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getHardwareScalingLevel" }
                }
            );
        }

        public InternalTexture[] getLoadedTexturesCache()
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<InternalTexture>(
                entity => new InternalTexture(entity),
                new object[]
                {
                    new string[] { this.___guid, "getLoadedTexturesCache" }
                }
            );
        }

        public EngineCapabilities getCaps()
        {
            return EventHorizonBlazorInteropt.FuncClass<EngineCapabilities>(
                entity => new EngineCapabilitiesCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getCaps" }
                }
            );
        }

        #region stopRenderLoop TODO: Get Comments as metadata identification
        private bool _isStopRenderLoopEnabled = false;
        private readonly IDictionary<string, Func<Task>> _stopRenderLoopActionMap = new Dictionary<string, Func<Task>>();

        public string stopRenderLoop(
            Func<Task> callback
        )
        {
            SetupStopRenderLoopLoop();

            var handle = Guid.NewGuid().ToString();
            _stopRenderLoopActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupStopRenderLoopLoop()
        {
            if (_isStopRenderLoopEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "stopRenderLoop",
                "CallStopRenderLoopActions",
                _invokableReference
            );
            _isStopRenderLoopEnabled = true;
        }

        [JSInvokable]
        public async Task CallStopRenderLoopActions()
        {
            foreach (var action in _stopRenderLoopActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public HTMLCanvasElement getRenderingCanvas()
        {
            return EventHorizonBlazorInteropt.FuncClass<HTMLCanvasElement>(
                entity => new HTMLCanvasElementCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getRenderingCanvas" }
                }
            );
        }

        public Window getHostWindow()
        {
            return EventHorizonBlazorInteropt.FuncClass<Window>(
                entity => new WindowCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getHostWindow" }
                }
            );
        }

        public decimal getRenderWidth(System.Nullable<bool> useScreen = null)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getRenderWidth" }, useScreen
                }
            );
        }

        public decimal getRenderHeight(System.Nullable<bool> useScreen = null)
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getRenderHeight" }, useScreen
                }
            );
        }

        #region runRenderLoop TODO: Get Comments as metadata identification
        private bool _isRunRenderLoopEnabled = false;
        private readonly IDictionary<string, Func<Task>> _runRenderLoopActionMap = new Dictionary<string, Func<Task>>();

        public string runRenderLoop(
            Func<Task> callback
        )
        {
            SetupRunRenderLoopLoop();

            var handle = Guid.NewGuid().ToString();
            _runRenderLoopActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupRunRenderLoopLoop()
        {
            if (_isRunRenderLoopEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "runRenderLoop",
                "CallRunRenderLoopActions",
                _invokableReference
            );
            _isRunRenderLoopEnabled = true;
        }

        [JSInvokable]
        public async Task CallRunRenderLoopActions()
        {
            foreach (var action in _runRenderLoopActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void clear(IColor4Like color, bool backBuffer, bool depth, System.Nullable<bool> stencil = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "clear" }, color, backBuffer, depth, stencil
                }
            );
        }

        public void setViewport(IViewportLike viewport, System.Nullable<decimal> requiredWidth = null, System.Nullable<decimal> requiredHeight = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setViewport" }, viewport, requiredWidth, requiredHeight
                }
            );
        }

        public void beginFrame()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "beginFrame" }
                }
            );
        }

        public void endFrame()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "endFrame" }
                }
            );
        }

        public void resize()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "resize" }
                }
            );
        }

        public void setSize(decimal width, decimal height)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setSize" }, width, height
                }
            );
        }

        public void bindFramebuffer(InternalTexture texture, System.Nullable<decimal> faceIndex = null, System.Nullable<decimal> requiredWidth = null, System.Nullable<decimal> requiredHeight = null, System.Nullable<bool> forceFullscreenViewport = null, System.Nullable<decimal> lodLevel = null, System.Nullable<decimal> layer = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindFramebuffer" }, texture, faceIndex, requiredWidth, requiredHeight, forceFullscreenViewport, lodLevel, layer
                }
            );
        }

        #region unBindFramebuffer TODO: Get Comments as metadata identification
        private bool _isUnBindFramebufferEnabled = false;
        private readonly IDictionary<string, Func<Task>> _unBindFramebufferActionMap = new Dictionary<string, Func<Task>>();

        public string unBindFramebuffer(
            Func<Task> callback
        )
        {
            SetupUnBindFramebufferLoop();

            var handle = Guid.NewGuid().ToString();
            _unBindFramebufferActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupUnBindFramebufferLoop()
        {
            if (_isUnBindFramebufferEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "unBindFramebuffer",
                "CallUnBindFramebufferActions",
                _invokableReference
            );
            _isUnBindFramebufferEnabled = true;
        }

        [JSInvokable]
        public async Task CallUnBindFramebufferActions()
        {
            foreach (var action in _unBindFramebufferActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public void flushFramebuffer()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "flushFramebuffer" }
                }
            );
        }

        public void restoreDefaultFramebuffer()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "restoreDefaultFramebuffer" }
                }
            );
        }

        public DataBuffer createVertexBuffer(DataArray data)
        {
            return EventHorizonBlazorInteropt.FuncClass<DataBuffer>(
                entity => new DataBuffer(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createVertexBuffer" }, data
                }
            );
        }

        public DataBuffer createDynamicVertexBuffer(DataArray data)
        {
            return EventHorizonBlazorInteropt.FuncClass<DataBuffer>(
                entity => new DataBuffer(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createDynamicVertexBuffer" }, data
                }
            );
        }

        public DataBuffer createIndexBuffer(decimal[] indices, System.Nullable<bool> updatable = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<DataBuffer>(
                entity => new DataBuffer(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createIndexBuffer" }, indices, updatable
                }
            );
        }

        public void bindArrayBuffer(DataBuffer buffer)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindArrayBuffer" }, buffer
                }
            );
        }

        public void updateArrayBuffer(decimal[] data)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateArrayBuffer" }, data
                }
            );
        }

        public WebGLVertexArrayObject recordVertexArrayObject(object vertexBuffers, DataBuffer indexBuffer, Effect effect)
        {
            return EventHorizonBlazorInteropt.FuncClass<WebGLVertexArrayObject>(
                entity => new WebGLVertexArrayObjectCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "recordVertexArrayObject" }, vertexBuffers, indexBuffer, effect
                }
            );
        }

        public void bindVertexArrayObject(WebGLVertexArrayObject vertexArrayObject, DataBuffer indexBuffer)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindVertexArrayObject" }, vertexArrayObject, indexBuffer
                }
            );
        }

        public void bindBuffersDirectly(DataBuffer vertexBuffer, DataBuffer indexBuffer, decimal[] vertexDeclaration, decimal vertexStrideSize, Effect effect)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindBuffersDirectly" }, vertexBuffer, indexBuffer, vertexDeclaration, vertexStrideSize, effect
                }
            );
        }

        public void bindBuffers(object vertexBuffers, DataBuffer indexBuffer, Effect effect)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindBuffers" }, vertexBuffers, indexBuffer, effect
                }
            );
        }

        public void unbindInstanceAttributes()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unbindInstanceAttributes" }
                }
            );
        }

        public void releaseVertexArrayObject(WebGLVertexArrayObject vao)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "releaseVertexArrayObject" }, vao
                }
            );
        }

        public void updateAndBindInstancesBuffer(DataBuffer instancesBuffer, decimal[] data, decimal offsetLocations)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateAndBindInstancesBuffer" }, instancesBuffer, data, offsetLocations
                }
            );
        }

        public void bindInstancesBuffer(DataBuffer instancesBuffer, InstancingAttributeInfo[] attributesInfo, System.Nullable<bool> computeStride = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindInstancesBuffer" }, instancesBuffer, attributesInfo, computeStride
                }
            );
        }

        public void disableInstanceAttributeByName(string name)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "disableInstanceAttributeByName" }, name
                }
            );
        }

        public void disableInstanceAttribute(decimal attributeLocation)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "disableInstanceAttribute" }, attributeLocation
                }
            );
        }

        public void disableAttributeByIndex(decimal attributeLocation)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "disableAttributeByIndex" }, attributeLocation
                }
            );
        }

        public void draw(bool useTriangles, decimal indexStart, decimal indexCount, System.Nullable<decimal> instancesCount = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "draw" }, useTriangles, indexStart, indexCount, instancesCount
                }
            );
        }

        public void drawPointClouds(decimal verticesStart, decimal verticesCount, System.Nullable<decimal> instancesCount = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "drawPointClouds" }, verticesStart, verticesCount, instancesCount
                }
            );
        }

        public void drawUnIndexed(bool useTriangles, decimal verticesStart, decimal verticesCount, System.Nullable<decimal> instancesCount = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "drawUnIndexed" }, useTriangles, verticesStart, verticesCount, instancesCount
                }
            );
        }

        public void drawElementsType(decimal fillMode, decimal indexStart, decimal indexCount, System.Nullable<decimal> instancesCount = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "drawElementsType" }, fillMode, indexStart, indexCount, instancesCount
                }
            );
        }

        public void drawArraysType(decimal fillMode, decimal verticesStart, decimal verticesCount, System.Nullable<decimal> instancesCount = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "drawArraysType" }, fillMode, verticesStart, verticesCount, instancesCount
                }
            );
        }

        public Effect createEffect(object baseName, string attributesNamesOrOptions, string uniformsNamesOrEngine, string[] samplers = null, string defines = null, IEffectFallbacks fallbacks = null, Effect onCompiled = null, Effect onError = null, object indexParameters = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<Effect>(
                entity => new Effect(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createEffect" }, baseName, attributesNamesOrOptions, uniformsNamesOrEngine, samplers, defines, fallbacks, onCompiled, onError, indexParameters
                }
            );
        }

        public WebGLProgram createRawShaderProgram(IPipelineContext pipelineContext, string vertexCode, string fragmentCode, WebGLRenderingContext context = null, string[] transformFeedbackVaryings = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<WebGLProgram>(
                entity => new WebGLProgramCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createRawShaderProgram" }, pipelineContext, vertexCode, fragmentCode, context, transformFeedbackVaryings
                }
            );
        }

        public WebGLProgram createShaderProgram(IPipelineContext pipelineContext, string vertexCode, string fragmentCode, string defines, WebGLRenderingContext context = null, string[] transformFeedbackVaryings = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<WebGLProgram>(
                entity => new WebGLProgramCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createShaderProgram" }, pipelineContext, vertexCode, fragmentCode, defines, context, transformFeedbackVaryings
                }
            );
        }

        public IPipelineContext createPipelineContext()
        {
            return EventHorizonBlazorInteropt.FuncClass<IPipelineContext>(
                entity => new IPipelineContextCachedEntity(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createPipelineContext" }
                }
            );
        }

        public WebGLUniformLocation[] getUniforms(IPipelineContext pipelineContext, string[] uniformsNames)
        {
            return EventHorizonBlazorInteropt.FuncArrayClass<WebGLUniformLocation>(
                entity => new WebGLUniformLocationCachedEntity(entity),
                new object[]
                {
                    new string[] { this.___guid, "getUniforms" }, pipelineContext, uniformsNames
                }
            );
        }

        public decimal[] getAttributes(IPipelineContext pipelineContext, string[] attributesNames)
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getAttributes" }, pipelineContext, attributesNames
                }
            );
        }

        public void enableEffect(Effect effect)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "enableEffect" }, effect
                }
            );
        }

        public void setInt(WebGLUniformLocation uniform, decimal value)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setInt" }, uniform, value
                }
            );
        }

        public void setIntArray(WebGLUniformLocation uniform, Int32Array array)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setIntArray" }, uniform, array
                }
            );
        }

        public void setIntArray2(WebGLUniformLocation uniform, Int32Array array)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setIntArray2" }, uniform, array
                }
            );
        }

        public void setIntArray3(WebGLUniformLocation uniform, Int32Array array)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setIntArray3" }, uniform, array
                }
            );
        }

        public void setIntArray4(WebGLUniformLocation uniform, Int32Array array)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setIntArray4" }, uniform, array
                }
            );
        }

        public void setArray(WebGLUniformLocation uniform, decimal array)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setArray" }, uniform, array
                }
            );
        }

        public void setArray2(WebGLUniformLocation uniform, decimal array)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setArray2" }, uniform, array
                }
            );
        }

        public void setArray3(WebGLUniformLocation uniform, decimal array)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setArray3" }, uniform, array
                }
            );
        }

        public void setArray4(WebGLUniformLocation uniform, decimal array)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setArray4" }, uniform, array
                }
            );
        }

        public void setMatrices(WebGLUniformLocation uniform, decimal[] matrices)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setMatrices" }, uniform, matrices
                }
            );
        }

        public void setMatrix3x3(WebGLUniformLocation uniform, decimal[] matrix)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setMatrix3x3" }, uniform, matrix
                }
            );
        }

        public void setMatrix2x2(WebGLUniformLocation uniform, decimal[] matrix)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setMatrix2x2" }, uniform, matrix
                }
            );
        }

        public void setFloat(WebGLUniformLocation uniform, decimal value)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setFloat" }, uniform, value
                }
            );
        }

        public void setFloat2(WebGLUniformLocation uniform, decimal x, decimal y)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setFloat2" }, uniform, x, y
                }
            );
        }

        public void setFloat3(WebGLUniformLocation uniform, decimal x, decimal y, decimal z)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setFloat3" }, uniform, x, y, z
                }
            );
        }

        public void setFloat4(WebGLUniformLocation uniform, decimal x, decimal y, decimal z, decimal w)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setFloat4" }, uniform, x, y, z, w
                }
            );
        }

        public void applyStates()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "applyStates" }
                }
            );
        }

        public void setColorWrite(bool enable)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setColorWrite" }, enable
                }
            );
        }

        public bool getColorWrite()
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "getColorWrite" }
                }
            );
        }

        public void clearInternalTexturesCache()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "clearInternalTexturesCache" }
                }
            );
        }

        public void wipeCaches(System.Nullable<bool> bruteForce = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "wipeCaches" }, bruteForce
                }
            );
        }

        #region createTexture TODO: Get Comments as metadata identification
        private bool _isCreateTextureEnabled = false;
        private readonly IDictionary<string, Func<Task>> _createTextureActionMap = new Dictionary<string, Func<Task>>();

        public string createTexture(
            Func<Task> callback
        )
        {
            SetupCreateTextureLoop();

            var handle = Guid.NewGuid().ToString();
            _createTextureActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupCreateTextureLoop()
        {
            if (_isCreateTextureEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "createTexture",
                "CallCreateTextureActions",
                _invokableReference
            );
            _isCreateTextureEnabled = true;
        }

        [JSInvokable]
        public async Task CallCreateTextureActions()
        {
            foreach (var action in _createTextureActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public InternalTexture createRawTexture(ArrayBufferView data, decimal width, decimal height, decimal format, bool generateMipMaps, bool invertY, decimal samplingMode, string compression = null, System.Nullable<decimal> type = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<InternalTexture>(
                entity => new InternalTexture(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createRawTexture" }, data, width, height, format, generateMipMaps, invertY, samplingMode, compression, type
                }
            );
        }

        public InternalTexture createRawCubeTexture(ArrayBufferView[] data, decimal size, decimal format, decimal type, bool generateMipMaps, bool invertY, decimal samplingMode, string compression = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<InternalTexture>(
                entity => new InternalTexture(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createRawCubeTexture" }, data, size, format, type, generateMipMaps, invertY, samplingMode, compression
                }
            );
        }

        public InternalTexture createRawTexture3D(ArrayBufferView data, decimal width, decimal height, decimal depth, decimal format, bool generateMipMaps, bool invertY, decimal samplingMode, string compression = null, System.Nullable<decimal> textureType = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<InternalTexture>(
                entity => new InternalTexture(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createRawTexture3D" }, data, width, height, depth, format, generateMipMaps, invertY, samplingMode, compression, textureType
                }
            );
        }

        public InternalTexture createRawTexture2DArray(ArrayBufferView data, decimal width, decimal height, decimal depth, decimal format, bool generateMipMaps, bool invertY, decimal samplingMode, string compression = null, System.Nullable<decimal> textureType = null)
        {
            return EventHorizonBlazorInteropt.FuncClass<InternalTexture>(
                entity => new InternalTexture(entity),
                new object[] 
                {
                    new string[] { this.___guid, "createRawTexture2DArray" }, data, width, height, depth, format, generateMipMaps, invertY, samplingMode, compression, textureType
                }
            );
        }

        public void updateTextureSamplingMode(decimal samplingMode, InternalTexture texture, System.Nullable<bool> generateMipMaps = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateTextureSamplingMode" }, samplingMode, texture, generateMipMaps
                }
            );
        }

        public void updateTextureWrappingMode(InternalTexture texture, decimal wrapU, System.Nullable<decimal> wrapV = null, System.Nullable<decimal> wrapR = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateTextureWrappingMode" }, texture, wrapU, wrapV, wrapR
                }
            );
        }

        public void updateTextureData(InternalTexture texture, ArrayBufferView imageData, decimal xOffset, decimal yOffset, decimal width, decimal height, System.Nullable<decimal> faceIndex = null, System.Nullable<decimal> lod = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateTextureData" }, texture, imageData, xOffset, yOffset, width, height, faceIndex, lod
                }
            );
        }

        public void bindSamplers(Effect effect)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "bindSamplers" }, effect
                }
            );
        }

        public void unbindAllTextures()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unbindAllTextures" }
                }
            );
        }

        public void setTexture(decimal channel, WebGLUniformLocation uniform, BaseTexture texture)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTexture" }, channel, uniform, texture
                }
            );
        }

        public void setTextureArray(decimal channel, WebGLUniformLocation uniform, BaseTexture[] textures)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setTextureArray" }, channel, uniform, textures
                }
            );
        }

        public void unbindAllAttributes()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "unbindAllAttributes" }
                }
            );
        }

        public void releaseEffects()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "releaseEffects" }
                }
            );
        }

        public void dispose()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "dispose" }
                }
            );
        }

        #region attachContextLostEvent TODO: Get Comments as metadata identification
        private bool _isAttachContextLostEventEnabled = false;
        private readonly IDictionary<string, Func<Task>> _attachContextLostEventActionMap = new Dictionary<string, Func<Task>>();

        public string attachContextLostEvent(
            Func<Task> callback
        )
        {
            SetupAttachContextLostEventLoop();

            var handle = Guid.NewGuid().ToString();
            _attachContextLostEventActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupAttachContextLostEventLoop()
        {
            if (_isAttachContextLostEventEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "attachContextLostEvent",
                "CallAttachContextLostEventActions",
                _invokableReference
            );
            _isAttachContextLostEventEnabled = true;
        }

        [JSInvokable]
        public async Task CallAttachContextLostEventActions()
        {
            foreach (var action in _attachContextLostEventActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        #region attachContextRestoredEvent TODO: Get Comments as metadata identification
        private bool _isAttachContextRestoredEventEnabled = false;
        private readonly IDictionary<string, Func<Task>> _attachContextRestoredEventActionMap = new Dictionary<string, Func<Task>>();

        public string attachContextRestoredEvent(
            Func<Task> callback
        )
        {
            SetupAttachContextRestoredEventLoop();

            var handle = Guid.NewGuid().ToString();
            _attachContextRestoredEventActionMap.Add(
                handle,
                callback
            );

            return handle;
        }

        private void SetupAttachContextRestoredEventLoop()
        {
            if (_isAttachContextRestoredEventEnabled)
            {
                return;
            }
            EventHorizonBlazorInteropt.FuncCallback(
                this,
                "attachContextRestoredEvent",
                "CallAttachContextRestoredEventActions",
                _invokableReference
            );
            _isAttachContextRestoredEventEnabled = true;
        }

        [JSInvokable]
        public async Task CallAttachContextRestoredEventActions()
        {
            foreach (var action in _attachContextRestoredEventActionMap.Values)
            {
                await action();
            }
        }
        #endregion

        public decimal getError()
        {
            return EventHorizonBlazorInteropt.Func<decimal>(
                new object[] 
                {
                    new string[] { this.___guid, "getError" }
                }
            );
        }

        public decimal[] readPixels(decimal x, decimal y, decimal width, decimal height, System.Nullable<bool> hasAlpha = null)
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "readPixels" }, x, y, width, height, hasAlpha
                }
            );
        }

        public Document getHostDocument()
        {
            return EventHorizonBlazorInteropt.FuncClass<Document>(
                entity => new Document(entity),
                new object[] 
                {
                    new string[] { this.___guid, "getHostDocument" }
                }
            );
        }
        #endregion
    }
}