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
internal class WTBFLPCTUEB
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
	[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
	public WTBFLPCTUEB()
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
		[Cpp2IlInjected.Address(RVA = "0x84B2150", Offset = "0x84B0F50", VA = "0x1884B2150", Slot = "4")]
		public override void IPFDCTVTWHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class TPSFNJSTZBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3D33460", Offset = "0x3D32260", VA = "0x183D33460")]
		public static void CCQENQPWLWQ<c>(this CERMPDGXYNS a, [Out] c b) where c : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3D334E0", Offset = "0x3D322E0", VA = "0x183D334E0")]
		public static d CCQENQPWLWQ<d>(this CERMPDGXYNS a) where d : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3D33550", Offset = "0x3D32350", VA = "0x183D33550")]
		public static bool HFGIPAZTZGX<e>(this CERMPDGXYNS a, [Out] e b) where e : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84B59D0", Offset = "0x84B47D0", VA = "0x1884B59D0")]
		public static void HQGBKTYUFYQ(this CERMPDGXYNS a, Lifetime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84B5B40", Offset = "0x84B4940", VA = "0x1884B5B40")]
		public static void KAVPMFSGVAU(this CERMPDGXYNS a, Lifetime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84B5CB0", Offset = "0x84B4AB0", VA = "0x1884B5CB0")]
		public static void QQOSPBFAGUS(this CERMPDGXYNS a, Lifetime b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class LZAULAOXKTO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x39C3D90", Offset = "0x39C2B90", VA = "0x1839C3D90")]
		public static bool HFGIPAZTZGX<a>(this YKMTYEBAAOC a, [Out] a b) where a : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x39C3CB0", Offset = "0x39C2AB0", VA = "0x1839C3CB0")]
		public static c CCQENQPWLWQ<c>(this YKMTYEBAAOC a) where c : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x39C3B70", Offset = "0x39C2970", VA = "0x1839C3B70")]
		public static void CCQENQPWLWQ<d>(this YKMTYEBAAOC a, [Out] d b) where d : class
		{
		}
	}
}
namespace RecRoom.Foundation.Service
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface ZXIOZKABGHT<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface IFVEAFHUJHU
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitInternal();
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface OQVTAWVSILE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SXTLJXSESHW(YKMTYEBAAOC a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface LYBXKQOLIUF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitReferences(YKMTYEBAAOC services);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface XBOLCYDYDAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitExternal(YKMTYEBAAOC services);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface DXMSNGPOYLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NTDDNBMPTFZ(YKMTYEBAAOC a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface PCRUMRFIXDD : IFVEAFHUJHU, LYBXKQOLIUF, XBOLCYDYDAA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface OZGSEXBXCXO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JKEMGOBUBBM();
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface JFNNEAWOERD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ShutdownReferences();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface CKMVDEYKLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GJYBNMNYCPS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface BQLXQKHZRWO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QDLPFTNMELS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface TCMMDPAGKSW
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		PhaseFlags JKEOYMAEQHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QEQMAIUWDSM(YKMTYEBAAOC a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface LIUHYBSTFYH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FQYMSXHBSEL(YKMTYEBAAOC a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface WEUUFDGSMJS : IFVEAFHUJHU, BQLXQKHZRWO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface UEHYRVMCIWT : LYBXKQOLIUF, JFNNEAWOERD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface WAKURPWFEEW : XBOLCYDYDAA, OZGSEXBXCXO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ServiceLifetime(Lifetime.Application)]
	public interface CERMPDGXYNS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		YKMTYEBAAOC this[Lifetime lifetime]
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		Lifetime EXVEIWYUACQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		YKMTYEBAAOC VVQPNDJKPQI
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Add(Type bindType, object service, Lifetime lifetime);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RPSJBOHTYNJ(Type[] a, object b, Lifetime c, ulong d);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ulong DJDPOKDOVYC(Type[] a, Lifetime b);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool PZKCECJZFXK(Type a, Lifetime b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void HQGBKTYUFYQ();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void KAVPMFSGVAU();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IDisposable WBRBJYTJEKS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface VJRHJITDGWD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HFGIPAZTZGX(Type a, [Out] object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface YKMTYEBAAOC : VJRHJITDGWD
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		Phase EZSFWWEXMAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Lifetime EXVEIWYUACQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		object Get(Type type);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal class Disposables : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class YOORDGQGQVE
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public YOORDGQGQVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<IDisposable> UKUEVZLBCOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly YOORDGQGQVE RKAFVLIFROI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool RKZVTHIHIQI;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84B1430", Offset = "0x84B0230", VA = "0x1884B1430")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84B1590", Offset = "0x84B0390", VA = "0x1884B1590", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84B1640", Offset = "0x84B0440", VA = "0x1884B1640")]
		public Disposables()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal class BRAKPDDFWMH
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class UHRWADSOIRM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public YKMTYEBAAOC SOVAMOEOAOR;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public UHRWADSOIRM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x84B64F0", Offset = "0x84B52F0", VA = "0x1884B64F0")]
			internal void HGEIAWWFHGK(LIUHYBSTFYH a, YKMTYEBAAOC b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly ProfilerMarker YHBYCBZMRUQ;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static readonly ProfilerMarker NSUXESLYIYP;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly ProfilerMarker EHUFEFIONNP;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly ProfilerMarker VKDJMJOHPVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly YKMTYEBAAOC YAQZQWZJBFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<object>[] GFHDEKUHTHP;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Phase EZSFWWEXMAP
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xAAF580", Offset = "0xAAE380", VA = "0x180AAF580")]
			[CompilerGenerated]
			get
			{
				return default(Phase);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xAFF070", Offset = "0xAFDE70", VA = "0x180AFF070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool CEUTKOAAMIT
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xF470D0", Offset = "0xF45ED0", VA = "0x180F470D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xF46B80", Offset = "0xF45980", VA = "0x180F46B80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x84B1110", Offset = "0x84AFF10", VA = "0x1884B1110")]
		public BRAKPDDFWMH(YKMTYEBAAOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x84B0930", Offset = "0x84AF730", VA = "0x1884B0930")]
		public bool UXXTPVWCRRW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x84B0090", Offset = "0x84AEE90", VA = "0x1884B0090")]
		public bool FSLACFDITNU(YKMTYEBAAOC a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x84B0180", Offset = "0x84AEF80", VA = "0x1884B0180")]
		public bool HTORTSKTUQA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x84B0ED0", Offset = "0x84AFCD0", VA = "0x1884B0ED0")]
		private bool VXVXEKTCAFL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84B0630", Offset = "0x84AF430", VA = "0x1884B0630")]
		public bool IJTCPAPZRJZ(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3632490", Offset = "0x3631290", VA = "0x183632490")]
		private bool JTPQUKAIPNW<a>(Action<a, YKMTYEBAAOC> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3632180", Offset = "0x3630F80", VA = "0x183632180")]
		private bool HIXYACJJSYB<b>(object a, Action<b, YKMTYEBAAOC> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3632720", Offset = "0x3631520", VA = "0x183632720")]
		private bool QVCHVLWXFGO<c>(Phase a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84AFF20", Offset = "0x84AED20", VA = "0x1884AFF20")]
		private void BVOXZKSPKBT(Phase a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[AttributeUsage(AttributeTargets.Class)]
	public class ServiceAllowDisposableAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
		public ServiceAllowDisposableAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class ServiceInitOrder
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly ProfilerMarker MCXFISSOQPN;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly ProfilerMarker FDFYPNFOHDX;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly ProfilerMarker KZRIOAREVNU;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly ProfilerMarker FMZICFPPXJX;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly ProfilerMarker VKGPOSLWTYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly CGJPIYVCORU ZIAWQFQVOUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<Type, object> YPQKSOJNXIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly HashSet<object> NTPYRZDOVFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly Lifetime CNMHXSUBGCQ;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84B3EA0", Offset = "0x84B2CA0", VA = "0x1884B3EA0")]
		public ServiceInitOrder(Lifetime lifetime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84B2470", Offset = "0x84B1270", VA = "0x1884B2470")]
		public void Add(Type bindType, object service)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x84B3300", Offset = "0x84B2100", VA = "0x1884B3300")]
		private void TPXJZOGBIHR(Type a, Type b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x84B3B80", Offset = "0x84B2980", VA = "0x1884B3B80")]
		private void XAEVWJTGDWH(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x84B2500", Offset = "0x84B1300", VA = "0x1884B2500")]
		public void ELBAXFBHMLP(BRAKPDDFWMH a, VJRHJITDGWD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x84B3640", Offset = "0x84B2440", VA = "0x1884B3640")]
		private void WXWFECMFSDW(BRAKPDDFWMH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84B2EF0", Offset = "0x84B1CF0", VA = "0x1884B2EF0")]
		private void NAGIFRUEPLN(BRAKPDDFWMH a, VJRHJITDGWD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84B2820", Offset = "0x84B1620", VA = "0x1884B2820")]
		private void JZUIMGJWGEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x84B2650", Offset = "0x84B1450", VA = "0x1884B2650")]
		private IEnumerable<Type> GQVXPVWFNMQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84B2970", Offset = "0x84B1770", VA = "0x1884B2970")]
		private static bool MLMHZYYUDUK(Type a, Type b, [Out] Lifetime c, [Out] string d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class LifetimeScopedServices
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly ProfilerMarker WHDJOYLHHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly MQNVASDZCUX container;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly ServiceInitOrder YAISRDXRAYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly BRAKPDDFWMH ATFONHDOZZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly Lifetime CNMHXSUBGCQ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Phase EZSFWWEXMAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x84B1D50", Offset = "0x84B0B50", VA = "0x1884B1D50")]
			get
			{
				return default(Phase);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MQNVASDZCUX KSNTYYWJQHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x84B1F40", Offset = "0x84B0D40", VA = "0x1884B1F40")]
		public LifetimeScopedServices(MQNVASDZCUX container, Lifetime lifetime, YKMTYEBAAOC access)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x84B16F0", Offset = "0x84B04F0", VA = "0x1884B16F0")]
		public void Add(Type type, object service)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x84B1B50", Offset = "0x84B0950", VA = "0x1884B1B50")]
		public bool HNVZCZXMVOK(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x84B1B80", Offset = "0x84B0980", VA = "0x1884B1B80")]
		public bool Initialize(VJRHJITDGWD resolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180")]
		private void GTMPUHSITQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x84B1980", Offset = "0x84B0780", VA = "0x1884B1980")]
		public void FQYMSXHBSEL(YKMTYEBAAOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x84B1DE0", Offset = "0x84B0BE0", VA = "0x1884B1DE0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x84B1E10", Offset = "0x84B0C10", VA = "0x1884B1E10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x84B1930", Offset = "0x84B0730", VA = "0x1884B1930")]
		private static void EDAIBLHYXFY(Type a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x84B1D70", Offset = "0x84B0B70", VA = "0x1884B1D70")]
		private void QWRUJHQOQBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x84B1A70", Offset = "0x84B0870", VA = "0x1884B1A70")]
		private void HECVFRXUUAR(Type a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate T ServiceFactory<out T>();
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[ServiceAllowDisposable]
	public class Services : CERMPDGXYNS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		private class DOVWLSGFDEY : YKMTYEBAAOC, VJRHJITDGWD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private readonly Services YAQZQWZJBFV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private readonly Lifetime CNMHXSUBGCQ;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private LifetimeScopedServices EUUPDBPNMGJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x84B13F0", Offset = "0x84B01F0", VA = "0x1884B13F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public Phase EZSFWWEXMAP
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x84B13A0", Offset = "0x84B01A0", VA = "0x1884B13A0", Slot = "4")]
				get
				{
					return default(Phase);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public Lifetime EXVEIWYUACQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0xA9ED10", Offset = "0xA9DB10", VA = "0x180A9ED10", Slot = "5")]
				get
				{
					return default(Lifetime);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x1099B60", Offset = "0x1098960", VA = "0x181099B60")]
			public DOVWLSGFDEY(Services a, Lifetime b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x84B1350", Offset = "0x84B0150", VA = "0x1884B1350", Slot = "7")]
			public bool HFGIPAZTZGX(Type a, [Out] object b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x84B1190", Offset = "0x84AFF90", VA = "0x1884B1190", Slot = "6")]
			public object Get(Type type)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private class OJJGUKTEAZX : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private readonly MQNVASDZCUX.DeferCycleCheck[] DXSDMJOHDWU;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x84B2300", Offset = "0x84B1100", VA = "0x1884B2300")]
			public OJJGUKTEAZX(Services a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x84B22A0", Offset = "0x84B10A0", VA = "0x1884B22A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly ProfilerMarker RSEVALGGYHR;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly ProfilerMarker LETPGJEXPYE;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly ProfilerMarker CEGHYSUCHOU;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly ProfilerMarker SKLSTHXYXHQ;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly ProfilerMarker AXLLWPSSNJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly LifetimeScopedServices[] VNQIIKOBWVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly DOVWLSGFDEY[] VNLNHQUGYHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Lifetime CNMHXSUBGCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool RKZVTHIHIQI;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private YKMTYEBAAOC KXUIATSRUAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x84B4610", Offset = "0x84B3410", VA = "0x1884B4610", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Lifetime EXVEIWYUACQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAAF580", Offset = "0xAAE380", VA = "0x180AAF580", Slot = "5")]
			get
			{
				return default(Lifetime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public YKMTYEBAAOC this[Lifetime lifetime]
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x745F7B0", Offset = "0x745E5B0", VA = "0x18745F7B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		internal LifetimeScopedServices VVQPNDJKPQI
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x746E880", Offset = "0x746D680", VA = "0x18746E880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		internal LifetimeScopedServices YZTAALPNWWZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x84B5410", Offset = "0x84B4210", VA = "0x1884B5410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x84B4260", Offset = "0x84B3060", VA = "0x1884B4260")]
		public static CERMPDGXYNS Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x84B41E0", Offset = "0x84B2FE0", VA = "0x1884B41E0")]
		public static CERMPDGXYNS Create(MQNVASDZCUX container)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x84B5100", Offset = "0x84B3F00", VA = "0x1884B5100")]
		public static CERMPDGXYNS SWKQUCVJTDS(MQNVASDZCUX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x84B5780", Offset = "0x84B4580", VA = "0x1884B5780")]
		private Services(MQNVASDZCUX rootContainer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x84B40C0", Offset = "0x84B2EC0", VA = "0x1884B40C0", Slot = "15")]
		public void Add(Type bindType, object service)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x84B3FB0", Offset = "0x84B2DB0", VA = "0x1884B3FB0", Slot = "7")]
		public void Add(Type bindType, object service, Lifetime lifetime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x84B4340", Offset = "0x84B3140", VA = "0x1884B4340", Slot = "9")]
		public ulong DJDPOKDOVYC(Type[] a, Lifetime b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x84B4E80", Offset = "0x84B3C80", VA = "0x1884B4E80", Slot = "10")]
		public bool PZKCECJZFXK(Type a, Lifetime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x84B4FC0", Offset = "0x84B3DC0", VA = "0x1884B4FC0", Slot = "8")]
		public void RPSJBOHTYNJ(Type[] a, object b, Lifetime c, ulong d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x84B5270", Offset = "0x84B4070", VA = "0x1884B5270", Slot = "13")]
		public IDisposable WBRBJYTJEKS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x84B46E0", Offset = "0x84B34E0", VA = "0x1884B46E0", Slot = "11")]
		public void HQGBKTYUFYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x84B4BD0", Offset = "0x84B39D0", VA = "0x1884B4BD0", Slot = "12")]
		public void KAVPMFSGVAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x84B4590", Offset = "0x84B3390", VA = "0x1884B4590", Slot = "14")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x84B4530", Offset = "0x84B3330", VA = "0x1884B4530")]
		private bool DMUBYERVJLR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x84B4B80", Offset = "0x84B3980", VA = "0x1884B4B80")]
		private void IZFNHNRWZNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x84B4650", Offset = "0x84B3450", VA = "0x1884B4650")]
		private bool HNVZCZXMVOK(Type a, Lifetime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x84B51E0", Offset = "0x84B3FE0", VA = "0x1884B51E0")]
		private bool UEHUELTTQHR(Type a, [Out] Lifetime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x84B5440", Offset = "0x84B4240", VA = "0x1884B5440")]
		private void YXOLLSCDDYW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x84B4950", Offset = "0x84B3750", VA = "0x1884B4950")]
		private static LifetimeScopedServices[] IEZEHBBPCAC(MQNVASDZCUX a, DOVWLSGFDEY[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x84B4D80", Offset = "0x84B3B80", VA = "0x1884B4D80")]
		private DOVWLSGFDEY[] PRGVSTKHKCV()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public enum Phase
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Uninitialized = -1,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		InitInternal,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		InitReferencesGenerated,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		InitReferences,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		InitExternal,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		PostInit,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Initialized,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		ScopeChange,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		ShutdownExternal,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		ShutdownReferences,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		ShutdownReferencesGenerated,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		ShutdownInternal,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		PhaseCount
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[Flags]
	public enum PhaseFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		Uninitialized = 0,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		InitInternal = 1,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		InitReferencesGenerated = 2,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		InitReferences = 4,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		InitExternal = 8,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		PostInit = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		Initialized = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		ScopeChange = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		ShutdownExternal = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		ShutdownReferences = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		ShutdownReferencesGenerated = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		ShutdownInternal = 0x400,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		CoreInit = 0xF,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		AllInit = 0x1F,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		AllShutdown = 0x780,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		All = 0x79F
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class ULXJPIZJEQE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x84B6550", Offset = "0x84B5350", VA = "0x1884B6550")]
		public static Exception GMVERIRZDVV(Type a, Lifetime b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x84B6790", Offset = "0x84B5590", VA = "0x1884B6790")]
		public static Exception YGLGRSAWILQ(Type a, Lifetime b, Type c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x84B6620", Offset = "0x84B5420", VA = "0x1884B6620")]
		public static Type XCVAYREUXAP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x84B65E0", Offset = "0x84B53E0", VA = "0x1884B65E0")]
		private static string WORSRYHBTPG(Type a, Lifetime b, Type c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x84B65E0", Offset = "0x84B53E0", VA = "0x1884B65E0")]
		private static string XATQLREKAQG(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum ShutdownPhase
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		Uninitialized = -1,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		ShutdownInternal,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		ShutdownReferences,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		ShutdownContent,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Initialized
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class WHQVVRMOVTV
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
