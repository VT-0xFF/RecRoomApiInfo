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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C34EF0", Offset = "0x9C33CF0", VA = "0x189C34EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C34BB0", Offset = "0x9C339B0", VA = "0x189C34BB0", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C40F60", Offset = "0x9C3FD60", VA = "0x189C40F60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29EF0F0", Offset = "0x29EDEF0", VA = "0x1829EF0F0")]
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
	internal static class OULRLZKTCJT
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal delegate void CustomSaveHandler(JZVAHTBZCLJ backingStore);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9C35600", Offset = "0x9C34400", VA = "0x189C35600")]
		private static void TZPQQDAASES(JZVAHTBZCLJ a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9C357C0", Offset = "0x9C345C0", VA = "0x189C357C0")]
		public static bool XWIHWMSTLSM(this JZVAHTBZCLJ a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9C350E0", Offset = "0x9C33EE0", VA = "0x189C350E0")]
		public static SetResult GEWRUOICSXB(this JZVAHTBZCLJ a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9C35680", Offset = "0x9C34480", VA = "0x189C35680")]
		public static SetResult WTYTCJNPUPD(this JZVAHTBZCLJ a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9C35370", Offset = "0x9C34170", VA = "0x189C35370")]
		public static SetResult JDIGNYZITNM(this JZVAHTBZCLJ a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9C354B0", Offset = "0x9C342B0", VA = "0x189C354B0")]
		public static SetResult SLUGNDINZOS(this JZVAHTBZCLJ a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9C34F70", Offset = "0x9C33D70", VA = "0x189C34F70")]
		public static SetResult AVSYEOROLMD(this JZVAHTBZCLJ a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9C35230", Offset = "0x9C34030", VA = "0x189C35230")]
		public static SetResult GYBLDMLHMOY(this JZVAHTBZCLJ a, string b, long c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class TDDGDJNSAAY : ZXCRVALKLPG, JZVAHTBZCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log ALDXGIVBEKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly EYDDAZPVOJX YOXAIEZHHLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Dictionary<string, byte> UOWJMAWPYCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Dictionary<string, string> OQQBXCDHRZX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool YJTUVSGDJFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> LBWTJHUUQYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9C3C4F0", Offset = "0x9C3B2F0", VA = "0x189C3C4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action CBHZTHOUXMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E2E0", Offset = "0x9C3D0E0", VA = "0x189C3E2E0")]
		[UnityEngine.Scripting.Preserve]
		public TDDGDJNSAAY([Inject(null)] EYDDAZPVOJX unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "8")]
		public void OBIEGUWIDOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C0A0", Offset = "0x9C3AEA0", VA = "0x189C3C0A0")]
		private DirectoryInfo EPBWPWFVQNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C530", Offset = "0x9C3B330", VA = "0x189C3C530", Slot = "6")]
		public Task RZHOWJXVQBB(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D980", Offset = "0x9C3C780", VA = "0x189C3D980", Slot = "14")]
		public float TSTRHRCZTET(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C030", Offset = "0x9C3AE30", VA = "0x189C3C030", Slot = "13")]
		public void DRCOXKZCMYL(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E1A0", Offset = "0x9C3CFA0", VA = "0x189C3E1A0", Slot = "12")]
		public bool YSPTQUMSMXJ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D910", Offset = "0x9C3C710", VA = "0x189C3D910", Slot = "10")]
		public int TJALRFIUNJW(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C240", Offset = "0x9C3B040", VA = "0x189C3C240", Slot = "18")]
		public DateTime JIFGKFHUIJE(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C3F0", Offset = "0x9C3B1F0", VA = "0x189C3C3F0", Slot = "19")]
		public void PMAPKMQQFXY(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9C3BDE0", Offset = "0x9C3ABE0", VA = "0x189C3BDE0", Slot = "15")]
		public void BFCIKGCDHFF(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9C3BE50", Offset = "0x9C3AC50", VA = "0x189C3BE50", Slot = "11")]
		public void BJDRIVQTAAI(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C380", Offset = "0x9C3B180", VA = "0x189C3C380", Slot = "20")]
		public long NEBMHJJYLEB(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C5C0", Offset = "0x9C3B3C0", VA = "0x189C3C5C0", Slot = "21")]
		public void SCDPMGTMRRL(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3F46C70", Offset = "0x3F45A70", VA = "0x183F46C70", Slot = "22")]
		public a SHZBBWFFKOU<a>(string a, a b, OHSUVITLQCJ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3F48120", Offset = "0x3F46F20", VA = "0x183F48120", Slot = "23")]
		public void UYDXXCAFNXC<b>(string a, b b, OHSUVITLQCJ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C190", Offset = "0x9C3AF90", VA = "0x189C3C190", Slot = "16")]
		public string HCRODWCQXOW(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C2B0", Offset = "0x9C3B0B0", VA = "0x189C3C2B0", Slot = "17")]
		public void KCFDDMXHRMW(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E030", Offset = "0x9C3CE30", VA = "0x189C3E030", Slot = "24")]
		public void XPCMVAWLTJX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C460", Offset = "0x9C3B260", VA = "0x189C3C460", Slot = "9")]
		public bool PXXJGFSTPWG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C850", Offset = "0x9C3B650", VA = "0x189C3C850", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9C3D9F0", Offset = "0x9C3C7F0", VA = "0x189C3D9F0")]
		private void VDVANOCFCRD(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C630", Offset = "0x9C3B430", VA = "0x189C3C630")]
		private static string SGWHUEIBURK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C3BEC0", Offset = "0x9C3ACC0", VA = "0x189C3BEC0")]
		private static string BXQZXZAXAJX(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3F45500", Offset = "0x3F44300", VA = "0x183F45500")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] OHSUVITLQCJ<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3F46E50", Offset = "0x3F45C50", VA = "0x183F46E50")]
		private void Set<T>(string propertyName, T value, [Optional] OHSUVITLQCJ<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9C3CB90", Offset = "0x9C3B990", VA = "0x189C3CB90")]
		private Dictionary<string, string> TANACEPQWMZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9C3C320", Offset = "0x9C3B120", VA = "0x189C3C320")]
		private void KOJOQDYAVPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9C3BFC0", Offset = "0x9C3ADC0", VA = "0x189C3BFC0")]
		private void CFTJUOFVVGC(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class MIPHJXLDVEG
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log ALDXGIVBEKZ;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9C34CB0", Offset = "0x9C33AB0", VA = "0x189C34CB0")]
		[CXDXQIFYXBD.Root]
		internal static void CXDXQIFYXBD(MZEBANDYSXL a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class TFQAQGPBFGD : ITNWMDIZCGO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9C34B30", Offset = "0x9C33930", VA = "0x189C34B30")]
		[UnityEngine.Scripting.Preserve]
		public TFQAQGPBFGD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AAUCTLGJIFR : ZXCRVALKLPG, JZVAHTBZCLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly EYDDAZPVOJX YOXAIEZHHLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Dictionary<string, string> VDZIEOYEWJD;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool YJTUVSGDJFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action CBHZTHOUXMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9C34360", Offset = "0x9C33160", VA = "0x189C34360")]
		[UnityEngine.Scripting.Preserve]
		public AAUCTLGJIFR([Inject(null)] EYDDAZPVOJX unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9C33FF0", Offset = "0x9C32DF0", VA = "0x189C33FF0", Slot = "6")]
		public Task RZHOWJXVQBB(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "8")]
		public void OBIEGUWIDOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9C33F90", Offset = "0x9C32D90", VA = "0x189C33F90", Slot = "9")]
		public bool PXXJGFSTPWG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9C34180", Offset = "0x9C32F80", VA = "0x189C34180", Slot = "10")]
		public int TJALRFIUNJW(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9C33C70", Offset = "0x9C32A70", VA = "0x189C33C70", Slot = "11")]
		public void BJDRIVQTAAI(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9C342F0", Offset = "0x9C330F0", VA = "0x189C342F0", Slot = "12")]
		public bool YSPTQUMSMXJ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9C33CE0", Offset = "0x9C32AE0", VA = "0x189C33CE0", Slot = "13")]
		public void DRCOXKZCMYL(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9C341F0", Offset = "0x9C32FF0", VA = "0x189C341F0", Slot = "14")]
		public float TSTRHRCZTET(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9C33C00", Offset = "0x9C32A00", VA = "0x189C33C00", Slot = "15")]
		public void BFCIKGCDHFF(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9C33D50", Offset = "0x9C32B50", VA = "0x189C33D50", Slot = "16")]
		public string HCRODWCQXOW(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9C33E40", Offset = "0x9C32C40", VA = "0x189C33E40", Slot = "17")]
		public void KCFDDMXHRMW(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9C33DD0", Offset = "0x9C32BD0", VA = "0x189C33DD0", Slot = "18")]
		public DateTime JIFGKFHUIJE(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9C33F20", Offset = "0x9C32D20", VA = "0x189C33F20", Slot = "19")]
		public void PMAPKMQQFXY(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9C33EB0", Offset = "0x9C32CB0", VA = "0x189C33EB0", Slot = "20")]
		public long NEBMHJJYLEB(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9C34080", Offset = "0x9C32E80", VA = "0x189C34080", Slot = "21")]
		public void SCDPMGTMRRL(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x335E890", Offset = "0x335D690", VA = "0x18335E890", Slot = "22")]
		public a SHZBBWFFKOU<a>(string a, a b, OHSUVITLQCJ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x335FCB0", Offset = "0x335EAB0", VA = "0x18335FCB0", Slot = "23")]
		public void UYDXXCAFNXC<b>(string a, b b, OHSUVITLQCJ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9C34260", Offset = "0x9C33060", VA = "0x189C34260", Slot = "24")]
		public void XPCMVAWLTJX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9C340F0", Offset = "0x9C32EF0", VA = "0x189C340F0", Slot = "25")]
		public Task Save([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x335CF80", Offset = "0x335BD80", VA = "0x18335CF80")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] OHSUVITLQCJ<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x335EA70", Offset = "0x335D870", VA = "0x18335EA70")]
		private void Set<T>(string propertyName, T value, [Optional] OHSUVITLQCJ<T> parser)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ITNWMDIZCGO : ZXCRVALKLPG, JZVAHTBZCLJ, IPBHQHBMINE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly Dictionary<string, object> ZZCERCEJWYC;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool YJTUVSGDJFT
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action CBHZTHOUXMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "8")]
		public void OBIEGUWIDOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9C34830", Offset = "0x9C33630", VA = "0x189C34830", Slot = "6")]
		public Task RZHOWJXVQBB(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9C347D0", Offset = "0x9C335D0", VA = "0x189C347D0", Slot = "9")]
		public bool PXXJGFSTPWG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9C349B0", Offset = "0x9C337B0", VA = "0x189C349B0", Slot = "10")]
		public int TJALRFIUNJW(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9C34530", Offset = "0x9C33330", VA = "0x189C34530", Slot = "11")]
		public void BJDRIVQTAAI(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9C34AD0", Offset = "0x9C338D0", VA = "0x189C34AD0", Slot = "12")]
		public bool YSPTQUMSMXJ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9C34590", Offset = "0x9C33390", VA = "0x189C34590", Slot = "13")]
		public void DRCOXKZCMYL(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9C34A10", Offset = "0x9C33810", VA = "0x189C34A10", Slot = "14")]
		public float TSTRHRCZTET(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9C344D0", Offset = "0x9C332D0", VA = "0x189C344D0", Slot = "15")]
		public void BFCIKGCDHFF(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9C345F0", Offset = "0x9C333F0", VA = "0x189C345F0", Slot = "16")]
		public string HCRODWCQXOW(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9C346B0", Offset = "0x9C334B0", VA = "0x189C346B0", Slot = "17")]
		public void KCFDDMXHRMW(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9C34650", Offset = "0x9C33450", VA = "0x189C34650", Slot = "18")]
		public DateTime JIFGKFHUIJE(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9C34770", Offset = "0x9C33570", VA = "0x189C34770", Slot = "19")]
		public void PMAPKMQQFXY(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9C34710", Offset = "0x9C33510", VA = "0x189C34710", Slot = "20")]
		public long NEBMHJJYLEB(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9C348C0", Offset = "0x9C336C0", VA = "0x189C348C0", Slot = "21")]
		public void SCDPMGTMRRL(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3B1D850", Offset = "0x3B1C650", VA = "0x183B1D850", Slot = "22")]
		public a SHZBBWFFKOU<a>(string a, a b, OHSUVITLQCJ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3B1E2A0", Offset = "0x3B1D0A0", VA = "0x183B1E2A0", Slot = "23")]
		public void UYDXXCAFNXC<b>(string a, b b, OHSUVITLQCJ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3B1CCA0", Offset = "0x3B1BAA0", VA = "0x183B1CCA0")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3B1DC10", Offset = "0x3B1CA10", VA = "0x183B1DC10")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9C34A70", Offset = "0x9C33870", VA = "0x189C34A70", Slot = "24")]
		public void XPCMVAWLTJX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9C34920", Offset = "0x9C33720", VA = "0x189C34920", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9C34B30", Offset = "0x9C33930", VA = "0x189C34B30")]
		public ITNWMDIZCGO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class LKOAMBZLQRH<a> where a : JZVAHTBZCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly HashSet<LKOAMBZLQRH<a>> TIJYYJGYRMS;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x68B9160", Offset = "0x68B7F60", VA = "0x1868B9160")]
		protected LKOAMBZLQRH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract void CMGWSREMVOF(string a);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x68B8D60", Offset = "0x68B7B60", VA = "0x1868B8D60")]
		public static void QNZXSJLXHOF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x68B88C0", Offset = "0x68B76C0", VA = "0x1868B88C0")]
		public static void IUDABOJRTPT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class LJYFUHRTOJG<a, b> : LKOAMBZLQRH<a> where a : JZVAHTBZCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly LJYFUHRTOJG<a, b> DOFDCVCRMAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Dictionary<string, b> PPLYRBUDKVL;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x68B8100", Offset = "0x68B6F00", VA = "0x1868B8100")]
		public bool YOABBVTNACT(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x68B7F60", Offset = "0x68B6D60", VA = "0x1868B7F60")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
		public IEnumerable<KeyValuePair<string, b>> VKHVQYYWAZE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x62A40E0", Offset = "0x62A2EE0", VA = "0x1862A40E0", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x68B7C80", Offset = "0x68B6A80", VA = "0x1868B7C80", Slot = "5")]
		protected override void CMGWSREMVOF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x68B8490", Offset = "0x68B7290", VA = "0x1868B8490")]
		public LJYFUHRTOJG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface JZVAHTBZCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool YJTUVSGDJFT
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OBIEGUWIDOT();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool PXXJGFSTPWG(string a);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int TJALRFIUNJW(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BJDRIVQTAAI(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool YSPTQUMSMXJ(string a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DRCOXKZCMYL(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "7")]
		float TSTRHRCZTET(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void BFCIKGCDHFF(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "9")]
		string HCRODWCQXOW(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void KCFDDMXHRMW(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DateTime JIFGKFHUIJE(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void PMAPKMQQFXY(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		long NEBMHJJYLEB(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void SCDPMGTMRRL(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		a SHZBBWFFKOU<a>(string a, a b, OHSUVITLQCJ<a> c);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void UYDXXCAFNXC<b>(string a, b b, OHSUVITLQCJ<b> c);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void XPCMVAWLTJX(string a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task Save([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface ZXCRVALKLPG : JZVAHTBZCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action CBHZTHOUXMX;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task RZHOWJXVQBB(long a, CancellationToken b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface IPBHQHBMINE : JZVAHTBZCLJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class SWHYASYUKUY : ZXCRVALKLPG, JZVAHTBZCLJ
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
			public SWHYASYUKUY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9C3FB90", Offset = "0x9C3E990", VA = "0x189C3FB90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9C3FF50", Offset = "0x9C3ED50", VA = "0x189C3FF50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class XNSMNSAZJEE : IEnumerator<IUPNMORLIQV>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private IUPNMORLIQV OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public SWHYASYUKUY XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private IUPNMORLIQV BIZXNLKFYPO
			{
				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
			[DebuggerHidden]
			public XNSMNSAZJEE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9C40DD0", Offset = "0x9C3FBD0", VA = "0x189C40DD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9C40E40", Offset = "0x9C3FC40", VA = "0x189C40E40", Slot = "8")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly Log ALDXGIVBEKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly EYDDAZPVOJX YOXAIEZHHLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool BJLFVLEADKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool DDOJNXGDMJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private CQCXTJLOHGF AUGRZUFPKEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private VOFDHKTSCRY XQLRLQMXUYQ;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool YJTUVSGDJFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action CBHZTHOUXMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9C3BB10", Offset = "0x9C3A910", VA = "0x189C3BB10")]
		[UnityEngine.Scripting.Preserve]
		public SWHYASYUKUY([Inject(null)] EYDDAZPVOJX unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "8")]
		public void OBIEGUWIDOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B2C0", Offset = "0x9C3A0C0", VA = "0x189C3B2C0", Slot = "6")]
		public Task RZHOWJXVQBB(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1E87E10", Offset = "0x1E86C10", VA = "0x181E87E10")]
		private static int NOMXPFDVPYF(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B240", Offset = "0x9C3A040", VA = "0x189C3B240", Slot = "9")]
		public bool PXXJGFSTPWG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B660", Offset = "0x9C3A460", VA = "0x189C3B660", Slot = "10")]
		public int TJALRFIUNJW(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9C390D0", Offset = "0x9C37ED0", VA = "0x189C390D0", Slot = "11")]
		public void BJDRIVQTAAI(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B950", Offset = "0x9C3A750", VA = "0x189C3B950", Slot = "12")]
		public bool YSPTQUMSMXJ(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9C392A0", Offset = "0x9C380A0", VA = "0x189C392A0", Slot = "13")]
		public void DRCOXKZCMYL(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B790", Offset = "0x9C3A590", VA = "0x189C3B790", Slot = "14")]
		public float TSTRHRCZTET(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9C39010", Offset = "0x9C37E10", VA = "0x189C39010", Slot = "15")]
		public void BFCIKGCDHFF(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9C39530", Offset = "0x9C38330", VA = "0x189C39530", Slot = "18")]
		public DateTime JIFGKFHUIJE(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B1D0", Offset = "0x9C39FD0", VA = "0x189C3B1D0", Slot = "19")]
		public void PMAPKMQQFXY(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B090", Offset = "0x9C39E90", VA = "0x189C3B090", Slot = "20")]
		public long NEBMHJJYLEB(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B350", Offset = "0x9C3A150", VA = "0x189C3B350", Slot = "21")]
		public void SCDPMGTMRRL(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F01090", Offset = "0x3EFFE90", VA = "0x183F01090", Slot = "22")]
		public a SHZBBWFFKOU<a>(string a, a b, OHSUVITLQCJ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3F01390", Offset = "0x3F00190", VA = "0x183F01390", Slot = "23")]
		public void UYDXXCAFNXC<b>(string a, b b, OHSUVITLQCJ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3F01550", Offset = "0x3F00350", VA = "0x183F01550")]
		private c WGBWGFQXBTD<c>(string a, c b, [Optional] OHSUVITLQCJ<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3F00410", Offset = "0x3EFF210", VA = "0x183F00410")]
		private void CQBWCUKNTIN<d>(string a, d b, [Optional] OHSUVITLQCJ<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9C39380", Offset = "0x9C38180", VA = "0x189C39380", Slot = "16")]
		public string HCRODWCQXOW(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9C3AEF0", Offset = "0x9C39CF0", VA = "0x189C3AEF0", Slot = "17")]
		public void KCFDDMXHRMW(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9C38EE0", Offset = "0x9C37CE0", VA = "0x189C38EE0")]
		private void BEJJYDPGYIX(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B3C0", Offset = "0x9C3A1C0", VA = "0x189C3B3C0")]
		private string SMEAQTKLCRZ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B8C0", Offset = "0x9C3A6C0", VA = "0x189C3B8C0", Slot = "24")]
		public void XPCMVAWLTJX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9C39200", Offset = "0x9C38000", VA = "0x189C39200")]
		private string DDSDKTWMLSV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9C395A0", Offset = "0x9C383A0", VA = "0x189C395A0")]
		public void JWIHTEBDZCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B260", Offset = "0x9C3A060", VA = "0x189C3B260", Slot = "26")]
		public void QBSBUOGZVKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B570", Offset = "0x9C3A370", VA = "0x189C3B570", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__40))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B100", Offset = "0x9C39F00", VA = "0x189C3B100")]
		[IteratorStateMachine(typeof(XNSMNSAZJEE))]
		private IEnumerator<IUPNMORLIQV> OJHGKFBDLOV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B170", Offset = "0x9C39F70", VA = "0x189C3B170")]
		private void OKMRTOTNWZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9C3B020", Offset = "0x9C39E20", VA = "0x189C3B020")]
		private void KOJOQDYAVPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9C39190", Offset = "0x9C37F90", VA = "0x189C39190")]
		private void CFTJUOFVVGC(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class TETINZSLBRM : ZXCRVALKLPG, JZVAHTBZCLJ
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
		private Dictionary<string, string> OQQBXCDHRZX;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool YJTUVSGDJFT
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string AALLBBZXAZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x9C3E9F0", Offset = "0x9C3D7F0", VA = "0x189C3E9F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private string VQSTPDFALDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9C3F1B0", Offset = "0x9C3DFB0", VA = "0x189C3F1B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Dictionary<string, string> LBWTJHUUQYV
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x9C3E8B0", Offset = "0x9C3D6B0", VA = "0x189C3E8B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action CBHZTHOUXMX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		[UnityEngine.Scripting.Preserve]
		public TETINZSLBRM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "8")]
		public void OBIEGUWIDOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E8F0", Offset = "0x9C3D6F0", VA = "0x189C3E8F0", Slot = "6")]
		public Task RZHOWJXVQBB(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F080", Offset = "0x9C3DE80", VA = "0x189C3F080", Slot = "14")]
		public float TSTRHRCZTET(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E510", Offset = "0x9C3D310", VA = "0x189C3E510", Slot = "13")]
		public void DRCOXKZCMYL(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F240", Offset = "0x9C3E040", VA = "0x189C3F240", Slot = "12")]
		public bool YSPTQUMSMXJ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F010", Offset = "0x9C3DE10", VA = "0x189C3F010", Slot = "10")]
		public int TJALRFIUNJW(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E630", Offset = "0x9C3D430", VA = "0x189C3E630", Slot = "18")]
		public DateTime JIFGKFHUIJE(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E7B0", Offset = "0x9C3D5B0", VA = "0x189C3E7B0", Slot = "19")]
		public void PMAPKMQQFXY(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E430", Offset = "0x9C3D230", VA = "0x189C3E430", Slot = "15")]
		public void BFCIKGCDHFF(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E4A0", Offset = "0x9C3D2A0", VA = "0x189C3E4A0", Slot = "11")]
		public void BJDRIVQTAAI(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E740", Offset = "0x9C3D540", VA = "0x189C3E740", Slot = "20")]
		public long NEBMHJJYLEB(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E980", Offset = "0x9C3D780", VA = "0x189C3E980", Slot = "21")]
		public void SCDPMGTMRRL(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3F4A3E0", Offset = "0x3F491E0", VA = "0x183F4A3E0", Slot = "22")]
		public a SHZBBWFFKOU<a>(string a, a b, OHSUVITLQCJ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3F4B4F0", Offset = "0x3F4A2F0", VA = "0x183F4B4F0", Slot = "23")]
		public void UYDXXCAFNXC<b>(string a, b b, OHSUVITLQCJ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E580", Offset = "0x9C3D380", VA = "0x189C3E580", Slot = "16")]
		public string HCRODWCQXOW(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E6A0", Offset = "0x9C3D4A0", VA = "0x189C3E6A0", Slot = "17")]
		public void KCFDDMXHRMW(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F0F0", Offset = "0x9C3DEF0", VA = "0x189C3F0F0", Slot = "24")]
		public void XPCMVAWLTJX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9C3E820", Offset = "0x9C3D620", VA = "0x189C3E820", Slot = "9")]
		public bool PXXJGFSTPWG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9C3EA80", Offset = "0x9C3D880", VA = "0x189C3EA80", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3F48C70", Offset = "0x3F47A70", VA = "0x183F48C70")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] OHSUVITLQCJ<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3F4A5C0", Offset = "0x3F493C0", VA = "0x183F4A5C0")]
		private void Set<T>(string propertyName, T value, [Optional] OHSUVITLQCJ<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9C3ECE0", Offset = "0x9C3DAE0", VA = "0x189C3ECE0")]
		private Dictionary<string, string> TANACEPQWMZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface UTDSXNMOWWG
	{
		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action CBHZTHOUXMX;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OBIEGUWIDOT();

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task BPXVHLZVCUN(long a);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool CZOQVEPUOLL(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool UDPZFJXJEMR(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool GXIPTMIBJEU(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		string LJEUKBGZPPV(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SetResult APICEWCSOJB(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int TSMYOUMQDID(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SetResult AXOXRQTFFJN(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool ZWAOGTTTLRU(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SetResult FLJSEBWPCTI(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		float QCSZOZYWQYE(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		SetResult CILYSZZVFGA(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DateTime LUBWUGIAGML(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "16")]
		SetResult BRTLEQRWLFJ(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "17")]
		long NSFGMCODAMY(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "18")]
		SetResult LLDBUMLKSKI(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "19")]
		a FMAGJWLYSDH<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "20")]
		SetResult AWDXFASVPLH<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD);

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "21")]
		bool XPQSFXBCTNX(string a);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool DRMBZRGIRZY(string a);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "23")]
		string KVWIYUSXTNF(string a, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "24")]
		SetResult VPLIUKRIDBJ(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "25")]
		int GSQEAPNDHOL(string a, int b = 0);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SetResult NCFWKYZLIUP(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool CMCSLUOBLRA(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "28")]
		SetResult NGWJYNGPXRU(string a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "29")]
		float KJLPZFJFJHO(string a, float b = 0f);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "30")]
		SetResult WBFPFYRGOAM(string a, float b);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		DateTime ZAPTYZFFYLJ(string a, [Optional] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		SetResult PTWGSXLSAOP(string a, DateTime b);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		long TGDWRMOMIBS(string a, long b = 0L);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		SetResult BDBCDWAZMMY(string a, long b);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void XGRKDOWUBGX<e>(OHSUVITLQCJ<e> a, [Optional] IEqualityComparer<e> b);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void SJZQVLICMVK<f>();

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "37")]
		IDisposable WLSNFMLVNTX();

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void HTVZAPIXTPE(float a);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task OKMRTOTNWZP([Optional] CancellationToken a);
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
	public class Preferences : UTDSXNMOWWG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private abstract class TCIMZAYHZPW
		{
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			protected static readonly HashSet<TCIMZAYHZPW> ZECNMLSUVXF;

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9C3BC10", Offset = "0x9C3AA10", VA = "0x189C3BC10")]
			public static void IUDABOJRTPT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			protected TCIMZAYHZPW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private class DQIFAUBDWET<a> : TCIMZAYHZPW
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public static readonly DQIFAUBDWET<a> GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public OHSUVITLQCJ<a> EBGRXYLYOSK
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public IEqualityComparer<a> QSAZWMUTLBE
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool BDDLIYBAOOR
			{
				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xE8E710", Offset = "0xE8D510", VA = "0x180E8E710")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x5332540", Offset = "0x5331340", VA = "0x185332540")]
			private DQIFAUBDWET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x5331C60", Offset = "0x5330A60", VA = "0x185331C60")]
			public void CBYRPQCEVDS(OHSUVITLQCJ<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x1025A60", Offset = "0x1024860", VA = "0x181025A60", Slot = "4")]
			public override void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private class YKNLBRUXPTO : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private readonly Preferences AOCUQNXLNHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private readonly object ZTAZKWPKQTF;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9C40EB0", Offset = "0x9C3FCB0", VA = "0x189C40EB0")]
			public YKNLBRUXPTO(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9C40E80", Offset = "0x9C3FC80", VA = "0x189C40E80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C3F310", Offset = "0x9C3E110", VA = "0x189C3F310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x9C3F600", Offset = "0x9C3E400", VA = "0x189C3F600", Slot = "5")]
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
			public JZVAHTBZCLJ backingStoreToSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x9C3FFB0", Offset = "0x9C3EDB0", VA = "0x189C3FFB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xD4A120", Offset = "0xD48F20", VA = "0x180D4A120", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C3F660", Offset = "0x9C3E460", VA = "0x189C3F660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x9C3FB30", Offset = "0x9C3E930", VA = "0x189C3FB30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class HQGDTHZJAXA : IEnumerator<IUPNMORLIQV>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private IUPNMORLIQV OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Preferences XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float NHTPMLSVRMS;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private IUPNMORLIQV BIZXNLKFYPO
			{
				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
			[DebuggerHidden]
			public HQGDTHZJAXA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x9C34400", Offset = "0x9C33200", VA = "0x189C34400", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9C34490", Offset = "0x9C33290", VA = "0x189C34490", Slot = "8")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly ZXCRVALKLPG NBRNAMOILCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly ZXCRVALKLPG QIAKEWSEVDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly IPBHQHBMINE JXPYXQALVPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly CQCXTJLOHGF AUGRZUFPKEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly OULRLZKTCJT.CustomSaveHandler FAQIOIEIYUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly CFODDVOSBJL AFSIQIAOYIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly HashSet<JZVAHTBZCLJ> RWYSYKQFPXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Task LCWXSOOLXYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<string, string> ODMOIFCYPQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private VOFDHKTSCRY ZYKMAJZMHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly object JEBXRVIDNHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly object YSHFAXBOALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long OOCLLYXWNJJ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool TAWVLPKTXZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x1A5D100", Offset = "0x1A5BF00", VA = "0x181A5D100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private CancellationTokenSource NVJQRYOJEOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B20", Offset = "0xCE6920", VA = "0x180CE7B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xCE7900", Offset = "0xCE6700", VA = "0x180CE7900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action CBHZTHOUXMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9C38930", Offset = "0x9C37730", VA = "0x189C38930", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9C37410", Offset = "0x9C36210", VA = "0x189C37410", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9C369A0", Offset = "0x9C357A0", VA = "0x189C369A0")]
		[CXDXQIFYXBD.Root]
		internal static void EOQBVPFENUW(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9C38B50", Offset = "0x9C37950", VA = "0x189C38B50")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] ZXCRVALKLPG localBackingStore, [Inject("Cloud")] ZXCRVALKLPG cloudBackingStore, [Inject(null)] IPBHQHBMINE editorBackingStore, [Inject(null)] CQCXTJLOHGF scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9C36960", Offset = "0x9C35760", VA = "0x189C36960", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9C36A10", Offset = "0x9C35810", VA = "0x189C36A10")]
		private void FETTXOTUBFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9C375E0", Offset = "0x9C363E0", VA = "0x189C375E0", Slot = "6")]
		public void OBIEGUWIDOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9C36240", Offset = "0x9C35040", VA = "0x189C36240", Slot = "7")]
		public Task BPXVHLZVCUN(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9C35DB0", Offset = "0x9C34BB0", VA = "0x189C35DB0")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task ACLDSGGTHBU(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9C38770", Offset = "0x9C37570", VA = "0x189C38770")]
		private void WNAHOSXJRBJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9C367A0", Offset = "0x9C355A0", VA = "0x189C367A0")]
		private void CUKSRRXDXZA(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9C389D0", Offset = "0x9C377D0", VA = "0x189C389D0")]
		private string YYQYXFILTUN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9C37F20", Offset = "0x9C36D20", VA = "0x189C37F20")]
		private void UUSZLEHXAWJ(AccountPreferenceBackingStoreTypes a, string b, [Out] ZXCRVALKLPG c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9C368E0", Offset = "0x9C356E0", VA = "0x189C368E0")]
		private ZXCRVALKLPG DYHUGMJHNCF(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9C36820", Offset = "0x9C35620", VA = "0x189C36820", Slot = "8")]
		public bool CZOQVEPUOLL(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9C37D30", Offset = "0x9C36B30", VA = "0x189C37D30", Slot = "9")]
		public bool UDPZFJXJEMR(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9C36C40", Offset = "0x9C35A40", VA = "0x189C36C40", Slot = "10")]
		public bool GXIPTMIBJEU(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9C37160", Offset = "0x9C35F60", VA = "0x189C37160", Slot = "11")]
		public string LJEUKBGZPPV(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9C35EC0", Offset = "0x9C34CC0", VA = "0x189C35EC0", Slot = "12")]
		public SetResult APICEWCSOJB(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9C37C80", Offset = "0x9C36A80", VA = "0x189C37C80", Slot = "13")]
		public int TSMYOUMQDID(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9C36040", Offset = "0x9C34E40", VA = "0x189C36040", Slot = "14")]
		public SetResult AXOXRQTFFJN(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9C38AA0", Offset = "0x9C378A0", VA = "0x189C38AA0", Slot = "15")]
		public bool ZWAOGTTTLRU(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9C36A60", Offset = "0x9C35860", VA = "0x189C36A60", Slot = "16")]
		public SetResult FLJSEBWPCTI(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9C37A90", Offset = "0x9C36890", VA = "0x189C37A90", Slot = "17")]
		public float QCSZOZYWQYE(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9C365B0", Offset = "0x9C353B0", VA = "0x189C365B0", Slot = "18")]
		public SetResult CILYSZZVFGA(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9C37370", Offset = "0x9C36170", VA = "0x189C37370", Slot = "19")]
		public DateTime LUBWUGIAGML(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9C36410", Offset = "0x9C35210", VA = "0x189C36410", Slot = "20")]
		public SetResult BRTLEQRWLFJ(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9C37540", Offset = "0x9C36340", VA = "0x189C37540", Slot = "21")]
		public long NSFGMCODAMY(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9C37200", Offset = "0x9C36000", VA = "0x189C37200", Slot = "22")]
		public SetResult LLDBUMLKSKI(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3DC5D80", Offset = "0x3DC4B80", VA = "0x183DC5D80", Slot = "23")]
		public a FMAGJWLYSDH<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3DC4420", Offset = "0x3DC3220", VA = "0x183DC4420", Slot = "24")]
		public SetResult AWDXFASVPLH<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9C388D0", Offset = "0x9C376D0", VA = "0x189C388D0", Slot = "25")]
		public bool XPQSFXBCTNX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9C368D0", Offset = "0x9C356D0", VA = "0x189C368D0", Slot = "26")]
		public bool DRMBZRGIRZY(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9C36F80", Offset = "0x9C35D80", VA = "0x189C36F80", Slot = "27")]
		public string KVWIYUSXTNF(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9C38500", Offset = "0x9C37300", VA = "0x189C38500", Slot = "28")]
		public SetResult VPLIUKRIDBJ(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9C36BD0", Offset = "0x9C359D0", VA = "0x189C36BD0", Slot = "29")]
		public int GSQEAPNDHOL(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9C374B0", Offset = "0x9C362B0", VA = "0x189C374B0", Slot = "30")]
		public SetResult NCFWKYZLIUP(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9C36730", Offset = "0x9C35530", VA = "0x189C36730", Slot = "31")]
		public bool CMCSLUOBLRA(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9C374E0", Offset = "0x9C362E0", VA = "0x189C374E0", Slot = "32")]
		public SetResult NGWJYNGPXRU(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9C36F10", Offset = "0x9C35D10", VA = "0x189C36F10", Slot = "33")]
		public float KJLPZFJFJHO(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9C38670", Offset = "0x9C37470", VA = "0x189C38670", Slot = "34")]
		public SetResult WBFPFYRGOAM(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9C38A30", Offset = "0x9C37830", VA = "0x189C38A30", Slot = "35")]
		public DateTime ZAPTYZFFYLJ(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9C37A60", Offset = "0x9C36860", VA = "0x189C37A60", Slot = "36")]
		public SetResult PTWGSXLSAOP(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9C37C10", Offset = "0x9C36A10", VA = "0x189C37C10", Slot = "37")]
		public long TGDWRMOMIBS(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9C361B0", Offset = "0x9C34FB0", VA = "0x189C361B0", Slot = "38")]
		public SetResult BDBCDWAZMMY(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9C361E0", Offset = "0x9C34FE0", VA = "0x189C361E0")]
		private bool BETDWYZWKBN(JZVAHTBZCLJ a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9C380C0", Offset = "0x9C36EC0", VA = "0x189C380C0")]
		private bool UWGZJJQLONU(JZVAHTBZCLJ a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9C37DD0", Offset = "0x9C36BD0", VA = "0x189C37DD0")]
		private SetResult ULYSTXQYOJY(JZVAHTBZCLJ a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9C36DD0", Offset = "0x9C35BD0", VA = "0x189C36DD0")]
		private SetResult ILZVAPBIXGA(JZVAHTBZCLJ a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9C38530", Offset = "0x9C37330", VA = "0x189C38530")]
		private SetResult VWDNNCINWGX(JZVAHTBZCLJ a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9C37740", Offset = "0x9C36540", VA = "0x189C37740")]
		private SetResult PHYLCPLJXWT(JZVAHTBZCLJ a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9C36FF0", Offset = "0x9C35DF0", VA = "0x189C36FF0")]
		private SetResult LEFWIHLPTJU(JZVAHTBZCLJ a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9C38790", Offset = "0x9C37590", VA = "0x189C38790")]
		private SetResult XNUHMMDVWNP(JZVAHTBZCLJ a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3DC4850", Offset = "0x3DC3650", VA = "0x183DC4850")]
		private e BCELEUSCXCI<e>(JZVAHTBZCLJ a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3DC5230", Offset = "0x3DC4030", VA = "0x183DC5230")]
		private SetResult BQFIBCSBCKQ<f>(JZVAHTBZCLJ a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3DC6460", Offset = "0x3DC5260", VA = "0x183DC6460", Slot = "39")]
		public void XGRKDOWUBGX<g>(OHSUVITLQCJ<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC6320", Offset = "0x3DC5120", VA = "0x183DC6320", Slot = "40")]
		public void SJZQVLICMVK<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9C37B40", Offset = "0x9C36940", VA = "0x189C37B40")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(JZVAHTBZCLJ backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9C37650", Offset = "0x9C36450", VA = "0x189C37650", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task OKMRTOTNWZP([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9C37880", Offset = "0x9C36680", VA = "0x189C37880")]
		private void POGKLHVGFNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9C386A0", Offset = "0x9C374A0", VA = "0x189C386A0", Slot = "41")]
		public IDisposable WLSNFMLVNTX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9C36DC0", Offset = "0x9C35BC0", VA = "0x189C36DC0", Slot = "42")]
		public void HTVZAPIXTPE(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9C38220", Offset = "0x9C37020", VA = "0x189C38220")]
		private void VAKGCZAMYKW(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9C38480", Offset = "0x9C37280", VA = "0x189C38480")]
		[IteratorStateMachine(typeof(HQGDTHZJAXA))]
		private IEnumerator<IUPNMORLIQV> VFJPMSJSORG(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9C37510", Offset = "0x9C36310", VA = "0x189C37510")]
		[CompilerGenerated]
		private void NKOUAPZSMLN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class UOELTPEKVFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9C40C60", Offset = "0x9C3FA60", VA = "0x189C40C60")]
		public static string SDTYHTNINLV(this UTDSXNMOWWG a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9C409B0", Offset = "0x9C3F7B0", VA = "0x189C409B0")]
		public static byte[] AYMFSIHWCIJ(this UTDSXNMOWWG a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9C40B50", Offset = "0x9C3F950", VA = "0x189C40B50")]
		public static SetResult GQBJNDLWWZX(this UTDSXNMOWWG a, string b, ReadOnlySpan<byte> value)
		{
			return default(SetResult);
		}
	}
}
namespace RecRoom.Preferences.CustomParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class PXRMSJWIHND : XSDXOWNJGCN<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static PXRMSJWIHND GFQGJWBHKJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x9C35920", Offset = "0x9C34720", VA = "0x189C35920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9C35970", Offset = "0x9C34770", VA = "0x189C35970", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9C35A60", Offset = "0x9C34860", VA = "0x189C35A60", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9C35D70", Offset = "0x9C34B70", VA = "0x189C35D70")]
		public PXRMSJWIHND()
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
