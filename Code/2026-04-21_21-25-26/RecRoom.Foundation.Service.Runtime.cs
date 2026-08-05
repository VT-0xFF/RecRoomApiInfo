using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
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
internal class IXBFVIJSSFJ
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
	[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
	public IXBFVIJSSFJ()
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
		[Cpp2IlInjected.Address(RVA = "0x99F5F60", Offset = "0x99F4960", VA = "0x1899F5F60", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class LCMYHXJEESI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3C11F00", Offset = "0x3C10900", VA = "0x183C11F00")]
		public static void NKAHUPVSFVI<c>(this KJVXVBNUPJI a, [Out] c b) where c : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3C11F80", Offset = "0x3C10980", VA = "0x183C11F80")]
		public static d NKAHUPVSFVI<d>(this KJVXVBNUPJI a) where d : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3C11E80", Offset = "0x3C10880", VA = "0x183C11E80")]
		public static bool EFGFCUDRQBD<e>(this KJVXVBNUPJI a, [Out] e b) where e : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99F4F70", Offset = "0x99F3970", VA = "0x1899F4F70")]
		public static void QFWGWPMQBAC(this KJVXVBNUPJI a, Lifetime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99F50E0", Offset = "0x99F3AE0", VA = "0x1899F50E0")]
		public static void VMQBQMTPUCO(this KJVXVBNUPJI a, Lifetime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x99F4CD0", Offset = "0x99F36D0", VA = "0x1899F4CD0")]
		public static void OKBXTYHIOPG(this KJVXVBNUPJI a, Lifetime b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class QUVMHTKQYEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3E7BA70", Offset = "0x3E7A470", VA = "0x183E7BA70")]
		public static bool EFGFCUDRQBD<a>(this IKBIXEGYPOI a, [Out] a b) where a : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3E7BC20", Offset = "0x3E7A620", VA = "0x183E7BC20")]
		public static c NKAHUPVSFVI<c>(this IKBIXEGYPOI a) where c : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3E7BD00", Offset = "0x3E7A700", VA = "0x183E7BD00")]
		public static void NKAHUPVSFVI<d>(this IKBIXEGYPOI a, [Out] d b) where d : class
		{
		}
	}
}
namespace RecRoom.Foundation.Service
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface ESSJZPWWELR<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface SZDUQTANYAQ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitInternal();
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface JIKZVPRDGWM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FNYWTFRYZOC(IKBIXEGYPOI a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface YWYIFNCKTFV
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitReferences(IKBIXEGYPOI services);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface PVENKBCWRBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitExternal(IKBIXEGYPOI services);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface YGSELBPVAKX
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DDGBNRVLWVD(IKBIXEGYPOI a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface JJEDGXFWBDV : SZDUQTANYAQ, YWYIFNCKTFV, PVENKBCWRBE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface HMEVPLUVQPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZCZVBWKAWEU();
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FGDXYNTAWZN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ShutdownReferences();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface ORELWRZKHYY
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LFKOHQORQPM();
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface JQVAGBYEMGQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LUFANJQDLDU();
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface NEODLRNIPVC
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		PhaseFlags YCZNVGZHTNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PHBPRTFLCEK(IKBIXEGYPOI a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface CDGSSMEOKIR
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AKLNXAAFTGV(IKBIXEGYPOI a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface ROHNBVEOEZI : SZDUQTANYAQ, JQVAGBYEMGQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface VUCHORACHIF : YWYIFNCKTFV, FGDXYNTAWZN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface LHEQUPAOLFC : PVENKBCWRBE, HMEVPLUVQPI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ServiceLifetime(Lifetime.Application)]
	public interface KJVXVBNUPJI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		IKBIXEGYPOI this[Lifetime lifetime]
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		Lifetime OYPTGPEOYDU
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		IKBIXEGYPOI BUKFSLLHQCW
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Add(Type bindType, object service);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Add(Type bindType, object service, Lifetime lifetime);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XXCCIAWPTND(Type[] a, object b, Lifetime c, ulong d);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ulong LJTVGPMSNOU(Type[] a, Lifetime b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool ZIPPNBINCTE(Type a, Lifetime b);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void QFWGWPMQBAC();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void VMQBQMTPUCO();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "10")]
		IDisposable TAXIRVPRUWU();
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface ASDYZVAVLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool EFGFCUDRQBD(Type a, [Out] object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface IKBIXEGYPOI : ASDYZVAVLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		Phase EHXUZVHLQYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Lifetime OYPTGPEOYDU
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
		private class BRDKXLAUULO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public BRDKXLAUULO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<IDisposable> WMTECGPJTUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly BRDKXLAUULO QCZRKEXMPWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool DZPJVTCESGG;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x99F4A10", Offset = "0x99F3410", VA = "0x1899F4A10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x99F4B70", Offset = "0x99F3570", VA = "0x1899F4B70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x99F4C20", Offset = "0x99F3620", VA = "0x1899F4C20")]
		public Disposables()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal class PhaseLists
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class CZCHTXMEYAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IKBIXEGYPOI SYKFLOQBMVR;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public CZCHTXMEYAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x99F49B0", Offset = "0x99F33B0", VA = "0x1899F49B0")]
			internal void FSCNXOCPSAY(CDGSSMEOKIR a, IKBIXEGYPOI b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Log ALDXGIVBEKZ;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker VDGJQYUEGHU;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly ProfilerMarker FMBHVDWEMCF;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly ProfilerMarker IPFABFHKZNV;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static readonly ProfilerMarker QEJDWGBEQQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly IKBIXEGYPOI GUKAWUKYTGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly List<object>[] BTEVFRYDLGP;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Phase EHXUZVHLQYF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(Phase);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool FOLKOMLFOTT
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xED9EB0", Offset = "0xED88B0", VA = "0x180ED9EB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xED9FA0", Offset = "0xED89A0", VA = "0x180ED9FA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x99F7500", Offset = "0x99F5F00", VA = "0x1899F7500")]
		public PhaseLists(IKBIXEGYPOI services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x99F6850", Offset = "0x99F5250", VA = "0x1899F6850")]
		public bool QXPMFRFYBEW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x99F6DF0", Offset = "0x99F57F0", VA = "0x1899F6DF0")]
		public bool VHOXRAUADQE(IKBIXEGYPOI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x99F6EE0", Offset = "0x99F58E0", VA = "0x1899F6EE0")]
		public bool ZGLJEWEGYCG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x99F62C0", Offset = "0x99F4CC0", VA = "0x1899F62C0")]
		private bool ASDNMCLBYWD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x99F63E0", Offset = "0x99F4DE0", VA = "0x1899F63E0")]
		public bool LNDYTTXMAEJ(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3E09210", Offset = "0x3E07C10", VA = "0x183E09210")]
		private bool TTMRXVBXXWS<a>(Action<a, IKBIXEGYPOI> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3E09730", Offset = "0x3E08130", VA = "0x183E09730")]
		private bool WZTTEFFAWJJ<b>(object a, Action<b, IKBIXEGYPOI> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3E09020", Offset = "0x3E07A20", VA = "0x183E09020")]
		private bool EVLQHIOBRHG<c>(Phase a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x99F66E0", Offset = "0x99F50E0", VA = "0x1899F66E0")]
		private void NFHPTTCWZKX(Phase a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[AttributeUsage(AttributeTargets.Class)]
	public class ServiceAllowDisposableAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		public ServiceAllowDisposableAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class ServiceInitOrder
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly ProfilerMarker WDTLGIGVBVL;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly ProfilerMarker PPMSIBOSKNZ;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly ProfilerMarker KWBYWWGQNRC;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly ProfilerMarker EEHYUVXYNKH;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly ProfilerMarker ADQDJSMSBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly SWTOLURXUHK NLVZAOKVVOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly Dictionary<Type, object> ZECNMLSUVXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly HashSet<object> GXJEMQAQOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Lifetime LRKBLOWEHLY;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99F8FA0", Offset = "0x99F79A0", VA = "0x1899F8FA0")]
		public ServiceInitOrder(Lifetime lifetime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x99F7580", Offset = "0x99F5F80", VA = "0x1899F7580")]
		public void Add(Type bindType, object service)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99F7A20", Offset = "0x99F6420", VA = "0x1899F7A20")]
		private void FYTXGDOEVVL(Type a, Type b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x99F78B0", Offset = "0x99F62B0", VA = "0x1899F78B0")]
		private void DWJDSGJVQXT(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x99F7610", Offset = "0x99F6010", VA = "0x1899F7610")]
		public void BQXMDYPUJQT(PhaseLists a, ASDYZVAVLIJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x99F8340", Offset = "0x99F6D40", VA = "0x1899F8340")]
		private void PLMVGOSACJU(PhaseLists a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x99F7D60", Offset = "0x99F6760", VA = "0x1899F7D60")]
		private void KNCCDCYPVRH(PhaseLists a, ASDYZVAVLIJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x99F7760", Offset = "0x99F6160", VA = "0x1899F7760")]
		private void DMUAPHOLIAR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x99F8170", Offset = "0x99F6B70", VA = "0x1899F8170")]
		private IEnumerable<Type> NMWZJNTRKTM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x99F8880", Offset = "0x99F7280", VA = "0x1899F8880")]
		private static bool UBBRPOOURJS(Type a, Type b, [Out] Lifetime c, [Out] string d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class LifetimeScopedServices
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly ProfilerMarker AUZRKYDKATD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly MZEBANDYSXL container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly ServiceInitOrder VHEZVYUGSES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly PhaseLists YZDABIAMHSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly Lifetime LRKBLOWEHLY;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Phase EHXUZVHLQYF
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x5394BC0", Offset = "0x53935C0", VA = "0x185394BC0")]
			get
			{
				return default(Phase);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MZEBANDYSXL DXKJZRWEENK
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x99F5D50", Offset = "0x99F4750", VA = "0x1899F5D50")]
		public LifetimeScopedServices(MZEBANDYSXL container, Lifetime lifetime, IKBIXEGYPOI access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x99F5610", Offset = "0x99F4010", VA = "0x1899F5610")]
		public void Add(Type type, object service)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x99F5C60", Offset = "0x99F4660", VA = "0x1899F5C60")]
		public bool XANUVMKNXHG(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x99F5850", Offset = "0x99F4250", VA = "0x1899F5850")]
		public bool Initialize(ASDYZVAVLIJ resolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		private void QMDCRLHJNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x99F5520", Offset = "0x99F3F20", VA = "0x1899F5520")]
		public void AKLNXAAFTGV(IKBIXEGYPOI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x99F5B50", Offset = "0x99F4550", VA = "0x1899F5B50")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x99F5B80", Offset = "0x99F4580", VA = "0x1899F5B80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x99F5B00", Offset = "0x99F4500", VA = "0x1899F5B00")]
		private static void NATRTPULVDW(Type a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x99F5BF0", Offset = "0x99F45F0", VA = "0x1899F5BF0")]
		private void WBAWPSWKMJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x99F5A20", Offset = "0x99F4420", VA = "0x1899F5A20")]
		private void LHKPLJKQFXB(Type a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate T ServiceFactory<out T>();
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[ServiceAllowDisposable]
	public class Services : KJVXVBNUPJI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private class VTLOGHGULWS : IKBIXEGYPOI, ASDYZVAVLIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private readonly Services GUKAWUKYTGZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private readonly Lifetime LRKBLOWEHLY;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private LifetimeScopedServices KCVMRLUAJLF
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x99FB080", Offset = "0x99F9A80", VA = "0x1899FB080")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public Phase EHXUZVHLQYF
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x99FB2D0", Offset = "0x99F9CD0", VA = "0x1899FB2D0", Slot = "4")]
				get
				{
					return default(Phase);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public Lifetime OYPTGPEOYDU
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340", Slot = "5")]
				get
				{
					return default(Lifetime);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x10773A0", Offset = "0x1075DA0", VA = "0x1810773A0")]
			public VTLOGHGULWS(Services a, Lifetime b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x99FB0C0", Offset = "0x99F9AC0", VA = "0x1899FB0C0", Slot = "7")]
			public bool EFGFCUDRQBD(Type a, [Out] object b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x99FB110", Offset = "0x99F9B10", VA = "0x1899FB110", Slot = "6")]
			public object Get(Type type)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private class NCQLYEQMGDB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private readonly MZEBANDYSXL.DeferCycleCheck[] VHDURTPCPJY;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x99F6150", Offset = "0x99F4B50", VA = "0x1899F6150")]
			public NCQLYEQMGDB(Services a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x99F60F0", Offset = "0x99F4AF0", VA = "0x1899F60F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly ProfilerMarker COXLNUSLPVT;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly ProfilerMarker ZBGYJOXTODI;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly ProfilerMarker VYWAEOWIDZY;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly ProfilerMarker GCLRHAWDFXG;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly ProfilerMarker MDQTKZXHYGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly LifetimeScopedServices[] HRFCQJCSFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly VTLOGHGULWS[] NTIIPVJWEVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Lifetime LRKBLOWEHLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool DZPJVTCESGG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private IKBIXEGYPOI RKFASMYXAWK
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x99F9870", Offset = "0x99F8270", VA = "0x1899F9870", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Lifetime OYPTGPEOYDU
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0", Slot = "5")]
			get
			{
				return default(Lifetime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IKBIXEGYPOI this[Lifetime lifetime]
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x899BEA0", Offset = "0x899A8A0", VA = "0x18899BEA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		internal LifetimeScopedServices BUKFSLLHQCW
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x89AAFD0", Offset = "0x89A99D0", VA = "0x1889AAFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		internal LifetimeScopedServices OSLKHNLSUGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x99F9BA0", Offset = "0x99F85A0", VA = "0x1899F9BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x99F9630", Offset = "0x99F8030", VA = "0x1899F9630")]
		public static KJVXVBNUPJI Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x99F95B0", Offset = "0x99F7FB0", VA = "0x1899F95B0")]
		public static KJVXVBNUPJI Create(MZEBANDYSXL container)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x99F9790", Offset = "0x99F8190", VA = "0x1899F9790")]
		public static KJVXVBNUPJI FMFJCUVFKXI(MZEBANDYSXL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x99FA890", Offset = "0x99F9290", VA = "0x1899FA890")]
		private Services(MZEBANDYSXL rootContainer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x99F91C0", Offset = "0x99F7BC0", VA = "0x1899F91C0", Slot = "7")]
		public void Add(Type bindType, object service)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x99F90B0", Offset = "0x99F7AB0", VA = "0x1899F90B0", Slot = "8")]
		public void Add(Type bindType, object service, Lifetime lifetime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x99F98B0", Offset = "0x99F82B0", VA = "0x1899F98B0", Slot = "10")]
		public ulong LJTVGPMSNOU(Type[] a, Lifetime b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x99FA5A0", Offset = "0x99F8FA0", VA = "0x1899FA5A0", Slot = "11")]
		public bool ZIPPNBINCTE(Type a, Lifetime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x99FA460", Offset = "0x99F8E60", VA = "0x1899FA460", Slot = "9")]
		public void XXCCIAWPTND(Type[] a, object b, Lifetime c, ulong d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x99F9EF0", Offset = "0x99F88F0", VA = "0x1899F9EF0", Slot = "14")]
		public IDisposable TAXIRVPRUWU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x99F9C20", Offset = "0x99F8620", VA = "0x1899F9C20", Slot = "12")]
		public void QFWGWPMQBAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x99FA090", Offset = "0x99F8A90", VA = "0x1899FA090", Slot = "13")]
		public void VMQBQMTPUCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x99F9710", Offset = "0x99F8110", VA = "0x1899F9710", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x99F9E90", Offset = "0x99F8890", VA = "0x1899F9E90")]
		private bool QLMSUKAPNXL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x99F9BD0", Offset = "0x99F85D0", VA = "0x1899F9BD0")]
		private void OBNYFOZLHEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x99FA3D0", Offset = "0x99F8DD0", VA = "0x1899FA3D0")]
		private bool XANUVMKNXHG(Type a, Lifetime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x99F92E0", Offset = "0x99F7CE0", VA = "0x1899F92E0")]
		private bool CIXYHSULYHP(Type a, [Out] Lifetime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x99FA240", Offset = "0x99F8C40", VA = "0x1899FA240")]
		private void WTHYFZWEIFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x99F9370", Offset = "0x99F7D70", VA = "0x1899F9370")]
		private static LifetimeScopedServices[] CYUBNYGLBLS(MZEBANDYSXL a, VTLOGHGULWS[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x99F9AA0", Offset = "0x99F84A0", VA = "0x1899F9AA0")]
		private VTLOGHGULWS[] MXMTZNRXRGX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum Phase
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		Uninitialized = -1,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		InitInternal,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		InitReferencesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		InitReferences,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		InitExternal,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		PostInit,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		Initialized,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		ScopeChange,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		ShutdownExternal,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		ShutdownReferences,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		ShutdownReferencesGenerated,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		ShutdownInternal,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		PhaseCount
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[Flags]
	public enum PhaseFlags
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		Uninitialized = 0,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		InitInternal = 1,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		InitReferencesGenerated = 2,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		InitReferences = 4,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		InitExternal = 8,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		PostInit = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Initialized = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		ScopeChange = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		ShutdownExternal = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		ShutdownReferences = 0x100,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		ShutdownReferencesGenerated = 0x200,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		ShutdownInternal = 0x400,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		CoreInit = 0xF,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		AllInit = 0x1F,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		AllShutdown = 0x780,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		All = 0x79F
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class LIFDDXRWPZE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x99F5250", Offset = "0x99F3C50", VA = "0x1899F5250")]
		public static Exception BVDCQPLNZSV(Type a, Lifetime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x99F52E0", Offset = "0x99F3CE0", VA = "0x1899F52E0")]
		public static Exception FAJQTVGLRNG(Type a, Lifetime b, Type c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x99F5370", Offset = "0x99F3D70", VA = "0x1899F5370")]
		public static Type HMUPYTYLVTL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x99F54E0", Offset = "0x99F3EE0", VA = "0x1899F54E0")]
		private static string QJAEMHJTDGK(Type a, Lifetime b, Type c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x99F54E0", Offset = "0x99F3EE0", VA = "0x1899F54E0")]
		private static string VKRGEDLYXXO(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public enum ShutdownPhase
	{
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Uninitialized = -1,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		ShutdownInternal,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		ShutdownReferences,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		ShutdownContent,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Initialized
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class KQQIHWCZVOV
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
