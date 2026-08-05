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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DB7ED0", Offset = "0x9DB68D0", VA = "0x189DB7ED0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DB7B90", Offset = "0x9DB6590", VA = "0x189DB7B90", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DC3F80", Offset = "0x9DC2980", VA = "0x189DC3F80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A2D0B0", Offset = "0x2A2BAB0", VA = "0x182A2D0B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DB85F0", Offset = "0x9DB6FF0", VA = "0x189DB85F0")]
		private static void TZPQQDAASES(JZVAHTBZCLJ a, CustomSaveHandler b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9DB87B0", Offset = "0x9DB71B0", VA = "0x189DB87B0")]
		public static bool XWIHWMSTLSM(this JZVAHTBZCLJ a, string b, [Optional] CustomSaveHandler c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB80C0", Offset = "0x9DB6AC0", VA = "0x189DB80C0")]
		public static SetResult GEWRUOICSXB(this JZVAHTBZCLJ a, string b, string c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8670", Offset = "0x9DB7070", VA = "0x189DB8670")]
		public static SetResult WTYTCJNPUPD(this JZVAHTBZCLJ a, string b, int c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8350", Offset = "0x9DB6D50", VA = "0x189DB8350")]
		public static SetResult JDIGNYZITNM(this JZVAHTBZCLJ a, string b, bool c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9DB84A0", Offset = "0x9DB6EA0", VA = "0x189DB84A0")]
		public static SetResult SLUGNDINZOS(this JZVAHTBZCLJ a, string b, float c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7F50", Offset = "0x9DB6950", VA = "0x189DB7F50")]
		public static SetResult AVSYEOROLMD(this JZVAHTBZCLJ a, string b, DateTime c, [Optional] CustomSaveHandler d)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8210", Offset = "0x9DB6C10", VA = "0x189DB8210")]
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
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Dictionary<string, string> LBWTJHUUQYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9DBF4F0", Offset = "0x9DBDEF0", VA = "0x189DBF4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action CBHZTHOUXMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9DC12E0", Offset = "0x9DBFCE0", VA = "0x189DC12E0")]
		[UnityEngine.Scripting.Preserve]
		public TDDGDJNSAAY([Inject(null)] EYDDAZPVOJX unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "8")]
		public void OBIEGUWIDOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF0A0", Offset = "0x9DBDAA0", VA = "0x189DBF0A0")]
		private DirectoryInfo EPBWPWFVQNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF530", Offset = "0x9DBDF30", VA = "0x189DBF530", Slot = "6")]
		public Task RZHOWJXVQBB(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9DC0980", Offset = "0x9DBF380", VA = "0x189DC0980", Slot = "14")]
		public float TSTRHRCZTET(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF030", Offset = "0x9DBDA30", VA = "0x189DBF030", Slot = "13")]
		public void DRCOXKZCMYL(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9DC11A0", Offset = "0x9DBFBA0", VA = "0x189DC11A0", Slot = "12")]
		public bool YSPTQUMSMXJ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9DC0910", Offset = "0x9DBF310", VA = "0x189DC0910", Slot = "10")]
		public int TJALRFIUNJW(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF240", Offset = "0x9DBDC40", VA = "0x189DBF240", Slot = "18")]
		public DateTime JIFGKFHUIJE(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF3F0", Offset = "0x9DBDDF0", VA = "0x189DBF3F0", Slot = "19")]
		public void PMAPKMQQFXY(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9DBEDE0", Offset = "0x9DBD7E0", VA = "0x189DBEDE0", Slot = "15")]
		public void BFCIKGCDHFF(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9DBEE50", Offset = "0x9DBD850", VA = "0x189DBEE50", Slot = "11")]
		public void BJDRIVQTAAI(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF380", Offset = "0x9DBDD80", VA = "0x189DBF380", Slot = "20")]
		public long NEBMHJJYLEB(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF5C0", Offset = "0x9DBDFC0", VA = "0x189DBF5C0", Slot = "21")]
		public void SCDPMGTMRRL(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3F96410", Offset = "0x3F94E10", VA = "0x183F96410", Slot = "22")]
		public a SHZBBWFFKOU<a>(string a, a b, OHSUVITLQCJ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3F978C0", Offset = "0x3F962C0", VA = "0x183F978C0", Slot = "23")]
		public void UYDXXCAFNXC<b>(string a, b b, OHSUVITLQCJ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF190", Offset = "0x9DBDB90", VA = "0x189DBF190", Slot = "16")]
		public string HCRODWCQXOW(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF2B0", Offset = "0x9DBDCB0", VA = "0x189DBF2B0", Slot = "17")]
		public void KCFDDMXHRMW(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1030", Offset = "0x9DBFA30", VA = "0x189DC1030", Slot = "24")]
		public void XPCMVAWLTJX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF460", Offset = "0x9DBDE60", VA = "0x189DBF460", Slot = "9")]
		public bool PXXJGFSTPWG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF850", Offset = "0x9DBE250", VA = "0x189DBF850", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9DC09F0", Offset = "0x9DBF3F0", VA = "0x189DC09F0")]
		private void VDVANOCFCRD(DirectoryInfo a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF630", Offset = "0x9DBE030", VA = "0x189DBF630")]
		private static string SGWHUEIBURK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9DBEEC0", Offset = "0x9DBD8C0", VA = "0x189DBEEC0")]
		private static string BXQZXZAXAJX(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3F94CA0", Offset = "0x3F936A0", VA = "0x183F94CA0")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] OHSUVITLQCJ<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3F965F0", Offset = "0x3F94FF0", VA = "0x183F965F0")]
		private void Set<T>(string propertyName, T value, [Optional] OHSUVITLQCJ<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9DBFB90", Offset = "0x9DBE590", VA = "0x189DBFB90")]
		private Dictionary<string, string> TANACEPQWMZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9DBF320", Offset = "0x9DBDD20", VA = "0x189DBF320")]
		private void KOJOQDYAVPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9DBEFC0", Offset = "0x9DBD9C0", VA = "0x189DBEFC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DB7C90", Offset = "0x9DB6690", VA = "0x189DB7C90")]
		[CXDXQIFYXBD.Root]
		internal static void CXDXQIFYXBD(MZEBANDYSXL a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class TFQAQGPBFGD : ITNWMDIZCGO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7B10", Offset = "0x9DB6510", VA = "0x189DB7B10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action CBHZTHOUXMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7340", Offset = "0x9DB5D40", VA = "0x189DB7340")]
		[UnityEngine.Scripting.Preserve]
		public AAUCTLGJIFR([Inject(null)] EYDDAZPVOJX unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6FD0", Offset = "0x9DB59D0", VA = "0x189DB6FD0", Slot = "6")]
		public Task RZHOWJXVQBB(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "8")]
		public void OBIEGUWIDOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6F70", Offset = "0x9DB5970", VA = "0x189DB6F70", Slot = "9")]
		public bool PXXJGFSTPWG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7160", Offset = "0x9DB5B60", VA = "0x189DB7160", Slot = "10")]
		public int TJALRFIUNJW(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6C50", Offset = "0x9DB5650", VA = "0x189DB6C50", Slot = "11")]
		public void BJDRIVQTAAI(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9DB72D0", Offset = "0x9DB5CD0", VA = "0x189DB72D0", Slot = "12")]
		public bool YSPTQUMSMXJ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6CC0", Offset = "0x9DB56C0", VA = "0x189DB6CC0", Slot = "13")]
		public void DRCOXKZCMYL(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB71D0", Offset = "0x9DB5BD0", VA = "0x189DB71D0", Slot = "14")]
		public float TSTRHRCZTET(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6BE0", Offset = "0x9DB55E0", VA = "0x189DB6BE0", Slot = "15")]
		public void BFCIKGCDHFF(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6D30", Offset = "0x9DB5730", VA = "0x189DB6D30", Slot = "16")]
		public string HCRODWCQXOW(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6E20", Offset = "0x9DB5820", VA = "0x189DB6E20", Slot = "17")]
		public void KCFDDMXHRMW(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6DB0", Offset = "0x9DB57B0", VA = "0x189DB6DB0", Slot = "18")]
		public DateTime JIFGKFHUIJE(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6F00", Offset = "0x9DB5900", VA = "0x189DB6F00", Slot = "19")]
		public void PMAPKMQQFXY(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6E90", Offset = "0x9DB5890", VA = "0x189DB6E90", Slot = "20")]
		public long NEBMHJJYLEB(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7060", Offset = "0x9DB5A60", VA = "0x189DB7060", Slot = "21")]
		public void SCDPMGTMRRL(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x33A0650", Offset = "0x339F050", VA = "0x1833A0650", Slot = "22")]
		public a SHZBBWFFKOU<a>(string a, a b, OHSUVITLQCJ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x33A1A70", Offset = "0x33A0470", VA = "0x1833A1A70", Slot = "23")]
		public void UYDXXCAFNXC<b>(string a, b b, OHSUVITLQCJ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7240", Offset = "0x9DB5C40", VA = "0x189DB7240", Slot = "24")]
		public void XPCMVAWLTJX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9DB70D0", Offset = "0x9DB5AD0", VA = "0x189DB70D0", Slot = "25")]
		public Task Save([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x339ED40", Offset = "0x339D740", VA = "0x18339ED40")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] OHSUVITLQCJ<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x33A0830", Offset = "0x339F230", VA = "0x1833A0830")]
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
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action CBHZTHOUXMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "8")]
		public void OBIEGUWIDOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7810", Offset = "0x9DB6210", VA = "0x189DB7810", Slot = "6")]
		public Task RZHOWJXVQBB(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9DB77B0", Offset = "0x9DB61B0", VA = "0x189DB77B0", Slot = "9")]
		public bool PXXJGFSTPWG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7990", Offset = "0x9DB6390", VA = "0x189DB7990", Slot = "10")]
		public int TJALRFIUNJW(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7510", Offset = "0x9DB5F10", VA = "0x189DB7510", Slot = "11")]
		public void BJDRIVQTAAI(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7AB0", Offset = "0x9DB64B0", VA = "0x189DB7AB0", Slot = "12")]
		public bool YSPTQUMSMXJ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7570", Offset = "0x9DB5F70", VA = "0x189DB7570", Slot = "13")]
		public void DRCOXKZCMYL(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9DB79F0", Offset = "0x9DB63F0", VA = "0x189DB79F0", Slot = "14")]
		public float TSTRHRCZTET(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9DB74B0", Offset = "0x9DB5EB0", VA = "0x189DB74B0", Slot = "15")]
		public void BFCIKGCDHFF(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9DB75D0", Offset = "0x9DB5FD0", VA = "0x189DB75D0", Slot = "16")]
		public string HCRODWCQXOW(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7690", Offset = "0x9DB6090", VA = "0x189DB7690", Slot = "17")]
		public void KCFDDMXHRMW(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7630", Offset = "0x9DB6030", VA = "0x189DB7630", Slot = "18")]
		public DateTime JIFGKFHUIJE(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7750", Offset = "0x9DB6150", VA = "0x189DB7750", Slot = "19")]
		public void PMAPKMQQFXY(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9DB76F0", Offset = "0x9DB60F0", VA = "0x189DB76F0", Slot = "20")]
		public long NEBMHJJYLEB(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB78A0", Offset = "0x9DB62A0", VA = "0x189DB78A0", Slot = "21")]
		public void SCDPMGTMRRL(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3B634B0", Offset = "0x3B61EB0", VA = "0x183B634B0", Slot = "22")]
		public a SHZBBWFFKOU<a>(string a, a b, OHSUVITLQCJ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3B63F00", Offset = "0x3B62900", VA = "0x183B63F00", Slot = "23")]
		public void UYDXXCAFNXC<b>(string a, b b, OHSUVITLQCJ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3B62900", Offset = "0x3B61300", VA = "0x183B62900")]
		public T Get<T>(string propertyName, T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3B63870", Offset = "0x3B62270", VA = "0x183B63870")]
		public void Set<T>(string propertyName, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7A50", Offset = "0x9DB6450", VA = "0x189DB7A50", Slot = "24")]
		public void XPCMVAWLTJX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7900", Offset = "0x9DB6300", VA = "0x189DB7900", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7B10", Offset = "0x9DB6510", VA = "0x189DB7B10")]
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
		[Cpp2IlInjected.Address(RVA = "0x699A340", Offset = "0x6998D40", VA = "0x18699A340")]
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
		[Cpp2IlInjected.Address(RVA = "0x6999F00", Offset = "0x6998900", VA = "0x186999F00")]
		public static void QNZXSJLXHOF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6999A30", Offset = "0x6998430", VA = "0x186999A30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6999230", Offset = "0x6997C30", VA = "0x186999230")]
		public bool YOABBVTNACT(string a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6999090", Offset = "0x6997A90", VA = "0x186999090")]
		public void Store(string cacheKey, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
		public IEnumerable<KeyValuePair<string, b>> VKHVQYYWAZE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x635EC30", Offset = "0x635D630", VA = "0x18635EC30", Slot = "4")]
		protected override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6998DB0", Offset = "0x69977B0", VA = "0x186998DB0", Slot = "5")]
		protected override void CMGWSREMVOF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x69995E0", Offset = "0x6997FE0", VA = "0x1869995E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DC2B90", Offset = "0x9DC1590", VA = "0x189DC2B90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x9DC2F60", Offset = "0x9DC1960", VA = "0x189DC2F60", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xD14A60", Offset = "0xD13460", VA = "0x180D14A60")]
			[DebuggerHidden]
			public XNSMNSAZJEE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9DC3DF0", Offset = "0x9DC27F0", VA = "0x189DC3DF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9DC3E60", Offset = "0x9DC2860", VA = "0x189DC3E60", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action CBHZTHOUXMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9DBEB10", Offset = "0x9DBD510", VA = "0x189DBEB10")]
		[UnityEngine.Scripting.Preserve]
		public SWHYASYUKUY([Inject(null)] EYDDAZPVOJX unityContainers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "8")]
		public void OBIEGUWIDOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE2C0", Offset = "0x9DBCCC0", VA = "0x189DBE2C0", Slot = "6")]
		public Task RZHOWJXVQBB(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1EBFEA0", Offset = "0x1EBE8A0", VA = "0x181EBFEA0")]
		private static int NOMXPFDVPYF(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE240", Offset = "0x9DBCC40", VA = "0x189DBE240", Slot = "9")]
		public bool PXXJGFSTPWG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE660", Offset = "0x9DBD060", VA = "0x189DBE660", Slot = "10")]
		public int TJALRFIUNJW(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC0C0", Offset = "0x9DBAAC0", VA = "0x189DBC0C0", Slot = "11")]
		public void BJDRIVQTAAI(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE950", Offset = "0x9DBD350", VA = "0x189DBE950", Slot = "12")]
		public bool YSPTQUMSMXJ(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC290", Offset = "0x9DBAC90", VA = "0x189DBC290", Slot = "13")]
		public void DRCOXKZCMYL(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE790", Offset = "0x9DBD190", VA = "0x189DBE790", Slot = "14")]
		public float TSTRHRCZTET(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC000", Offset = "0x9DBAA00", VA = "0x189DBC000", Slot = "15")]
		public void BFCIKGCDHFF(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC520", Offset = "0x9DBAF20", VA = "0x189DBC520", Slot = "18")]
		public DateTime JIFGKFHUIJE(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE1D0", Offset = "0x9DBCBD0", VA = "0x189DBE1D0", Slot = "19")]
		public void PMAPKMQQFXY(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE090", Offset = "0x9DBCA90", VA = "0x189DBE090", Slot = "20")]
		public long NEBMHJJYLEB(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE350", Offset = "0x9DBCD50", VA = "0x189DBE350", Slot = "21")]
		public void SCDPMGTMRRL(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F50B50", Offset = "0x3F4F550", VA = "0x183F50B50", Slot = "22")]
		public a SHZBBWFFKOU<a>(string a, a b, OHSUVITLQCJ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3F50E50", Offset = "0x3F4F850", VA = "0x183F50E50", Slot = "23")]
		public void UYDXXCAFNXC<b>(string a, b b, OHSUVITLQCJ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3F51010", Offset = "0x3F4FA10", VA = "0x183F51010")]
		private c WGBWGFQXBTD<c>(string a, c b, [Optional] OHSUVITLQCJ<c> c)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3F4FED0", Offset = "0x3F4E8D0", VA = "0x183F4FED0")]
		private void CQBWCUKNTIN<d>(string a, d b, [Optional] OHSUVITLQCJ<d> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC370", Offset = "0x9DBAD70", VA = "0x189DBC370", Slot = "16")]
		public string HCRODWCQXOW(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9DBDEF0", Offset = "0x9DBC8F0", VA = "0x189DBDEF0", Slot = "17")]
		public void KCFDDMXHRMW(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9DBBED0", Offset = "0x9DBA8D0", VA = "0x189DBBED0")]
		private void BEJJYDPGYIX(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE3C0", Offset = "0x9DBCDC0", VA = "0x189DBE3C0")]
		private string SMEAQTKLCRZ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE8C0", Offset = "0x9DBD2C0", VA = "0x189DBE8C0", Slot = "24")]
		public void XPCMVAWLTJX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC1F0", Offset = "0x9DBABF0", VA = "0x189DBC1F0")]
		private string DDSDKTWMLSV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC590", Offset = "0x9DBAF90", VA = "0x189DBC590")]
		public void JWIHTEBDZCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE260", Offset = "0x9DBCC60", VA = "0x189DBE260", Slot = "26")]
		public void QBSBUOGZVKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE570", Offset = "0x9DBCF70", VA = "0x189DBE570", Slot = "25")]
		[AsyncStateMachine(typeof(<Save>d__40))]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE100", Offset = "0x9DBCB00", VA = "0x189DBE100")]
		[IteratorStateMachine(typeof(XNSMNSAZJEE))]
		private IEnumerator<IUPNMORLIQV> OJHGKFBDLOV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE170", Offset = "0x9DBCB70", VA = "0x189DBE170")]
		private void OKMRTOTNWZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9DBE020", Offset = "0x9DBCA20", VA = "0x189DBE020")]
		private void KOJOQDYAVPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC180", Offset = "0x9DBAB80", VA = "0x189DBC180")]
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
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private string AALLBBZXAZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x9DC19F0", Offset = "0x9DC03F0", VA = "0x189DC19F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private string VQSTPDFALDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9DC21B0", Offset = "0x9DC0BB0", VA = "0x189DC21B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Dictionary<string, string> LBWTJHUUQYV
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x9DC18B0", Offset = "0x9DC02B0", VA = "0x189DC18B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action CBHZTHOUXMX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		[UnityEngine.Scripting.Preserve]
		public TETINZSLBRM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "8")]
		public void OBIEGUWIDOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9DC18F0", Offset = "0x9DC02F0", VA = "0x189DC18F0", Slot = "6")]
		public Task RZHOWJXVQBB(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9DC2080", Offset = "0x9DC0A80", VA = "0x189DC2080", Slot = "14")]
		public float TSTRHRCZTET(string a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1510", Offset = "0x9DBFF10", VA = "0x189DC1510", Slot = "13")]
		public void DRCOXKZCMYL(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9DC2240", Offset = "0x9DC0C40", VA = "0x189DC2240", Slot = "12")]
		public bool YSPTQUMSMXJ(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9DC2010", Offset = "0x9DC0A10", VA = "0x189DC2010", Slot = "10")]
		public int TJALRFIUNJW(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1630", Offset = "0x9DC0030", VA = "0x189DC1630", Slot = "18")]
		public DateTime JIFGKFHUIJE(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9DC17B0", Offset = "0x9DC01B0", VA = "0x189DC17B0", Slot = "19")]
		public void PMAPKMQQFXY(string a, DateTime b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1430", Offset = "0x9DBFE30", VA = "0x189DC1430", Slot = "15")]
		public void BFCIKGCDHFF(string a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9DC14A0", Offset = "0x9DBFEA0", VA = "0x189DC14A0", Slot = "11")]
		public void BJDRIVQTAAI(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1740", Offset = "0x9DC0140", VA = "0x189DC1740", Slot = "20")]
		public long NEBMHJJYLEB(string a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1980", Offset = "0x9DC0380", VA = "0x189DC1980", Slot = "21")]
		public void SCDPMGTMRRL(string a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3F99B80", Offset = "0x3F98580", VA = "0x183F99B80", Slot = "22")]
		public a SHZBBWFFKOU<a>(string a, a b, OHSUVITLQCJ<a> c)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x3F9ACA0", Offset = "0x3F996A0", VA = "0x183F9ACA0", Slot = "23")]
		public void UYDXXCAFNXC<b>(string a, b b, OHSUVITLQCJ<b> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1580", Offset = "0x9DBFF80", VA = "0x189DC1580", Slot = "16")]
		public string HCRODWCQXOW(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9DC16A0", Offset = "0x9DC00A0", VA = "0x189DC16A0", Slot = "17")]
		public void KCFDDMXHRMW(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9DC20F0", Offset = "0x9DC0AF0", VA = "0x189DC20F0", Slot = "24")]
		public void XPCMVAWLTJX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1820", Offset = "0x9DC0220", VA = "0x189DC1820", Slot = "9")]
		public bool PXXJGFSTPWG(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1A80", Offset = "0x9DC0480", VA = "0x189DC1A80", Slot = "25")]
		public Task Save(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3F98410", Offset = "0x3F96E10", VA = "0x183F98410")]
		private T Get<T>(string propertyName, T defaultValue, [Optional] OHSUVITLQCJ<T> parser)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3F99D60", Offset = "0x3F98760", VA = "0x183F99D60")]
		private void Set<T>(string propertyName, T value, [Optional] OHSUVITLQCJ<T> parser)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9DC1CE0", Offset = "0x9DC06E0", VA = "0x189DC1CE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DBEC10", Offset = "0x9DBD610", VA = "0x189DBEC10")]
			public static void IUDABOJRTPT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(Slot = "4")]
			public abstract void Clear();

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
				[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public IEqualityComparer<a> QSAZWMUTLBE
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool BDDLIYBAOOR
			{
				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0xEAE250", Offset = "0xEACC50", VA = "0x180EAE250")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x5396630", Offset = "0x5395030", VA = "0x185396630")]
			private DQIFAUBDWET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x5395D00", Offset = "0x5394700", VA = "0x185395D00")]
			public void CBYRPQCEVDS(OHSUVITLQCJ<a> a, [Optional] IEqualityComparer<a> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x104F170", Offset = "0x104DB70", VA = "0x18104F170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DC3ED0", Offset = "0x9DC28D0", VA = "0x189DC3ED0")]
			public YKNLBRUXPTO(Preferences a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9DC3EA0", Offset = "0x9DC28A0", VA = "0x189DC3EA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DC2310", Offset = "0x9DC0D10", VA = "0x189DC2310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x9DC2600", Offset = "0x9DC1000", VA = "0x189DC2600", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DC2FC0", Offset = "0x9DC19C0", VA = "0x189DC2FC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xD74370", Offset = "0xD72D70", VA = "0x180D74370", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DC2660", Offset = "0x9DC1060", VA = "0x189DC2660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x9DC2B30", Offset = "0x9DC1530", VA = "0x189DC2B30", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xD14A60", Offset = "0xD13460", VA = "0x180D14A60")]
			[DebuggerHidden]
			public HQGDTHZJAXA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x9DB73E0", Offset = "0x9DB5DE0", VA = "0x189DB73E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x9DB7470", Offset = "0x9DB5E70", VA = "0x189DB7470", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x1A95830", Offset = "0x1A94230", VA = "0x181A95830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private CancellationTokenSource NVJQRYOJEOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action CBHZTHOUXMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9DBB930", Offset = "0x9DBA330", VA = "0x189DBB930", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9DBA400", Offset = "0x9DB8E00", VA = "0x189DBA400", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9990", Offset = "0x9DB8390", VA = "0x189DB9990")]
		[CXDXQIFYXBD.Root]
		internal static void EOQBVPFENUW(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9DBBB50", Offset = "0x9DBA550", VA = "0x189DBBB50")]
		[UnityEngine.Scripting.Preserve]
		public Preferences([Inject("Disk")] ZXCRVALKLPG localBackingStore, [Inject("Cloud")] ZXCRVALKLPG cloudBackingStore, [Inject(null)] IPBHQHBMINE editorBackingStore, [Inject(null)] CQCXTJLOHGF scheduler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9950", Offset = "0x9DB8350", VA = "0x189DB9950", Slot = "44")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9A00", Offset = "0x9DB8400", VA = "0x189DB9A00")]
		private void FETTXOTUBFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA5D0", Offset = "0x9DB8FD0", VA = "0x189DBA5D0", Slot = "6")]
		public void OBIEGUWIDOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9230", Offset = "0x9DB7C30", VA = "0x189DB9230", Slot = "7")]
		public Task BPXVHLZVCUN(long a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8DA0", Offset = "0x9DB77A0", VA = "0x189DB8DA0")]
		[AsyncStateMachine(typeof(<InitializeForPlayerInternal>d__23))]
		private Task ACLDSGGTHBU(long a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9DBB770", Offset = "0x9DBA170", VA = "0x189DBB770")]
		private void WNAHOSXJRBJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9790", Offset = "0x9DB8190", VA = "0x189DB9790")]
		private void CUKSRRXDXZA(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9DBB9D0", Offset = "0x9DBA3D0", VA = "0x189DBB9D0")]
		private string YYQYXFILTUN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9DBAF20", Offset = "0x9DB9920", VA = "0x189DBAF20")]
		private void UUSZLEHXAWJ(AccountPreferenceBackingStoreTypes a, string b, [Out] ZXCRVALKLPG c, [Out] string d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9DB98D0", Offset = "0x9DB82D0", VA = "0x189DB98D0")]
		private ZXCRVALKLPG DYHUGMJHNCF(AccountPreferenceBackingStoreTypes a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9810", Offset = "0x9DB8210", VA = "0x189DB9810", Slot = "8")]
		public bool CZOQVEPUOLL(AccountPreferenceBackingStoreTypes a = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9DBAD30", Offset = "0x9DB9730", VA = "0x189DBAD30", Slot = "9")]
		public bool UDPZFJXJEMR(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9C30", Offset = "0x9DB8630", VA = "0x189DB9C30", Slot = "10")]
		public bool GXIPTMIBJEU(string a, AccountPreferenceBackingStoreTypes b = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA150", Offset = "0x9DB8B50", VA = "0x189DBA150", Slot = "11")]
		public string LJEUKBGZPPV(string a, [Optional] string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8EB0", Offset = "0x9DB78B0", VA = "0x189DB8EB0", Slot = "12")]
		public SetResult APICEWCSOJB(string a, string b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9DBAC80", Offset = "0x9DB9680", VA = "0x189DBAC80", Slot = "13")]
		public int TSMYOUMQDID(string a, int b = 0, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9030", Offset = "0x9DB7A30", VA = "0x189DB9030", Slot = "14")]
		public SetResult AXOXRQTFFJN(string a, int b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9DBBAA0", Offset = "0x9DBA4A0", VA = "0x189DBBAA0", Slot = "15")]
		public bool ZWAOGTTTLRU(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9A50", Offset = "0x9DB8450", VA = "0x189DB9A50", Slot = "16")]
		public SetResult FLJSEBWPCTI(string a, bool b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9DBAA90", Offset = "0x9DB9490", VA = "0x189DBAA90", Slot = "17")]
		public float QCSZOZYWQYE(string a, float b = 0f, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9DB95A0", Offset = "0x9DB7FA0", VA = "0x189DB95A0", Slot = "18")]
		public SetResult CILYSZZVFGA(string a, float b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA360", Offset = "0x9DB8D60", VA = "0x189DBA360", Slot = "19")]
		public DateTime LUBWUGIAGML(string a, [Optional] DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9400", Offset = "0x9DB7E00", VA = "0x189DB9400", Slot = "20")]
		public SetResult BRTLEQRWLFJ(string a, DateTime b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA530", Offset = "0x9DB8F30", VA = "0x189DBA530", Slot = "21")]
		public long NSFGMCODAMY(string a, long b = 0L, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA1F0", Offset = "0x9DB8BF0", VA = "0x189DBA1F0", Slot = "22")]
		public SetResult LLDBUMLKSKI(string a, long b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3E14980", Offset = "0x3E13380", VA = "0x183E14980", Slot = "23")]
		public a FMAGJWLYSDH<a>(string a, [Optional] a b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3E12FF0", Offset = "0x3E119F0", VA = "0x183E12FF0", Slot = "24")]
		public SetResult AWDXFASVPLH<b>(string a, b b, AccountPreferenceBackingStoreTypes c = AccountPreferenceBackingStoreTypes.CLOUD)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9DBB8D0", Offset = "0x9DBA2D0", VA = "0x189DBB8D0", Slot = "25")]
		public bool XPQSFXBCTNX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9DB98C0", Offset = "0x9DB82C0", VA = "0x189DB98C0", Slot = "26")]
		public bool DRMBZRGIRZY(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9F70", Offset = "0x9DB8970", VA = "0x189DB9F70", Slot = "27")]
		public string KVWIYUSXTNF(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9DBB500", Offset = "0x9DB9F00", VA = "0x189DBB500", Slot = "28")]
		public SetResult VPLIUKRIDBJ(string a, string b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9BC0", Offset = "0x9DB85C0", VA = "0x189DB9BC0", Slot = "29")]
		public int GSQEAPNDHOL(string a, int b = 0)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA4A0", Offset = "0x9DB8EA0", VA = "0x189DBA4A0", Slot = "30")]
		public SetResult NCFWKYZLIUP(string a, int b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9720", Offset = "0x9DB8120", VA = "0x189DB9720", Slot = "31")]
		public bool CMCSLUOBLRA(string a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA4D0", Offset = "0x9DB8ED0", VA = "0x189DBA4D0", Slot = "32")]
		public SetResult NGWJYNGPXRU(string a, bool b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9F00", Offset = "0x9DB8900", VA = "0x189DB9F00", Slot = "33")]
		public float KJLPZFJFJHO(string a, float b = 0f)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9DBB670", Offset = "0x9DBA070", VA = "0x189DBB670", Slot = "34")]
		public SetResult WBFPFYRGOAM(string a, float b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9DBBA30", Offset = "0x9DBA430", VA = "0x189DBBA30", Slot = "35")]
		public DateTime ZAPTYZFFYLJ(string a, [Optional] DateTime b)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9DBAA60", Offset = "0x9DB9460", VA = "0x189DBAA60", Slot = "36")]
		public SetResult PTWGSXLSAOP(string a, DateTime b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9DBAC10", Offset = "0x9DB9610", VA = "0x189DBAC10", Slot = "37")]
		public long TGDWRMOMIBS(string a, long b = 0L)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9DB91A0", Offset = "0x9DB7BA0", VA = "0x189DB91A0", Slot = "38")]
		public SetResult BDBCDWAZMMY(string a, long b)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9DB91D0", Offset = "0x9DB7BD0", VA = "0x189DB91D0")]
		private bool BETDWYZWKBN(JZVAHTBZCLJ a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9DBB0C0", Offset = "0x9DB9AC0", VA = "0x189DBB0C0")]
		private bool UWGZJJQLONU(JZVAHTBZCLJ a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9DBADD0", Offset = "0x9DB97D0", VA = "0x189DBADD0")]
		private SetResult ULYSTXQYOJY(JZVAHTBZCLJ a, string b, string c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9DC0", Offset = "0x9DB87C0", VA = "0x189DB9DC0")]
		private SetResult ILZVAPBIXGA(JZVAHTBZCLJ a, string b, int c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x9DBB530", Offset = "0x9DB9F30", VA = "0x189DBB530")]
		private SetResult VWDNNCINWGX(JZVAHTBZCLJ a, string b, bool c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA730", Offset = "0x9DB9130", VA = "0x189DBA730")]
		private SetResult PHYLCPLJXWT(JZVAHTBZCLJ a, string b, float c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9FE0", Offset = "0x9DB89E0", VA = "0x189DB9FE0")]
		private SetResult LEFWIHLPTJU(JZVAHTBZCLJ a, string b, DateTime c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9DBB790", Offset = "0x9DBA190", VA = "0x189DBB790")]
		private SetResult XNUHMMDVWNP(JZVAHTBZCLJ a, string b, long c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3E13420", Offset = "0x3E11E20", VA = "0x183E13420")]
		private e BCELEUSCXCI<e>(JZVAHTBZCLJ a, string b, e c)
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3E13E00", Offset = "0x3E12800", VA = "0x183E13E00")]
		private SetResult BQFIBCSBCKQ<f>(JZVAHTBZCLJ a, string b, f c)
		{
			return default(SetResult);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3E15060", Offset = "0x3E13A60", VA = "0x183E15060", Slot = "39")]
		public void XGRKDOWUBGX<g>(OHSUVITLQCJ<g> a, [Optional] IEqualityComparer<g> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3E14F20", Offset = "0x3E13920", VA = "0x183E14F20", Slot = "40")]
		public void SJZQVLICMVK<h>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9DBAB40", Offset = "0x9DB9540", VA = "0x189DBAB40")]
		[AsyncStateMachine(typeof(<Save>d__77))]
		private void Save(JZVAHTBZCLJ backingStoreToSave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA640", Offset = "0x9DB9040", VA = "0x189DBA640", Slot = "43")]
		[AsyncStateMachine(typeof(<SaveImmediate>d__78))]
		public Task OKMRTOTNWZP([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA880", Offset = "0x9DB9280", VA = "0x189DBA880")]
		private void POGKLHVGFNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9DBB6A0", Offset = "0x9DBA0A0", VA = "0x189DBB6A0", Slot = "41")]
		public IDisposable WLSNFMLVNTX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9DB0", Offset = "0x9DB87B0", VA = "0x189DB9DB0", Slot = "42")]
		public void HTVZAPIXTPE(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9DBB220", Offset = "0x9DB9C20", VA = "0x189DBB220")]
		private void VAKGCZAMYKW(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9DBB480", Offset = "0x9DB9E80", VA = "0x189DBB480")]
		[IteratorStateMachine(typeof(HQGDTHZJAXA))]
		private IEnumerator<IUPNMORLIQV> VFJPMSJSORG(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9DBA500", Offset = "0x9DB8F00", VA = "0x189DBA500")]
		[CompilerGenerated]
		private void NKOUAPZSMLN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public static class UOELTPEKVFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9DC3C80", Offset = "0x9DC2680", VA = "0x189DC3C80")]
		public static string SDTYHTNINLV(this UTDSXNMOWWG a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9DC39C0", Offset = "0x9DC23C0", VA = "0x189DC39C0")]
		public static byte[] AYMFSIHWCIJ(this UTDSXNMOWWG a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9DC3B70", Offset = "0x9DC2570", VA = "0x189DC3B70")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DB8910", Offset = "0x9DB7310", VA = "0x189DB8910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8960", Offset = "0x9DB7360", VA = "0x189DB8960", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8A50", Offset = "0x9DB7450", VA = "0x189DB8A50", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8D60", Offset = "0x9DB7760", VA = "0x189DB8D60")]
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
