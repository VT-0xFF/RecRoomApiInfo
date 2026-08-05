using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Core;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.DataStructures.Tokens;
using RecRoom.UnityContainers;
using RecRoom.Utils.PrefParsers;
using UJect;
using UJect.Injection;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5470", Offset = "0x9DC3E70", VA = "0x189DC5470")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Preferences_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9DC49A0", Offset = "0x9DC33A0", VA = "0x189DC49A0", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Preferences_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9DCB400", Offset = "0x9DC9E00", VA = "0x189DCB400", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E140", Offset = "0x2A2CB40", VA = "0x182A2E140")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Preferences
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum AccountPreferenceBackingStoreTypes : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		CLOUD,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		DISK
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class AZIFFSZNTMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal delegate void CustomSaveHandler(PMIBWDISFAW backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE9A0", Offset = "0x9DBD3A0", VA = "0x189DBE9A0")]
		private static void ZMXYFJRIRTT(PMIBWDISFAW a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE460", Offset = "0x9DBCE60", VA = "0x189DBE460")]
		public static bool TRQLCCSHCBJ(this PMIBWDISFAW a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE1A0", Offset = "0x9DBCBA0", VA = "0x189DBE1A0")]
		public static SetResult KGZDUMSKVDE(this PMIBWDISFAW a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE5C0", Offset = "0x9DBCFC0", VA = "0x189DBE5C0")]
		public static SetResult VNJUJQUXWDI(this PMIBWDISFAW a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE850", Offset = "0x9DBD250", VA = "0x189DBE850")]
		public static SetResult WRKGQQKRGOD(this PMIBWDISFAW a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE700", Offset = "0x9DBD100", VA = "0x189DBE700")]
		public static SetResult WPPAFTCNIDX(this PMIBWDISFAW a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE2F0", Offset = "0x9DBCCF0", VA = "0x189DBE2F0")]
		public static SetResult OEOWYRJUITE(this PMIBWDISFAW a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE060", Offset = "0x9DBCA60", VA = "0x189DBE060")]
		public static SetResult FVGIEAZLLAN(this PMIBWDISFAW a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class FXCRZXGSJYD : ONUBXCTDIBZ, PMIBWDISFAW
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log MTKAYXCPQAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly ZKGNCVNKCRM QPNQPPMAVBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Dictionary<string, byte> EGMJYNPHBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Dictionary<string, string> GYNCXEJECWO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool QWVJKLTWNYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> MOIQKMLYNDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9DC2DF0", Offset = "0x9DC17F0", VA = "0x189DC2DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action GUNHVJZWKDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4170", Offset = "0x9DC2B70", VA = "0x189DC4170")]
		[UnityEngine.Scripting.Preserve]
		public FXCRZXGSJYD([Inject(null)] ZKGNCVNKCRM unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "8")]
		public void SDSAAHOEYJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1D70", Offset = "0x9DC0770", VA = "0x189DC1D70")]
		private DirectoryInfo AVEDWJLGHNU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9DC2470", Offset = "0x9DC0E70", VA = "0x189DC2470", Slot = "6")]
		public Task UEGLIIBCOVQ(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9DC30C0", Offset = "0x9DC1AC0", VA = "0x189DC30C0", Slot = "14")]
		public float YUNQABHQRJK(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9DC3EB0", Offset = "0x9DC28B0", VA = "0x189DC3EB0", Slot = "13")]
		public void ZEDRLRKLMQS(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9DC2500", Offset = "0x9DC0F00", VA = "0x189DC2500", Slot = "12")]
		public bool URLPLXUKKSK(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9DC2740", Offset = "0x9DC1140", VA = "0x189DC2740", Slot = "10")]
		public int WTAVZZLBJKD(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1F40", Offset = "0x9DC0940", VA = "0x189DC1F40", Slot = "18")]
		public DateTime FGJQWYUJGYH(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4090", Offset = "0x9DC2A90", VA = "0x189DC4090", Slot = "19")]
		public void ZXLWVRIMFQP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9DC2E30", Offset = "0x9DC1830", VA = "0x189DC2E30", Slot = "15")]
		public void XTTBMLIAEZC(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9DC2350", Offset = "0x9DC0D50", VA = "0x189DC2350", Slot = "11")]
		public void TMNXLMANQJF(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9DC25D0", Offset = "0x9DC0FD0", VA = "0x189DC25D0", Slot = "20")]
		public long VDYZKPGFTCM(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1ED0", Offset = "0x9DC08D0", VA = "0x189DC1ED0", Slot = "21")]
		public void DNJNMXMLVKQ(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3AE8340", Offset = "0x3AE6D40", VA = "0x183AE8340", Slot = "22")]
		public a CFGVLFWFCER<a>(string a, a b, ZEAELRSVOME<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AE8610", Offset = "0x3AE7010", VA = "0x183AE8610", Slot = "23")]
		public void DJDPGDQZXTT<b>(string a, b b, ZEAELRSVOME<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9DC23C0", Offset = "0x9DC0DC0", VA = "0x189DC23C0", Slot = "16")]
		public string TPBZTRCPNTZ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1E60", Offset = "0x9DC0860", VA = "0x189DC1E60", Slot = "17")]
		public void DEBFOBNHFQL(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9DC3F20", Offset = "0x9DC2920", VA = "0x189DC3F20", Slot = "24")]
		public void ZLAXRRSMULC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1CE0", Offset = "0x9DC06E0", VA = "0x189DC1CE0", Slot = "9")]
		public bool AQGZBQROZTD(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9DC2010", Offset = "0x9DC0A10", VA = "0x189DC2010", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9DC27B0", Offset = "0x9DC11B0", VA = "0x189DC27B0")]
		private void WUHYUPGDJWM(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9DC2EA0", Offset = "0x9DC18A0", VA = "0x189DC2EA0")]
		private static string YGSQLXLEVDX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9DC2640", Offset = "0x9DC1040", VA = "0x189DC2640")]
		private static string VZNURJCOYVA(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3AE87B0", Offset = "0x3AE71B0", VA = "0x183AE87B0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] ZEAELRSVOME<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3AE9FA0", Offset = "0x3AE89A0", VA = "0x183AE9FA0")]
		private void Set<T>(string propertyName, T value, [Optional] ZEAELRSVOME<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9DC3130", Offset = "0x9DC1B30", VA = "0x189DC3130")]
		private Dictionary<string, string> YUZMUVGQHQE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1FB0", Offset = "0x9DC09B0", VA = "0x189DC1FB0")]
		private void RQMKDNNZRNW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1C70", Offset = "0x9DC0670", VA = "0x189DC1C70")]
		private void AMFOZVCMMRV(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class XWJKYQJZNPZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log MTKAYXCPQAM;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9DCB1C0", Offset = "0x9DC9BC0", VA = "0x189DCB1C0")]
		[BRMSZAJTATI.Root]
		internal static void BRMSZAJTATI(ZUKUOYIIEVW a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class RNKYKGZAJUU : LYMVESVYUYF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4920", Offset = "0x9DC3320", VA = "0x189DC4920")]
		[UnityEngine.Scripting.Preserve]
		public RNKYKGZAJUU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MVHSDOGVTKO : ONUBXCTDIBZ, PMIBWDISFAW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly ZKGNCVNKCRM QPNQPPMAVBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Dictionary<string, string> HLMXKEPUQJG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool QWVJKLTWNYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action GUNHVJZWKDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9DC53D0", Offset = "0x9DC3DD0", VA = "0x189DC53D0")]
		[UnityEngine.Scripting.Preserve]
		public MVHSDOGVTKO([Inject(null)] ZKGNCVNKCRM unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4FA0", Offset = "0x9DC39A0", VA = "0x189DC4FA0", Slot = "6")]
		public Task UEGLIIBCOVQ(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "8")]
		public void SDSAAHOEYJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4C70", Offset = "0x9DC3670", VA = "0x189DC4C70", Slot = "9")]
		public bool AQGZBQROZTD(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5110", Offset = "0x9DC3B10", VA = "0x189DC5110", Slot = "10")]
		public int WTAVZZLBJKD(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4EB0", Offset = "0x9DC38B0", VA = "0x189DC4EB0", Slot = "11")]
		public void TMNXLMANQJF(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5030", Offset = "0x9DC3A30", VA = "0x189DC5030", Slot = "12")]
		public bool URLPLXUKKSK(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5260", Offset = "0x9DC3C60", VA = "0x189DC5260", Slot = "13")]
		public void ZEDRLRKLMQS(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9DC51F0", Offset = "0x9DC3BF0", VA = "0x189DC51F0", Slot = "14")]
		public float YUNQABHQRJK(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5180", Offset = "0x9DC3B80", VA = "0x189DC5180", Slot = "15")]
		public void XTTBMLIAEZC(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4F20", Offset = "0x9DC3920", VA = "0x189DC4F20", Slot = "16")]
		public string TPBZTRCPNTZ(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4CD0", Offset = "0x9DC36D0", VA = "0x189DC4CD0", Slot = "17")]
		public void DEBFOBNHFQL(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4DB0", Offset = "0x9DC37B0", VA = "0x189DC4DB0", Slot = "18")]
		public DateTime FGJQWYUJGYH(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5360", Offset = "0x9DC3D60", VA = "0x189DC5360", Slot = "19")]
		public void ZXLWVRIMFQP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9DC50A0", Offset = "0x9DC3AA0", VA = "0x189DC50A0", Slot = "20")]
		public long VDYZKPGFTCM(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4D40", Offset = "0x9DC3740", VA = "0x189DC4D40", Slot = "21")]
		public void DNJNMXMLVKQ(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3C497E0", Offset = "0x3C481E0", VA = "0x183C497E0", Slot = "22")]
		public a CFGVLFWFCER<a>(string a, a b, ZEAELRSVOME<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3C499C0", Offset = "0x3C483C0", VA = "0x183C499C0", Slot = "23")]
		public void DJDPGDQZXTT<b>(string a, b b, ZEAELRSVOME<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9DC52D0", Offset = "0x9DC3CD0", VA = "0x189DC52D0", Slot = "24")]
		public void ZLAXRRSMULC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4E20", Offset = "0x9DC3820", VA = "0x189DC4E20", Slot = "25")]
		public Task Save([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3C49B60", Offset = "0x3C48560", VA = "0x183C49B60")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] ZEAELRSVOME<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3C4B350", Offset = "0x3C49D50", VA = "0x183C4B350")]
		private void Set<T>(string propertyName, T value, [Optional] ZEAELRSVOME<T> parser)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class LYMVESVYUYF : ONUBXCTDIBZ, PMIBWDISFAW, FYOJKNGMTWX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly Dictionary<string, object> ASNEQIGBYHB;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool QWVJKLTWNYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action GUNHVJZWKDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "8")]
		public void SDSAAHOEYJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4590", Offset = "0x9DC2F90", VA = "0x189DC4590", Slot = "6")]
		public Task UEGLIIBCOVQ(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9DC42C0", Offset = "0x9DC2CC0", VA = "0x189DC42C0", Slot = "9")]
		public bool AQGZBQROZTD(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9DC46E0", Offset = "0x9DC30E0", VA = "0x189DC46E0", Slot = "10")]
		public int WTAVZZLBJKD(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9DC44D0", Offset = "0x9DC2ED0", VA = "0x189DC44D0", Slot = "11")]
		public void TMNXLMANQJF(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4620", Offset = "0x9DC3020", VA = "0x189DC4620", Slot = "12")]
		public bool URLPLXUKKSK(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4800", Offset = "0x9DC3200", VA = "0x189DC4800", Slot = "13")]
		public void ZEDRLRKLMQS(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9DC47A0", Offset = "0x9DC31A0", VA = "0x189DC47A0", Slot = "14")]
		public float YUNQABHQRJK(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4740", Offset = "0x9DC3140", VA = "0x189DC4740", Slot = "15")]
		public void XTTBMLIAEZC(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4530", Offset = "0x9DC2F30", VA = "0x189DC4530", Slot = "16")]
		public string TPBZTRCPNTZ(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4320", Offset = "0x9DC2D20", VA = "0x189DC4320", Slot = "17")]
		public void DEBFOBNHFQL(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9DC43E0", Offset = "0x9DC2DE0", VA = "0x189DC43E0", Slot = "18")]
		public DateTime FGJQWYUJGYH(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9DC48C0", Offset = "0x9DC32C0", VA = "0x189DC48C0", Slot = "19")]
		public void ZXLWVRIMFQP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4680", Offset = "0x9DC3080", VA = "0x189DC4680", Slot = "20")]
		public long VDYZKPGFTCM(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4380", Offset = "0x9DC2D80", VA = "0x189DC4380", Slot = "21")]
		public void DNJNMXMLVKQ(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3C0D820", Offset = "0x3C0C220", VA = "0x183C0D820", Slot = "22")]
		public a CFGVLFWFCER<a>(string a, a b, ZEAELRSVOME<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3C0DCC0", Offset = "0x3C0C6C0", VA = "0x183C0DCC0", Slot = "23")]
		public void DJDPGDQZXTT<b>(string a, b b, ZEAELRSVOME<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3C0DEC0", Offset = "0x3C0C8C0", VA = "0x183C0DEC0")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E950", Offset = "0x3C0D350", VA = "0x183C0E950")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4860", Offset = "0x9DC3260", VA = "0x189DC4860", Slot = "24")]
		public void ZLAXRRSMULC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4440", Offset = "0x9DC2E40", VA = "0x189DC4440", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4920", Offset = "0x9DC3320", VA = "0x189DC4920")]
		public LYMVESVYUYF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class ZLUIKALNFTS<a> where a : PMIBWDISFAW
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly HashSet<ZLUIKALNFTS<a>> OOQYESYXEFD;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x515D830", Offset = "0x515C230", VA = "0x18515D830")]
		protected ZLUIKALNFTS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void XRCJSIMOFZS(string a);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x515CC60", Offset = "0x515B660", VA = "0x18515CC60")]
		public static void KGRSXAARKYG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x515D410", Offset = "0x515BE10", VA = "0x18515D410")]
		public static void SKSACPWCQDM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class ZMKDBUTFIBT<a, b> : ZLUIKALNFTS<a> where a : PMIBWDISFAW
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly ZMKDBUTFIBT<a, b> FYBGHSPAYRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Dictionary<string, b> ZIOBVXVYDFQ;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x515DCF0", Offset = "0x515C6F0", VA = "0x18515DCF0")]
		public bool MAVXVFMPMHQ(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x515DFD0", Offset = "0x515C9D0", VA = "0x18515DFD0")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
		public IEnumerable<KeyValuePair<string, b>> JMAPGRFFAPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x515DB70", Offset = "0x515C570", VA = "0x18515DB70", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x515E080", Offset = "0x515CA80", VA = "0x18515E080", Slot = "5")]
		protected override void XRCJSIMOFZS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x515E3D0", Offset = "0x515CDD0", VA = "0x18515E3D0")]
		public ZMKDBUTFIBT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface PMIBWDISFAW
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool QWVJKLTWNYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SDSAAHOEYJK();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool AQGZBQROZTD(string a);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int WTAVZZLBJKD(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void TMNXLMANQJF(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool URLPLXUKKSK(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZEDRLRKLMQS(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float YUNQABHQRJK(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void XTTBMLIAEZC(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string TPBZTRCPNTZ(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void DEBFOBNHFQL(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime FGJQWYUJGYH(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ZXLWVRIMFQP(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long VDYZKPGFTCM(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void DNJNMXMLVKQ(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a CFGVLFWFCER<a>(string a, a b, ZEAELRSVOME<a> c);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void DJDPGDQZXTT<b>(string a, b b, ZEAELRSVOME<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void ZLAXRRSMULC(string a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface ONUBXCTDIBZ : PMIBWDISFAW
	{
		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action GUNHVJZWKDE;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task UEGLIIBCOVQ(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface FYOJKNGMTWX : PMIBWDISFAW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class CBBYFIALAKN : ONUBXCTDIBZ, PMIBWDISFAW
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct <Save>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public CBBYFIALAKN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9DCA2E0", Offset = "0x9DC8CE0", VA = "0x189DCA2E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9DCA6B0", Offset = "0x9DC90B0", VA = "0x189DCA6B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class VYJHGRNUBSL : IEnumerator<OSEXMMYDSBS>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private OSEXMMYDSBS RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public CBBYFIALAKN TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private OSEXMMYDSBS XMCHSAEGAKP
			{
				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
			[DebuggerHidden]
			public VYJHGRNUBSL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9DCB150", Offset = "0x9DC9B50", VA = "0x189DCB150", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9DCB110", Offset = "0x9DC9B10", VA = "0x189DCB110", Slot = "8")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly Log MTKAYXCPQAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly ZKGNCVNKCRM QPNQPPMAVBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool RTQUCJEDWEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool EGUUJQNBJMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private AQNWLBANTQG FTHBHRLZINB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private OVUANEJXOET GXDILIUBQLD;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool QWVJKLTWNYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action GUNHVJZWKDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1660", Offset = "0x9DC0060", VA = "0x189DC1660")]
		[UnityEngine.Scripting.Preserve]
		public CBBYFIALAKN([Inject(null)] ZKGNCVNKCRM unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "8")]
		public void SDSAAHOEYJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9DC0E30", Offset = "0x9DBF830", VA = "0x189DC0E30", Slot = "6")]
		public Task UEGLIIBCOVQ(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1EBCC20", Offset = "0x1EBB620", VA = "0x181EBCC20")]
		private static int ZDWLSMOKJQI(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9DBEC40", Offset = "0x9DBD640", VA = "0x189DBEC40", Slot = "9")]
		public bool AQGZBQROZTD(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9DC10F0", Offset = "0x9DBFAF0", VA = "0x189DC10F0", Slot = "10")]
		public int WTAVZZLBJKD(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF1C0", Offset = "0x9DBDBC0", VA = "0x189DBF1C0", Slot = "11")]
		public void TMNXLMANQJF(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9DC0EC0", Offset = "0x9DBF8C0", VA = "0x189DC0EC0", Slot = "12")]
		public bool URLPLXUKKSK(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1410", Offset = "0x9DBFE10", VA = "0x189DC1410", Slot = "13")]
		public void ZEDRLRKLMQS(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9DC12E0", Offset = "0x9DBFCE0", VA = "0x189DC12E0", Slot = "14")]
		public float YUNQABHQRJK(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1220", Offset = "0x9DBFC20", VA = "0x189DC1220", Slot = "15")]
		public void XTTBMLIAEZC(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9DBEE00", Offset = "0x9DBD800", VA = "0x189DBEE00", Slot = "18")]
		public DateTime FGJQWYUJGYH(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1580", Offset = "0x9DBFF80", VA = "0x189DC1580", Slot = "19")]
		public void ZXLWVRIMFQP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1080", Offset = "0x9DBFA80", VA = "0x189DC1080", Slot = "20")]
		public long VDYZKPGFTCM(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9DBED90", Offset = "0x9DBD790", VA = "0x189DBED90", Slot = "21")]
		public void DNJNMXMLVKQ(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x38190E0", Offset = "0x3817AE0", VA = "0x1838190E0", Slot = "22")]
		public a CFGVLFWFCER<a>(string a, a b, ZEAELRSVOME<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x38193E0", Offset = "0x3817DE0", VA = "0x1838193E0", Slot = "23")]
		public void DJDPGDQZXTT<b>(string a, b b, ZEAELRSVOME<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x38195A0", Offset = "0x3817FA0", VA = "0x1838195A0")]
		private c OUCLOWTNJXS<c>(string a, c b, [Optional] ZEAELRSVOME<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x381A670", Offset = "0x3819070", VA = "0x18381A670")]
		private void TPZPDKBYIOE<d>(string a, d b, [Optional] ZEAELRSVOME<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF280", Offset = "0x9DBDC80", VA = "0x189DBF280", Slot = "16")]
		public string TPBZTRCPNTZ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9DBEC60", Offset = "0x9DBD660", VA = "0x189DBEC60", Slot = "17")]
		public void DEBFOBNHFQL(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9DBEED0", Offset = "0x9DBD8D0", VA = "0x189DBEED0")]
		private void OCVRJRLIXZI(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9DBEA20", Offset = "0x9DBD420", VA = "0x189DBEA20")]
		private string AIKABCNGVKK(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9DC14F0", Offset = "0x9DBFEF0", VA = "0x189DC14F0", Slot = "24")]
		public void ZLAXRRSMULC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF430", Offset = "0x9DBDE30", VA = "0x189DBF430")]
		private string TPKXUZKPANS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF4D0", Offset = "0x9DBDED0", VA = "0x189DBF4D0")]
		public void TTXUANFXEOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF000", Offset = "0x9DBDA00", VA = "0x189DBF000", Slot = "26")]
		public void QYIYBSSCZJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF0D0", Offset = "0x9DBDAD0", VA = "0x189DBF0D0", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__40))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1010", Offset = "0x9DBFA10", VA = "0x189DC1010")]
		[IteratorStateMachine(typeof(VYJHGRNUBSL))]
		private IEnumerator<OSEXMMYDSBS> VBWCRLCNZEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9DBEE70", Offset = "0x9DBD870", VA = "0x189DBEE70")]
		private void IIMTRUTYAAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF060", Offset = "0x9DBDA60", VA = "0x189DBF060")]
		private void RQMKDNNZRNW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9DBEBD0", Offset = "0x9DBD5D0", VA = "0x189DBEBD0")]
		private void AMFOZVCMMRV(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class TYFFDACNCAN : ONUBXCTDIBZ, PMIBWDISFAW
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private struct KVP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public string k;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public string v;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private struct KVPs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public KVP[] kvps;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Dictionary<string, string> GYNCXEJECWO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool QWVJKLTWNYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string YIQIZCZRVIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x9DC8E20", Offset = "0x9DC7820", VA = "0x189DC8E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private string BXCVCQMFEXZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9DC8D90", Offset = "0x9DC7790", VA = "0x189DC8D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Dictionary<string, string> MOIQKMLYNDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x9DC9470", Offset = "0x9DC7E70", VA = "0x189DC9470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action GUNHVJZWKDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		[UnityEngine.Scripting.Preserve]
		public TYFFDACNCAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "8")]
		public void SDSAAHOEYJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9DC9230", Offset = "0x9DC7C30", VA = "0x189DC9230", Slot = "6")]
		public Task UEGLIIBCOVQ(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9DC9520", Offset = "0x9DC7F20", VA = "0x189DC9520", Slot = "14")]
		public float YUNQABHQRJK(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9DC98C0", Offset = "0x9DC82C0", VA = "0x189DC98C0", Slot = "13")]
		public void ZEDRLRKLMQS(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9DC92C0", Offset = "0x9DC7CC0", VA = "0x189DC92C0", Slot = "12")]
		public bool URLPLXUKKSK(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9DC9400", Offset = "0x9DC7E00", VA = "0x189DC9400", Slot = "10")]
		public int WTAVZZLBJKD(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8D20", Offset = "0x9DC7720", VA = "0x189DC8D20", Slot = "18")]
		public DateTime FGJQWYUJGYH(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9DC99F0", Offset = "0x9DC83F0", VA = "0x189DC99F0", Slot = "19")]
		public void ZXLWVRIMFQP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9DC94B0", Offset = "0x9DC7EB0", VA = "0x189DC94B0", Slot = "15")]
		public void XTTBMLIAEZC(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9DC9110", Offset = "0x9DC7B10", VA = "0x189DC9110", Slot = "11")]
		public void TMNXLMANQJF(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9DC9390", Offset = "0x9DC7D90", VA = "0x189DC9390", Slot = "20")]
		public long VDYZKPGFTCM(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8CB0", Offset = "0x9DC76B0", VA = "0x189DC8CB0", Slot = "21")]
		public void DNJNMXMLVKQ(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3F726B0", Offset = "0x3F710B0", VA = "0x183F726B0", Slot = "22")]
		public a CFGVLFWFCER<a>(string a, a b, ZEAELRSVOME<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3F72890", Offset = "0x3F71290", VA = "0x183F72890", Slot = "23")]
		public void DJDPGDQZXTT<b>(string a, b b, ZEAELRSVOME<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9DC9180", Offset = "0x9DC7B80", VA = "0x189DC9180", Slot = "16")]
		public string TPBZTRCPNTZ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8C10", Offset = "0x9DC7610", VA = "0x189DC8C10", Slot = "17")]
		public void DEBFOBNHFQL(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9DC9930", Offset = "0x9DC8330", VA = "0x189DC9930", Slot = "24")]
		public void ZLAXRRSMULC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8B80", Offset = "0x9DC7580", VA = "0x189DC8B80", Slot = "9")]
		public bool AQGZBQROZTD(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8EB0", Offset = "0x9DC78B0", VA = "0x189DC8EB0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3F72A30", Offset = "0x3F71430", VA = "0x183F72A30")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] ZEAELRSVOME<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3F74220", Offset = "0x3F72C20", VA = "0x183F74220")]
		private void Set<T>(string propertyName, T value, [Optional] ZEAELRSVOME<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9DC9590", Offset = "0x9DC7F90", VA = "0x189DC9590")]
		private Dictionary<string, string> YUZMUVGQHQE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface QGJARWQTXXT
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action GUNHVJZWKDE;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SDSAAHOEYJK();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task XSRXXWGTOLA(long a);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool VXKIALEOSMC(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool ZOWVRYIFKMQ(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool MECJPRZOAUP(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string OGEOAFJNQZG(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult HMWHDBKFXUY(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int WENNJBDZNFA(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult QXDHGHRUERA(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool LUXEYDTDVKN(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult CWBLUEIRSRP(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float NUNKOPORNHD(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult ETMPWTUJUHD(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime CVWAQDJLZLW(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult MPRRFCZWBOU(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long JGXNAPQINDB(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult RWZIYULCSDR(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a QLOZDRSQPHM<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult GWMUAUJNZCC<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool RNQMNFLGCEG(string a);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool YMFDRPHOZOX(string a);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string QVRNNNLJPVQ(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult JWLOVOJEOUS(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int TBKLVLYAEHG(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult HQIQDPIDNWQ(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool PFCBNEJXZSX(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult AVPVRYPHLFN(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float ZWOKPWJWMTJ(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult OFDGNRXPCQD(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime JQHEWGKIHBQ(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult RTJMRVUGAUS(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long SKJHHPFWDUJ(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult ZYMIXHSBPKJ(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void BMYGOWVMKDW<e>(ZEAELRSVOME<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void AGHMJPXYUYL<f>();

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable GFKAQXFJFYI();

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void PSUQITQMSSX(float a);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task IIMTRUTYAAM([Optional] CancellationToken a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public enum SetResult : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		Unchanged,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		New,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		Changed
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class Preferences : QGJARWQTXXT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private abstract class MODBXGVKAVB
		{
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			protected static readonly HashSet<MODBXGVKAVB> LMDKFTOTEUO;

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9DC4AA0", Offset = "0x9DC34A0", VA = "0x189DC4AA0")]
			public static void SKSACPWCQDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			protected MODBXGVKAVB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private class LUZYCSDPEMI<a> : MODBXGVKAVB
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly LUZYCSDPEMI<a> UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public ZEAELRSVOME<a> EIRDYBDJOQJ
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public IEqualityComparer<a> KFTYRZNBDXX
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool TXVHKMUVWOO
			{
				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xEAE870", Offset = "0xEAD270", VA = "0x180EAE870")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x68F2280", Offset = "0x68F0C80", VA = "0x1868F2280")]
			private LUZYCSDPEMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x68F1640", Offset = "0x68F0040", VA = "0x1868F1640")]
			public void WSFSWRIEDET(ZEAELRSVOME<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x104F8B0", Offset = "0x104E2B0", VA = "0x18104F8B0", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private class FOXCSXWUQIX : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private readonly Preferences YONUBYGYDWM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private readonly object CUNMZOQTFWK;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9DC1BC0", Offset = "0x9DC05C0", VA = "0x189DC1BC0")]
			public FOXCSXWUQIX(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9DC1B90", Offset = "0x9DC0590", VA = "0x189DC1B90", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private struct <InitializeForPlayerInternal>d__23 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public long playerAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x9DC9A60", Offset = "0x9DC8460", VA = "0x189DC9A60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x9DC9D50", Offset = "0x9DC8750", VA = "0x189DC9D50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private struct <Save>d__77 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public PMIBWDISFAW backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x9DCA710", Offset = "0x9DC9110", VA = "0x189DCA710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct <SaveImmediate>d__78 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public Preferences <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x9DC9DB0", Offset = "0x9DC87B0", VA = "0x189DC9DB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x9DCA280", Offset = "0x9DC8C80", VA = "0x189DCA280", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class SUFGZTOVDFT : IEnumerator<OSEXMMYDSBS>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private OSEXMMYDSBS RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Preferences TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float SIDVNFLMHYP;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private OSEXMMYDSBS XMCHSAEGAKP
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
			[DebuggerHidden]
			public SUFGZTOVDFT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x9DC8AF0", Offset = "0x9DC74F0", VA = "0x189DC8AF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9DC8AB0", Offset = "0x9DC74B0", VA = "0x189DC8AB0", Slot = "8")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly ONUBXCTDIBZ EQZCZDSIPHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly ONUBXCTDIBZ IABDJJNSTXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly FYOJKNGMTWX ELWXAKXORKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly AQNWLBANTQG FTHBHRLZINB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly AZIFFSZNTMK.CustomSaveHandler WCTSTPZNBSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly HFGUPORPTXK AQZHELSFXXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly HashSet<PMIBWDISFAW> YMDTJYPMKJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Task UAVTHAELTXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<string, string> ZPHFHUISNTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private OVUANEJXOET OPCNTLUFSCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly object QHGPWGZZWPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly object BYSOPUJPYHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long YDKJHUDQRWM;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool OSZYPTUOZTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x1A95E10", Offset = "0x1A94810", VA = "0x181A95E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private CancellationTokenSource GTTCNHWVBBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xD141D0", Offset = "0xD12BD0", VA = "0x180D141D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xD141E0", Offset = "0xD12BE0", VA = "0x180D141E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action GUNHVJZWKDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9DC5570", Offset = "0x9DC3F70", VA = "0x189DC5570", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9DC7D60", Offset = "0x9DC6760", VA = "0x189DC7D60", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5BA0", Offset = "0x9DC45A0", VA = "0x189DC5BA0")]
		[BRMSZAJTATI.Root]
		internal static void FFUYQKNEPOZ(ZUKUOYIIEVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9DC82A0", Offset = "0x9DC6CA0", VA = "0x189DC82A0")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] ONUBXCTDIBZ localBackingStore, [Inject("Cloud")] ONUBXCTDIBZ cloudBackingStore, [Inject(null)] FYOJKNGMTWX editorBackingStore, [Inject(null)] AQNWLBANTQG scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9DC59E0", Offset = "0x9DC43E0", VA = "0x189DC59E0", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9DC54F0", Offset = "0x9DC3EF0", VA = "0x189DC54F0")]
		private void ASKFERHKUNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7A40", Offset = "0x9DC6440", VA = "0x189DC7A40", Slot = "6")]
		public void SDSAAHOEYJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7F60", Offset = "0x9DC6960", VA = "0x189DC7F60", Slot = "7")]
		public Task XSRXXWGTOLA(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7290", Offset = "0x9DC5C90", VA = "0x189DC7290")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task PLHUXWGGSMH(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8140", Offset = "0x9DC6B40", VA = "0x189DC8140")]
		private void ZMDYHLARTMS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7CE0", Offset = "0x9DC66E0", VA = "0x189DC7CE0")]
		private void TOEOPDVYEZJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6210", Offset = "0x9DC4C10", VA = "0x189DC6210")]
		private string JGQBBTGIBIG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9DC70F0", Offset = "0x9DC5AF0", VA = "0x189DC70F0")]
		private void PLAFIVQHPQM(AccountPreferenceBackingStoreTypes a, string b, [Out] ONUBXCTDIBZ c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5960", Offset = "0x9DC4360", VA = "0x189DC5960")]
		private ONUBXCTDIBZ DXDKLEWWSVW(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7E00", Offset = "0x9DC6800", VA = "0x189DC7E00", Slot = "8")]
		public bool VXKIALEOSMC(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8160", Offset = "0x9DC6B60", VA = "0x189DC8160", Slot = "9")]
		public bool ZOWVRYIFKMQ(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6890", Offset = "0x9DC5290", VA = "0x189DC6890", Slot = "10")]
		public bool MECJPRZOAUP(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6EA0", Offset = "0x9DC58A0", VA = "0x189DC6EA0", Slot = "11")]
		public string OGEOAFJNQZG(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5E20", Offset = "0x9DC4820", VA = "0x189DC5E20", Slot = "12")]
		public SetResult HMWHDBKFXUY(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7EB0", Offset = "0x9DC68B0", VA = "0x189DC7EB0", Slot = "13")]
		public int WENNJBDZNFA(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9DC76D0", Offset = "0x9DC60D0", VA = "0x189DC76D0", Slot = "14")]
		public SetResult QXDHGHRUERA(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9DC67E0", Offset = "0x9DC51E0", VA = "0x189DC67E0", Slot = "15")]
		public bool LUXEYDTDVKN(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9DC56B0", Offset = "0x9DC40B0", VA = "0x189DC56B0", Slot = "16")]
		public SetResult CWBLUEIRSRP(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6BE0", Offset = "0x9DC55E0", VA = "0x189DC6BE0", Slot = "17")]
		public float NUNKOPORNHD(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5A20", Offset = "0x9DC4420", VA = "0x189DC5A20", Slot = "18")]
		public SetResult ETMPWTUJUHD(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5610", Offset = "0x9DC4010", VA = "0x189DC5610", Slot = "19")]
		public DateTime CVWAQDJLZLW(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6A10", Offset = "0x9DC5410", VA = "0x189DC6A10", Slot = "20")]
		public SetResult MPRRFCZWBOU(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6270", Offset = "0x9DC4C70", VA = "0x189DC6270", Slot = "21")]
		public long JGXNAPQINDB(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9DC78D0", Offset = "0x9DC62D0", VA = "0x189DC78D0", Slot = "22")]
		public SetResult RWZIYULCSDR(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3DBDA20", Offset = "0x3DBC420", VA = "0x183DBDA20", Slot = "23")]
		public a QLOZDRSQPHM<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3DBCFD0", Offset = "0x3DBB9D0", VA = "0x183DBCFD0", Slot = "24")]
		public SetResult GWMUAUJNZCC<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7840", Offset = "0x9DC6240", VA = "0x189DC7840", Slot = "25")]
		public bool RNQMNFLGCEG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8130", Offset = "0x9DC6B30", VA = "0x189DC8130", Slot = "26")]
		public bool YMFDRPHOZOX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7660", Offset = "0x9DC6060", VA = "0x189DC7660", Slot = "27")]
		public string QVRNNNLJPVQ(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9DC63E0", Offset = "0x9DC4DE0", VA = "0x189DC63E0", Slot = "28")]
		public SetResult JWLOVOJEOUS(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7C70", Offset = "0x9DC6670", VA = "0x189DC7C70", Slot = "29")]
		public int TBKLVLYAEHG(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5FA0", Offset = "0x9DC49A0", VA = "0x189DC5FA0", Slot = "30")]
		public SetResult HQIQDPIDNWQ(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7080", Offset = "0x9DC5A80", VA = "0x189DC7080", Slot = "31")]
		public bool PFCBNEJXZSX(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5540", Offset = "0x9DC3F40", VA = "0x189DC5540", Slot = "32")]
		public SetResult AVPVRYPHLFN(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8200", Offset = "0x9DC6C00", VA = "0x189DC8200", Slot = "33")]
		public float ZWOKPWJWMTJ(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6E70", Offset = "0x9DC5870", VA = "0x189DC6E70", Slot = "34")]
		public SetResult OFDGNRXPCQD(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6310", Offset = "0x9DC4D10", VA = "0x189DC6310", Slot = "35")]
		public DateTime JQHEWGKIHBQ(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9DC78A0", Offset = "0x9DC62A0", VA = "0x189DC78A0", Slot = "36")]
		public SetResult RTJMRVUGAUS(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7AB0", Offset = "0x9DC64B0", VA = "0x189DC7AB0", Slot = "37")]
		public long SKJHHPFWDUJ(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8270", Offset = "0x9DC6C70", VA = "0x189DC8270", Slot = "38")]
		public SetResult ZYMIXHSBPKJ(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6380", Offset = "0x9DC4D80", VA = "0x189DC6380")]
		private bool JVXKSBWVLLU(PMIBWDISFAW a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9DC73A0", Offset = "0x9DC5DA0", VA = "0x189DC73A0")]
		private bool PQMIPRVGIYB(PMIBWDISFAW a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7510", Offset = "0x9DC5F10", VA = "0x189DC7510")]
		private SetResult QOJYSGGSKGD(PMIBWDISFAW a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5C10", Offset = "0x9DC4610", VA = "0x189DC5C10")]
		private SetResult GECAMCUASIP(PMIBWDISFAW a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5820", Offset = "0x9DC4220", VA = "0x189DC5820")]
		private SetResult DLMDSWZAJXQ(PMIBWDISFAW a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9DC60C0", Offset = "0x9DC4AC0", VA = "0x189DC60C0")]
		private SetResult JESHVAXXLFG(PMIBWDISFAW a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6410", Offset = "0x9DC4E10", VA = "0x189DC6410")]
		private SetResult KMQALAQIBKT(PMIBWDISFAW a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6F40", Offset = "0x9DC5940", VA = "0x189DC6F40")]
		private SetResult OKOUSWDNBBS(PMIBWDISFAW a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD400", Offset = "0x3DBBE00", VA = "0x183DBD400")]
		private e JBPVLWKMNFL<e>(PMIBWDISFAW a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3DBE500", Offset = "0x3DBCF00", VA = "0x183DBE500")]
		private SetResult YWVKFVEFBXD<f>(PMIBWDISFAW a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3DBCC90", Offset = "0x3DBB690", VA = "0x183DBCC90", Slot = "39")]
		public void BMYGOWVMKDW<g>(ZEAELRSVOME<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3DBCB50", Offset = "0x3DBB550", VA = "0x183DBCB50", Slot = "40")]
		public void AGHMJPXYUYL<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7BA0", Offset = "0x9DC65A0", VA = "0x189DC7BA0")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(PMIBWDISFAW backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5FD0", Offset = "0x9DC49D0", VA = "0x189DC5FD0", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task IIMTRUTYAAM([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6C90", Offset = "0x9DC5690", VA = "0x189DC6C90")]
		private void OETRRPNXWDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5D50", Offset = "0x9DC4750", VA = "0x189DC5D50", Slot = "41")]
		public IDisposable GFKAQXFJFYI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7500", Offset = "0x9DC5F00", VA = "0x189DC7500", Slot = "42")]
		public void PSUQITQMSSX(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6580", Offset = "0x9DC4F80", VA = "0x189DC6580")]
		private void LAELYEYZZAP(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9DC7B20", Offset = "0x9DC6520", VA = "0x189DC7B20")]
		[IteratorStateMachine(typeof(SUFGZTOVDFT))]
		private IEnumerator<OSEXMMYDSBS> SUZFEYFXQUB(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9DC6BB0", Offset = "0x9DC55B0", VA = "0x189DC6BB0")]
		[CompilerGenerated]
		private void NIKVJFTFKJY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class CZHSLEQOIJV
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1760", Offset = "0x9DC0160", VA = "0x189DC1760")]
		public static string FYDHEKXOKZC(this QGJARWQTXXT a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9DC18D0", Offset = "0x9DC02D0", VA = "0x189DC18D0")]
		public static byte[] OJHIHUNBUHK(this QGJARWQTXXT a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1A80", Offset = "0x9DC0480", VA = "0x189DC1A80")]
		public static SetResult OUVEVDWRUAI(this QGJARWQTXXT a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RGQQVDQZFJE : UHZRSONWGEO<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static RGQQVDQZFJE UIOXUQVVXGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x9DC8990", Offset = "0x9DC7390", VA = "0x189DC8990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8620", Offset = "0x9DC7020", VA = "0x189DC8620", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8710", Offset = "0x9DC7110", VA = "0x189DC8710", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9DC8A70", Offset = "0x9DC7470", VA = "0x189DC8A70")]
		public RGQQVDQZFJE()
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
