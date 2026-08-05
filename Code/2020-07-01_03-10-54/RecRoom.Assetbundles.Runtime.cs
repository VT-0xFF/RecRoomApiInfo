using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.DataStructures.ResourceHandles;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AGAddressableAssetManager
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private abstract class AssetBundleHandleBase<TAsset, T> : ResourceHandleBase<Task<TAsset>, T> where TAsset : UnityEngine.Object where T : UnityEngine.Object
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		protected readonly AsyncOperationHandle<TAsset> operationHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private bool callbackQueued;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected TAsset Asset
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3ADAB0", Offset = "0x3AC4B0", VA = "0x1803ADAB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x3AC2E0", Offset = "0x3AACE0", VA = "0x1803AC2E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1505DE0", Offset = "0x15047E0", VA = "0x181505DE0")]
		protected AssetBundleHandleBase(AsyncOperationHandle<TAsset> operationHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1505A80", Offset = "0x1504480", VA = "0x181505A80")]
		private void OnOperationHandleCompleted(AsyncOperationHandle<TAsset> obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1505D10", Offset = "0x1504710", VA = "0x181505D10", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1505D80", Offset = "0x1504780", VA = "0x181505D80", Slot = "8")]
		protected override T TransformTaskResult(Task<TAsset> originalTask)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T TransformLoadedAsset(TAsset loadedAsset);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1505C60", Offset = "0x1504660", VA = "0x181505C60", Slot = "9")]
		protected override void ReleaseResource()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class LoadedAssetHandle<T> : AssetBundleHandleBase<T, T> where T : UnityEngine.Object
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x150B830", Offset = "0x150A230", VA = "0x18150B830")]
		public LoadedAssetHandle(AsyncOperationHandle<T> operationHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4B81F0", Offset = "0x4B6BF0", VA = "0x1804B81F0", Slot = "10")]
		protected override T TransformLoadedAsset(T loadedAsset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x150B780", Offset = "0x150A180", VA = "0x18150B780", Slot = "9")]
		protected sealed override void ReleaseResource()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x11DA520", Offset = "0x11D8F20", VA = "0x1811DA520")]
	public static IResourceHandle<T> LoadAssetOrElse<T>(AssetReference assetReference, Func<IResourceHandle<T>> loadDefaultValue) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x11DA5A0", Offset = "0x11D8FA0", VA = "0x1811DA5A0")]
	public static IResourceHandle<T> LoadAsset<T>([NotNull] AssetReference reference) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x11DA6D0", Offset = "0x11D90D0", VA = "0x1811DA6D0")]
	public static IResourceHandle<T> LoadResource<T>([NotNull] string resourceName) where T : UnityEngine.Object
	{
		return null;
	}
}
namespace Cpp2IlInjected;

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
