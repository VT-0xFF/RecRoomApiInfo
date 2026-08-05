using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using RecRoom.NoEngine.DataStructures.Runtime.Caching;
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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE09B0", Offset = "0xADF3B0", VA = "0x180AE09B0")]
		public NullableAttribute(byte[] P_0)
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
		[Cpp2IlInjected.Address(RVA = "0xAE09F0", Offset = "0xADF3F0", VA = "0x180AE09F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class LUMECVDBIOU : XWEVTJFRHOH<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8730970", Offset = "0x872F370", VA = "0x188730970", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x87309A0", Offset = "0x872F3A0", VA = "0x1887309A0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87309F0", Offset = "0x872F3F0", VA = "0x1887309F0")]
		public LUMECVDBIOU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class XEBACCQRMUB : XWEVTJFRHOH<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8731910", Offset = "0x8730310", VA = "0x188731910", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87319A0", Offset = "0x87303A0", VA = "0x1887319A0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8731A40", Offset = "0x8730440", VA = "0x188731A40")]
		public XEBACCQRMUB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class EGVXAOSEDWJ<a> : XWEVTJFRHOH<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type NGKZJCWKIZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool IVOISFHYAWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] CPYGRQASLYN;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x46BFBD0", Offset = "0x46BE5D0", VA = "0x1846BFBD0")]
		[Preserve]
		public EGVXAOSEDWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x46BF790", Offset = "0x46BE190", VA = "0x1846BF790", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x46BFA40", Offset = "0x46BE440", VA = "0x1846BFA40", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class CWIWXPKLXBU<a> : XWEVTJFRHOH<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type NGKZJCWKIZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly OXEVZGWDZAA VKIVWHSPOMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool IVOISFHYAWN;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3DA70A0", Offset = "0x3DA5AA0", VA = "0x183DA70A0")]
		[Preserve]
		public CWIWXPKLXBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6920", Offset = "0x3DA5320", VA = "0x183DA6920", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6A00", Offset = "0x3DA5400", VA = "0x183DA6A00", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class RIMQQMMZBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, OXEVZGWDZAA> FNWPKOLWYFX;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8730D00", Offset = "0x872F700", VA = "0x188730D00")]
		public static OXEVZGWDZAA RSTRFUROOMB(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AWYOWTOUPAC<a> : XWEVTJFRHOH<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x55522A0", Offset = "0x5550CA0", VA = "0x1855522A0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5552390", Offset = "0x5550D90", VA = "0x185552390", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3DD4BC0", Offset = "0x3DD35C0", VA = "0x183DD4BC0")]
		public AWYOWTOUPAC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class KGQXCSRWDUY<a, b> : XWEVTJFRHOH<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly AHKEIBKRYEP<b> ZUCSWKTYMEK;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x52909C0", Offset = "0x528F3C0", VA = "0x1852909C0")]
		protected KGQXCSRWDUY(AHKEIBKRYEP<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x528D430", Offset = "0x528BE30", VA = "0x18528D430", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5290310", Offset = "0x528ED10", VA = "0x185290310", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a XPDMPSXXBLV(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x528C730", Offset = "0x528B130", VA = "0x18528C730", Slot = "12")]
		internal virtual IEnumerable<string> MJMYRCRLWEH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x528CAB0", Offset = "0x528B4B0", VA = "0x18528CAB0")]
		[CompilerGenerated]
		private string PDXCGLDOSLW(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ZAWQIMIFGWI<a> : KGQXCSRWDUY<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3E35650", Offset = "0x3E34050", VA = "0x183E35650")]
		[Preserve]
		public ZAWQIMIFGWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3E35630", Offset = "0x3E34030", VA = "0x183E35630")]
		[Preserve]
		public ZAWQIMIFGWI(AHKEIBKRYEP<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3E351C0", Offset = "0x3E33BC0", VA = "0x183E351C0", Slot = "11")]
		protected override a[] XPDMPSXXBLV(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MMDLGVCVDYD<a> : KGQXCSRWDUY<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3E35650", Offset = "0x3E34050", VA = "0x183E35650")]
		[Preserve]
		public MMDLGVCVDYD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3E35630", Offset = "0x3E34030", VA = "0x183E35630")]
		[Preserve]
		public MMDLGVCVDYD([Optional] AHKEIBKRYEP<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5883840", Offset = "0x5882240", VA = "0x185883840", Slot = "11")]
		protected override List<a> XPDMPSXXBLV(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class OUXTRFTFICX<a> : XWEVTJFRHOH<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? PPMYHOHOFKM;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5AC6500", Offset = "0x5AC4F00", VA = "0x185AC6500")]
		public OUXTRFTFICX(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5AC6260", Offset = "0x5AC4C60", VA = "0x185AC6260", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5AC6450", Offset = "0x5AC4E50", VA = "0x185AC6450", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class DECIBCEBVBI : XWEVTJFRHOH<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8730490", Offset = "0x872EE90", VA = "0x188730490", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x87304F0", Offset = "0x872EEF0", VA = "0x1887304F0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8730580", Offset = "0x872EF80", VA = "0x188730580")]
		public DECIBCEBVBI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class WUPDEEFMOGI : XWEVTJFRHOH<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x87317D0", Offset = "0x87301D0", VA = "0x1887317D0", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8731830", Offset = "0x8730230", VA = "0x188731830", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x87318D0", Offset = "0x87302D0", VA = "0x1887318D0")]
		public WUPDEEFMOGI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class UOFKSYQIDQH : XWEVTJFRHOH<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8731690", Offset = "0x8730090", VA = "0x188731690", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x87316F0", Offset = "0x87300F0", VA = "0x1887316F0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8731790", Offset = "0x8730190", VA = "0x188731790")]
		public UOFKSYQIDQH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class UGPJLIUODJV : XWEVTJFRHOH<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8731560", Offset = "0x872FF60", VA = "0x188731560", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x87315C0", Offset = "0x872FFC0", VA = "0x1887315C0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8731650", Offset = "0x8730050", VA = "0x188731650")]
		public UGPJLIUODJV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class EMXIETMPKWY : XWEVTJFRHOH<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x87306A0", Offset = "0x872F0A0", VA = "0x1887306A0", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8730700", Offset = "0x872F100", VA = "0x188730700", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8730790", Offset = "0x872F190", VA = "0x188730790")]
		public EMXIETMPKWY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class BWTGVJVEYNA : XWEVTJFRHOH<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8730350", Offset = "0x872ED50", VA = "0x188730350", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x87303B0", Offset = "0x872EDB0", VA = "0x1887303B0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8730450", Offset = "0x872EE50", VA = "0x188730450")]
		public BWTGVJVEYNA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class SMLMJMMWXGT : XWEVTJFRHOH<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8731420", Offset = "0x872FE20", VA = "0x188731420", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8731480", Offset = "0x872FE80", VA = "0x188731480", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8731520", Offset = "0x872FF20", VA = "0x188731520")]
		public SMLMJMMWXGT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class JVJJLWDXFXW : XWEVTJFRHOH<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8730830", Offset = "0x872F230", VA = "0x188730830", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x87308A0", Offset = "0x872F2A0", VA = "0x1887308A0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8730930", Offset = "0x872F330", VA = "0x188730930")]
		public JVJJLWDXFXW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface OXEVZGWDZAA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string JQQRJUQNVII(object a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool HBQUUXSOTRS([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface AHKEIBKRYEP<a> : OXEVZGWDZAA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ZMUPFJICOJR([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a VIKUNIOWFTU([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class XWEVTJFRHOH<a> : AHKEIBKRYEP<a>, OXEVZGWDZAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type HKFMRGOTYOJ;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3DFA8F0", Offset = "0x3DF92F0", VA = "0x183DFA8F0")]
		protected XWEVTJFRHOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9EE0", Offset = "0x3DF88E0", VA = "0x183DF9EE0")]
		private a LPOVJRVCPZL(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9910", Offset = "0x3DF8310", VA = "0x183DF9910", Slot = "7")]
		public string JQQRJUQNVII(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3DFA850", Offset = "0x3DF9250", VA = "0x183DFA850", Slot = "5")]
		public bool ZMUPFJICOJR(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9430", Offset = "0x3DF7E30", VA = "0x183DF9430", Slot = "8")]
		private bool DZOVXCZOSOW(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3DFA510", Offset = "0x3DF8F10", VA = "0x183DFA510", Slot = "6")]
		public a VIKUNIOWFTU(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class CJSSMLVNQWK<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static AHKEIBKRYEP<b> WUXFTMOSJKM
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3D5BF10", Offset = "0x3D5A910", VA = "0x183D5BF10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x355A8B0", Offset = "0x35592B0", VA = "0x18355A8B0")]
		public static AHKEIBKRYEP<a> TPBELBQFVNN<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3D55B60", Offset = "0x3D54560", VA = "0x183D55B60")]
		public static OXEVZGWDZAA TPBELBQFVNN(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3D50990", Offset = "0x3D4F390", VA = "0x183D50990")]
		private static OXEVZGWDZAA EHVTVHFFHQA(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3D5CE90", Offset = "0x3D5B890", VA = "0x183D5CE90")]
		private static OXEVZGWDZAA WFLOJMQRMRN(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class DLVEDTNCRQV<a> : KGQXCSRWDUY<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class KJPZMSAIKMW : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int XJERYWNBAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string ZKTAECIFTCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string AIJWPVFZEBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public DLVEDTNCRQV<a> VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> OXMAULTUCLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder LTZYZUFJWLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool PPKMYGYBBGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int WJOHSGCNMSK;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string ZZKHVIGFZGO
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD50190", Offset = "0xD4EB90", VA = "0x180D50190")]
			[DebuggerHidden]
			public KJPZMSAIKMW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5294880", Offset = "0x5293280", VA = "0x185294880", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5294430", Offset = "0x5292E30", VA = "0x185294430", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5294A10", Offset = "0x5293410", VA = "0x185294A10")]
			private void SNXRWXESNLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3D4A650", Offset = "0x3D49050", VA = "0x183D4A650", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x5293E40", Offset = "0x5292840", VA = "0x185293E40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> DIANHCHXSWJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5294A60", Offset = "0x5293460", VA = "0x185294A60", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool YBLAVKNAHQM;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4071490", Offset = "0x406FE90", VA = "0x184071490")]
		protected DLVEDTNCRQV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4070F30", Offset = "0x406F930", VA = "0x184070F30", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4070DD0", Offset = "0x406F7D0", VA = "0x184070DD0", Slot = "12")]
		[IteratorStateMachine(typeof(DLVEDTNCRQV<>.KJPZMSAIKMW))]
		internal override IEnumerable<string> MJMYRCRLWEH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4070D50", Offset = "0x406F750", VA = "0x184070D50")]
		[CompilerGenerated]
		internal static string KKRSWHRDZFR(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class EBRODCLGBGF : DLVEDTNCRQV<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8730650", Offset = "0x872F050", VA = "0x188730650")]
		[Preserve]
		public EBRODCLGBGF(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x87305C0", Offset = "0x872EFC0", VA = "0x1887305C0", Slot = "11")]
		protected override List<string> XPDMPSXXBLV(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class XZQHZCWLCOU : DLVEDTNCRQV<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8731AE0", Offset = "0x87304E0", VA = "0x188731AE0")]
		[Preserve]
		public XZQHZCWLCOU(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8731A80", Offset = "0x8730480", VA = "0x188731A80", Slot = "11")]
		protected override string[] XPDMPSXXBLV(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class GOQJBAQOGJP : XWEVTJFRHOH<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB18100", Offset = "0xB16B00", VA = "0x180B18100", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x87307D0", Offset = "0x872F1D0", VA = "0x1887307D0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x87307F0", Offset = "0x872F1F0", VA = "0x1887307F0")]
		public GOQJBAQOGJP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class MHUWIYHMTDE : XWEVTJFRHOH<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8730A30", Offset = "0x872F430", VA = "0x188730A30", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8730B50", Offset = "0x872F550", VA = "0x188730B50", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8730CC0", Offset = "0x872F6C0", VA = "0x188730CC0")]
		public MHUWIYHMTDE()
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
