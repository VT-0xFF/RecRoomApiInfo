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
public static class AGAssetBundleManager
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
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x377810", Offset = "0x376210", VA = "0x180377810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3A47C0", Offset = "0x3A31C0", VA = "0x1803A47C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xEBE970", Offset = "0xEBD370", VA = "0x180EBE970")]
		protected AssetBundleHandleBase(AsyncOperationHandle<TAsset> operationHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xEBE610", Offset = "0xEBD010", VA = "0x180EBE610")]
		private void OnOperationHandleCompleted(AsyncOperationHandle<TAsset> obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xEBE8A0", Offset = "0xEBD2A0", VA = "0x180EBE8A0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xEBE910", Offset = "0xEBD310", VA = "0x180EBE910", Slot = "8")]
		protected override T TransformTaskResult(Task<TAsset> originalTask)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T TransformLoadedAsset(TAsset loadedAsset);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xEBE7F0", Offset = "0xEBD1F0", VA = "0x180EBE7F0", Slot = "9")]
		protected override void ReleaseResource()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class LoadedAssetHandle<T> : AssetBundleHandleBase<T, T> where T : UnityEngine.Object
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEC3BC0", Offset = "0xEC25C0", VA = "0x180EC3BC0")]
		public LoadedAssetHandle(AsyncOperationHandle<T> operationHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3D98E0", Offset = "0x3D82E0", VA = "0x1803D98E0", Slot = "10")]
		protected override T TransformLoadedAsset(T loadedAsset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xEC3B10", Offset = "0xEC2510", VA = "0x180EC3B10", Slot = "9")]
		protected sealed override void ReleaseResource()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xD48C40", Offset = "0xD47640", VA = "0x180D48C40")]
	public static IResourceHandle<T> LoadAssetOrElse<T>(AssetReference assetReference, Func<IResourceHandle<T>> loadDefaultValue) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xD48CC0", Offset = "0xD476C0", VA = "0x180D48CC0")]
	public static IResourceHandle<T> LoadAsset<T>([NotNull] AssetReference reference) where T : UnityEngine.Object
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
