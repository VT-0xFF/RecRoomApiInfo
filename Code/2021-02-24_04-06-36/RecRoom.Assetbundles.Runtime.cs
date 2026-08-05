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
				[Cpp2IlInjected.Address(RVA = "0x48F6D0", Offset = "0x48E6D0", VA = "0x18048F6D0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public UnityEngine.Object CachedObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000009")]
				[Cpp2IlInjected.Address(RVA = "0x3CD930", Offset = "0x3CC930", VA = "0x1803CD930")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x14E49D0", Offset = "0x14E39D0", VA = "0x1814E49D0")]
			public static CachedAddressableAsset CachePrefabComponent<T>(AssetReference assetReference) where T : Component
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x14E47D0", Offset = "0x14E37D0", VA = "0x1814E47D0")]
			private static CachedAddressableAsset CacheAssetInternal<T>(AssetReference assetReference, IResourceHandle<T> loadHandle) where T : UnityEngine.Object
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x3CA300", Offset = "0x3C9300", VA = "0x1803CA300")]
			private CachedAddressableAsset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1246640", Offset = "0x1245640", VA = "0x181246640")]
			public void IncrementRequestCount()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1E8E3F0", Offset = "0x1E8D3F0", VA = "0x181E8E3F0")]
			public void DecrementRequestCount()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x32EE280", Offset = "0x32ED280", VA = "0x1832EE280", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xF591F0", Offset = "0xF581F0", VA = "0x180F591F0", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public IPromise<T> ResourcePromise
			{
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x22C8BE0", Offset = "0x22C7BE0", VA = "0x1822C8BE0", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Task<T> ResourceTask
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x22C8C90", Offset = "0x22C7C90", VA = "0x1822C8C90", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x22C8BA0", Offset = "0x22C7BA0", VA = "0x1822C8BA0")]
			public CachedResourceHandle(IResourceHandle<T> baseHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x22C8AD0", Offset = "0x22C7AD0", VA = "0x1822C8AD0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x32EE1C0", Offset = "0x32ED1C0", VA = "0x1832EE1C0")]
		public AGAddressableAssetCache(int lruCacheSize = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1ACBAB0", Offset = "0x1ACAAB0", VA = "0x181ACBAB0")]
		public IResourceHandle<T> LoadPrefab<T>([NotNull] AssetReference reference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x14E1E50", Offset = "0x14E0E50", VA = "0x1814E1E50")]
		private CachedResourceHandle<T> CachePrefabRequest<T>(AssetReference assetReference, IResourceHandle<T> resourceHandle) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x14E1F00", Offset = "0x14E0F00", VA = "0x1814E1F00")]
		private CachedResourceHandle<T> CacheRequestInternal<T>(AssetReference assetReference, IResourceHandle<T> resourceHandle, Func<AssetReference, CachedAddressableAsset> cacheFunction) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x32EDE10", Offset = "0x32ECE10", VA = "0x1832EDE10")]
		private void DisposeExpiredRequests()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x32EDF00", Offset = "0x32ECF00", VA = "0x1832EDF00")]
		private void DisposeRequest(CachedAddressableAsset request)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x32EE030", Offset = "0x32ED030", VA = "0x1832EE030", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3CC450", Offset = "0x3CB450", VA = "0x1803CC450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x44F660", Offset = "0x44E660", VA = "0x18044F660")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x22C8920", Offset = "0x22C7920", VA = "0x1822C8920")]
			protected AssetBundleHandleBase(AsyncOperationHandle<TSource> operationHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x22C85C0", Offset = "0x22C75C0", VA = "0x1822C85C0")]
			private void OnOperationHandleCompleted(AsyncOperationHandle<TSource> obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x22C8850", Offset = "0x22C7850", VA = "0x1822C8850", Slot = "3")]
			public sealed override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x22C88C0", Offset = "0x22C78C0", VA = "0x1822C88C0", Slot = "8")]
			protected override TTransformed TransformTaskResult(Task<TSource> originalTask)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "10")]
			protected abstract TTransformed TransformLoadedAsset(TSource loadedAsset);

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x22C87A0", Offset = "0x22C77A0", VA = "0x1822C87A0", Slot = "9")]
			protected override void ReleaseResource()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class LoadedAssetHandle<T> : AssetBundleHandleBase<T, T> where T : UnityEngine.Object
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1A7A5C0", Offset = "0x1A795C0", VA = "0x181A7A5C0")]
			public LoadedAssetHandle(AsyncOperationHandle<T> operationHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5FD8A0", Offset = "0x5FC8A0", VA = "0x1805FD8A0", Slot = "10")]
			protected override T TransformLoadedAsset(T loadedAsset)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x22C9F60", Offset = "0x22C8F60", VA = "0x1822C9F60", Slot = "9")]
			protected sealed override void ReleaseResource()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class PrefabComponentHandle<T> : AssetBundleHandleBase<GameObject, T> where T : Component
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1A7A5C0", Offset = "0x1A795C0", VA = "0x181A7A5C0")]
			public PrefabComponentHandle(AsyncOperationHandle<GameObject> operationHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x17E1F10", Offset = "0x17E0F10", VA = "0x1817E1F10", Slot = "10")]
			protected override T TransformLoadedAsset(GameObject loadedAsset)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x22CA010", Offset = "0x22C9010", VA = "0x1822CA010", Slot = "9")]
			protected sealed override void ReleaseResource()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1A2E430", Offset = "0x1A2D430", VA = "0x181A2E430")]
		public static bool TryLoadAssetOrElse<T>(AssetReference assetReference, Func<IResourceHandle<T>> loadDefaultValue, out IResourceHandle<T> resourceHandle) where T : UnityEngine.Object
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1ACBB10", Offset = "0x1ACAB10", VA = "0x181ACBB10")]
		public static IResourceHandle<T> LoadAsset<T>([NotNull] AssetReference reference) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1ACBD70", Offset = "0x1ACAD70", VA = "0x181ACBD70")]
		public static IResourceHandle<T> LoadResource<T>([NotNull] string resourceName) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1ACBC40", Offset = "0x1ACAC40", VA = "0x181ACBC40")]
		public static IResourceHandle<T> LoadPrefab<T>([NotNull] AssetReference reference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3D7110", Offset = "0x3D6110", VA = "0x1803D7110")]
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
