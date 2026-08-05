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
				[Cpp2IlInjected.Address(RVA = "0x4B27F0", Offset = "0x4B13F0", VA = "0x1804B27F0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public UnityEngine.Object CachedObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000009")]
				[Cpp2IlInjected.Address(RVA = "0x39C230", Offset = "0x39AE30", VA = "0x18039C230")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1E03380", Offset = "0x1E01F80", VA = "0x181E03380")]
			public static CachedAddressableAsset CachePrefabComponent<T>(AssetReference assetReference) where T : Component
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1E03180", Offset = "0x1E01D80", VA = "0x181E03180")]
			private static CachedAddressableAsset CacheAssetInternal<T>(AssetReference assetReference, IResourceHandle<T> loadHandle) where T : UnityEngine.Object
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x39C670", Offset = "0x39B270", VA = "0x18039C670")]
			private CachedAddressableAsset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xDDAD60", Offset = "0xDD9960", VA = "0x180DDAD60")]
			public void IncrementRequestCount()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x599FF0", Offset = "0x598BF0", VA = "0x180599FF0")]
			public void DecrementRequestCount()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xDDACA0", Offset = "0xDD98A0", VA = "0x180DDACA0", Slot = "4")]
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
			Task IResourceHandle.ResourceTask
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x189F880", Offset = "0x189E480", VA = "0x18189F880", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			IPromise IResourceHandle.ResourcePromise
			{
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x1894C60", Offset = "0x1893860", VA = "0x181894C60", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public IPromise<T> ResourcePromise
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x2613540", Offset = "0x2612140", VA = "0x182613540", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public Task<T> ResourceTask
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x26135F0", Offset = "0x26121F0", VA = "0x1826135F0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2613500", Offset = "0x2612100", VA = "0x182613500")]
			public CachedResourceHandle(IResourceHandle<T> baseHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2613430", Offset = "0x2612030", VA = "0x182613430", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xDDABE0", Offset = "0xDD97E0", VA = "0x180DDABE0")]
		public AGAddressableAssetCache(int lruCacheSize = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x21E2060", Offset = "0x21E0C60", VA = "0x1821E2060")]
		public IResourceHandle<T> LoadPrefab<T>([NotNull] AssetReference reference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1E01EE0", Offset = "0x1E00AE0", VA = "0x181E01EE0")]
		private CachedResourceHandle<T> CachePrefabRequest<T>(AssetReference assetReference, IResourceHandle<T> resourceHandle) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1E01F90", Offset = "0x1E00B90", VA = "0x181E01F90")]
		private CachedResourceHandle<T> CacheRequestInternal<T>(AssetReference assetReference, IResourceHandle<T> resourceHandle, Func<AssetReference, CachedAddressableAsset> cacheFunction) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xDDA830", Offset = "0xDD9430", VA = "0x180DDA830")]
		private void DisposeExpiredRequests()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xDDA920", Offset = "0xDD9520", VA = "0x180DDA920")]
		private void DisposeRequest(CachedAddressableAsset request)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xDDAA50", Offset = "0xDD9650", VA = "0x180DDAA50", Slot = "4")]
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

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			protected TSource Asset
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x43D280", Offset = "0x43BE80", VA = "0x18043D280")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x43D290", Offset = "0x43BE90", VA = "0x18043D290")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2613280", Offset = "0x2611E80", VA = "0x182613280")]
			protected AssetBundleHandleBase(AsyncOperationHandle<TSource> operationHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2612F20", Offset = "0x2611B20", VA = "0x182612F20")]
			private void OnOperationHandleCompleted(AsyncOperationHandle<TSource> obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x26131B0", Offset = "0x2611DB0", VA = "0x1826131B0", Slot = "3")]
			public sealed override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2613220", Offset = "0x2611E20", VA = "0x182613220", Slot = "9")]
			protected override TTransformed TransformTaskResult(Task<TSource> originalTask)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract TTransformed TransformLoadedAsset(TSource loadedAsset);

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2613100", Offset = "0x2611D00", VA = "0x182613100", Slot = "10")]
			protected override void ReleaseResource()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class LoadedAssetHandle<T> : AssetBundleHandleBase<T, T> where T : UnityEngine.Object
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1F72790", Offset = "0x1F71390", VA = "0x181F72790")]
			public LoadedAssetHandle(AsyncOperationHandle<T> operationHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4D18F0", Offset = "0x4D04F0", VA = "0x1804D18F0", Slot = "11")]
			protected override T TransformLoadedAsset(T loadedAsset)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2614450", Offset = "0x2613050", VA = "0x182614450", Slot = "10")]
			protected sealed override void ReleaseResource()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class PrefabComponentHandle<T> : AssetBundleHandleBase<GameObject, T> where T : Component
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1F72790", Offset = "0x1F71390", VA = "0x181F72790")]
			public PrefabComponentHandle(AsyncOperationHandle<GameObject> operationHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x20FA4D0", Offset = "0x20F90D0", VA = "0x1820FA4D0", Slot = "11")]
			protected override T TransformLoadedAsset(GameObject loadedAsset)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2614500", Offset = "0x2613100", VA = "0x182614500", Slot = "10")]
			protected sealed override void ReleaseResource()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1F1A8D0", Offset = "0x1F194D0", VA = "0x181F1A8D0")]
		public static bool TryLoadAssetOrElse<T>(AssetReference assetReference, Func<IResourceHandle<T>> loadDefaultValue, out IResourceHandle<T> resourceHandle) where T : UnityEngine.Object
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x21E20C0", Offset = "0x21E0CC0", VA = "0x1821E20C0")]
		public static IResourceHandle<T> LoadAsset<T>([NotNull] AssetReference reference) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x21E2320", Offset = "0x21E0F20", VA = "0x1821E2320")]
		public static IResourceHandle<T> LoadResource<T>([NotNull] string resourceName) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x21E21F0", Offset = "0x21E0DF0", VA = "0x1821E21F0")]
		public static IResourceHandle<T> LoadPrefab<T>([NotNull] AssetReference reference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3A4F60", Offset = "0x3A3B60", VA = "0x1803A4F60")]
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
