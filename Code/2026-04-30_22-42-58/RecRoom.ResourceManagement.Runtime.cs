using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.Async;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using UJect;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ResourceManagement_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9F7C900", Offset = "0x9F7BD00", VA = "0x189F7C900", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ResourceManagement_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F7FF30", Offset = "0x9F7F330", VA = "0x189F7FF30", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x29FCDD0", Offset = "0x29FC1D0", VA = "0x1829FCDD0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Core.ResourceManagement
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface QKUICRDERCX
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject STQNVOHDEON(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FCGSBMYYMMV<GameObject> JVSDTAZITDB(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SVGZEYJFNEF(string a, GameObject b, bool c);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void UBWWSHGPZVY(string a, bool b, bool c);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BVEQBNWLREB(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class PrefabCache : QKUICRDERCX, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class XGULYOGONJZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public string ICCPMPLFVYN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public IEVGXIBBHSU<(GameObject loadedAsset, AsyncOperationHandle<GameObject> handle)> WEHJUYPLKYH;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9F7FEA0", Offset = "0x9F7F2A0", VA = "0x189F7FEA0")]
			public XGULYOGONJZ(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private struct LoadedPrefab
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public GameObject Prefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public AsyncOperationHandle<GameObject> AddressablesHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class YSXXGNAWFKS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public GameObject WUSPPBRITRJ;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public YSXXGNAWFKS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
			internal void MTATIPYZSLL(GameObject a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class NXKJPKTRAET
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public Dictionary<string, LoadedPrefab> ZPXUCKXLUJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public string OHPWWMENOYP;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public NXKJPKTRAET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9F7C980", Offset = "0x9F7BD80", VA = "0x189F7C980")]
			internal GameObject VFAEXIADKNW((GameObject prefab, AsyncOperationHandle<GameObject> handle) tuple)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct <ProcessLoadRequestAsync>d__29 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public XGULYOGONJZ loadRequest;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private AsyncOperationHandle<IList<IResourceLocation>> <loadLocationHandle>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private ResourceRequest <resourceRequest>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private AsyncOperationHandle<GameObject> <addressablesHandle>5__4;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9F7E640", Offset = "0x9F7DA40", VA = "0x189F7E640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9F7F5E0", Offset = "0x9F7E9E0", VA = "0x189F7F5E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private struct <ProcessQueueAsync>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public PrefabCache <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9F7F640", Offset = "0x9F7EA40", VA = "0x189F7F640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9F7FE40", Offset = "0x9F7F240", VA = "0x189F7FE40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly Dictionary<string, LoadedPrefab> KDUAKDZVBPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Dictionary<string, LoadedPrefab> CGRJZZCAGUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly Queue<XGULYOGONJZ> UYCEVGXGONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly object MHUZCQYUANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly SemaphoreSlim RXOQRTAJWXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly CancellationTokenSource BYONGNYHLYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool ZIWJLCMIQDX;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F7DC60", Offset = "0x9F7D060", VA = "0x189F7DC60")]
		[BQDQKYYGTTM.Root.GameOnly]
		internal static void TDUDTGPDFOH(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9F7E330", Offset = "0x9F7D730", VA = "0x189F7E330")]
		[RecRoom.NoEngine.Common.Preserve]
		public PrefabCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9F7D0F0", Offset = "0x9F7C4F0", VA = "0x189F7D0F0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9F7D270", Offset = "0x9F7C670", VA = "0x189F7D270")]
		private void HYXXWOEAVJB(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9F7E090", Offset = "0x9F7D490", VA = "0x189F7E090")]
		private void VVVPTCEMRJW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9F7D750", Offset = "0x9F7CB50", VA = "0x189F7D750")]
		private void QIHNOSMEJWY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9F7D980", Offset = "0x9F7CD80", VA = "0x189F7D980", Slot = "4")]
		public GameObject STQNVOHDEON(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F7D3C0", Offset = "0x9F7C7C0", VA = "0x189F7D3C0", Slot = "5")]
		public FCGSBMYYMMV<GameObject> JVSDTAZITDB(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9F7D2D0", Offset = "0x9F7C6D0", VA = "0x189F7D2D0")]
		private GameObject JFHNFUZBIFW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9F7D3E0", Offset = "0x9F7C7E0", VA = "0x189F7D3E0")]
		private static LoadedPrefab KLNEOAENHMW(string a)
		{
			return default(LoadedPrefab);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9F7CF90", Offset = "0x9F7C390", VA = "0x189F7CF90", Slot = "8")]
		public void BVEQBNWLREB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9F7DB40", Offset = "0x9F7CF40", VA = "0x189F7DB40", Slot = "6")]
		public void SVGZEYJFNEF(string a, GameObject b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9F7DE80", Offset = "0x9F7D280", VA = "0x189F7DE80", Slot = "7")]
		public void UBWWSHGPZVY(string a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9F7CAE0", Offset = "0x9F7BEE0", VA = "0x189F7CAE0")]
		private FCGSBMYYMMV<GameObject> AYZZXGOAWRZ(string a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9F7CE00", Offset = "0x9F7C200", VA = "0x189F7CE00")]
		private FCGSBMYYMMV<GameObject> BLSOFBQFHTY(string a, Dictionary<string, LoadedPrefab> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9F7DD50", Offset = "0x9F7D150", VA = "0x189F7DD50")]
		private void TTPQQSTUQHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9F7DE90", Offset = "0x9F7D290", VA = "0x189F7DE90")]
		private FCGSBMYYMMV<(GameObject, AsyncOperationHandle<GameObject>)> UDBLKDJHUUY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9F7D000", Offset = "0x9F7C400", VA = "0x189F7D000")]
		[AsyncStateMachine(typeof(<ProcessQueueAsync>d__28))]
		private Task DXZZSXOSAWS(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9F7D640", Offset = "0x9F7CA40", VA = "0x189F7D640")]
		[AsyncStateMachine(typeof(<ProcessLoadRequestAsync>d__29))]
		private Task OWWYYHYVOQI(XGULYOGONJZ a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9F7D1F0", Offset = "0x9F7C5F0", VA = "0x189F7D1F0")]
		private bool HQJKDXTPVPI(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9F7D3A0", Offset = "0x9F7C7A0", VA = "0x189F7D3A0")]
		[CompilerGenerated]
		private int JQKAVWYCRPP(Task a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class VMPXGUYIROT
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x40B6AF0", Offset = "0x40B5EF0", VA = "0x1840B6AF0")]
		public static a XVEFIZIKCNZ<a>(string a) where a : UnityEngine.Object
		{
			return null;
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
