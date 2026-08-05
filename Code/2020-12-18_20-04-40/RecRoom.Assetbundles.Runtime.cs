using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Async;
using RecRoom.DataStructures.ResourceHandles;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.AssetBundles
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AGAddressableAssetCache : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class CachedAddressableAsset : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			private IResourceHandle cachedHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private object runtimeKey;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private int requestCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private UnityEngine.Object cachedObject;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public int RequestCount
			{
				[Cpp2IlInjected.Token(Token = "0x6000008")]
				[Cpp2IlInjected.Address(RVA = "0x443960", Offset = "0x442B60", VA = "0x180443960")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public UnityEngine.Object CachedObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000009")]
				[Cpp2IlInjected.Address(RVA = "0x3B1980", Offset = "0x3B0B80", VA = "0x1803B1980")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x13AB7E0", Offset = "0x13AA9E0", VA = "0x1813AB7E0")]
			public static CachedAddressableAsset CachePrefabComponent<T>(AssetReference assetReference) where T : Component
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x13AB5E0", Offset = "0x13AA7E0", VA = "0x1813AB5E0")]
			private static CachedAddressableAsset CacheAssetInternal<T>(AssetReference assetReference, IResourceHandle<T> loadHandle) where T : UnityEngine.Object
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x3AE300", Offset = "0x3AD500", VA = "0x1803AE300")]
			private CachedAddressableAsset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x126DB90", Offset = "0x126CD90", VA = "0x18126DB90")]
			public void IncrementRequestCount()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x19C9B10", Offset = "0x19C8D10", VA = "0x1819C9B10")]
			public void DecrementRequestCount()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x314F4D0", Offset = "0x314E6D0", VA = "0x18314F4D0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class CachedResourceHandle<T> : IResourceHandle<T>, IResourceHandle, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action OnDispose;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private bool isDisposed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private IResourceHandle<T> baseHandle;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			IPromise IResourceHandle.ResourcePromise
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xFCDE20", Offset = "0xFCD020", VA = "0x180FCDE20", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public IPromise<T> ResourcePromise
			{
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x23CD040", Offset = "0x23CC240", VA = "0x1823CD040", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Task<T> ResourceTask
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x23CD0F0", Offset = "0x23CC2F0", VA = "0x1823CD0F0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x23CD000", Offset = "0x23CC200", VA = "0x1823CD000")]
			public CachedResourceHandle(IResourceHandle<T> baseHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x23CCF30", Offset = "0x23CC130", VA = "0x1823CCF30", Slot = "7")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly ActionEvent<UnityEngine.Object> WillUnloadAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int lruCacheSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private bool isDisposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private Dictionary<object, CachedAddressableAsset> cachedAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private LinkedList<object> inactiveRuntimeKeys;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x314F410", Offset = "0x314E610", VA = "0x18314F410")]
		public AGAddressableAssetCache(int lruCacheSize = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1BAE060", Offset = "0x1BAD260", VA = "0x181BAE060")]
		public IResourceHandle<T> LoadPrefab<T>([NotNull] AssetReference reference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x13A98D0", Offset = "0x13A8AD0", VA = "0x1813A98D0")]
		private CachedResourceHandle<T> CachePrefabRequest<T>(AssetReference assetReference, IResourceHandle<T> resourceHandle) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x13A9980", Offset = "0x13A8B80", VA = "0x1813A9980")]
		private CachedResourceHandle<T> CacheRequestInternal<T>(AssetReference assetReference, IResourceHandle<T> resourceHandle, Func<AssetReference, CachedAddressableAsset> cacheFunction) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x314F060", Offset = "0x314E260", VA = "0x18314F060")]
		private void DisposeExpiredRequests()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x314F150", Offset = "0x314E350", VA = "0x18314F150")]
		private void DisposeRequest(CachedAddressableAsset request)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x314F280", Offset = "0x314E480", VA = "0x18314F280", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class AGAddressableAssetManager
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private abstract class AssetBundleHandleBase<TSource, TTransformed> : ResourceHandleBase<Task<TSource>, TTransformed> where TSource : UnityEngine.Object where TTransformed : UnityEngine.Object
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			protected readonly AsyncOperationHandle<TSource> operationHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private bool callbackQueued;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			protected TSource Asset
			{
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3B0440", Offset = "0x3AF640", VA = "0x1803B0440")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x4199B0", Offset = "0x418BB0", VA = "0x1804199B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x23CCD80", Offset = "0x23CBF80", VA = "0x1823CCD80")]
			protected AssetBundleHandleBase(AsyncOperationHandle<TSource> operationHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x23CCA20", Offset = "0x23CBC20", VA = "0x1823CCA20")]
			private void OnOperationHandleCompleted(AsyncOperationHandle<TSource> obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x23CCCB0", Offset = "0x23CBEB0", VA = "0x1823CCCB0", Slot = "3")]
			public sealed override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x23CCD20", Offset = "0x23CBF20", VA = "0x1823CCD20", Slot = "8")]
			protected override TTransformed TransformTaskResult(Task<TSource> originalTask)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "10")]
			protected abstract TTransformed TransformLoadedAsset(TSource loadedAsset);

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x23CCC00", Offset = "0x23CBE00", VA = "0x1823CCC00", Slot = "9")]
			protected override void ReleaseResource()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class LoadedAssetHandle<T> : AssetBundleHandleBase<T, T> where T : UnityEngine.Object
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1AE9130", Offset = "0x1AE8330", VA = "0x181AE9130")]
			public LoadedAssetHandle(AsyncOperationHandle<T> operationHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x4E65F0", Offset = "0x4E57F0", VA = "0x1804E65F0", Slot = "10")]
			protected override T TransformLoadedAsset(T loadedAsset)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x23CDFC0", Offset = "0x23CD1C0", VA = "0x1823CDFC0", Slot = "9")]
			protected sealed override void ReleaseResource()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class PrefabComponentHandle<T> : AssetBundleHandleBase<GameObject, T> where T : Component
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1AE9130", Offset = "0x1AE8330", VA = "0x181AE9130")]
			public PrefabComponentHandle(AsyncOperationHandle<GameObject> operationHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2192B60", Offset = "0x2191D60", VA = "0x182192B60", Slot = "10")]
			protected override T TransformLoadedAsset(GameObject loadedAsset)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x23CE070", Offset = "0x23CD270", VA = "0x1823CE070", Slot = "9")]
			protected sealed override void ReleaseResource()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x15CDE70", Offset = "0x15CD070", VA = "0x1815CDE70")]
		public static bool TryLoadAssetOrElse<T>(AssetReference assetReference, Func<IResourceHandle<T>> loadDefaultValue, out IResourceHandle<T> resourceHandle) where T : UnityEngine.Object
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1BAE0C0", Offset = "0x1BAD2C0", VA = "0x181BAE0C0")]
		public static IResourceHandle<T> LoadAsset<T>([NotNull] AssetReference reference) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1BAE320", Offset = "0x1BAD520", VA = "0x181BAE320")]
		public static IResourceHandle<T> LoadResource<T>([NotNull] string resourceName) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1BAE1F0", Offset = "0x1BAD3F0", VA = "0x181BAE1F0")]
		public static IResourceHandle<T> LoadPrefab<T>([NotNull] AssetReference reference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3BB130", Offset = "0x3BA330", VA = "0x1803BB130")]
		private static void AssertAssetReferenceIsValid(AssetReference reference)
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
