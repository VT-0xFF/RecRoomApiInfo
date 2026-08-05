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
			[Cpp2IlInjected.Address(RVA = "0x34EC60", Offset = "0x34DE60", VA = "0x18034EC60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x34F700", Offset = "0x34E900", VA = "0x18034F700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xE4CC50", Offset = "0xE4BE50", VA = "0x180E4CC50")]
		protected AssetBundleHandleBase(AsyncOperationHandle<TAsset> operationHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xE4C8F0", Offset = "0xE4BAF0", VA = "0x180E4C8F0")]
		private void OnOperationHandleCompleted(AsyncOperationHandle<TAsset> obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE4CB80", Offset = "0xE4BD80", VA = "0x180E4CB80", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE4CBF0", Offset = "0xE4BDF0", VA = "0x180E4CBF0", Slot = "8")]
		protected override T TransformTaskResult(Task<TAsset> originalTask)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T TransformLoadedAsset(TAsset loadedAsset);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE4CAD0", Offset = "0xE4BCD0", VA = "0x180E4CAD0", Slot = "9")]
		protected override void ReleaseResource()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class LoadedAssetHandle<T> : AssetBundleHandleBase<T, T> where T : UnityEngine.Object
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xE52570", Offset = "0xE51770", VA = "0x180E52570")]
		public LoadedAssetHandle(AsyncOperationHandle<T> operationHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FD3B0", Offset = "0x5FC5B0", VA = "0x1805FD3B0", Slot = "10")]
		protected override T TransformLoadedAsset(T loadedAsset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xE524C0", Offset = "0xE516C0", VA = "0x180E524C0", Slot = "9")]
		protected sealed override void ReleaseResource()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xCCA5C0", Offset = "0xCC97C0", VA = "0x180CCA5C0")]
	public static IResourceHandle<T> LoadAssetOrElse<T>(AssetReference assetReference, Func<IResourceHandle<T>> loadDefaultValue) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xCCA640", Offset = "0xCC9840", VA = "0x180CCA640")]
	public static IResourceHandle<T> LoadAsset<T>([NotNull] AssetReference reference) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xCCA760", Offset = "0xCC9960", VA = "0x180CCA760")]
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
