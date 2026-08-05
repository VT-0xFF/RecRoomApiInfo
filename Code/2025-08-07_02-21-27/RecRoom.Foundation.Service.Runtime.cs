using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Foundation.Collections;
using RecRoom.Foundation.Service;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using UJect;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class DZISONAGUEP
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
	public DZISONAGUEP()
	{
	}
}
namespace _LogRegistration.RecRoom_Foundation_Service_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8A2F370", Offset = "0x8A2DF70", VA = "0x188A2F370", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class TEIKKJIEJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x40344E0", Offset = "0x40330E0", VA = "0x1840344E0")]
		public static void AHIAETVHJOS<c>(this BDOPQIINDDA a, [Out] c b) where c : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4034560", Offset = "0x4033160", VA = "0x184034560")]
		public static d AHIAETVHJOS<d>(this BDOPQIINDDA a) where d : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4034460", Offset = "0x4033060", VA = "0x184034460")]
		public static bool ADEQMFSTXTP<e>(this BDOPQIINDDA a, [Out] e b) where e : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A33FA0", Offset = "0x8A32BA0", VA = "0x188A33FA0")]
		public static void CQEKXCJVPXA(this BDOPQIINDDA a, Lifetime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A34100", Offset = "0x8A32D00", VA = "0x188A34100")]
		public static void KPJDJGJISIG(this BDOPQIINDDA a, Lifetime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8A34260", Offset = "0x8A32E60", VA = "0x188A34260")]
		public static void VJJWLICRUGE(this BDOPQIINDDA a, Lifetime b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class TSUDTZATUFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4039300", Offset = "0x4037F00", VA = "0x184039300")]
		public static bool ADEQMFSTXTP<a>(this BVNDYEZSFBO a, [Out] a b) where a : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x40394B0", Offset = "0x40380B0", VA = "0x1840394B0")]
		public static b ADEQMFSTXTP<b>(this BVNDYEZSFBO a) where b : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4039750", Offset = "0x4038350", VA = "0x184039750")]
		public static c AHIAETVHJOS<c>(this BVNDYEZSFBO a) where c : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4039610", Offset = "0x4038210", VA = "0x184039610")]
		public static void AHIAETVHJOS<d>(this BVNDYEZSFBO a, [Out] d b) where d : class
		{
		}
	}
}
namespace RecRoom.Foundation.Service
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface QFQRDWXDJUX<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface MOWQOGDYZLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitInternal();
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface GAEEWOIWDJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void VCIHLXOICAG(BVNDYEZSFBO a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface PEEXKGKATXF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitReferences(BVNDYEZSFBO services);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface YGTTGTSBWNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitExternal(BVNDYEZSFBO services);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface MNXVATUOHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JBENIRXJBGJ(BVNDYEZSFBO a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface UFBXRRZACID : MOWQOGDYZLC, PEEXKGKATXF, YGTTGTSBWNM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface UJJANZWBMES
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ShutdownExternal();
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface SJOHKXRHEUT
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ShutdownReferences();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface OBETOEUHEYQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FWAIHKPEJFA();
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface BMZVOVVGZNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ShutdownInternal();
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface AWCHYBFOBLC
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		PhaseFlags NHUCQALJIWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void InitPhase(BVNDYEZSFBO services);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface FFDEMKOYDYB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ScopeChanged(BVNDYEZSFBO services);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface MECCJSHSEPI : MOWQOGDYZLC, BMZVOVVGZNC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface PRZRNKKWHDL : PEEXKGKATXF, SJOHKXRHEUT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface ANDQGXMMLTC : YGTTGTSBWNM, UJJANZWBMES
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ServiceLifetime(Lifetime.Application)]
	public interface BDOPQIINDDA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		BVNDYEZSFBO this[Lifetime lifetime]
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		Lifetime TSPZKYFAEXI
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		BVNDYEZSFBO TLYNLRORKKK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Add(Type bindType, object service, Lifetime lifetime);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GAKYZTOGNAB(Type[] a, object b, Lifetime c, ulong d);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ulong TTCDSBQXYHS(Type[] a, Lifetime b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DZMTOADETIS(Type a, Lifetime b);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void CQEKXCJVPXA();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void KPJDJGJISIG();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IDisposable PINYGTLZDAI();
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface XOEVBGTOYZP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ADEQMFSTXTP(Type a, [Out] object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface BVNDYEZSFBO : XOEVBGTOYZP
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		Phase KNEACQXVHNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Lifetime TSPZKYFAEXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		object Get(Type type);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal class Disposables : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class NXXTUYPESWU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private readonly HashSet<IDisposable> RDAEVVFTNQX;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8A2F4C0", Offset = "0x8A2E0C0", VA = "0x188A2F4C0")]
			[Conditional("UNITY_EDITOR")]
			[Conditional("DEBUG_BUILD")]
			public void Clear()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8A2F510", Offset = "0x8A2E110", VA = "0x188A2F510")]
			public NXXTUYPESWU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<IDisposable> AUMQZTVECXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly NXXTUYPESWU IKSZQLJWCJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool JDQGFFMCCEG;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8A2C460", Offset = "0x8A2B060", VA = "0x188A2C460")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8A2C750", Offset = "0x8A2B350", VA = "0x188A2C750", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8A2C800", Offset = "0x8A2B400", VA = "0x188A2C800")]
		public Disposables()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal class LLGNNLEKSSN
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class XPNAWOTYTOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public BVNDYEZSFBO LDBGBZHIFPF;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XPNAWOTYTOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8A358F0", Offset = "0x8A344F0", VA = "0x188A358F0")]
			internal void WJQRUJPSTHS(FFDEMKOYDYB a, BVNDYEZSFBO b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static readonly ProfilerMarker RQAGYJEAJJI;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly ProfilerMarker KCNMLZLPJEZ;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly ProfilerMarker TCTFJTDYZRZ;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly ProfilerMarker TWYNVQJLGPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly BVNDYEZSFBO QAHOXJHWHNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<object>[] BTIDCHPXMRB;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Phase KNEACQXVHNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0")]
			[CompilerGenerated]
			get
			{
				return default(Phase);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xB6A400", Offset = "0xB69000", VA = "0x180B6A400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool WFTGYVIQRAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xF1F280", Offset = "0xF1DE80", VA = "0x180F1F280")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xF1F440", Offset = "0xF1E040", VA = "0x180F1F440")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8A2E250", Offset = "0x8A2CE50", VA = "0x188A2E250")]
		public LLGNNLEKSSN(BVNDYEZSFBO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8A2CCD0", Offset = "0x8A2B8D0", VA = "0x188A2CCD0")]
		public bool JVVNYSAUSKK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8A2D890", Offset = "0x8A2C490", VA = "0x188A2D890")]
		public bool PTVDYYJFSDO(BVNDYEZSFBO a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8A2D270", Offset = "0x8A2BE70", VA = "0x188A2D270")]
		public bool LKHSPJCFXMS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8A2CBB0", Offset = "0x8A2B7B0", VA = "0x188A2CBB0")]
		private bool DYHNKWDAOHV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8A2DE20", Offset = "0x8A2CA20", VA = "0x188A2DE20")]
		public bool XNARJNKNTAJ(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE9E0", Offset = "0x3CAD5E0", VA = "0x183CAE9E0")]
		private bool THPVQPBJESK<a>(Action<a, BVNDYEZSFBO> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3CAEFA0", Offset = "0x3CADBA0", VA = "0x183CAEFA0")]
		private bool WHTRVEYPXVJ<b>(object a, Action<b, BVNDYEZSFBO> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3CAEC70", Offset = "0x3CAD870", VA = "0x183CAEC70")]
		private bool VNLQKVVZNFO<c>(Phase a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8A2D720", Offset = "0x8A2C320", VA = "0x188A2D720")]
		private void LRYTUXNGOKX(Phase a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8A2D980", Offset = "0x8A2C580", VA = "0x188A2D980")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void VYLHNPLGOKC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE770", Offset = "0x3CAD370", VA = "0x183CAE770")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void CTRTUSHGITM<d>(object a, string b, params Type[] args)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[AttributeUsage(AttributeTargets.Class)]
	public class ServiceAllowDisposableAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public ServiceAllowDisposableAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class ServiceInitOrder
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly ProfilerMarker MELQEVJHWSJ;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly ProfilerMarker KXKXIGVOQKL;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly ProfilerMarker WAFPJCRNZOE;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly ProfilerMarker QNQWALYDMPF;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly ProfilerMarker GAQJDEZTOME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly QOXQDWPBNGM XDYEMTISHTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly Dictionary<Type, object> QKLMMIZVAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<object> WBQGEQTOHRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly Lifetime LEFHPRLRDOO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		internal int JFXQJUOQDDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCB0B00", Offset = "0xCAF700", VA = "0x180CB0B00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x20AD150", Offset = "0x20ABD50", VA = "0x1820AD150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8A31EB0", Offset = "0x8A30AB0", VA = "0x188A31EB0")]
		public ServiceInitOrder(Lifetime lifetime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8A2F590", Offset = "0x8A2E190", VA = "0x188A2F590")]
		public void Add(Type bindType, object service)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8A2FD30", Offset = "0x8A2E930", VA = "0x188A2FD30")]
		private void FRULYZGGGWJ(Type a, Type b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8A2F8C0", Offset = "0x8A2E4C0", VA = "0x188A2F8C0")]
		private void EGGUOZQXNMZ(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8A30E30", Offset = "0x8A2FA30", VA = "0x188A30E30")]
		public void NYZQOLHOHDB(LLGNNLEKSSN a, XOEVBGTOYZP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8A30F80", Offset = "0x8A2FB80", VA = "0x188A30F80")]
		private void RPNMLFQTWJY(LLGNNLEKSSN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8A30060", Offset = "0x8A2EC60", VA = "0x188A30060")]
		private void IAMMCQAHNHX(LLGNNLEKSSN a, XOEVBGTOYZP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8A31820", Offset = "0x8A30420", VA = "0x188A31820")]
		private void TSLJWHLQNSF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8A31970", Offset = "0x8A30570", VA = "0x188A31970")]
		private IEnumerable<Type> UEFPUUUSKUG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8A308B0", Offset = "0x8A2F4B0", VA = "0x188A308B0")]
		private static bool IEMURUINVGM(Type a, Type b, [Out] Lifetime c, [Out] string d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8A317C0", Offset = "0x8A303C0", VA = "0x188A317C0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TOFXEOSMWVJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8A2FC60", Offset = "0x8A2E860", VA = "0x188A2FC60")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void FDWJCBKKAVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8A31B40", Offset = "0x8A30740", VA = "0x188A31B40")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void UXDILBGLTPH(ZOKMZDQINFS<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8A2F7B0", Offset = "0x8A2E3B0", VA = "0x188A2F7B0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void BHLMTTLMOBN(Type a, Type b, Lifetime c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class LifetimeScopedServices
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly ProfilerMarker EABGVXBZAEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly DiContainer container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly ServiceInitOrder GXOAVLSMYHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly LLGNNLEKSSN PJDASMYJIYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Lifetime LEFHPRLRDOO;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Phase KNEACQXVHNL
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8A2EB60", Offset = "0x8A2D760", VA = "0x188A2EB60")]
			get
			{
				return default(Phase);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public DiContainer ZKAOXXLCNTG
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8A2EFF0", Offset = "0x8A2DBF0", VA = "0x188A2EFF0")]
		public LifetimeScopedServices(DiContainer container, Lifetime lifetime, BVNDYEZSFBO access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8A2E2D0", Offset = "0x8A2CED0", VA = "0x188A2E2D0")]
		public void Add(Type type, object service)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8A2EB30", Offset = "0x8A2D730", VA = "0x188A2EB30")]
		public bool MKEZEUELTNG(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8A2E800", Offset = "0x8A2D400", VA = "0x188A2E800")]
		public bool Initialize(XOEVBGTOYZP resolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8A2E7E0", Offset = "0x8A2D3E0", VA = "0x188A2E7E0")]
		private void IPVWFPTNZED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8A2EDA0", Offset = "0x8A2D9A0", VA = "0x188A2EDA0")]
		public void ScopeChanged(BVNDYEZSFBO newScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8A2EBF0", Offset = "0x8A2D7F0", VA = "0x188A2EBF0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8A2EEC0", Offset = "0x8A2DAC0", VA = "0x188A2EEC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8A2E790", Offset = "0x8A2D390", VA = "0x188A2E790")]
		private static void ESGESXMJQJS(Type a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8A2EB80", Offset = "0x8A2D780", VA = "0x188A2EB80")]
		private void RDCKIUBVLBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8A2E6B0", Offset = "0x8A2D2B0", VA = "0x188A2E6B0")]
		private void DCZIPNUYRNB(Type a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate T ServiceFactory<out T>();
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[ServiceAllowDisposable]
	public class Services : BDOPQIINDDA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class GKZLFBJCKCS : BVNDYEZSFBO, XOEVBGTOYZP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private readonly Services QAHOXJHWHNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private readonly Lifetime LEFHPRLRDOO;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private LifetimeScopedServices AJSKXARUZFF
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x8A2CB20", Offset = "0x8A2B720", VA = "0x188A2CB20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public Phase KNEACQXVHNL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0x8A2CB60", Offset = "0x8A2B760", VA = "0x188A2CB60", Slot = "4")]
				get
				{
					return default(Phase);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public Lifetime TSPZKYFAEXI
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780", Slot = "5")]
				get
				{
					return default(Lifetime);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x1118100", Offset = "0x1116D00", VA = "0x181118100")]
			public GKZLFBJCKCS(Services a, Lifetime b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8A2C910", Offset = "0x8A2B510", VA = "0x188A2C910", Slot = "7")]
			public bool ADEQMFSTXTP(Type a, [Out] object b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8A2C960", Offset = "0x8A2B560", VA = "0x188A2C960", Slot = "6")]
			public object Get(Type type)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private class WTMAPGOFXEP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private readonly DiContainer.DeferCycleCheck[] NHPWPSTZPQO;

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8A35780", Offset = "0x8A34380", VA = "0x188A35780")]
			public WTMAPGOFXEP(Services a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8A35720", Offset = "0x8A34320", VA = "0x188A35720", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly ProfilerMarker LXAGMBKDXSF;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static readonly ProfilerMarker JOAEOEJLVPY;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly ProfilerMarker TTMFZVRVIVY;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly ProfilerMarker RRUNZOMYYHG;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly ProfilerMarker ATWSSMKASCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly LifetimeScopedServices[] JJTETLDWJYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly GKZLFBJCKCS[] UXEZEQWCSDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Lifetime LEFHPRLRDOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool JDQGFFMCCEG;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private BVNDYEZSFBO VJOSIBMXBEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8A335C0", Offset = "0x8A321C0", VA = "0x188A335C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Lifetime TSPZKYFAEXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0", Slot = "5")]
			get
			{
				return default(Lifetime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BVNDYEZSFBO this[Lifetime lifetime]
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2D0B000", Offset = "0x2D09C00", VA = "0x182D0B000", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		internal LifetimeScopedServices TLYNLRORKKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7A096C0", Offset = "0x7A082C0", VA = "0x187A096C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		internal LifetimeScopedServices FDJBKBYGZNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8A32F60", Offset = "0x8A31B60", VA = "0x188A32F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8A32990", Offset = "0x8A31590", VA = "0x188A32990")]
		public static BDOPQIINDDA Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8A32910", Offset = "0x8A31510", VA = "0x188A32910")]
		public static BDOPQIINDDA Create(DiContainer container)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8A33250", Offset = "0x8A31E50", VA = "0x188A33250")]
		public static BDOPQIINDDA LTNWIJNZOFI(DiContainer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8A33D50", Offset = "0x8A32950", VA = "0x188A33D50")]
		private Services(DiContainer rootContainer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8A321C0", Offset = "0x8A30DC0", VA = "0x188A321C0", Slot = "15")]
		public void Add(Type bindType, object service)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8A32000", Offset = "0x8A30C00", VA = "0x188A32000", Slot = "7")]
		public void Add(Type bindType, object service, Lifetime lifetime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8A33600", Offset = "0x8A32200", VA = "0x188A33600", Slot = "9")]
		public ulong TTCDSBQXYHS(Type[] a, Lifetime b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8A32A70", Offset = "0x8A31670", VA = "0x188A32A70", Slot = "10")]
		public bool DZMTOADETIS(Type a, Lifetime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8A32DE0", Offset = "0x8A319E0", VA = "0x188A32DE0", Slot = "8")]
		public void GAKYZTOGNAB(Type[] a, object b, Lifetime c, ulong d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8A333C0", Offset = "0x8A31FC0", VA = "0x188A333C0", Slot = "13")]
		public IDisposable PINYGTLZDAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8A32340", Offset = "0x8A30F40", VA = "0x188A32340", Slot = "11")]
		public void CQEKXCJVPXA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8A32F90", Offset = "0x8A31B90", VA = "0x188A32F90", Slot = "12")]
		public void KPJDJGJISIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8A32BB0", Offset = "0x8A317B0", VA = "0x188A32BB0", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8A33560", Offset = "0x8A32160", VA = "0x188A33560")]
		private bool PUGHBCQYZQN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8A32F20", Offset = "0x8A31B20", VA = "0x188A32F20")]
		private void HKMXICKCRDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8A33330", Offset = "0x8A31F30", VA = "0x188A33330")]
		private bool MKEZEUELTNG(Type a, Lifetime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8A32D50", Offset = "0x8A31950", VA = "0x188A32D50")]
		private bool ECDBRCHWTPH(Type a, [Out] Lifetime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8A32760", Offset = "0x8A31360", VA = "0x188A32760")]
		private void CYISHJQSWBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8A33960", Offset = "0x8A32560", VA = "0x188A33960")]
		private static LifetimeScopedServices[] VQUBUHFJBKA(DiContainer a, GKZLFBJCKCS[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8A337F0", Offset = "0x8A323F0", VA = "0x188A337F0")]
		private GKZLFBJCKCS[] UMCBFKQBBJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8A2E790", Offset = "0x8A2D390", VA = "0x188A2E790")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private static void KMJTDCWGHUY(Type a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8A338F0", Offset = "0x8A324F0", VA = "0x188A338F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private static void UREVILLPHJW(Type a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8A326F0", Offset = "0x8A312F0", VA = "0x188A326F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void CWEUMCJKQFQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum Phase
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		Uninitialized = -1,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		InitInternal,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		InitReferencesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		InitReferences,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		InitExternal,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		PostInit,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Initialized,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		ScopeChange,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		ShutdownExternal,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		ShutdownReferences,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		ShutdownReferencesGenerated,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		ShutdownInternal,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		PhaseCount
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Flags]
	public enum PhaseFlags
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Uninitialized = 0,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		InitInternal = 1,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		InitReferencesGenerated = 2,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		InitReferences = 4,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		InitExternal = 8,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		PostInit = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Initialized = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		ScopeChange = 0x40,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		ShutdownExternal = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		ShutdownReferences = 0x100,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		ShutdownReferencesGenerated = 0x200,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		ShutdownInternal = 0x400,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		CoreInit = 0xF,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		AllInit = 0x1F,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		AllShutdown = 0x780,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		All = 0x79F
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class UYBXCZRDDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8A35690", Offset = "0x8A34290", VA = "0x188A35690")]
		public static Exception YTLEAXPAZIV(Type a, Lifetime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8A35490", Offset = "0x8A34090", VA = "0x188A35490")]
		public static Exception KWFOSRQVMQQ(Type a, Lifetime b, Type c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8A35520", Offset = "0x8A34120", VA = "0x188A35520")]
		public static Type UPEMYYVYCMZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8A35450", Offset = "0x8A34050", VA = "0x188A35450")]
		private static string DGOLYKKIOPI(Type a, Lifetime b, Type c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8A35450", Offset = "0x8A34050", VA = "0x188A35450")]
		private static string BNIGTQJCBEA(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum ShutdownPhase
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		Uninitialized = -1,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		ShutdownInternal,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		ShutdownReferences,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		ShutdownContent,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Initialized
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal static class UCYUNRNHRTP
	{
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
