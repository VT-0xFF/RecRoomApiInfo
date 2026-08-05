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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x862E180", Offset = "0x862C980", VA = "0x18862E180", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x862E1B0", Offset = "0x862C9B0", VA = "0x18862E1B0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x862E200", Offset = "0x862CA00", VA = "0x18862E200")]
		public LUMECVDBIOU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class XEBACCQRMUB : XWEVTJFRHOH<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x862F0F0", Offset = "0x862D8F0", VA = "0x18862F0F0", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x862F180", Offset = "0x862D980", VA = "0x18862F180", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x862F220", Offset = "0x862DA20", VA = "0x18862F220")]
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
		[Cpp2IlInjected.Address(RVA = "0x46716D0", Offset = "0x466FED0", VA = "0x1846716D0")]
		[Preserve]
		public EGVXAOSEDWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x46712B0", Offset = "0x466FAB0", VA = "0x1846712B0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4671540", Offset = "0x466FD40", VA = "0x184671540", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D8BE20", Offset = "0x3D8A620", VA = "0x183D8BE20")]
		[Preserve]
		public CWIWXPKLXBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D8B6B0", Offset = "0x3D89EB0", VA = "0x183D8B6B0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3D8B780", Offset = "0x3D89F80", VA = "0x183D8B780", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x862E510", Offset = "0x862CD10", VA = "0x18862E510")]
		public static OXEVZGWDZAA RSTRFUROOMB(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AWYOWTOUPAC<a> : XWEVTJFRHOH<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x54B5AF0", Offset = "0x54B42F0", VA = "0x1854B5AF0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x54B5BE0", Offset = "0x54B43E0", VA = "0x1854B5BE0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3DB8D00", Offset = "0x3DB7500", VA = "0x183DB8D00")]
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
		[Cpp2IlInjected.Address(RVA = "0x5204EB0", Offset = "0x52036B0", VA = "0x185204EB0")]
		protected KGQXCSRWDUY(AHKEIBKRYEP<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5201A70", Offset = "0x5200270", VA = "0x185201A70", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5204820", Offset = "0x5203020", VA = "0x185204820", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a XPDMPSXXBLV(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5200E50", Offset = "0x51FF650", VA = "0x185200E50", Slot = "12")]
		internal virtual IEnumerable<string> MJMYRCRLWEH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x52011B0", Offset = "0x51FF9B0", VA = "0x1852011B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E17500", Offset = "0x3E15D00", VA = "0x183E17500")]
		[Preserve]
		public ZAWQIMIFGWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3E174F0", Offset = "0x3E15CF0", VA = "0x183E174F0")]
		[Preserve]
		public ZAWQIMIFGWI(AHKEIBKRYEP<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3E17120", Offset = "0x3E15920", VA = "0x183E17120", Slot = "11")]
		protected override a[] XPDMPSXXBLV(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MMDLGVCVDYD<a> : KGQXCSRWDUY<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3E17500", Offset = "0x3E15D00", VA = "0x183E17500")]
		[Preserve]
		public MMDLGVCVDYD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3E174F0", Offset = "0x3E15CF0", VA = "0x183E174F0")]
		[Preserve]
		public MMDLGVCVDYD([Optional] AHKEIBKRYEP<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x57D30A0", Offset = "0x57D18A0", VA = "0x1857D30A0", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x5A06C10", Offset = "0x5A05410", VA = "0x185A06C10")]
		public OUXTRFTFICX(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5A06980", Offset = "0x5A05180", VA = "0x185A06980", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5A06B60", Offset = "0x5A05360", VA = "0x185A06B60", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class DECIBCEBVBI : XWEVTJFRHOH<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x862DCA0", Offset = "0x862C4A0", VA = "0x18862DCA0", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x862DD00", Offset = "0x862C500", VA = "0x18862DD00", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x862DD90", Offset = "0x862C590", VA = "0x18862DD90")]
		public DECIBCEBVBI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class WUPDEEFMOGI : XWEVTJFRHOH<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x862EFB0", Offset = "0x862D7B0", VA = "0x18862EFB0", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x862F010", Offset = "0x862D810", VA = "0x18862F010", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x862F0B0", Offset = "0x862D8B0", VA = "0x18862F0B0")]
		public WUPDEEFMOGI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class UOFKSYQIDQH : XWEVTJFRHOH<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x862EE70", Offset = "0x862D670", VA = "0x18862EE70", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x862EED0", Offset = "0x862D6D0", VA = "0x18862EED0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x862EF70", Offset = "0x862D770", VA = "0x18862EF70")]
		public UOFKSYQIDQH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class UGPJLIUODJV : XWEVTJFRHOH<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x862ED40", Offset = "0x862D540", VA = "0x18862ED40", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x862EDA0", Offset = "0x862D5A0", VA = "0x18862EDA0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x862EE30", Offset = "0x862D630", VA = "0x18862EE30")]
		public UGPJLIUODJV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class EMXIETMPKWY : XWEVTJFRHOH<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x862DEB0", Offset = "0x862C6B0", VA = "0x18862DEB0", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x862DF10", Offset = "0x862C710", VA = "0x18862DF10", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x862DFA0", Offset = "0x862C7A0", VA = "0x18862DFA0")]
		public EMXIETMPKWY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class BWTGVJVEYNA : XWEVTJFRHOH<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x862DB60", Offset = "0x862C360", VA = "0x18862DB60", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x862DBC0", Offset = "0x862C3C0", VA = "0x18862DBC0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x862DC60", Offset = "0x862C460", VA = "0x18862DC60")]
		public BWTGVJVEYNA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class SMLMJMMWXGT : XWEVTJFRHOH<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x862EC00", Offset = "0x862D400", VA = "0x18862EC00", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x862EC60", Offset = "0x862D460", VA = "0x18862EC60", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x862ED00", Offset = "0x862D500", VA = "0x18862ED00")]
		public SMLMJMMWXGT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class JVJJLWDXFXW : XWEVTJFRHOH<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x862E040", Offset = "0x862C840", VA = "0x18862E040", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x862E0B0", Offset = "0x862C8B0", VA = "0x18862E0B0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x862E140", Offset = "0x862C940", VA = "0x18862E140")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DDDDD0", Offset = "0x3DDC5D0", VA = "0x183DDDDD0")]
		protected XWEVTJFRHOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD3E0", Offset = "0x3DDBBE0", VA = "0x183DDD3E0")]
		private a LPOVJRVCPZL(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCE30", Offset = "0x3DDB630", VA = "0x183DDCE30", Slot = "7")]
		public string JQQRJUQNVII(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3DDDD30", Offset = "0x3DDC530", VA = "0x183DDDD30", Slot = "5")]
		public bool ZMUPFJICOJR(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC970", Offset = "0x3DDB170", VA = "0x183DDC970", Slot = "8")]
		private bool DZOVXCZOSOW(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3DDDA00", Offset = "0x3DDC200", VA = "0x183DDDA00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D41C80", Offset = "0x3D40480", VA = "0x183D41C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x35402B0", Offset = "0x353EAB0", VA = "0x1835402B0")]
		public static AHKEIBKRYEP<a> TPBELBQFVNN<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3D3B8D0", Offset = "0x3D3A0D0", VA = "0x183D3B8D0")]
		public static OXEVZGWDZAA TPBELBQFVNN(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3D36700", Offset = "0x3D34F00", VA = "0x183D36700")]
		private static OXEVZGWDZAA EHVTVHFFHQA(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3D42BF0", Offset = "0x3D413F0", VA = "0x183D42BF0")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD38BD0", Offset = "0xD373D0", VA = "0x180D38BD0")]
			[DebuggerHidden]
			public KJPZMSAIKMW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5208B40", Offset = "0x5207340", VA = "0x185208B40", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5208700", Offset = "0x5206F00", VA = "0x185208700", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5208CB0", Offset = "0x52074B0", VA = "0x185208CB0")]
			private void SNXRWXESNLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3D305A0", Offset = "0x3D2EDA0", VA = "0x183D305A0", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x5208130", Offset = "0x5206930", VA = "0x185208130", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> DIANHCHXSWJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5208D00", Offset = "0x5207500", VA = "0x185208D00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4047C20", Offset = "0x4046420", VA = "0x184047C20")]
		protected DLVEDTNCRQV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x40476F0", Offset = "0x4045EF0", VA = "0x1840476F0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4047590", Offset = "0x4045D90", VA = "0x184047590", Slot = "12")]
		[IteratorStateMachine(typeof(DLVEDTNCRQV<>.KJPZMSAIKMW))]
		internal override IEnumerable<string> MJMYRCRLWEH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4047510", Offset = "0x4045D10", VA = "0x184047510")]
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
		[Cpp2IlInjected.Address(RVA = "0x862DE60", Offset = "0x862C660", VA = "0x18862DE60")]
		[Preserve]
		public EBRODCLGBGF(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x862DDD0", Offset = "0x862C5D0", VA = "0x18862DDD0", Slot = "11")]
		protected override List<string> XPDMPSXXBLV(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class XZQHZCWLCOU : DLVEDTNCRQV<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x862F2C0", Offset = "0x862DAC0", VA = "0x18862F2C0")]
		[Preserve]
		public XZQHZCWLCOU(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x862F260", Offset = "0x862DA60", VA = "0x18862F260", Slot = "11")]
		protected override string[] XPDMPSXXBLV(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class GOQJBAQOGJP : XWEVTJFRHOH<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB00F50", Offset = "0xAFF750", VA = "0x180B00F50", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x862DFE0", Offset = "0x862C7E0", VA = "0x18862DFE0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x862E000", Offset = "0x862C800", VA = "0x18862E000")]
		public GOQJBAQOGJP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class MHUWIYHMTDE : XWEVTJFRHOH<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x862E240", Offset = "0x862CA40", VA = "0x18862E240", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x862E360", Offset = "0x862CB60", VA = "0x18862E360", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x862E4D0", Offset = "0x862CCD0", VA = "0x18862E4D0")]
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
