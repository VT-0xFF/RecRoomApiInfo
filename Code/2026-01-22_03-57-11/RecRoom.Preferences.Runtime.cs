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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E1C30", Offset = "0x86E0430", VA = "0x1886E1C30")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E1AB0", Offset = "0x86E02B0", VA = "0x1886E1AB0", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x86ED8E0", Offset = "0x86EC0E0", VA = "0x1886ED8E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x275D1F0", Offset = "0x275B9F0", VA = "0x18275D1F0")]
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
	internal static class UVQHXWRKJIX
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal delegate void CustomSaveHandler(FASRJDYTVDP backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86E6BE0", Offset = "0x86E53E0", VA = "0x1886E6BE0")]
		private static void JKXQTVYVDLO(FASRJDYTVDP a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86E7060", Offset = "0x86E5860", VA = "0x1886E7060")]
		public static bool PJTDZEKWMKK(this FASRJDYTVDP a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86E6950", Offset = "0x86E5150", VA = "0x1886E6950")]
		public static SetResult AWYWPXVRWDX(this FASRJDYTVDP a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x86E6AA0", Offset = "0x86E52A0", VA = "0x1886E6AA0")]
		public static SetResult COKVRNAZXFZ(this FASRJDYTVDP a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x86E6DD0", Offset = "0x86E55D0", VA = "0x1886E6DD0")]
		public static SetResult KYSOKLKJMJK(this FASRJDYTVDP a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x86E71C0", Offset = "0x86E59C0", VA = "0x1886E71C0")]
		public static SetResult PKZIBDWUBOE(this FASRJDYTVDP a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86E6C60", Offset = "0x86E5460", VA = "0x1886E6C60")]
		public static SetResult JSIXRORNOGJ(this FASRJDYTVDP a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x86E6F20", Offset = "0x86E5720", VA = "0x1886E6F20")]
		public static SetResult MRCYUNHKOEG(this FASRJDYTVDP a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class WYZBOTZYHBI : MDLCVJRNJRA, FASRJDYTVDP
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log MIFSZHMCPMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly KLUUCDQKGNV DANWDMZKHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Dictionary<string, byte> TQLTQOXRGFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Dictionary<string, string> UWTAYZZJPCT;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool XBJSXLTIPVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> FCKDHEIBMAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x86E9F70", Offset = "0x86E8770", VA = "0x1886E9F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ESCFXIJEPGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x86EA5E0", Offset = "0x86E8DE0", VA = "0x1886EA5E0")]
		[UnityEngine.Scripting.Preserve]
		public WYZBOTZYHBI([Inject(null)] KLUUCDQKGNV unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "8")]
		public void CILFSIVTKHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x86E9BC0", Offset = "0x86E83C0", VA = "0x1886E9BC0")]
		private DirectoryInfo UGSUHMLLBTP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x86E9800", Offset = "0x86E8000", VA = "0x1886E9800", Slot = "6")]
		public Task SRJAETJSLVL(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x86E9720", Offset = "0x86E7F20", VA = "0x1886E9720", Slot = "14")]
		public float MRPWVJNMDLL(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x86EA250", Offset = "0x86E8A50", VA = "0x1886EA250", Slot = "13")]
		public void ZHHITVUZFZD(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x86EA120", Offset = "0x86E8920", VA = "0x1886EA120", Slot = "12")]
		public bool YXHTRMXRSPX(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86E96B0", Offset = "0x86E7EB0", VA = "0x1886E96B0", Slot = "10")]
		public int MLHUNWVMZMS(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x86E8240", Offset = "0x86E6A40", VA = "0x1886E8240", Slot = "18")]
		public DateTime DICJFALSRQM(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86E9CB0", Offset = "0x86E84B0", VA = "0x1886E9CB0", Slot = "19")]
		public void VNIYIPUQONK(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86E81D0", Offset = "0x86E69D0", VA = "0x1886E81D0", Slot = "15")]
		public void DBTIZWQTVEN(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86E9F00", Offset = "0x86E8700", VA = "0x1886E9F00", Slot = "11")]
		public void XBWPHAZOAGO(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x86E9FB0", Offset = "0x86E87B0", VA = "0x1886E9FB0", Slot = "20")]
		public long YJZIDUKGYML(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86E9790", Offset = "0x86E7F90", VA = "0x1886E9790", Slot = "21")]
		public void NVGGRUXWZNB(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3C0AD70", Offset = "0x3C09570", VA = "0x183C0AD70", Slot = "22")]
		public a JQLXJYAIKDY<a>(string a, a b, IWSXLDXORPN<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C4E0", Offset = "0x3C0ACE0", VA = "0x183C0C4E0", Slot = "23")]
		public void ZNVYTYMKZRU<b>(string a, b b, IWSXLDXORPN<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86E82B0", Offset = "0x86E6AB0", VA = "0x1886E82B0", Slot = "16")]
		public string GQYOJHZYNNC(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x86EA1E0", Offset = "0x86E89E0", VA = "0x1886EA1E0", Slot = "17")]
		public void YZYUHGTRLYA(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86E9D20", Offset = "0x86E8520", VA = "0x1886E9D20", Slot = "24")]
		public void VRALHMZLZIL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x86EA4E0", Offset = "0x86E8CE0", VA = "0x1886EA4E0", Slot = "9")]
		public bool ZZQUXRBJYMY(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86E9890", Offset = "0x86E8090", VA = "0x1886E9890", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x86E8360", Offset = "0x86E6B60", VA = "0x1886E8360")]
		private void GRBHNWLMSRR(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x86EA2C0", Offset = "0x86E8AC0", VA = "0x1886EA2C0")]
		private static string ZNKDAYBFZSC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86EA020", Offset = "0x86E8820", VA = "0x1886EA020")]
		private static string YOVUMCESERJ(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3C09590", Offset = "0x3C07D90", VA = "0x183C09590")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] IWSXLDXORPN<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3C0AF50", Offset = "0x3C09750", VA = "0x183C0AF50")]
		private void Set<T>(string propertyName, T value, [Optional] IWSXLDXORPN<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x86E8980", Offset = "0x86E7180", VA = "0x1886E8980")]
		private Dictionary<string, string> HYNAWAWEZLN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x86E8170", Offset = "0x86E6970", VA = "0x1886E8170")]
		private void CTHYHILOQFR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x86E9E90", Offset = "0x86E8690", VA = "0x1886E9E90")]
		private void XBPTGNAVWFO(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class PZXTQXTLKLG
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log MIFSZHMCPMX;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x86E1CB0", Offset = "0x86E04B0", VA = "0x1886E1CB0")]
		[SLGIUIECCXF.Root]
		internal static void SLGIUIECCXF(MUPQGBSCKZR a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MYZVQBKASFD : VPEBKERQYWA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x86E1BB0", Offset = "0x86E03B0", VA = "0x1886E1BB0")]
		[UnityEngine.Scripting.Preserve]
		public MYZVQBKASFD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class VEQWPSAYDWF : MDLCVJRNJRA, FASRJDYTVDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly KLUUCDQKGNV DANWDMZKHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Dictionary<string, string> URSRUEOLYSD;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool XBJSXLTIPVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action ESCFXIJEPGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x86E7A70", Offset = "0x86E6270", VA = "0x1886E7A70")]
		[UnityEngine.Scripting.Preserve]
		public VEQWPSAYDWF([Inject(null)] KLUUCDQKGNV unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86E75C0", Offset = "0x86E5DC0", VA = "0x1886E75C0", Slot = "6")]
		public Task SRJAETJSLVL(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "8")]
		public void CILFSIVTKHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x86E7A10", Offset = "0x86E6210", VA = "0x1886E7A10", Slot = "9")]
		public bool ZZQUXRBJYMY(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x86E7470", Offset = "0x86E5C70", VA = "0x1886E7470", Slot = "10")]
		public int MLHUNWVMZMS(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x86E77E0", Offset = "0x86E5FE0", VA = "0x1886E77E0", Slot = "11")]
		public void XBWPHAZOAGO(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x86E78C0", Offset = "0x86E60C0", VA = "0x1886E78C0", Slot = "12")]
		public bool YXHTRMXRSPX(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x86E79A0", Offset = "0x86E61A0", VA = "0x1886E79A0", Slot = "13")]
		public void ZHHITVUZFZD(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x86E74E0", Offset = "0x86E5CE0", VA = "0x1886E74E0", Slot = "14")]
		public float MRPWVJNMDLL(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x86E7310", Offset = "0x86E5B10", VA = "0x1886E7310", Slot = "15")]
		public void DBTIZWQTVEN(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x86E73F0", Offset = "0x86E5BF0", VA = "0x1886E73F0", Slot = "16")]
		public string GQYOJHZYNNC(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x86E7930", Offset = "0x86E6130", VA = "0x1886E7930", Slot = "17")]
		public void YZYUHGTRLYA(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x86E7380", Offset = "0x86E5B80", VA = "0x1886E7380", Slot = "18")]
		public DateTime DICJFALSRQM(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x86E76E0", Offset = "0x86E5EE0", VA = "0x1886E76E0", Slot = "19")]
		public void VNIYIPUQONK(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x86E7850", Offset = "0x86E6050", VA = "0x1886E7850", Slot = "20")]
		public long YJZIDUKGYML(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x86E7550", Offset = "0x86E5D50", VA = "0x1886E7550", Slot = "21")]
		public void NVGGRUXWZNB(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3BDE020", Offset = "0x3BDC820", VA = "0x183BDE020", Slot = "22")]
		public a JQLXJYAIKDY<a>(string a, a b, IWSXLDXORPN<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3BDF360", Offset = "0x3BDDB60", VA = "0x183BDF360", Slot = "23")]
		public void ZNVYTYMKZRU<b>(string a, b b, IWSXLDXORPN<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x86E7750", Offset = "0x86E5F50", VA = "0x1886E7750", Slot = "24")]
		public void VRALHMZLZIL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x86E7650", Offset = "0x86E5E50", VA = "0x1886E7650", Slot = "25")]
		public Task Save([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3BDC8C0", Offset = "0x3BDB0C0", VA = "0x183BDC8C0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] IWSXLDXORPN<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3BDE200", Offset = "0x3BDCA00", VA = "0x183BDE200")]
		private void Set<T>(string propertyName, T value, [Optional] IWSXLDXORPN<T> parser)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class VPEBKERQYWA : MDLCVJRNJRA, FASRJDYTVDP, JUEZTEBCYTS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly Dictionary<string, object> FXIJUWFPEKI;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool XBJSXLTIPVF
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action ESCFXIJEPGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "8")]
		public void CILFSIVTKHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x86E7D50", Offset = "0x86E6550", VA = "0x1886E7D50", Slot = "6")]
		public Task SRJAETJSLVL(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x86E8110", Offset = "0x86E6910", VA = "0x1886E8110", Slot = "9")]
		public bool ZZQUXRBJYMY(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x86E7C30", Offset = "0x86E6430", VA = "0x1886E7C30", Slot = "10")]
		public int MLHUNWVMZMS(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x86E7F30", Offset = "0x86E6730", VA = "0x1886E7F30", Slot = "11")]
		public void XBWPHAZOAGO(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x86E7FF0", Offset = "0x86E67F0", VA = "0x1886E7FF0", Slot = "12")]
		public bool YXHTRMXRSPX(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x86E80B0", Offset = "0x86E68B0", VA = "0x1886E80B0", Slot = "13")]
		public void ZHHITVUZFZD(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x86E7C90", Offset = "0x86E6490", VA = "0x1886E7C90", Slot = "14")]
		public float MRPWVJNMDLL(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x86E7B10", Offset = "0x86E6310", VA = "0x1886E7B10", Slot = "15")]
		public void DBTIZWQTVEN(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x86E7BD0", Offset = "0x86E63D0", VA = "0x1886E7BD0", Slot = "16")]
		public string GQYOJHZYNNC(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x86E8050", Offset = "0x86E6850", VA = "0x1886E8050", Slot = "17")]
		public void YZYUHGTRLYA(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x86E7B70", Offset = "0x86E6370", VA = "0x1886E7B70", Slot = "18")]
		public DateTime DICJFALSRQM(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x86E7E70", Offset = "0x86E6670", VA = "0x1886E7E70", Slot = "19")]
		public void VNIYIPUQONK(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x86E7F90", Offset = "0x86E6790", VA = "0x1886E7F90", Slot = "20")]
		public long YJZIDUKGYML(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x86E7CF0", Offset = "0x86E64F0", VA = "0x1886E7CF0", Slot = "21")]
		public void NVGGRUXWZNB(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3BE6C10", Offset = "0x3BE5410", VA = "0x183BE6C10", Slot = "22")]
		public a JQLXJYAIKDY<a>(string a, a b, IWSXLDXORPN<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3BE7670", Offset = "0x3BE5E70", VA = "0x183BE7670", Slot = "23")]
		public void ZNVYTYMKZRU<b>(string a, b b, IWSXLDXORPN<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3BE6040", Offset = "0x3BE4840", VA = "0x183BE6040")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3BE6FD0", Offset = "0x3BE57D0", VA = "0x183BE6FD0")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x86E7ED0", Offset = "0x86E66D0", VA = "0x1886E7ED0", Slot = "24")]
		public void VRALHMZLZIL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x86E7DE0", Offset = "0x86E65E0", VA = "0x1886E7DE0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x86E1BB0", Offset = "0x86E03B0", VA = "0x1886E1BB0")]
		public VPEBKERQYWA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class UGOOAQWBJKL<a> where a : FASRJDYTVDP
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly HashSet<UGOOAQWBJKL<a>> NEDXINEGGZS;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x619BF50", Offset = "0x619A750", VA = "0x18619BF50")]
		protected UGOOAQWBJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void IEVFRPWSRRV(string a);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x619B630", Offset = "0x6199E30", VA = "0x18619B630")]
		public static void FWJAGKASYXN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x619B820", Offset = "0x619A020", VA = "0x18619B820")]
		public static void VYFYOIMWEFN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class UGTUXXPYSVU<a, b> : UGOOAQWBJKL<a> where a : FASRJDYTVDP
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly UGTUXXPYSVU<a, b> BIGUOPIZRYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Dictionary<string, b> TYSIFCSXIAP;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x619C220", Offset = "0x619AA20", VA = "0x18619C220")]
		public bool LHRMMYTLGSF(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x619C300", Offset = "0x619AB00", VA = "0x18619C300")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
		public IEnumerable<KeyValuePair<string, b>> XUNQYQENPYQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x619BFF0", Offset = "0x619A7F0", VA = "0x18619BFF0", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x619C050", Offset = "0x619A850", VA = "0x18619C050", Slot = "5")]
		protected override void IEVFRPWSRRV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x619C8D0", Offset = "0x619B0D0", VA = "0x18619C8D0")]
		public UGTUXXPYSVU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface FASRJDYTVDP
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool XBJSXLTIPVF
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CILFSIVTKHH();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ZZQUXRBJYMY(string a);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int MLHUNWVMZMS(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void XBWPHAZOAGO(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool YXHTRMXRSPX(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZHHITVUZFZD(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float MRPWVJNMDLL(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void DBTIZWQTVEN(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string GQYOJHZYNNC(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void YZYUHGTRLYA(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime DICJFALSRQM(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void VNIYIPUQONK(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long YJZIDUKGYML(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void NVGGRUXWZNB(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a JQLXJYAIKDY<a>(string a, a b, IWSXLDXORPN<a> c);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void ZNVYTYMKZRU<b>(string a, b b, IWSXLDXORPN<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void VRALHMZLZIL(string a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface MDLCVJRNJRA : FASRJDYTVDP
	{
		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action ESCFXIJEPGB;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task SRJAETJSLVL(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface JUEZTEBCYTS : FASRJDYTVDP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class ZNETFVUNGOS : MDLCVJRNJRA, FASRJDYTVDP
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
			public ZNETFVUNGOS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x86E5B20", Offset = "0x86E4320", VA = "0x1886E5B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x86E5EF0", Offset = "0x86E46F0", VA = "0x1886E5EF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class TNHFIBRAPXA : IEnumerator<ZCECIALXIMT>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private ZCECIALXIMT VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public ZNETFVUNGOS BDLWXAGXLOZ;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private ZCECIALXIMT NOLEYVPTISW
			{
				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public TNHFIBRAPXA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x86E5230", Offset = "0x86E3A30", VA = "0x1886E5230", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x86E51F0", Offset = "0x86E39F0", VA = "0x1886E51F0", Slot = "8")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly Log MIFSZHMCPMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly KLUUCDQKGNV DANWDMZKHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool EXAAOTKABPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool ANVLJYRTNQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private UJRYTLVVYNJ BCRPUIYVFQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private BFFPISQCYKM RNMRLXDRNUK;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool XBJSXLTIPVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action ESCFXIJEPGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x86ED7E0", Offset = "0x86EBFE0", VA = "0x1886ED7E0")]
		[UnityEngine.Scripting.Preserve]
		public ZNETFVUNGOS([Inject(null)] KLUUCDQKGNV unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "8")]
		public void CILFSIVTKHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x86EB5E0", Offset = "0x86E9DE0", VA = "0x1886EB5E0", Slot = "6")]
		public Task SRJAETJSLVL(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1BCF5B0", Offset = "0x1BCDDB0", VA = "0x181BCF5B0")]
		private static int HTRKRAQJOFF(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x86ED750", Offset = "0x86EBF50", VA = "0x1886ED750", Slot = "9")]
		public bool ZZQUXRBJYMY(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x86EB1A0", Offset = "0x86E99A0", VA = "0x1886EB1A0", Slot = "10")]
		public int MLHUNWVMZMS(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x86ED1D0", Offset = "0x86EB9D0", VA = "0x1886ED1D0", Slot = "11")]
		public void XBWPHAZOAGO(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x86ED350", Offset = "0x86EBB50", VA = "0x1886ED350", Slot = "12")]
		public bool YXHTRMXRSPX(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x86ED5D0", Offset = "0x86EBDD0", VA = "0x1886ED5D0", Slot = "13")]
		public void ZHHITVUZFZD(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x86EB2C0", Offset = "0x86E9AC0", VA = "0x1886EB2C0", Slot = "14")]
		public float MRPWVJNMDLL(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x86EACB0", Offset = "0x86E94B0", VA = "0x1886EACB0", Slot = "15")]
		public void DBTIZWQTVEN(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x86EAD70", Offset = "0x86E9570", VA = "0x1886EAD70", Slot = "18")]
		public DateTime DICJFALSRQM(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x86ED060", Offset = "0x86EB860", VA = "0x1886ED060", Slot = "19")]
		public void VNIYIPUQONK(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x86ED2E0", Offset = "0x86EBAE0", VA = "0x1886ED2E0", Slot = "20")]
		public long YJZIDUKGYML(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x86EB510", Offset = "0x86E9D10", VA = "0x1886EB510", Slot = "21")]
		public void NVGGRUXWZNB(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3C45540", Offset = "0x3C43D40", VA = "0x183C45540", Slot = "22")]
		public a JQLXJYAIKDY<a>(string a, a b, IWSXLDXORPN<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3C47480", Offset = "0x3C45C80", VA = "0x183C47480", Slot = "23")]
		public void ZNVYTYMKZRU<b>(string a, b b, IWSXLDXORPN<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3C45740", Offset = "0x3C43F40", VA = "0x183C45740")]
		private c QQXXPYMSKTN<c>(string a, c b, [Optional] IWSXLDXORPN<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3C46810", Offset = "0x3C45010", VA = "0x183C46810")]
		private void VHLDWBSDGCT<d>(string a, d b, [Optional] IWSXLDXORPN<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x86EADE0", Offset = "0x86E95E0", VA = "0x1886EADE0", Slot = "16")]
		public string GQYOJHZYNNC(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x86ED4A0", Offset = "0x86EBCA0", VA = "0x1886ED4A0", Slot = "17")]
		public void YZYUHGTRLYA(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x86EB3F0", Offset = "0x86E9BF0", VA = "0x1886EB3F0")]
		private void NCAYOGSPRHL(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x86EAF90", Offset = "0x86E9790", VA = "0x1886EAF90")]
		private string GYKZGBHYUMB(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x86ED0D0", Offset = "0x86EB8D0", VA = "0x1886ED0D0", Slot = "24")]
		public void VRALHMZLZIL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x86ED6B0", Offset = "0x86EBEB0", VA = "0x1886ED6B0")]
		private string ZZGBPKLRQIX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x86EB760", Offset = "0x86E9F60", VA = "0x1886EB760")]
		public void TGECKAIGBOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x86EB580", Offset = "0x86E9D80", VA = "0x1886EB580", Slot = "26")]
		public void QEKUOYBIWJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x86EB670", Offset = "0x86E9E70", VA = "0x1886EB670", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__40))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x86EB130", Offset = "0x86E9930", VA = "0x1886EB130")]
		[IteratorStateMachine(typeof(TNHFIBRAPXA))]
		private IEnumerator<ZCECIALXIMT> JQUVREXUYOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x86ED280", Offset = "0x86EBA80", VA = "0x1886ED280")]
		private void YFLEGQUPNFR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x86EAC40", Offset = "0x86E9440", VA = "0x1886EAC40")]
		private void CTHYHILOQFR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x86ED160", Offset = "0x86EB960", VA = "0x1886ED160")]
		private void XBPTGNAVWFO(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class FRDVJZXVFIU : MDLCVJRNJRA, FASRJDYTVDP
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
		private Dictionary<string, string> UWTAYZZJPCT;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool XBJSXLTIPVF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string QCXJTZYZGPW
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x86E0C10", Offset = "0x86DF410", VA = "0x1886E0C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private string UNKWMMTDJJU
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x86E1060", Offset = "0x86DF860", VA = "0x1886E1060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Dictionary<string, string> FCKDHEIBMAX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x86E16D0", Offset = "0x86DFED0", VA = "0x1886E16D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action ESCFXIJEPGB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		[UnityEngine.Scripting.Preserve]
		public FRDVJZXVFIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "8")]
		public void CILFSIVTKHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x86E1240", Offset = "0x86DFA40", VA = "0x1886E1240", Slot = "6")]
		public Task SRJAETJSLVL(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x86E1160", Offset = "0x86DF960", VA = "0x1886E1160", Slot = "14")]
		public float MRPWVJNMDLL(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x86E18E0", Offset = "0x86E00E0", VA = "0x1886E18E0", Slot = "13")]
		public void ZHHITVUZFZD(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x86E1780", Offset = "0x86DFF80", VA = "0x1886E1780", Slot = "12")]
		public bool YXHTRMXRSPX(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x86E10F0", Offset = "0x86DF8F0", VA = "0x1886E10F0", Slot = "10")]
		public int MLHUNWVMZMS(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x86E0BA0", Offset = "0x86DF3A0", VA = "0x1886E0BA0", Slot = "18")]
		public DateTime DICJFALSRQM(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x86E1530", Offset = "0x86DFD30", VA = "0x1886E1530", Slot = "19")]
		public void VNIYIPUQONK(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x86E0B30", Offset = "0x86DF330", VA = "0x1886E0B30", Slot = "15")]
		public void DBTIZWQTVEN(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x86E1660", Offset = "0x86DFE60", VA = "0x1886E1660", Slot = "11")]
		public void XBWPHAZOAGO(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x86E1710", Offset = "0x86DFF10", VA = "0x1886E1710", Slot = "20")]
		public long YJZIDUKGYML(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x86E11D0", Offset = "0x86DF9D0", VA = "0x1886E11D0", Slot = "21")]
		public void NVGGRUXWZNB(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x36ADE40", Offset = "0x36AC640", VA = "0x1836ADE40", Slot = "22")]
		public a JQLXJYAIKDY<a>(string a, a b, IWSXLDXORPN<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x36AF300", Offset = "0x36ADB00", VA = "0x1836AF300", Slot = "23")]
		public void ZNVYTYMKZRU<b>(string a, b b, IWSXLDXORPN<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x86E0CA0", Offset = "0x86DF4A0", VA = "0x1886E0CA0", Slot = "16")]
		public string GQYOJHZYNNC(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x86E1840", Offset = "0x86E0040", VA = "0x1886E1840", Slot = "17")]
		public void YZYUHGTRLYA(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x86E15A0", Offset = "0x86DFDA0", VA = "0x1886E15A0", Slot = "24")]
		public void VRALHMZLZIL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x86E1950", Offset = "0x86E0150", VA = "0x1886E1950", Slot = "9")]
		public bool ZZQUXRBJYMY(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x86E12D0", Offset = "0x86DFAD0", VA = "0x1886E12D0", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x36AC530", Offset = "0x36AAD30", VA = "0x1836AC530")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] IWSXLDXORPN<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x36AE020", Offset = "0x36AC820", VA = "0x1836AE020")]
		private void Set<T>(string propertyName, T value, [Optional] IWSXLDXORPN<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x86E0D50", Offset = "0x86DF550", VA = "0x1886E0D50")]
		private Dictionary<string, string> HYNAWAWEZLN()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface FSYMTSLYMQM
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action ESCFXIJEPGB;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CILFSIVTKHH();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task QVTCWHUYNQX(long a);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool CYJFCBRDQOX(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool XWXDUBQOBQL(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool LXPKZPJYXIC(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string ASGEQNVSCVT(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult RLVCUZJPFQV(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int ZPQWOTGDBSV(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult QHTEOPQNSDL(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool EWYTLNKEVFO(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult RPNQGHYSILK(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float EIUXLJUJNZY(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult ZDZUHZGYCFI(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime LSNKLQHKPKR(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult SZGYEEXNEVT(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long ENANPBFFRBE(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult TWMENBCUULI(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a JYWQRWNWSHR<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult JXKABPNZCPV<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool BPRYETEOTJZ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool OGCIJRUSJZS(string a);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string ZNLQKLIHGQN(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult JBTVLPSVHSJ(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int ARGUDJBHQWB(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult NWSTDOCUVLH(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool RMYCILHZGWY(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult LNVQBNHEFDW(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float NFOKYLHFYCS(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult HLFHPVFMITE(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime HLIMSAJMZHH(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult CKFHCQLZORD(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long DXCYXDGIBSC(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult KQPSBJWJYXI(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void SNHWZOTOVDL<e>(IWSXLDXORPN<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void SPMTILNONNY<f>();

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable IUWUWPKPIPR();

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void ATSCOXDEZDO(float a);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task YFLEGQUPNFR([Optional] CancellationToken a);
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
	public class Preferences : FSYMTSLYMQM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private abstract class QAKDDGZEBKC
		{
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			protected static readonly HashSet<QAKDDGZEBKC> HKKZRJKTLQN;

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x86E5030", Offset = "0x86E3830", VA = "0x1886E5030")]
			public static void VYFYOIMWEFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			protected QAKDDGZEBKC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private class IFMGRCLRMAF<a> : QAKDDGZEBKC
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly IFMGRCLRMAF<a> QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public IWSXLDXORPN<a> FVGTEKLYAOY
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xAACAF0", Offset = "0xAAB2F0", VA = "0x180AACAF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public IEqualityComparer<a> EKSNIDSSQUE
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xAACB10", Offset = "0xAAB310", VA = "0x180AACB10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool TVMXJAENUYL
			{
				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xC4B8B0", Offset = "0xC4A0B0", VA = "0x180C4B8B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x5001A80", Offset = "0x5000280", VA = "0x185001A80")]
			private IFMGRCLRMAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x5000FB0", Offset = "0x4FFF7B0", VA = "0x185000FB0")]
			public void JPLRKQDWIBU(IWSXLDXORPN<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xDA6BD0", Offset = "0xDA53D0", VA = "0x180DA6BD0", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private class ZJDEZSKTDNA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private readonly Preferences SXTLZJDLHVR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private readonly object LUAWGVVHIDD;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x86EAB90", Offset = "0x86E9390", VA = "0x1886EAB90")]
			public ZJDEZSKTDNA(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x86EAB60", Offset = "0x86E9360", VA = "0x1886EAB60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E52A0", Offset = "0x86E3AA0", VA = "0x1886E52A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x86E5590", Offset = "0x86E3D90", VA = "0x1886E5590", Slot = "5")]
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
			public FASRJDYTVDP backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x86E5F50", Offset = "0x86E4750", VA = "0x1886E5F50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x86E55F0", Offset = "0x86E3DF0", VA = "0x1886E55F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x86E5AC0", Offset = "0x86E42C0", VA = "0x1886E5AC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class IHZPIHTXRNO : IEnumerator<ZCECIALXIMT>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private ZCECIALXIMT VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Preferences BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float SHYVURPHUEA;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private ZCECIALXIMT NOLEYVPTISW
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public IHZPIHTXRNO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x86E1A20", Offset = "0x86E0220", VA = "0x1886E1A20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x86E19E0", Offset = "0x86E01E0", VA = "0x1886E19E0", Slot = "8")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly MDLCVJRNJRA MPVOARVETIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly MDLCVJRNJRA DNYPRIHBCZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly JUEZTEBCYTS IXMFADRJRTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly UJRYTLVVYNJ BCRPUIYVFQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly UVQHXWRKJIX.CustomSaveHandler ULKZDKVUMSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly VIJGXVWMDWL HCJSXTZQBZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly HashSet<FASRJDYTVDP> NJPJJZNMIPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Task OMDXMYAGAYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<string, string> WAVBLCMWOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private BFFPISQCYKM JFAFEMESJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly object QWDTQRUJUNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly object LAQHTZUSJJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long PSKETDLGDNH;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool OWAPGRTQDSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x17C5C50", Offset = "0x17C4450", VA = "0x1817C5C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private CancellationTokenSource KTSXIXUTJJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xAB3470", Offset = "0xAB1C70", VA = "0x180AB3470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xAB3290", Offset = "0xAB1A90", VA = "0x180AB3290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action ESCFXIJEPGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x86E43C0", Offset = "0x86E2BC0", VA = "0x1886E43C0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x86E41B0", Offset = "0x86E29B0", VA = "0x1886E41B0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x86E3B70", Offset = "0x86E2370", VA = "0x1886E3B70")]
		[SLGIUIECCXF.Root]
		internal static void RGYVRYLRKIA(MUPQGBSCKZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x86E4CA0", Offset = "0x86E34A0", VA = "0x1886E4CA0")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] MDLCVJRNJRA localBackingStore, [Inject("Cloud")] MDLCVJRNJRA cloudBackingStore, [Inject(null)] JUEZTEBCYTS editorBackingStore, [Inject(null)] UJRYTLVVYNJ scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x86E23C0", Offset = "0x86E0BC0", VA = "0x1886E23C0", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x86E2E30", Offset = "0x86E1630", VA = "0x1886E2E30")]
		private void LJQMDFTGWTV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x86E2180", Offset = "0x86E0980", VA = "0x1886E2180", Slot = "6")]
		public void CILFSIVTKHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x86E39A0", Offset = "0x86E21A0", VA = "0x1886E39A0", Slot = "7")]
		public Task QVTCWHUYNQX(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x86E44C0", Offset = "0x86E2CC0", VA = "0x1886E44C0")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task XGEXYFQNDEA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x86E27E0", Offset = "0x86E0FE0", VA = "0x1886E27E0")]
		private void HLWHWBJJUOV(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x86E2D80", Offset = "0x86E1580", VA = "0x1886E2D80")]
		private void JBVLPWNOYDG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x86E1EF0", Offset = "0x86E06F0", VA = "0x1886E1EF0")]
		private string AMMFFELIGXV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x86E33A0", Offset = "0x86E1BA0", VA = "0x1886E33A0")]
		private void NLNEBCLDXGH(AccountPreferenceBackingStoreTypes a, string b, [Out] MDLCVJRNJRA c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x86E22D0", Offset = "0x86E0AD0", VA = "0x1886E22D0")]
		private MDLCVJRNJRA DUXIUTOYAVN(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x86E2220", Offset = "0x86E0A20", VA = "0x1886E2220", Slot = "8")]
		public bool CYJFCBRDQOX(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x86E45D0", Offset = "0x86E2DD0", VA = "0x1886E45D0", Slot = "9")]
		public bool XWXDUBQOBQL(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x86E31B0", Offset = "0x86E19B0", VA = "0x1886E31B0", Slot = "10")]
		public bool LXPKZPJYXIC(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x86E1FC0", Offset = "0x86E07C0", VA = "0x1886E1FC0", Slot = "11")]
		public string ASGEQNVSCVT(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x86E3BE0", Offset = "0x86E23E0", VA = "0x1886E3BE0", Slot = "12")]
		public SetResult RLVCUZJPFQV(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x86E4BF0", Offset = "0x86E33F0", VA = "0x1886E4BF0", Slot = "13")]
		public int ZPQWOTGDBSV(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x86E3830", Offset = "0x86E2030", VA = "0x1886E3830", Slot = "14")]
		public SetResult QHTEOPQNSDL(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x86E2550", Offset = "0x86E0D50", VA = "0x1886E2550", Slot = "15")]
		public bool EWYTLNKEVFO(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x86E3DD0", Offset = "0x86E25D0", VA = "0x1886E3DD0", Slot = "16")]
		public SetResult RPNQGHYSILK(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x86E2400", Offset = "0x86E0C00", VA = "0x1886E2400", Slot = "17")]
		public float EIUXLJUJNZY(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x86E48B0", Offset = "0x86E30B0", VA = "0x1886E48B0", Slot = "18")]
		public SetResult ZDZUHZGYCFI(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x86E2EB0", Offset = "0x86E16B0", VA = "0x1886E2EB0", Slot = "19")]
		public DateTime LSNKLQHKPKR(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x86E3F40", Offset = "0x86E2740", VA = "0x1886E3F40", Slot = "20")]
		public SetResult SZGYEEXNEVT(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x86E24B0", Offset = "0x86E0CB0", VA = "0x1886E24B0", Slot = "21")]
		public long ENANPBFFRBE(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x86E4250", Offset = "0x86E2A50", VA = "0x1886E4250", Slot = "22")]
		public SetResult TWMENBCUULI(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3915E20", Offset = "0x3914620", VA = "0x183915E20", Slot = "23")]
		public a JYWQRWNWSHR<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3915A70", Offset = "0x3914270", VA = "0x183915A70", Slot = "24")]
		public SetResult JXKABPNZCPV<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x86E20F0", Offset = "0x86E08F0", VA = "0x1886E20F0", Slot = "25")]
		public bool BPRYETEOTJZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x86E36E0", Offset = "0x86E1EE0", VA = "0x1886E36E0", Slot = "26")]
		public bool OGCIJRUSJZS(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x86E4A30", Offset = "0x86E3230", VA = "0x1886E4A30", Slot = "27")]
		public string ZNLQKLIHGQN(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x86E2D50", Offset = "0x86E1550", VA = "0x1886E2D50", Slot = "28")]
		public SetResult JBTVLPSVHSJ(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x86E1F50", Offset = "0x86E0750", VA = "0x1886E1F50", Slot = "29")]
		public int ARGUDJBHQWB(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x86E3540", Offset = "0x86E1D40", VA = "0x1886E3540", Slot = "30")]
		public SetResult NWSTDOCUVLH(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x86E3D60", Offset = "0x86E2560", VA = "0x1886E3D60", Slot = "31")]
		public bool RMYCILHZGWY(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x86E2E80", Offset = "0x86E1680", VA = "0x1886E2E80", Slot = "32")]
		public SetResult LNVQBNHEFDW(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x86E3330", Offset = "0x86E1B30", VA = "0x1886E3330", Slot = "33")]
		public float NFOKYLHFYCS(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x86E2740", Offset = "0x86E0F40", VA = "0x1886E2740", Slot = "34")]
		public SetResult HLFHPVFMITE(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x86E2770", Offset = "0x86E0F70", VA = "0x1886E2770", Slot = "35")]
		public DateTime HLIMSAJMZHH(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x86E21F0", Offset = "0x86E09F0", VA = "0x1886E21F0", Slot = "36")]
		public SetResult CKFHCQLZORD(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x86E2350", Offset = "0x86E0B50", VA = "0x1886E2350", Slot = "37")]
		public long DXCYXDGIBSC(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x86E2E00", Offset = "0x86E1600", VA = "0x1886E2E00", Slot = "38")]
		public SetResult KQPSBJWJYXI(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x86E4460", Offset = "0x86E2C60", VA = "0x1886E4460")]
		private bool UMNYJHYUGZH(FASRJDYTVDP a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x86E2800", Offset = "0x86E1000", VA = "0x1886E2800")]
		private bool HZXRBPMRGTC(FASRJDYTVDP a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x86E4670", Offset = "0x86E2E70", VA = "0x1886E4670")]
		private SetResult YETWWWMSIUM(FASRJDYTVDP a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x86E36F0", Offset = "0x86E1EF0", VA = "0x1886E36F0")]
		private SetResult PXLVALZVOMC(FASRJDYTVDP a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x86E2960", Offset = "0x86E1160", VA = "0x1886E2960")]
		private SetResult IABUEVXTSDD(FASRJDYTVDP a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x86E4AA0", Offset = "0x86E32A0", VA = "0x1886E4AA0")]
		private SetResult ZOXRUKDTLKR(FASRJDYTVDP a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x86E3570", Offset = "0x86E1D70", VA = "0x1886E3570")]
		private SetResult NWVAENATNQY(FASRJDYTVDP a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x86E2600", Offset = "0x86E0E00", VA = "0x1886E2600")]
		private SetResult GPYLBHFOHMT(FASRJDYTVDP a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x39168F0", Offset = "0x39150F0", VA = "0x1839168F0")]
		private e VCKDKCHDQCK<e>(FASRJDYTVDP a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3914F40", Offset = "0x3913740", VA = "0x183914F40")]
		private SetResult GJIMIHBGVEW<f>(FASRJDYTVDP a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3916460", Offset = "0x3914C60", VA = "0x183916460", Slot = "39")]
		public void SNHWZOTOVDL<g>(IWSXLDXORPN<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3916640", Offset = "0x3914E40", VA = "0x183916640", Slot = "40")]
		public void SPMTILNONNY<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x86E40E0", Offset = "0x86E28E0", VA = "0x1886E40E0")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(FASRJDYTVDP backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x86E47C0", Offset = "0x86E2FC0", VA = "0x1886E47C0", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task YFLEGQUPNFR([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x86E2AA0", Offset = "0x86E12A0", VA = "0x1886E2AA0")]
		private void IKVEYCOLZAV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x86E2C80", Offset = "0x86E1480", VA = "0x1886E2C80", Slot = "41")]
		public IDisposable IUWUWPKPIPR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x86E20E0", Offset = "0x86E08E0", VA = "0x1886E20E0", Slot = "42")]
		public void ATSCOXDEZDO(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x86E2F50", Offset = "0x86E1750", VA = "0x1886E2F50")]
		private void LVZFTKOXBSM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x86E2060", Offset = "0x86E0860", VA = "0x1886E2060")]
		[IteratorStateMachine(typeof(IHZPIHTXRNO))]
		private IEnumerator<ZCECIALXIMT> ATLNNJNEKLY(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x86E2150", Offset = "0x86E0950", VA = "0x1886E2150")]
		[CompilerGenerated]
		private void BYRMASSJSFL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class XRRFWBMBAYC
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x86EA840", Offset = "0x86E9040", VA = "0x1886EA840")]
		public static string GJPZQPXQQDL(this FSYMTSLYMQM a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x86EA9B0", Offset = "0x86E91B0", VA = "0x1886EA9B0")]
		public static byte[] HKVYACLTMMH(this FSYMTSLYMQM a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x86EA730", Offset = "0x86E8F30", VA = "0x1886EA730")]
		public static SetResult BAGUETVXHZF(this FSYMTSLYMQM a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class EZSBJGNPVZN : CNQKQSPMGJN<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static EZSBJGNPVZN QIBVUYLFYAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x86E06A0", Offset = "0x86DEEA0", VA = "0x1886E06A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x86E06F0", Offset = "0x86DEEF0", VA = "0x1886E06F0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x86E07E0", Offset = "0x86DEFE0", VA = "0x1886E07E0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x86E0AF0", Offset = "0x86DF2F0", VA = "0x1886E0AF0")]
		public EZSBJGNPVZN()
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
