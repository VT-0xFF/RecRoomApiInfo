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
	public interface CQGZITPROPE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool DNYPGZBCQDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool TBQYSPDKIVW
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		XLYBIIWOHJI LPQICPLBZBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int VHKCKKZRCKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool CNEABGSPHIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool EFAXRNWPFXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action UIJWZOKUNFL;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void KNRGLMITJQA();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void OLHJUXXVRIO(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void MAJYFJOJNCI();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface TIPTKZTWKCL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string KZRDAMSNULS
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool HESBUXJGVCK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface LWVQRIMZPHC<a> : TIPTKZTWKCL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a VQZWQGLWFVG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ZBFOGYEJOEJ(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class PDMSMHFQVBD<a> : LWVQRIMZPHC<a>, TIPTKZTWKCL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly RALQHHSRNMS<a> KSDLQNTHNCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly RALQHHSRNMS<a> YTOVJBYRGDZ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string KZRDAMSNULS
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x104CE40", Offset = "0x104BE40", VA = "0x18104CE40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool CRFINWCBSFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5D97D90", Offset = "0x5D96D90", VA = "0x185D97D90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a CBNLBTXILJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5D95ED0", Offset = "0x5D94ED0", VA = "0x185D95ED0", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5D94920", Offset = "0x5D93920", VA = "0x185D94920", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a VQZWQGLWFVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5D96730", Offset = "0x5D95730", VA = "0x185D96730", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x5D95DB0", Offset = "0x5D94DB0", VA = "0x185D95DB0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a AUBFRNVZHSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5D96730", Offset = "0x5D95730", VA = "0x185D96730")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5D968D0", Offset = "0x5D958D0", VA = "0x185D968D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HESBUXJGVCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x5D8CB70", Offset = "0x5D8BB70", VA = "0x185D8CB70", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5D8C390", Offset = "0x5D8B390", VA = "0x185D8C390", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool WKTDGOKMBTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5D97A10", Offset = "0x5D96A10", VA = "0x185D97A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5D98640", Offset = "0x5D97640", VA = "0x185D98640", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D9A640", Offset = "0x5D99640", VA = "0x185D9A640")]
		public PDMSMHFQVBD([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5D96210", Offset = "0x5D95210", VA = "0x185D96210")]
		private void MRBFTGVQYOW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D98DE0", Offset = "0x5D97DE0", VA = "0x185D98DE0", Slot = "5")]
		public void ZBFOGYEJOEJ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5D99140", Offset = "0x5D98140", VA = "0x185D99140")]
		public void ZBFOGYEJOEJ(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5D88020", Offset = "0x5D87020", VA = "0x185D88020", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class PCWXUMXYSTC<a, b> : LWVQRIMZPHC<(a, b)>, TIPTKZTWKCL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly RAGJKAYUEBJ<a, b> KSDLQNTHNCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly RAGJKAYUEBJ<a, b> YTOVJBYRGDZ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string KZRDAMSNULS
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x104CE40", Offset = "0x104BE40", VA = "0x18104CE40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool CRFINWCBSFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5D8BFB0", Offset = "0x5D8AFB0", VA = "0x185D8BFB0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool REQCDPDIJRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5D89ED0", Offset = "0x5D88ED0", VA = "0x185D89ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool REAHLUVQHJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5D89A10", Offset = "0x5D88A10", VA = "0x185D89A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) CBNLBTXILJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5D894E0", Offset = "0x5D884E0", VA = "0x185D894E0", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5D887D0", Offset = "0x5D877D0", VA = "0x185D887D0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) VQZWQGLWFVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5D8B330", Offset = "0x5D8A330", VA = "0x185D8B330", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5D88E80", Offset = "0x5D87E80", VA = "0x185D88E80", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) AUBFRNVZHSG
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5D8C8A0", Offset = "0x5D8B8A0", VA = "0x185D8C8A0")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5D8BAF0", Offset = "0x5D8AAF0", VA = "0x185D8BAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a XQUMGTTMXNG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5D87F40", Offset = "0x5D86F40", VA = "0x185D87F40")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5D8DF60", Offset = "0x5D8CF60", VA = "0x185D8DF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a JNUOKCCCRAD
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5D8B8C0", Offset = "0x5D8A8C0", VA = "0x185D8B8C0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a CBWJPZWWXEZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5D8B8C0", Offset = "0x5D8A8C0", VA = "0x185D8B8C0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5D8ABD0", Offset = "0x5D89BD0", VA = "0x185D8ABD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b XRKGYOBEZVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5D87E40", Offset = "0x5D86E40", VA = "0x185D87E40")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5D8D840", Offset = "0x5D8C840", VA = "0x185D8D840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b JNZVHIWAALM
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5D8B9D0", Offset = "0x5D8A9D0", VA = "0x185D8B9D0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b CBGOYFPEUWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5D8B9D0", Offset = "0x5D8A9D0", VA = "0x185D8B9D0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5D8B170", Offset = "0x5D8A170", VA = "0x185D8B170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool HESBUXJGVCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5D8CB70", Offset = "0x5D8BB70", VA = "0x185D8CB70", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5D8C390", Offset = "0x5D8B390", VA = "0x185D8C390", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5D8C770", Offset = "0x5D8B770", VA = "0x185D8C770", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5D8EB70", Offset = "0x5D8DB70", VA = "0x185D8EB70")]
		public PCWXUMXYSTC([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5D8A3C0", Offset = "0x5D893C0", VA = "0x185D8A3C0")]
		private void MRBFTGVQYOW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D3D0", Offset = "0x5D8C3D0", VA = "0x185D8D3D0")]
		public void WRRRMRZIPOK(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E0A0", Offset = "0x5D8D0A0", VA = "0x185D8E0A0")]
		public void ZBFOGYEJOEJ(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5D8CF40", Offset = "0x5D8BF40", VA = "0x185D8CF40", Slot = "5")]
		private void VTJMBGMFRPQ((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5D88020", Offset = "0x5D87020", VA = "0x185D88020", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class PDCERTRWCEL<a, b, c> : LWVQRIMZPHC<(a, b, c)>, TIPTKZTWKCL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly RABCMUEWUQA<a, b, c> KSDLQNTHNCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly RABCMUEWUQA<a, b, c> YTOVJBYRGDZ;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string KZRDAMSNULS
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x104CE40", Offset = "0x104BE40", VA = "0x18104CE40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool CRFINWCBSFM
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5D92750", Offset = "0x5D91750", VA = "0x185D92750", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool REQCDPDIJRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5D910C0", Offset = "0x5D900C0", VA = "0x185D910C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool REAHLUVQHJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5D90F00", Offset = "0x5D8FF00", VA = "0x185D90F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool REFOJBPNQUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5D90C10", Offset = "0x5D8FC10", VA = "0x185D90C10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) CBNLBTXILJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5D907E0", Offset = "0x5D8F7E0", VA = "0x185D907E0", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5D8FD30", Offset = "0x5D8ED30", VA = "0x185D8FD30", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) VQZWQGLWFVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5D92040", Offset = "0x5D91040", VA = "0x185D92040", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5D90380", Offset = "0x5D8F380", VA = "0x185D90380", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a XQUMGTTMXNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5D8F4E0", Offset = "0x5D8E4E0", VA = "0x185D8F4E0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5D939B0", Offset = "0x5D929B0", VA = "0x185D939B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a JNUOKCCCRAD
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5D921E0", Offset = "0x5D911E0", VA = "0x185D921E0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a CBWJPZWWXEZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5D921E0", Offset = "0x5D911E0", VA = "0x185D921E0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5D91690", Offset = "0x5D90690", VA = "0x185D91690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b XRKGYOBEZVH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5D8F3D0", Offset = "0x5D8E3D0", VA = "0x185D8F3D0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5D93650", Offset = "0x5D92650", VA = "0x185D93650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b JNZVHIWAALM
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5D923A0", Offset = "0x5D913A0", VA = "0x185D923A0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b CBGOYFPEUWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5D923A0", Offset = "0x5D913A0", VA = "0x185D923A0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5D91B70", Offset = "0x5D90B70", VA = "0x185D91B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c XRFABHHHQJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5D8F400", Offset = "0x5D8E400", VA = "0x185D8F400")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x5D93760", Offset = "0x5D92760", VA = "0x185D93760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c JOFCEPPXJWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5D922C0", Offset = "0x5D912C0", VA = "0x185D922C0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c CBLVVMJCEIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5D922C0", Offset = "0x5D912C0", VA = "0x185D922C0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5D91950", Offset = "0x5D90950", VA = "0x185D91950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool HESBUXJGVCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5D8CB70", Offset = "0x5D8BB70", VA = "0x185D8CB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5D92BB0", Offset = "0x5D91BB0", VA = "0x185D92BB0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5D94530", Offset = "0x5D93530", VA = "0x185D94530")]
		public PDCERTRWCEL([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5D91290", Offset = "0x5D90290", VA = "0x185D91290")]
		private void MRBFTGVQYOW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5D930E0", Offset = "0x5D920E0", VA = "0x185D930E0")]
		public void WRRRMRZIPOK(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5D92F60", Offset = "0x5D91F60", VA = "0x185D92F60")]
		public void SMPRDOHQGLT(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5D8FF70", Offset = "0x5D8EF70", VA = "0x185D8FF70")]
		public void FFPZMDPKYIY(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5D93F30", Offset = "0x5D92F30", VA = "0x185D93F30")]
		public void ZBFOGYEJOEJ(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5D926F0", Offset = "0x5D916F0", VA = "0x185D926F0", Slot = "5")]
		private void NPKNAMRIVPN((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5D88020", Offset = "0x5D87020", VA = "0x185D88020", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class PECNEBNIXJE<a, b, c, d> : LWVQRIMZPHC<(a, b, c, d)>, TIPTKZTWKCL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly RBLYTPOEIRL<a, b, c, d> KSDLQNTHNCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly RBLYTPOEIRL<a, b, c, d> YTOVJBYRGDZ;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string KZRDAMSNULS
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x104CE40", Offset = "0x104BE40", VA = "0x18104CE40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) VQZWQGLWFVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5D9FF70", Offset = "0x5D9EF70", VA = "0x185D9FF70", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5D9F780", Offset = "0x5D9E780", VA = "0x185D9F780", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b JNZVHIWAALM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5DA0560", Offset = "0x5D9F560", VA = "0x185DA0560")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c JOFCEPPXJWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5DA0480", Offset = "0x5D9F480", VA = "0x185DA0480")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d JMUFXUGPVVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5DA0640", Offset = "0x5D9F640", VA = "0x185DA0640")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool HESBUXJGVCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5D8CB70", Offset = "0x5D8BB70", VA = "0x185D8CB70", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5D8C390", Offset = "0x5D8B390", VA = "0x185D8C390", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5DA1530", Offset = "0x5DA0530", VA = "0x185DA1530")]
		public PECNEBNIXJE([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5D9FE60", Offset = "0x5D9EE60", VA = "0x185D9FE60")]
		private void MRBFTGVQYOW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5DA0720", Offset = "0x5D9F720", VA = "0x185DA0720")]
		public void WRRRMRZIPOK(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5DA0DD0", Offset = "0x5D9FDD0", VA = "0x185DA0DD0")]
		public void ZBFOGYEJOEJ(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5D9F3A0", Offset = "0x5D9E3A0", VA = "0x185D9F3A0", Slot = "5")]
		private void CRQNHSLNVDJ((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5D88020", Offset = "0x5D87020", VA = "0x185D88020", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class YWYWBGMFQPC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x886DCF0", Offset = "0x886CCF0", VA = "0x18886DCF0")]
		public static string ORPEGBQMBJV(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xB242A0", Offset = "0xB232A0", VA = "0x180B242A0")]
		public static NetworkSetterPermissionMode PCWAZMLPSLW(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class RALQHHSRNMS<a> : TGYJTPDEZPV<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5EA36C0", Offset = "0x5EA26C0", VA = "0x185EA36C0")]
		public RALQHHSRNMS([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1B80", Offset = "0x5EA0B80", VA = "0x185EA1B80")]
		public RALQHHSRNMS(HHTCNVFGVYJ a, XLYBIIWOHJI b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] XHIHKQWDJMJ g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3030", Offset = "0x5EA2030", VA = "0x185EA3030")]
		public RALQHHSRNMS(HHTCNVFGVYJ a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] XHIHKQWDJMJ f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0560", Offset = "0x5E9F560", VA = "0x185EA0560")]
		public RALQHHSRNMS(HHTCNVFGVYJ a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] XHIHKQWDJMJ g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RAGJKAYUEBJ<a, b> : THDQQVXCJBE<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E4E0", Offset = "0x5E9D4E0", VA = "0x185E9E4E0")]
		public RAGJKAYUEBJ([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E2D0", Offset = "0x5E9D2D0", VA = "0x185E9E2D0")]
		public RAGJKAYUEBJ(HHTCNVFGVYJ a, XLYBIIWOHJI b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] XHIHKQWDJMJ h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C130", Offset = "0x5E9B130", VA = "0x185E9C130")]
		public RAGJKAYUEBJ(HHTCNVFGVYJ a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] XHIHKQWDJMJ g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E000", Offset = "0x5E9D000", VA = "0x185E9E000")]
		public RAGJKAYUEBJ(HHTCNVFGVYJ a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] XHIHKQWDJMJ h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class RABCMUEWUQA<a, b, c> : THIXOCQZSMN<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B180", Offset = "0x5E9A180", VA = "0x185E9B180")]
		public RABCMUEWUQA([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B650", Offset = "0x5E9A650", VA = "0x185E9B650")]
		public RABCMUEWUQA(HHTCNVFGVYJ a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] XHIHKQWDJMJ h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class RBLYTPOEIRL<a, b, c, d> : TFYBHHHSELC<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9970", Offset = "0x5EA8970", VA = "0x185EA9970")]
		public RBLYTPOEIRL([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA87A0", Offset = "0x5EA77A0", VA = "0x185EA87A0")]
		public RBLYTPOEIRL(HHTCNVFGVYJ a, XLYBIIWOHJI b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] XHIHKQWDJMJ j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9DE0", Offset = "0x5EA8DE0", VA = "0x185EA9DE0")]
		public RBLYTPOEIRL(HHTCNVFGVYJ a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] XHIHKQWDJMJ i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class RBGRWIUGZGC<a, b, c, d, e> : TGDIEOBPNWL<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7060", Offset = "0x5EA6060", VA = "0x185EA7060")]
		public RBGRWIUGZGC(HHTCNVFGVYJ a, XLYBIIWOHJI b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] XHIHKQWDJMJ k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7A20", Offset = "0x5EA6A20", VA = "0x185EA7A20")]
		public RBGRWIUGZGC(HHTCNVFGVYJ a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] XHIHKQWDJMJ j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class XZLPUJZOLPL<a> : TGYJTPDEZPV<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x41914F0", Offset = "0x41904F0", VA = "0x1841914F0")]
		public XZLPUJZOLPL(XLYBIIWOHJI a, string b, a c, [Optional] Action d, [Optional] XHIHKQWDJMJ e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class XYVVCPRWJHK<a, b> : THDQQVXCJBE<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x41910E0", Offset = "0x41900E0", VA = "0x1841910E0")]
		public XYVVCPRWJHK(XLYBIIWOHJI a, string b, a c, b d, [Optional] Action e, [Optional] XHIHKQWDJMJ f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface OPWWUOBBLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RALQHHSRNMS<a> GNAPZWTLTAT<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class AQLQWEGCIOI : OPWWUOBBLOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly XHIHKQWDJMJ PYJWKGAQIRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly HHTCNVFGVYJ AGGAWTUHLTW;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAD9FF0", Offset = "0xAD8FF0", VA = "0x180AD9FF0")]
		public AQLQWEGCIOI(XHIHKQWDJMJ a, HHTCNVFGVYJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3321300", Offset = "0x3320300", VA = "0x183321300", Slot = "4")]
		public RALQHHSRNMS<a> GNAPZWTLTAT<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface IDHCSTFBIGK : HHTCNVFGVYJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId VHYMXYEVRYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface HHTCNVFGVYJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool GWGXFQPIFDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool DCDSPFHYYIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string NIUYIPUFINS
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool SBUKBQNINYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(EHDLXBWWXLB handler);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(EHDLXBWWXLB handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class PHOCTZBXQJR
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x886B260", Offset = "0x886A260", VA = "0x18886B260")]
		public static bool OWXWUIKPITO(this HHTCNVFGVYJ a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface XHIHKQWDJMJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		XLYBIIWOHJI QQRSSROVZZT
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool WKTDGOKMBTG
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool SOBNMWWJMDL
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Initialize();

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object TDOJTESFJRX(string a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object SFVIBAKFWNZ(XLYBIIWOHJI a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void XDIRQKGWAUJ(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void VWLZWUALSDZ(XLYBIIWOHJI a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void YQFKIDQUXPC<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void EQSPBAMUJHM([CanBeNull] XLYBIIWOHJI photonPlayer, string a, OYJCOKSFVXP b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void JXIPEYLUDBN([CanBeNull] XLYBIIWOHJI photonPlayer, string a, OYJCOKSFVXP b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b MFSIDDBOUMN<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object HBNSEFYPVRS<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void PNVXUQNSPOB();

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void VRPIYXXHUCP();

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void TIQCGVUBMTA(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public XLYBIIWOHJI player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public HHTCNVFGVYJ context;

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
		public XHIHKQWDJMJ networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x886B490", Offset = "0x886A490", VA = "0x18886B490")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x886B300", Offset = "0x886A300", VA = "0x18886B300")]
		public SyncData(HHTCNVFGVYJ context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] XHIHKQWDJMJ networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x886B2B0", Offset = "0x886A2B0", VA = "0x18886B2B0")]
		public static SyncData From(HHTCNVFGVYJ context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] XHIHKQWDJMJ networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class WIHFRBHBXRO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3F396A0", Offset = "0x3F386A0", VA = "0x183F396A0")]
		public static RALQHHSRNMS<a> OYJCOKSFVXP<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3F38560", Offset = "0x3F37560", VA = "0x183F38560")]
		public static RAGJKAYUEBJ<b, c> OYJCOKSFVXP<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x3F38600", Offset = "0x3F37600", VA = "0x183F38600")]
		public static RABCMUEWUQA<d, e, f> OYJCOKSFVXP<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3F39150", Offset = "0x3F38150", VA = "0x183F39150")]
		public static RBLYTPOEIRL<g, h, i, j> OYJCOKSFVXP<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3F39920", Offset = "0x3F38920", VA = "0x183F39920")]
		public static PDMSMHFQVBD<k> TNMFZPLJOOS<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3F397D0", Offset = "0x3F387D0", VA = "0x183F397D0")]
		public static PCWXUMXYSTC<l, m> TNMFZPLJOOS<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3F39870", Offset = "0x3F38870", VA = "0x183F39870")]
		public static PDCERTRWCEL<n, o, p> TNMFZPLJOOS<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3F39BF0", Offset = "0x3F38BF0", VA = "0x183F39BF0")]
		public static PECNEBNIXJE<q, r, s, t> TNMFZPLJOOS<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class OYJCOKSFVXP : EHDLXBWWXLB, IDisposable
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
		private static Stack<XHIHKQWDJMJ> KKWMBJYYCHF;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool FZUUVVANSVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly XLYBIIWOHJI XCUHZEJTUPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly HHTCNVFGVYJ AGGAWTUHLTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string VBWKGQRZQUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode KEFUHYCRJQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action TEPIKIUCSZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected XHIHKQWDJMJ WUWXBCUJTJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags HJXXSDGPTVS;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static XHIHKQWDJMJ GEALUHEGJKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x886A560", Offset = "0x8869560", VA = "0x18886A560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool GSQACKVUANH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8869CE0", Offset = "0x8868CE0", VA = "0x188869CE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x886A540", Offset = "0x8869540", VA = "0x18886A540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool DCGBCTNFXCY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x886AE40", Offset = "0x8869E40", VA = "0x18886AE40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x886AF00", Offset = "0x8869F00", VA = "0x18886AF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool RSMAXKSAVRT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x886AF20", Offset = "0x8869F20", VA = "0x18886AF20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x886A620", Offset = "0x8869620", VA = "0x18886A620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool HESBUXJGVCK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x886AEF0", Offset = "0x8869EF0", VA = "0x18886AEF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x886AA70", Offset = "0x8869A70", VA = "0x18886AA70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object JOLWGJEGVLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xAD6750", Offset = "0xAD5750", VA = "0x180AD6750", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAD6760", Offset = "0xAD5760", VA = "0x180AD6760", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool CIVXYZETFJV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x886AC50", Offset = "0x8869C50", VA = "0x18886AC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int QKEWAEFCNSM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xF8B490", Offset = "0xF8A490", VA = "0x180F8B490")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1B42120", Offset = "0x1B41120", VA = "0x181B42120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string KZRDAMSNULS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool WKTDGOKMBTG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x886A5D0", Offset = "0x88695D0", VA = "0x18886A5D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x886A060", Offset = "0x8869060", VA = "0x18886A060")]
		public static void IVIRHDYHYXC(XHIHKQWDJMJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool VUSQFFAJXKS();

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x886B040", Offset = "0x886A040", VA = "0x18886B040")]
		protected OYJCOKSFVXP(XLYBIIWOHJI a, HHTCNVFGVYJ b, string c, NetworkSetterPermissionMode d, Action e, XHIHKQWDJMJ f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8869EC0", Offset = "0x8868EC0", VA = "0x188869EC0", Slot = "1")]
		~OYJCOKSFVXP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8869B70", Offset = "0x8868B70", VA = "0x188869B70", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x886AE50", Offset = "0x8869E50", VA = "0x18886AE50")]
		private void VFALCSGKFVS(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8869D50", Offset = "0x8868D50", VA = "0x188869D50")]
		private object FTBIDAITUVO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x886A260", Offset = "0x8869260", VA = "0x18886A260")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x886ACA0", Offset = "0x8869CA0", VA = "0x18886ACA0")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x886A820", Offset = "0x8869820", VA = "0x18886A820")]
		protected void QREKVXNCHEN(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8869980", Offset = "0x8868980", VA = "0x188869980")]
		internal void ATGQBVJSYFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x886AF40", Offset = "0x8869F40", VA = "0x18886AF40")]
		private void YHIQJQIFVMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8869CF0", Offset = "0x8868CF0", VA = "0x188869CF0")]
		private void FCNFOZEAYUK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x886ABE0", Offset = "0x8869BE0", VA = "0x18886ABE0", Slot = "4")]
		private void QYVRJMNJHBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x886A100", Offset = "0x8869100", VA = "0x18886A100", Slot = "5")]
		private void IWECPAKSUEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8869F20", Offset = "0x8868F20", VA = "0x188869F20")]
		public bool HWRSSIAJFWP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x886A640", Offset = "0x8869640", VA = "0x18886A640")]
		public bool QHFILVKRZZR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x886A110", Offset = "0x8869110", VA = "0x18886A110")]
		private bool IWVUNLFVJKI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x886AB30", Offset = "0x8869B30", VA = "0x18886AB30")]
		internal void QYALJYVNYTH(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x886A430", Offset = "0x8869430", VA = "0x18886A430")]
		private void KPHQFXSDJLB(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x886AF30", Offset = "0x8869F30", VA = "0x18886AF30")]
		private bool WYLURYFHSOB(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x886A800", Offset = "0x8869800", VA = "0x18886A800")]
		private void QIKUHOUQKAR(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8869AE0", Offset = "0x8868AE0", VA = "0x188869AE0")]
		public static string CEOVMCQLXYL(XLYBIIWOHJI a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8869A00", Offset = "0x8868A00", VA = "0x188869A00")]
		public static string AYZOVXSDRDZ(HHTCNVFGVYJ a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x886ACE0", Offset = "0x8869CE0", VA = "0x18886ACE0")]
		public static bool TLYVAFZROSR(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class YSCUDMMGIMX : XHIHKQWDJMJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<object, object> QHHUELSSFMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<string> BRRBVFJZMDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<object, object> XGZMOFBIJAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> JAYGJCNMJWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool JQVMLRYLPXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly Dictionary<string, object> CXBSVQQNIGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<XLYBIIWOHJI, Dictionary<string, object>> SJUSCMFMZLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<string> PUZNDBHWORF;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> KRCLSQEUNSD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int RLMRMOKYRDK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract XLYBIIWOHJI QQRSSROVZZT
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool WKTDGOKMBTG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool SOBNMWWJMDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool XQWWDYQLVJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool GZOGBLRDHTQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xB31A30", Offset = "0xB30A30", VA = "0x180B31A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3F698A0", Offset = "0x3F688A0", VA = "0x183F698A0", Slot = "12")]
		public void YQFKIDQUXPC<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x886D160", Offset = "0x886C160", VA = "0x18886D160", Slot = "11")]
		public void VWLZWUALSDZ(XLYBIIWOHJI a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x886CC70", Offset = "0x886BC70", VA = "0x18886CC70", Slot = "9")]
		public object SFVIBAKFWNZ(XLYBIIWOHJI a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x886D3D0", Offset = "0x886C3D0", VA = "0x18886D3D0", Slot = "10")]
		public void XDIRQKGWAUJ(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x886CD60", Offset = "0x886BD60", VA = "0x18886CD60", Slot = "8")]
		public object TDOJTESFJRX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x886BAC0", Offset = "0x886AAC0", VA = "0x18886BAC0", Slot = "13")]
		public void EQSPBAMUJHM(XLYBIIWOHJI a, string b, OYJCOKSFVXP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x886C1C0", Offset = "0x886B1C0", VA = "0x18886C1C0", Slot = "14")]
		public void JXIPEYLUDBN(XLYBIIWOHJI a, string b, OYJCOKSFVXP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x886C750", Offset = "0x886B750", VA = "0x18886C750")]
		private void LFTTDULQWJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x886BE00", Offset = "0x886AE00", VA = "0x18886BE00")]
		private void HEKRHIZBAZH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x886B900", Offset = "0x886A900", VA = "0x18886B900")]
		private void CKZURTKGHRO(XLYBIIWOHJI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x886D2B0", Offset = "0x886C2B0", VA = "0x18886D2B0")]
		protected void VZENFPLBLXI(XLYBIIWOHJI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x886C0D0", Offset = "0x886B0D0", VA = "0x18886C0D0")]
		protected void IKVVIQTGENM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x886BDF0", Offset = "0x886ADF0", VA = "0x18886BDF0")]
		protected void HBEALUTSPGW(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x886DA90", Offset = "0x886CA90", VA = "0x18886DA90")]
		protected void ZLSBTNGTBTY(XLYBIIWOHJI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x886D970", Offset = "0x886C970", VA = "0x18886D970")]
		protected void XVSPWYSWYAE(XLYBIIWOHJI a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x886D4F0", Offset = "0x886C4F0", VA = "0x18886D4F0")]
		private void XJNUNSWEMEL(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x886C970", Offset = "0x886B970", VA = "0x18886C970")]
		private static void PJRNUNOQDTR(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x886C460", Offset = "0x886B460", VA = "0x18886C460")]
		private static void KMBBTIJVXAO(Dictionary<string, object> a, string b, OYJCOKSFVXP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x886C7A0", Offset = "0x886B7A0", VA = "0x18886C7A0")]
		private static void NEQOHCGLBYF(Dictionary<string, object> a, string b, OYJCOKSFVXP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x886CB70", Offset = "0x886BB70", VA = "0x18886CB70", Slot = "17")]
		public void PNVXUQNSPOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "27")]
		protected abstract void PAPPSYYWBSE(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x886D080", Offset = "0x886C080", VA = "0x18886D080", Slot = "18")]
		public void VRPIYXXHUCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "28")]
		protected abstract void RRNVIUIDLNU(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x886BBD0", Offset = "0x886ABD0", VA = "0x18886BBD0")]
		private void FCVNHGQUNOV(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x886BE50", Offset = "0x886AE50", VA = "0x18886BE50")]
		private void IJYSKJSKSHS(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x886DA00", Offset = "0x886CA00", VA = "0x18886DA00")]
		public void ZHQKUADNZTV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x886C680", Offset = "0x886B680", VA = "0x18886C680")]
		public void KXRWIOPXUWH(XLYBIIWOHJI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x886B510", Offset = "0x886A510", VA = "0x18886B510")]
		public void AJKWGUVVAOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract HashSet<int> FHKGNXUDRLS(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x886CE00", Offset = "0x886BE00", VA = "0x18886CE00", Slot = "19")]
		public void TIQCGVUBMTA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x886B870", Offset = "0x886A870", VA = "0x18886B870")]
		protected string CEOVMCQLXYL(XLYBIIWOHJI a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		public abstract object HBNSEFYPVRS<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		public abstract c MFSIDDBOUMN<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "32")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x886B960", Offset = "0x886A960", VA = "0x18886B960", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "33")]
		protected virtual void OJJUYPBNUWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x886DB00", Offset = "0x886CB00", VA = "0x18886DB00")]
		protected YSCUDMMGIMX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class TGYJTPDEZPV<a> : OYJCOKSFVXP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private a ANHXWIMPNJI;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a KQGSQIVITZD
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x10F7FA0", Offset = "0x10F6FA0", VA = "0x1810F7FA0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x10F7F90", Offset = "0x10F6F90", VA = "0x1810F7F90", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object JOLWGJEGVLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x628BEC0", Offset = "0x628AEC0", VA = "0x18628BEC0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x62A7AD0", Offset = "0x62A6AD0", VA = "0x1862A7AD0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x62A6550", Offset = "0x62A5550", VA = "0x1862A6550", Slot = "9")]
		protected override bool VUSQFFAJXKS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x62AA510", Offset = "0x62A9510", VA = "0x1862AA510")]
		protected TGYJTPDEZPV([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x62A9E30", Offset = "0x62A8E30", VA = "0x1862A9E30")]
		protected TGYJTPDEZPV(XLYBIIWOHJI a, HHTCNVFGVYJ b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, XHIHKQWDJMJ h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6291F30", Offset = "0x6290F30", VA = "0x186291F30")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x62A1EA0", Offset = "0x62A0EA0", VA = "0x1862A1EA0")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x62A15E0", Offset = "0x62A05E0", VA = "0x1862A15E0")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class THDQQVXCJBE<a, b> : OYJCOKSFVXP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private a ANHXWIMPNJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private b ANCQZBSSDXZ;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a KQGSQIVITZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x11B5350", Offset = "0x11B4350", VA = "0x1811B5350", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x137B570", Offset = "0x137A570", VA = "0x18137B570", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b KPQXYONQRRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x326F4B0", Offset = "0x326E4B0", VA = "0x18326F4B0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x62AB580", Offset = "0x62AA580", VA = "0x1862AB580", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b WNKMJSZCAVO
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x17E51E0", Offset = "0x17E41E0", VA = "0x1817E51E0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object JOLWGJEGVLC
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x628BEC0", Offset = "0x628AEC0", VA = "0x18628BEC0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x62AEC80", Offset = "0x62ADC80", VA = "0x1862AEC80", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x62AE0B0", Offset = "0x62AD0B0", VA = "0x1862AE0B0", Slot = "9")]
		protected override bool VUSQFFAJXKS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x62AFA60", Offset = "0x62AEA60", VA = "0x1862AFA60")]
		protected THDQQVXCJBE([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x62AF7E0", Offset = "0x62AE7E0", VA = "0x1862AF7E0")]
		protected THDQQVXCJBE(XLYBIIWOHJI a, HHTCNVFGVYJ b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, XHIHKQWDJMJ i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6291E30", Offset = "0x6290E30", VA = "0x186291E30")]
		public a UPJVDLMPXGW()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x62ABC00", Offset = "0x62AAC00", VA = "0x1862ABC00")]
		public void OGIVLKDLJVU(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x17E51E0", Offset = "0x17E41E0", VA = "0x1817E51E0")]
		public b UPEOGESSNVN()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x62AB7A0", Offset = "0x62AA7A0", VA = "0x1862AB7A0")]
		public void OGDOODJOAKL(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x62ACCB0", Offset = "0x62ABCB0", VA = "0x1862ACCB0")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class THIXOCQZSMN<a, b, c> : OYJCOKSFVXP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private a ANHXWIMPNJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private b ANCQZBSSDXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private c AMXKBUYUUMQ;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a KQGSQIVITZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xADFD40", Offset = "0xADED40", VA = "0x180ADFD40", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xADF920", Offset = "0xADE920", VA = "0x180ADF920", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b KPQXYONQRRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xF99660", Offset = "0xF98660", VA = "0x180F99660", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x2AAEA10", Offset = "0x2AADA10", VA = "0x182AAEA10", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c KPWEVVHOBCL
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xACEBB0", Offset = "0xACDBB0", VA = "0x180ACEBB0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xACEEB0", Offset = "0xACDEB0", VA = "0x180ACEEB0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a WOAHBNGUDDP
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x6291E30", Offset = "0x6290E30", VA = "0x186291E30")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b WNKMJSZCAVO
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x17E51E0", Offset = "0x17E41E0", VA = "0x1817E51E0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c WNPTGZSZKGX
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x5DF3050", Offset = "0x5DF2050", VA = "0x185DF3050")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object JOLWGJEGVLC
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x628BEC0", Offset = "0x628AEC0", VA = "0x18628BEC0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x62C0190", Offset = "0x62BF190", VA = "0x1862C0190", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x62BE940", Offset = "0x62BD940", VA = "0x1862BE940", Slot = "9")]
		protected override bool VUSQFFAJXKS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x62C0300", Offset = "0x62BF300", VA = "0x1862C0300")]
		protected THIXOCQZSMN([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x62C2BC0", Offset = "0x62C1BC0", VA = "0x1862C2BC0")]
		protected THIXOCQZSMN(XLYBIIWOHJI a, HHTCNVFGVYJ b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, XHIHKQWDJMJ j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6291E30", Offset = "0x6290E30", VA = "0x186291E30")]
		public a UPJVDLMPXGW()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x62BA080", Offset = "0x62B9080", VA = "0x1862BA080")]
		public void OGIVLKDLJVU(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x17E51E0", Offset = "0x17E41E0", VA = "0x1817E51E0")]
		public b UPEOGESSNVN()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x62B9540", Offset = "0x62B8540", VA = "0x1862B9540")]
		public void OGDOODJOAKL(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3050", Offset = "0x5DF2050", VA = "0x185DF3050")]
		public c UOZHIXYVEKE()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x62B8C00", Offset = "0x62B7C00", VA = "0x1862B8C00")]
		public void OFYHQWPQQZC(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x62BAEB0", Offset = "0x62B9EB0", VA = "0x1862BAEB0")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class TFYBHHHSELC<a, b, c, d> : OYJCOKSFVXP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private a ANHXWIMPNJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private b ANCQZBSSDXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private c AMXKBUYUUMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private d AOIGIQICIOB;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a KQGSQIVITZD
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x102AE30", Offset = "0x1029E30", VA = "0x18102AE30", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x628BEB0", Offset = "0x628AEB0", VA = "0x18628BEB0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b KPQXYONQRRC
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x2191780", Offset = "0x2190780", VA = "0x182191780", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x218CCE0", Offset = "0x218BCE0", VA = "0x18218CCE0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c KPWEVVHOBCL
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x628BFE0", Offset = "0x628AFE0", VA = "0x18628BFE0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x628BC90", Offset = "0x628AC90", VA = "0x18628BC90", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d KQWNIDDAWHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x1DB9530", Offset = "0x1DB8530", VA = "0x181DB9530", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1713580", Offset = "0x1712580", VA = "0x181713580", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b WNKMJSZCAVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x628C490", Offset = "0x628B490", VA = "0x18628C490")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c WNPTGZSZKGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x628C2E0", Offset = "0x628B2E0", VA = "0x18628C2E0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d WOQBTHOMFLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x21C3770", Offset = "0x21C2770", VA = "0x1821C3770")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object JOLWGJEGVLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x628BEC0", Offset = "0x628AEC0", VA = "0x18628BEC0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x6294160", Offset = "0x6293160", VA = "0x186294160", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6292EA0", Offset = "0x6291EA0", VA = "0x186292EA0", Slot = "9")]
		protected override bool VUSQFFAJXKS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x62969E0", Offset = "0x62959E0", VA = "0x1862969E0")]
		protected TFYBHHHSELC([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6296F40", Offset = "0x6295F40", VA = "0x186296F40")]
		protected TFYBHHHSELC(XLYBIIWOHJI a, HHTCNVFGVYJ b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, XHIHKQWDJMJ k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6291E30", Offset = "0x6290E30", VA = "0x186291E30")]
		public a UPJVDLMPXGW()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x628E710", Offset = "0x628D710", VA = "0x18628E710")]
		public void OGIVLKDLJVU(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x628C490", Offset = "0x628B490", VA = "0x18628C490")]
		public b UPEOGESSNVN()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x628DDA0", Offset = "0x628CDA0", VA = "0x18628DDA0")]
		public void OGDOODJOAKL(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x628C2E0", Offset = "0x628B2E0", VA = "0x18628C2E0")]
		public c UOZHIXYVEKE()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x628D420", Offset = "0x628C420", VA = "0x18628D420")]
		public void OFYHQWPQQZC(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x21C3770", Offset = "0x21C2770", VA = "0x1821C3770")]
		public d UQKDPTICSLP()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x628C700", Offset = "0x628B700", VA = "0x18628C700")]
		public void OFTATPVTHNT(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x628F740", Offset = "0x628E740", VA = "0x18628F740")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class TGDIEOBPNWL<a, b, c, d, e> : OYJCOKSFVXP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private a ANHXWIMPNJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private b ANCQZBSSDXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private c AMXKBUYUUMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private d AOIGIQICIOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private e AOCZLJOEZCS;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a KQGSQIVITZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xADFD40", Offset = "0xADED40", VA = "0x180ADFD40", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xADF920", Offset = "0xADE920", VA = "0x180ADF920", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b KPQXYONQRRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xEB2060", Offset = "0xEB1060", VA = "0x180EB2060", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x155FBD0", Offset = "0x155EBD0", VA = "0x18155FBD0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c KPWEVVHOBCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xEE1170", Offset = "0xEE0170", VA = "0x180EE1170", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xEE1F80", Offset = "0xEE0F80", VA = "0x180EE1F80", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d KQWNIDDAWHE
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAE95E0", Offset = "0xAE85E0", VA = "0x180AE95E0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xAF9AE0", Offset = "0xAF8AE0", VA = "0x180AF9AE0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e KRBUFJWYFSN
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xAE9220", Offset = "0xAE8220", VA = "0x180AE9220", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x628BAE0", Offset = "0x628AAE0", VA = "0x18628BAE0", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object JOLWGJEGVLC
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x628BEC0", Offset = "0x628AEC0", VA = "0x18628BEC0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x629EDB0", Offset = "0x629DDB0", VA = "0x18629EDB0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x629D5A0", Offset = "0x629C5A0", VA = "0x18629D5A0", Slot = "9")]
		protected override bool VUSQFFAJXKS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x629F830", Offset = "0x629E830", VA = "0x18629F830")]
		protected TGDIEOBPNWL(XLYBIIWOHJI a, HHTCNVFGVYJ b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, XHIHKQWDJMJ l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6291E30", Offset = "0x6290E30", VA = "0x186291E30")]
		public a UPJVDLMPXGW()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x629A470", Offset = "0x6299470", VA = "0x18629A470")]
		public void OGIVLKDLJVU(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x17E51E0", Offset = "0x17E41E0", VA = "0x1817E51E0")]
		public b UPEOGESSNVN()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x629A1A0", Offset = "0x62991A0", VA = "0x18629A1A0")]
		public void OGDOODJOAKL(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3050", Offset = "0x5DF2050", VA = "0x185DF3050")]
		public c UOZHIXYVEKE()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x6299350", Offset = "0x6298350", VA = "0x186299350")]
		public void OFYHQWPQQZC(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x21C3770", Offset = "0x21C2770", VA = "0x1821C3770")]
		public d UQKDPTICSLP()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6298BA0", Offset = "0x6297BA0", VA = "0x186298BA0")]
		public void OFTATPVTHNT(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x629D1D0", Offset = "0x629C1D0", VA = "0x18629D1D0")]
		public e UQEWSMOFJAG()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x62984E0", Offset = "0x62974E0", VA = "0x1862984E0")]
		public void OFNTWJBVYCK(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x629BB50", Offset = "0x629AB50", VA = "0x18629BB50")]
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
