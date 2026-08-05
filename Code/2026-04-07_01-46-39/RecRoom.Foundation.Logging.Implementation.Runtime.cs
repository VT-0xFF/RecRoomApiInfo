using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Microsoft.Win32.SafeHandles;
using RecRoom.Foundation.Collections;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Foundation_Logging_Implementation_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x99D8AC0", Offset = "0x99D7AC0", VA = "0x1899D8AC0", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Foundation.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class LTGBVUJHORB : JYFINALGCEK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private string SYMTCIPFGLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private Storage UTZTNPGSEJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Storage JIQIEBOHXXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private Storage EFEGJNFXETJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private AIPTDGRWCXL KLAPIXPHTAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int DXVJZRCKFJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int UOKBSOGEBXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool TYDTLZJONUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private string NOFUGILBCMA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool FBRDVXONRPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xF40E90", Offset = "0xF3FE90", VA = "0x180F40E90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public PSTXEUOWHIH[] GSZHMVMWVTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BD0", Offset = "0xCF6BD0", VA = "0x180CF7BD0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BC0", Offset = "0xCF6BC0", VA = "0x180CF7BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public FMMCLUCYQGK DZJVVZCBIDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCF7E60", Offset = "0xCF6E60", VA = "0x180CF7E60", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int YEVMBFYDXLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x99D8830", Offset = "0x99D7830", VA = "0x1899D8830", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99D7340", Offset = "0x99D6340", VA = "0x1899D7340")]
		public static LTGBVUJHORB BHQIKQTBRDF(string a, AIPTDGRWCXL b, bool c = false, bool d = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99D7550", Offset = "0x99D6550", VA = "0x1899D7550")]
		public static LTGBVUJHORB Create(string path, AIPTDGRWCXL schema)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x99D83D0", Offset = "0x99D73D0", VA = "0x1899D83D0")]
		public static LTGBVUJHORB Load(string path, bool readOnly = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x99D7880", Offset = "0x99D6880", VA = "0x1899D7880", Slot = "1")]
		~LTGBVUJHORB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99D89E0", Offset = "0x99D79E0", VA = "0x1899D89E0")]
		private LTGBVUJHORB(string a, [Optional] AIPTDGRWCXL b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x99D8930", Offset = "0x99D7930", VA = "0x1899D8930")]
		public void VGHAVEZCHTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99D8850", Offset = "0x99D7850", VA = "0x1899D8850")]
		public void Reload()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x99D7BC0", Offset = "0x99D6BC0", VA = "0x1899D7BC0")]
		private void ICQWDVOGHXG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99D8460", Offset = "0x99D7460", VA = "0x1899D8460")]
		private void MCDYGDWVCON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x99D7820", Offset = "0x99D6820", VA = "0x1899D7820", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x99D7450", Offset = "0x99D6450", VA = "0x1899D7450")]
		private void BODEYOQYIOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x99D8510", Offset = "0x99D7510", VA = "0x1899D8510")]
		public void NMGNMKFDKPU(AIPTDGRWCXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99D8690", Offset = "0x99D7690", VA = "0x1899D8690")]
		public void OFMVDEZKAYR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99D7920", Offset = "0x99D6920", VA = "0x1899D7920")]
		private void GQXCOSEBNVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99D7D80", Offset = "0x99D6D80", VA = "0x1899D7D80", Slot = "7")]
		public void JIVPGJSGYUL(NativeParallelHashMap<int, RecRoom.Foundation.Collections.Range> a, NativeArray<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99D8940", Offset = "0x99D7940", VA = "0x1899D8940", Slot = "6")]
		public int YBDYCGXJHDX(Type a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x99D7490", Offset = "0x99D6490", VA = "0x1899D7490", Slot = "11")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x99D8360", Offset = "0x99D7360", VA = "0x1899D8360")]
		private void KLLKMCNJQEY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AIPTDGRWCXL
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int YEVMBFYDXLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x99D6910", Offset = "0x99D5910", VA = "0x1899D6910")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Guid[] CYZNGNJUUTA
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int WZQEDLFLMPU
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xD031D0", Offset = "0xD021D0", VA = "0x180D031D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int[] PUTMRYOFHFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string[] NEIMVVGZVOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xCF4880", Offset = "0xCF3880", VA = "0x180CF4880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99D65C0", Offset = "0x99D55C0", VA = "0x1899D65C0")]
		public void NTXNIJJJHYF(Storage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x99D6360", Offset = "0x99D5360", VA = "0x1899D6360")]
		public void IOACUTWBTGW(Storage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3368330", Offset = "0x3367330", VA = "0x183368330")]
		private static void NTXNIJJJHYF<T>(T a, Span<int> b, Storage c) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3367B20", Offset = "0x3366B20", VA = "0x183367B20")]
		private static void DDBHMSDJDMW<T>(T[] a, Span<int> b, Storage c) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x99D66C0", Offset = "0x99D56C0", VA = "0x1899D66C0")]
		private static void PGNUOQYMHBD(string[] a, Span<int> b, Storage c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x33680B0", Offset = "0x33670B0", VA = "0x1833680B0")]
		private static T IOACUTWBTGW<T>(ReadOnlySpan<int> a, Storage b) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3368440", Offset = "0x3367440", VA = "0x183368440")]
		private static T[] TURSFKTXYAH<T>(ReadOnlySpan<int> a, Storage b) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x99D6920", Offset = "0x99D5920", VA = "0x1899D6920")]
		private static string[] XESVKXTDLNO(ReadOnlySpan<int> a, Storage b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x99D6B20", Offset = "0x99D5B20", VA = "0x1899D6B20")]
		public AIPTDGRWCXL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class LJAKYDIXKTP
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly Dictionary<Type, Guid> VZOUCZSDJUP;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Dictionary<Guid, Type> TJQZEXOSUYL;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly Dictionary<Type, int> MOAHJBOFQLA;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly PSTXEUOWHIH[] IRMLOPGGHUK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly PSTXEUOWHIH TWNZNAIBNKM;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly Guid[] FNYTWOGONVG;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99D6CB0", Offset = "0x99D5CB0", VA = "0x1899D6CB0")]
		static LJAKYDIXKTP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x99D6C50", Offset = "0x99D5C50", VA = "0x1899D6C50")]
		private static List<Type> UIYZARPSJRN()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class Storage : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public ref struct Reader
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private Storage storage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private long readLength;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3113730", Offset = "0x3112730", VA = "0x183113730")]
			public Reader(Storage storage, long offset)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x414D720", Offset = "0x414C720", VA = "0x18414D720")]
			public T IOACUTWBTGW<T>() where T : struct
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x414D400", Offset = "0x414C400", VA = "0x18414D400")]
			public ReadOnlySpan<T> FJYKEDHWFAK<T>(int a) where T : struct
			{
				return default(ReadOnlySpan<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x99D8B60", Offset = "0x99D7B60", VA = "0x1899D8B60")]
			public ReadOnlySpan<byte> IOACUTWBTGW(int a)
			{
				return default(ReadOnlySpan<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string SYMTCIPFGLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private long VGYGAYISGHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool TYDTLZJONUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private SafeFileHandle SSRHZIQAGHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private FileStream EJWZPZDOKNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private MemoryMappedFile HHHKJOAADUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private MemoryMappedViewAccessor NTRKQILOUCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private unsafe byte* YELLOXZNFCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private long MHJVLJDWAGJ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string HGGJHTIYZTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private unsafe byte* CWJOVTTWVMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x99D8C50", Offset = "0x99D7C50", VA = "0x1899D8C50")]
			get
			{
				//IL_0002: Expected I, but got O
				return (byte*)unchecked((nint)null);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool FBRDVXONRPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x99D9350", Offset = "0x99D8350", VA = "0x1899D9350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public long YRTSNWBGGGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BD0", Offset = "0xCF6BD0", VA = "0x180CF7BD0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public long KHHULVTWNWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99D97D0", Offset = "0x99D87D0", VA = "0x1899D97D0")]
		public Storage(string path, long capacity = 1048576L, bool readOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x99D9730", Offset = "0x99D8730", VA = "0x1899D9730")]
		public Reader REVCVDPHWOJ(long a = 0L)
		{
			return default(Reader);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x99D8C60", Offset = "0x99D7C60", VA = "0x1899D8C60")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3F16E20", Offset = "0x3F15E20", VA = "0x183F16E20")]
		public Span<T> VILIDLISTXA<T>(int a = 1, bool b = false) where T : struct
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3F16C00", Offset = "0x3F15C00", VA = "0x183F16C00")]
		public LongRange NTXNIJJJHYF<T>(T a) where T : struct
		{
			return default(LongRange);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x99D8D00", Offset = "0x99D7D00", VA = "0x1899D8D00")]
		public LongRange HFSDRGUEJAD(string a)
		{
			return default(LongRange);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3F16A50", Offset = "0x3F15A50", VA = "0x183F16A50")]
		public LongRange NTXNIJJJHYF<T>(ReadOnlySpan<T> a) where T : struct
		{
			return default(LongRange);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x99D9620", Offset = "0x99D8620", VA = "0x1899D9620")]
		public LongRange NTXNIJJJHYF(ReadOnlySpan<byte> a)
		{
			return default(LongRange);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x99D9290", Offset = "0x99D8290", VA = "0x1899D9290")]
		public ReadOnlySpan<byte> IOACUTWBTGW(LongRange a)
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3F169F0", Offset = "0x3F159F0", VA = "0x183F169F0")]
		public T GUGHYSQGWFF<T>(int a) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x99D8C80", Offset = "0x99D7C80", VA = "0x1899D8C80")]
		private void GAKMMDDZWUU(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x99D8C70", Offset = "0x99D7C70", VA = "0x1899D8C70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x99D8DE0", Offset = "0x99D7DE0", VA = "0x1899D8DE0")]
		private bool ICQWDVOGHXG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x99D9360", Offset = "0x99D8360", VA = "0x1899D9360")]
		private void MCDYGDWVCON()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct LongRange
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public long offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int length;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public long ZQHOKUWTOCH
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x99D8B40", Offset = "0x99D7B40", VA = "0x1899D8B40")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99D8B50", Offset = "0x99D7B50", VA = "0x1899D8B50")]
		public LongRange(long start, long end)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B67E80", Offset = "0x2B66E80", VA = "0x182B67E80")]
		public LongRange(long offset, int length)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class AMYRVVLUQKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9079C10", Offset = "0x9078C10", VA = "0x189079C10")]
		public static int GDFMYCOWSRE(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class WOYEOLOSVWA
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[Flags]
		private enum EFileAccess : uint
		{
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			AccessSystemSecurity = 0x1000000u,
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			MaximumAllowed = 0x2000000u,
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			Delete = 0x10000u,
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			ReadControl = 0x20000u,
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			WriteDAC = 0x40000u,
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			WriteOwner = 0x80000u,
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			Synchronize = 0x100000u,
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			StandardRightsRequired = 0xF0000u,
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			StandardRightsRead = 0x20000u,
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			StandardRightsWrite = 0x20000u,
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			StandardRightsExecute = 0x20000u,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			StandardRightsAll = 0x1F0000u,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			SpecificRightsAll = 0xFFFFu,
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			FILE_READ_DATA = 1u,
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			FILE_LIST_DIRECTORY = 1u,
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			FILE_WRITE_DATA = 2u,
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			FILE_ADD_FILE = 2u,
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			FILE_APPEND_DATA = 4u,
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			FILE_ADD_SUBDIRECTORY = 4u,
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			FILE_CREATE_PIPE_INSTANCE = 4u,
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			FILE_READ_EA = 8u,
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			FILE_WRITE_EA = 0x10u,
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			FILE_EXECUTE = 0x20u,
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			FILE_TRAVERSE = 0x20u,
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			FILE_DELETE_CHILD = 0x40u,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			FILE_READ_ATTRIBUTES = 0x80u,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			FILE_WRITE_ATTRIBUTES = 0x100u,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			GenericRead = 0x80000000u,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			GenericWrite = 0x40000000u,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			GenericExecute = 0x20000000u,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			GenericAll = 0x10000000u,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			SPECIFIC_RIGHTS_ALL = 0xFFFFu,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			FILE_ALL_ACCESS = 0x1F01FFu,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			FILE_GENERIC_READ = 0x120089u,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			FILE_GENERIC_WRITE = 0x120116u,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			FILE_GENERIC_EXECUTE = 0x1200A0u
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[Flags]
		public enum EFileShare : uint
		{
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			None = 0u,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			Read = 1u,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			Write = 2u,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Delete = 4u
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum ECreationDisposition : uint
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			CreateNew = 1u,
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			Create,
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Open,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			OpenOrCreate,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			Truncate
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x99D9A70", Offset = "0x99D8A70", VA = "0x1899D9A70")]
		private static extern SafeFileHandle CreateFile(string lpFileName, EFileAccess dwDesiredAccess, EFileShare dwShareMode, IntPtr lpSecurityAttributes, ECreationDisposition dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x99D9BC0", Offset = "0x99D8BC0", VA = "0x1899D9BC0")]
		public static SafeFileHandle RMTFFNHCERC(string a, FileMode b, FileAccess c, FileShare d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x99D9B90", Offset = "0x99D8B90", VA = "0x1899D9B90")]
		public static void QFIBIQZHKMO(string a)
		{
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
