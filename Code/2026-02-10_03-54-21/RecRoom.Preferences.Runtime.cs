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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x881F190", Offset = "0x881E390", VA = "0x18881F190")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x881EF40", Offset = "0x881E140", VA = "0x18881EF40", Slot = "4")]
		public override void JUFURAKXVZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x8824430", Offset = "0x8823630", VA = "0x188824430", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x27815F0", Offset = "0x27807F0", VA = "0x1827815F0")]
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
	internal static class HRTOMXPAVLW
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal delegate void CustomSaveHandler(VIQRBGKASHK backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x881A8F0", Offset = "0x8819AF0", VA = "0x18881A8F0")]
		private static void PTEBRSENSXJ(VIQRBGKASHK a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x881AAB0", Offset = "0x8819CB0", VA = "0x18881AAB0")]
		public static bool WRXXSQIEFOR(this VIQRBGKASHK a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x881A4F0", Offset = "0x88196F0", VA = "0x18881A4F0")]
		public static SetResult INGMBJYCBEM(this VIQRBGKASHK a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x881A260", Offset = "0x8819460", VA = "0x18881A260")]
		public static SetResult ENSWVHCZQYY(this VIQRBGKASHK a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x881A970", Offset = "0x8819B70", VA = "0x18881A970")]
		public static SetResult USQCHRPGSLH(this VIQRBGKASHK a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x881A3A0", Offset = "0x88195A0", VA = "0x18881A3A0")]
		public static SetResult GAODAHIQYQL(this VIQRBGKASHK a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x881A640", Offset = "0x8819840", VA = "0x18881A640")]
		public static SetResult KMHVAICFIKQ(this VIQRBGKASHK a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x881A7B0", Offset = "0x88199B0", VA = "0x18881A7B0")]
		public static SetResult MQBWRFAKXAL(this VIQRBGKASHK a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class FSFWUGKBORX : BMPLHGOEAAV, VIQRBGKASHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log ZVAFGKBWRCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly KMEDGXMBOLS NJERQVZFNYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Dictionary<string, byte> YHGXPIQOHDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Dictionary<string, string> VNYUSJMNKLO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool SKRCPBVXMIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> STYDQAWCFRQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8818EF0", Offset = "0x88180F0", VA = "0x188818EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NBHZWHJFFQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x881A060", Offset = "0x8819260", VA = "0x18881A060")]
		[UnityEngine.Scripting.Preserve]
		public FSFWUGKBORX([Inject(null)] KMEDGXMBOLS unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "8")]
		public void DQPUGJYJOZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8818160", Offset = "0x8817360", VA = "0x188818160")]
		private DirectoryInfo IBMIRSBQFNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8818870", Offset = "0x8817A70", VA = "0x188818870", Slot = "6")]
		public Task MRDKKDOEAOQ(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88189E0", Offset = "0x8817BE0", VA = "0x1888189E0", Slot = "14")]
		public float RSEDQLSTBWK(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8819F80", Offset = "0x8819180", VA = "0x188819F80", Slot = "13")]
		public void ZTKKNDETOMU(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8818FA0", Offset = "0x88181A0", VA = "0x188818FA0", Slot = "12")]
		public bool WWYFJITNLRK(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8817C60", Offset = "0x8816E60", VA = "0x188817C60", Slot = "10")]
		public int AUGMCDUFTTX(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8819060", Offset = "0x8818260", VA = "0x188819060", Slot = "18")]
		public DateTime XIUVHSGHDQJ(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8817BF0", Offset = "0x8816DF0", VA = "0x188817BF0", Slot = "19")]
		public void APQFEFGBKMR(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x88190D0", Offset = "0x88182D0", VA = "0x1888190D0", Slot = "15")]
		public void YBLEKHFIVKO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8817DD0", Offset = "0x8816FD0", VA = "0x188817DD0", Slot = "11")]
		public void BTUBHFEMPDT(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8817ED0", Offset = "0x88170D0", VA = "0x188817ED0", Slot = "20")]
		public long FWUWSCKVRBA(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8818F30", Offset = "0x8818130", VA = "0x188818F30", Slot = "21")]
		public void VTIFXQVGSHU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x370BEC0", Offset = "0x370B0C0", VA = "0x18370BEC0", Slot = "22")]
		public a DIPAXIETDDZ<a>(string a, a b, RDLNPBOQBUW<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x370C190", Offset = "0x370B390", VA = "0x18370C190", Slot = "23")]
		public void GGLPYHWYKEX<b>(string a, b b, RDLNPBOQBUW<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8819ED0", Offset = "0x88190D0", VA = "0x188819ED0", Slot = "16")]
		public string YMVZHZVKHSR(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8818970", Offset = "0x8817B70", VA = "0x188818970", Slot = "17")]
		public void QDDVYNBUWDP(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8818D80", Offset = "0x8817F80", VA = "0x188818D80", Slot = "24")]
		public void TZHWUHXAJLM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8817E40", Offset = "0x8817040", VA = "0x188817E40", Slot = "9")]
		public bool CJBVNSAIZLZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8818A50", Offset = "0x8817C50", VA = "0x188818A50", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8818250", Offset = "0x8817450", VA = "0x188818250")]
		private void LXPHQPMXPTU(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8817F40", Offset = "0x8817140", VA = "0x188817F40")]
		private static string GSCOIJEPSZJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8817CD0", Offset = "0x8816ED0", VA = "0x188817CD0")]
		private static string AZXQVMLFUMI(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x370C330", Offset = "0x370B530", VA = "0x18370C330")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] RDLNPBOQBUW<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x370DAF0", Offset = "0x370CCF0", VA = "0x18370DAF0")]
		private void Set<T>(string propertyName, T value, [Optional] RDLNPBOQBUW<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8819140", Offset = "0x8818340", VA = "0x188819140")]
		private Dictionary<string, string> YDDTAHJKPPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8819E70", Offset = "0x8819070", VA = "0x188819E70")]
		private void YKTJKEKHPQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8818900", Offset = "0x8817B00", VA = "0x188818900")]
		private void PPLQDALRBKZ(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class OIVMCNUBHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log ZVAFGKBWRCW;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x881F210", Offset = "0x881E410", VA = "0x18881F210")]
		[OCFGNIRMEEE.Root]
		internal static void OCFGNIRMEEE(CYZVJPHMMVM a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MKOCGBUDGXA : VZWWNKEFXDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x881F040", Offset = "0x881E240", VA = "0x18881F040")]
		[UnityEngine.Scripting.Preserve]
		public MKOCGBUDGXA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class IIGAXYVUYNK : BMPLHGOEAAV, VIQRBGKASHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly KMEDGXMBOLS NJERQVZFNYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Dictionary<string, string> PQYHQIXZGPY;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool SKRCPBVXMIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action NBHZWHJFFQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x881B370", Offset = "0x881A570", VA = "0x18881B370")]
		[UnityEngine.Scripting.Preserve]
		public IIGAXYVUYNK([Inject(null)] KMEDGXMBOLS unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x881AE30", Offset = "0x881A030", VA = "0x18881AE30", Slot = "6")]
		public Task MRDKKDOEAOQ(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "8")]
		public void DQPUGJYJOZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x881AD60", Offset = "0x8819F60", VA = "0x18881AD60", Slot = "9")]
		public bool CJBVNSAIZLZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x881AC80", Offset = "0x8819E80", VA = "0x18881AC80", Slot = "10")]
		public int AUGMCDUFTTX(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x881ACF0", Offset = "0x8819EF0", VA = "0x18881ACF0", Slot = "11")]
		public void BTUBHFEMPDT(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x881B130", Offset = "0x881A330", VA = "0x18881B130", Slot = "12")]
		public bool WWYFJITNLRK(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x881B300", Offset = "0x881A500", VA = "0x18881B300", Slot = "13")]
		public void ZTKKNDETOMU(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x881AF30", Offset = "0x881A130", VA = "0x18881AF30", Slot = "14")]
		public float RSEDQLSTBWK(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x881B210", Offset = "0x881A410", VA = "0x18881B210", Slot = "15")]
		public void YBLEKHFIVKO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x881B280", Offset = "0x881A480", VA = "0x18881B280", Slot = "16")]
		public string YMVZHZVKHSR(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x881AEC0", Offset = "0x881A0C0", VA = "0x18881AEC0", Slot = "17")]
		public void QDDVYNBUWDP(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x881B1A0", Offset = "0x881A3A0", VA = "0x18881B1A0", Slot = "18")]
		public DateTime XIUVHSGHDQJ(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x881AC10", Offset = "0x8819E10", VA = "0x18881AC10", Slot = "19")]
		public void APQFEFGBKMR(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x881ADC0", Offset = "0x8819FC0", VA = "0x18881ADC0", Slot = "20")]
		public long FWUWSCKVRBA(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x881B0C0", Offset = "0x881A2C0", VA = "0x18881B0C0", Slot = "21")]
		public void VTIFXQVGSHU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x37719F0", Offset = "0x3770BF0", VA = "0x1837719F0", Slot = "22")]
		public a DIPAXIETDDZ<a>(string a, a b, RDLNPBOQBUW<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3771BD0", Offset = "0x3770DD0", VA = "0x183771BD0", Slot = "23")]
		public void GGLPYHWYKEX<b>(string a, b b, RDLNPBOQBUW<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x881B030", Offset = "0x881A230", VA = "0x18881B030", Slot = "24")]
		public void TZHWUHXAJLM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x881AFA0", Offset = "0x881A1A0", VA = "0x18881AFA0", Slot = "25")]
		public Task Save([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3771D70", Offset = "0x3770F70", VA = "0x183771D70")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] RDLNPBOQBUW<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3773530", Offset = "0x3772730", VA = "0x183773530")]
		private void Set<T>(string propertyName, T value, [Optional] RDLNPBOQBUW<T> parser)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class VZWWNKEFXDJ : BMPLHGOEAAV, VIQRBGKASHK, VAKWMISXHCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly Dictionary<string, object> VAEHBDCPNJH;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool SKRCPBVXMIC
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action NBHZWHJFFQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "8")]
		public void DQPUGJYJOZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8823FB0", Offset = "0x88231B0", VA = "0x188823FB0", Slot = "6")]
		public Task MRDKKDOEAOQ(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8823EF0", Offset = "0x88230F0", VA = "0x188823EF0", Slot = "9")]
		public bool CJBVNSAIZLZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8823E30", Offset = "0x8823030", VA = "0x188823E30", Slot = "10")]
		public int AUGMCDUFTTX(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8823E90", Offset = "0x8823090", VA = "0x188823E90", Slot = "11")]
		public void BTUBHFEMPDT(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8824250", Offset = "0x8823450", VA = "0x188824250", Slot = "12")]
		public bool WWYFJITNLRK(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x88243D0", Offset = "0x88235D0", VA = "0x1888243D0", Slot = "13")]
		public void ZTKKNDETOMU(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x88240A0", Offset = "0x88232A0", VA = "0x1888240A0", Slot = "14")]
		public float RSEDQLSTBWK(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8824310", Offset = "0x8823510", VA = "0x188824310", Slot = "15")]
		public void YBLEKHFIVKO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8824370", Offset = "0x8823570", VA = "0x188824370", Slot = "16")]
		public string YMVZHZVKHSR(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8824040", Offset = "0x8823240", VA = "0x188824040", Slot = "17")]
		public void QDDVYNBUWDP(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x88242B0", Offset = "0x88234B0", VA = "0x1888242B0", Slot = "18")]
		public DateTime XIUVHSGHDQJ(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8823DD0", Offset = "0x8822FD0", VA = "0x188823DD0", Slot = "19")]
		public void APQFEFGBKMR(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8823F50", Offset = "0x8823150", VA = "0x188823F50", Slot = "20")]
		public long FWUWSCKVRBA(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x88241F0", Offset = "0x88233F0", VA = "0x1888241F0", Slot = "21")]
		public void VTIFXQVGSHU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3C25A10", Offset = "0x3C24C10", VA = "0x183C25A10", Slot = "22")]
		public a DIPAXIETDDZ<a>(string a, a b, RDLNPBOQBUW<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3C25D80", Offset = "0x3C24F80", VA = "0x183C25D80", Slot = "23")]
		public void GGLPYHWYKEX<b>(string a, b b, RDLNPBOQBUW<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3C25ED0", Offset = "0x3C250D0", VA = "0x183C25ED0")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3C2F870", Offset = "0x3C2EA70", VA = "0x183C2F870")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8824190", Offset = "0x8823390", VA = "0x188824190", Slot = "24")]
		public void TZHWUHXAJLM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8824100", Offset = "0x8823300", VA = "0x188824100", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x881F040", Offset = "0x881E240", VA = "0x18881F040")]
		public VZWWNKEFXDJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class ASNNFDUBTBM<a> where a : VIQRBGKASHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly HashSet<ASNNFDUBTBM<a>> SGQSHUVQFWP;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5599000", Offset = "0x5598200", VA = "0x185599000")]
		protected ASNNFDUBTBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void ZKOWDHPQDZM(string a);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5598B40", Offset = "0x5597D40", VA = "0x185598B40")]
		public static void THCVUTOYOEI(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x55983C0", Offset = "0x55975C0", VA = "0x1855983C0")]
		public static void JYTDIHMXDVS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class ASIGHXAEJQD<a, b> : ASNNFDUBTBM<a> where a : VIQRBGKASHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly ASIGHXAEJQD<a, b> XTXDOOBWSYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Dictionary<string, b> JMXPHHKOUYM;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x55977C0", Offset = "0x55969C0", VA = "0x1855977C0")]
		public bool GDGJFTLPVBG(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5597930", Offset = "0x5596B30", VA = "0x185597930")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
		public IEnumerable<KeyValuePair<string, b>> VVDMZUNJQCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5597670", Offset = "0x5596870", VA = "0x185597670", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5597B00", Offset = "0x5596D00", VA = "0x185597B00", Slot = "5")]
		protected override void ZKOWDHPQDZM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5597EC0", Offset = "0x55970C0", VA = "0x185597EC0")]
		public ASIGHXAEJQD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface VIQRBGKASHK
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool SKRCPBVXMIC
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DQPUGJYJOZI();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CJBVNSAIZLZ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int AUGMCDUFTTX(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BTUBHFEMPDT(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool WWYFJITNLRK(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZTKKNDETOMU(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float RSEDQLSTBWK(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void YBLEKHFIVKO(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string YMVZHZVKHSR(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void QDDVYNBUWDP(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime XIUVHSGHDQJ(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void APQFEFGBKMR(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long FWUWSCKVRBA(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void VTIFXQVGSHU(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a DIPAXIETDDZ<a>(string a, a b, RDLNPBOQBUW<a> c);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void GGLPYHWYKEX<b>(string a, b b, RDLNPBOQBUW<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void TZHWUHXAJLM(string a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface BMPLHGOEAAV : VIQRBGKASHK
	{
		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action NBHZWHJFFQQ;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task MRDKKDOEAOQ(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface VAKWMISXHCF : VIQRBGKASHK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KZVMJOGLHQH : BMPLHGOEAAV, VIQRBGKASHK
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
			public KZVMJOGLHQH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x8822DF0", Offset = "0x8821FF0", VA = "0x188822DF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x88231B0", Offset = "0x88223B0", VA = "0x1888231B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class HJRXLRHMONH : IEnumerator<GVXKGQILIBM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private GVXKGQILIBM HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public KZVMJOGLHQH LQBDIDDTHZG;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private GVXKGQILIBM FMWFFBPUHSV
			{
				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xABE300", Offset = "0xABD500", VA = "0x180ABE300")]
			[DebuggerHidden]
			public HJRXLRHMONH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x881A1B0", Offset = "0x88193B0", VA = "0x18881A1B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x881A220", Offset = "0x8819420", VA = "0x18881A220", Slot = "8")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly Log ZVAFGKBWRCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly KMEDGXMBOLS NJERQVZFNYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool BICWXNWMNYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool EAMUZOCGSDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private GFPWOHIOJAQ LMEFDSOPPHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private IFXEZINOVAZ BYVAQBUGIVB;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool SKRCPBVXMIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action NBHZWHJFFQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x881EE40", Offset = "0x881E040", VA = "0x18881EE40")]
		[UnityEngine.Scripting.Preserve]
		public KZVMJOGLHQH([Inject(null)] KMEDGXMBOLS unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "8")]
		public void DQPUGJYJOZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x881C850", Offset = "0x881BA50", VA = "0x18881C850", Slot = "6")]
		public Task MRDKKDOEAOQ(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1C19600", Offset = "0x1C18800", VA = "0x181C19600")]
		private static int SHWKJXQHOGS(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x881C500", Offset = "0x881B700", VA = "0x18881C500", Slot = "9")]
		public bool CJBVNSAIZLZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x881C330", Offset = "0x881B530", VA = "0x18881C330", Slot = "10")]
		public int AUGMCDUFTTX(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x881C450", Offset = "0x881B650", VA = "0x18881C450", Slot = "11")]
		public void BTUBHFEMPDT(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x881E850", Offset = "0x881DA50", VA = "0x18881E850", Slot = "12")]
		public bool WWYFJITNLRK(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x881ECF0", Offset = "0x881DEF0", VA = "0x18881ECF0", Slot = "13")]
		public void ZTKKNDETOMU(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x881E4D0", Offset = "0x881D6D0", VA = "0x18881E4D0", Slot = "14")]
		public float RSEDQLSTBWK(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x881EA10", Offset = "0x881DC10", VA = "0x18881EA10", Slot = "15")]
		public void YBLEKHFIVKO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x881E9A0", Offset = "0x881DBA0", VA = "0x18881E9A0", Slot = "18")]
		public DateTime XIUVHSGHDQJ(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x881C2C0", Offset = "0x881B4C0", VA = "0x18881C2C0", Slot = "19")]
		public void APQFEFGBKMR(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x881C640", Offset = "0x881B840", VA = "0x18881C640", Slot = "20")]
		public long FWUWSCKVRBA(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x881E7E0", Offset = "0x881D9E0", VA = "0x18881E7E0", Slot = "21")]
		public void VTIFXQVGSHU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x380BD00", Offset = "0x380AF00", VA = "0x18380BD00", Slot = "22")]
		public a DIPAXIETDDZ<a>(string a, a b, RDLNPBOQBUW<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x380C010", Offset = "0x380B210", VA = "0x18380C010", Slot = "23")]
		public void GGLPYHWYKEX<b>(string a, b b, RDLNPBOQBUW<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x380C2C0", Offset = "0x380B4C0", VA = "0x18380C2C0")]
		private c SUDKARRUDPE<c>(string a, c b, [Optional] RDLNPBOQBUW<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x380D300", Offset = "0x380C500", VA = "0x18380D300")]
		private void XJYFKOWBYVI<d>(string a, d b, [Optional] RDLNPBOQBUW<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x881EB40", Offset = "0x881DD40", VA = "0x18881EB40", Slot = "16")]
		public string YMVZHZVKHSR(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x881CAC0", Offset = "0x881BCC0", VA = "0x18881CAC0", Slot = "17")]
		public void QDDVYNBUWDP(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x881C520", Offset = "0x881B720", VA = "0x18881C520")]
		private void EMEWHYLBSZW(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x881C6B0", Offset = "0x881B8B0", VA = "0x18881C6B0")]
		private string HHKJCGJEDKE(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x881E750", Offset = "0x881D950", VA = "0x18881E750", Slot = "24")]
		public void TZHWUHXAJLM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x881C8E0", Offset = "0x881BAE0", VA = "0x18881C8E0")]
		private string MZMLKXRGDCS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x881CBF0", Offset = "0x881BDF0", VA = "0x18881CBF0")]
		public void RIQXPGEARTL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x881E600", Offset = "0x881D800", VA = "0x18881E600", Slot = "26")]
		public void SFUBWPSQMYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x881E660", Offset = "0x881D860", VA = "0x18881E660", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__40))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x881C9E0", Offset = "0x881BBE0", VA = "0x18881C9E0")]
		[IteratorStateMachine(typeof(HJRXLRHMONH))]
		private IEnumerator<GVXKGQILIBM> PAFXIQIAHKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x881C980", Offset = "0x881BB80", VA = "0x18881C980")]
		private void OLIAYWXXAGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x881EAD0", Offset = "0x881DCD0", VA = "0x18881EAD0")]
		private void YKTJKEKHPQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x881CA50", Offset = "0x881BC50", VA = "0x18881CA50")]
		private void PPLQDALRBKZ(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KHTHOCYWQSD : BMPLHGOEAAV, VIQRBGKASHK
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
		private Dictionary<string, string> VNYUSJMNKLO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool SKRCPBVXMIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string ATEBIWOYUZR
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x881B820", Offset = "0x881AA20", VA = "0x18881B820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private string XMQJGSZODDT
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x881B6F0", Offset = "0x881A8F0", VA = "0x18881B6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Dictionary<string, string> STYDQAWCFRQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x881BC40", Offset = "0x881AE40", VA = "0x18881BC40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action NBHZWHJFFQQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		[UnityEngine.Scripting.Preserve]
		public KHTHOCYWQSD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "8")]
		public void DQPUGJYJOZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x881B660", Offset = "0x881A860", VA = "0x18881B660", Slot = "6")]
		public Task MRDKKDOEAOQ(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x881B8B0", Offset = "0x881AAB0", VA = "0x18881B8B0", Slot = "14")]
		public float RSEDQLSTBWK(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x881C250", Offset = "0x881B450", VA = "0x18881C250", Slot = "13")]
		public void ZTKKNDETOMU(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x881BCF0", Offset = "0x881AEF0", VA = "0x18881BCF0", Slot = "12")]
		public bool WWYFJITNLRK(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x881B480", Offset = "0x881A680", VA = "0x18881B480", Slot = "10")]
		public int AUGMCDUFTTX(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x881BDB0", Offset = "0x881AFB0", VA = "0x18881BDB0", Slot = "18")]
		public DateTime XIUVHSGHDQJ(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x881B410", Offset = "0x881A610", VA = "0x18881B410", Slot = "19")]
		public void APQFEFGBKMR(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x881BE20", Offset = "0x881B020", VA = "0x18881BE20", Slot = "15")]
		public void YBLEKHFIVKO(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x881B4F0", Offset = "0x881A6F0", VA = "0x18881B4F0", Slot = "11")]
		public void BTUBHFEMPDT(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x881B5F0", Offset = "0x881A7F0", VA = "0x18881B5F0", Slot = "20")]
		public long FWUWSCKVRBA(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x881BC80", Offset = "0x881AE80", VA = "0x18881BC80", Slot = "21")]
		public void VTIFXQVGSHU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3805540", Offset = "0x3804740", VA = "0x183805540", Slot = "22")]
		public a DIPAXIETDDZ<a>(string a, a b, RDLNPBOQBUW<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3805720", Offset = "0x3804920", VA = "0x183805720", Slot = "23")]
		public void GGLPYHWYKEX<b>(string a, b b, RDLNPBOQBUW<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x881C1A0", Offset = "0x881B3A0", VA = "0x18881C1A0", Slot = "16")]
		public string YMVZHZVKHSR(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x881B780", Offset = "0x881A980", VA = "0x18881B780", Slot = "17")]
		public void QDDVYNBUWDP(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x881BB80", Offset = "0x881AD80", VA = "0x18881BB80", Slot = "24")]
		public void TZHWUHXAJLM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x881B560", Offset = "0x881A760", VA = "0x18881B560", Slot = "9")]
		public bool CJBVNSAIZLZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x881B920", Offset = "0x881AB20", VA = "0x18881B920", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x38058C0", Offset = "0x3804AC0", VA = "0x1838058C0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] RDLNPBOQBUW<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3807000", Offset = "0x3806200", VA = "0x183807000")]
		private void Set<T>(string propertyName, T value, [Optional] RDLNPBOQBUW<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x881BE90", Offset = "0x881B090", VA = "0x18881BE90")]
		private Dictionary<string, string> YDDTAHJKPPI()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface SSXJQXLLVXB
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action NBHZWHJFFQQ;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DQPUGJYJOZI();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task ABFGVQRCGSE(long a);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool TLATRDHKVNS(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool OJLBZALJVEG(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DDDZGAMBFWR(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string UOLRPVNXTUW(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult IGGPQQIZGRU(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int SXFDDZWHWHC(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult NDTSVHQFJEQ(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool ESREXAEDOIT(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult NXZIWZXBZJJ(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float RMHRRBMZLJF(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult TMIFGSBBSSL(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime AELXJIQSODE(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult QEUQIGHNSPI(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long RNPCDZHYCXT(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult CYZHTFGSDJP(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a NFKVNJCKPFO<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult MBBYVZSHVRK<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool XYNXFYPPZGE(string a);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool SMZLPEVLTGN(string a);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string FVSFFJVEGAM(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult NCXKOWLENXW(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int VOPVDOHPPVE(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult KFURSUZJQRU(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool GUEHFGOXQOF(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult RZTXHMKZBFX(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float WTPZZUZVCSN(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult KQKDWQJKAEF(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime XZLKEJGMOWA(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult WVSGCIRJSSU(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long GDEXHQSHHXN(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult VRRRVAFYLUX(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void FOUBLSSMZKG<e>(RDLNPBOQBUW<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void WZKAZDILYEB<f>();

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable MTKCHTUJEGS();

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void SUXXTINULJT(float a);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task OLIAYWXXAGC([Optional] CancellationToken a);
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
	public class Preferences : SSXJQXLLVXB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private abstract class VCUQQBSXTOZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			protected static readonly HashSet<VCUQQBSXTOZ> MKFRWVGLUMM;

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x8823C10", Offset = "0x8822E10", VA = "0x188823C10")]
			public static void JYTDIHMXDVS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			protected VCUQQBSXTOZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private class UFGWYOPUEKK<a> : VCUQQBSXTOZ
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly UFGWYOPUEKK<a> DZRVHNEPLID;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public RDLNPBOQBUW<a> QFKCUZYEFHB
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xABA430", Offset = "0xAB9630", VA = "0x180ABA430")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public IEqualityComparer<a> SEPGTBXXTAT
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xABA470", Offset = "0xAB9670", VA = "0x180ABA470")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool UOSEMHJMGGQ
			{
				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xC64B10", Offset = "0xC63D10", VA = "0x180C64B10")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x626B110", Offset = "0x626A310", VA = "0x18626B110")]
			private UFGWYOPUEKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x626A610", Offset = "0x6269810", VA = "0x18626A610")]
			public void JUFURAKXVZP(RDLNPBOQBUW<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xDD1810", Offset = "0xDD0A10", VA = "0x180DD1810", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private class DYVFNBZCYJX : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private readonly Preferences TFBPRDETXTM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private readonly object ZOXKREPPUTG;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x8817B40", Offset = "0x8816D40", VA = "0x188817B40")]
			public DYVFNBZCYJX(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x8817B10", Offset = "0x8816D10", VA = "0x188817B10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8822580", Offset = "0x8821780", VA = "0x188822580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x8822860", Offset = "0x8821A60", VA = "0x188822860", Slot = "5")]
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
			public VIQRBGKASHK backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x8823210", Offset = "0x8822410", VA = "0x188823210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xB18410", Offset = "0xB17610", VA = "0x180B18410", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x88228C0", Offset = "0x8821AC0", VA = "0x1888228C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x8822D90", Offset = "0x8821F90", VA = "0x188822D90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class NSDWQAFWJIP : IEnumerator<GVXKGQILIBM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private GVXKGQILIBM HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Preferences LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float ANJSVJQMQQR;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private GVXKGQILIBM FMWFFBPUHSV
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xABE300", Offset = "0xABD500", VA = "0x180ABE300")]
			[DebuggerHidden]
			public NSDWQAFWJIP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x881F0C0", Offset = "0x881E2C0", VA = "0x18881F0C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x881F150", Offset = "0x881E350", VA = "0x18881F150", Slot = "8")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly BMPLHGOEAAV AZKUFAYBJMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly BMPLHGOEAAV YMIHKNITQLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly VAKWMISXHCF GCKLJIJCAFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly GFPWOHIOJAQ LMEFDSOPPHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly HRTOMXPAVLW.CustomSaveHandler SSQGIGTBLAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly EWUFIVAODUW JBPLJJKGIJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly HashSet<VIQRBGKASHK> UMKPIGZNRTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Task SLKKHHYOGNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<string, string> CVFLNCTLSMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private IFXEZINOVAZ BPISBRIPGAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly object GAKGPWTYNPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly object YPFTVXCARRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long USHYTDMLBHE;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool AMZVVKGHXXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x17FA790", Offset = "0x17F9990", VA = "0x1817FA790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private CancellationTokenSource PRAQDRKFTFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xABC9A0", Offset = "0xABBBA0", VA = "0x180ABC9A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xABC960", Offset = "0xABBB60", VA = "0x180ABC960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action NBHZWHJFFQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8820330", Offset = "0x881F530", VA = "0x188820330", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x881FF20", Offset = "0x881F120", VA = "0x18881FF20", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8821860", Offset = "0x8820A60", VA = "0x188821860")]
		[OCFGNIRMEEE.Root]
		internal static void TVDYOIXXSED(CYZVJPHMMVM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x88221F0", Offset = "0x88213F0", VA = "0x1888221F0")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] BMPLHGOEAAV localBackingStore, [Inject("Cloud")] BMPLHGOEAAV cloudBackingStore, [Inject(null)] VAKWMISXHCF editorBackingStore, [Inject(null)] GFPWOHIOJAQ scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x881FE60", Offset = "0x881F060", VA = "0x18881FE60", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x881F830", Offset = "0x881EA30", VA = "0x18881F830")]
		private void BFFGUKQFRGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x881FB90", Offset = "0x881ED90", VA = "0x18881FB90", Slot = "6")]
		public void DQPUGJYJOZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x881F450", Offset = "0x881E650", VA = "0x18881F450", Slot = "7")]
		public Task ABFGVQRCGSE(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x881F6C0", Offset = "0x881E8C0", VA = "0x18881F6C0")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task AINXUFDGYHP(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x881F880", Offset = "0x881EA80", VA = "0x18881F880")]
		private void BOSFIVOMXFG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x881FEA0", Offset = "0x881F0A0", VA = "0x18881FEA0")]
		private void EEXJINHNYGJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8821CC0", Offset = "0x8820EC0", VA = "0x188821CC0")]
		private string WJQMTKRZBKA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8821D20", Offset = "0x8820F20", VA = "0x188821D20")]
		private void WKIGZGXASFE(AccountPreferenceBackingStoreTypes a, string b, [Out] BMPLHGOEAAV c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x88220A0", Offset = "0x88212A0", VA = "0x1888220A0")]
		private BMPLHGOEAAV XUDBTRCCVVY(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8821630", Offset = "0x8820830", VA = "0x188821630", Slot = "8")]
		public bool TLATRDHKVNS(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8820D20", Offset = "0x881FF20", VA = "0x188820D20", Slot = "9")]
		public bool OJLBZALJVEG(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x881FA10", Offset = "0x881EC10", VA = "0x18881FA10", Slot = "10")]
		public bool DDDZGAMBFWR(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x88218D0", Offset = "0x8820AD0", VA = "0x1888218D0", Slot = "11")]
		public string UOLRPVNXTUW(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x88206E0", Offset = "0x881F8E0", VA = "0x1888206E0", Slot = "12")]
		public SetResult IGGPQQIZGRU(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x88214B0", Offset = "0x88206B0", VA = "0x1888214B0", Slot = "13")]
		public int SXFDDZWHWHC(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8820A40", Offset = "0x881FC40", VA = "0x188820A40", Slot = "14")]
		public SetResult NDTSVHQFJEQ(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x881FFC0", Offset = "0x881F1C0", VA = "0x18881FFC0", Slot = "15")]
		public bool ESREXAEDOIT(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8820BB0", Offset = "0x881FDB0", VA = "0x188820BB0", Slot = "16")]
		public SetResult NXZIWZXBZJJ(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x88212E0", Offset = "0x88204E0", VA = "0x1888212E0", Slot = "17")]
		public float RMHRRBMZLJF(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x88216E0", Offset = "0x88208E0", VA = "0x1888216E0", Slot = "18")]
		public SetResult TMIFGSBBSSL(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x881F620", Offset = "0x881E820", VA = "0x18881F620", Slot = "19")]
		public DateTime AELXJIQSODE(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8820FF0", Offset = "0x88201F0", VA = "0x188820FF0", Slot = "20")]
		public SetResult QEUQIGHNSPI(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8821390", Offset = "0x8820590", VA = "0x188821390", Slot = "21")]
		public long RNPCDZHYCXT(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x881F8A0", Offset = "0x881EAA0", VA = "0x18881F8A0", Slot = "22")]
		public SetResult CYZHTFGSDJP(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x39794A0", Offset = "0x39786A0", VA = "0x1839794A0", Slot = "23")]
		public a NFKVNJCKPFO<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x39790F0", Offset = "0x39782F0", VA = "0x1839790F0", Slot = "24")]
		public SetResult MBBYVZSHVRK<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8822120", Offset = "0x8821320", VA = "0x188822120", Slot = "25")]
		public bool XYNXFYPPZGE(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8821490", Offset = "0x8820690", VA = "0x188821490", Slot = "26")]
		public bool SMZLPEVLTGN(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8820250", Offset = "0x881F450", VA = "0x188820250", Slot = "27")]
		public string FVSFFJVEGAM(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8820A10", Offset = "0x881FC10", VA = "0x188820A10", Slot = "28")]
		public SetResult NCXKOWLENXW(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8821C20", Offset = "0x8820E20", VA = "0x188821C20", Slot = "29")]
		public int VOPVDOHPPVE(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x88208E0", Offset = "0x881FAE0", VA = "0x1888208E0", Slot = "30")]
		public SetResult KFURSUZJQRU(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x88203D0", Offset = "0x881F5D0", VA = "0x1888203D0", Slot = "31")]
		public bool GUEHFGOXQOF(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8821430", Offset = "0x8820630", VA = "0x188821430", Slot = "32")]
		public SetResult RZTXHMKZBFX(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8821EC0", Offset = "0x88210C0", VA = "0x188821EC0", Slot = "33")]
		public float WTPZZUZVCSN(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8820910", Offset = "0x881FB10", VA = "0x188820910", Slot = "34")]
		public SetResult KQKDWQJKAEF(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8822180", Offset = "0x8821380", VA = "0x188822180", Slot = "35")]
		public DateTime XZLKEJGMOWA(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8821F30", Offset = "0x8821130", VA = "0x188821F30", Slot = "36")]
		public SetResult WVSGCIRJSSU(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x88202C0", Offset = "0x881F4C0", VA = "0x1888202C0", Slot = "37")]
		public long GDEXHQSHHXN(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8821C90", Offset = "0x8820E90", VA = "0x188821C90", Slot = "38")]
		public SetResult VRRRVAFYLUX(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x881F7D0", Offset = "0x881E9D0", VA = "0x18881F7D0")]
		private bool ASKXJCGBXEA(VIQRBGKASHK a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8820580", Offset = "0x881F780", VA = "0x188820580")]
		private bool HJVJCFBPCPB(VIQRBGKASHK a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8821190", Offset = "0x8820390", VA = "0x188821190")]
		private SetResult QKYKKFYQUQV(VIQRBGKASHK a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8821F60", Offset = "0x8821160", VA = "0x188821F60")]
		private SetResult XDCSWUJXFBX(VIQRBGKASHK a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8820440", Offset = "0x881F640", VA = "0x188820440")]
		private SetResult GXXATYMWDLC(VIQRBGKASHK a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8821AE0", Offset = "0x8820CE0", VA = "0x188821AE0")]
		private SetResult VMXJIVXBMKS(VIQRBGKASHK a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8821970", Offset = "0x8820B70", VA = "0x188821970")]
		private SetResult VFKFXQCORXH(VIQRBGKASHK a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8820EB0", Offset = "0x88200B0", VA = "0x188820EB0")]
		private SetResult QBVSASULMHE(VIQRBGKASHK a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3979C60", Offset = "0x3978E60", VA = "0x183979C60")]
		private e OYVJORKEXJN<e>(VIQRBGKASHK a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x39785E0", Offset = "0x39777E0", VA = "0x1839785E0")]
		private SetResult KPHHYZOKQQH<f>(VIQRBGKASHK a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3977EB0", Offset = "0x39770B0", VA = "0x183977EB0", Slot = "39")]
		public void FOUBLSSMZKG<g>(RDLNPBOQBUW<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x397A100", Offset = "0x3979300", VA = "0x18397A100", Slot = "40")]
		public void WZKAZDILYEB<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8821560", Offset = "0x8820760", VA = "0x188821560")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(VIQRBGKASHK backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8820DC0", Offset = "0x881FFC0", VA = "0x188820DC0", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task OLIAYWXXAGC([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8820070", Offset = "0x881F270", VA = "0x188820070")]
		private void FNHFMHJPCOS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8820940", Offset = "0x881FB40", VA = "0x188820940", Slot = "41")]
		public IDisposable MTKCHTUJEGS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x88214A0", Offset = "0x88206A0", VA = "0x1888214A0", Slot = "42")]
		public void SUXXTINULJT(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x881FC00", Offset = "0x881EE00", VA = "0x18881FC00")]
		private void DWDXHGPRAIR(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8820860", Offset = "0x881FA60", VA = "0x188820860")]
		[IteratorStateMachine(typeof(NSDWQAFWJIP))]
		private IEnumerator<GVXKGQILIBM> IRIIBIELFTR(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8821460", Offset = "0x8820660", VA = "0x188821460")]
		[CompilerGenerated]
		private void SBHURODTFRS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class AHUUJSLEVXT
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8817370", Offset = "0x8816570", VA = "0x188817370")]
		public static string TILYBJFGJTQ(this SSXJQXLLVXB a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x88174E0", Offset = "0x88166E0", VA = "0x1888174E0")]
		public static byte[] WWQXHTWLNCC(this SSXJQXLLVXB a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8817260", Offset = "0x8816460", VA = "0x188817260")]
		public static SetResult KWUSLJXSHZY(this SSXJQXLLVXB a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AYTCGJPKSQQ : IYQVSTAWREU<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static AYTCGJPKSQQ DZRVHNEPLID
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x8817680", Offset = "0x8816880", VA = "0x188817680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x88176D0", Offset = "0x88168D0", VA = "0x1888176D0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x88177C0", Offset = "0x88169C0", VA = "0x1888177C0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8817AD0", Offset = "0x8816CD0", VA = "0x188817AD0")]
		public AYTCGJPKSQQ()
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
