/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    public interface IGetSetVerticesData { }
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class IGetSetVerticesDataCachedEntity : CachedEntityObject, IGetSetVerticesData
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties

        #endregion
        
        #region Constructor
        public IGetSetVerticesDataCachedEntity() : base() { }

        public IGetSetVerticesDataCachedEntity(
            ICachedEntity entity
        ) : base(entity)
        {
        }


        #endregion

        #region Methods
        public bool isVerticesDataPresent(string kind)
        {
            return EventHorizonBlazorInteropt.Func<bool>(
                new object[] 
                {
                    new string[] { this.___guid, "isVerticesDataPresent" }, kind
                }
            );
        }

        public decimal[] getVerticesData(string kind, System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getVerticesData" }, kind, copyWhenShared, forceCopy
                }
            );
        }

        public decimal[] getIndices(System.Nullable<bool> copyWhenShared = null, System.Nullable<bool> forceCopy = null)
        {
            return EventHorizonBlazorInteropt.FuncArray<decimal>(
                new object[]
                {
                    new string[] { this.___guid, "getIndices" }, copyWhenShared, forceCopy
                }
            );
        }

        public void setVerticesData(string kind, decimal[] data, bool updatable)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setVerticesData" }, kind, data, updatable
                }
            );
        }

        public void updateVerticesData(string kind, decimal[] data, System.Nullable<bool> updateExtends = null, System.Nullable<bool> makeItUnique = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "updateVerticesData" }, kind, data, updateExtends, makeItUnique
                }
            );
        }

        public void setIndices(decimal[] indices, decimal totalVertices, System.Nullable<bool> updatable = null)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "setIndices" }, indices, totalVertices, updatable
                }
            );
        }
        #endregion
    }
}