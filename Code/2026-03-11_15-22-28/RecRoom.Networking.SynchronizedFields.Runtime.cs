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
	public interface TEIEBPFUVOM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool CNRXIQEEROF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool GWPPIVZMXAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		OVSEBXDBUJS XJFQZDBLPXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int ZVTIBVATORA
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool NKBKAUMNXNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool XWZZDTUDTOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action AFSALZIIHZJ;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void LLJDQMOUZQK();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void LPSDXFBKXWA(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void LGQQAIUFRZU();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface TOHSKKQOIRH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string QZQNBFORTMC
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool RYKYLKXYKMI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface XIVBPOERIQO<a> : TOHSKKQOIRH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a GGQCFUKWTNI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CGSBIOWILNF(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class EKUZKUPSUIP<a> : XIVBPOERIQO<a>, TOHSKKQOIRH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly RCGMXRRJRNC<a> IIHXLSHTTDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly RCGMXRRJRNC<a> SRNVHAQRUMZ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string QZQNBFORTMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD1E3E0", Offset = "0xD1D3E0", VA = "0x180D1E3E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MPUJNOZZIEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x48BA690", Offset = "0x48B9690", VA = "0x1848BA690", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a OJDOPJSMVRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x48BAEA0", Offset = "0x48B9EA0", VA = "0x1848BAEA0", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x48BC750", Offset = "0x48BB750", VA = "0x1848BC750", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a GGQCFUKWTNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x48BE1B0", Offset = "0x48BD1B0", VA = "0x1848BE1B0", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x48BA470", Offset = "0x48B9470", VA = "0x1848BA470", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a FNDQYUTZTLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x48BE1B0", Offset = "0x48BD1B0", VA = "0x1848BE1B0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x48BBD50", Offset = "0x48BAD50", VA = "0x1848BBD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool RYKYLKXYKMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x48B7F20", Offset = "0x48B6F20", VA = "0x1848B7F20", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x48B74F0", Offset = "0x48B64F0", VA = "0x1848B74F0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool GJCZRRWYTMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x48BA570", Offset = "0x48B9570", VA = "0x1848BA570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x48BD280", Offset = "0x48BC280", VA = "0x1848BD280", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x48BF270", Offset = "0x48BE270", VA = "0x1848BF270")]
		public EKUZKUPSUIP([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x48BE0D0", Offset = "0x48BD0D0", VA = "0x1848BE0D0")]
		private void UIVLLHALZVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x48B9FD0", Offset = "0x48B8FD0", VA = "0x1848B9FD0", Slot = "5")]
		public void CGSBIOWILNF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x48BA0D0", Offset = "0x48B90D0", VA = "0x1848BA0D0")]
		public void CGSBIOWILNF(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x48B7090", Offset = "0x48B6090", VA = "0x1848B7090", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class ELAGIBJQDTY<a, b> : XIVBPOERIQO<(a, b)>, TOHSKKQOIRH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly RCWHPLZBTVD<a, b> IIHXLSHTTDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly RCWHPLZBTVD<a, b> SRNVHAQRUMZ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string QZQNBFORTMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xD1E3E0", Offset = "0xD1D3E0", VA = "0x180D1E3E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool MPUJNOZZIEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x48C2D20", Offset = "0x48C1D20", VA = "0x1848C2D20", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool YLRCEEDENCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x48C6520", Offset = "0x48C5520", VA = "0x1848C6520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool YLWJBKXBWNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x48C66E0", Offset = "0x48C56E0", VA = "0x1848C66E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) OJDOPJSMVRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x48C3880", Offset = "0x48C2880", VA = "0x1848C3880", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x48C4920", Offset = "0x48C3920", VA = "0x1848C4920", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) GGQCFUKWTNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x48C6D80", Offset = "0x48C5D80", VA = "0x1848C6D80", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x48C1700", Offset = "0x48C0700", VA = "0x1848C1700", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) FNDQYUTZTLK
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x48C6080", Offset = "0x48C5080", VA = "0x1848C6080")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x48C3BE0", Offset = "0x48C2BE0", VA = "0x1848C3BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a XQTTWKZUCAO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x48C5570", Offset = "0x48C4570", VA = "0x1848C5570")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x48C1C90", Offset = "0x48C0C90", VA = "0x1848C1C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a CQZHRCIHMMF
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x48C3A70", Offset = "0x48C2A70", VA = "0x1848C3A70")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x48C5DF0", Offset = "0x48C4DF0", VA = "0x1848C5DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a BWFPUBACZFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x48C3A70", Offset = "0x48C2A70", VA = "0x1848C3A70")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x48C2C90", Offset = "0x48C1C90", VA = "0x1848C2C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b XQOMZEFWSPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x48C5680", Offset = "0x48C4680", VA = "0x1848C5680")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x48C1F00", Offset = "0x48C0F00", VA = "0x1848C1F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b CQJMZIAPKEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x48C3970", Offset = "0x48C2970", VA = "0x1848C3970")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b BWKWRHUAIRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x48C3970", Offset = "0x48C2970", VA = "0x1848C3970")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x48C2340", Offset = "0x48C1340", VA = "0x1848C2340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool RYKYLKXYKMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x48B7F20", Offset = "0x48B6F20", VA = "0x1848B7F20", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x48B74F0", Offset = "0x48B64F0", VA = "0x1848B74F0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x48C5140", Offset = "0x48C4140", VA = "0x1848C5140", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x48C7450", Offset = "0x48C6450", VA = "0x1848C7450")]
		public ELAGIBJQDTY([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x48C5CC0", Offset = "0x48C4CC0", VA = "0x1848C5CC0")]
		private void UIVLLHALZVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x48C0B70", Offset = "0x48BFB70", VA = "0x1848C0B70")]
		public void BDKYKNZQHZK(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x48C1160", Offset = "0x48C0160", VA = "0x1848C1160")]
		public void CGSBIOWILNF(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x48C3E90", Offset = "0x48C2E90", VA = "0x1848C3E90", Slot = "5")]
		private void ROMYIITMHTG((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x48B7090", Offset = "0x48B6090", VA = "0x1848B7090", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class ELFNFIDNNFH<a, b, c> : XIVBPOERIQO<(a, b, c)>, TOHSKKQOIRH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly RCRASFFEKJU<a, b, c> IIHXLSHTTDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly RCRASFFEKJU<a, b, c> SRNVHAQRUMZ;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string QZQNBFORTMC
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xD1E3E0", Offset = "0xD1D3E0", VA = "0x180D1E3E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool MPUJNOZZIEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x48C9B50", Offset = "0x48C8B50", VA = "0x1848C9B50", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool YLRCEEDENCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x48CC080", Offset = "0x48CB080", VA = "0x1848CC080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool YLWJBKXBWNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x48CC450", Offset = "0x48CB450", VA = "0x1848CC450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool YMBPYRQZFYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x48CC290", Offset = "0x48CB290", VA = "0x1848CC290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) OJDOPJSMVRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x48CA6B0", Offset = "0x48C96B0", VA = "0x1848CA6B0", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x48CB4C0", Offset = "0x48CA4C0", VA = "0x1848CB4C0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) GGQCFUKWTNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x48CC870", Offset = "0x48CB870", VA = "0x1848CC870", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x48C88E0", Offset = "0x48C78E0", VA = "0x1848C88E0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a XQTTWKZUCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x48CB9C0", Offset = "0x48CA9C0", VA = "0x1848CB9C0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x48C8C90", Offset = "0x48C7C90", VA = "0x1848C8C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a CQZHRCIHMMF
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x48CACA0", Offset = "0x48C9CA0", VA = "0x1848CACA0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a BWFPUBACZFR
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x48CACA0", Offset = "0x48C9CA0", VA = "0x1848CACA0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x48C9A10", Offset = "0x48C8A10", VA = "0x1848C9A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b XQOMZEFWSPF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x48CBAA0", Offset = "0x48CAAA0", VA = "0x1848CBAA0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x48C8F70", Offset = "0x48C7F70", VA = "0x1848C8F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b CQJMZIAPKEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x48CABC0", Offset = "0x48C9BC0", VA = "0x1848CABC0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b BWKWRHUAIRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x48CABC0", Offset = "0x48C9BC0", VA = "0x1848CABC0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x48C9710", Offset = "0x48C8710", VA = "0x1848C9710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c XQJGBXLZJDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x48CBAD0", Offset = "0x48CAAD0", VA = "0x1848CBAD0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x48C9490", Offset = "0x48C8490", VA = "0x1848C9490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c CQOTWOUMTPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x48CAB90", Offset = "0x48C9B90", VA = "0x1848CAB90")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c BWQDOONXSCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x48CAB90", Offset = "0x48C9B90", VA = "0x1848CAB90")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x48C9510", Offset = "0x48C8510", VA = "0x1848C9510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool RYKYLKXYKMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x48B7F20", Offset = "0x48B6F20", VA = "0x1848B7F20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x48CB700", Offset = "0x48CA700", VA = "0x1848CB700", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x48CCFB0", Offset = "0x48CBFB0", VA = "0x1848CCFB0")]
		public ELFNFIDNNFH([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x48CBCA0", Offset = "0x48CACA0", VA = "0x1848CBCA0")]
		private void UIVLLHALZVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x48C8260", Offset = "0x48C7260", VA = "0x1848C8260")]
		public void BDKYKNZQHZK(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x48CA440", Offset = "0x48C9440", VA = "0x1848CA440")]
		public void KNUIMMCWEGH(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x48CA140", Offset = "0x48C9140", VA = "0x1848CA140")]
		public void INNKNMSZZOC(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x48C8620", Offset = "0x48C7620", VA = "0x1848C8620")]
		public void CGSBIOWILNF(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x48CCAB0", Offset = "0x48CBAB0", VA = "0x1848CCAB0", Slot = "5")]
		private void ZHLAGBTVYGZ((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x48B7090", Offset = "0x48B6090", VA = "0x1848B7090", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class EJUQYMUFZDW<a, b, c, d> : XIVBPOERIQO<(a, b, c, d)>, TOHSKKQOIRH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly RDGVJZMWMRV<a, b, c, d> IIHXLSHTTDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly RDGVJZMWMRV<a, b, c, d> SRNVHAQRUMZ;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string QZQNBFORTMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xD1E3E0", Offset = "0xD1D3E0", VA = "0x180D1E3E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) GGQCFUKWTNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x48B7F40", Offset = "0x48B6F40", VA = "0x1848B7F40", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x48B74A0", Offset = "0x48B64A0", VA = "0x1848B74A0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b CQJMZIAPKEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x48B79C0", Offset = "0x48B69C0", VA = "0x1848B79C0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c CQOTWOUMTPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x48B7990", Offset = "0x48B6990", VA = "0x1848B7990")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d CPYZEUMURHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x48B7B50", Offset = "0x48B6B50", VA = "0x1848B7B50")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool RYKYLKXYKMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x48B7F20", Offset = "0x48B6F20", VA = "0x1848B7F20", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x48B74F0", Offset = "0x48B64F0", VA = "0x1848B74F0", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x48B8440", Offset = "0x48B7440", VA = "0x1848B8440")]
		public EJUQYMUFZDW([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x48B7E10", Offset = "0x48B6E10", VA = "0x1848B7E10")]
		private void UIVLLHALZVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x48B6C80", Offset = "0x48B5C80", VA = "0x1848B6C80")]
		public void BDKYKNZQHZK(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x48B6D70", Offset = "0x48B5D70", VA = "0x1848B6D70")]
		public void CGSBIOWILNF(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x48B7510", Offset = "0x48B6510", VA = "0x1848B7510", Slot = "5")]
		private void MHMWYQLYGQN((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x48B7090", Offset = "0x48B6090", VA = "0x1848B7090", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class GKFBAIWZEGS
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x85D0DA0", Offset = "0x85CFDA0", VA = "0x1885D0DA0")]
		public static string CSSUJRTFQCN(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xBE14C0", Offset = "0xBE04C0", VA = "0x180BE14C0")]
		public static NetworkSetterPermissionMode ZZVZWAADVIW(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class RCGMXRRJRNC<a> : NEVJYQCQUKF<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E667A0", Offset = "0x5E657A0", VA = "0x185E667A0")]
		public RCGMXRRJRNC([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A040", Offset = "0x5E69040", VA = "0x185E6A040")]
		public RCGMXRRJRNC(FFHJLRAELVV a, OVSEBXDBUJS b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] RLKFNJWEYUT g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5E65760", Offset = "0x5E64760", VA = "0x185E65760")]
		public RCGMXRRJRNC(FFHJLRAELVV a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] RLKFNJWEYUT f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5E69BA0", Offset = "0x5E68BA0", VA = "0x185E69BA0")]
		public RCGMXRRJRNC(FFHJLRAELVV a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] RLKFNJWEYUT g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RCWHPLZBTVD<a, b> : NEFPGVUYSCE<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5E704A0", Offset = "0x5E6F4A0", VA = "0x185E704A0")]
		public RCWHPLZBTVD([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5E709E0", Offset = "0x5E6F9E0", VA = "0x185E709E0")]
		public RCWHPLZBTVD(FFHJLRAELVV a, OVSEBXDBUJS b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] RLKFNJWEYUT h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5E71810", Offset = "0x5E70810", VA = "0x185E71810")]
		public RCWHPLZBTVD(FFHJLRAELVV a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] RLKFNJWEYUT g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5E706A0", Offset = "0x5E6F6A0", VA = "0x185E706A0")]
		public RCWHPLZBTVD(FFHJLRAELVV a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] RLKFNJWEYUT h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class RCRASFFEKJU<a, b, c> : NEKWECOWBNN<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B090", Offset = "0x5E6A090", VA = "0x185E6B090")]
		public RCRASFFEKJU([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A830", Offset = "0x5E69830", VA = "0x185E6A830")]
		public RCRASFFEKJU(FFHJLRAELVV a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] RLKFNJWEYUT h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class RDGVJZMWMRV<a, b, c, d> : NFLEQKKIWSG<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E739C0", Offset = "0x5E729C0", VA = "0x185E739C0")]
		public RDGVJZMWMRV([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5E733E0", Offset = "0x5E723E0", VA = "0x185E733E0")]
		public RDGVJZMWMRV(FFHJLRAELVV a, OVSEBXDBUJS b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] RLKFNJWEYUT j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5E73690", Offset = "0x5E72690", VA = "0x185E73690")]
		public RDGVJZMWMRV(FFHJLRAELVV a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] RLKFNJWEYUT i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class RDBOMSSZDGM<a, b, c, d, e> : NFQLNREGGDP<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5E720F0", Offset = "0x5E710F0", VA = "0x185E720F0")]
		public RDBOMSSZDGM(FFHJLRAELVV a, OVSEBXDBUJS b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] RLKFNJWEYUT k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5E727A0", Offset = "0x5E717A0", VA = "0x185E727A0")]
		public RDBOMSSZDGM(FFHJLRAELVV a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] RLKFNJWEYUT j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class UVZBDRTUMOX<a> : NEVJYQCQUKF<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x63E4E00", Offset = "0x63E3E00", VA = "0x1863E4E00")]
		public UVZBDRTUMOX(OVSEBXDBUJS a, string b, a c, [Optional] Action d, [Optional] RLKFNJWEYUT e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class UWEIAYNRWAG<a, b> : NEFPGVUYSCE<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x63E5130", Offset = "0x63E4130", VA = "0x1863E5130")]
		public UWEIAYNRWAG(OVSEBXDBUJS a, string b, a c, b d, [Optional] Action e, [Optional] RLKFNJWEYUT f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface CORHQDJXQXP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RCGMXRRJRNC<a> WJVQZEZWMPX<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class XMDAVSHLZUO : CORHQDJXQXP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly RLKFNJWEYUT NZBLWFTVTEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly FFHJLRAELVV LMGFUTIDBOW;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xACA870", Offset = "0xAC9870", VA = "0x180ACA870")]
		public XMDAVSHLZUO(RLKFNJWEYUT a, FFHJLRAELVV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3C66BA0", Offset = "0x3C65BA0", VA = "0x183C66BA0", Slot = "4")]
		public RCGMXRRJRNC<a> WJVQZEZWMPX<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface GDNETMRXOLS : FFHJLRAELVV
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId HNZVHGFNDLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface FFHJLRAELVV
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool WLVSURWXUOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool ZKATOGNQQWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string HZIBFLVKVJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool YMRAHILDUXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(SMDYNWTJNDH handler);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(SMDYNWTJNDH handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class LYVGQNBJBFX
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x85D0DE0", Offset = "0x85CFDE0", VA = "0x1885D0DE0")]
		public static bool ZAVNZYGKKLU(this FFHJLRAELVV a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface RLKFNJWEYUT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		OVSEBXDBUJS UOTHWZKTJRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool GJCZRRWYTMO
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool RIAZAHEERGH
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
		object EIYLXCGQUVN(string a);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object FHQYWVJORZX(OVSEBXDBUJS a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void TACQEBQLUEL(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void PGYKCSOXZTP(OVSEBXDBUJS a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void JYXIFRSEFTI<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void DAXVLUZNIZO([CanBeNull] OVSEBXDBUJS photonPlayer, string a, VNLFEPUTBSL b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void FLVLYIBHWDD([CanBeNull] OVSEBXDBUJS photonPlayer, string a, VNLFEPUTBSL b);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b XYRNMWYGJZJ<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object ZYZUIWBCDKK<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		object XYRNMWYGJZJ(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		object ZYZUIWBCDKK(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void VAZOMQJFPWL();

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void ZCBGWXXYIJD();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void MSUOREDYZCI(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public OVSEBXDBUJS player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public FFHJLRAELVV context;

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
		public RLKFNJWEYUT networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x85D1010", Offset = "0x85D0010", VA = "0x1885D1010")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x85D0E80", Offset = "0x85CFE80", VA = "0x1885D0E80")]
		public SyncData(FFHJLRAELVV context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] RLKFNJWEYUT networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x85D0E30", Offset = "0x85CFE30", VA = "0x1885D0E30")]
		public static SyncData From(FFHJLRAELVV context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] RLKFNJWEYUT networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class PICNASVPWGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3973A30", Offset = "0x3972A30", VA = "0x183973A30")]
		public static RCGMXRRJRNC<a> VNLFEPUTBSL<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3973020", Offset = "0x3972020", VA = "0x183973020")]
		public static RCWHPLZBTVD<b, c> VNLFEPUTBSL<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x39730C0", Offset = "0x39720C0", VA = "0x1839730C0")]
		public static RCRASFFEKJU<d, e, f> VNLFEPUTBSL<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x39734E0", Offset = "0x39724E0", VA = "0x1839734E0")]
		public static RDGVJZMWMRV<g, h, i, j> VNLFEPUTBSL<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3972070", Offset = "0x3971070", VA = "0x183972070")]
		public static EKUZKUPSUIP<k> BNSIYVQHXYI<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3971F20", Offset = "0x3970F20", VA = "0x183971F20")]
		public static ELAGIBJQDTY<l, m> BNSIYVQHXYI<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3971FC0", Offset = "0x3970FC0", VA = "0x183971FC0")]
		public static ELFNFIDNNFH<n, o, p> BNSIYVQHXYI<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3972A30", Offset = "0x3971A30", VA = "0x183972A30")]
		public static EJUQYMUFZDW<q, r, s, t> BNSIYVQHXYI<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class VNLFEPUTBSL : SMDYNWTJNDH, IDisposable
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
		private static Stack<RLKFNJWEYUT> ENAWMKDZDXP;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool XVRSCNEUMTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly OVSEBXDBUJS DTYPFDEGLFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly FFHJLRAELVV LMGFUTIDBOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string MFGYHTMRNRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode WVIXSULRDIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action LHPNEULWNUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected RLKFNJWEYUT IKUQZMQXDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags NSPAFXTWKDY;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static RLKFNJWEYUT MWIVLNDXOEX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x85D43E0", Offset = "0x85D33E0", VA = "0x1885D43E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool NYMNNPKFXHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x85D4A20", Offset = "0x85D3A20", VA = "0x1885D4A20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x85D4600", Offset = "0x85D3600", VA = "0x1885D4600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool MWFRFJNCXDY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x85D3870", Offset = "0x85D2870", VA = "0x1885D3870")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x85D3EE0", Offset = "0x85D2EE0", VA = "0x1885D3EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool GLSRKVMWOET
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x85D3E70", Offset = "0x85D2E70", VA = "0x1885D3E70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x85D3E50", Offset = "0x85D2E50", VA = "0x1885D3E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool RYKYLKXYKMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x85D4A10", Offset = "0x85D3A10", VA = "0x1885D4A10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x85D42A0", Offset = "0x85D32A0", VA = "0x1885D42A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object NUNSJCDTDVM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F50", Offset = "0xAD1F50", VA = "0x180AD2F50", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAD32E0", Offset = "0xAD22E0", VA = "0x180AD32E0", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool HZMOXVXXAMV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x85D45B0", Offset = "0x85D35B0", VA = "0x1885D45B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int MEAINNZSTHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xC3AF70", Offset = "0xC39F70", VA = "0x180C3AF70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1836E50", Offset = "0x1835E50", VA = "0x181836E50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string QZQNBFORTMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool GJCZRRWYTMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x85D3E00", Offset = "0x85D2E00", VA = "0x1885D3E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x85D4BA0", Offset = "0x85D3BA0", VA = "0x1885D4BA0")]
		public static void YFRVXNTCRFQ(RLKFNJWEYUT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool WDXESVPTVBW();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x85D4F20", Offset = "0x85D3F20", VA = "0x1885D4F20")]
		protected VNLFEPUTBSL(OVSEBXDBUJS a, FFHJLRAELVV b, string c, NetworkSetterPermissionMode d, Action e, RLKFNJWEYUT f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x85D3E80", Offset = "0x85D2E80", VA = "0x1885D3E80", Slot = "1")]
		~VNLFEPUTBSL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x85D3C90", Offset = "0x85D2C90", VA = "0x1885D3C90", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x85D4900", Offset = "0x85D3900", VA = "0x1885D4900")]
		private void UZOXOMBFCRY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x85D4A30", Offset = "0x85D3A30", VA = "0x1885D4A30")]
		private object YDBSFCELBFQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x85D40D0", Offset = "0x85D30D0", VA = "0x1885D40D0")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x85D4620", Offset = "0x85D3620", VA = "0x1885D4620")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x85D4C40", Offset = "0x85D3C40", VA = "0x1885D4C40")]
		protected void YOZERRNUNWP(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x85D4360", Offset = "0x85D3360", VA = "0x1885D4360")]
		internal void KIOTZYQZPUP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x85D3880", Offset = "0x85D2880", VA = "0x1885D3880")]
		private void AKPYDSUYTLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x85D4070", Offset = "0x85D3070", VA = "0x1885D4070")]
		private void IPUZQVZWGCY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x85D49A0", Offset = "0x85D39A0", VA = "0x1885D49A0", Slot = "4")]
		private void XCETEZPPBYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x85D4460", Offset = "0x85D3460", VA = "0x1885D4460", Slot = "5")]
		private void MIYMQLRVRBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x85D4660", Offset = "0x85D3660", VA = "0x1885D4660")]
		public bool UGBWFPCUVTH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x85D39F0", Offset = "0x85D29F0", VA = "0x1885D39F0")]
		public bool DJOPDXSSMXH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x85D3F20", Offset = "0x85D2F20", VA = "0x1885D3F20")]
		private bool INKVADRXEAO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x85D4500", Offset = "0x85D3500", VA = "0x1885D4500")]
		internal void NVJZKONCIFR(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x85D38E0", Offset = "0x85D28E0", VA = "0x1885D38E0")]
		private void AOWGBXMNCZH(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x85D4450", Offset = "0x85D3450", VA = "0x1885D4450")]
		private bool LMPMQAWWOOH(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x85D3F00", Offset = "0x85D2F00", VA = "0x1885D3F00")]
		private void HJTPTUBESTJ(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x85D4470", Offset = "0x85D3470", VA = "0x1885D4470")]
		public static string MNHPSQEHLCZ(OVSEBXDBUJS a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x85D3BB0", Offset = "0x85D2BB0", VA = "0x1885D3BB0")]
		public static string DSCDOBRCILX(FFHJLRAELVV a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x85D47A0", Offset = "0x85D37A0", VA = "0x1885D47A0")]
		public static bool UKMZFCFIELZ(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class VDTHKXQMYYJ : RLKFNJWEYUT, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<object, object> FGDEMMCADCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<string> HEUTFJGODUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<object, object> NXOXWXWDALW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> VWYPUMTJRIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool CKKXJOLCXCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly Dictionary<string, object> REFHPZRTPWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<OVSEBXDBUJS, Dictionary<string, object>> SNEUGSOBVEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<string> ELQEGBWCKWF;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> MZHPSSRGJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int LUTQVZYZILE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract OVSEBXDBUJS UOTHWZKTJRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool GJCZRRWYTMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool RIAZAHEERGH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool VZMVZJCXRJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool OPWPRMKHCCE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xB25800", Offset = "0xB24800", VA = "0x180B25800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3C4A2F0", Offset = "0x3C492F0", VA = "0x183C4A2F0", Slot = "12")]
		public void JYXIFRSEFTI<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x85D24C0", Offset = "0x85D14C0", VA = "0x1885D24C0", Slot = "11")]
		public void PGYKCSOXZTP(OVSEBXDBUJS a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x85D19A0", Offset = "0x85D09A0", VA = "0x1885D19A0", Slot = "9")]
		public object FHQYWVJORZX(OVSEBXDBUJS a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x85D2910", Offset = "0x85D1910", VA = "0x1885D2910", Slot = "10")]
		public void TACQEBQLUEL(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x85D1470", Offset = "0x85D0470", VA = "0x1885D1470", Slot = "8")]
		public object EIYLXCGQUVN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x85D1200", Offset = "0x85D0200", VA = "0x1885D1200", Slot = "13")]
		public void DAXVLUZNIZO(OVSEBXDBUJS a, string b, VNLFEPUTBSL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x85D1A90", Offset = "0x85D0A90", VA = "0x1885D1A90", Slot = "14")]
		public void FLVLYIBHWDD(OVSEBXDBUJS a, string b, VNLFEPUTBSL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x85D11B0", Offset = "0x85D01B0", VA = "0x1885D11B0")]
		private void CNOFHIJRWCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x85D30B0", Offset = "0x85D20B0", VA = "0x1885D30B0")]
		private void VTOCOTXTVYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x85D1DD0", Offset = "0x85D0DD0", VA = "0x1885D1DD0")]
		private void HDCUBUQNODM(OVSEBXDBUJS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x85D1090", Offset = "0x85D0090", VA = "0x1885D1090")]
		protected void AEEXCFBMTYM(OVSEBXDBUJS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x85D23D0", Offset = "0x85D13D0", VA = "0x1885D23D0")]
		protected void NYOOUZXBHKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x85D1510", Offset = "0x85D0510", VA = "0x1885D1510")]
		protected void EMGUXNOFNWU(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x85D2050", Offset = "0x85D1050", VA = "0x1885D2050")]
		protected void LCQGOHADRMA(OVSEBXDBUJS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x85D2880", Offset = "0x85D1880", VA = "0x1885D2880")]
		protected void SLTDJORUCMC(OVSEBXDBUJS a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x85D1520", Offset = "0x85D0520", VA = "0x1885D1520")]
		private void EPXHLENTTYF(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x85D33A0", Offset = "0x85D23A0", VA = "0x1885D33A0")]
		private static void YVCKXGLQJBH(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E30", Offset = "0x85D0E30", VA = "0x1885D1E30")]
		private static void JIXNLNMKTRC(Dictionary<string, object> a, string b, VNLFEPUTBSL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x85D31D0", Offset = "0x85D21D0", VA = "0x1885D31D0")]
		private static void YTKRPKCTXCX(Dictionary<string, object> a, string b, VNLFEPUTBSL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x85D2FB0", Offset = "0x85D1FB0", VA = "0x1885D2FB0", Slot = "19")]
		public void VAZOMQJFPWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract void ITIJMUSJOBQ(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x85D35A0", Offset = "0x85D25A0", VA = "0x1885D35A0", Slot = "20")]
		public void ZCBGWXXYIJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		protected abstract void VMDSHNQQMKE(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x85D2D90", Offset = "0x85D1D90", VA = "0x1885D2D90")]
		private void URHKRNDMNPN(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x85D2610", Offset = "0x85D1610", VA = "0x1885D2610")]
		private void REBDWGTZZAO(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x85D1D40", Offset = "0x85D0D40", VA = "0x1885D1D40")]
		public void GVPLGYIUUSV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x85D3100", Offset = "0x85D2100", VA = "0x1885D3100")]
		public void YRTNFOXJHGZ(OVSEBXDBUJS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x85D2A30", Offset = "0x85D1A30", VA = "0x1885D2A30")]
		public void TDZKPMDHSCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		protected abstract HashSet<int> ZVRUQLSRKXA(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x85D2150", Offset = "0x85D1150", VA = "0x1885D2150", Slot = "21")]
		public void MSUOREDYZCI(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x85D20C0", Offset = "0x85D10C0", VA = "0x1885D20C0")]
		protected string MNHPSQEHLCZ(OVSEBXDBUJS a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "32")]
		public abstract object ZYZUIWBCDKK<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "33")]
		public abstract c XYRNMWYGJZJ<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "34")]
		public abstract object ZYZUIWBCDKK(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "35")]
		public abstract object XYRNMWYGJZJ(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "36")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x85D1310", Offset = "0x85D0310", VA = "0x1885D1310", Slot = "22")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "37")]
		protected virtual void ZLXODHYBEAR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x85D3680", Offset = "0x85D2680", VA = "0x1885D3680")]
		protected VDTHKXQMYYJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class NEVJYQCQUKF<a> : VNLFEPUTBSL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private a OPVPKGTQJPG;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a XXTBJIOPKMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x5B22CB0", Offset = "0x5B21CB0", VA = "0x185B22CB0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x5B22C50", Offset = "0x5B21C50", VA = "0x185B22C50", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object NUNSJCDTDVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x5B050F0", Offset = "0x5B040F0", VA = "0x185B050F0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x5B1BF00", Offset = "0x5B1AF00", VA = "0x185B1BF00", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5B21DB0", Offset = "0x5B20DB0", VA = "0x185B21DB0", Slot = "9")]
		protected override bool WDXESVPTVBW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5B25760", Offset = "0x5B24760", VA = "0x185B25760")]
		protected NEVJYQCQUKF([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5B241E0", Offset = "0x5B231E0", VA = "0x185B241E0")]
		protected NEVJYQCQUKF(OVSEBXDBUJS a, FFHJLRAELVV b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, RLKFNJWEYUT h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5B09300", Offset = "0x5B08300", VA = "0x185B09300")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5B1EAA0", Offset = "0x5B1DAA0", VA = "0x185B1EAA0")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5B1DBE0", Offset = "0x5B1CBE0", VA = "0x185B1DBE0")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class NEFPGVUYSCE<a, b> : VNLFEPUTBSL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private a OPVPKGTQJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private b OQLKCBBILXH;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a XXTBJIOPKMH
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0xE80490", Offset = "0xE7F490", VA = "0x180E80490", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x10507D0", Offset = "0x104F7D0", VA = "0x1810507D0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b XXYIGPIMTXQ
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x3015530", Offset = "0x3014530", VA = "0x183015530", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5B0CE50", Offset = "0x5B0BE50", VA = "0x185B0CE50", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b QZPZKDCYZQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x14B10B0", Offset = "0x14B00B0", VA = "0x1814B10B0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object NUNSJCDTDVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x5B050F0", Offset = "0x5B040F0", VA = "0x185B050F0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x5B033B0", Offset = "0x5B023B0", VA = "0x185B033B0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5B0C310", Offset = "0x5B0B310", VA = "0x185B0C310", Slot = "9")]
		protected override bool WDXESVPTVBW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5B0EE30", Offset = "0x5B0DE30", VA = "0x185B0EE30")]
		protected NEFPGVUYSCE([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5B0D800", Offset = "0x5B0C800", VA = "0x185B0D800")]
		protected NEFPGVUYSCE(OVSEBXDBUJS a, FFHJLRAELVV b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, RLKFNJWEYUT i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5B09300", Offset = "0x5B08300", VA = "0x185B09300")]
		public a TXOUEWZGQYA()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5B09F40", Offset = "0x5B08F40", VA = "0x185B09F40")]
		public void UIDXLMZKFRG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x14B10B0", Offset = "0x14B00B0", VA = "0x1814B10B0")]
		public b TYEOWRGYTGB()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5B0A840", Offset = "0x5B09840", VA = "0x185B0A840")]
		public void UITSDHHCHZH(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5B07DA0", Offset = "0x5B06DA0", VA = "0x185B07DA0")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class NEKWECOWBNN<a, b, c> : VNLFEPUTBSL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private a OPVPKGTQJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private b OQLKCBBILXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private c OQGDEUHLCLY;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a XXTBJIOPKMH
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xADD460", Offset = "0xADC460", VA = "0x180ADD460", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xADCE80", Offset = "0xADBE80", VA = "0x180ADCE80", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b XXYIGPIMTXQ
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xC516E0", Offset = "0xC506E0", VA = "0x180C516E0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x28559F0", Offset = "0x28549F0", VA = "0x1828559F0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c XYDPDWCKDIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xACDCA0", Offset = "0xACCCA0", VA = "0x180ACDCA0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xACDCC0", Offset = "0xACCCC0", VA = "0x180ACDCC0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a QZKSMWJBQFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5B09300", Offset = "0x5B08300", VA = "0x185B09300")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b QZPZKDCYZQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x14B10B0", Offset = "0x14B00B0", VA = "0x1814B10B0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c QZVGHJWWJBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x5B12080", Offset = "0x5B11080", VA = "0x185B12080")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object NUNSJCDTDVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x5B050F0", Offset = "0x5B040F0", VA = "0x185B050F0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5B10D00", Offset = "0x5B0FD00", VA = "0x185B10D00", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5B12CB0", Offset = "0x5B11CB0", VA = "0x185B12CB0", Slot = "9")]
		protected override bool WDXESVPTVBW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5B13150", Offset = "0x5B12150", VA = "0x185B13150")]
		protected NEKWECOWBNN([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5B12EC0", Offset = "0x5B11EC0", VA = "0x185B12EC0")]
		protected NEKWECOWBNN(OVSEBXDBUJS a, FFHJLRAELVV b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, RLKFNJWEYUT j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5B09300", Offset = "0x5B08300", VA = "0x185B09300")]
		public a TXOUEWZGQYA()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5B12290", Offset = "0x5B11290", VA = "0x185B12290")]
		public void UIDXLMZKFRG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x14B10B0", Offset = "0x14B00B0", VA = "0x1814B10B0")]
		public b TYEOWRGYTGB()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5B12570", Offset = "0x5B11570", VA = "0x185B12570")]
		public void UITSDHHCHZH(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5B12080", Offset = "0x5B11080", VA = "0x185B12080")]
		public c TXZHZKNBJUS()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5B12450", Offset = "0x5B11450", VA = "0x185B12450")]
		public void UIOLGANEYNY(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5B11D20", Offset = "0x5B10D20", VA = "0x185B11D20")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class NFLEQKKIWSG<a, b, c, d> : VNLFEPUTBSL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private a OPVPKGTQJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private b OQLKCBBILXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private c OQGDEUHLCLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private d OQVXWOPDETZ;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a XXTBJIOPKMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xCDECF0", Offset = "0xCDDCF0", VA = "0x180CDECF0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x5B423F0", Offset = "0x5B413F0", VA = "0x185B423F0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b XXYIGPIMTXQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1258BC0", Offset = "0x1257BC0", VA = "0x181258BC0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x1257620", Offset = "0x1256620", VA = "0x181257620", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c XYDPDWCKDIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x12A6350", Offset = "0x12A5350", VA = "0x1812A6350", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x5B42410", Offset = "0x5B41410", VA = "0x185B42410", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d XWSSXATCPHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1ACF1A0", Offset = "0x1ACE1A0", VA = "0x181ACF1A0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x1405C30", Offset = "0x1404C30", VA = "0x181405C30", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b QZPZKDCYZQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x5B093F0", Offset = "0x5B083F0", VA = "0x185B093F0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c QZVGHJWWJBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x5B120A0", Offset = "0x5B110A0", VA = "0x185B120A0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d QYKKAONOVAM
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x1391410", Offset = "0x1390410", VA = "0x181391410")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object NUNSJCDTDVM
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x5B050F0", Offset = "0x5B040F0", VA = "0x185B050F0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x5B3D280", Offset = "0x5B3C280", VA = "0x185B3D280", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5B419B0", Offset = "0x5B409B0", VA = "0x185B419B0", Slot = "9")]
		protected override bool WDXESVPTVBW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5B42D60", Offset = "0x5B41D60", VA = "0x185B42D60")]
		protected NFLEQKKIWSG([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5B42E10", Offset = "0x5B41E10", VA = "0x185B42E10")]
		protected NFLEQKKIWSG(OVSEBXDBUJS a, FFHJLRAELVV b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, RLKFNJWEYUT k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5B09300", Offset = "0x5B08300", VA = "0x185B09300")]
		public a TXOUEWZGQYA()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5B405A0", Offset = "0x5B3F5A0", VA = "0x185B405A0")]
		public void UIDXLMZKFRG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5B093F0", Offset = "0x5B083F0", VA = "0x185B093F0")]
		public b TYEOWRGYTGB()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5B411E0", Offset = "0x5B401E0", VA = "0x185B411E0")]
		public void UITSDHHCHZH(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5B120A0", Offset = "0x5B110A0", VA = "0x185B120A0")]
		public c TXZHZKNBJUS()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5B40D70", Offset = "0x5B3FD70", VA = "0x185B40D70")]
		public void UIOLGANEYNY(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x1391410", Offset = "0x1390410", VA = "0x181391410")]
		public d TYPCREUTMCT()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5B40290", Offset = "0x5B3F290", VA = "0x185B40290")]
		public void UHOCTSRSDJF(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5B3E880", Offset = "0x5B3D880", VA = "0x185B3E880")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class NFQLNREGGDP<a, b, c, d, e> : VNLFEPUTBSL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private a OPVPKGTQJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private b OQLKCBBILXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private c OQGDEUHLCLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private d OQVXWOPDETZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private e OQQQZHVFVIQ;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a XXTBJIOPKMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xADD460", Offset = "0xADC460", VA = "0x180ADD460", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xADCE80", Offset = "0xADBE80", VA = "0x180ADCE80", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b XXYIGPIMTXQ
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xB80760", Offset = "0xB7F760", VA = "0x180B80760", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x121BEC0", Offset = "0x121AEC0", VA = "0x18121BEC0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c XYDPDWCKDIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xBA8CC0", Offset = "0xBA7CC0", VA = "0x180BA8CC0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xBA8CD0", Offset = "0xBA7CD0", VA = "0x180BA8CD0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d XWSSXATCPHO
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xAE6760", Offset = "0xAE5760", VA = "0x180AE6760", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xAF6D60", Offset = "0xAF5D60", VA = "0x180AF6D60", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e XWXZUHMZYSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAE63A0", Offset = "0xAE53A0", VA = "0x180AE63A0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x5B42480", Offset = "0x5B41480", VA = "0x185B42480", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object NUNSJCDTDVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x5B050F0", Offset = "0x5B040F0", VA = "0x185B050F0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x5B54200", Offset = "0x5B53200", VA = "0x185B54200", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5B591C0", Offset = "0x5B581C0", VA = "0x185B591C0", Slot = "9")]
		protected override bool WDXESVPTVBW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5B5BA20", Offset = "0x5B5AA20", VA = "0x185B5BA20")]
		protected NFQLNREGGDP(OVSEBXDBUJS a, FFHJLRAELVV b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, RLKFNJWEYUT l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5B09300", Offset = "0x5B08300", VA = "0x185B09300")]
		public a TXOUEWZGQYA()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5B57E10", Offset = "0x5B56E10", VA = "0x185B57E10")]
		public void UIDXLMZKFRG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x14B10B0", Offset = "0x14B00B0", VA = "0x1814B10B0")]
		public b TYEOWRGYTGB()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5B58B30", Offset = "0x5B57B30", VA = "0x185B58B30")]
		public void UITSDHHCHZH(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5B12080", Offset = "0x5B11080", VA = "0x185B12080")]
		public c TXZHZKNBJUS()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5B58740", Offset = "0x5B57740", VA = "0x185B58740")]
		public void UIOLGANEYNY(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x1391410", Offset = "0x1390410", VA = "0x181391410")]
		public d TYPCREUTMCT()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5B575A0", Offset = "0x5B565A0", VA = "0x185B575A0")]
		public void UHOCTSRSDJF(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5B56BE0", Offset = "0x5B55BE0", VA = "0x185B56BE0")]
		public e TYJVTYAWCRK()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5B56FD0", Offset = "0x5B55FD0", VA = "0x185B56FD0")]
		public void UHIVWLXUTXW(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5B54410", Offset = "0x5B53410", VA = "0x185B54410")]
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
