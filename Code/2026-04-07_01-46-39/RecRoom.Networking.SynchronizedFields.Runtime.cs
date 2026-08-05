using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.DataLayer;
using RecRoom.Foundation;
using RecRoom.Networking.DataTypes;
using RecRoom.Networking.SynchronizedFields;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface EAZHVFPJVKR : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool LSIRUQJUWMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool LCHYKCEDFBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		QCTMRFTYWMB NHPMTWHLEQG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int RVTAWRESVNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool WZACPETGXTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool AHPPUJOWJJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action CPYAPDSKAJK;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void ROUMEMOBADP();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void NDYHVYHTSRD(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void VTUQVMNTJBF();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface GROWKGMMDPA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string AOHZFAYUMAF
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool CGZZNNMFODR
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface AKTWQMIGIAV<a> : GROWKGMMDPA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a WKCJPKBDNDN
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WGKPQUMZRBQ(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class LZAOIAUDMIS<a> : AKTWQMIGIAV<a>, GROWKGMMDPA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly ZZRRLPIZEBF<a> MNTDSOBENIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly ZZRRLPIZEBF<a> YCZYRBJHMYO;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string AOHZFAYUMAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xFA3130", Offset = "0xFA2130", VA = "0x180FA3130", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool XHQCBHNVGZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x698BB20", Offset = "0x698AB20", VA = "0x18698BB20", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a HFHJGZEXYHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x698BFE0", Offset = "0x698AFE0", VA = "0x18698BFE0", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x698EC30", Offset = "0x698DC30", VA = "0x18698EC30", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a WKCJPKBDNDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x698B790", Offset = "0x698A790", VA = "0x18698B790", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x698B620", Offset = "0x698A620", VA = "0x18698B620", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a WZVCBEIJRSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x698B790", Offset = "0x698A790", VA = "0x18698B790")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x698CAE0", Offset = "0x698BAE0", VA = "0x18698CAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool CGZZNNMFODR
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x697CA00", Offset = "0x697BA00", VA = "0x18697CA00", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x697CA20", Offset = "0x697BA20", VA = "0x18697CA20", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool DVVCXGHSQVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x698C940", Offset = "0x698B940", VA = "0x18698C940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x698C3C0", Offset = "0x698B3C0", VA = "0x18698C3C0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6990140", Offset = "0x698F140", VA = "0x186990140")]
		public LZAOIAUDMIS([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x698DD20", Offset = "0x698CD20", VA = "0x18698DD20")]
		private void UPASHYGICKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x698E2D0", Offset = "0x698D2D0", VA = "0x18698E2D0", Slot = "5")]
		public void WGKPQUMZRBQ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x698E790", Offset = "0x698D790", VA = "0x18698E790")]
		public void WGKPQUMZRBQ(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x697C1F0", Offset = "0x697B1F0", VA = "0x18697C1F0", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class LYVHKUAGCXJ<a, b> : AKTWQMIGIAV<(a, b)>, GROWKGMMDPA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly ZZWYIWCWNMO<a, b> MNTDSOBENIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly ZZWYIWCWNMO<a, b> YCZYRBJHMYO;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string AOHZFAYUMAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xFA3130", Offset = "0xFA2130", VA = "0x180FA3130", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool XHQCBHNVGZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6985A50", Offset = "0x6984A50", VA = "0x186985A50", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool BTNCSJXCWMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6987050", Offset = "0x6986050", VA = "0x186987050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool BUCXKEEUYUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6987470", Offset = "0x6986470", VA = "0x186987470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) HFHJGZEXYHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6985F40", Offset = "0x6984F40", VA = "0x186985F40", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6989860", Offset = "0x6988860", VA = "0x186989860", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) WKCJPKBDNDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6988930", Offset = "0x6987930", VA = "0x186988930", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6984A30", Offset = "0x6983A30", VA = "0x186984A30", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) WZVCBEIJRSP
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6985570", Offset = "0x6984570", VA = "0x186985570")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6987AE0", Offset = "0x6986AE0", VA = "0x186987AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a XYBUIVHCDIP
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x69853C0", Offset = "0x69843C0", VA = "0x1869853C0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6984570", Offset = "0x6983570", VA = "0x186984570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a ZGWEYNIHZTI
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6988380", Offset = "0x6987380", VA = "0x186988380")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6988EF0", Offset = "0x6987EF0", VA = "0x186988EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a HIGJLHBKIIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6988380", Offset = "0x6987380", VA = "0x186988380")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x69867B0", Offset = "0x69857B0", VA = "0x1869867B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b XYHBGCAZMTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6985340", Offset = "0x6984340", VA = "0x186985340")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6984170", Offset = "0x6983170", VA = "0x186984170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b ZGQYBGOKQHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6988280", Offset = "0x6987280", VA = "0x186988280")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b HIBCOAHMYXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6988280", Offset = "0x6987280", VA = "0x186988280")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x69869E0", Offset = "0x69859E0", VA = "0x1869869E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool CGZZNNMFODR
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x697CA00", Offset = "0x697BA00", VA = "0x18697CA00", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x697CA20", Offset = "0x697BA20", VA = "0x18697CA20", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x69879E0", Offset = "0x69869E0", VA = "0x1869879E0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x698AB00", Offset = "0x6989B00", VA = "0x18698AB00")]
		public LYVHKUAGCXJ([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6987DC0", Offset = "0x6986DC0", VA = "0x186987DC0")]
		private void UPASHYGICKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6985160", Offset = "0x6984160", VA = "0x186985160")]
		public void GQLJNZPPWKX(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6988AE0", Offset = "0x6987AE0", VA = "0x186988AE0")]
		public void WGKPQUMZRBQ(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6989040", Offset = "0x6988040", VA = "0x186989040", Slot = "5")]
		private void YNBJGAIAXHL((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x697C1F0", Offset = "0x697B1F0", VA = "0x18697C1F0", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class LYQANNGITMA<a, b, c> : AKTWQMIGIAV<(a, b, c)>, GROWKGMMDPA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly AACFGCWTWXX<a, b, c> MNTDSOBENIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly AACFGCWTWXX<a, b, c> YCZYRBJHMYO;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string AOHZFAYUMAF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xFA3130", Offset = "0xFA2130", VA = "0x180FA3130", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool XHQCBHNVGZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6980080", Offset = "0x697F080", VA = "0x186980080", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool BTNCSJXCWMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x69810F0", Offset = "0x69800F0", VA = "0x1869810F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool BUCXKEEUYUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x69811D0", Offset = "0x69801D0", VA = "0x1869811D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool BTXQMXKXPJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x69815F0", Offset = "0x69805F0", VA = "0x1869815F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) HFHJGZEXYHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6980380", Offset = "0x697F380", VA = "0x186980380", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6983200", Offset = "0x6982200", VA = "0x186983200", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) WKCJPKBDNDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6982710", Offset = "0x6981710", VA = "0x186982710", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x697F0E0", Offset = "0x697E0E0", VA = "0x18697F0E0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a XYBUIVHCDIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x697F700", Offset = "0x697E700", VA = "0x18697F700")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x697ED40", Offset = "0x697DD40", VA = "0x18697ED40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a ZGWEYNIHZTI
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x69822B0", Offset = "0x69812B0", VA = "0x1869822B0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a HIGJLHBKIIK
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x69822B0", Offset = "0x69812B0", VA = "0x1869822B0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x69808A0", Offset = "0x697F8A0", VA = "0x1869808A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b XYHBGCAZMTY
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x697F620", Offset = "0x697E620", VA = "0x18697F620")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x697E810", Offset = "0x697D810", VA = "0x18697E810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b ZGQYBGOKQHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x69820F0", Offset = "0x69810F0", VA = "0x1869820F0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b HIBCOAHMYXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x69820F0", Offset = "0x69810F0", VA = "0x1869820F0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6980BA0", Offset = "0x697FBA0", VA = "0x186980BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c XYMIDIUWWFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x697F5F0", Offset = "0x697E5F0", VA = "0x18697F5F0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x697E550", Offset = "0x697D550", VA = "0x18697E550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c ZGLRDZUNGWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6982120", Offset = "0x6981120", VA = "0x186982120")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c HHVVQTNPPLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6982120", Offset = "0x6981120", VA = "0x186982120")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6980DC0", Offset = "0x697FDC0", VA = "0x186980DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool CGZZNNMFODR
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x697CA00", Offset = "0x697BA00", VA = "0x18697CA00", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6981B00", Offset = "0x6980B00", VA = "0x186981B00", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x69839E0", Offset = "0x69829E0", VA = "0x1869839E0")]
		public LYQANNGITMA([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6981E60", Offset = "0x6980E60", VA = "0x186981E60")]
		private void UPASHYGICKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x697F3C0", Offset = "0x697E3C0", VA = "0x18697F3C0")]
		public void GQLJNZPPWKX(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x697F8A0", Offset = "0x697E8A0", VA = "0x18697F8A0")]
		public void HWMPHXLKROI(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x697FDD0", Offset = "0x697EDD0", VA = "0x18697FDD0")]
		public void KQSQQBMVNRT(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6982800", Offset = "0x6981800", VA = "0x186982800")]
		public void WGKPQUMZRBQ(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6981980", Offset = "0x6980980", VA = "0x186981980", Slot = "5")]
		private void QZTTLAPJRPM((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x697C1F0", Offset = "0x697B1F0", VA = "0x18697C1F0", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class LYKTQGMLKAR<a, b, c, d> : AKTWQMIGIAV<(a, b, c, d)>, GROWKGMMDPA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly ZYRIZHNMIWM<a, b, c, d> MNTDSOBENIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly ZYRIZHNMIWM<a, b, c, d> YCZYRBJHMYO;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string AOHZFAYUMAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xFA3130", Offset = "0xFA2130", VA = "0x180FA3130", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) WKCJPKBDNDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x697D450", Offset = "0x697C450", VA = "0x18697D450", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x697C230", Offset = "0x697B230", VA = "0x18697C230", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b ZGQYBGOKQHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x697D340", Offset = "0x697C340", VA = "0x18697D340")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c ZGLRDZUNGWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x697D370", Offset = "0x697C370", VA = "0x18697D370")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d ZGGKGTAPXLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x697D260", Offset = "0x697C260", VA = "0x18697D260")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool CGZZNNMFODR
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x697CA00", Offset = "0x697BA00", VA = "0x18697CA00", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x697CA20", Offset = "0x697BA20", VA = "0x18697CA20", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x697E350", Offset = "0x697D350", VA = "0x18697E350")]
		public LYKTQGMLKAR([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x697CE10", Offset = "0x697BE10", VA = "0x18697CE10")]
		private void UPASHYGICKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x697C910", Offset = "0x697B910", VA = "0x18697C910")]
		public void GQLJNZPPWKX(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x697D950", Offset = "0x697C950", VA = "0x18697D950")]
		public void WGKPQUMZRBQ(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x697CA40", Offset = "0x697BA40", VA = "0x18697CA40", Slot = "5")]
		private void SHCIBIGDFRS((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x697C1F0", Offset = "0x697B1F0", VA = "0x18697C1F0", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class WDTZSMLAFRB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5FF0", Offset = "0x9AF4FF0", VA = "0x189AF5FF0")]
		public static string LENLFLAZTAK(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xD606C0", Offset = "0xD5F6C0", VA = "0x180D606C0")]
		public static NetworkSetterPermissionMode TUGYBWVZWFZ(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ZZRRLPIZEBF<a> : YVZECQQFEQO<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x514E380", Offset = "0x514D380", VA = "0x18514E380")]
		public ZZRRLPIZEBF([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x514E4D0", Offset = "0x514D4D0", VA = "0x18514E4D0")]
		public ZZRRLPIZEBF(CFJGLFDIMUU a, QCTMRFTYWMB b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] KREGEBXKHLE g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5150490", Offset = "0x514F490", VA = "0x185150490")]
		public ZZRRLPIZEBF(CFJGLFDIMUU a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] KREGEBXKHLE f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x514FBF0", Offset = "0x514EBF0", VA = "0x18514FBF0")]
		public ZZRRLPIZEBF(CFJGLFDIMUU a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] KREGEBXKHLE g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ZZWYIWCWNMO<a, b> : YVTXFJWHVFF<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5157730", Offset = "0x5156730", VA = "0x185157730")]
		public ZZWYIWCWNMO([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5156600", Offset = "0x5155600", VA = "0x185156600")]
		public ZZWYIWCWNMO(CFJGLFDIMUU a, QCTMRFTYWMB b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] KREGEBXKHLE h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5153950", Offset = "0x5152950", VA = "0x185153950")]
		public ZZWYIWCWNMO(CFJGLFDIMUU a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] KREGEBXKHLE g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x51568D0", Offset = "0x51558D0", VA = "0x1851568D0")]
		public ZZWYIWCWNMO(CFJGLFDIMUU a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] KREGEBXKHLE h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AACFGCWTWXX<a, b, c> : YVOQIDCKLTW<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7310880", Offset = "0x730F880", VA = "0x187310880")]
		public AACFGCWTWXX([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7310B80", Offset = "0x730FB80", VA = "0x187310B80")]
		public AACFGCWTWXX(CFJGLFDIMUU a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] KREGEBXKHLE h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ZYRIZHNMIWM<a, b, c, d> : YWZMOYLRZVH<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x514B180", Offset = "0x514A180", VA = "0x18514B180")]
		public ZYRIZHNMIWM([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x514BDE0", Offset = "0x514ADE0", VA = "0x18514BDE0")]
		public ZYRIZHNMIWM(CFJGLFDIMUU a, QCTMRFTYWMB b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] KREGEBXKHLE j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x514A870", Offset = "0x5149870", VA = "0x18514A870")]
		public ZYRIZHNMIWM(CFJGLFDIMUU a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] KREGEBXKHLE i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ZYWPWOHJSHV<a, b, c, d, e> : YWUFRRRUQJY<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x514CB50", Offset = "0x514BB50", VA = "0x18514CB50")]
		public ZYWPWOHJSHV(CFJGLFDIMUU a, QCTMRFTYWMB b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] KREGEBXKHLE k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x514C2D0", Offset = "0x514B2D0", VA = "0x18514C2D0")]
		public ZYWPWOHJSHV(CFJGLFDIMUU a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] KREGEBXKHLE j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class NWOYKBYOSUU<a> : YVZECQQFEQO<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x72A4180", Offset = "0x72A3180", VA = "0x1872A4180")]
		public NWOYKBYOSUU(QCTMRFTYWMB a, string b, a c, [Optional] Action d, [Optional] KREGEBXKHLE e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class NXETBWGGVCV<a, b> : YVTXFJWHVFF<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x72A5840", Offset = "0x72A4840", VA = "0x1872A5840")]
		public NXETBWGGVCV(QCTMRFTYWMB a, string b, a c, b d, [Optional] Action e, [Optional] KREGEBXKHLE f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface JGASMPDQHJS
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ZZRRLPIZEBF<a> ITHMCTUHTEQ<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ZHBGNTGNNYV : JGASMPDQHJS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly KREGEBXKHLE LEHYWGRMGBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly CFJGLFDIMUU YNXGERMLHNT;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xCFB2A0", Offset = "0xCFA2A0", VA = "0x180CFB2A0")]
		public ZHBGNTGNNYV(KREGEBXKHLE a, CFJGLFDIMUU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x41227A0", Offset = "0x41217A0", VA = "0x1841227A0", Slot = "4")]
		public ZZRRLPIZEBF<a> ITHMCTUHTEQ<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface WPPRRRCTRXL : CFJGLFDIMUU
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId MWMTAEFULFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface CFJGLFDIMUU
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool UVANAIIVOHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool UJLJNBHBEWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string LRBOLRNXDRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool XTYRDOAVEKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(KQPVLPWWDOO handler);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(KQPVLPWWDOO handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class WADGVWSUQSC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5FA0", Offset = "0x9AF4FA0", VA = "0x189AF5FA0")]
		public static bool YMCVKIPUGOJ(this CFJGLFDIMUU a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface KREGEBXKHLE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		QCTMRFTYWMB BZISNAJGEBG
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool DVVCXGHSQVN
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool CBXBNDHBZZI
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Initialize();

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object HPFIIQORALA(string a);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object UCNIRXLPGZG(QCTMRFTYWMB a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void QTYENWCRTAO(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void DHYOFTKQTWM(QCTMRFTYWMB a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void SIEBLBMTUAB<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void WCRJJKDTTZN([CanBeNull] QCTMRFTYWMB photonPlayer, string a, SAFTBJAXEWQ b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void TLQCAXCXTTA([CanBeNull] QCTMRFTYWMB photonPlayer, string a, SAFTBJAXEWQ b);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b BAEKBPGWWKG<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object ABHILBATQLJ<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		object BAEKBPGWWKG(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		object ABHILBATQLJ(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void BBKAFTSTWPI();

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void LOLTRADIDJW();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void COGDWEZPXHZ(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public QCTMRFTYWMB player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CFJGLFDIMUU context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public string key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public NetworkSetterPermissionMode permissionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool enforceInitialValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Action callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public KREGEBXKHLE networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5D90", Offset = "0x9AF4D90", VA = "0x189AF5D90")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5E10", Offset = "0x9AF4E10", VA = "0x189AF5E10")]
		public SyncData(CFJGLFDIMUU context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] KREGEBXKHLE networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5D40", Offset = "0x9AF4D40", VA = "0x189AF5D40")]
		public static SyncData From(CFJGLFDIMUU context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] KREGEBXKHLE networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class PSCZQWUHZVF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3D7B140", Offset = "0x3D7A140", VA = "0x183D7B140")]
		public static ZZRRLPIZEBF<a> SAFTBJAXEWQ<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3D7A730", Offset = "0x3D79730", VA = "0x183D7A730")]
		public static ZZWYIWCWNMO<b, c> SAFTBJAXEWQ<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3D7A7D0", Offset = "0x3D797D0", VA = "0x183D7A7D0")]
		public static AACFGCWTWXX<d, e, f> SAFTBJAXEWQ<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3D7ABF0", Offset = "0x3D79BF0", VA = "0x183D7ABF0")]
		public static ZYRIZHNMIWM<g, h, i, j> SAFTBJAXEWQ<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D79780", Offset = "0x3D78780", VA = "0x183D79780")]
		public static LZAOIAUDMIS<k> HOFXWRFQKCZ<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3D79630", Offset = "0x3D78630", VA = "0x183D79630")]
		public static LYVHKUAGCXJ<l, m> HOFXWRFQKCZ<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3D796D0", Offset = "0x3D786D0", VA = "0x183D796D0")]
		public static LYQANNGITMA<n, o, p> HOFXWRFQKCZ<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3D7A140", Offset = "0x3D79140", VA = "0x183D7A140")]
		public static LYKTQGMLKAR<q, r, s, t> HOFXWRFQKCZ<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class SAFTBJAXEWQ : KQPVLPWWDOO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[Flags]
		private enum Flags
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			Disposed = 1,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			LastSetLocally = 2,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			Synchronizing = 4,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			ModifiedOffline = 8,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			Default = 4
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static Stack<KREGEBXKHLE> WBOLZRMYLMC;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool GYZFXPBQBFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly QCTMRFTYWMB MBQIVTKLVAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly CFJGLFDIMUU YNXGERMLHNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string QMCRYWZIPRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode ETFLXLXRESC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action YYIZMHSJRBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected KREGEBXKHLE FDLNHZDSTYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags GKUOXQORORP;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static KREGEBXKHLE QZCVRVGUVXQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9AF4E90", Offset = "0x9AF3E90", VA = "0x189AF4E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool RQQBQGIMSRQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9AF51A0", Offset = "0x9AF41A0", VA = "0x189AF51A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9AF56A0", Offset = "0x9AF46A0", VA = "0x189AF56A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool OEHCTJGKEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9AF5190", Offset = "0x9AF4190", VA = "0x189AF5190")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9AF4F80", Offset = "0x9AF3F80", VA = "0x189AF4F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool PHSBJXBAFZK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9AF5270", Offset = "0x9AF4270", VA = "0x189AF5270")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x9AF5A60", Offset = "0x9AF4A60", VA = "0x189AF5A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool CGZZNNMFODR
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x9AF4BD0", Offset = "0x9AF3BD0", VA = "0x189AF4BD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9AF51B0", Offset = "0x9AF41B0", VA = "0x189AF51B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object KDUWUASGBUN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCFC240", Offset = "0xCFB240", VA = "0x180CFC240", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool QKHKDKCJLYA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x9AF4950", Offset = "0x9AF3950", VA = "0x189AF4950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int DAQNDVBBPLV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xED7420", Offset = "0xED6420", VA = "0x180ED7420")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1AABF50", Offset = "0x1AAAF50", VA = "0x181AABF50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string AOHZFAYUMAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool DVVCXGHSQVN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x9AF54B0", Offset = "0x9AF44B0", VA = "0x189AF54B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5930", Offset = "0x9AF4930", VA = "0x189AF5930")]
		public static void YTCDFICBPWX(KREGEBXKHLE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool WQFHMYPPRKN();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5B20", Offset = "0x9AF4B20", VA = "0x189AF5B20")]
		protected SAFTBJAXEWQ(QCTMRFTYWMB a, CFJGLFDIMUU b, string c, NetworkSetterPermissionMode d, Action e, KREGEBXKHLE f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9AF49A0", Offset = "0x9AF39A0", VA = "0x189AF49A0", Slot = "1")]
		~SAFTBJAXEWQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4730", Offset = "0x9AF3730", VA = "0x189AF4730", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9AF50F0", Offset = "0x9AF40F0", VA = "0x189AF50F0")]
		private void NUQSFCDJBBZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4A00", Offset = "0x9AF3A00", VA = "0x189AF4A00")]
		private object GTQFLIWHLFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4CC0", Offset = "0x9AF3CC0", VA = "0x189AF4CC0")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5500", Offset = "0x9AF4500", VA = "0x189AF5500")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9AF56E0", Offset = "0x9AF46E0", VA = "0x189AF56E0")]
		protected void YDVKBNOAAFE(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9AF53C0", Offset = "0x9AF43C0", VA = "0x189AF53C0")]
		internal void QQOEOTSMFAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4F20", Offset = "0x9AF3F20", VA = "0x189AF4F20")]
		private void MKCHGVPFNOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4B70", Offset = "0x9AF3B70", VA = "0x189AF4B70")]
		private void IFSQVERUESZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5440", Offset = "0x9AF4440", VA = "0x189AF5440", Slot = "4")]
		private void SHUSYAHPXCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9AF56C0", Offset = "0x9AF46C0", VA = "0x189AF56C0", Slot = "5")]
		private void WNBKECIEEBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5280", Offset = "0x9AF4280", VA = "0x189AF5280")]
		public bool QMKDOBQDRKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4570", Offset = "0x9AF3570", VA = "0x189AF4570")]
		public bool BPZDSBUSLNC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4FA0", Offset = "0x9AF3FA0", VA = "0x189AF4FA0")]
		private bool NAOZHIFPNMP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9AF48A0", Offset = "0x9AF38A0", VA = "0x189AF48A0")]
		internal void EYZEZMFOULW(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4460", Offset = "0x9AF3460", VA = "0x189AF4460")]
		private void AOTYGQNOIVW(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9AF56D0", Offset = "0x9AF46D0", VA = "0x189AF56D0")]
		private bool XUPCXOYZJTK(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4F00", Offset = "0x9AF3F00", VA = "0x189AF4F00")]
		private void KFXJWJRBQWE(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9AF59D0", Offset = "0x9AF49D0", VA = "0x189AF59D0")]
		public static string YTUHHXMAXXA(QCTMRFTYWMB a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4BE0", Offset = "0x9AF3BE0", VA = "0x189AF4BE0")]
		public static string IPPKMFTNVSS(CFJGLFDIMUU a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5540", Offset = "0x9AF4540", VA = "0x189AF5540")]
		public static bool TUCJCETAVKU(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class PCDHOWEMKMK : KREGEBXKHLE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<object, object> NOJNNXJXSKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<string> YJONITXSGCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<object, object> JRAAFTLSFIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> EFJBSXRCXWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool BBOLEABAMSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly Dictionary<string, object> QNQJPJIJUKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<QCTMRFTYWMB, Dictionary<string, object>> ETHWZKMHVLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<string> NRLCLQWOIME;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> WAFPNJSMHMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int IOFAOQYCKQN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract QCTMRFTYWMB BZISNAJGEBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool DVVCXGHSQVN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool CBXBNDHBZZI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool FROKDXRDNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool ZANTMLNUIXH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xD4F720", Offset = "0xD4E720", VA = "0x180D4F720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3D720B0", Offset = "0x3D710B0", VA = "0x183D720B0", Slot = "12")]
		public void SIEBLBMTUAB<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2220", Offset = "0x9AF1220", VA = "0x189AF2220", Slot = "11")]
		public void DHYOFTKQTWM(QCTMRFTYWMB a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9AF3BB0", Offset = "0x9AF2BB0", VA = "0x189AF3BB0", Slot = "9")]
		public object UCNIRXLPGZG(QCTMRFTYWMB a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9AF3030", Offset = "0x9AF2030", VA = "0x189AF3030", Slot = "10")]
		public void QTYENWCRTAO(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2860", Offset = "0x9AF1860", VA = "0x189AF2860", Slot = "8")]
		public object HPFIIQORALA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9AF3D00", Offset = "0x9AF2D00", VA = "0x189AF3D00", Slot = "13")]
		public void WCRJJKDTTZN(QCTMRFTYWMB a, string b, SAFTBJAXEWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9AF35C0", Offset = "0x9AF25C0", VA = "0x189AF35C0", Slot = "14")]
		public void TLQCAXCXTTA(QCTMRFTYWMB a, string b, SAFTBJAXEWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2900", Offset = "0x9AF1900", VA = "0x189AF2900")]
		private void IEHNIOYWLZE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2CC0", Offset = "0x9AF1CC0", VA = "0x189AF2CC0")]
		private void PCFJFKRNWWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9AF3CA0", Offset = "0x9AF2CA0", VA = "0x189AF3CA0")]
		private void VXEJKZRCMZB(QCTMRFTYWMB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2F10", Offset = "0x9AF1F10", VA = "0x189AF2F10")]
		protected void QTDNLHFUXTV(QCTMRFTYWMB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9AF26A0", Offset = "0x9AF16A0", VA = "0x189AF26A0")]
		protected void FEIXJOTYFTP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2950", Offset = "0x9AF1950", VA = "0x189AF2950")]
		protected void KJGJCCIXRPD(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4170", Offset = "0x9AF3170", VA = "0x189AF4170")]
		protected void YOGUMBABMZB(QCTMRFTYWMB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9AF3B20", Offset = "0x9AF2B20", VA = "0x189AF3B20")]
		protected void TYPJTTQJDBR(QCTMRFTYWMB a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9AF3150", Offset = "0x9AF2150", VA = "0x189AF3150")]
		private void RIVUWQJMFRU(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2D10", Offset = "0x9AF1D10", VA = "0x189AF2D10")]
		private static void PYNIDQPHMRQ(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9AF3900", Offset = "0x9AF2900", VA = "0x189AF3900")]
		private static void TUIKCWZJLVH(Dictionary<string, object> a, string b, SAFTBJAXEWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2370", Offset = "0x9AF1370", VA = "0x189AF2370")]
		private static void DKILXFDITVC(Dictionary<string, object> a, string b, SAFTBJAXEWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9AF1C80", Offset = "0x9AF0C80", VA = "0x189AF1C80", Slot = "19")]
		public void BBKAFTSTWPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract void NPBIINDWDVF(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2960", Offset = "0x9AF1960", VA = "0x189AF2960", Slot = "20")]
		public void LOLTRADIDJW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		protected abstract void MURTVLAQDZP(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9AF1D80", Offset = "0x9AF0D80", VA = "0x189AF1D80")]
		private void BFPBSRAQLSI(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2A40", Offset = "0x9AF1A40", VA = "0x189AF2A40")]
		private void MAUHEZBPRGZ(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9AF3870", Offset = "0x9AF2870", VA = "0x189AF3870")]
		public void TPJJWCGWCFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2790", Offset = "0x9AF1790", VA = "0x189AF2790")]
		public void HMTNBMQGTNQ(QCTMRFTYWMB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9AF3E10", Offset = "0x9AF2E10", VA = "0x189AF3E10")]
		public void WPRYUQOMYGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		protected abstract HashSet<int> WIJLCVHBBGP(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9AF1FA0", Offset = "0x9AF0FA0", VA = "0x189AF1FA0", Slot = "21")]
		public void COGDWEZPXHZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9AF41E0", Offset = "0x9AF31E0", VA = "0x189AF41E0")]
		protected string YTUHHXMAXXA(QCTMRFTYWMB a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "32")]
		public abstract object ABHILBATQLJ<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "33")]
		public abstract c BAEKBPGWWKG<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "34")]
		public abstract object ABHILBATQLJ(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "35")]
		public abstract object BAEKBPGWWKG(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "36")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2540", Offset = "0x9AF1540", VA = "0x189AF2540", Slot = "22")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "37")]
		protected virtual void HGIWMRUMFRA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4270", Offset = "0x9AF3270", VA = "0x189AF4270")]
		protected PCDHOWEMKMK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class YVZECQQFEQO<a> : SAFTBJAXEWQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private a BNJAGXOLQZR;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a HBXHMBFCUUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x50F5640", Offset = "0x50F4640", VA = "0x1850F5640", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x50F4C70", Offset = "0x50F3C70", VA = "0x1850F4C70", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object KDUWUASGBUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x50E2B90", Offset = "0x50E1B90", VA = "0x1850E2B90", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x50F4FD0", Offset = "0x50F3FD0", VA = "0x1850F4FD0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x50F8820", Offset = "0x50F7820", VA = "0x1850F8820", Slot = "9")]
		protected override bool WQFHMYPPRKN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x50F9FE0", Offset = "0x50F8FE0", VA = "0x1850F9FE0")]
		protected YVZECQQFEQO([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x50FAE10", Offset = "0x50F9E10", VA = "0x1850FAE10")]
		protected YVZECQQFEQO(QCTMRFTYWMB a, CFJGLFDIMUU b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, KREGEBXKHLE h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x50DC060", Offset = "0x50DB060", VA = "0x1850DC060")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x50F59D0", Offset = "0x50F49D0", VA = "0x1850F59D0")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x50F7270", Offset = "0x50F6270", VA = "0x1850F7270")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class YVTXFJWHVFF<a, b> : SAFTBJAXEWQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private a BNJAGXOLQZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private b BNOHEEIJALA;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a HBXHMBFCUUA
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x10F6080", Offset = "0x10F5080", VA = "0x1810F6080", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x12C3890", Offset = "0x12C2890", VA = "0x1812C3890", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b HCNCDVMUXCB
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x327EB90", Offset = "0x327DB90", VA = "0x18327EB90", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x50E7450", Offset = "0x50E6450", VA = "0x1850E7450", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b OWOMRCXELLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x17293E0", Offset = "0x17283E0", VA = "0x1817293E0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object KDUWUASGBUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x50E2B90", Offset = "0x50E1B90", VA = "0x1850E2B90", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x50E7A10", Offset = "0x50E6A10", VA = "0x1850E7A10", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x50EFE40", Offset = "0x50EEE40", VA = "0x1850EFE40", Slot = "9")]
		protected override bool WQFHMYPPRKN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x50F1260", Offset = "0x50F0260", VA = "0x1850F1260")]
		protected YVTXFJWHVFF([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x50F25A0", Offset = "0x50F15A0", VA = "0x1850F25A0")]
		protected YVTXFJWHVFF(QCTMRFTYWMB a, CFJGLFDIMUU b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, KREGEBXKHLE i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x50DC060", Offset = "0x50DB060", VA = "0x1850DC060")]
		public a FSDEKQZXQFH()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x50EA880", Offset = "0x50E9880", VA = "0x1850EA880")]
		public void MXCLBEDGJWF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x17293E0", Offset = "0x17283E0", VA = "0x1817293E0")]
		public b FRNJSWSFNXG()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x50E96C0", Offset = "0x50E86C0", VA = "0x1850E96C0")]
		public void MWMQJJVOHOE(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x50EE7B0", Offset = "0x50ED7B0", VA = "0x1850EE7B0")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class YVOQIDCKLTW<a, b, c> : SAFTBJAXEWQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private a BNJAGXOLQZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private b BNOHEEIJALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private c BNTOBLCGJWJ;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a HBXHMBFCUUA
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xD06EC0", Offset = "0xD05EC0", VA = "0x180D06EC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xD06820", Offset = "0xD05820", VA = "0x180D06820", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b HCNCDVMUXCB
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xED7540", Offset = "0xED6540", VA = "0x180ED7540", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB1180", Offset = "0x2AB0180", VA = "0x182AB1180", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c HCHVGOSXNQS
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B60", Offset = "0xCF6B60", VA = "0x180CF7B60", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BA0", Offset = "0xCF6BA0", VA = "0x180CF7BA0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a OVYRZIPMJDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x50DC060", Offset = "0x50DB060", VA = "0x1850DC060")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b OWOMRCXELLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x17293E0", Offset = "0x17283E0", VA = "0x1817293E0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c OWJFTWDHCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x50DC1E0", Offset = "0x50DB1E0", VA = "0x1850DC1E0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object KDUWUASGBUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x50E2B90", Offset = "0x50E1B90", VA = "0x1850E2B90", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x50DC690", Offset = "0x50DB690", VA = "0x1850DC690", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x50E37F0", Offset = "0x50E27F0", VA = "0x1850E37F0", Slot = "9")]
		protected override bool WQFHMYPPRKN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x50E4800", Offset = "0x50E3800", VA = "0x1850E4800")]
		protected YVOQIDCKLTW([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x50E6FA0", Offset = "0x50E5FA0", VA = "0x1850E6FA0")]
		protected YVOQIDCKLTW(QCTMRFTYWMB a, CFJGLFDIMUU b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, KREGEBXKHLE j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x50DC060", Offset = "0x50DB060", VA = "0x1850DC060")]
		public a FSDEKQZXQFH()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x50DF7F0", Offset = "0x50DE7F0", VA = "0x1850DF7F0")]
		public void MXCLBEDGJWF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x17293E0", Offset = "0x17283E0", VA = "0x1817293E0")]
		public b FRNJSWSFNXG()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x50DDED0", Offset = "0x50DCED0", VA = "0x1850DDED0")]
		public void MWMQJJVOHOE(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x50DC1E0", Offset = "0x50DB1E0", VA = "0x1850DC1E0")]
		public c FRSQQDMCXIP()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x50DE750", Offset = "0x50DD750", VA = "0x1850DE750")]
		public void MWRXGQPLQZN(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x50E0530", Offset = "0x50DF530", VA = "0x1850E0530")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class YWZMOYLRZVH<a, b, c, d> : SAFTBJAXEWQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private a BNJAGXOLQZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private b BNOHEEIJALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private c BNTOBLCGJWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private d BNYUYRWDTHS;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a HBXHMBFCUUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xF4CA60", Offset = "0xF4BA60", VA = "0x180F4CA60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x511D820", Offset = "0x511C820", VA = "0x18511D820", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b HCNCDVMUXCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1497BA0", Offset = "0x1496BA0", VA = "0x181497BA0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x1494750", Offset = "0x1493750", VA = "0x181494750", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c HCHVGOSXNQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x151AF00", Offset = "0x1519F00", VA = "0x18151AF00", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x5126F80", Offset = "0x5125F80", VA = "0x185126F80", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d HCXPYJAPPYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1D4BEA0", Offset = "0x1D4AEA0", VA = "0x181D4BEA0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x1674910", Offset = "0x1673910", VA = "0x181674910", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b OWOMRCXELLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x50DC1A0", Offset = "0x50DB1A0", VA = "0x1850DC1A0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c OWJFTWDHCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x50DC2E0", Offset = "0x50DB2E0", VA = "0x1850DC2E0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d OWZALQKZEIP
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x15D04F0", Offset = "0x15CF4F0", VA = "0x1815D04F0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object KDUWUASGBUN
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x50E2B90", Offset = "0x50E1B90", VA = "0x1850E2B90", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x5127240", Offset = "0x5126240", VA = "0x185127240", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x512E0B0", Offset = "0x512D0B0", VA = "0x18512E0B0", Slot = "9")]
		protected override bool WQFHMYPPRKN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5131AA0", Offset = "0x5130AA0", VA = "0x185131AA0")]
		protected YWZMOYLRZVH([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x512F980", Offset = "0x512E980", VA = "0x18512F980")]
		protected YWZMOYLRZVH(QCTMRFTYWMB a, CFJGLFDIMUU b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, KREGEBXKHLE k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x50DC060", Offset = "0x50DB060", VA = "0x1850DC060")]
		public a FSDEKQZXQFH()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x512A790", Offset = "0x5129790", VA = "0x18512A790")]
		public void MXCLBEDGJWF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x50DC1A0", Offset = "0x50DB1A0", VA = "0x1850DC1A0")]
		public b FRNJSWSFNXG()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5129820", Offset = "0x5128820", VA = "0x185129820")]
		public void MWMQJJVOHOE(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x50DC2E0", Offset = "0x50DB2E0", VA = "0x1850DC2E0")]
		public c FRSQQDMCXIP()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5129FC0", Offset = "0x5128FC0", VA = "0x185129FC0")]
		public void MWRXGQPLQZN(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x15D04F0", Offset = "0x15CF4F0", VA = "0x1815D04F0")]
		public d FSSZCLHPSNI()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x51290C0", Offset = "0x51280C0", VA = "0x1851290C0")]
		public void MWCCOWHTORM(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x512D1C0", Offset = "0x512C1C0", VA = "0x18512D1C0")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class YWUFRRRUQJY<a, b, c, d, e> : SAFTBJAXEWQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private a BNJAGXOLQZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private b BNOHEEIJALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private c BNTOBLCGJWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private d BNYUYRWDTHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private e BOEBVYQBCTB;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a HBXHMBFCUUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xD06EC0", Offset = "0xD05EC0", VA = "0x180D06EC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xD06820", Offset = "0xD05820", VA = "0x180D06820", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b HCNCDVMUXCB
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xDEC1D0", Offset = "0xDEB1D0", VA = "0x180DEC1D0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x14AD0E0", Offset = "0x14AC0E0", VA = "0x1814AD0E0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c HCHVGOSXNQS
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xE0C1B0", Offset = "0xE0B1B0", VA = "0x180E0C1B0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xE0C1D0", Offset = "0xE0B1D0", VA = "0x180E0C1D0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d HCXPYJAPPYT
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xD0FFF0", Offset = "0xD0EFF0", VA = "0x180D0FFF0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xD1F500", Offset = "0xD1E500", VA = "0x180D1F500", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e HCSJBCGSGNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC30", Offset = "0xD0EC30", VA = "0x180D0FC30", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x511D720", Offset = "0x511C720", VA = "0x18511D720", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object KDUWUASGBUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x50E2B90", Offset = "0x50E1B90", VA = "0x1850E2B90", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x511E6A0", Offset = "0x511D6A0", VA = "0x18511E6A0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5123E90", Offset = "0x5122E90", VA = "0x185123E90", Slot = "9")]
		protected override bool WQFHMYPPRKN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x51267D0", Offset = "0x51257D0", VA = "0x1851267D0")]
		protected YWUFRRRUQJY(QCTMRFTYWMB a, CFJGLFDIMUU b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, KREGEBXKHLE l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x50DC060", Offset = "0x50DB060", VA = "0x1850DC060")]
		public a FSDEKQZXQFH()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5120F60", Offset = "0x511FF60", VA = "0x185120F60")]
		public void MXCLBEDGJWF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x17293E0", Offset = "0x17283E0", VA = "0x1817293E0")]
		public b FRNJSWSFNXG()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5120060", Offset = "0x511F060", VA = "0x185120060")]
		public void MWMQJJVOHOE(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x50DC1E0", Offset = "0x50DB1E0", VA = "0x1850DC1E0")]
		public c FRSQQDMCXIP()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5120500", Offset = "0x511F500", VA = "0x185120500")]
		public void MWRXGQPLQZN(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x15D04F0", Offset = "0x15CF4F0", VA = "0x1815D04F0")]
		public d FSSZCLHPSNI()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x511EF70", Offset = "0x511DF70", VA = "0x18511EF70")]
		public void MWCCOWHTORM(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x511D3F0", Offset = "0x511C3F0", VA = "0x18511D3F0")]
		public e FSYFZSBNBYR()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x511F8C0", Offset = "0x511E8C0", VA = "0x18511F8C0")]
		public void MWHJMDBQYCV(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5121410", Offset = "0x5120410", VA = "0x185121410")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, e newValue5)
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
