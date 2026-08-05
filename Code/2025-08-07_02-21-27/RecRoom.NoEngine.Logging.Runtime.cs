using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Logging;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_NoEngine_Logging_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8B894A0", Offset = "0x8B880A0", VA = "0x188B894A0", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public readonly struct Log
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class FHGMUHOCBLU<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IEnumerable<a> RDAEVVFTNQX;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public FHGMUHOCBLU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x52F7370", Offset = "0x52F5F70", VA = "0x1852F7370")]
			internal object DOGRKNWYCFM((string message, string separator, IEnumerable<a> set, Func<a, string> toString) a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class SEMJOUFSBCR<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public IEnumerable<a> RDAEVVFTNQX;

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public SEMJOUFSBCR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x64EE6D0", Offset = "0x64ED2D0", VA = "0x1864EE6D0")]
			internal object DOGRKNWYCFM((string separator, IEnumerable<a> set, Func<a, string> toString) a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly Log Invalid;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xCE0880", Offset = "0xCDF480", VA = "0x180CE0880")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool ZPTGQZWOGXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8B8AA60", Offset = "0x8B89660", VA = "0x188B8AA60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool KUQHCZQTZXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8B8BFF0", Offset = "0x8B8ABF0", VA = "0x188B8BFF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string IGGDTQFVHLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8B8C3F0", Offset = "0x8B8AFF0", VA = "0x188B8C3F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool SNDHVNFTAHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x59F6030", Offset = "0x59F4C30", VA = "0x1859F6030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ParanoiaLevel GSZFNAMAHGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8B8A7B0", Offset = "0x8B893B0", VA = "0x188B8A7B0")]
			get
			{
				return default(ParanoiaLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Log this[string name]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8B8D3A0", Offset = "0x8B8BFA0", VA = "0x188B8D3A0")]
			get
			{
				return default(Log);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x167A4A0", Offset = "0x16790A0", VA = "0x18167A4A0")]
		public Log(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8B8D400", Offset = "0x8B8C000", VA = "0x188B8D400")]
		public static implicit operator Log(string path)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3CF63B0", Offset = "0x3CF4FB0", VA = "0x183CF63B0")]
		public void WZYWCRUQBLX<a>(Func<a, object> a, [In] a args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8D210", Offset = "0x8B8BE10", VA = "0x188B8D210")]
		public void WZYWCRUQBLX(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8B8D110", Offset = "0x8B8BD10", VA = "0x188B8D110")]
		public void WZYWCRUQBLX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3CF1DB0", Offset = "0x3CF09B0", VA = "0x183CF1DB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TGJQOPPHXBK<b>(Func<b, object> a, [In] b args, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8B8C750", Offset = "0x8B8B350", VA = "0x188B8C750")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TGJQOPPHXBK(Func<object> a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8B8C640", Offset = "0x8B8B240", VA = "0x188B8C640")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TGJQOPPHXBK(string a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3CF34F0", Offset = "0x3CF20F0", VA = "0x183CF34F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TGJQOPPHXBK<c>(Func<c, object> a, [In] c args, ParanoiaLevel b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8B8CCB0", Offset = "0x8B8B8B0", VA = "0x188B8CCB0")]
		public void WDNEMTSKPUO(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8B8B150", Offset = "0x8B89D50", VA = "0x188B8B150")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void HBVENYZZTLT(bool a, Func<object> b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF3B0", Offset = "0x3CCDFB0", VA = "0x183CCF3B0")]
		public void BUABTVTCRZF<p>(Func<p, object> a, [In] p args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8B8A840", Offset = "0x8B89440", VA = "0x188B8A840")]
		public void BUABTVTCRZF(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8B8A960", Offset = "0x8B89560", VA = "0x188B8A960")]
		public void BUABTVTCRZF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3CEFBB0", Offset = "0x3CEE7B0", VA = "0x183CEFBB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void LVXRFDATDDE<q>(Func<q, object> a, [In] q args, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8B8B8B0", Offset = "0x8B8A4B0", VA = "0x188B8B8B0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void LVXRFDATDDE(Func<object> a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8B8B7A0", Offset = "0x8B8A3A0", VA = "0x188B8B7A0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void LVXRFDATDDE(string a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4B80", Offset = "0x3CF3780", VA = "0x183CF4B80")]
		public void UXMTHWFWBJK<s>(bool a, Func<s, object> b, [In] s args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8B8C980", Offset = "0x8B8B580", VA = "0x188B8C980")]
		public void UXMTHWFWBJK(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8C870", Offset = "0x8B8B470", VA = "0x188B8C870")]
		public void UXMTHWFWBJK(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3CEE170", Offset = "0x3CECD70", VA = "0x183CEE170")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void CJDWICGHSIP<t>(bool a, Func<t, object> b, [In] t args, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4F40", Offset = "0x3CF3B40", VA = "0x183CF4F40")]
		public void WEJRWAXQWGB<be>(Func<be, object> a, [In] be args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8B8CDD0", Offset = "0x8B8B9D0", VA = "0x188B8CDD0")]
		public void WEJRWAXQWGB(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8B8CED0", Offset = "0x8B8BAD0", VA = "0x188B8CED0")]
		public void WEJRWAXQWGB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3CEE6D0", Offset = "0x3CED2D0", VA = "0x183CEE6D0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void FHJCSUMYQXW<bf>(Func<bf, object> a, [In] bf args, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8B8AAB0", Offset = "0x8B896B0", VA = "0x188B8AAB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void FHJCSUMYQXW(Func<object> a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8B8ABB0", Offset = "0x8B897B0", VA = "0x188B8ABB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void FHJCSUMYQXW(string a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3CF05D0", Offset = "0x3CEF1D0", VA = "0x183CF05D0")]
		public void MTZKNCHILMS<bh>(bool a, Func<bh, object> b, [In] bh args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8B8B9E0", Offset = "0x8B8A5E0", VA = "0x188B8B9E0")]
		public void MTZKNCHILMS(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B8BAE0", Offset = "0x8B8A6E0", VA = "0x188B8BAE0")]
		public void MTZKNCHILMS(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3CF1770", Offset = "0x3CF0370", VA = "0x183CF1770")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void SQUIOIBMJPX<bi>(bool a, Func<bi, object> b, [In] bi args, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8B8C440", Offset = "0x8B8B040", VA = "0x188B8C440")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void SQUIOIBMJPX(bool a, Func<object> b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8B8C550", Offset = "0x8B8B150", VA = "0x188B8C550")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void SQUIOIBMJPX(bool a, string b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0E20", Offset = "0x3CEFA20", VA = "0x183CF0E20")]
		public void OXBWYQGKRNN<bk>(bool a, Func<bk, object> b, [In] bk args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8B8BE00", Offset = "0x8B8AA00", VA = "0x188B8BE00")]
		public void OXBWYQGKRNN(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8BF00", Offset = "0x8B8AB00", VA = "0x188B8BF00")]
		public void OXBWYQGKRNN(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8B8CFB0", Offset = "0x8B8BBB0", VA = "0x188B8CFB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void WOLFWRUPUTA(bool a, string b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8B8D0A0", Offset = "0x8B8BCA0", VA = "0x188B8D0A0")]
		public void WZQFOSWZDPS(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8B8B430", Offset = "0x8B8A030", VA = "0x188B8B430")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void IZJQVJAFCTN(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8B8D330", Offset = "0x8B8BF30", VA = "0x188B8D330")]
		public void YVUERKCVHEB(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3CF48E0", Offset = "0x3CF34E0", VA = "0x183CF48E0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void UOQHEPQAMUM<bx>(bool a, Func<bx, object> b, [In] bx args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8B8CAB0", Offset = "0x8B8B6B0", VA = "0x188B8CAB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void UZFIHMWBFPI(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8B8C1F0", Offset = "0x8B8ADF0", VA = "0x188B8C1F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void QZZXMUXFRTN(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8B8B280", Offset = "0x8B89E80", VA = "0x188B8B280")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void HYLSOQQCGYN(bool a, string b, [Optional][CallerFilePath] string filePath, [CallerLineNumber] int lineNumber = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8B8C040", Offset = "0x8B8AC40", VA = "0x188B8C040")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void PYPJFESHUAC(bool a, string b, [Optional][CallerFilePath] string filePath, [CallerLineNumber] int lineNumber = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0980", Offset = "0x3CEF580", VA = "0x183CF0980")]
		public LogRangeScope NRDEJKHYKVU<cd>(Func<cd, object> a, [In] cd args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3CEF170", Offset = "0x3CEDD70", VA = "0x183CEF170")]
		public LogRangeScope GZNSTHFVKRP<ce>(Func<ce, object> a, [In] ce args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8B8BCD0", Offset = "0x8B8A8D0", VA = "0x188B8BCD0")]
		public LogRangeScope NRDEJKHYKVU(Func<object> a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8B8BBD0", Offset = "0x8B8A7D0", VA = "0x188B8BBD0")]
		public LogRangeScope NRDEJKHYKVU(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8ADC0", Offset = "0x8B899C0", VA = "0x188B8ADC0")]
		public LogRangeScope GZNSTHFVKRP(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8B8B4A0", Offset = "0x8B8A0A0", VA = "0x188B8B4A0")]
		public void LGFXJUHEOSW(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8B580", Offset = "0x8B8A180", VA = "0x188B8B580")]
		public void LGFXJUHEOSW(Exception a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3CEF4F0", Offset = "0x3CEE0F0", VA = "0x183CEF4F0")]
		public void LGFXJUHEOSW<cf>(Exception a, Func<cf, object> b, [In] cf args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3CF1200", Offset = "0x3CEFE00", VA = "0x183CF1200")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void QLVOJVAPMSW<ch>(string a, IEnumerable<ch> b, [Optional] Func<ch, string> c, string d = "\n")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3CF1350", Offset = "0x3CEFF50", VA = "0x183CF1350")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void QLVOJVAPMSW<ci>(IEnumerable<ci> a, [Optional] Func<ci, string> b, string c = "\n")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8B8BDF0", Offset = "0x8B8A9F0", VA = "0x188B8BDF0")]
		public void OBVKDMALYHT([Optional][CallerMemberName] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8B8ACA0", Offset = "0x8B898A0", VA = "0x188B8ACA0")]
		private string Format(object obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8B8ADF0", Offset = "0x8B899F0", VA = "0x188B8ADF0")]
		private static void HBCLQGFTNMH(Exception a, StringBuilder b, int c = 0, int d = 5)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class Logs
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class Teams
		{
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Log ZLEWGNQJPGP;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Log LMWSNDNVNFM;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Log BMGSUAQPFHS;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Log JWSARMVAECV;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Log RXLJWTQVVNH;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Log CNHTREMADFZ;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Log VKYMFMJUHWW;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Log AEGQHFEPIMJ;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Log UYDQTISBKYU;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Log YRFLAEUZZZJ;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log WYGHKFTUYTD;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Log IMTJQKKXHHN;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Log JTFRZZBVEXO;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Log EUZGYGAIVPI;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Log ACPRPGUBBXS;

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public static readonly Log EUOAGHEBLCE;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Log BLUJLZWUMNJ;

			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly Log DOZCISRNDUI;

			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly Log URHPATFURII;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static readonly Log PSQOGGGUGOO;
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class AI
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public static class MakerAI
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				public static class Command
				{
					[Cpp2IlInjected.Token(Token = "0x4000026")]
					public static readonly Log IBKFVVFMRIY;

					[Cpp2IlInjected.Token(Token = "0x4000027")]
					public static readonly Log SYMNNZMUIUK;
				}

				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public static readonly Log IBKFVVFMRIY;

				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static readonly Log DYEKLEKKEZC;

				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static readonly Log JXHYXMJZFNF;

				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public static readonly Log DPNCNKINTKL;

				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static readonly Log IEOOIQMIPTH;

				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static readonly Log ZYKJOREETRF;

				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public static readonly Log LASJNYIBBZP;
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public static class RoomieAI
			{
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public static readonly Log IBKFVVFMRIY;

				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static readonly Log DYEKLEKKEZC;

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static readonly Log DPNCNKINTKL;

				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public static readonly Log IEOOIQMIPTH;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static readonly Log QMDXZNSCUIO;

				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public static readonly Log YVIZFMOTBGB;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public static readonly Log OLIXBQLQZCP;
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public static class OpenAI
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static readonly Log IBKFVVFMRIY;

				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public static readonly Log PPAOTWSPHHN;

				[Cpp2IlInjected.Token(Token = "0x4000031")]
				public static readonly Log DKPSXPYHLAI;
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public static class GameAI
			{
				[Cpp2IlInjected.Token(Token = "0x2000010")]
				public static class RealtimeSession
				{
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					private static readonly Log IBKFVVFMRIY;

					[Cpp2IlInjected.Token(Token = "0x4000038")]
					public static readonly Log KZTLKIKUHXC;

					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public static readonly Log KZYSHPERRIL;

					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public static readonly Log LADZEVYPATU;

					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public static readonly Log LAJGCCSMKFD;

					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public static readonly Log KYYJVHJEWDS;

					[Cpp2IlInjected.Token(Token = "0x400003D")]
					public static readonly Log KZDQSODCFPB;

					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public static readonly Log KZIXPUWZPAK;

					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public static readonly Log KZOENBQWYLT;

					[Cpp2IlInjected.Token(Token = "0x4000040")]
					public static readonly Log KYDIGGHPKKI;

					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public static readonly Log KYIPDNBMTVR;
				}

				[Cpp2IlInjected.Token(Token = "0x2000011")]
				public static class RealtimeSessionDeltaEvents
				{
					[Cpp2IlInjected.Token(Token = "0x4000042")]
					private static readonly Log IBKFVVFMRIY;

					[Cpp2IlInjected.Token(Token = "0x4000043")]
					public static readonly Log KZTLKIKUHXC;

					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public static readonly Log KZYSHPERRIL;

					[Cpp2IlInjected.Token(Token = "0x4000045")]
					public static readonly Log LADZEVYPATU;

					[Cpp2IlInjected.Token(Token = "0x4000046")]
					public static readonly Log LAJGCCSMKFD;

					[Cpp2IlInjected.Token(Token = "0x4000047")]
					public static readonly Log KYYJVHJEWDS;

					[Cpp2IlInjected.Token(Token = "0x4000048")]
					public static readonly Log KZDQSODCFPB;

					[Cpp2IlInjected.Token(Token = "0x4000049")]
					public static readonly Log KZIXPUWZPAK;

					[Cpp2IlInjected.Token(Token = "0x400004A")]
					public static readonly Log KZOENBQWYLT;

					[Cpp2IlInjected.Token(Token = "0x400004B")]
					public static readonly Log KYDIGGHPKKI;

					[Cpp2IlInjected.Token(Token = "0x400004C")]
					public static readonly Log KYIPDNBMTVR;
				}

				[Cpp2IlInjected.Token(Token = "0x2000012")]
				public static class Controller
				{
					[Cpp2IlInjected.Token(Token = "0x400004D")]
					private static readonly Log IBKFVVFMRIY;

					[Cpp2IlInjected.Token(Token = "0x400004E")]
					public static readonly Log TFBJZZJYTUD;

					[Cpp2IlInjected.Token(Token = "0x400004F")]
					public static readonly Log QDJMRKQCYEI;
				}

				[Cpp2IlInjected.Token(Token = "0x4000032")]
				private static readonly Log IBKFVVFMRIY;

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static readonly Log TFBJZZJYTUD;

				[Cpp2IlInjected.Token(Token = "0x4000034")]
				public static readonly Log UQPJMCXXGAO;

				[Cpp2IlInjected.Token(Token = "0x4000035")]
				public static readonly Log GGYEBALOYTR;

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static readonly Log RSEXWRUXZIY;
			}

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private static readonly Log IBKFVVFMRIY;

			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public static readonly Log HSQAZMUPYPG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class Art
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private static readonly Log XZHRAOCCLYQ;

			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly Log SZNLTLLFMJW;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Audio
		{
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private static readonly Log XZHRAOCCLYQ;

			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly Log PGNQZROIPRI;

			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly Log HZPSDFGPIIQ;

			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly Log QLCHSWKXMQE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private static readonly Log XZHRAOCCLYQ;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly Log WQYLEZJGROY;

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly Log CRVXDAEPBVF;

			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public static readonly Log QZMQVQSCHZY;

			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly Log NXNDIAFKSCU;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly Log BIDFMHPHAFL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public static class Data
		{
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private static readonly Log XZHRAOCCLYQ;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public static readonly Log VZYOKPBOODM;

			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly Log LGGVEJMFXSZ;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly Log NKNMZIGJWYR;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly Log ZHZHUOYFZGQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class DI
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private static readonly Log XZHRAOCCLYQ;

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly Log NJLRNQSLJRA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Economy
		{
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly Log XZHRAOCCLYQ;

			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public static readonly Log CQAGPMVOSKG;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly Log RFSRIBXOZCI;

			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public static readonly Log NXNDIAFKSCU;

			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly Log GXAFVLNVKQO;

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly Log PSQOGGGUGOO;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly Log BFUAJGFCDWW;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class Engagement
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public static class Discovery
			{
				[Cpp2IlInjected.Token(Token = "0x4000077")]
				public static readonly Log IBKFVVFMRIY;

				[Cpp2IlInjected.Token(Token = "0x4000078")]
				public static readonly Log SIPDPWRYMTY;
			}

			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private static readonly Log XZHRAOCCLYQ;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly Log OFQNQIDTCFB;

			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public static readonly Log IRZYRCCNORG;

			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly Log ZPULVLKGKVB;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly Log NXNDIAFKSCU;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly Log SURZWCVLQQM;

			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly Log GUNAZUODBLA;

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public static readonly Log DFUIYSOBPER;

			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public static readonly Log AFPHWUKMJRL;

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly Log HCJIFIFKYMT;

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly Log HUHJNWJAHIV;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly Log IXHJXQQNHPZ;

			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly Log PEQMLDCUOPJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class Experience
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly Log XZHRAOCCLYQ;

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly Log VBJLWDKAOIS;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public static readonly Log NXNDIAFKSCU;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public static readonly Log XYYGIYDOLYS;

			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public static readonly Log ONNKAIBRLET;

			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public static readonly Log EVMIUSGOINY;

			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Log LTHHVTWPWLL;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly Log RLYXPTYWVEQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class Localization
		{
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly Log XZHRAOCCLYQ;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public static readonly Log NQCGNJYSXYR;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class Logic
		{
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public static class CV1
			{
				[Cpp2IlInjected.Token(Token = "0x4000084")]
				private static readonly Log XZHRAOCCLYQ;
			}

			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public static class CV2
			{
				[Cpp2IlInjected.Token(Token = "0x4000085")]
				public static readonly Log IBKFVVFMRIY;

				[Cpp2IlInjected.Token(Token = "0x4000086")]
				public static readonly Log JBYMLFDTHEI;

				[Cpp2IlInjected.Token(Token = "0x4000087")]
				public static readonly Log OCWOMYEOMMW;

				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly Log ARQKPWMRHRY;

				[Cpp2IlInjected.Token(Token = "0x4000089")]
				public static readonly Log YMCWVDNKPYP;

				[Cpp2IlInjected.Token(Token = "0x400008A")]
				public static readonly Log XVDCRDZUZGG;

				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public static readonly Log QZOPVQXSFDN;

				[Cpp2IlInjected.Token(Token = "0x400008C")]
				public static readonly Log FEYRGGAABUL;

				[Cpp2IlInjected.Token(Token = "0x400008D")]
				public static readonly Log HSJMYRKIIDV;

				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly Log YRFLAEUZZZJ;

				[Cpp2IlInjected.Token(Token = "0x400008F")]
				public static readonly Log QMDXZNSCUIO;

				[Cpp2IlInjected.Token(Token = "0x4000090")]
				public static readonly Log WECVVRJIOGE;

				[Cpp2IlInjected.Token(Token = "0x4000091")]
				public static readonly Log OMFFNDUCKPZ;

				[Cpp2IlInjected.Token(Token = "0x4000092")]
				public static readonly Log DXAPXCCARDD;

				[Cpp2IlInjected.Token(Token = "0x4000093")]
				public static readonly Log ATFCPMVDCPQ;

				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly Log CZXSXXAKWEP;
			}

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly Log IBKFVVFMRIY;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Network
		{
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public static class RRNetworkLayer
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly Log IBKFVVFMRIY;

				[Cpp2IlInjected.Token(Token = "0x400009B")]
				public static readonly Log OXTDISFDNHI;

				[Cpp2IlInjected.Token(Token = "0x400009C")]
				public static readonly Log WYHEQHXQSJM;

				[Cpp2IlInjected.Token(Token = "0x400009D")]
				public static readonly Log SHCTNHUYBUY;

				[Cpp2IlInjected.Token(Token = "0x400009E")]
				public static readonly Log FXHMXIDOXIY;
			}

			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public static class Photon
			{
				[Cpp2IlInjected.Token(Token = "0x2000023")]
				public static class Events
				{
					[Cpp2IlInjected.Token(Token = "0x40000AA")]
					private static readonly Log XZHRAOCCLYQ;

					[Cpp2IlInjected.Token(Token = "0x40000AB")]
					public static readonly Log WIRMRVVXSAT;

					[Cpp2IlInjected.Token(Token = "0x40000AC")]
					public static readonly Log TMAMEJIRGVO;

					[Cpp2IlInjected.Token(Token = "0x40000AD")]
					public static readonly Log KGQTTZATBTB;

					[Cpp2IlInjected.Token(Token = "0x40000AE")]
					public static readonly Log VPPBLPWVIPX;

					[Cpp2IlInjected.Token(Token = "0x40000AF")]
					public static readonly Log BFFXWJJVROX;

					[Cpp2IlInjected.Token(Token = "0x40000B0")]
					public static readonly Log SHCTNHUYBUY;

					[Cpp2IlInjected.Token(Token = "0x40000B1")]
					public static readonly Log FYOUKUGQZCL;
				}

				[Cpp2IlInjected.Token(Token = "0x400009F")]
				public static readonly Log IBKFVVFMRIY;

				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				public static readonly Log MAGMQBCAHJF;

				[Cpp2IlInjected.Token(Token = "0x40000A1")]
				public static readonly Log VUGNAUCSDNI;

				[Cpp2IlInjected.Token(Token = "0x40000A2")]
				public static readonly Log MLPFXBUMWDB;

				[Cpp2IlInjected.Token(Token = "0x40000A3")]
				public static readonly Log KEUQECWOYYM;

				[Cpp2IlInjected.Token(Token = "0x40000A4")]
				public static readonly Log WYHEQHXQSJM;

				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				public static readonly Log LBXPIXUUTIM;

				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				public static readonly Log HPGCGLYOLRJ;

				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				public static readonly Log TVKSWHEBPSS;

				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public static readonly Log DUTCDGDCRGV;

				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public static readonly Log JUCLSTMYOIA;
			}

			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public static readonly Log IBKFVVFMRIY;

			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public static readonly Log LSXNLWADMRQ;

			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly Log QLYILFCJYIN;

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly Log MACXGGGWHPU;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public static readonly Log KVOSWUHMXLG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class Patching
		{
			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public static class LogTransform
			{
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public static readonly Log IBKFVVFMRIY;

				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public static readonly Log OPHPAEQDUWZ;

				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				public static readonly Log JCCDDYKHFVC;

				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				public static readonly Log ZGOSLRIHOIY;

				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				public static readonly Log RFVFWPPQDQS;

				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				public static readonly Log XAMMVZKWSLF;

				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				public static readonly Log MBXASNXXMWR;

				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				public static readonly Log GVLAKHMFBUU;

				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public static readonly Log IMVRPXCMIJK;

				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public static readonly Log FDEMFPWQAXT;

				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public static readonly Log GUATTBZEHBV;

				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public static readonly Log JQJOCRCNUXC;

				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public static readonly Log SVCCQIDJECB;

				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public static readonly Log ZGFLPHPNKSP;
			}

			[Cpp2IlInjected.Token(Token = "0x2000026")]
			public static class LogLifecycle
			{
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public static readonly Log IBKFVVFMRIY;

				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public static readonly Log YYQCIFXCXDZ;

				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public static readonly Log AJHNZJBZQZT;
			}

			[Cpp2IlInjected.Token(Token = "0x2000027")]
			public static class GIASTPQULIK
			{
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public static readonly Log IBKFVVFMRIY;

				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public static readonly Log XXSFLOICXJF;

				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public static readonly Log YNUWIONNHNB;

				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public static readonly Log QYJMXIYRKRI;
			}

			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public static readonly Log IBKFVVFMRIY;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class Platform
		{
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private static readonly Log XZHRAOCCLYQ;

			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly Log RMVPLNSWTRS;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly Log EUWPPZAJDXR;

			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public static readonly Log AVQISOAKQWE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class Profiling
		{
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private static readonly Log XZHRAOCCLYQ;

			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public static readonly Log PQLQHLOFDVE;

			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public static readonly Log KSKQLXILEKE;

			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public static readonly Log CZXSXXAKWEP;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class RecNet
		{
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public static readonly Log IBKFVVFMRIY;

			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public static readonly Log MCNIUIBATPC;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class Rendering
		{
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public static readonly Log IBKFVVFMRIY;

			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public static readonly Log ZBXHGQZKGKO;

			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public static readonly Log MMZOCQLZLIL;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class RoomLoad
		{
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public static readonly Log IBKFVVFMRIY;

			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly Log GQYQGFXAAUL;

			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public static readonly Log XQKADIWEJOU;

			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public static readonly Log WAYZWCUFCMG;

			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public static readonly Log IOXWNGHJERA;

			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public static readonly Log UHSDWXUMLWA;

			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public static readonly Log ZOKJEZFRBPJ;

			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public static readonly Log TZXRDUYBLQS;

			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public static readonly Log MDGMPWJZBPC;

			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public static readonly Log NXNDIAFKSCU;

			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public static readonly Log KQTWCSGSARH;

			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly Log PLDCLQIFQLL;

			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly Log ZCMFNRZSNBH;

			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public static readonly Log BFCZXLBPXEX;

			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly Log WOBVIOFDWJV;

			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly Log QTTVMEZGBOB;

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public static readonly Log YUXFXYRIORK;

			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public static readonly Log GJBSHWBRYGE;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class RRUI
		{
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public static readonly Log IBKFVVFMRIY;

			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public static readonly Log JWSARMVAECV;

			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly Log SDZRORGYKXA;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly Log IPQJQEHTQIX;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly Log WWQXLATKZTQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Hile
		{
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private static readonly Log XZHRAOCCLYQ;

			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public static readonly Log KOBROPXRDZV;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class UGC
		{
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private static readonly Log XZHRAOCCLYQ;

			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public static readonly Log OORAELPRISB;

			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly Log RZUHVRBTENU;

			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public static readonly Log TDTINFYXVCT;

			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public static readonly Log IZYLEAEVTPU;

			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public static readonly Log YSNLMOBBWOG;

			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public static readonly Log TMBCPNRABHY;

			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly Log FNXSPPIHPLY;

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public static readonly Log RWKGBIVEJZC;

			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public static readonly Log POCAOXNDGMM;

			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly Log XMMOCGSMCAI;

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly Log JFFMXFPRBPL;

			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly Log VYTHPDKQQPE;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly Log MNRLCKUJSAD;

			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly Log WMRNRAAWRWA;

			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public static readonly Log WMCYPFGBNFP;

			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public static readonly Log HWTVBINTSSX;

			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public static readonly Log OLIXBQLQZCP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class Tools
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			public static class FastMeshTools
			{
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public static readonly Log IBKFVVFMRIY;

				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public static readonly Log GOAYHJFKBBU;

				[Cpp2IlInjected.Token(Token = "0x400010C")]
				public static readonly Log UTJQTLTPHTL;
			}

			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private static readonly Log IBKFVVFMRIY;

			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly Log FZHMHOZJMRE;

			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly Log WVCYHIDHHXY;

			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public static readonly Log XNUCFKFNCQZ;

			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public static readonly Log GVUBVQFADCO;

			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly Log ROKBYJNOIRI;

			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly Log SDVLDJGBZPE;

			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly Log PTBRAJUNIOK;

			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public static readonly Log NVDYLROMRAI;

			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public static readonly Log NBPCMHCMMQC;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class TrustAndSafety
		{
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			private static readonly Log XZHRAOCCLYQ;

			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly Log AZUGPQALKVW;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class Utilities
		{
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly Log IBKFVVFMRIY;
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class EnvironmentGen
		{
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public static readonly Log IBKFVVFMRIY;

			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public static readonly Log WNDZJZUKYYC;

			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly Log NTEQPKNNJZY;
		}
	}
}
namespace RecRoom.NoEngine.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class GQOOTZPVISD
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public class TSSRORNCOJX : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private readonly (int index, bool enabled)[] ZUQTXCEQODA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private List<(int index, bool enabled)> CXZXVMOGGOY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private bool GDNRSCTYHHI;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8B90B30", Offset = "0x8B8F730", VA = "0x188B90B30")]
			internal TSSRORNCOJX((Log log, bool stateToSet)[] configuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8B90AB0", Offset = "0x8B8F6B0", VA = "0x188B90AB0")]
			public IDisposable HYOAAOHHMBR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8B90A00", Offset = "0x8B8F600", VA = "0x188B90A00", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public static class KDTKCNUQLLY
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private static readonly Log XZHRAOCCLYQ;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly Log KIUMPELAMOK;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public static readonly Log FIIARLTUSKZ;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly Log DLUSLHEANUQ;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly Log TLBECBCUWAG;

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly Log ACYMMWEESRQ;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public static readonly Log FARIMEAAUJD;

		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly Log RZUHVRBTENU;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public static readonly Log XIMZEITYCNM;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static readonly Log INFUKJGABSG;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public static readonly Log UAIHXRHZYTC;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly Log ITKEJHBNMZL;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly Log QYMRQMDAMQQ;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly Log PYENIYMJQSV;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public static readonly Log QJININJYNQE;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public static readonly Log NQVMAFXMIGQ;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public static readonly Log TEGUNALOSBR;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly Log YSNLMOBBWOG;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly Log POGBGCNLYGS;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly Log KPDTKCITXHF;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static readonly Log PKQENYCCDOW;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public static readonly Log YRFLAEUZZZJ;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly Log WJVQILVDUWT;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly Log ZPAWFLUEKWK;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly Log UXELQQOUBIX;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly Log FKBOOUKWIUD;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly Log SPYKAOWJRZZ;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly Log YVDBIWDZSGE;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly Log AZKSVLQETOB;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly Log BCJPPBCALSS;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly Log EJCHCCKIEIB;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly Log BGCXBMNSRNS;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly Log KPFNJBEIRHT;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly Log IJEYXLSQKXK;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly Log JXHYXMJZFNF;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly Log AJSKXARUZFF;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly Log KOGSPMNRTVZ;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly Log XLMRGUUTISZ;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly Log LPWUITPJCCS;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly Log MLVAMDWIMUU;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly Log TRIDUMRYKKW;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly Log CBESLVXETEN;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly Log YHGZTXOLGVK;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly Log PRHARSLYJIR;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly Log UFTSEOCIIJX;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly Log QPEIOOFURGW;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly Log FOEIUEEUVSR;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Log IQNWMWWWPVZ
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8B844B0", Offset = "0x8B830B0", VA = "0x188B844B0")]
			get
			{
				return default(Log);
			}
		}
	}
}
namespace RecRoom.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal class KOLHMPTLCTL
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private KOLHMPTLCTL parent;

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
			public Scope(KOLHMPTLCTL parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly Stopwatch HVDZFYDTBRS;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x157B500", Offset = "0x157A100", VA = "0x18157B500")]
		public Scope BJPNLCEULRH()
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8B85A40", Offset = "0x8B84640", VA = "0x188B85A40")]
		public KOLHMPTLCTL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface FMVBUIZWJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void WZYWCRUQBLX(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BUABTVTCRZF(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void WEJRWAXQWGB(object a, [Optional] object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct LogRangeScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private readonly object message;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8B89400", Offset = "0x8B88000", VA = "0x188B89400")]
		public LogRangeScope(Log log, object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8B89390", Offset = "0x8B87F90", VA = "0x188B89390", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[Preserve]
	public abstract class LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void Register();

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected LogRegistrationIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal static class MKDIXEIPKHR
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private static List<LogRegistrationIndex> PIJISQOYEWW;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static bool UCWBSNBCBIJ;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private static readonly object RXRHKXRPVIA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static List<LogRegistrationIndex> ZHIHIFSTFVU
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8B8DA90", Offset = "0x8B8C690", VA = "0x188B8DA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8B8D910", Offset = "0x8B8C510", VA = "0x188B8D910")]
		public static List<LogRegistrationIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8B8D700", Offset = "0x8B8C300", VA = "0x188B8D700")]
		private static void DUAAQUAYMGY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8D4C0", Offset = "0x8B8C0C0", VA = "0x188B8D4C0")]
		private static void CTTRFDUNJSH(Assembly a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public static class KYHVZCRPUPU
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private struct Debug
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private List<(byte version, ParanoiaLevel level)> paranoiaLevel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private HashSet<(string, int)> triggered;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private byte version;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8B826D0", Offset = "0x8B812D0", VA = "0x188B826D0")]
			public static Debug Create()
			{
				return default(Debug);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8B82610", Offset = "0x8B81210", VA = "0x188B82610")]
			public void CRLCJDAZFAK(int a, ParanoiaLevel b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x8B82840", Offset = "0x8B81440", VA = "0x188B82840")]
			public ParanoiaLevel ZENIOKFVOHE(int a)
			{
				return default(ParanoiaLevel);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8B827A0", Offset = "0x8B813A0", VA = "0x188B827A0")]
			public bool UZVEMAZLKXQ(string a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8B82550", Offset = "0x8B81150", VA = "0x188B82550")]
			public void Add()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static Action AVHYZZKNVQP;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly object XNNXNAZZIYH;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private static readonly Dictionary<(int parentIndex, string token), int> IWQCPNIHVPT;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private static readonly List<string> GKTPSHDVGDH;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private static readonly List<int> OYMRWFXSOJG;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static readonly List<ulong> YYATFRGREUI;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly List<ulong> KUPYVEXXIDL;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private static readonly List<ulong> DQELFOPCHGE;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private static readonly StringBuilder QSAKQQTVJWY;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private static readonly KOLHMPTLCTL BNXARLMEDQG;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private static Debug JYFTCKEPTIU;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private static int TKRJRIBVHGI;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static FMVBUIZWJKI ZDUXGRPYFEZ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8B88B20", Offset = "0x8B87720", VA = "0x188B88B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8B87080", Offset = "0x8B85C80", VA = "0x188B87080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool HYDTNGPLLJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8B87F60", Offset = "0x8B86B60", VA = "0x188B87F60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool XVZSGWENOOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8B87580", Offset = "0x8B86180", VA = "0x188B87580")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool FPVEJMHSIRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8B85AB0", Offset = "0x8B846B0", VA = "0x188B85AB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8B88B70", Offset = "0x8B87770", VA = "0x188B88B70")]
		static KYHVZCRPUPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8B872B0", Offset = "0x8B85EB0", VA = "0x188B872B0")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8B85F50", Offset = "0x8B84B50", VA = "0x188B85F50")]
		public static int ERBMWTZFFKA(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8B85E80", Offset = "0x8B84A80", VA = "0x188B85E80")]
		public static int ERBMWTZFFKA(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8B87030", Offset = "0x8B85C30", VA = "0x188B87030")]
		public static Log HHAVBMAAPKK(string a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8B875D0", Offset = "0x8B861D0", VA = "0x188B875D0")]
		public static void OHLWLYYSMQT(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8B85B40", Offset = "0x8B84740", VA = "0x188B85B40")]
		public static void AZJERDMORYI(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8B87B60", Offset = "0x8B86760", VA = "0x188B87B60")]
		public static bool TGKSSRHFJBE(Log a, Log b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8B88020", Offset = "0x8B86C20", VA = "0x188B88020")]
		public static int VBWXAJFEJON(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8B86990", Offset = "0x8B85590", VA = "0x188B86990")]
		public static string FLENXGLLLCI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8B86260", Offset = "0x8B84E60", VA = "0x188B86260")]
		public static (string[], int[]) FBGDBCZXOYD()
		{
			return default((string[], int[]));
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8B889A0", Offset = "0x8B875A0", VA = "0x188B889A0")]
		private static int ZBIUOLLXJVD(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8B87D50", Offset = "0x8B86950", VA = "0x188B87D50")]
		private static int UDLFXKUJTAD(int a, string b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8B86410", Offset = "0x8B85010", VA = "0x188B86410")]
		private static int FLDJMPCTCFD(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8B87800", Offset = "0x8B86400", VA = "0x188B87800")]
		private static int QSXQZAHKWFE(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8B878D0", Offset = "0x8B864D0", VA = "0x188B878D0")]
		private static int QSXQZAHKWFE(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8B87BE0", Offset = "0x8B867E0", VA = "0x188B87BE0")]
		private static void THSZXZMKQQR(int a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8B85D50", Offset = "0x8B84950", VA = "0x188B85D50")]
		public static bool CFCYFJTLGAR(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8B874C0", Offset = "0x8B860C0", VA = "0x188B874C0")]
		public static bool LKAUDLEKGMY(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B88450", Offset = "0x8B87050", VA = "0x188B88450")]
		public static void YOJPJPZHGWM(IEnumerable<(int index, bool enabled)> values, bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8B86C00", Offset = "0x8B85800", VA = "0x188B86C00")]
		public static void GIHXCNHJCWX(IEnumerable<(int index, bool enabled)> values, List<(int index, bool enabled)> currentState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B87790", Offset = "0x8B86390", VA = "0x188B87790")]
		private static void OPYWNTVXTDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8B88170", Offset = "0x8B86D70", VA = "0x188B88170")]
		private static void VEYGVESALXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8B87170", Offset = "0x8B85D70", VA = "0x188B87170")]
		private static bool IWUACHXLELW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8B87E00", Offset = "0x8B86A00", VA = "0x188B87E00")]
		private static bool UGOOXZUEINZ(int a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8B870F0", Offset = "0x8B85CF0", VA = "0x188B870F0")]
		private static bool ISEUZOZZVYH(List<ulong> a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8B87AA0", Offset = "0x8B866A0", VA = "0x188B87AA0")]
		private static void Set(List<ulong> bitList, int bitIndex, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B86FC0", Offset = "0x8B85BC0", VA = "0x188B86FC0")]
		private static void GQFYZMADDWF(List<ulong> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8B860F0", Offset = "0x8B84CF0", VA = "0x188B860F0")]
		public static GQOOTZPVISD.TSSRORNCOJX EUPBIBWICKT((Log log, bool stateToSet)[] logGroupsAndValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B87FB0", Offset = "0x8B86BB0", VA = "0x188B87FB0")]
		public static bool UZVEMAZLKXQ(string a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8B85E10", Offset = "0x8B84A10", VA = "0x188B85E10")]
		public static void CRLCJDAZFAK(int a, ParanoiaLevel b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B88AC0", Offset = "0x8B876C0", VA = "0x188B88AC0")]
		public static ParanoiaLevel ZENIOKFVOHE(int a)
		{
			return default(ParanoiaLevel);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum ParanoiaLevel : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		FastDebug,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		Debug,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		Paranoid,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		SuperParanoid,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		MassivelyParanoid
	}
}
namespace RecRoom.Logging.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[Obfuscation(Exclude = true)]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public PreserveAttribute()
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
