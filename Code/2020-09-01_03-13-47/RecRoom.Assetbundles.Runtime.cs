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
				[Cpp2IlInjected.Address(RVA = "0x455D30", Offset = "0x454D30", VA = "0x180455D30")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public UnityEngine.Object CachedObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000009")]
				[Cpp2IlInjected.Address(RVA = "0x3A09C0", Offset = "0x39F9C0", VA = "0x1803A09C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1410A50", Offset = "0x140FA50", VA = "0x181410A50")]
			public static CachedAddressableAsset CachePrefabComponent<T>(AssetReference assetReference) where T : Component
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x14108A0", Offset = "0x140F8A0", VA = "0x1814108A0")]
			private static CachedAddressableAsset CacheAssetInternal<T>(AssetReference assetReference, IResourceHandle<T> loadHandle) where T : UnityEngine.Object
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x39A540", Offset = "0x399540", VA = "0x18039A540")]
			private CachedAddressableAsset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2F9CF90", Offset = "0x2F9BF90", VA = "0x182F9CF90")]
			public void IncrementRequestCount()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x180B6A0", Offset = "0x180A6A0", VA = "0x18180B6A0")]
			public void DecrementRequestCount()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2F9CED0", Offset = "0x2F9BED0", VA = "0x182F9CED0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xE91B10", Offset = "0xE90B10", VA = "0x180E91B10", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			IPromise IResourceHandle.ResourcePromise
			{
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0xE87A80", Offset = "0xE86A80", VA = "0x180E87A80", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public IPromise<T> ResourcePromise
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x255CE20", Offset = "0x255BE20", VA = "0x18255CE20", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public Task<T> ResourceTask
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x255CED0", Offset = "0x255BED0", VA = "0x18255CED0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x255CDE0", Offset = "0x255BDE0", VA = "0x18255CDE0")]
			public CachedResourceHandle(IResourceHandle<T> baseHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x255CD10", Offset = "0x255BD10", VA = "0x18255CD10", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F9CE10", Offset = "0x2F9BE10", VA = "0x182F9CE10")]
		public AGAddressableAssetCache(int lruCacheSize = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1CFB900", Offset = "0x1CFA900", VA = "0x181CFB900")]
		public IResourceHandle<T> LoadPrefab<T>([NotNull] AssetReference reference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x140EE80", Offset = "0x140DE80", VA = "0x18140EE80")]
		private CachedResourceHandle<T> CachePrefabRequest<T>(AssetReference assetReference, IResourceHandle<T> resourceHandle) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x140EF30", Offset = "0x140DF30", VA = "0x18140EF30")]
		private CachedResourceHandle<T> CacheRequestInternal<T>(AssetReference assetReference, IResourceHandle<T> resourceHandle, Func<AssetReference, CachedAddressableAsset> cacheFunction) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2F9CA60", Offset = "0x2F9BA60", VA = "0x182F9CA60")]
		private void DisposeExpiredRequests()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2F9CB50", Offset = "0x2F9BB50", VA = "0x182F9CB50")]
		private void DisposeRequest(CachedAddressableAsset request)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2F9CC80", Offset = "0x2F9BC80", VA = "0x182F9CC80", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3E4FE0", Offset = "0x3E3FE0", VA = "0x1803E4FE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x455D00", Offset = "0x454D00", VA = "0x180455D00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x255CB60", Offset = "0x255BB60", VA = "0x18255CB60")]
			protected AssetBundleHandleBase(AsyncOperationHandle<TSource> operationHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x255C800", Offset = "0x255B800", VA = "0x18255C800")]
			private void OnOperationHandleCompleted(AsyncOperationHandle<TSource> obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x255CA90", Offset = "0x255BA90", VA = "0x18255CA90", Slot = "3")]
			public sealed override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x255CB00", Offset = "0x255BB00", VA = "0x18255CB00", Slot = "9")]
			protected override TTransformed TransformTaskResult(Task<TSource> originalTask)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "11")]
			protected abstract TTransformed TransformLoadedAsset(TSource loadedAsset);

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x255C9E0", Offset = "0x255B9E0", VA = "0x18255C9E0", Slot = "10")]
			protected override void ReleaseResource()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class LoadedAssetHandle<T> : AssetBundleHandleBase<T, T> where T : UnityEngine.Object
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1DFF3F0", Offset = "0x1DFE3F0", VA = "0x181DFF3F0")]
			public LoadedAssetHandle(AsyncOperationHandle<T> operationHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x489A50", Offset = "0x488A50", VA = "0x180489A50", Slot = "11")]
			protected override T TransformLoadedAsset(T loadedAsset)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x255D970", Offset = "0x255C970", VA = "0x18255D970", Slot = "10")]
			protected sealed override void ReleaseResource()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class PrefabComponentHandle<T> : AssetBundleHandleBase<GameObject, T> where T : Component
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1DFF3F0", Offset = "0x1DFE3F0", VA = "0x181DFF3F0")]
			public PrefabComponentHandle(AsyncOperationHandle<GameObject> operationHandle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x172C7C0", Offset = "0x172B7C0", VA = "0x18172C7C0", Slot = "11")]
			protected override T TransformLoadedAsset(GameObject loadedAsset)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x255DA20", Offset = "0x255CA20", VA = "0x18255DA20", Slot = "10")]
			protected sealed override void ReleaseResource()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x14D6DF0", Offset = "0x14D5DF0", VA = "0x1814D6DF0")]
		public static bool TryLoadAssetOrElse<T>(AssetReference assetReference, Func<IResourceHandle<T>> loadDefaultValue, out IResourceHandle<T> resourceHandle) where T : UnityEngine.Object
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1CFB960", Offset = "0x1CFA960", VA = "0x181CFB960")]
		public static IResourceHandle<T> LoadAsset<T>([NotNull] AssetReference reference) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1CFBBC0", Offset = "0x1CFABC0", VA = "0x181CFBBC0")]
		public static IResourceHandle<T> LoadResource<T>([NotNull] string resourceName) where T : UnityEngine.Object
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1CFBA90", Offset = "0x1CFAA90", VA = "0x181CFBA90")]
		public static IResourceHandle<T> LoadPrefab<T>([NotNull] AssetReference reference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x39B3A0", Offset = "0x39A3A0", VA = "0x18039B3A0")]
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
