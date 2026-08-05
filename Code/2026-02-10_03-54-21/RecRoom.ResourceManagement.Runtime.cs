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
		[Cpp2IlInjected.Address(RVA = "0x8C0EA60", Offset = "0x8C0DC60", VA = "0x188C0EA60", Slot = "4")]
		public override void JUFURAKXVZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C11FE0", Offset = "0x8C111E0", VA = "0x188C11FE0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x27815F0", Offset = "0x27807F0", VA = "0x1827815F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Core.ResourceManagement
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface WQCGUDBMDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GameObject HMRIXONGKLB(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		YUBVFZQANJB<GameObject> BAIOJOHQWTT(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MVHFOAGBWXF(string a, GameObject b, bool c);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void AUNNGDCLFLK(string a, bool b, bool c);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GQYYHMQRBZV(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class PrefabCache : WQCGUDBMDCJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class AWNMRRYCWUZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public string KGCJBUJCVKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public PSJCSVSCOIC<(GameObject loadedAsset, AsyncOperationHandle<GameObject> handle)> JIQTMOOBEYN;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8C0E9D0", Offset = "0x8C0DBD0", VA = "0x188C0E9D0")]
			public AWNMRRYCWUZ(string a)
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
		private sealed class WNLGYASEDMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public GameObject JMMZRNCTCSB;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public WNLGYASEDMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xABA430", Offset = "0xAB9630", VA = "0x180ABA430")]
			internal void VGTNGOZXUBV(GameObject a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class MCLFJDBJANT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public Dictionary<string, LoadedPrefab> UJLRVRRDDMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public string SQGPSVRRDGN;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public MCLFJDBJANT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8C0EAE0", Offset = "0x8C0DCE0", VA = "0x188C0EAE0")]
			internal GameObject OOCYVLIRXAS((GameObject prefab, AsyncOperationHandle<GameObject> handle) tuple)
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
			public AWNMRRYCWUZ loadRequest;

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
			[Cpp2IlInjected.Address(RVA = "0x8C10790", Offset = "0x8C0F990", VA = "0x188C10790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8C11720", Offset = "0x8C10920", VA = "0x188C11720", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8C11780", Offset = "0x8C10980", VA = "0x188C11780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8C11F80", Offset = "0x8C11180", VA = "0x188C11F80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly Dictionary<string, LoadedPrefab> MEJUAUSQHAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Dictionary<string, LoadedPrefab> BKTFKUWIDMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly Queue<AWNMRRYCWUZ> MIIRVMHABPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly object ORRYOMASRZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly SemaphoreSlim IELOYNIQFRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly CancellationTokenSource OWZVCJSUJQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool WCTMPOAJLBF;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8C10210", Offset = "0x8C0F410", VA = "0x188C10210")]
		[OCFGNIRMEEE.Root.GameOnly]
		internal static void XXZSNELNZLP(CYZVJPHMMVM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8C10480", Offset = "0x8C0F680", VA = "0x188C10480")]
		[RecRoom.NoEngine.Common.Preserve]
		public PrefabCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8C0EEA0", Offset = "0x8C0E0A0", VA = "0x188C0EEA0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8C0FDA0", Offset = "0x8C0EFA0", VA = "0x188C0FDA0")]
		private void WCHGHKQEBKB(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8C0EC50", Offset = "0x8C0DE50", VA = "0x188C0EC50")]
		private void AVBYLNSNZJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8C0F4D0", Offset = "0x8C0E6D0", VA = "0x188C0F4D0")]
		private void JQFWLTZICNU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8C0F270", Offset = "0x8C0E470", VA = "0x188C0F270", Slot = "4")]
		public GameObject HMRIXONGKLB(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8C0EE80", Offset = "0x8C0E080", VA = "0x188C0EE80", Slot = "5")]
		public YUBVFZQANJB<GameObject> BAIOJOHQWTT(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8C0FCD0", Offset = "0x8C0EED0", VA = "0x188C0FCD0")]
		private GameObject UQJGNAXOLHI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8C0EFA0", Offset = "0x8C0E1A0", VA = "0x188C0EFA0")]
		private static LoadedPrefab FIKBTFZQNSI(string a)
		{
			return default(LoadedPrefab);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8C0F200", Offset = "0x8C0E400", VA = "0x188C0F200", Slot = "8")]
		public void GQYYHMQRBZV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8C0F700", Offset = "0x8C0E900", VA = "0x188C0F700", Slot = "6")]
		public void MVHFOAGBWXF(string a, GameObject b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8C0EC40", Offset = "0x8C0DE40", VA = "0x188C0EC40", Slot = "7")]
		public void AUNNGDCLFLK(string a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8C0FE00", Offset = "0x8C0F000", VA = "0x188C0FE00")]
		private YUBVFZQANJB<GameObject> WPUJQSZSJCF(string a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8C0FB50", Offset = "0x8C0ED50", VA = "0x188C0FB50")]
		private YUBVFZQANJB<GameObject> TWWNMYQJUWU(string a, Dictionary<string, LoadedPrefab> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8C0FA20", Offset = "0x8C0EC20", VA = "0x188C0FA20")]
		private void TEZIGTPHFNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8C0F820", Offset = "0x8C0EA20", VA = "0x188C0F820")]
		private YUBVFZQANJB<(GameObject, AsyncOperationHandle<GameObject>)> PTQBYJXMNZI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8C10120", Offset = "0x8C0F320", VA = "0x188C10120")]
		[AsyncStateMachine(typeof(<ProcessQueueAsync>d__28))]
		private Task XDVKCHALMFG(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8C10300", Offset = "0x8C0F500", VA = "0x188C10300")]
		[AsyncStateMachine(typeof(<ProcessLoadRequestAsync>d__29))]
		private Task ZUUOQLZKVGO(AWNMRRYCWUZ a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8C0F450", Offset = "0x8C0E650", VA = "0x188C0F450")]
		private bool IOPCGCKMUOY(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8C0F430", Offset = "0x8C0E630", VA = "0x188C0F430")]
		[CompilerGenerated]
		private int IHJRDVMPZPV(Task a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class ESENDWEYDJT
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x362AD10", Offset = "0x3629F10", VA = "0x18362AD10")]
		public static a WULNZWWRUHH<a>(string a) where a : UnityEngine.Object
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
