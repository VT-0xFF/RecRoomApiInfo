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
				[Cpp2IlInjected.Address(RVA = "0x4812A0", Offset = "0x4802A0", VA = "0x1804812A0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public UnityEngine.Object CachedObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000009")]
				[Cpp2IlInjected.Address(RVA = "0x3BF080", Offset = "0x3BE080", VA = "0x1803BF080")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x14408D0", Offset = "0x143F8D0", VA = "0x1814408D0")]
			public static CachedAddressableAsset CachePrefabComponent<T>(AssetReference assetReference) where T : Component
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1440720", Offset = "0x143F720", VA = "0x181440720")]
			private static CachedAddressableAsset CacheAssetInternal<T>(AssetReference assetReference, IResourceHandle<T> loadHandle) where T : UnityEngine.Object
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x39AF80", Offset = "0x399F80", VA = "0x18039AF80")]
			private CachedAddressableAsset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2F99A00", Offset = "0x2F98A00", VA = "0x182F99A00")]
			public void IncrementRequestCount()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x182EBC0", Offset = "0x182DBC0", VA = "0x18182EBC0")]
			public void DecrementRequestCount()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2F99940", Offset = "0x2F98940", VA = "0x182F99940", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xECF090", Offset = "0xECE090", VA = "0x180ECF090", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			IPromise IResourceHandle.ResourcePromise
			{
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x1243FF0", Offset = "0x1242FF0", VA = "0x181243FF0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public IPromise<T> ResourcePromise
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x245FCF0", Offset = "0x245ECF0", VA = "0x18245FCF0", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public Task<T> ResourceTask
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x245FDA0", Offset = "0x245EDA0", VA = "0x18245FDA0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x245FCB0", Offset = "0x245ECB0", VA = "0x18245FCB0")]
			public CachedResourceHandle(IResourceHandle<T> baseHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x245FBE0", Offset = "0x245EBE0", VA = "0x18245FBE0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F99880", Offset = "0x2F98880", VA = "0x182F99880")]
		public AGAddressableAssetCache(int lruCacheSize = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1D215E0", Offset = "0x1D205E0", VA = "0x181D215E0")]
		public IResourceHandle<T> LoadPrefab<T>([NotNull] AssetReference reference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x143ED00", Offset = "0x143DD00", VA = "0x18143ED00")]
		private CachedResourceHandle<T> CachePrefabRequest<T>(AssetReference assetReference, IResourceHandle<T> resourceHandle) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x143EDB0", Offset = "0x143DDB0", VA = "0x18143EDB0")]
		private CachedResourceHandle<T> CacheRequestInternal<T>(AssetReference assetReference, IResourceHandle<T> resourceHandle, Func<AssetReference, CachedAddressableAsset> cacheFunction) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2F994D0", Offset = "0x2F984D0", VA = "0x182F994D0")]
		private void DisposeExpiredRequests()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2F995C0", Offset = "0x2F985C0", VA = "0x182F995C0")]
		private void DisposeRequest(CachedAddressableAsset request)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2F996F0", Offset = "0x2F986F0", VA = "0x182F996F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3AA190", Offset = "0x3A9190", VA = "0x1803AA190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x459890", Offset = "0x458890", VA = "0x180459890")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x245FA30", Offset = "0x245EA30", VA = "0x18245FA30")]
			protected AssetBundleHandleBase(AsyncOperationHandle<TSource> operationHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x245F6D0", Offset = "0x245E6D0", VA = "0x18245F6D0")]
			private void OnOperationHandleCompleted(AsyncOperationHandle<TSource> obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x245F960", Offset = "0x245E960", VA = "0x18245F960", Slot = "3")]
			public sealed override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x245F9D0", Offset = "0x245E9D0", VA = "0x18245F9D0", Slot = "9")]
			protected override TTransformed TransformTaskResult(Task<TSource> originalTask)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract TTransformed TransformLoadedAsset(TSource loadedAsset);

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x245F8B0", Offset = "0x245E8B0", VA = "0x18245F8B0", Slot = "10")]
			protected override void ReleaseResource()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class LoadedAssetHandle<T> : AssetBundleHandleBase<T, T> where T : UnityEngine.Object
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1DDDA30", Offset = "0x1DDCA30", VA = "0x181DDDA30")]
			public LoadedAssetHandle(AsyncOperationHandle<T> operationHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x460A00", Offset = "0x45FA00", VA = "0x180460A00", Slot = "11")]
			protected override T TransformLoadedAsset(T loadedAsset)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2460810", Offset = "0x245F810", VA = "0x182460810", Slot = "10")]
			protected sealed override void ReleaseResource()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class PrefabComponentHandle<T> : AssetBundleHandleBase<GameObject, T> where T : Component
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1DDDA30", Offset = "0x1DDCA30", VA = "0x181DDDA30")]
			public PrefabComponentHandle(AsyncOperationHandle<GameObject> operationHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x16F9950", Offset = "0x16F8950", VA = "0x1816F9950", Slot = "11")]
			protected override T TransformLoadedAsset(GameObject loadedAsset)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x24608C0", Offset = "0x245F8C0", VA = "0x1824608C0", Slot = "10")]
			protected sealed override void ReleaseResource()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x151B5D0", Offset = "0x151A5D0", VA = "0x18151B5D0")]
		public static bool TryLoadAssetOrElse<T>(AssetReference assetReference, Func<IResourceHandle<T>> loadDefaultValue, out IResourceHandle<T> resourceHandle) where T : UnityEngine.Object
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D21640", Offset = "0x1D20640", VA = "0x181D21640")]
		public static IResourceHandle<T> LoadAsset<T>([NotNull] AssetReference reference) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1D218A0", Offset = "0x1D208A0", VA = "0x181D218A0")]
		public static IResourceHandle<T> LoadResource<T>([NotNull] string resourceName) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1D21770", Offset = "0x1D20770", VA = "0x181D21770")]
		public static IResourceHandle<T> LoadPrefab<T>([NotNull] AssetReference reference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x39A2A0", Offset = "0x3992A0", VA = "0x18039A2A0")]
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
