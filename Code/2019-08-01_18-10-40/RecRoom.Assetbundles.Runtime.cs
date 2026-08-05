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
	private abstract class HandleBase<TAsset, T> : ResourceHandleBase<Task<TAsset>, T> where TAsset : UnityEngine.Object where T : UnityEngine.Object
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		protected readonly AsyncOperationHandle<TAsset> operationHandle;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected TAsset Asset
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x3918B0", Offset = "0x3904B0", VA = "0x1803918B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x3918E0", Offset = "0x3904E0", VA = "0x1803918E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xDC5460", Offset = "0xDC4060", VA = "0x180DC5460")]
		protected HandleBase(AsyncOperationHandle<TAsset> operationHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xDC5180", Offset = "0xDC3D80", VA = "0x180DC5180")]
		private void OnOperationHandleCompleted(AsyncOperationHandle<TAsset> obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xDC5400", Offset = "0xDC4000", VA = "0x180DC5400", Slot = "8")]
		protected override T TransformTaskResult(Task<TAsset> originalTask)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T TransformLoadedAsset(TAsset loadedAsset);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xDC5360", Offset = "0xDC3F60", VA = "0x180DC5360", Slot = "9")]
		protected override void ReleaseResource()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class LoadedResourceHandle<T> : HandleBase<T, T> where T : UnityEngine.Object
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDC59E0", Offset = "0xDC45E0", VA = "0x180DC59E0")]
		public LoadedResourceHandle(AsyncOperationHandle<T> operationHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4466E0", Offset = "0x4452E0", VA = "0x1804466E0", Slot = "10")]
		protected override T TransformLoadedAsset(T loadedAsset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDC5930", Offset = "0xDC4530", VA = "0x180DC5930", Slot = "9")]
		protected sealed override void ReleaseResource()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xC244F0", Offset = "0xC230F0", VA = "0x180C244F0")]
	public static IResourceHandle<T> LoadAssetOrElse<T>(AssetReference assetReference, Func<IResourceHandle<T>> loadDefaultValue) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xC24570", Offset = "0xC23170", VA = "0x180C24570")]
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
