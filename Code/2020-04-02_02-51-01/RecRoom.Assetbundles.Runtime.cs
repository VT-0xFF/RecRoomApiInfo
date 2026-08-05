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
			[Cpp2IlInjected.Address(RVA = "0x35CFF0", Offset = "0x35BFF0", VA = "0x18035CFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x354B80", Offset = "0x353B80", VA = "0x180354B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x113E3C0", Offset = "0x113D3C0", VA = "0x18113E3C0")]
		protected AssetBundleHandleBase(AsyncOperationHandle<TAsset> operationHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x113E060", Offset = "0x113D060", VA = "0x18113E060")]
		private void OnOperationHandleCompleted(AsyncOperationHandle<TAsset> obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x113E2F0", Offset = "0x113D2F0", VA = "0x18113E2F0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x113E360", Offset = "0x113D360", VA = "0x18113E360", Slot = "8")]
		protected override T TransformTaskResult(Task<TAsset> originalTask)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T TransformLoadedAsset(TAsset loadedAsset);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x113E240", Offset = "0x113D240", VA = "0x18113E240", Slot = "9")]
		protected override void ReleaseResource()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class LoadedAssetHandle<T> : AssetBundleHandleBase<T, T> where T : UnityEngine.Object
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1143D10", Offset = "0x1142D10", VA = "0x181143D10")]
		public LoadedAssetHandle(AsyncOperationHandle<T> operationHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x55D420", Offset = "0x55C420", VA = "0x18055D420", Slot = "10")]
		protected override T TransformLoadedAsset(T loadedAsset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1143C60", Offset = "0x1142C60", VA = "0x181143C60", Slot = "9")]
		protected sealed override void ReleaseResource()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x10C0050", Offset = "0x10BF050", VA = "0x1810C0050")]
	public static IResourceHandle<T> LoadAssetOrElse<T>(AssetReference assetReference, Func<IResourceHandle<T>> loadDefaultValue) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x10C00D0", Offset = "0x10BF0D0", VA = "0x1810C00D0")]
	public static IResourceHandle<T> LoadAsset<T>([NotNull] AssetReference reference) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x10C01F0", Offset = "0x10BF1F0", VA = "0x1810C01F0")]
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
