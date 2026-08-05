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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C331A0", Offset = "0x9C31BA0", VA = "0x189C331A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFB750", Offset = "0xCFA150", VA = "0x180CFB750")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C330A0", Offset = "0x9C31AA0", VA = "0x189C330A0", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C3F060", Offset = "0x9C3DA60", VA = "0x189C3F060", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29F5EA0", Offset = "0x29F48A0", VA = "0x1829F5EA0")]
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
	internal static class YPCNBRBNUJO
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal delegate void CustomSaveHandler(MAEDEWEATHO backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E6B0", Offset = "0x9C3D0B0", VA = "0x189C3E6B0")]
		private static void BWXCGZHDMIP(MAEDEWEATHO a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9C3EC50", Offset = "0x9C3D650", VA = "0x189C3EC50")]
		public static bool QHBBPJKQROZ(this MAEDEWEATHO a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E870", Offset = "0x9C3D270", VA = "0x189C3E870")]
		public static SetResult FGOFAWVMRQM(this MAEDEWEATHO a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E9C0", Offset = "0x9C3D3C0", VA = "0x189C3E9C0")]
		public static SetResult HLKNKFVJXIU(this MAEDEWEATHO a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E730", Offset = "0x9C3D130", VA = "0x189C3E730")]
		public static SetResult DQQNPLREEJL(this MAEDEWEATHO a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9C3EB00", Offset = "0x9C3D500", VA = "0x189C3EB00")]
		public static SetResult QGPBYDGUJFN(this MAEDEWEATHO a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9C3EDB0", Offset = "0x9C3D7B0", VA = "0x189C3EDB0")]
		public static SetResult UQRAELGAPSE(this MAEDEWEATHO a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9C3EF20", Offset = "0x9C3D920", VA = "0x189C3EF20")]
		public static SetResult VAZMVLNCTLV(this MAEDEWEATHO a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class WWXNSMKQVLH : ZYZGCDYIPRX, MAEDEWEATHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log YPBIFIZOQDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly ZMWNMZQDNPW TRQELRXZZIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Dictionary<string, byte> DHIBJTBECRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Dictionary<string, string> AMCMDPKWVAA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool XGVRADRHOYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> SIMYHTLYCSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9C3DDC0", Offset = "0x9C3C7C0", VA = "0x189C3DDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action XZCGNIXOVPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E560", Offset = "0x9C3CF60", VA = "0x189C3E560")]
		[UnityEngine.Scripting.Preserve]
		public WWXNSMKQVLH([Inject(null)] ZMWNMZQDNPW unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "8")]
		public void GMLBQBLZGSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D6B0", Offset = "0x9C3C0B0", VA = "0x189C3D6B0")]
		private DirectoryInfo JFYELQRHWWU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9C3DCC0", Offset = "0x9C3C6C0", VA = "0x189C3DCC0", Slot = "6")]
		public Task UAOGRKUGASA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C0D0", Offset = "0x9C3AAD0", VA = "0x189C3C0D0", Slot = "14")]
		public float BLTYKOCWILM(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D500", Offset = "0x9C3BF00", VA = "0x189C3D500", Slot = "13")]
		public void HAKOZGCKHXS(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D430", Offset = "0x9C3BE30", VA = "0x189C3D430", Slot = "12")]
		public bool GPSPSLKAWSU(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C3B0", Offset = "0x9C3ADB0", VA = "0x189C3C3B0", Slot = "10")]
		public int DLJDDQLZGLD(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C340", Offset = "0x9C3AD40", VA = "0x189C3C340", Slot = "18")]
		public DateTime DILRHLWPVEB(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C2D0", Offset = "0x9C3ACD0", VA = "0x189C3C2D0", Slot = "19")]
		public void CQXSJVOXZKB(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9C3DD50", Offset = "0x9C3C750", VA = "0x189C3DD50", Slot = "15")]
		public void WSSXJXKYWXA(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D1A0", Offset = "0x9C3BBA0", VA = "0x189C3D1A0", Slot = "11")]
		public void EUCLLYCLDJH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D640", Offset = "0x9C3C040", VA = "0x189C3D640", Slot = "20")]
		public long IVXTURTHPRA(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C060", Offset = "0x9C3AA60", VA = "0x189C3C060", Slot = "21")]
		public void AFIBUOWSLBU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x40FFA50", Offset = "0x40FE450", VA = "0x1840FFA50", Slot = "22")]
		public a CEOSHHJBPJF<a>(string a, a b, XMNUSNLGNCS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4102670", Offset = "0x4101070", VA = "0x184102670", Slot = "23")]
		public void WQMUXHDHNAD<b>(string a, b b, XMNUSNLGNCS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E440", Offset = "0x9C3CE40", VA = "0x189C3E440", Slot = "16")]
		public string ZXWWRLSIAEB(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D5D0", Offset = "0x9C3BFD0", VA = "0x189C3D5D0", Slot = "17")]
		public void HYSXEIUJEAV(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D7A0", Offset = "0x9C3C1A0", VA = "0x189C3D7A0", Slot = "24")]
		public void MIMDBFUEDMS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C240", Offset = "0x9C3AC40", VA = "0x189C3C240", Slot = "9")]
		public bool CIJSKEHSURZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D980", Offset = "0x9C3C380", VA = "0x189C3D980", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9C3DE00", Offset = "0x9C3C800", VA = "0x189C3DE00")]
		private void YBWZTRFNQEO(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D210", Offset = "0x9C3BC10", VA = "0x189C3D210")]
		private static string GJDSCYIXJPJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C140", Offset = "0x9C3AB40", VA = "0x189C3C140")]
		private static string BWBYTFGCGGM(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x40FFC30", Offset = "0x40FE630", VA = "0x1840FFC30")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] XMNUSNLGNCS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x41013A0", Offset = "0x40FFDA0", VA = "0x1841013A0")]
		private void Set<T>(string propertyName, T value, [Optional] XMNUSNLGNCS<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C420", Offset = "0x9C3AE20", VA = "0x189C3C420")]
		private Dictionary<string, string> DVEZTXWCVTA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D570", Offset = "0x9C3BF70", VA = "0x189C3D570")]
		private void HYJETOENGSO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D910", Offset = "0x9C3C310", VA = "0x189C3D910")]
		private void RQAPUUWYNQN(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class RPXHNFLXAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log YPBIFIZOQDI;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9C36350", Offset = "0x9C34D50", VA = "0x189C36350")]
		[ONTQUCAGRJW.Root]
		internal static void ONTQUCAGRJW(KLUMUBWDFVY a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class EFZWFKEXIAG : VKJUBLFJXQP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9C31DC0", Offset = "0x9C307C0", VA = "0x189C31DC0")]
		[UnityEngine.Scripting.Preserve]
		public EFZWFKEXIAG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KYAEHXPLDXK : ZYZGCDYIPRX, MAEDEWEATHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly ZMWNMZQDNPW TRQELRXZZIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Dictionary<string, string> CTEJUTFNQBE;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool XGVRADRHOYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action XZCGNIXOVPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9C33000", Offset = "0x9C31A00", VA = "0x189C33000")]
		[UnityEngine.Scripting.Preserve]
		public KYAEHXPLDXK([Inject(null)] ZMWNMZQDNPW unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9C32E80", Offset = "0x9C31880", VA = "0x189C32E80", Slot = "6")]
		public Task UAOGRKUGASA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "8")]
		public void GMLBQBLZGSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9C32980", Offset = "0x9C31380", VA = "0x189C32980", Slot = "9")]
		public bool CIJSKEHSURZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9C32AC0", Offset = "0x9C314C0", VA = "0x189C32AC0", Slot = "10")]
		public int DLJDDQLZGLD(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9C32B30", Offset = "0x9C31530", VA = "0x189C32B30", Slot = "11")]
		public void EUCLLYCLDJH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9C32BA0", Offset = "0x9C315A0", VA = "0x189C32BA0", Slot = "12")]
		public bool GPSPSLKAWSU(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9C32C10", Offset = "0x9C31610", VA = "0x189C32C10", Slot = "13")]
		public void HAKOZGCKHXS(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9C32910", Offset = "0x9C31310", VA = "0x189C32910", Slot = "14")]
		public float BLTYKOCWILM(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9C32F10", Offset = "0x9C31910", VA = "0x189C32F10", Slot = "15")]
		public void WSSXJXKYWXA(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9C32F80", Offset = "0x9C31980", VA = "0x189C32F80", Slot = "16")]
		public string ZXWWRLSIAEB(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9C32C80", Offset = "0x9C31680", VA = "0x189C32C80", Slot = "17")]
		public void HYSXEIUJEAV(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9C32A50", Offset = "0x9C31450", VA = "0x189C32A50", Slot = "18")]
		public DateTime DILRHLWPVEB(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9C329E0", Offset = "0x9C313E0", VA = "0x189C329E0", Slot = "19")]
		public void CQXSJVOXZKB(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9C32CF0", Offset = "0x9C316F0", VA = "0x189C32CF0", Slot = "20")]
		public long IVXTURTHPRA(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9C328A0", Offset = "0x9C312A0", VA = "0x189C328A0", Slot = "21")]
		public void AFIBUOWSLBU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3BFFE90", Offset = "0x3BFE890", VA = "0x183BFFE90", Slot = "22")]
		public a CEOSHHJBPJF<a>(string a, a b, XMNUSNLGNCS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3C02AA0", Offset = "0x3C014A0", VA = "0x183C02AA0", Slot = "23")]
		public void WQMUXHDHNAD<b>(string a, b b, XMNUSNLGNCS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9C32D60", Offset = "0x9C31760", VA = "0x189C32D60", Slot = "24")]
		public void MIMDBFUEDMS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9C32DF0", Offset = "0x9C317F0", VA = "0x189C32DF0", Slot = "25")]
		public Task Save([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3C00070", Offset = "0x3BFEA70", VA = "0x183C00070")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] XMNUSNLGNCS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3C01860", Offset = "0x3C00260", VA = "0x183C01860")]
		private void Set<T>(string propertyName, T value, [Optional] XMNUSNLGNCS<T> parser)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class VKJUBLFJXQP : ZYZGCDYIPRX, MAEDEWEATHO, BLNIGADNRIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly Dictionary<string, object> LORTIRDGEBL;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool XGVRADRHOYC
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action XZCGNIXOVPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "8")]
		public void GMLBQBLZGSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9C391E0", Offset = "0x9C37BE0", VA = "0x189C391E0", Slot = "6")]
		public Task UAOGRKUGASA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9C38D90", Offset = "0x9C37790", VA = "0x189C38D90", Slot = "9")]
		public bool CIJSKEHSURZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9C38EB0", Offset = "0x9C378B0", VA = "0x189C38EB0", Slot = "10")]
		public int DLJDDQLZGLD(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9C38F10", Offset = "0x9C37910", VA = "0x189C38F10", Slot = "11")]
		public void EUCLLYCLDJH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9C38F70", Offset = "0x9C37970", VA = "0x189C38F70", Slot = "12")]
		public bool GPSPSLKAWSU(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9C38FD0", Offset = "0x9C379D0", VA = "0x189C38FD0", Slot = "13")]
		public void HAKOZGCKHXS(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9C38D30", Offset = "0x9C37730", VA = "0x189C38D30", Slot = "14")]
		public float BLTYKOCWILM(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9C39270", Offset = "0x9C37C70", VA = "0x189C39270", Slot = "15")]
		public void WSSXJXKYWXA(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9C392D0", Offset = "0x9C37CD0", VA = "0x189C392D0", Slot = "16")]
		public string ZXWWRLSIAEB(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9C39030", Offset = "0x9C37A30", VA = "0x189C39030", Slot = "17")]
		public void HYSXEIUJEAV(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9C38E50", Offset = "0x9C37850", VA = "0x189C38E50", Slot = "18")]
		public DateTime DILRHLWPVEB(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9C38DF0", Offset = "0x9C377F0", VA = "0x189C38DF0", Slot = "19")]
		public void CQXSJVOXZKB(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9C39090", Offset = "0x9C37A90", VA = "0x189C39090", Slot = "20")]
		public long IVXTURTHPRA(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9C38CD0", Offset = "0x9C376D0", VA = "0x189C38CD0", Slot = "21")]
		public void AFIBUOWSLBU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x40BAFC0", Offset = "0x40B99C0", VA = "0x1840BAFC0", Slot = "22")]
		public a CEOSHHJBPJF<a>(string a, a b, XMNUSNLGNCS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x40BC470", Offset = "0x40BAE70", VA = "0x1840BC470", Slot = "23")]
		public void WQMUXHDHNAD<b>(string a, b b, XMNUSNLGNCS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x40BB370", Offset = "0x40B9D70", VA = "0x1840BB370")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x40BBDD0", Offset = "0x40BA7D0", VA = "0x1840BBDD0")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9C390F0", Offset = "0x9C37AF0", VA = "0x189C390F0", Slot = "24")]
		public void MIMDBFUEDMS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9C39150", Offset = "0x9C37B50", VA = "0x189C39150", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9C31DC0", Offset = "0x9C307C0", VA = "0x189C31DC0")]
		public VKJUBLFJXQP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class IOWRIQBSCBQ<a> where a : MAEDEWEATHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly HashSet<IOWRIQBSCBQ<a>> ERSQILJRVCX;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x65FCCC0", Offset = "0x65FB6C0", VA = "0x1865FCCC0")]
		protected IOWRIQBSCBQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void GJMZXSSBIYC(string a);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x65FC8C0", Offset = "0x65FB2C0", VA = "0x1865FC8C0")]
		public static void SFDZQFVYKZO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x65FC180", Offset = "0x65FAB80", VA = "0x1865FC180")]
		public static void LSHXAWTPNQE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class IORKLJHUSQH<a, b> : IOWRIQBSCBQ<a> where a : MAEDEWEATHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly IORKLJHUSQH<a, b> KLCPKUHGTRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Dictionary<string, b> GHLCWCVFKTG;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x65FBA70", Offset = "0x65FA470", VA = "0x1865FBA70")]
		public bool IAMPTCAGJIA(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x65FBC10", Offset = "0x65FA610", VA = "0x1865FBC10")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
		public IEnumerable<KeyValuePair<string, b>> FIYPYJVWDLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x64DC6D0", Offset = "0x64DB0D0", VA = "0x1864DC6D0", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x65FB850", Offset = "0x65FA250", VA = "0x1865FB850", Slot = "5")]
		protected override void GJMZXSSBIYC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x65FC000", Offset = "0x65FAA00", VA = "0x1865FC000")]
		public IORKLJHUSQH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface MAEDEWEATHO
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool XGVRADRHOYC
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GMLBQBLZGSG();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CIJSKEHSURZ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int DLJDDQLZGLD(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EUCLLYCLDJH(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool GPSPSLKAWSU(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void HAKOZGCKHXS(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float BLTYKOCWILM(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void WSSXJXKYWXA(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string ZXWWRLSIAEB(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void HYSXEIUJEAV(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime DILRHLWPVEB(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void CQXSJVOXZKB(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long IVXTURTHPRA(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void AFIBUOWSLBU(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a CEOSHHJBPJF<a>(string a, a b, XMNUSNLGNCS<a> c);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void WQMUXHDHNAD<b>(string a, b b, XMNUSNLGNCS<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void MIMDBFUEDMS(string a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface ZYZGCDYIPRX : MAEDEWEATHO
	{
		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action XZCGNIXOVPK;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task UAOGRKUGASA(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface BLNIGADNRIJ : MAEDEWEATHO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class WEQPTAPCPYH : ZYZGCDYIPRX, MAEDEWEATHO
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
			public WEQPTAPCPYH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9C37EB0", Offset = "0x9C368B0", VA = "0x189C37EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9C38270", Offset = "0x9C36C70", VA = "0x189C38270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class DZFKNIHRFWB : IEnumerator<PESYKSMCDNI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private PESYKSMCDNI AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public WEQPTAPCPYH AFKVCRAYCVS;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private PESYKSMCDNI TPPDVWBUFIZ
			{
				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xCD8B10", Offset = "0xCD7510", VA = "0x180CD8B10")]
			[DebuggerHidden]
			public DZFKNIHRFWB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9C31D10", Offset = "0x9C30710", VA = "0x189C31D10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9C31D80", Offset = "0x9C30780", VA = "0x189C31D80", Slot = "8")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly Log YPBIFIZOQDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly ZMWNMZQDNPW TRQELRXZZIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool AURPNQOXFAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool AKVITEZZJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private HIVJVEKFYXO KYNXOFCTFQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private AMGSXYCAQOJ YSFHOZSDUML;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool XGVRADRHOYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action XZCGNIXOVPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9C3BF60", Offset = "0x9C3A960", VA = "0x189C3BF60")]
		[UnityEngine.Scripting.Preserve]
		public WEQPTAPCPYH([Inject(null)] ZMWNMZQDNPW unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "8")]
		public void GMLBQBLZGSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9C3BAF0", Offset = "0x9C3A4F0", VA = "0x189C3BAF0", Slot = "6")]
		public Task UAOGRKUGASA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1E7E1B0", Offset = "0x1E7CBB0", VA = "0x181E7E1B0")]
		private static int NDOOHOTYCNM(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9C3AE20", Offset = "0x9C39820", VA = "0x189C3AE20", Slot = "9")]
		public bool CIJSKEHSURZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9C3AF90", Offset = "0x9C39990", VA = "0x189C3AF90", Slot = "10")]
		public int DLJDDQLZGLD(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B1F0", Offset = "0x9C39BF0", VA = "0x189C3B1F0", Slot = "11")]
		public void EUCLLYCLDJH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B4C0", Offset = "0x9C39EC0", VA = "0x189C3B4C0", Slot = "12")]
		public bool GPSPSLKAWSU(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B610", Offset = "0x9C3A010", VA = "0x189C3B610", Slot = "13")]
		public void HAKOZGCKHXS(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9C393A0", Offset = "0x9C37DA0", VA = "0x189C393A0", Slot = "14")]
		public float BLTYKOCWILM(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9C3BBE0", Offset = "0x9C3A5E0", VA = "0x189C3BBE0", Slot = "15")]
		public void WSSXJXKYWXA(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9C3AF20", Offset = "0x9C39920", VA = "0x189C3AF20", Slot = "18")]
		public DateTime DILRHLWPVEB(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9C3AE40", Offset = "0x9C39840", VA = "0x189C3AE40", Slot = "19")]
		public void CQXSJVOXZKB(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B890", Offset = "0x9C3A290", VA = "0x189C3B890", Slot = "20")]
		public long IVXTURTHPRA(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9C39330", Offset = "0x9C37D30", VA = "0x189C39330", Slot = "21")]
		public void AFIBUOWSLBU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x40F7790", Offset = "0x40F6190", VA = "0x1840F7790", Slot = "22")]
		public a CEOSHHJBPJF<a>(string a, a b, XMNUSNLGNCS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x40F9480", Offset = "0x40F7E80", VA = "0x1840F9480", Slot = "23")]
		public void WQMUXHDHNAD<b>(string a, b b, XMNUSNLGNCS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x40F8320", Offset = "0x40F6D20", VA = "0x1840F8320")]
		private c MFOENVWMTWW<c>(string a, c b, [Optional] XMNUSNLGNCS<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x40F7990", Offset = "0x40F6390", VA = "0x1840F7990")]
		private void EKEBARERRIO<d>(string a, d b, [Optional] XMNUSNLGNCS<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9C3BD40", Offset = "0x9C3A740", VA = "0x189C3BD40", Slot = "16")]
		public string ZXWWRLSIAEB(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B760", Offset = "0x9C3A160", VA = "0x189C3B760", Slot = "17")]
		public void HYSXEIUJEAV(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B0C0", Offset = "0x9C39AC0", VA = "0x189C3B0C0")]
		private void DLSGPFVINOY(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B310", Offset = "0x9C39D10", VA = "0x189C3B310")]
		private string FCAPXCDEUUE(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B900", Offset = "0x9C3A300", VA = "0x189C3B900", Slot = "24")]
		public void MIMDBFUEDMS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9C3BCA0", Offset = "0x9C3A6A0", VA = "0x189C3BCA0")]
		private string YGMECAREDCK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9C394D0", Offset = "0x9C37ED0", VA = "0x189C394D0")]
		public void CHTBKJBCALH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9C3BB80", Offset = "0x9C3A580", VA = "0x189C3BB80", Slot = "26")]
		public void USYWXECIYRA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9C3BA00", Offset = "0x9C3A400", VA = "0x189C3BA00", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__40))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9C3AEB0", Offset = "0x9C398B0", VA = "0x189C3AEB0")]
		[IteratorStateMachine(typeof(DZFKNIHRFWB))]
		private IEnumerator<PESYKSMCDNI> DICHDMZSSLU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B2B0", Offset = "0x9C39CB0", VA = "0x189C3B2B0")]
		private void EWTIOQWAWCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B6F0", Offset = "0x9C3A0F0", VA = "0x189C3B6F0")]
		private void HYJETOENGSO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B990", Offset = "0x9C3A390", VA = "0x189C3B990")]
		private void RQAPUUWYNQN(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class SFHEUVAHGYP : ZYZGCDYIPRX, MAEDEWEATHO
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
		private Dictionary<string, string> AMCMDPKWVAA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool XGVRADRHOYC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string HMETGHEOROT
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x9C36600", Offset = "0x9C35000", VA = "0x189C36600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private string BXLRRSHFPYB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9C36C10", Offset = "0x9C35610", VA = "0x189C36C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Dictionary<string, string> SIMYHTLYCSK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x9C37380", Offset = "0x9C35D80", VA = "0x189C37380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action XZCGNIXOVPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		[UnityEngine.Scripting.Preserve]
		public SFHEUVAHGYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "8")]
		public void GMLBQBLZGSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9C37280", Offset = "0x9C35C80", VA = "0x189C37280", Slot = "6")]
		public Task UAOGRKUGASA(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9C36690", Offset = "0x9C35090", VA = "0x189C36690", Slot = "14")]
		public float BLTYKOCWILM(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9C36DE0", Offset = "0x9C357E0", VA = "0x189C36DE0", Slot = "13")]
		public void HAKOZGCKHXS(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9C36D10", Offset = "0x9C35710", VA = "0x189C36D10", Slot = "12")]
		public bool GPSPSLKAWSU(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9C36870", Offset = "0x9C35270", VA = "0x189C36870", Slot = "10")]
		public int DLJDDQLZGLD(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9C36800", Offset = "0x9C35200", VA = "0x189C36800", Slot = "18")]
		public DateTime DILRHLWPVEB(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9C36790", Offset = "0x9C35190", VA = "0x189C36790", Slot = "19")]
		public void CQXSJVOXZKB(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9C37310", Offset = "0x9C35D10", VA = "0x189C37310", Slot = "15")]
		public void WSSXJXKYWXA(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9C36CA0", Offset = "0x9C356A0", VA = "0x189C36CA0", Slot = "11")]
		public void EUCLLYCLDJH(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9C36EF0", Offset = "0x9C358F0", VA = "0x189C36EF0", Slot = "20")]
		public long IVXTURTHPRA(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9C36590", Offset = "0x9C34F90", VA = "0x189C36590", Slot = "21")]
		public void AFIBUOWSLBU(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3F06EB0", Offset = "0x3F058B0", VA = "0x183F06EB0", Slot = "22")]
		public a CEOSHHJBPJF<a>(string a, a b, XMNUSNLGNCS<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3F09A60", Offset = "0x3F08460", VA = "0x183F09A60", Slot = "23")]
		public void WQMUXHDHNAD<b>(string a, b b, XMNUSNLGNCS<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9C373C0", Offset = "0x9C35DC0", VA = "0x189C373C0", Slot = "16")]
		public string ZXWWRLSIAEB(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9C36E50", Offset = "0x9C35850", VA = "0x189C36E50", Slot = "17")]
		public void HYSXEIUJEAV(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9C36F60", Offset = "0x9C35960", VA = "0x189C36F60", Slot = "24")]
		public void MIMDBFUEDMS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9C36700", Offset = "0x9C35100", VA = "0x189C36700", Slot = "9")]
		public bool CIJSKEHSURZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9C37020", Offset = "0x9C35A20", VA = "0x189C37020", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3F07090", Offset = "0x3F05A90", VA = "0x183F07090")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] XMNUSNLGNCS<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3F08880", Offset = "0x3F07280", VA = "0x183F08880")]
		private void Set<T>(string propertyName, T value, [Optional] XMNUSNLGNCS<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9C368E0", Offset = "0x9C352E0", VA = "0x189C368E0")]
		private Dictionary<string, string> DVEZTXWCVTA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface STAKPLUPOSH
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action XZCGNIXOVPK;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GMLBQBLZGSG();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task TEAIKVUKCBW(long a);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool BONJATKWTZK(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool ICZAQRUVMNI(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DYMVMNNRAAZ(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string KYDAKNFLOAK(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult MTNGMPZFSIW(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int DRZZEBAXMYY(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult STJNHIVICVS(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool YCHEJHZSZXB(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult DGVOBEZJIIP(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float QHTVVNRRVSL(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult ATAYPUGNJBB(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime JFQRVBQZRYW(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult TACYQKNDZDM(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long MNIEYDUDEQB(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult UEEZCHWYXOV(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a KHTZNUADIBS<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult KOIGJQRIZLG<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool ZCFMTRZVSAU(string a);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool JWNXNXMNZMR(string a);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string JBQQHZDEQRS(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult ZWMTZYLZACM(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int CJLEDTSQXGK(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult OZHIKCMRVIS(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool YLJIBDHBWYB(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult BYRAFCRYUNL(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float NWBYZUNXKFH(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult KJLBCFVUZFP(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime SWZHRUAPJGE(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult RCRRBVYDRAU(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long VXUIFIHCIEH(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult BLIORKEOAJZ(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void ZCKLZZKBCFU<e>(XMNUSNLGNCS<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void DWCUHRRDROR<f>();

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable DJAVXWAWGUO();

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void UTTDISFDWVP(float a);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task EWTIOQWAWCC([Optional] CancellationToken a);
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
	public class Preferences : STAKPLUPOSH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private abstract class TEUFJUZEPQV
		{
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			protected static readonly HashSet<TEUFJUZEPQV> VAFCXYUOWUU;

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9C37470", Offset = "0x9C35E70", VA = "0x189C37470")]
			public static void LSHXAWTPNQE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			protected TEUFJUZEPQV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private class VBAPZYZWYVE<a> : TEUFJUZEPQV
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly VBAPZYZWYVE<a> IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public XMNUSNLGNCS<a> NPRFJTSKYLV
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public IEqualityComparer<a> AZVXEEDKYQP
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xCD8E10", Offset = "0xCD7810", VA = "0x180CD8E10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool FQLONXFJXEQ
			{
				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xE6D740", Offset = "0xE6C140", VA = "0x180E6D740")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x7EADB80", Offset = "0x7EAC580", VA = "0x187EADB80")]
			private VBAPZYZWYVE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x7EAD190", Offset = "0x7EABB90", VA = "0x187EAD190")]
			public void QCIVJGOFOSZ(XMNUSNLGNCS<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x1013D00", Offset = "0x1012700", VA = "0x181013D00", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private class GTHVIRLPBSZ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private readonly Preferences PYOUHBOYEAW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private readonly object WRMCSTIDWGY;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9C31E70", Offset = "0x9C30870", VA = "0x189C31E70")]
			public GTHVIRLPBSZ(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9C31E40", Offset = "0x9C30840", VA = "0x189C31E40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C37640", Offset = "0x9C36040", VA = "0x189C37640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x9C37920", Offset = "0x9C36320", VA = "0x189C37920", Slot = "5")]
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
			public MAEDEWEATHO backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x9C382D0", Offset = "0x9C36CD0", VA = "0x189C382D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xD34AE0", Offset = "0xD334E0", VA = "0x180D34AE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C37980", Offset = "0x9C36380", VA = "0x189C37980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x9C37E50", Offset = "0x9C36850", VA = "0x189C37E50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class GXSIOZAIKLV : IEnumerator<PESYKSMCDNI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private PESYKSMCDNI AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Preferences AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float KLPMZWMRNIN;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private PESYKSMCDNI TPPDVWBUFIZ
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xCD8B10", Offset = "0xCD7510", VA = "0x180CD8B10")]
			[DebuggerHidden]
			public GXSIOZAIKLV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x9C31F20", Offset = "0x9C30920", VA = "0x189C31F20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9C31FB0", Offset = "0x9C309B0", VA = "0x189C31FB0", Slot = "8")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly ZYZGCDYIPRX SDCKZJNVLOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly ZYZGCDYIPRX MZPTOIPSCUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly BLNIGADNRIJ VGPCLHYFTDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly HIVJVEKFYXO KYNXOFCTFQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly YPCNBRBNUJO.CustomSaveHandler VZSPWAEABRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly OZHUFMCFCAS MSBMJONYQYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly HashSet<MAEDEWEATHO> ELLKCWLGDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Task KXDPJRTIISR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<string, string> VZWVHWVVMMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private AMGSXYCAQOJ WBUEMDMYRYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly object GOICUSRMALG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly object CCRPTWDLWYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long TLKWEISWSIG;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool LBGXLUHNURO
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x1A595E0", Offset = "0x1A57FE0", VA = "0x181A595E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private CancellationTokenSource CKTQPPFOULH
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xCD5930", Offset = "0xCD4330", VA = "0x180CD5930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xCD5910", Offset = "0xCD4310", VA = "0x180CD5910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action XZCGNIXOVPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9C337F0", Offset = "0x9C321F0", VA = "0x189C337F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9C35AD0", Offset = "0x9C344D0", VA = "0x189C35AD0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9C34E00", Offset = "0x9C33800", VA = "0x189C34E00")]
		[ONTQUCAGRJW.Root]
		internal static void NVOLZDRLLVN(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9C35FC0", Offset = "0x9C349C0", VA = "0x189C35FC0")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] ZYZGCDYIPRX localBackingStore, [Inject("Cloud")] ZYZGCDYIPRX cloudBackingStore, [Inject(null)] BLNIGADNRIJ editorBackingStore, [Inject(null)] HIVJVEKFYXO scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9C33F60", Offset = "0x9C32960", VA = "0x189C33F60", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9C35740", Offset = "0x9C34140", VA = "0x189C35740")]
		private void TBMRSXPLMJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9C34090", Offset = "0x9C32A90", VA = "0x189C34090", Slot = "6")]
		public void GMLBQBLZGSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9C35790", Offset = "0x9C34190", VA = "0x189C35790", Slot = "7")]
		public Task TEAIKVUKCBW(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9C34CF0", Offset = "0x9C336F0", VA = "0x189C34CF0")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task NLIIDWVWNYJ(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9C33510", Offset = "0x9C31F10", VA = "0x189C33510")]
		private void BBQXQRYTPTK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9C34270", Offset = "0x9C32C70", VA = "0x189C34270")]
		private void HMOBKCELSKR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9C35B80", Offset = "0x9C34580", VA = "0x189C35B80")]
		private string VTAAVCFYDPG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9C34390", Offset = "0x9C32D90", VA = "0x189C34390")]
		private void INZMRNIVMDQ(AccountPreferenceBackingStoreTypes a, string b, [Out] ZYZGCDYIPRX c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9C35D90", Offset = "0x9C34790", VA = "0x189C35D90")]
		private ZYZGCDYIPRX XTQKAEWVWFE(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9C33740", Offset = "0x9C32140", VA = "0x189C33740", Slot = "8")]
		public bool BONJATKWTZK(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9C342F0", Offset = "0x9C32CF0", VA = "0x189C342F0", Slot = "9")]
		public bool ICZAQRUVMNI(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9C33DE0", Offset = "0x9C327E0", VA = "0x189C33DE0", Slot = "10")]
		public bool DYMVMNNRAAZ(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9C348E0", Offset = "0x9C332E0", VA = "0x189C348E0", Slot = "11")]
		public string KYDAKNFLOAK(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9C34B70", Offset = "0x9C33570", VA = "0x189C34B70", Slot = "12")]
		public SetResult MTNGMPZFSIW(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9C33CD0", Offset = "0x9C326D0", VA = "0x189C33CD0", Slot = "13")]
		public int DRZZEBAXMYY(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9C352F0", Offset = "0x9C33CF0", VA = "0x189C352F0", Slot = "14")]
		public SetResult STJNHIVICVS(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9C35E10", Offset = "0x9C34810", VA = "0x189C35E10", Slot = "15")]
		public bool YCHEJHZSZXB(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9C33930", Offset = "0x9C32330", VA = "0x189C33930", Slot = "16")]
		public SetResult DGVOBEZJIIP(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9C35190", Offset = "0x9C33B90", VA = "0x189C35190", Slot = "17")]
		public float QHTVVNRRVSL(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9C33220", Offset = "0x9C31C20", VA = "0x189C33220", Slot = "18")]
		public SetResult ATAYPUGNJBB(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9C345A0", Offset = "0x9C32FA0", VA = "0x189C345A0", Slot = "19")]
		public DateTime JFQRVBQZRYW(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9C355A0", Offset = "0x9C33FA0", VA = "0x189C355A0", Slot = "20")]
		public SetResult TACYQKNDZDM(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9C34AD0", Offset = "0x9C334D0", VA = "0x189C34AD0", Slot = "21")]
		public long MNIEYDUDEQB(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9C35960", Offset = "0x9C34360", VA = "0x189C35960", Slot = "22")]
		public SetResult UEEZCHWYXOV(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1340", Offset = "0x3DBFD40", VA = "0x183DC1340", Slot = "23")]
		public a KHTZNUADIBS<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1A10", Offset = "0x3DC0410", VA = "0x183DC1A10", Slot = "24")]
		public SetResult KOIGJQRIZLG<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9C35F30", Offset = "0x9C34930", VA = "0x189C35F30", Slot = "25")]
		public bool ZCFMTRZVSAU(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9C34640", Offset = "0x9C33040", VA = "0x189C34640", Slot = "26")]
		public bool JWNXNXMNZMR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9C34530", Offset = "0x9C32F30", VA = "0x189C34530", Slot = "27")]
		public string JBQQHZDEQRS(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9C35F90", Offset = "0x9C34990", VA = "0x189C35F90", Slot = "28")]
		public SetResult ZWMTZYLZACM(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9C338C0", Offset = "0x9C322C0", VA = "0x189C338C0", Slot = "29")]
		public int CJLEDTSQXGK(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9C35020", Offset = "0x9C33A20", VA = "0x189C35020", Slot = "30")]
		public SetResult OZHIKCMRVIS(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9C35EC0", Offset = "0x9C348C0", VA = "0x189C35EC0", Slot = "31")]
		public bool YLJIBDHBWYB(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9C33890", Offset = "0x9C32290", VA = "0x189C33890", Slot = "32")]
		public SetResult BYRAFCRYUNL(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9C34E70", Offset = "0x9C33870", VA = "0x189C34E70", Slot = "33")]
		public float NWBYZUNXKFH(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9C348B0", Offset = "0x9C332B0", VA = "0x189C348B0", Slot = "34")]
		public SetResult KJLBCFVUZFP(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9C35460", Offset = "0x9C33E60", VA = "0x189C35460", Slot = "35")]
		public DateTime SWZHRUAPJGE(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9C352C0", Offset = "0x9C33CC0", VA = "0x189C352C0", Slot = "36")]
		public SetResult RCRRBVYDRAU(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9C35BE0", Offset = "0x9C345E0", VA = "0x189C35BE0", Slot = "37")]
		public long VXUIFIHCIEH(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9C33710", Offset = "0x9C32110", VA = "0x189C33710", Slot = "38")]
		public SetResult BLIORKEOAJZ(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9C33D80", Offset = "0x9C32780", VA = "0x189C33D80")]
		private bool DTXJSDPVZFW(MAEDEWEATHO a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9C33B70", Offset = "0x9C32570", VA = "0x189C33B70")]
		private bool DORHBOWXNDV(MAEDEWEATHO a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9C34980", Offset = "0x9C33380", VA = "0x189C34980")]
		private SetResult MEXEFCADRZX(MAEDEWEATHO a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9C35050", Offset = "0x9C33A50", VA = "0x189C35050")]
		private SetResult PZGLGRZWIQV(MAEDEWEATHO a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9C34100", Offset = "0x9C32B00", VA = "0x189C34100")]
		private SetResult GMRXDEWOSEE(MAEDEWEATHO a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9C35C50", Offset = "0x9C34650", VA = "0x189C35C50")]
		private SetResult XROPQRIREJE(MAEDEWEATHO a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9C333A0", Offset = "0x9C31DA0", VA = "0x189C333A0")]
		private SetResult AXPDCJQIYCV(MAEDEWEATHO a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9C34EE0", Offset = "0x9C338E0", VA = "0x189C34EE0")]
		private SetResult ORWHKLRVQJI(MAEDEWEATHO a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0C80", Offset = "0x3DBF680", VA = "0x183DC0C80")]
		private e CUPIOKCAQDN<e>(MAEDEWEATHO a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2450", Offset = "0x3DC0E50", VA = "0x183DC2450")]
		private SetResult ZTXWNJTTUTZ<f>(MAEDEWEATHO a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1CE0", Offset = "0x3DC06E0", VA = "0x183DC1CE0", Slot = "39")]
		public void ZCKLZZKBCFU<g>(XMNUSNLGNCS<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC1120", Offset = "0x3DBFB20", VA = "0x183DC1120", Slot = "40")]
		public void DWCUHRRDROR<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9C354D0", Offset = "0x9C33ED0", VA = "0x189C354D0")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(MAEDEWEATHO backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9C33FA0", Offset = "0x9C329A0", VA = "0x189C33FA0", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task EWTIOQWAWCC([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9C33530", Offset = "0x9C31F30", VA = "0x189C33530")]
		private void BJIJVARXANM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9C33AA0", Offset = "0x9C324A0", VA = "0x189C33AA0", Slot = "41")]
		public IDisposable DJAVXWAWGUO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9C35B70", Offset = "0x9C34570", VA = "0x189C35B70", Slot = "42")]
		public void UTTDISFDWVP(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9C34650", Offset = "0x9C33050", VA = "0x189C34650")]
		private void KCZZAUSBHXH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9C35240", Offset = "0x9C33C40", VA = "0x189C35240")]
		[IteratorStateMachine(typeof(GXSIOZAIKLV))]
		private IEnumerator<PESYKSMCDNI> QSLAKUXSETV(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9C34240", Offset = "0x9C32C40", VA = "0x189C34240")]
		[CompilerGenerated]
		private void HCLPUALJGTS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class IWVKLSHGGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9C32730", Offset = "0x9C31130", VA = "0x189C32730")]
		public static string VZHQQVXKFIW(this STAKPLUPOSH a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9C32480", Offset = "0x9C30E80", VA = "0x189C32480")]
		public static byte[] IMWCTDKCFPQ(this STAKPLUPOSH a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9C32620", Offset = "0x9C31020", VA = "0x189C32620")]
		public static SetResult LPCVDHIWZTU(this STAKPLUPOSH a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class HQWSNDABMLK : DCDRIKKOMXS<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static HQWSNDABMLK IWMDTGRRYAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x9C31FF0", Offset = "0x9C309F0", VA = "0x189C31FF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9C32040", Offset = "0x9C30A40", VA = "0x189C32040", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9C32130", Offset = "0x9C30B30", VA = "0x189C32130", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9C32440", Offset = "0x9C30E40", VA = "0x189C32440")]
		public HQWSNDABMLK()
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
