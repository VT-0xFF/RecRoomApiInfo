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
		[Cpp2IlInjected.Address(RVA = "0xA057B90", Offset = "0xA056590", VA = "0x18A057B90", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA05B1A0", Offset = "0xA059BA0", VA = "0x18A05B1A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x29FAE60", Offset = "0x29F9860", VA = "0x1829FAE60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA05B110", Offset = "0xA059B10", VA = "0x18A05B110")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public YSXXGNAWFKS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E00", Offset = "0xCD5800", VA = "0x180CD6E00")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public NXKJPKTRAET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA057C10", Offset = "0xA056610", VA = "0x18A057C10")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0598C0", Offset = "0xA0582C0", VA = "0x18A0598C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA05A850", Offset = "0xA059250", VA = "0x18A05A850", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA05A8B0", Offset = "0xA0592B0", VA = "0x18A05A8B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA05B0B0", Offset = "0xA059AB0", VA = "0x18A05B0B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA058EE0", Offset = "0xA0578E0", VA = "0x18A058EE0")]
		[BQDQKYYGTTM.Root.GameOnly]
		internal static void TDUDTGPDFOH(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA0595B0", Offset = "0xA057FB0", VA = "0x18A0595B0")]
		[RecRoom.NoEngine.Common.Preserve]
		public PrefabCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA058370", Offset = "0xA056D70", VA = "0x18A058370", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA0584F0", Offset = "0xA056EF0", VA = "0x18A0584F0")]
		private void HYXXWOEAVJB(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA059310", Offset = "0xA057D10", VA = "0x18A059310")]
		private void VVVPTCEMRJW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA0589D0", Offset = "0xA0573D0", VA = "0x18A0589D0")]
		private void QIHNOSMEJWY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA058C00", Offset = "0xA057600", VA = "0x18A058C00", Slot = "4")]
		public GameObject STQNVOHDEON(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA058640", Offset = "0xA057040", VA = "0x18A058640", Slot = "5")]
		public FCGSBMYYMMV<GameObject> JVSDTAZITDB(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA058550", Offset = "0xA056F50", VA = "0x18A058550")]
		private GameObject JFHNFUZBIFW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA058660", Offset = "0xA057060", VA = "0x18A058660")]
		private static LoadedPrefab KLNEOAENHMW(string a)
		{
			return default(LoadedPrefab);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA058210", Offset = "0xA056C10", VA = "0x18A058210", Slot = "8")]
		public void BVEQBNWLREB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA058DC0", Offset = "0xA0577C0", VA = "0x18A058DC0", Slot = "6")]
		public void SVGZEYJFNEF(string a, GameObject b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA059100", Offset = "0xA057B00", VA = "0x18A059100", Slot = "7")]
		public void UBWWSHGPZVY(string a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA057D70", Offset = "0xA056770", VA = "0x18A057D70")]
		private FCGSBMYYMMV<GameObject> AYZZXGOAWRZ(string a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA058090", Offset = "0xA056A90", VA = "0x18A058090")]
		private FCGSBMYYMMV<GameObject> BLSOFBQFHTY(string a, Dictionary<string, LoadedPrefab> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA058FD0", Offset = "0xA0579D0", VA = "0x18A058FD0")]
		private void TTPQQSTUQHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA059110", Offset = "0xA057B10", VA = "0x18A059110")]
		private FCGSBMYYMMV<(GameObject, AsyncOperationHandle<GameObject>)> UDBLKDJHUUY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA058280", Offset = "0xA056C80", VA = "0x18A058280")]
		[AsyncStateMachine(typeof(<ProcessQueueAsync>d__28))]
		private Task DXZZSXOSAWS(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA0588C0", Offset = "0xA0572C0", VA = "0x18A0588C0")]
		[AsyncStateMachine(typeof(<ProcessLoadRequestAsync>d__29))]
		private Task OWWYYHYVOQI(XGULYOGONJZ a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA058470", Offset = "0xA056E70", VA = "0x18A058470")]
		private bool HQJKDXTPVPI(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA058620", Offset = "0xA057020", VA = "0x18A058620")]
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
		[Cpp2IlInjected.Address(RVA = "0x40C1EC0", Offset = "0x40C08C0", VA = "0x1840C1EC0")]
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
