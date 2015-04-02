﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbim.COBieLiteUK;
using Xbim.CobieLiteUK.Validation.Extensions;

namespace Xbim.CobieLiteUK.Validation.Reporting
{
    public class AssetTypeRequirementPointer
    {
        public readonly string ExternalId;
        public readonly string ExternalSystem;

        public AssetTypeRequirementPointer(string externalSystem, string externalId)
        {
            ExternalId = externalId;
            ExternalSystem = externalSystem;
        }

        public override bool Equals(System.Object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to AssetTypeRequirementPointer return false.
            var p = obj as AssetTypeRequirementPointer;
            if ((System.Object)p == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (ExternalId == p.ExternalId) && (ExternalSystem == p.ExternalSystem);
        }

        public override int GetHashCode()
        {
            return (ExternalId + ExternalSystem).GetHashCode();
        }

        public List<AssetType> ProvidedAssetTypes = new List<AssetType>();

        public void AddSumission(AssetType providedAsset)
        {
            ProvidedAssetTypes.Add(providedAsset);
        }

        internal int GetSubmittedAssetsCount()
        {
            return ProvidedAssetTypes.Sum(providedAsset => providedAsset.GetSubmittedAssetsCount());
        }

        public string Name { get; set; }

        public IEnumerable<Asset> Assets()
        {
            return 
                from providedAsset in ProvidedAssetTypes 
                where providedAsset.Assets != null 
                from asset in providedAsset.Assets 
                select asset;
        }
    }
}