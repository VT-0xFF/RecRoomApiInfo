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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class VECPMATGZYI : VICDNBVOCID<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85BE1C0", Offset = "0x85BCDC0", VA = "0x1885BE1C0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85BE1F0", Offset = "0x85BCDF0", VA = "0x1885BE1F0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85BE240", Offset = "0x85BCE40", VA = "0x1885BE240")]
		public VECPMATGZYI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class KISAHDVEMBT : VICDNBVOCID<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85BD130", Offset = "0x85BBD30", VA = "0x1885BD130", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85BD1C0", Offset = "0x85BBDC0", VA = "0x1885BD1C0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85BD260", Offset = "0x85BBE60", VA = "0x1885BD260")]
		public KISAHDVEMBT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class FOUTNADDETP<a> : VICDNBVOCID<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type FDALDMWLUKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool SLEZHVSCRMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] YSVVTUJGYDP;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4C719E0", Offset = "0x4C705E0", VA = "0x184C719E0")]
		[Preserve]
		public FOUTNADDETP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4C715C0", Offset = "0x4C701C0", VA = "0x184C715C0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4C71780", Offset = "0x4C70380", VA = "0x184C71780", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class FVZQXYTAVFY<a> : VICDNBVOCID<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type FDALDMWLUKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly RXNOUBZITDG JXMVBDYZUVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool SLEZHVSCRMR;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4C761A0", Offset = "0x4C74DA0", VA = "0x184C761A0")]
		[Preserve]
		public FVZQXYTAVFY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4C75900", Offset = "0x4C74500", VA = "0x184C75900", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4C75B00", Offset = "0x4C74700", VA = "0x184C75B00", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class OOSHZSFVMSN
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, RXNOUBZITDG> NWXJKTRCGQN;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x85BD510", Offset = "0x85BC110", VA = "0x1885BD510")]
		public static RXNOUBZITDG UPJWXVNJARD(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class SQDDNKQMEIS<a> : VICDNBVOCID<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5D19B40", Offset = "0x5D18740", VA = "0x185D19B40", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5D19D20", Offset = "0x5D18920", VA = "0x185D19D20", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E860", Offset = "0x3D2D460", VA = "0x183D2E860")]
		public SQDDNKQMEIS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class ZYUTYPWYNRC<a, b> : VICDNBVOCID<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly KKPQSGFSPLZ<b> AUSJWJJWULQ;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3EADFA0", Offset = "0x3EACBA0", VA = "0x183EADFA0")]
		protected ZYUTYPWYNRC(KKPQSGFSPLZ<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3EAAF00", Offset = "0x3EA9B00", VA = "0x183EAAF00", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3EACF10", Offset = "0x3EABB10", VA = "0x183EACF10", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a TNEQSCEJYHN(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3EAA490", Offset = "0x3EA9090", VA = "0x183EAA490", Slot = "12")]
		internal virtual IEnumerable<string> LREQHAVTBYP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3EAA1C0", Offset = "0x3EA8DC0", VA = "0x183EAA1C0")]
		[CompilerGenerated]
		private string FWFPFNZGHZS(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class CRQNIFUMSUI<a> : ZYUTYPWYNRC<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3CFAD00", Offset = "0x3CF9900", VA = "0x183CFAD00")]
		[Preserve]
		public CRQNIFUMSUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3CFAD20", Offset = "0x3CF9920", VA = "0x183CFAD20")]
		[Preserve]
		public CRQNIFUMSUI(KKPQSGFSPLZ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3CFACA0", Offset = "0x3CF98A0", VA = "0x183CFACA0", Slot = "11")]
		protected override a[] TNEQSCEJYHN(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class NXXUEEOFTXZ<a> : ZYUTYPWYNRC<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3CFAD00", Offset = "0x3CF9900", VA = "0x183CFAD00")]
		[Preserve]
		public NXXUEEOFTXZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3CFAD20", Offset = "0x3CF9920", VA = "0x183CFAD20")]
		[Preserve]
		public NXXUEEOFTXZ([Optional] KKPQSGFSPLZ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x57AFBC0", Offset = "0x57AE7C0", VA = "0x1857AFBC0", Slot = "11")]
		protected override List<a> TNEQSCEJYHN(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class VVPPLFQFRLN<a> : VICDNBVOCID<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? UDYVIZLBJKA;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6163410", Offset = "0x6162010", VA = "0x186163410")]
		public VVPPLFQFRLN(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6163180", Offset = "0x6161D80", VA = "0x186163180", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x61631E0", Offset = "0x6161DE0", VA = "0x1861631E0", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class WSYBDUOLGFY : VICDNBVOCID<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85BE280", Offset = "0x85BCE80", VA = "0x1885BE280", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85BE2E0", Offset = "0x85BCEE0", VA = "0x1885BE2E0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85BE370", Offset = "0x85BCF70", VA = "0x1885BE370")]
		public WSYBDUOLGFY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class KBAYVXVFWRW : VICDNBVOCID<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85BCFF0", Offset = "0x85BBBF0", VA = "0x1885BCFF0", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85BD050", Offset = "0x85BBC50", VA = "0x1885BD050", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85BD0F0", Offset = "0x85BBCF0", VA = "0x1885BD0F0")]
		public KBAYVXVFWRW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class QMLUCRWUTIL : VICDNBVOCID<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85BDDB0", Offset = "0x85BC9B0", VA = "0x1885BDDB0", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85BDE10", Offset = "0x85BCA10", VA = "0x1885BDE10", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85BDEB0", Offset = "0x85BCAB0", VA = "0x1885BDEB0")]
		public QMLUCRWUTIL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class PZWFWLPSNFZ : VICDNBVOCID<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85BDC20", Offset = "0x85BC820", VA = "0x1885BDC20", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85BDC80", Offset = "0x85BC880", VA = "0x1885BDC80", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85BDD10", Offset = "0x85BC910", VA = "0x1885BDD10")]
		public PZWFWLPSNFZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class LGGNPTGRRUU : VICDNBVOCID<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85BD2A0", Offset = "0x85BBEA0", VA = "0x1885BD2A0", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85BD300", Offset = "0x85BBF00", VA = "0x1885BD300", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x85BD390", Offset = "0x85BBF90", VA = "0x1885BD390")]
		public LGGNPTGRRUU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class XWJPNJWWPRI : VICDNBVOCID<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x85BE3B0", Offset = "0x85BCFB0", VA = "0x1885BE3B0", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85BE410", Offset = "0x85BD010", VA = "0x1885BE410", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85BE4B0", Offset = "0x85BD0B0", VA = "0x1885BE4B0")]
		public XWJPNJWWPRI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class MGJTMRYTZVJ : VICDNBVOCID<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85BD3D0", Offset = "0x85BBFD0", VA = "0x1885BD3D0", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85BD430", Offset = "0x85BC030", VA = "0x1885BD430", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85BD4D0", Offset = "0x85BC0D0", VA = "0x1885BD4D0")]
		public MGJTMRYTZVJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class HTEREHDYMWQ : VICDNBVOCID<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85BCEB0", Offset = "0x85BBAB0", VA = "0x1885BCEB0", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85BCF20", Offset = "0x85BBB20", VA = "0x1885BCF20", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85BCFB0", Offset = "0x85BBBB0", VA = "0x1885BCFB0")]
		public HTEREHDYMWQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface RXNOUBZITDG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string CFNRDUJBFWA(object a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CADJQBROYPG([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface KKPQSGFSPLZ<a> : RXNOUBZITDG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool LMMIVTGGNIT([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a POZJDCVLYVQ([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class VICDNBVOCID<a> : KKPQSGFSPLZ<a>, RXNOUBZITDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type WWWBOEMVRAV;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6155280", Offset = "0x6153E80", VA = "0x186155280")]
		protected VICDNBVOCID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6154EB0", Offset = "0x6153AB0", VA = "0x186154EB0")]
		private a XUEUJXKOACB(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x61540C0", Offset = "0x6152CC0", VA = "0x1861540C0", Slot = "7")]
		public string CFNRDUJBFWA(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x61541A0", Offset = "0x6152DA0", VA = "0x1861541A0", Slot = "5")]
		public bool LMMIVTGGNIT(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x61542B0", Offset = "0x6152EB0", VA = "0x1861542B0", Slot = "8")]
		private bool OSTPFPSIAQW(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6154B30", Offset = "0x6153730", VA = "0x186154B30", Slot = "6")]
		public a POZJDCVLYVQ(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class SSOZJHIOPSK<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static KKPQSGFSPLZ<b> YNAVUHJMGMQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4C5C1D0", Offset = "0x4C5ADD0", VA = "0x184C5C1D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x38C8430", Offset = "0x38C7030", VA = "0x1838C8430")]
		public static KKPQSGFSPLZ<a> PADHUUQGAHR<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5D28540", Offset = "0x5D27140", VA = "0x185D28540")]
		public static RXNOUBZITDG PADHUUQGAHR(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5D1CA50", Offset = "0x5D1B650", VA = "0x185D1CA50")]
		private static RXNOUBZITDG KYYJAWHTFBS(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5D1FF40", Offset = "0x5D1EB40", VA = "0x185D1FF40")]
		private static RXNOUBZITDG LFLEQJDUVYX(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class QIBLFVPSYCJ<a> : ZYUTYPWYNRC<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class VIZWPXJDCVI : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int FTPEWITHWYC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string DVJPFYKYOVL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string XUHBQIFPLPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public QIBLFVPSYCJ<a> BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> TXGVRMMIAQB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder CSHOTCRLPBT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool WOJVKIEOKDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int DIBPMRMQGUC;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string WSCBMCOAYZI
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD18690", Offset = "0xD17290", VA = "0x180D18690")]
			[DebuggerHidden]
			public VIZWPXJDCVI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6155ED0", Offset = "0x6154AD0", VA = "0x186155ED0", Slot = "7")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6155500", Offset = "0x6154100", VA = "0x186155500", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6155460", Offset = "0x6154060", VA = "0x186155460")]
			private void LSRJDRRKPDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3CCB5C0", Offset = "0x3CCA1C0", VA = "0x183CCB5C0", Slot = "10")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x61552E0", Offset = "0x6153EE0", VA = "0x1861552E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> EYJDILNHLTP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6155D90", Offset = "0x6154990", VA = "0x186155D90", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator VDVERRYCFPI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool LUSRHGUTUZS;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5A46DA0", Offset = "0x5A459A0", VA = "0x185A46DA0")]
		protected QIBLFVPSYCJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5A46890", Offset = "0x5A45490", VA = "0x185A46890", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5A467E0", Offset = "0x5A453E0", VA = "0x185A467E0", Slot = "12")]
		[IteratorStateMachine(typeof(QIBLFVPSYCJ<>.VIZWPXJDCVI))]
		internal override IEnumerable<string> LREQHAVTBYP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5A46630", Offset = "0x5A45230", VA = "0x185A46630")]
		[CompilerGenerated]
		internal static string LALOZTKOKZZ(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class GCTFSCVYSBP : QIBLFVPSYCJ<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x85BCE60", Offset = "0x85BBA60", VA = "0x1885BCE60")]
		[Preserve]
		public GCTFSCVYSBP(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x85BCDD0", Offset = "0x85BB9D0", VA = "0x1885BCDD0", Slot = "11")]
		protected override List<string> TNEQSCEJYHN(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class FJMIBFFWVTC : QIBLFVPSYCJ<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x85BCD80", Offset = "0x85BB980", VA = "0x1885BCD80")]
		[Preserve]
		public FJMIBFFWVTC(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x85BCD20", Offset = "0x85BB920", VA = "0x1885BCD20", Slot = "11")]
		protected override string[] TNEQSCEJYHN(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class QGXARKAAWZD : VICDNBVOCID<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAF7580", Offset = "0xAF6180", VA = "0x180AF7580", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x85BDD50", Offset = "0x85BC950", VA = "0x1885BDD50", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x85BDD70", Offset = "0x85BC970", VA = "0x1885BDD70")]
		public QGXARKAAWZD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RKZQMPIOQQK : VICDNBVOCID<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x85BDEF0", Offset = "0x85BCAF0", VA = "0x1885BDEF0", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x85BE010", Offset = "0x85BCC10", VA = "0x1885BE010", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x85BE180", Offset = "0x85BCD80", VA = "0x1885BE180")]
		public RKZQMPIOQQK()
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
