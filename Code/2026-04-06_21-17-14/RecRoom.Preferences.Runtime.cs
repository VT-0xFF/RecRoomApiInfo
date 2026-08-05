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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD3C0", Offset = "0x9DAC3C0", VA = "0x189DAD3C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DAC630", Offset = "0x9DAB630", VA = "0x189DAC630", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DB7A60", Offset = "0x9DB6A60", VA = "0x189DB7A60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29F86A0", Offset = "0x29F76A0", VA = "0x1829F86A0")]
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
	internal static class ASVIXNIKBWW
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal delegate void CustomSaveHandler(YRQQFWHWLVM backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9DAAA30", Offset = "0x9DA9A30", VA = "0x189DAAA30")]
		private static void JZFVJJKGMUN(YRQQFWHWLVM a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB000", Offset = "0x9DAA000", VA = "0x189DAB000")]
		public static bool ZYBCZNHAPSD(this YRQQFWHWLVM a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9DAAAB0", Offset = "0x9DA9AB0", VA = "0x189DAAAB0")]
		public static SetResult MOCHHAQKWGS(this YRQQFWHWLVM a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9DAA7B0", Offset = "0x9DA97B0", VA = "0x189DAA7B0")]
		public static SetResult CSURVXVJGYG(this YRQQFWHWLVM a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9DAA8F0", Offset = "0x9DA98F0", VA = "0x189DAA8F0")]
		public static SetResult JSWYMUMFMTJ(this YRQQFWHWLVM a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9DAAC00", Offset = "0x9DA9C00", VA = "0x189DAAC00")]
		public static SetResult OTRGMTPUZER(this YRQQFWHWLVM a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9DAAD50", Offset = "0x9DA9D50", VA = "0x189DAAD50")]
		public static SetResult QDOSEUFUTLI(this YRQQFWHWLVM a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9DAAEC0", Offset = "0x9DA9EC0", VA = "0x189DAAEC0")]
		public static SetResult QIACERNBJVD(this YRQQFWHWLVM a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class WYMNUZDUKPJ : CHZJVSBKAMD, YRQQFWHWLVM
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log ZUUYQYDTAXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly WHJPYZJXFYC NSWIATDIEOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Dictionary<string, byte> QCDGMCUTITT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Dictionary<string, string> UOHMIHAKIZI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CCWOSPTXWCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> GPMTBHCUJDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9DB5640", Offset = "0x9DB4640", VA = "0x189DB5640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action QCWDWDVIDDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7830", Offset = "0x9DB6830", VA = "0x189DB7830")]
		[UnityEngine.Scripting.Preserve]
		public WYMNUZDUKPJ([Inject(null)] WHJPYZJXFYC unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "8")]
		public void HZYNIXROISA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6950", Offset = "0x9DB5950", VA = "0x189DB6950")]
		private DirectoryInfo ZKMVQFMPOIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5680", Offset = "0x9DB4680", VA = "0x189DB5680", Slot = "6")]
		public Task JVIBQCDEKJI(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB67E0", Offset = "0x9DB57E0", VA = "0x189DB67E0", Slot = "14")]
		public float WTAFFBTDVKI(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5410", Offset = "0x9DB4410", VA = "0x189DB5410", Slot = "13")]
		public void DOFRFRCAFFE(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6070", Offset = "0x9DB5070", VA = "0x189DB6070", Slot = "12")]
		public bool PEGZFEOFMHI(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5560", Offset = "0x9DB4560", VA = "0x189DB5560", Slot = "10")]
		public int HEGGQMNWZNN(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5480", Offset = "0x9DB4480", VA = "0x189DB5480", Slot = "18")]
		public DateTime EGFZCWMFETR(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB55D0", Offset = "0x9DB45D0", VA = "0x189DB55D0", Slot = "19")]
		public void HLQYNPWGCWP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5330", Offset = "0x9DB4330", VA = "0x189DB5330", Slot = "15")]
		public void AMLCUJNPODO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9DB68E0", Offset = "0x9DB58E0", VA = "0x189DB68E0", Slot = "11")]
		public void ZCJBKDYDSCD(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6140", Offset = "0x9DB5140", VA = "0x189DB6140", Slot = "20")]
		public long PQUJDWAAURK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9DB61B0", Offset = "0x9DB51B0", VA = "0x189DB61B0", Slot = "21")]
		public void PUSFPEICBWQ(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x40FD980", Offset = "0x40FC980", VA = "0x1840FD980", Slot = "22")]
		public a NSZUBCYFASN<a>(string a, a b, RHGAWVQGRXS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x40FF0E0", Offset = "0x40FE0E0", VA = "0x1840FF0E0", Slot = "23")]
		public void WZZIKMPROWZ<b>(string a, b b, RHGAWVQGRXS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6730", Offset = "0x9DB5730", VA = "0x189DB6730", Slot = "16")]
		public string VVQXIZVIFOD(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9DB53A0", Offset = "0x9DB43A0", VA = "0x189DB53A0", Slot = "17")]
		public void BVLMFJQGUDZ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6220", Offset = "0x9DB5220", VA = "0x189DB6220", Slot = "24")]
		public void QGHFLAWACUA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6850", Offset = "0x9DB5850", VA = "0x189DB6850", Slot = "9")]
		public bool XRKDRLLKDMR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6390", Offset = "0x9DB5390", VA = "0x189DB6390", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5810", Offset = "0x9DB4810", VA = "0x189DB5810")]
		private void KYDTTEYWDRO(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5E50", Offset = "0x9DB4E50", VA = "0x189DB5E50")]
		private static string LNHAAPWQBFD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5710", Offset = "0x9DB4710", VA = "0x189DB5710")]
		private static string KSKJZXIICBQ(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x40FC190", Offset = "0x40FB190", VA = "0x1840FC190")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] RHGAWVQGRXS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x40FDB60", Offset = "0x40FCB60", VA = "0x1840FDB60")]
		private void Set<T>(string propertyName, T value, [Optional] RHGAWVQGRXS<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6A40", Offset = "0x9DB5A40", VA = "0x189DB6A40")]
		private Dictionary<string, string> ZNGZTDPTZCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9DB66D0", Offset = "0x9DB56D0", VA = "0x189DB66D0")]
		private void VTBRWCXNQMU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9DB54F0", Offset = "0x9DB44F0", VA = "0x189DB54F0")]
		private void FUWEBZUCDZZ(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class SZDNWFYWUVJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log ZUUYQYDTAXG;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3A50", Offset = "0x9DB2A50", VA = "0x189DB3A50")]
		[GQJUYEPYYUG.Root]
		internal static void GQJUYEPYYUG(RZEIGZPHMMY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ZQKPVPXNDMU : PKUAZGLMJGF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9DADAA0", Offset = "0x9DACAA0", VA = "0x189DADAA0")]
		[UnityEngine.Scripting.Preserve]
		public ZQKPVPXNDMU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MXTYPWNBITA : CHZJVSBKAMD, YRQQFWHWLVM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly WHJPYZJXFYC NSWIATDIEOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Dictionary<string, string> WNKEFZZKDTG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool CCWOSPTXWCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action QCWDWDVIDDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9DACE90", Offset = "0x9DABE90", VA = "0x189DACE90")]
		[UnityEngine.Scripting.Preserve]
		public MXTYPWNBITA([Inject(null)] WHJPYZJXFYC unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC9D0", Offset = "0x9DAB9D0", VA = "0x189DAC9D0", Slot = "6")]
		public Task JVIBQCDEKJI(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "8")]
		public void HZYNIXROISA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9DACDC0", Offset = "0x9DABDC0", VA = "0x189DACDC0", Slot = "9")]
		public bool XRKDRLLKDMR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC8F0", Offset = "0x9DAB8F0", VA = "0x189DAC8F0", Slot = "10")]
		public int HEGGQMNWZNN(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9DACE20", Offset = "0x9DABE20", VA = "0x189DACE20", Slot = "11")]
		public void ZCJBKDYDSCD(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9DACA60", Offset = "0x9DABA60", VA = "0x189DACA60", Slot = "12")]
		public bool PEGZFEOFMHI(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC810", Offset = "0x9DAB810", VA = "0x189DAC810", Slot = "13")]
		public void DOFRFRCAFFE(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9DACD50", Offset = "0x9DABD50", VA = "0x189DACD50", Slot = "14")]
		public float WTAFFBTDVKI(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC730", Offset = "0x9DAB730", VA = "0x189DAC730", Slot = "15")]
		public void AMLCUJNPODO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9DACCD0", Offset = "0x9DABCD0", VA = "0x189DACCD0", Slot = "16")]
		public string VVQXIZVIFOD(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC7A0", Offset = "0x9DAB7A0", VA = "0x189DAC7A0", Slot = "17")]
		public void BVLMFJQGUDZ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC880", Offset = "0x9DAB880", VA = "0x189DAC880", Slot = "18")]
		public DateTime EGFZCWMFETR(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC960", Offset = "0x9DAB960", VA = "0x189DAC960", Slot = "19")]
		public void HLQYNPWGCWP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9DACAD0", Offset = "0x9DABAD0", VA = "0x189DACAD0", Slot = "20")]
		public long PQUJDWAAURK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9DACB40", Offset = "0x9DABB40", VA = "0x189DACB40", Slot = "21")]
		public void PUSFPEICBWQ(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CD60", Offset = "0x3C1BD60", VA = "0x183C1CD60", Slot = "22")]
		public a NSZUBCYFASN<a>(string a, a b, RHGAWVQGRXS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3C1E2D0", Offset = "0x3C1D2D0", VA = "0x183C1E2D0", Slot = "23")]
		public void WZZIKMPROWZ<b>(string a, b b, RHGAWVQGRXS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9DACBB0", Offset = "0x9DABBB0", VA = "0x189DACBB0", Slot = "24")]
		public void QGHFLAWACUA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9DACC40", Offset = "0x9DABC40", VA = "0x189DACC40", Slot = "25")]
		public Task Save([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B470", Offset = "0x3C1A470", VA = "0x183C1B470")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] RHGAWVQGRXS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CF40", Offset = "0x3C1BF40", VA = "0x183C1CF40")]
		private void Set<T>(string propertyName, T value, [Optional] RHGAWVQGRXS<T> parser)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PKUAZGLMJGF : CHZJVSBKAMD, YRQQFWHWLVM, JUOYRRODYVF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly Dictionary<string, object> CNVXGCUDKNN;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CCWOSPTXWCA
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action QCWDWDVIDDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "8")]
		public void HZYNIXROISA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD680", Offset = "0x9DAC680", VA = "0x189DAD680", Slot = "6")]
		public Task JVIBQCDEKJI(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD9E0", Offset = "0x9DAC9E0", VA = "0x189DAD9E0", Slot = "9")]
		public bool XRKDRLLKDMR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD5C0", Offset = "0x9DAC5C0", VA = "0x189DAD5C0", Slot = "10")]
		public int HEGGQMNWZNN(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9DADA40", Offset = "0x9DACA40", VA = "0x189DADA40", Slot = "11")]
		public void ZCJBKDYDSCD(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD710", Offset = "0x9DAC710", VA = "0x189DAD710", Slot = "12")]
		public bool PEGZFEOFMHI(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD500", Offset = "0x9DAC500", VA = "0x189DAD500", Slot = "13")]
		public void DOFRFRCAFFE(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD980", Offset = "0x9DAC980", VA = "0x189DAD980", Slot = "14")]
		public float WTAFFBTDVKI(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD440", Offset = "0x9DAC440", VA = "0x189DAD440", Slot = "15")]
		public void AMLCUJNPODO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD920", Offset = "0x9DAC920", VA = "0x189DAD920", Slot = "16")]
		public string VVQXIZVIFOD(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD4A0", Offset = "0x9DAC4A0", VA = "0x189DAD4A0", Slot = "17")]
		public void BVLMFJQGUDZ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD560", Offset = "0x9DAC560", VA = "0x189DAD560", Slot = "18")]
		public DateTime EGFZCWMFETR(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD620", Offset = "0x9DAC620", VA = "0x189DAD620", Slot = "19")]
		public void HLQYNPWGCWP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD770", Offset = "0x9DAC770", VA = "0x189DAD770", Slot = "20")]
		public long PQUJDWAAURK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD7D0", Offset = "0x9DAC7D0", VA = "0x189DAD7D0", Slot = "21")]
		public void PUSFPEICBWQ(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3D76AC0", Offset = "0x3D75AC0", VA = "0x183D76AC0", Slot = "22")]
		public a NSZUBCYFASN<a>(string a, a b, RHGAWVQGRXS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3D77510", Offset = "0x3D76510", VA = "0x183D77510", Slot = "23")]
		public void WZZIKMPROWZ<b>(string a, b b, RHGAWVQGRXS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3D75F10", Offset = "0x3D74F10", VA = "0x183D75F10")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3D76E80", Offset = "0x3D75E80", VA = "0x183D76E80")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD830", Offset = "0x9DAC830", VA = "0x189DAD830", Slot = "24")]
		public void QGHFLAWACUA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD890", Offset = "0x9DAC890", VA = "0x189DAD890", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9DADAA0", Offset = "0x9DACAA0", VA = "0x189DADAA0")]
		public PKUAZGLMJGF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class GDIRZHWOUAM<a> where a : YRQQFWHWLVM
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly HashSet<GDIRZHWOUAM<a>> XGTQYLWCIIN;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x63C4530", Offset = "0x63C3530", VA = "0x1863C4530")]
		protected GDIRZHWOUAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void DLNQZANOIAA(string a);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x63C38A0", Offset = "0x63C28A0", VA = "0x1863C38A0")]
		public static void MHXDAKKBHNQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x63C3D90", Offset = "0x63C2D90", VA = "0x1863C3D90")]
		public static void XIXXIHGSACG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class GDYMRCEGWIN<a, b> : GDIRZHWOUAM<a> where a : YRQQFWHWLVM
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly GDYMRCEGWIN<a, b> HPUTZVWRNHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Dictionary<string, b> VCTPXCEQDIS;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x63C5000", Offset = "0x63C4000", VA = "0x1863C5000")]
		public bool YBTJOCJEVNY(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x63C4DA0", Offset = "0x63C3DA0", VA = "0x1863C4DA0")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
		public IEnumerable<KeyValuePair<string, b>> RAFMUXGVDJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x63C4B80", Offset = "0x63C3B80", VA = "0x1863C4B80", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x63C4BE0", Offset = "0x63C3BE0", VA = "0x1863C4BE0", Slot = "5")]
		protected override void DLNQZANOIAA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x63C53E0", Offset = "0x63C43E0", VA = "0x1863C53E0")]
		public GDYMRCEGWIN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface YRQQFWHWLVM
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool CCWOSPTXWCA
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HZYNIXROISA();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool XRKDRLLKDMR(string a);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int HEGGQMNWZNN(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZCJBKDYDSCD(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool PEGZFEOFMHI(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DOFRFRCAFFE(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float WTAFFBTDVKI(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void AMLCUJNPODO(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string VVQXIZVIFOD(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void BVLMFJQGUDZ(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime EGFZCWMFETR(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void HLQYNPWGCWP(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long PQUJDWAAURK(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void PUSFPEICBWQ(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a NSZUBCYFASN<a>(string a, a b, RHGAWVQGRXS<a> c);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void WZZIKMPROWZ<b>(string a, b b, RHGAWVQGRXS<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void QGHFLAWACUA(string a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface CHZJVSBKAMD : YRQQFWHWLVM
	{
		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action QCWDWDVIDDQ;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task JVIBQCDEKJI(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface JUOYRRODYVF : YRQQFWHWLVM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class SMFVDIKJXDX : CHZJVSBKAMD, YRQQFWHWLVM
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
			public SMFVDIKJXDX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9DB4510", Offset = "0x9DB3510", VA = "0x189DB4510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9DB48D0", Offset = "0x9DB38D0", VA = "0x189DB48D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class AMLBALSIKRR : IEnumerator<BFNVKIYRTEQ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private BFNVKIYRTEQ NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public SMFVDIKJXDX NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private BFNVKIYRTEQ NHKNBMQLZLJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
			[DebuggerHidden]
			public AMLBALSIKRR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9DAA700", Offset = "0x9DA9700", VA = "0x189DAA700", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9DAA770", Offset = "0x9DA9770", VA = "0x189DAA770", Slot = "8")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly Log ZUUYQYDTAXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly WHJPYZJXFYC NSWIATDIEOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool UXBJMPTJEWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool NKAUHPHEVYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private WHWRQYRXEVA BYMFGYVPQBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TUMXXHBUICX SHXAKCQHPCB;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool CCWOSPTXWCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action QCWDWDVIDDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3950", Offset = "0x9DB2950", VA = "0x189DB3950")]
		[UnityEngine.Scripting.Preserve]
		public SMFVDIKJXDX([Inject(null)] WHJPYZJXFYC unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "8")]
		public void HZYNIXROISA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB14A0", Offset = "0x9DB04A0", VA = "0x189DB14A0", Slot = "6")]
		public Task JVIBQCDEKJI(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1E955D0", Offset = "0x1E945D0", VA = "0x181E955D0")]
		private static int YVUBIUISAVK(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3800", Offset = "0x9DB2800", VA = "0x189DB3800", Slot = "9")]
		public bool XRKDRLLKDMR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1300", Offset = "0x9DB0300", VA = "0x189DB1300", Slot = "10")]
		public int HEGGQMNWZNN(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3820", Offset = "0x9DB2820", VA = "0x189DB3820", Slot = "11")]
		public void ZCJBKDYDSCD(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1530", Offset = "0x9DB0530", VA = "0x189DB1530", Slot = "12")]
		public bool PEGZFEOFMHI(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0F70", Offset = "0x9DAFF70", VA = "0x189DB0F70", Slot = "13")]
		public void DOFRFRCAFFE(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3660", Offset = "0x9DB2660", VA = "0x189DB3660", Slot = "14")]
		public float WTAFFBTDVKI(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0D80", Offset = "0x9DAFD80", VA = "0x189DB0D80", Slot = "15")]
		public void AMLCUJNPODO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1050", Offset = "0x9DB0050", VA = "0x189DB1050", Slot = "18")]
		public DateTime EGFZCWMFETR(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1430", Offset = "0x9DB0430", VA = "0x189DB1430", Slot = "19")]
		public void HLQYNPWGCWP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1680", Offset = "0x9DB0680", VA = "0x189DB1680", Slot = "20")]
		public long PQUJDWAAURK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9DB16F0", Offset = "0x9DB06F0", VA = "0x189DB16F0", Slot = "21")]
		public void PUSFPEICBWQ(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3EF4340", Offset = "0x3EF3340", VA = "0x183EF4340", Slot = "22")]
		public a NSZUBCYFASN<a>(string a, a b, RHGAWVQGRXS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3EF5710", Offset = "0x3EF4710", VA = "0x183EF5710", Slot = "23")]
		public void WZZIKMPROWZ<b>(string a, b b, RHGAWVQGRXS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3EF4540", Offset = "0x3EF3540", VA = "0x183EF4540")]
		private c VQWGSVDUHXC<c>(string a, c b, [Optional] RHGAWVQGRXS<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3EF58D0", Offset = "0x3EF48D0", VA = "0x183EF58D0")]
		private void YSTOJRYCUYQ<d>(string a, d b, [Optional] RHGAWVQGRXS<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9DB34B0", Offset = "0x9DB24B0", VA = "0x189DB34B0", Slot = "16")]
		public string VVQXIZVIFOD(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0E40", Offset = "0x9DAFE40", VA = "0x189DB0E40", Slot = "17")]
		public void BVLMFJQGUDZ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9DB10C0", Offset = "0x9DB00C0", VA = "0x189DB10C0")]
		private void FEETXYPZCBE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1940", Offset = "0x9DB0940", VA = "0x189DB1940")]
		private string TEDLWSSQJYO(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1760", Offset = "0x9DB0760", VA = "0x189DB1760", Slot = "24")]
		public void QGHFLAWACUA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1260", Offset = "0x9DB0260", VA = "0x189DB1260")]
		private string GUFKWTFPAFS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1AF0", Offset = "0x9DB0AF0", VA = "0x189DB1AF0")]
		public void VBNFPYWXFFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0D20", Offset = "0x9DAFD20", VA = "0x189DB0D20", Slot = "26")]
		public void ALXQHUADTKY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1850", Offset = "0x9DB0850", VA = "0x189DB1850", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__40))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3790", Offset = "0x9DB2790", VA = "0x189DB3790")]
		[IteratorStateMachine(typeof(AMLBALSIKRR))]
		private IEnumerator<BFNVKIYRTEQ> XAGOCMISQUE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9DB17F0", Offset = "0x9DB07F0", VA = "0x189DB17F0")]
		private void QUWXKKCLLMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3440", Offset = "0x9DB2440", VA = "0x189DB3440")]
		private void VTBRWCXNQMU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9DB11F0", Offset = "0x9DB01F0", VA = "0x189DB11F0")]
		private void FUWEBZUCDZZ(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class DLLUZVQZNAB : CHZJVSBKAMD, YRQQFWHWLVM
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
		private Dictionary<string, string> UOHMIHAKIZI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool CCWOSPTXWCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string HGGJHTIYZTT
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x9DAB770", Offset = "0x9DAA770", VA = "0x189DAB770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private string BBIXMCPUIHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9DABE80", Offset = "0x9DAAE80", VA = "0x189DABE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Dictionary<string, string> GPMTBHCUJDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x9DAB8E0", Offset = "0x9DAA8E0", VA = "0x189DAB8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action QCWDWDVIDDQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		[UnityEngine.Scripting.Preserve]
		public DLLUZVQZNAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "8")]
		public void HZYNIXROISA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB920", Offset = "0x9DAA920", VA = "0x189DAB920", Slot = "6")]
		public Task JVIBQCDEKJI(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9DABFC0", Offset = "0x9DAAFC0", VA = "0x189DABFC0", Slot = "14")]
		public float WTAFFBTDVKI(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB690", Offset = "0x9DAA690", VA = "0x189DAB690", Slot = "13")]
		public void DOFRFRCAFFE(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB9B0", Offset = "0x9DAA9B0", VA = "0x189DAB9B0", Slot = "12")]
		public bool PEGZFEOFMHI(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB800", Offset = "0x9DAA800", VA = "0x189DAB800", Slot = "10")]
		public int HEGGQMNWZNN(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB700", Offset = "0x9DAA700", VA = "0x189DAB700", Slot = "18")]
		public DateTime EGFZCWMFETR(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB870", Offset = "0x9DAA870", VA = "0x189DAB870", Slot = "19")]
		public void HLQYNPWGCWP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB580", Offset = "0x9DAA580", VA = "0x189DAB580", Slot = "15")]
		public void AMLCUJNPODO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC0C0", Offset = "0x9DAB0C0", VA = "0x189DAC0C0", Slot = "11")]
		public void ZCJBKDYDSCD(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9DABA80", Offset = "0x9DAAA80", VA = "0x189DABA80", Slot = "20")]
		public long PQUJDWAAURK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9DABAF0", Offset = "0x9DAAAF0", VA = "0x189DABAF0", Slot = "21")]
		public void PUSFPEICBWQ(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x38F5780", Offset = "0x38F4780", VA = "0x1838F5780", Slot = "22")]
		public a NSZUBCYFASN<a>(string a, a b, RHGAWVQGRXS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x38F6C30", Offset = "0x38F5C30", VA = "0x1838F6C30", Slot = "23")]
		public void WZZIKMPROWZ<b>(string a, b b, RHGAWVQGRXS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9DABF10", Offset = "0x9DAAF10", VA = "0x189DABF10", Slot = "16")]
		public string VVQXIZVIFOD(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB5F0", Offset = "0x9DAA5F0", VA = "0x189DAB5F0", Slot = "17")]
		public void BVLMFJQGUDZ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9DABB60", Offset = "0x9DAAB60", VA = "0x189DABB60", Slot = "24")]
		public void QGHFLAWACUA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC030", Offset = "0x9DAB030", VA = "0x189DAC030", Slot = "9")]
		public bool XRKDRLLKDMR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9DABC20", Offset = "0x9DAAC20", VA = "0x189DABC20", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x38F3E70", Offset = "0x38F2E70", VA = "0x1838F3E70")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] RHGAWVQGRXS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x38F5960", Offset = "0x38F4960", VA = "0x1838F5960")]
		private void Set<T>(string propertyName, T value, [Optional] RHGAWVQGRXS<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC130", Offset = "0x9DAB130", VA = "0x189DAC130")]
		private Dictionary<string, string> ZNGZTDPTZCA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface BEJVLFDIYAN
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action QCWDWDVIDDQ;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HZYNIXROISA();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task CUVZMCKSDVQ(long a);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool UBLMOZBBBCC(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool RGCIZDJUQAI(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool LNCVZMXMAYX(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string NSLXLRHWCDS(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult BYPEFORNSNS(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int TMEXRUKCKAW(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult ANUMOQRNPFE(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool NDXCOMGJKCJ(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult KVBZHENZSDL(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float HPCERYMIIYF(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult NVVNTIFSLYV(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime ESSQAZBBZVC(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult EEKFYARCXQI(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long DIFVDQIBNNV(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult IRFRPPSVRSH(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a NVASXCTFLTM<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult AULJGHOOAOW<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool HDSKNMVYXZA(string a);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool CZJTNSALVOP(string a);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string XARPBQJNCFE(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult HMOFNXMMVEG(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int HJSOWZYBPNW(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult ZXEPAUOCCZW(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool DBQYESBVVQL(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult QNFGVAMOHPR(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float JLJQSAULSYX(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult NRDIKQZCQWX(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime VGQCHVKQFVQ(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult ITJRRPTWJMO(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long TZAJFUZLKWR(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult HSAOYFQCBIN(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void CAMXATSWCXO<e>(RHGAWVQGRXS<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void CNETBUNRMPN<f>();

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable UEHONEAIUIE();

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void CKZEDKCRBST(float a);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task QUWXKKCLLMA([Optional] CancellationToken a);
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
	public class Preferences : BEJVLFDIYAN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private abstract class GOPPZUDEJZF
		{
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			protected static readonly HashSet<GOPPZUDEJZF> IRMLOPGGHUK;

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9DAC460", Offset = "0x9DAB460", VA = "0x189DAC460")]
			public static void XIXXIHGSACG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			protected GOPPZUDEJZF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private class SDNQFVGEJIE<a> : GOPPZUDEJZF
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly SDNQFVGEJIE<a> CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public RHGAWVQGRXS<a> VYAQUCBGFCR
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public IEqualityComparer<a> BEKKJMPNITL
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool ULYQUYLHWNI
			{
				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xE9D0C0", Offset = "0xE9C0C0", VA = "0x180E9D0C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x7AB70E0", Offset = "0x7AB60E0", VA = "0x187AB70E0")]
			private SDNQFVGEJIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x7AB6840", Offset = "0x7AB5840", VA = "0x187AB6840")]
			public void OTSRDIPIITJ(RHGAWVQGRXS<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x10360F0", Offset = "0x10350F0", VA = "0x1810360F0", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private class YTQIKKTCRTV : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private readonly Preferences SMGIDVRRFXS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private readonly object EXAHVYSHSUK;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9DB79B0", Offset = "0x9DB69B0", VA = "0x189DB79B0")]
			public YTQIKKTCRTV(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9DB7980", Offset = "0x9DB6980", VA = "0x189DB7980", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DB3C90", Offset = "0x9DB2C90", VA = "0x189DB3C90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x9DB3F80", Offset = "0x9DB2F80", VA = "0x189DB3F80", Slot = "5")]
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
			public YRQQFWHWLVM backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x9DB4930", Offset = "0x9DB3930", VA = "0x189DB4930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DB3FE0", Offset = "0x9DB2FE0", VA = "0x189DB3FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x9DB44B0", Offset = "0x9DB34B0", VA = "0x189DB44B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class PVDEUNZGUMB : IEnumerator<BFNVKIYRTEQ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private BFNVKIYRTEQ NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Preferences NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float IMGEXGNXRWD;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private BFNVKIYRTEQ NHKNBMQLZLJ
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
			[DebuggerHidden]
			public PVDEUNZGUMB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x9DADB20", Offset = "0x9DACB20", VA = "0x189DADB20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9DADBB0", Offset = "0x9DACBB0", VA = "0x189DADBB0", Slot = "8")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly CHZJVSBKAMD OUEHHLSWARV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly CHZJVSBKAMD JQGKTTAENAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly JUOYRRODYVF BOJCQIABXGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly WHWRQYRXEVA BYMFGYVPQBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly ASVIXNIKBWW.CustomSaveHandler FUUMWKZHZJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly XIHSQHDZBEQ CQECWVGFJVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly HashSet<YRQQFWHWLVM> SYHRUKCITMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Task XNCQOMBCYNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<string, string> XXEKXGOOIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TUMXXHBUICX KSWDRGJJIYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly object PCJMUPKQTIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly object ZARJLLBPAPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long IOIGHECLSXG;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool LDBLFUJYRQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x1A70640", Offset = "0x1A6F640", VA = "0x181A70640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private CancellationTokenSource RXYAQTOWDKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BD0", Offset = "0xCF6BD0", VA = "0x180CF7BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BC0", Offset = "0xCF6BC0", VA = "0x180CF7BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action QCWDWDVIDDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9DB04A0", Offset = "0x9DAF4A0", VA = "0x189DB04A0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9DADEA0", Offset = "0x9DACEA0", VA = "0x189DADEA0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE740", Offset = "0x9DAD740", VA = "0x189DAE740")]
		[GQJUYEPYYUG.Root]
		internal static void EHOWKEZCPLX(RZEIGZPHMMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0990", Offset = "0x9DAF990", VA = "0x189DB0990")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] CHZJVSBKAMD localBackingStore, [Inject("Cloud")] CHZJVSBKAMD cloudBackingStore, [Inject(null)] JUOYRRODYVF editorBackingStore, [Inject(null)] WHWRQYRXEVA scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE560", Offset = "0x9DAD560", VA = "0x189DAE560", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF990", Offset = "0x9DAE990", VA = "0x189DAF990")]
		private void QNXCZYQBBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEA30", Offset = "0x9DADA30", VA = "0x189DAEA30", Slot = "6")]
		public void HZYNIXROISA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE130", Offset = "0x9DAD130", VA = "0x189DAE130", Slot = "7")]
		public Task CUVZMCKSDVQ(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF850", Offset = "0x9DAE850", VA = "0x189DAF850")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task QMAKALDVZDN(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF830", Offset = "0x9DAE830", VA = "0x189DAF830")]
		private void PZFVIYDJGXY(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEAA0", Offset = "0x9DADAA0", VA = "0x189DAEAA0")]
		private void IKKDMZYJSDV(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE0D0", Offset = "0x9DAD0D0", VA = "0x189DAE0D0")]
		private string CUGAOFQMUUC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9DAFDB0", Offset = "0x9DAEDB0", VA = "0x189DAFDB0")]
		private void TEFXQRVTQCE(AccountPreferenceBackingStoreTypes a, string b, [Out] CHZJVSBKAMD c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9DB03B0", Offset = "0x9DAF3B0", VA = "0x189DB03B0")]
		private CHZJVSBKAMD URKBNKRWDWI(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0070", Offset = "0x9DAF070", VA = "0x189DB0070", Slot = "8")]
		public bool UBLMOZBBBCC(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9DAFAD0", Offset = "0x9DAEAD0", VA = "0x189DAFAD0", Slot = "9")]
		public bool RGCIZDJUQAI(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF010", Offset = "0x9DAE010", VA = "0x189DAF010", Slot = "10")]
		public bool LNCVZMXMAYX(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF3B0", Offset = "0x9DAE3B0", VA = "0x189DAF3B0", Slot = "11")]
		public string NSLXLRHWCDS(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9DADF40", Offset = "0x9DACF40", VA = "0x189DADF40", Slot = "12")]
		public SetResult BYPEFORNSNS(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9DAFF50", Offset = "0x9DAEF50", VA = "0x189DAFF50", Slot = "13")]
		public int TMEXRUKCKAW(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9DADD30", Offset = "0x9DACD30", VA = "0x189DADD30", Slot = "14")]
		public SetResult ANUMOQRNPFE(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF190", Offset = "0x9DAE190", VA = "0x189DAF190", Slot = "15")]
		public bool NDXCOMGJKCJ(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9DAED60", Offset = "0x9DADD60", VA = "0x189DAED60", Slot = "16")]
		public SetResult KVBZHENZSDL(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE950", Offset = "0x9DAD950", VA = "0x189DAE950", Slot = "17")]
		public float HPCERYMIIYF(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF450", Offset = "0x9DAE450", VA = "0x189DAF450", Slot = "18")]
		public SetResult NVVNTIFSLYV(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE7B0", Offset = "0x9DAD7B0", VA = "0x189DAE7B0", Slot = "19")]
		public DateTime ESSQAZBBZVC(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE5A0", Offset = "0x9DAD5A0", VA = "0x189DAE5A0", Slot = "20")]
		public SetResult EEKFYARCXQI(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE380", Offset = "0x9DAD380", VA = "0x189DAE380", Slot = "21")]
		public long DIFVDQIBNNV(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEB50", Offset = "0x9DADB50", VA = "0x189DAEB50", Slot = "22")]
		public SetResult IRFRPPSVRSH(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3D98020", Offset = "0x3D97020", VA = "0x183D98020", Slot = "23")]
		public a NVASXCTFLTM<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3D96370", Offset = "0x3D95370", VA = "0x183D96370", Slot = "24")]
		public SetResult AULJGHOOAOW<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE850", Offset = "0x9DAD850", VA = "0x189DAE850", Slot = "25")]
		public bool HDSKNMVYXZA(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE300", Offset = "0x9DAD300", VA = "0x189DAE300", Slot = "26")]
		public bool CZJTNSALVOP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0540", Offset = "0x9DAF540", VA = "0x189DB0540", Slot = "27")]
		public string XARPBQJNCFE(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE920", Offset = "0x9DAD920", VA = "0x189DAE920", Slot = "28")]
		public SetResult HMOFNXMMVEG(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE8B0", Offset = "0x9DAD8B0", VA = "0x189DAE8B0", Slot = "29")]
		public int HJSOWZYBPNW(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0960", Offset = "0x9DAF960", VA = "0x189DB0960", Slot = "30")]
		public SetResult ZXEPAUOCCZW(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE310", Offset = "0x9DAD310", VA = "0x189DAE310", Slot = "31")]
		public bool DBQYESBVVQL(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF960", Offset = "0x9DAE960", VA = "0x189DAF960", Slot = "32")]
		public SetResult QNFGVAMOHPR(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9DAECF0", Offset = "0x9DADCF0", VA = "0x189DAECF0", Slot = "33")]
		public float JLJQSAULSYX(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF380", Offset = "0x9DAE380", VA = "0x189DAF380", Slot = "34")]
		public SetResult NRDIKQZCQWX(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0430", Offset = "0x9DAF430", VA = "0x189DB0430", Slot = "35")]
		public DateTime VGQCHVKQFVQ(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9DAECC0", Offset = "0x9DADCC0", VA = "0x189DAECC0", Slot = "36")]
		public SetResult ITJRRPTWJMO(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0000", Offset = "0x9DAF000", VA = "0x189DB0000", Slot = "37")]
		public long TZAJFUZLKWR(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEA00", Offset = "0x9DADA00", VA = "0x189DAEA00", Slot = "38")]
		public SetResult HSAOYFQCBIN(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9DB01F0", Offset = "0x9DAF1F0", VA = "0x189DB01F0")]
		private bool UEZUZOHZPYC(YRQQFWHWLVM a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0250", Offset = "0x9DAF250", VA = "0x189DB0250")]
		private bool UIJGSKRQMUJ(YRQQFWHWLVM a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9DB05B0", Offset = "0x9DAF5B0", VA = "0x189DB05B0")]
		private SetResult XIVOPRJOSXZ(YRQQFWHWLVM a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEED0", Offset = "0x9DADED0", VA = "0x189DAEED0")]
		private SetResult LDEFYWMXYUH(YRQQFWHWLVM a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF240", Offset = "0x9DAE240", VA = "0x189DAF240")]
		private SetResult NKOIUZYZGHE(YRQQFWHWLVM a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9DADBF0", Offset = "0x9DACBF0", VA = "0x189DADBF0")]
		private SetResult AJBINUVFLUQ(YRQQFWHWLVM a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9DAFB70", Offset = "0x9DAEB70", VA = "0x189DAFB70")]
		private SetResult RUQZFMJBNMX(YRQQFWHWLVM a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE420", Offset = "0x9DAD420", VA = "0x189DAE420")]
		private SetResult DTGBCTJVKWM(YRQQFWHWLVM a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3D97A00", Offset = "0x3D96A00", VA = "0x183D97A00")]
		private e LTKMEFUMXCR<e>(YRQQFWHWLVM a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3D96E20", Offset = "0x3D95E20", VA = "0x183D96E20")]
		private SetResult IWZOCHAFVBP<f>(YRQQFWHWLVM a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3D96640", Offset = "0x3D95640", VA = "0x183D96640", Slot = "39")]
		public void CAMXATSWCXO<g>(RHGAWVQGRXS<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3D96850", Offset = "0x3D95850", VA = "0x183D96850", Slot = "40")]
		public void CNETBUNRMPN<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9DAFCE0", Offset = "0x9DAECE0", VA = "0x189DAFCE0")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(YRQQFWHWLVM backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF9E0", Offset = "0x9DAE9E0", VA = "0x189DAF9E0", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task QUWXKKCLLMA([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0700", Offset = "0x9DAF700", VA = "0x189DB0700")]
		private void XJSDZTMTKIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0120", Offset = "0x9DAF120", VA = "0x189DB0120", Slot = "41")]
		public IDisposable UEHONEAIUIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE0C0", Offset = "0x9DAD0C0", VA = "0x189DAE0C0", Slot = "42")]
		public void CKZEDKCRBST(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF5D0", Offset = "0x9DAE5D0", VA = "0x189DAF5D0")]
		private void PJJQOCYBMWH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9DB08E0", Offset = "0x9DAF8E0", VA = "0x189DB08E0")]
		[IteratorStateMachine(typeof(PVDEUNZGUMB))]
		private IEnumerator<BFNVKIYRTEQ> XXESNLPSYWV(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEB20", Offset = "0x9DADB20", VA = "0x189DAEB20")]
		[CompilerGenerated]
		private void IPDUPWACZFM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class CUXJATGQMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB160", Offset = "0x9DAA160", VA = "0x189DAB160")]
		public static string BACHNAKIYCA(this BEJVLFDIYAN a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB3E0", Offset = "0x9DAA3E0", VA = "0x189DAB3E0")]
		public static byte[] REGJTNHOBKA(this BEJVLFDIYAN a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB2D0", Offset = "0x9DAA2D0", VA = "0x189DAB2D0")]
		public static SetResult NNQBNYNRXXW(this BEJVLFDIYAN a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class NXJUHIFVVMG : JAIVNHEPHYK<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static NXJUHIFVVMG CIARLSLMHCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x9DAD020", Offset = "0x9DAC020", VA = "0x189DAD020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9DACF30", Offset = "0x9DABF30", VA = "0x189DACF30", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD070", Offset = "0x9DAC070", VA = "0x189DAD070", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD380", Offset = "0x9DAC380", VA = "0x189DAD380")]
		public NXJUHIFVVMG()
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
