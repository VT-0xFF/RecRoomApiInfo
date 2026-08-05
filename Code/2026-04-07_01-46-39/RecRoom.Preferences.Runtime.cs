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
		[Cpp2IlInjected.Address(RVA = "0x9DAD360", Offset = "0x9DAC360", VA = "0x189DAD360")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DAC5D0", Offset = "0x9DAB5D0", VA = "0x189DAC5D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DB7A00", Offset = "0x9DB6A00", VA = "0x189DB7A00", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DAA9D0", Offset = "0x9DA99D0", VA = "0x189DAA9D0")]
		private static void JZFVJJKGMUN(YRQQFWHWLVM a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9DAAFA0", Offset = "0x9DA9FA0", VA = "0x189DAAFA0")]
		public static bool ZYBCZNHAPSD(this YRQQFWHWLVM a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9DAAA50", Offset = "0x9DA9A50", VA = "0x189DAAA50")]
		public static SetResult MOCHHAQKWGS(this YRQQFWHWLVM a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9DAA750", Offset = "0x9DA9750", VA = "0x189DAA750")]
		public static SetResult CSURVXVJGYG(this YRQQFWHWLVM a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9DAA890", Offset = "0x9DA9890", VA = "0x189DAA890")]
		public static SetResult JSWYMUMFMTJ(this YRQQFWHWLVM a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9DAABA0", Offset = "0x9DA9BA0", VA = "0x189DAABA0")]
		public static SetResult OTRGMTPUZER(this YRQQFWHWLVM a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9DAACF0", Offset = "0x9DA9CF0", VA = "0x189DAACF0")]
		public static SetResult QDOSEUFUTLI(this YRQQFWHWLVM a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9DAAE60", Offset = "0x9DA9E60", VA = "0x189DAAE60")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DB55E0", Offset = "0x9DB45E0", VA = "0x189DB55E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DB77D0", Offset = "0x9DB67D0", VA = "0x189DB77D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DB68F0", Offset = "0x9DB58F0", VA = "0x189DB68F0")]
		private DirectoryInfo ZKMVQFMPOIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5620", Offset = "0x9DB4620", VA = "0x189DB5620", Slot = "6")]
		public Task JVIBQCDEKJI(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6780", Offset = "0x9DB5780", VA = "0x189DB6780", Slot = "14")]
		public float WTAFFBTDVKI(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB53B0", Offset = "0x9DB43B0", VA = "0x189DB53B0", Slot = "13")]
		public void DOFRFRCAFFE(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6010", Offset = "0x9DB5010", VA = "0x189DB6010", Slot = "12")]
		public bool PEGZFEOFMHI(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5500", Offset = "0x9DB4500", VA = "0x189DB5500", Slot = "10")]
		public int HEGGQMNWZNN(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5420", Offset = "0x9DB4420", VA = "0x189DB5420", Slot = "18")]
		public DateTime EGFZCWMFETR(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5570", Offset = "0x9DB4570", VA = "0x189DB5570", Slot = "19")]
		public void HLQYNPWGCWP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9DB52D0", Offset = "0x9DB42D0", VA = "0x189DB52D0", Slot = "15")]
		public void AMLCUJNPODO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6880", Offset = "0x9DB5880", VA = "0x189DB6880", Slot = "11")]
		public void ZCJBKDYDSCD(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9DB60E0", Offset = "0x9DB50E0", VA = "0x189DB60E0", Slot = "20")]
		public long PQUJDWAAURK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6150", Offset = "0x9DB5150", VA = "0x189DB6150", Slot = "21")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DB66D0", Offset = "0x9DB56D0", VA = "0x189DB66D0", Slot = "16")]
		public string VVQXIZVIFOD(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5340", Offset = "0x9DB4340", VA = "0x189DB5340", Slot = "17")]
		public void BVLMFJQGUDZ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9DB61C0", Offset = "0x9DB51C0", VA = "0x189DB61C0", Slot = "24")]
		public void QGHFLAWACUA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9DB67F0", Offset = "0x9DB57F0", VA = "0x189DB67F0", Slot = "9")]
		public bool XRKDRLLKDMR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6330", Offset = "0x9DB5330", VA = "0x189DB6330", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB57B0", Offset = "0x9DB47B0", VA = "0x189DB57B0")]
		private void KYDTTEYWDRO(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5DF0", Offset = "0x9DB4DF0", VA = "0x189DB5DF0")]
		private static string LNHAAPWQBFD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9DB56B0", Offset = "0x9DB46B0", VA = "0x189DB56B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DB69E0", Offset = "0x9DB59E0", VA = "0x189DB69E0")]
		private Dictionary<string, string> ZNGZTDPTZCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6670", Offset = "0x9DB5670", VA = "0x189DB6670")]
		private void VTBRWCXNQMU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5490", Offset = "0x9DB4490", VA = "0x189DB5490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DB39F0", Offset = "0x9DB29F0", VA = "0x189DB39F0")]
		[GQJUYEPYYUG.Root]
		internal static void GQJUYEPYYUG(RZEIGZPHMMY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ZQKPVPXNDMU : PKUAZGLMJGF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9DADA40", Offset = "0x9DACA40", VA = "0x189DADA40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DACE30", Offset = "0x9DABE30", VA = "0x189DACE30")]
		[UnityEngine.Scripting.Preserve]
		public MXTYPWNBITA([Inject(null)] WHJPYZJXFYC unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC970", Offset = "0x9DAB970", VA = "0x189DAC970", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DACD60", Offset = "0x9DABD60", VA = "0x189DACD60", Slot = "9")]
		public bool XRKDRLLKDMR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC890", Offset = "0x9DAB890", VA = "0x189DAC890", Slot = "10")]
		public int HEGGQMNWZNN(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9DACDC0", Offset = "0x9DABDC0", VA = "0x189DACDC0", Slot = "11")]
		public void ZCJBKDYDSCD(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9DACA00", Offset = "0x9DABA00", VA = "0x189DACA00", Slot = "12")]
		public bool PEGZFEOFMHI(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC7B0", Offset = "0x9DAB7B0", VA = "0x189DAC7B0", Slot = "13")]
		public void DOFRFRCAFFE(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9DACCF0", Offset = "0x9DABCF0", VA = "0x189DACCF0", Slot = "14")]
		public float WTAFFBTDVKI(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC6D0", Offset = "0x9DAB6D0", VA = "0x189DAC6D0", Slot = "15")]
		public void AMLCUJNPODO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9DACC70", Offset = "0x9DABC70", VA = "0x189DACC70", Slot = "16")]
		public string VVQXIZVIFOD(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC740", Offset = "0x9DAB740", VA = "0x189DAC740", Slot = "17")]
		public void BVLMFJQGUDZ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC820", Offset = "0x9DAB820", VA = "0x189DAC820", Slot = "18")]
		public DateTime EGFZCWMFETR(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC900", Offset = "0x9DAB900", VA = "0x189DAC900", Slot = "19")]
		public void HLQYNPWGCWP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9DACA70", Offset = "0x9DABA70", VA = "0x189DACA70", Slot = "20")]
		public long PQUJDWAAURK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9DACAE0", Offset = "0x9DABAE0", VA = "0x189DACAE0", Slot = "21")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DACB50", Offset = "0x9DABB50", VA = "0x189DACB50", Slot = "24")]
		public void QGHFLAWACUA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9DACBE0", Offset = "0x9DABBE0", VA = "0x189DACBE0", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DAD620", Offset = "0x9DAC620", VA = "0x189DAD620", Slot = "6")]
		public Task JVIBQCDEKJI(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD980", Offset = "0x9DAC980", VA = "0x189DAD980", Slot = "9")]
		public bool XRKDRLLKDMR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD560", Offset = "0x9DAC560", VA = "0x189DAD560", Slot = "10")]
		public int HEGGQMNWZNN(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD9E0", Offset = "0x9DAC9E0", VA = "0x189DAD9E0", Slot = "11")]
		public void ZCJBKDYDSCD(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD6B0", Offset = "0x9DAC6B0", VA = "0x189DAD6B0", Slot = "12")]
		public bool PEGZFEOFMHI(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD4A0", Offset = "0x9DAC4A0", VA = "0x189DAD4A0", Slot = "13")]
		public void DOFRFRCAFFE(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD920", Offset = "0x9DAC920", VA = "0x189DAD920", Slot = "14")]
		public float WTAFFBTDVKI(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD3E0", Offset = "0x9DAC3E0", VA = "0x189DAD3E0", Slot = "15")]
		public void AMLCUJNPODO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD8C0", Offset = "0x9DAC8C0", VA = "0x189DAD8C0", Slot = "16")]
		public string VVQXIZVIFOD(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD440", Offset = "0x9DAC440", VA = "0x189DAD440", Slot = "17")]
		public void BVLMFJQGUDZ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD500", Offset = "0x9DAC500", VA = "0x189DAD500", Slot = "18")]
		public DateTime EGFZCWMFETR(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD5C0", Offset = "0x9DAC5C0", VA = "0x189DAD5C0", Slot = "19")]
		public void HLQYNPWGCWP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD710", Offset = "0x9DAC710", VA = "0x189DAD710", Slot = "20")]
		public long PQUJDWAAURK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD770", Offset = "0x9DAC770", VA = "0x189DAD770", Slot = "21")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DAD7D0", Offset = "0x9DAC7D0", VA = "0x189DAD7D0", Slot = "24")]
		public void QGHFLAWACUA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD830", Offset = "0x9DAC830", VA = "0x189DAD830", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9DADA40", Offset = "0x9DACA40", VA = "0x189DADA40")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DB44B0", Offset = "0x9DB34B0", VA = "0x189DB44B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9DB4870", Offset = "0x9DB3870", VA = "0x189DB4870", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DAA6A0", Offset = "0x9DA96A0", VA = "0x189DAA6A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9DAA710", Offset = "0x9DA9710", VA = "0x189DAA710", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DB38F0", Offset = "0x9DB28F0", VA = "0x189DB38F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DB1440", Offset = "0x9DB0440", VA = "0x189DB1440", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DB37A0", Offset = "0x9DB27A0", VA = "0x189DB37A0", Slot = "9")]
		public bool XRKDRLLKDMR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9DB12A0", Offset = "0x9DB02A0", VA = "0x189DB12A0", Slot = "10")]
		public int HEGGQMNWZNN(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9DB37C0", Offset = "0x9DB27C0", VA = "0x189DB37C0", Slot = "11")]
		public void ZCJBKDYDSCD(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB14D0", Offset = "0x9DB04D0", VA = "0x189DB14D0", Slot = "12")]
		public bool PEGZFEOFMHI(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0F10", Offset = "0x9DAFF10", VA = "0x189DB0F10", Slot = "13")]
		public void DOFRFRCAFFE(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3600", Offset = "0x9DB2600", VA = "0x189DB3600", Slot = "14")]
		public float WTAFFBTDVKI(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0D20", Offset = "0x9DAFD20", VA = "0x189DB0D20", Slot = "15")]
		public void AMLCUJNPODO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0FF0", Offset = "0x9DAFFF0", VA = "0x189DB0FF0", Slot = "18")]
		public DateTime EGFZCWMFETR(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9DB13D0", Offset = "0x9DB03D0", VA = "0x189DB13D0", Slot = "19")]
		public void HLQYNPWGCWP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1620", Offset = "0x9DB0620", VA = "0x189DB1620", Slot = "20")]
		public long PQUJDWAAURK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1690", Offset = "0x9DB0690", VA = "0x189DB1690", Slot = "21")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DB3450", Offset = "0x9DB2450", VA = "0x189DB3450", Slot = "16")]
		public string VVQXIZVIFOD(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0DE0", Offset = "0x9DAFDE0", VA = "0x189DB0DE0", Slot = "17")]
		public void BVLMFJQGUDZ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1060", Offset = "0x9DB0060", VA = "0x189DB1060")]
		private void FEETXYPZCBE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9DB18E0", Offset = "0x9DB08E0", VA = "0x189DB18E0")]
		private string TEDLWSSQJYO(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1700", Offset = "0x9DB0700", VA = "0x189DB1700", Slot = "24")]
		public void QGHFLAWACUA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1200", Offset = "0x9DB0200", VA = "0x189DB1200")]
		private string GUFKWTFPAFS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1A90", Offset = "0x9DB0A90", VA = "0x189DB1A90")]
		public void VBNFPYWXFFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0CC0", Offset = "0x9DAFCC0", VA = "0x189DB0CC0", Slot = "26")]
		public void ALXQHUADTKY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9DB17F0", Offset = "0x9DB07F0", VA = "0x189DB17F0", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__40))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3730", Offset = "0x9DB2730", VA = "0x189DB3730")]
		[IteratorStateMachine(typeof(AMLBALSIKRR))]
		private IEnumerator<BFNVKIYRTEQ> XAGOCMISQUE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1790", Offset = "0x9DB0790", VA = "0x189DB1790")]
		private void QUWXKKCLLMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9DB33E0", Offset = "0x9DB23E0", VA = "0x189DB33E0")]
		private void VTBRWCXNQMU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1190", Offset = "0x9DB0190", VA = "0x189DB1190")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DAB710", Offset = "0x9DAA710", VA = "0x189DAB710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private string BBIXMCPUIHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9DABE20", Offset = "0x9DAAE20", VA = "0x189DABE20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Dictionary<string, string> GPMTBHCUJDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x9DAB880", Offset = "0x9DAA880", VA = "0x189DAB880")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DAB8C0", Offset = "0x9DAA8C0", VA = "0x189DAB8C0", Slot = "6")]
		public Task JVIBQCDEKJI(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9DABF60", Offset = "0x9DAAF60", VA = "0x189DABF60", Slot = "14")]
		public float WTAFFBTDVKI(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB630", Offset = "0x9DAA630", VA = "0x189DAB630", Slot = "13")]
		public void DOFRFRCAFFE(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB950", Offset = "0x9DAA950", VA = "0x189DAB950", Slot = "12")]
		public bool PEGZFEOFMHI(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB7A0", Offset = "0x9DAA7A0", VA = "0x189DAB7A0", Slot = "10")]
		public int HEGGQMNWZNN(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB6A0", Offset = "0x9DAA6A0", VA = "0x189DAB6A0", Slot = "18")]
		public DateTime EGFZCWMFETR(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB810", Offset = "0x9DAA810", VA = "0x189DAB810", Slot = "19")]
		public void HLQYNPWGCWP(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB520", Offset = "0x9DAA520", VA = "0x189DAB520", Slot = "15")]
		public void AMLCUJNPODO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9DAC060", Offset = "0x9DAB060", VA = "0x189DAC060", Slot = "11")]
		public void ZCJBKDYDSCD(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9DABA20", Offset = "0x9DAAA20", VA = "0x189DABA20", Slot = "20")]
		public long PQUJDWAAURK(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9DABA90", Offset = "0x9DAAA90", VA = "0x189DABA90", Slot = "21")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DABEB0", Offset = "0x9DAAEB0", VA = "0x189DABEB0", Slot = "16")]
		public string VVQXIZVIFOD(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB590", Offset = "0x9DAA590", VA = "0x189DAB590", Slot = "17")]
		public void BVLMFJQGUDZ(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9DABB00", Offset = "0x9DAAB00", VA = "0x189DABB00", Slot = "24")]
		public void QGHFLAWACUA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9DABFD0", Offset = "0x9DAAFD0", VA = "0x189DABFD0", Slot = "9")]
		public bool XRKDRLLKDMR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9DABBC0", Offset = "0x9DAABC0", VA = "0x189DABBC0", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DAC0D0", Offset = "0x9DAB0D0", VA = "0x189DAC0D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DAC400", Offset = "0x9DAB400", VA = "0x189DAC400")]
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
			[Cpp2IlInjected.Address(RVA = "0x7AB7080", Offset = "0x7AB6080", VA = "0x187AB7080")]
			private SDNQFVGEJIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x7AB67E0", Offset = "0x7AB57E0", VA = "0x187AB67E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DB7950", Offset = "0x9DB6950", VA = "0x189DB7950")]
			public YTQIKKTCRTV(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9DB7920", Offset = "0x9DB6920", VA = "0x189DB7920", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DB3C30", Offset = "0x9DB2C30", VA = "0x189DB3C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x9DB3F20", Offset = "0x9DB2F20", VA = "0x189DB3F20", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DB48D0", Offset = "0x9DB38D0", VA = "0x189DB48D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DB3F80", Offset = "0x9DB2F80", VA = "0x189DB3F80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x9DB4450", Offset = "0x9DB3450", VA = "0x189DB4450", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DADAC0", Offset = "0x9DACAC0", VA = "0x189DADAC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9DADB50", Offset = "0x9DACB50", VA = "0x189DADB50", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DB0440", Offset = "0x9DAF440", VA = "0x189DB0440", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9DADE40", Offset = "0x9DACE40", VA = "0x189DADE40", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE6E0", Offset = "0x9DAD6E0", VA = "0x189DAE6E0")]
		[GQJUYEPYYUG.Root]
		internal static void EHOWKEZCPLX(RZEIGZPHMMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0930", Offset = "0x9DAF930", VA = "0x189DB0930")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] CHZJVSBKAMD localBackingStore, [Inject("Cloud")] CHZJVSBKAMD cloudBackingStore, [Inject(null)] JUOYRRODYVF editorBackingStore, [Inject(null)] WHWRQYRXEVA scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE500", Offset = "0x9DAD500", VA = "0x189DAE500", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF930", Offset = "0x9DAE930", VA = "0x189DAF930")]
		private void QNXCZYQBBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE9D0", Offset = "0x9DAD9D0", VA = "0x189DAE9D0", Slot = "6")]
		public void HZYNIXROISA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE0D0", Offset = "0x9DAD0D0", VA = "0x189DAE0D0", Slot = "7")]
		public Task CUVZMCKSDVQ(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF7F0", Offset = "0x9DAE7F0", VA = "0x189DAF7F0")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task QMAKALDVZDN(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF7D0", Offset = "0x9DAE7D0", VA = "0x189DAF7D0")]
		private void PZFVIYDJGXY(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEA40", Offset = "0x9DADA40", VA = "0x189DAEA40")]
		private void IKKDMZYJSDV(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE070", Offset = "0x9DAD070", VA = "0x189DAE070")]
		private string CUGAOFQMUUC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9DAFD50", Offset = "0x9DAED50", VA = "0x189DAFD50")]
		private void TEFXQRVTQCE(AccountPreferenceBackingStoreTypes a, string b, [Out] CHZJVSBKAMD c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0350", Offset = "0x9DAF350", VA = "0x189DB0350")]
		private CHZJVSBKAMD URKBNKRWDWI(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0010", Offset = "0x9DAF010", VA = "0x189DB0010", Slot = "8")]
		public bool UBLMOZBBBCC(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9DAFA70", Offset = "0x9DAEA70", VA = "0x189DAFA70", Slot = "9")]
		public bool RGCIZDJUQAI(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEFB0", Offset = "0x9DADFB0", VA = "0x189DAEFB0", Slot = "10")]
		public bool LNCVZMXMAYX(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF350", Offset = "0x9DAE350", VA = "0x189DAF350", Slot = "11")]
		public string NSLXLRHWCDS(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9DADEE0", Offset = "0x9DACEE0", VA = "0x189DADEE0", Slot = "12")]
		public SetResult BYPEFORNSNS(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9DAFEF0", Offset = "0x9DAEEF0", VA = "0x189DAFEF0", Slot = "13")]
		public int TMEXRUKCKAW(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9DADCD0", Offset = "0x9DACCD0", VA = "0x189DADCD0", Slot = "14")]
		public SetResult ANUMOQRNPFE(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF130", Offset = "0x9DAE130", VA = "0x189DAF130", Slot = "15")]
		public bool NDXCOMGJKCJ(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9DAED00", Offset = "0x9DADD00", VA = "0x189DAED00", Slot = "16")]
		public SetResult KVBZHENZSDL(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE8F0", Offset = "0x9DAD8F0", VA = "0x189DAE8F0", Slot = "17")]
		public float HPCERYMIIYF(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF3F0", Offset = "0x9DAE3F0", VA = "0x189DAF3F0", Slot = "18")]
		public SetResult NVVNTIFSLYV(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE750", Offset = "0x9DAD750", VA = "0x189DAE750", Slot = "19")]
		public DateTime ESSQAZBBZVC(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE540", Offset = "0x9DAD540", VA = "0x189DAE540", Slot = "20")]
		public SetResult EEKFYARCXQI(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE320", Offset = "0x9DAD320", VA = "0x189DAE320", Slot = "21")]
		public long DIFVDQIBNNV(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEAF0", Offset = "0x9DADAF0", VA = "0x189DAEAF0", Slot = "22")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DAE7F0", Offset = "0x9DAD7F0", VA = "0x189DAE7F0", Slot = "25")]
		public bool HDSKNMVYXZA(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE2A0", Offset = "0x9DAD2A0", VA = "0x189DAE2A0", Slot = "26")]
		public bool CZJTNSALVOP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9DB04E0", Offset = "0x9DAF4E0", VA = "0x189DB04E0", Slot = "27")]
		public string XARPBQJNCFE(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE8C0", Offset = "0x9DAD8C0", VA = "0x189DAE8C0", Slot = "28")]
		public SetResult HMOFNXMMVEG(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE850", Offset = "0x9DAD850", VA = "0x189DAE850", Slot = "29")]
		public int HJSOWZYBPNW(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0900", Offset = "0x9DAF900", VA = "0x189DB0900", Slot = "30")]
		public SetResult ZXEPAUOCCZW(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE2B0", Offset = "0x9DAD2B0", VA = "0x189DAE2B0", Slot = "31")]
		public bool DBQYESBVVQL(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF900", Offset = "0x9DAE900", VA = "0x189DAF900", Slot = "32")]
		public SetResult QNFGVAMOHPR(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEC90", Offset = "0x9DADC90", VA = "0x189DAEC90", Slot = "33")]
		public float JLJQSAULSYX(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF320", Offset = "0x9DAE320", VA = "0x189DAF320", Slot = "34")]
		public SetResult NRDIKQZCQWX(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB03D0", Offset = "0x9DAF3D0", VA = "0x189DB03D0", Slot = "35")]
		public DateTime VGQCHVKQFVQ(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEC60", Offset = "0x9DADC60", VA = "0x189DAEC60", Slot = "36")]
		public SetResult ITJRRPTWJMO(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9DAFFA0", Offset = "0x9DAEFA0", VA = "0x189DAFFA0", Slot = "37")]
		public long TZAJFUZLKWR(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE9A0", Offset = "0x9DAD9A0", VA = "0x189DAE9A0", Slot = "38")]
		public SetResult HSAOYFQCBIN(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0190", Offset = "0x9DAF190", VA = "0x189DB0190")]
		private bool UEZUZOHZPYC(YRQQFWHWLVM a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9DB01F0", Offset = "0x9DAF1F0", VA = "0x189DB01F0")]
		private bool UIJGSKRQMUJ(YRQQFWHWLVM a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0550", Offset = "0x9DAF550", VA = "0x189DB0550")]
		private SetResult XIVOPRJOSXZ(YRQQFWHWLVM a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEE70", Offset = "0x9DADE70", VA = "0x189DAEE70")]
		private SetResult LDEFYWMXYUH(YRQQFWHWLVM a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF1E0", Offset = "0x9DAE1E0", VA = "0x189DAF1E0")]
		private SetResult NKOIUZYZGHE(YRQQFWHWLVM a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9DADB90", Offset = "0x9DACB90", VA = "0x189DADB90")]
		private SetResult AJBINUVFLUQ(YRQQFWHWLVM a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9DAFB10", Offset = "0x9DAEB10", VA = "0x189DAFB10")]
		private SetResult RUQZFMJBNMX(YRQQFWHWLVM a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE3C0", Offset = "0x9DAD3C0", VA = "0x189DAE3C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DAFC80", Offset = "0x9DAEC80", VA = "0x189DAFC80")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(YRQQFWHWLVM backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF980", Offset = "0x9DAE980", VA = "0x189DAF980", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task QUWXKKCLLMA([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9DB06A0", Offset = "0x9DAF6A0", VA = "0x189DB06A0")]
		private void XJSDZTMTKIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9DB00C0", Offset = "0x9DAF0C0", VA = "0x189DB00C0", Slot = "41")]
		public IDisposable UEHONEAIUIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9DAE060", Offset = "0x9DAD060", VA = "0x189DAE060", Slot = "42")]
		public void CKZEDKCRBST(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9DAF570", Offset = "0x9DAE570", VA = "0x189DAF570")]
		private void PJJQOCYBMWH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0880", Offset = "0x9DAF880", VA = "0x189DB0880")]
		[IteratorStateMachine(typeof(PVDEUNZGUMB))]
		private IEnumerator<BFNVKIYRTEQ> XXESNLPSYWV(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9DAEAC0", Offset = "0x9DADAC0", VA = "0x189DAEAC0")]
		[CompilerGenerated]
		private void IPDUPWACZFM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class CUXJATGQMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB100", Offset = "0x9DAA100", VA = "0x189DAB100")]
		public static string BACHNAKIYCA(this BEJVLFDIYAN a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB380", Offset = "0x9DAA380", VA = "0x189DAB380")]
		public static byte[] REGJTNHOBKA(this BEJVLFDIYAN a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9DAB270", Offset = "0x9DAA270", VA = "0x189DAB270")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DACFC0", Offset = "0x9DABFC0", VA = "0x189DACFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9DACED0", Offset = "0x9DABED0", VA = "0x189DACED0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD010", Offset = "0x9DAC010", VA = "0x189DAD010", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9DAD320", Offset = "0x9DAC320", VA = "0x189DAD320")]
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
