using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : AHNNEHLOHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6121790", Offset = "0x6120B90", VA = "0x186121790", Slot = "4")]
		public override void GPKLHHLKJHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : LHJJEIDOJLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private IPMDCNDONNF bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private IPMDCNDONNF bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x612C260", Offset = "0x612B660", VA = "0x18612C260", Slot = "5")]
		public override void EPIKBAOIJJD(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x612C5E0", Offset = "0x612B9E0", VA = "0x18612C5E0")]
		private void LCMBPGOKGFP(MKELEIBDMMM registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x612C750", Offset = "0x612BB50", VA = "0x18612C750")]
		private void MDCKLCKJGGE(MKELEIBDMMM registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x612C2A0", Offset = "0x612B6A0", VA = "0x18612C2A0", Slot = "6")]
		public override void HDPKBLFAOGN(MKELEIBDMMM registry, [In] CHMHKFPJJIN filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "8")]
		public override void AOEHIAAJNNJ(EFDDNENJJHG registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x612C8C0", Offset = "0x612BCC0", VA = "0x18612C8C0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class OKBDOPEHHCI : ODCBMINKJGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class FKBIMBBMBCA : IEnumerable<FNJOAHFIGDA>, IEnumerable, IEnumerator<FNJOAHFIGDA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private FNJOAHFIGDA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private IAKELPIHEBB localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public IAKELPIHEBB <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public OKBDOPEHHCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private OJNADOFGOHF <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private INJPIJDHMDL.JGFBGEPFNNM <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private FNJOAHFIGDA System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x818520", Offset = "0x817920", VA = "0x180818520")]
		[DebuggerHidden]
		public FKBIMBBMBCA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6119070", Offset = "0x6118470", VA = "0x186119070", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6118BB0", Offset = "0x6117FB0", VA = "0x186118BB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6118B90", Offset = "0x6117F90", VA = "0x186118B90")]
		private void CLBCIEJIKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6119020", Offset = "0x6118420", VA = "0x186119020", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6118F70", Offset = "0x6118370", VA = "0x186118F70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FNJOAHFIGDA> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6118F70", Offset = "0x6118370", VA = "0x186118F70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly GFLOJPOFOAD DFBIKANGICJ;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly GFLOJPOFOAD HAODKNHDJJL;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly GFLOJPOFOAD EJBANNNDECC;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly GFLOJPOFOAD NMFPIHPDIPA;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly GFLOJPOFOAD EEKHGEEKPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private JIHDIEIPGCL BFFJEFKLFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private BBIPOKEHNOM KFDGKIEOGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private GHPBPAOBGIP CFKEPMMDAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private MJPJDCPKLOD ACAIKIGINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EMPADGFCLJJ GIJLPAJJMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly DOLMIFPLAGL PHINOHCBOMK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ILIOJLEOEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7CFBA0", Offset = "0x7CEFA0", VA = "0x1807CFBA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7CF580", Offset = "0x7CE980", VA = "0x1807CF580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<FNJOAHFIGDA, FNJOAHFIGDA> GGPOKOICMNE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6128D10", Offset = "0x6128110", VA = "0x186128D10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x612BEA0", Offset = "0x612B2A0", VA = "0x18612BEA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<FNJOAHFIGDA, FNJOAHFIGDA> AOIPDHEFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x612A930", Offset = "0x6129D30", VA = "0x18612A930", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6128F50", Offset = "0x6128350", VA = "0x186128F50", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<FNJOAHFIGDA, FNJOAHFIGDA, FNJOAHFIGDA> BMIBPNKLAPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x612AAE0", Offset = "0x6129EE0", VA = "0x18612AAE0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x612B0F0", Offset = "0x612A4F0", VA = "0x18612B0F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x612C150", Offset = "0x612B550", VA = "0x18612C150")]
	public OKBDOPEHHCI(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6128280", Offset = "0x6127680", VA = "0x186128280", Slot = "11")]
	public void EOPEJCOCBHD(GameObject LMKHHJAKBGC, KOAONJIGJJD CEECJBAJFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6127E90", Offset = "0x6127290", VA = "0x186127E90", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x611D990", Offset = "0x611CD90", VA = "0x18611D990", Slot = "21")]
	public bool ILNJEDGAICA(OCMPEAPAOIJ NCELHEHEEBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x61284F0", Offset = "0x61278F0", VA = "0x1861284F0")]
	private void FKFGEJIDCNJ(IAKELPIHEBB JNPAMFDGPBM, IAKELPIHEBB FDDDFMKFCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6129DF0", Offset = "0x61291F0", VA = "0x186129DF0")]
	private void KAGHBCDAIDO(IAKELPIHEBB JNPAMFDGPBM, IAKELPIHEBB JENJBBHDABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x612AB90", Offset = "0x6129F90", VA = "0x18612AB90")]
	private void MLBCOHPFPBA(IAKELPIHEBB JNPAMFDGPBM, IAKELPIHEBB JENJBBHDABA, IAKELPIHEBB FDDDFMKFCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6129480", Offset = "0x6128880", VA = "0x186129480")]
	private void JIPMOLGMJCN(IAKELPIHEBB JNPAMFDGPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "12")]
	public void LLBOFPOPBEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6128870", Offset = "0x6127C70", VA = "0x186128870", Slot = "13")]
	public void GPKLHHLKJHO(FNJOAHFIGDA EAECAIAEJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "14")]
	public void NHGOOEJBGFG(FNJOAHFIGDA EAECAIAEJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x612BD40", Offset = "0x612B140", VA = "0x18612BD40", Slot = "16")]
	public void OGGEGHPNLEK(FNJOAHFIGDA EAECAIAEJFE, FNJOAHFIGDA IDEJJMEMDDN, Vector3 LNCPBJIHNOH, Quaternion IAAIIIKHBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x612BC00", Offset = "0x612B000", VA = "0x18612BC00")]
	public void OGGEGHPNLEK(IAKELPIHEBB FGOLIAHPGNN, IAKELPIHEBB IDEJJMEMDDN, Vector3 LNCPBJIHNOH, Quaternion IAAIIIKHBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x612BF50", Offset = "0x612B350", VA = "0x18612BF50")]
	public void PMNAMENNJOL(FNJOAHFIGDA EAECAIAEJFE, float ABFKJDMBAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x612A650", Offset = "0x6129A50", VA = "0x18612A650", Slot = "17")]
	public void LLDGEFGPCPN(FNJOAHFIGDA EJBPBFPOLGF, int FHIPEJGIFEN, FNJOAHFIGDA NGOCMNDKFBG, int KIPBPJDEDAC, Vector3 LNCPBJIHNOH, Quaternion IAAIIIKHBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6127D80", Offset = "0x6127180", VA = "0x186127D80")]
	private float DCGGPGPBEMB(IAKELPIHEBB FGOLIAHPGNN, IAKELPIHEBB NCGFJMKBOIN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x612A7A0", Offset = "0x6129BA0", VA = "0x18612A7A0")]
	public void LLDGEFGPCPN(IAKELPIHEBB FGOLIAHPGNN, IAKELPIHEBB NCGFJMKBOIN, Vector3 LNCPBJIHNOH, Quaternion IAAIIIKHBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x612A8D0", Offset = "0x6129CD0", VA = "0x18612A8D0")]
	public void LLDGEFGPCPN(IAKELPIHEBB FGOLIAHPGNN, IAKELPIHEBB NCGFJMKBOIN, Vector3 LNCPBJIHNOH, Quaternion IAAIIIKHBBN, float ABFKJDMBAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6128700", Offset = "0x6127B00", VA = "0x186128700", Slot = "18")]
	public void GGBLFPALBKG(FNJOAHFIGDA EAECAIAEJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6127AF0", Offset = "0x6126EF0", VA = "0x186127AF0")]
	public bool CMOGKCLJGLI(IAKELPIHEBB KIPEPOENGME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x612B310", Offset = "0x612A710", VA = "0x18612B310", Slot = "15")]
	public void NMHCHIMBNON(FNJOAHFIGDA EAECAIAEJFE, HashSet<FNJOAHFIGDA> GBCMMNCOOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "19")]
	public JGJPKKIFJJF BHMNONAONKC(bool CANPDMMBKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "20")]
	public JGJPKKIFJJF IPGJBOKOOMB(HashSet<Guid> IEGDFIJMHHP, bool CANPDMMBKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6128080", Offset = "0x6127480", VA = "0x186128080", Slot = "22")]
	public void EABABKJKGDJ(JGJPKKIFJJF EHDPMADBCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x612A9E0", Offset = "0x6129DE0", VA = "0x18612A9E0", Slot = "23")]
	public void MELJCHGCFJI(JGJPKKIFJJF EHDPMADBCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6127A60", Offset = "0x6126E60", VA = "0x186127A60", Slot = "24")]
	public void AEDIPPLEBOK(JGJPKKIFJJF EHDPMADBCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x612A2F0", Offset = "0x61296F0", VA = "0x18612A2F0")]
	private void LGFFEENMMNM(IAKELPIHEBB FGOLIAHPGNN, IAKELPIHEBB NCGFJMKBOIN, Vector3 LNCPBJIHNOH, Quaternion IAAIIIKHBBN, float ABFKJDMBAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x61299E0", Offset = "0x6128DE0", VA = "0x1861299E0")]
	private void JNMHGNMCFPD(IAKELPIHEBB FGOLIAHPGNN, IAKELPIHEBB FANLJCAEFCA, Vector3 LNCPBJIHNOH, Quaternion IAAIIIKHBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6127A80", Offset = "0x6126E80", VA = "0x186127A80")]
	private void CFOMACPKECN(IAKELPIHEBB FGOLIAHPGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x612AA50", Offset = "0x6129E50", VA = "0x18612AA50")]
	[IteratorStateMachine(typeof(FKBIMBBMBCA))]
	public IEnumerable<FNJOAHFIGDA> MICCMMIFDFK(IAKELPIHEBB KIPEPOENGME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6129340", Offset = "0x6128740", VA = "0x186129340")]
	internal FNJOAHFIGDA JFNFIGCOCDE(IAKELPIHEBB KIPEPOENGME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6129910", Offset = "0x6128D10", VA = "0x186129910")]
	internal IAKELPIHEBB JLHLBBNIFML(FNJOAHFIGDA EAECAIAEJFE)
	{
		return default(IAKELPIHEBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x612B520", Offset = "0x612A920", VA = "0x18612B520")]
	private bool OEGPKPGHKAD(OCMPEAPAOIJ NCELHEHEEBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6127E30", Offset = "0x6127230", VA = "0x186127E30")]
	private bool DDDAFIOLLGJ(OCMPEAPAOIJ NCELHEHEEBE, [Out] FNJOAHFIGDA NCGFJMKBOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6129000", Offset = "0x6128400", VA = "0x186129000")]
	private FNJOAHFIGDA JFNFIGCOCDE(OCMPEAPAOIJ NCELHEHEEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6128DC0", Offset = "0x61281C0", VA = "0x186128DC0")]
	private FNJOAHFIGDA JDNADAHEPHM(OCMPEAPAOIJ NCELHEHEEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x612B1A0", Offset = "0x612A5A0", VA = "0x18612B1A0")]
	private FNJOAHFIGDA NGKNNJDFGAJ(OCMPEAPAOIJ NCELHEHEEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6119A20", Offset = "0x6118E20", VA = "0x186119A20")]
	private static Guid FGMLAABHGKK(OCMPEAPAOIJ NCELHEHEEBE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x612A1A0", Offset = "0x61295A0", VA = "0x18612A1A0")]
	private string KGOPBLIEHDH(OCMPEAPAOIJ NCELHEHEEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x61280F0", Offset = "0x61274F0", VA = "0x1861280F0")]
	private void EKGJFFIBLBI(FNJOAHFIGDA FGOLIAHPGNN, FNJOAHFIGDA FANLJCAEFCA, RigidTransform PFAOGHPPNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x612A010", Offset = "0x6129410", VA = "0x18612A010")]
	private void KDCEBCFHCAP(FNJOAHFIGDA FANLJCAEFCA, FNJOAHFIGDA FGOLIAHPGNN, RigidTransform PFAOGHPPNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x612A290", Offset = "0x6129690", VA = "0x18612A290")]
	private void LAAGHJJGDKN(FNJOAHFIGDA OKCAGOMMBIA, FNJOAHFIGDA FGOLIAHPGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6128B80", Offset = "0x6127F80", VA = "0x186128B80")]
	private void HEAEBHIKAON(FNJOAHFIGDA FGOLIAHPGNN, FNJOAHFIGDA NCGFJMKBOIN, RigidTransform PFAOGHPPNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x612BAF0", Offset = "0x612AEF0", VA = "0x18612BAF0")]
	private void OFEAJKNPJKK(IAKELPIHEBB KIPEPOENGME, FNJOAHFIGDA EAECAIAEJFE, IAKELPIHEBB JENJBBHDABA, IAKELPIHEBB FDDDFMKFCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x612AE10", Offset = "0x612A210", VA = "0x18612AE10")]
	private void NBMJDAPNIFJ(IAKELPIHEBB KIPEPOENGME, FNJOAHFIGDA EAECAIAEJFE, FNJOAHFIGDA ICHKEMENIOO, FNJOAHFIGDA EDCMCCHKNKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DECNLOJGBNA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class LFAGDLBGIDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public BNDLKDEPBDF container;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public LFAGDLBGIDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x611F7E0", Offset = "0x611EBE0", VA = "0x18611F7E0")]
		internal OKBDOPEHHCI PJHFLAFJHJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6116BF0", Offset = "0x6115FF0", VA = "0x186116BF0")]
	public static void PNMGFGOHHNN(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6116BA0", Offset = "0x6115FA0", VA = "0x186116BA0")]
	public static void LJBDEKPOKKC(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class FIAJOPHGFAO : JCLKGGLGLEK, GGFOMEBPHBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly RigidbodyEx GEGOPKKJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly OKBDOPEHHCI CKBHOLFCNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HPMBGCCLGLM PGAMENOFDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly OGCAKEKEENH ACAIKIGINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly AGHFKKCBIOD[] DHJNDOCCBGD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IAKELPIHEBB GJKJKLOPDBP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(IAKELPIHEBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FNJOAHFIGDA OKNKPCLMJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6118960", Offset = "0x6117D60", VA = "0x186118960", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FNJOAHFIGDA CEPFFFANEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x61171B0", Offset = "0x61165B0", VA = "0x1861171B0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 COKCMNNGACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6117C50", Offset = "0x6117050", VA = "0x186117C50", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Quaternion JOJJBOOHADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6117420", Offset = "0x6116820", VA = "0x186117420", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool HOCHNNJHJEF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6118700", Offset = "0x6117B00", VA = "0x186118700", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IEnumerable<FNJOAHFIGDA> NNDOGDDJEBF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x61178F0", Offset = "0x6116CF0", VA = "0x1861178F0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Obsolete]
	public bool KNHHELDDLDK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x8835C0", VA = "0x1808841C0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8842E0", Offset = "0x8836E0", VA = "0x1808842E0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Transform DHEPKMFHJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6118B70", Offset = "0x6117F70", VA = "0x186118B70", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public GameObject IDFBDNNIJMO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x229B7B0", Offset = "0x229ABB0", VA = "0x18229B7B0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string CGOKMMHCJIB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6118890", Offset = "0x6117C90", VA = "0x186118890", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid GEHNNGHGGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x61189C0", Offset = "0x6117DC0", VA = "0x1861189C0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int GCPKBHABOMB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6118AA0", Offset = "0x6117EA0", VA = "0x186118AA0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool LPPNIHPPNAF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private bool BGNCBLBDCFF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6116F20", Offset = "0x6116320", VA = "0x186116F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event NHIPNIKKLEB IMLCNPMPOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6116F70", Offset = "0x6116370", VA = "0x186116F70", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6116FD0", Offset = "0x61163D0", VA = "0x186116FD0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event NHIPNIKKLEB AMGOLBMCFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6116E60", Offset = "0x6116260", VA = "0x186116E60", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6117030", Offset = "0x6116430", VA = "0x186117030", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event NHIPNIKKLEB ACFDKCAJLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6116EC0", Offset = "0x61162C0", VA = "0x186116EC0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6117480", Offset = "0x6116880", VA = "0x186117480", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event HGFGODFMLEG LEBFIJLJHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6118660", Offset = "0x6117A60", VA = "0x186118660", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x61185C0", Offset = "0x61179C0", VA = "0x1861185C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6118790", Offset = "0x6117B90", VA = "0x186118790")]
	public FIAJOPHGFAO(IAKELPIHEBB DNDHIPHFOEE, RigidbodyEx GEGOPKKJAFB, HPMBGCCLGLM PGAMENOFDNG, AGHFKKCBIOD[] DHJNDOCCBGD, OGCAKEKEENH ACAIKIGINDM, ODCBMINKJGA CKBHOLFCNMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6117130", Offset = "0x6116530", VA = "0x186117130", Slot = "19")]
	public void DDKMMINMGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "21")]
	public void AHEJODPFBFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A7A0", Offset = "0x5F99BA0", VA = "0x185F9A7A0", Slot = "22")]
	public void EGPJFGBFMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6118360", Offset = "0x6117760", VA = "0x186118360", Slot = "20")]
	public void OEBPOHMGJLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x61183B0", Offset = "0x61177B0", VA = "0x1861183B0", Slot = "25")]
	public void ONCMCBHMLPP(int CPIHNPIPBCA, FNJOAHFIGDA NGOCMNDKFBG, int FMEDCEFGKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6118290", Offset = "0x6117690", VA = "0x186118290", Slot = "26")]
	public void LJKIALAFCJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6117970", Offset = "0x6116D70", VA = "0x186117970", Slot = "27")]
	public void JIAOIJBMEMF(int CPIHNPIPBCA, FNJOAHFIGDA EJBPBFPOLGF, int LJPJPKAOCFI, [Optional] Vector3? HIIINJCHIGN, [Optional] Quaternion? DBABBCPBBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6117CB0", Offset = "0x61170B0", VA = "0x186117CB0", Slot = "28")]
	public void JMHLGFNGMDA(FNJOAHFIGDA EJBPBFPOLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x61174E0", Offset = "0x61168E0", VA = "0x1861174E0", Slot = "31")]
	public void IHNDEBENMGG(Vector3 IBEDLKDEBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6117F80", Offset = "0x6117380", VA = "0x186117F80", Slot = "29")]
	public void LJJKIGDIDNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6117D80", Offset = "0x6117180", VA = "0x186117D80", Slot = "30")]
	public void KNICJFMNMGM(int PMLKPJNGBAD, Vector3 OCAHEBEILLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6117350", Offset = "0x6116750", VA = "0x186117350", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int CPIHNPIPBCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6117220", Offset = "0x6116620", VA = "0x186117220", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int CPIHNPIPBCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x846550", Offset = "0x845950", VA = "0x180846550", Slot = "42")]
	public Color GetConnectionSlotColor(int CPIHNPIPBCA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6117090", Offset = "0x6116490", VA = "0x186117090", Slot = "43")]
	public bool CanConnectTo(int CPIHNPIPBCA, FNJOAHFIGDA DCEGDCOLDEM, int CMOMGOEJMKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "44")]
	public void ParentChanged(int CPIHNPIPBCA, FNJOAHFIGDA ECNHNEPKLEF, int EPEKBCDAPKE, Vector3 NJIEOAKEPLG, Quaternion FGAAEOLKHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "45")]
	public void ChildAdded(int CPIHNPIPBCA, FNJOAHFIGDA JMJHEBDICGH, int CIIJEKDDOBI, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "46")]
	public void ChildRemoved(int CPIHNPIPBCA, FNJOAHFIGDA INKNBFNCMHF, int OOKODLDPEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "47")]
	public void ConnectionModified(int CPIHNPIPBCA, FNJOAHFIGDA NGOCMNDKFBG, int FMEDCEFGKIE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6118770", Offset = "0x6117B70", VA = "0x186118770", Slot = "48")]
	public void RootChanged(FNJOAHFIGDA NBOEDHDBAMC, FNJOAHFIGDA NAHHFFNJOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6117920", Offset = "0x6116D20", VA = "0x186117920", Slot = "23")]
	public void JBOKCJGCPIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6117160", Offset = "0x6116560", VA = "0x186117160", Slot = "24")]
	public void GJOJKCHOAEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6117D30", Offset = "0x6117130", VA = "0x186117D30")]
	private void KHNHABGDJOE(bool DENGGGEJOLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[JGOEIFPBJFO(typeof(JAFAPKOKJCP), new string[] { })]
public class JKIFKOFJJAP : JAFAPKOKJCP, KJACJMOCMBM
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class EGONICDOEMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public JKIFKOFJJAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public INJPIJDHMDL localIds;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public EGONICDOEMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6116D70", Offset = "0x6116170", VA = "0x186116D70")]
		internal void JIHIFNGGNKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly GFLOJPOFOAD DFBIKANGICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[LGIDMEDGIGK]
	private JFIEIJFNPEB BMLHPAOBBJJ;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public object MGGJEOIOLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x611EBA0", Offset = "0x611DFA0", VA = "0x18611EBA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x611EB50", Offset = "0x611DF50", VA = "0x18611EB50", Slot = "6")]
	public void InitReferences(IMFGMFPAOFH PHINOHCBOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x611E9E0", Offset = "0x611DDE0", VA = "0x18611E9E0", Slot = "5")]
	public void FOGBFOMOKLM(INJPIJDHMDL BPDOOMHKDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public JKIFKOFJJAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[JGOEIFPBJFO(typeof(ODCBMINKJGA), new string[] { "Ignore", "Mock" })]
public class AHGNAIOCHPN : ODCBMINKJGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool ILIOJLEOEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<FNJOAHFIGDA, FNJOAHFIGDA> GGPOKOICMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6115A20", Offset = "0x6114E20", VA = "0x186115A20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6115D90", Offset = "0x6115190", VA = "0x186115D90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<FNJOAHFIGDA, FNJOAHFIGDA> AOIPDHEFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6115B80", Offset = "0x6114F80", VA = "0x186115B80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6115AD0", Offset = "0x6114ED0", VA = "0x186115AD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<FNJOAHFIGDA, FNJOAHFIGDA, FNJOAHFIGDA> BMIBPNKLAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6115C30", Offset = "0x6115030", VA = "0x186115C30", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6115CE0", Offset = "0x61150E0", VA = "0x186115CE0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "11")]
	public void EOPEJCOCBHD(GameObject LMKHHJAKBGC, KOAONJIGJJD CEECJBAJFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "12")]
	public void LLBOFPOPBEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "13")]
	public void GPKLHHLKJHO(FNJOAHFIGDA EAECAIAEJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "14")]
	public void NHGOOEJBGFG(FNJOAHFIGDA EAECAIAEJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "15")]
	public void NMHCHIMBNON(FNJOAHFIGDA EAECAIAEJFE, HashSet<FNJOAHFIGDA> GBCMMNCOOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "16")]
	public void OGGEGHPNLEK(FNJOAHFIGDA EAECAIAEJFE, FNJOAHFIGDA IDEJJMEMDDN, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "17")]
	public void LLDGEFGPCPN(FNJOAHFIGDA EAECAIAEJFE, int IICIOKJAHGL, FNJOAHFIGDA FANLJCAEFCA, int EPEKBCDAPKE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "18")]
	public void GGBLFPALBKG(FNJOAHFIGDA EAECAIAEJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "19")]
	public JGJPKKIFJJF BHMNONAONKC(bool CANPDMMBKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "20")]
	public JGJPKKIFJJF IPGJBOKOOMB(HashSet<Guid> IEGDFIJMHHP, bool CANPDMMBKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "21")]
	public bool ILNJEDGAICA(OCMPEAPAOIJ NCELHEHEEBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "22")]
	public void EABABKJKGDJ(JGJPKKIFJJF EHDPMADBCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "23")]
	public void MELJCHGCFJI(JGJPKKIFJJF EHDPMADBCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "24")]
	public void AEDIPPLEBOK(JGJPKKIFJJF EHDPMADBCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public AHGNAIOCHPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FNJOAHFIGDA : GGFOMEBPHBF, IEquatable<FNJOAHFIGDA>
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GGFOMEBPHBF
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	FNJOAHFIGDA OKNKPCLMJCO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform DHEPKMFHJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	GameObject IDFBDNNIJMO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string CGOKMMHCJIB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Guid GEHNNGHGGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	int GCPKBHABOMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	IAKELPIHEBB GJKJKLOPDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool LPPNIHPPNAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int CPIHNPIPBCA);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int CPIHNPIPBCA);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int CPIHNPIPBCA);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int CPIHNPIPBCA, FNJOAHFIGDA DCEGDCOLDEM, int HPKPOFINMAA);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int CPIHNPIPBCA, FNJOAHFIGDA ECNHNEPKLEF, int EPEKBCDAPKE, Vector3 NJIEOAKEPLG, Quaternion FGAAEOLKHIF);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int CPIHNPIPBCA, FNJOAHFIGDA JMJHEBDICGH, int CIIJEKDDOBI, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int CPIHNPIPBCA, FNJOAHFIGDA INKNBFNCMHF, int OOKODLDPEJO);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int CPIHNPIPBCA, FNJOAHFIGDA NGOCMNDKFBG, int GJMNGIHFJKN, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(FNJOAHFIGDA NBOEDHDBAMC, FNJOAHFIGDA NAHHFFNJOAP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[LKLFBNCDEJD(AKFEFGLLHIP.OMRoom)]
public interface ODCBMINKJGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool ILIOJLEOEKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<FNJOAHFIGDA, FNJOAHFIGDA> GGPOKOICMNE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<FNJOAHFIGDA, FNJOAHFIGDA> AOIPDHEFFFA;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<FNJOAHFIGDA, FNJOAHFIGDA, FNJOAHFIGDA> BMIBPNKLAPO;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EOPEJCOCBHD(GameObject LMKHHJAKBGC, KOAONJIGJJD CEECJBAJFDK);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LLBOFPOPBEE();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GPKLHHLKJHO(FNJOAHFIGDA EAECAIAEJFE);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NHGOOEJBGFG(FNJOAHFIGDA EAECAIAEJFE);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NMHCHIMBNON(FNJOAHFIGDA EAECAIAEJFE, HashSet<FNJOAHFIGDA> GBCMMNCOOCM);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OGGEGHPNLEK(FNJOAHFIGDA EAECAIAEJFE, FNJOAHFIGDA IDEJJMEMDDN, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LLDGEFGPCPN(FNJOAHFIGDA EAECAIAEJFE, int IICIOKJAHGL, FNJOAHFIGDA FANLJCAEFCA, int EPEKBCDAPKE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GGBLFPALBKG(FNJOAHFIGDA EAECAIAEJFE);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JGJPKKIFJJF BHMNONAONKC(bool CANPDMMBKPN);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	JGJPKKIFJJF IPGJBOKOOMB(HashSet<Guid> IEGDFIJMHHP, bool CANPDMMBKPN);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool ILNJEDGAICA(OCMPEAPAOIJ NCELHEHEEBE);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EABABKJKGDJ(JGJPKKIFJJF EHDPMADBCLO);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MELJCHGCFJI(JGJPKKIFJJF EHDPMADBCLO);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void AEDIPPLEBOK(JGJPKKIFJJF EHDPMADBCLO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MJPJDCPKLOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool HJDGMNKJCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FNJOAHFIGDA NGKNNJDFGAJ(int HDBMLMBMDGE);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FNJOAHFIGDA JDNADAHEPHM(Guid POFKIHNGHFE);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KHBAJEGJALK(FNJOAHFIGDA EAECAIAEJFE);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AEAFBGHJFAF();

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FFAFJCKHMGN(FNJOAHFIGDA PGAMENOFDNG);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[LKLFBNCDEJD(AKFEFGLLHIP.Application)]
public interface OGCAKEKEENH
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGNCBLBDCFF(HPMBGCCLGLM PGAMENOFDNG);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FELEPIBPLCI(HPMBGCCLGLM PGAMENOFDNG);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string CBMPFCPNGNG(HPMBGCCLGLM PGAMENOFDNG);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid BPEBDHGNIBE(HPMBGCCLGLM PGAMENOFDNG);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int JMENNIMDJDH(HPMBGCCLGLM PGAMENOFDNG);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LAEFOMMGNOP(HPMBGCCLGLM PGAMENOFDNG);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate void NHIPNIKKLEB(FNJOAHFIGDA EJBPBFPOLGF, int FJPIMBGJICB, FNJOAHFIGDA NGOCMNDKFBG, int IBPJJKIFHBD, [Optional] Vector3? HIIINJCHIGN, [Optional] Quaternion? DBABBCPBBJB);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void HGFGODFMLEG(FNJOAHFIGDA NBOEDHDBAMC, FNJOAHFIGDA NAHHFFNJOAP);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HPMBGCCLGLM : FNJOAHFIGDA, GGFOMEBPHBF, IEquatable<FNJOAHFIGDA>
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JCLKGGLGLEK : GGFOMEBPHBF
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	FNJOAHFIGDA CEPFFFANEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	IEnumerable<FNJOAHFIGDA> NNDOGDDJEBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Vector3 COKCMNNGACK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	Quaternion JOJJBOOHADO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool HOCHNNJHJEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool KNHHELDDLDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event NHIPNIKKLEB IMLCNPMPOKO;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event NHIPNIKKLEB AMGOLBMCFLG;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event NHIPNIKKLEB ACFDKCAJLFC;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event HGFGODFMLEG LEBFIJLJHCG;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DDKMMINMGFL();

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OEBPOHMGJLL();

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AHEJODPFBFD();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EGPJFGBFMFE();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JBOKCJGCPIH();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GJOJKCHOAEA();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ONCMCBHMLPP(int CPIHNPIPBCA, FNJOAHFIGDA NGOCMNDKFBG, int FMEDCEFGKIE);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LJKIALAFCJE();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void JIAOIJBMEMF(int CPIHNPIPBCA, FNJOAHFIGDA EJBPBFPOLGF, int LJPJPKAOCFI, [Optional] Vector3? HIIINJCHIGN, [Optional] Quaternion? DBABBCPBBJB);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JMHLGFNGMDA(FNJOAHFIGDA EJBPBFPOLGF);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void LJJKIGDIDNM();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void KNICJFMNMGM(int PMLKPJNGBAD, Vector3 OCAHEBEILLK);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void IHNDEBENMGG(Vector3 IBEDLKDEBAL);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface AGHFKKCBIOD
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Vector3 ENPHBJOHAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KOAONJIGJJD
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool ILGFLLDAKNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	DPFFGAGNJIB FLJIGJCFHJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ConnectableConfigData : ScriptableObject, KOAONJIGJJD
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		[FormerlySerializedAs("linkVisualPrefab")]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x827D00", Offset = "0x827100", VA = "0x180827D00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public DPFFGAGNJIB LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6116AA0", Offset = "0x6115EA0", VA = "0x186116AA0")]
		public static ConnectableConfigData IGLJEFADHAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6116B50", Offset = "0x6115F50", VA = "0x186116B50")]
		public ConnectableConfigData(LegacyConnectableLinkVisual KLLOPANPCKL, bool PKPBPKOMLPP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct HMMBJJIFLJG : IEquatable<HMMBJJIFLJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public FNJOAHFIGDA EAECAIAEJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int KOJHDAJAEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int GJMNGIHFJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Vector3 HIIINJCHIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Quaternion DBABBCPBBJB;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x611C880", Offset = "0x611BC80", VA = "0x18611C880")]
	public HMMBJJIFLJG(FNJOAHFIGDA EAECAIAEJFE, int KOJHDAJAEFK, int GJMNGIHFJKN, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x611C8E0", Offset = "0x611BCE0", VA = "0x18611C8E0")]
	public HMMBJJIFLJG(FNJOAHFIGDA EAECAIAEJFE, int KOJHDAJAEFK, int GJMNGIHFJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x611C7F0", Offset = "0x611BBF0", VA = "0x18611C7F0")]
	public HMMBJJIFLJG(FNJOAHFIGDA EAECAIAEJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x611C380", Offset = "0x611B780", VA = "0x18611C380", Slot = "4")]
	public bool Equals(HMMBJJIFLJG MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x611C430", Offset = "0x611B830", VA = "0x18611C430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[UnityEngine.Scripting.Preserve]
public class KDMOAGFDHBL : NJADPHJOCMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Transform KDNNBEIJOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private DPFFGAGNJIB GGJFBLCEPJL;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5C3C140", Offset = "0x5C3B540", VA = "0x185C3C140", Slot = "4")]
	public void EOPEJCOCBHD(Transform KDNNBEIJOEO, DPFFGAGNJIB GGJFBLCEPJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x611EE30", Offset = "0x611E230", VA = "0x18611EE30", Slot = "5")]
	public DPFFGAGNJIB LPBFIIMMCMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x611EDE0", Offset = "0x611E1E0", VA = "0x18611EDE0", Slot = "6")]
	public void IDELKDJHCPK(DPFFGAGNJIB GNGKCOBFFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public KDMOAGFDHBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal class MJKKMCIMABH : IDisposable, ODMOJDNCEJK
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class HIJLDHIFNJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public FNJOAHFIGDA oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public FNJOAHFIGDA newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public HIJLDHIFNJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x611C2C0", Offset = "0x611B6C0", VA = "0x18611C2C0")]
		internal bool OLCPAPNGHJC(DGOMBPPDKHO node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly OENOONMKLAC PLELOGIEFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private ADPAEJLPELH NFJCHKBBCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private HBIGOHFOHDH PPBCLHOGJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool PKPBPKOMLPP;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public DGOMBPPDKHO DHEBBLCLMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6124B90", Offset = "0x6123F90", VA = "0x186124B90")]
	public bool KHIHMJGIIJL([In] KAAHNDPMAFD FLKOGFDGJDF, bool FOIMKLKODHB = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6123BF0", Offset = "0x6122FF0", VA = "0x186123BF0")]
	private bool HDPBKOEFKPN([In] KAAHNDPMAFD FLKOGFDGJDF, bool FOIMKLKODHB = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6126530", Offset = "0x6125930", VA = "0x186126530")]
	public MJKKMCIMABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6123300", Offset = "0x6122700", VA = "0x186123300", Slot = "5")]
	public void EOPEJCOCBHD(ODCBMINKJGA BJMBJJIMGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6126100", Offset = "0x6125500", VA = "0x186126100", Slot = "17")]
	public void OHLNHECKMMF(LLLKDMGHMAD KCNCNEMPBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6123680", Offset = "0x6122A80", VA = "0x186123680", Slot = "12")]
	public void FKIFOFKNNOP(Func<FNJOAHFIGDA, bool> GBMNHNNBKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6123390", Offset = "0x6122790", VA = "0x186123390")]
	private void FKIFOFKNNOP(OENOONMKLAC HBIAHPFPLFB, Func<FNJOAHFIGDA, bool> GBMNHNNBKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6126130", Offset = "0x6125530", VA = "0x186126130", Slot = "11")]
	public void OICKDLJOBLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6126360", Offset = "0x6125760", VA = "0x186126360", Slot = "8")]
	public bool PEJEBFNBDHJ(FNJOAHFIGDA GEDPCEKKFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6121A20", Offset = "0x6120E20", VA = "0x186121A20")]
	private bool AFLCELOADBG(FNJOAHFIGDA KHHPCKCHIJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6124790", Offset = "0x6123B90", VA = "0x186124790")]
	private static bool IGMICIJMGFD(FNJOAHFIGDA KHHPCKCHIJO, OENOONMKLAC HCLFEHNCGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6122680", Offset = "0x6121A80", VA = "0x186122680")]
	private void CBHNCOOGOBP(Transform FDIBMAMHBHB, OENOONMKLAC DHHAECKMGHB, OENOONMKLAC[] JCEKJNLCGIC, FNJOAHFIGDA MAEJCCLMHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x61218D0", Offset = "0x6120CD0", VA = "0x1861218D0")]
	private HMMBJJIFLJG AAMECMLAHAP(Transform JLKBKODIMON, HMMBJJIFLJG HDEDKOGNBME)
	{
		return default(HMMBJJIFLJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x61248B0", Offset = "0x6123CB0", VA = "0x1861248B0")]
	private static bool KAKNIEDCCEJ(OENOONMKLAC HCLFEHNCGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6122A70", Offset = "0x6121E70", VA = "0x186122A70")]
	private string CBMPFCPNGNG(FNJOAHFIGDA EAECAIAEJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6124840", Offset = "0x6123C40", VA = "0x186124840")]
	private string JMENNIMDJDH(FNJOAHFIGDA EAECAIAEJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x61250B0", Offset = "0x61244B0", VA = "0x1861250B0")]
	private void MFBMICCJCHN([In] KAAHNDPMAFD FLKOGFDGJDF, bool DLEFFDAKKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6125D00", Offset = "0x6125100", VA = "0x186125D00")]
	private void OEMNHJCJOOA(FNJOAHFIGDA FGOLIAHPGNN, bool DLEFFDAKKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x61241C0", Offset = "0x61235C0", VA = "0x1861241C0")]
	private void HLOBLKKFLIK(FNJOAHFIGDA MILJDCBPPOJ, int LJPJPKAOCFI, FNJOAHFIGDA FANLJCAEFCA, int FMEDCEFGKIE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB, bool DLEFFDAKKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6122BE0", Offset = "0x6121FE0", VA = "0x186122BE0")]
	private void DJHJAMPDNPI(FNJOAHFIGDA NKKBHFKAFMF, int LJPJPKAOCFI, int FMEDCEFGKIE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB, bool KHJCLKMEAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6126150", Offset = "0x6125550", VA = "0x186126150", Slot = "9")]
	public bool OJEDJFNGCCG(FNJOAHFIGDA NKKBHFKAFMF, int LJPJPKAOCFI, int FMEDCEFGKIE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6125ED0", Offset = "0x61252D0", VA = "0x186125ED0")]
	private bool OGGAOLOHBAE(FNJOAHFIGDA NKKBHFKAFMF, int LJPJPKAOCFI, int FMEDCEFGKIE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6123760", Offset = "0x6122B60", VA = "0x186123760")]
	private static void GLNAAMNCJBO(FNJOAHFIGDA NKKBHFKAFMF, int LJPJPKAOCFI, int FMEDCEFGKIE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB, OENOONMKLAC HNNKICAFJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x61231E0", Offset = "0x61225E0", VA = "0x1861231E0")]
	private void EKGJFFIBLBI(FNJOAHFIGDA MILJDCBPPOJ, int IICIOKJAHGL, FNJOAHFIGDA FANLJCAEFCA, int EPEKBCDAPKE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6124BE0", Offset = "0x6123FE0", VA = "0x186124BE0")]
	private void KKBLFLIKNEE(OENOONMKLAC HBIAHPFPLFB, FNJOAHFIGDA ICHKEMENIOO, FNJOAHFIGDA EDCMCCHKNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6124C50", Offset = "0x6124050", VA = "0x186124C50")]
	private void KKBLFLIKNEE(FNJOAHFIGDA EAECAIAEJFE, FNJOAHFIGDA ICHKEMENIOO, FNJOAHFIGDA EDCMCCHKNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x61257D0", Offset = "0x6124BD0", VA = "0x1861257D0")]
	private void NBMJDAPNIFJ(FNJOAHFIGDA EAECAIAEJFE, FNJOAHFIGDA ICHKEMENIOO, FNJOAHFIGDA EDCMCCHKNKP, bool NPKABOPCNOL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x61256D0", Offset = "0x6124AD0", VA = "0x1861256D0")]
	private void NBMJDAPNIFJ(OENOONMKLAC BEOJJJNJFFJ, FNJOAHFIGDA MAEJCCLMHII, FNJOAHFIGDA NAHHFFNJOAP, bool NPKABOPCNOL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6124A70", Offset = "0x6123E70", VA = "0x186124A70")]
	private void KDCEBCFHCAP(FNJOAHFIGDA FGOLIAHPGNN, int LJPJPKAOCFI, FNJOAHFIGDA FANLJCAEFCA, int EPEKBCDAPKE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6124CC0", Offset = "0x61240C0", VA = "0x186124CC0")]
	private void LAAGHJJGDKN(DGOMBPPDKHO NCGFJMKBOIN, DGOMBPPDKHO NLDJAJADOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6124F10", Offset = "0x6124310", VA = "0x186124F10", Slot = "18")]
	public FNJOAHFIGDA LKOPPDHPMGB(FNJOAHFIGDA EAECAIAEJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6125840", Offset = "0x6124C40", VA = "0x186125840", Slot = "13")]
	public void NMHCHIMBNON(FNJOAHFIGDA EAECAIAEJFE, HashSet<FNJOAHFIGDA> LJAFPEKDEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x61238E0", Offset = "0x6122CE0", VA = "0x1861238E0", Slot = "14")]
	public List<FNJOAHFIGDA> GNJPDPHGMCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6123690", Offset = "0x6122A90", VA = "0x186123690")]
	protected DGOMBPPDKHO FKNINMKCAHO(DGOMBPPDKHO HBIAHPFPLFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6122B40", Offset = "0x6121F40", VA = "0x186122B40")]
	protected OENOONMKLAC[] CPIBGFICNAN(OENOONMKLAC HCLFEHNCGNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6125BF0", Offset = "0x6124FF0", VA = "0x186125BF0")]
	protected bool NOHBHEJGGJM(FNJOAHFIGDA EAECAIAEJFE, [Out] OENOONMKLAC HBIAHPFPLFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6126230", Offset = "0x6125630", VA = "0x186126230", Slot = "15")]
	public bool OMDFBLGPCHM(FNJOAHFIGDA EAECAIAEJFE, [Out] HMMBJJIFLJG MECMCHLNOKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6125070", Offset = "0x6124470", VA = "0x186125070")]
	protected OENOONMKLAC LPIHLLLEPKJ(HMMBJJIFLJG GJJFCKPNEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6124E20", Offset = "0x6124220", VA = "0x186124E20", Slot = "10")]
	public bool LEHPIAMKMGB(FNJOAHFIGDA MILJDCBPPOJ, int IICIOKJAHGL, FNJOAHFIGDA FANLJCAEFCA, int EPEKBCDAPKE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x61220F0", Offset = "0x61214F0", VA = "0x1861220F0")]
	private bool ANPPFOPFEPA(FNJOAHFIGDA MILJDCBPPOJ, int IICIOKJAHGL, FNJOAHFIGDA FANLJCAEFCA, int EPEKBCDAPKE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6123B20", Offset = "0x6122F20", VA = "0x186123B20")]
	private static bool HDFKOOLCNNI(OENOONMKLAC FEEPNOCIFDI, HMMBJJIFLJG OHKIKIMKPHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6124B90", Offset = "0x6123F90", VA = "0x186124B90", Slot = "7")]
	private bool MPGKBMONGBK([In] KAAHNDPMAFD FLKOGFDGJDF, bool FOIMKLKODHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[UnityEngine.Scripting.Preserve]
internal class JADPMANMNKI : ODCBMINKJGA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly BNDLKDEPBDF CGBKOFIJCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly HBIGOHFOHDH PPBCLHOGJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly IGNLMFHOMKD FFLIAGGCGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly GPPKBHLNIJA AMFNJGABGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly ODMOJDNCEJK EHDPMADBCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal NILGCFJHOJA ACAIKIGINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal BIKKLBJEPFE HFIBHDFMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal ADPAEJLPELH LBNJLFEHMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal bool PKPBPKOMLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool JDEEMEMFPDB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool MCNBFHACINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x173CFA0", Offset = "0x173C3A0", VA = "0x18173CFA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x173CF90", Offset = "0x173C390", VA = "0x18173CF90")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool ILIOJLEOEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x173CFB0", Offset = "0x173C3B0", VA = "0x18173CFB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x173CF70", Offset = "0x173C370", VA = "0x18173CF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<FNJOAHFIGDA, FNJOAHFIGDA> GGPOKOICMNE
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x611DBA0", Offset = "0x611CFA0", VA = "0x18611DBA0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x611E590", Offset = "0x611D990", VA = "0x18611E590", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<FNJOAHFIGDA, FNJOAHFIGDA> AOIPDHEFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x611E050", Offset = "0x611D450", VA = "0x18611E050", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x611DC00", Offset = "0x611D000", VA = "0x18611DC00", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<FNJOAHFIGDA, FNJOAHFIGDA, FNJOAHFIGDA> BMIBPNKLAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x611E160", Offset = "0x611D560", VA = "0x18611E160", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x611E220", Offset = "0x611D620", VA = "0x18611E220", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x611E5F0", Offset = "0x611D9F0", VA = "0x18611E5F0")]
	public JADPMANMNKI(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x611D110", Offset = "0x611C510", VA = "0x18611D110", Slot = "11")]
	public void EOPEJCOCBHD(GameObject LMKHHJAKBGC, KOAONJIGJJD CEECJBAJFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x611CEA0", Offset = "0x611C2A0", VA = "0x18611CEA0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x611DEC0", Offset = "0x611D2C0", VA = "0x18611DEC0", Slot = "12")]
	public void LLBOFPOPBEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x611D8B0", Offset = "0x611CCB0", VA = "0x18611D8B0", Slot = "13")]
	public void GPKLHHLKJHO(FNJOAHFIGDA EAECAIAEJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x611E1C0", Offset = "0x611D5C0", VA = "0x18611E1C0", Slot = "14")]
	public void NHGOOEJBGFG(FNJOAHFIGDA EAECAIAEJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x611D990", Offset = "0x611CD90", VA = "0x18611D990", Slot = "21")]
	public bool ILNJEDGAICA(OCMPEAPAOIJ NCELHEHEEBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x611D8D0", Offset = "0x611CCD0", VA = "0x18611D8D0")]
	internal bool HDPBKOEFKPN([In] KAAHNDPMAFD FLKOGFDGJDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x611CD90", Offset = "0x611C190", VA = "0x18611CD90")]
	internal bool ANPPFOPFEPA([In] KAAHNDPMAFD FLKOGFDGJDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x611CE20", Offset = "0x611C220", VA = "0x18611CE20")]
	internal bool BEGCBGLEMPH([In] KAAHNDPMAFD FLKOGFDGJDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x611DD70", Offset = "0x611D170", VA = "0x18611DD70")]
	internal bool LGFEGJPHJAJ([In] KAAHNDPMAFD FLKOGFDGJDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x611D9C0", Offset = "0x611CDC0", VA = "0x18611D9C0")]
	internal void JCIMGNLJINJ(FNJOAHFIGDA EAECAIAEJFE, int FNEMEDBPGKI, bool FOIMKLKODHB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x611E1C0", Offset = "0x611D5C0", VA = "0x18611E1C0")]
	internal bool MMLMGCPKMDM(FNJOAHFIGDA MKHNOALGMAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x611CFD0", Offset = "0x611C3D0", VA = "0x18611CFD0")]
	internal bool EAKMHMMICEP(FNJOAHFIGDA NKKBHFKAFMF, int LJPJPKAOCFI, int FMEDCEFGKIE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x611E280", Offset = "0x611D680", VA = "0x18611E280", Slot = "15")]
	public void NMHCHIMBNON(FNJOAHFIGDA EAECAIAEJFE, HashSet<FNJOAHFIGDA> GBCMMNCOOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x611E380", Offset = "0x611D780", VA = "0x18611E380", Slot = "16")]
	public void OGGEGHPNLEK(FNJOAHFIGDA NKKBHFKAFMF, FNJOAHFIGDA IDEJJMEMDDN, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x611DF10", Offset = "0x611D310", VA = "0x18611DF10", Slot = "17")]
	public void LLDGEFGPCPN(FNJOAHFIGDA MILJDCBPPOJ, int IICIOKJAHGL, FNJOAHFIGDA FANLJCAEFCA, int EPEKBCDAPKE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x611D6E0", Offset = "0x611CAE0", VA = "0x18611D6E0", Slot = "18")]
	public void GGBLFPALBKG(FNJOAHFIGDA MILJDCBPPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x611DC60", Offset = "0x611D060", VA = "0x18611DC60")]
	public void LAAHOKIIGGE([Optional] ELBGPJKLPID MFJDHEBELOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x611CF40", Offset = "0x611C340", VA = "0x18611CF40", Slot = "22")]
	public void EABABKJKGDJ(JGJPKKIFJJF EHDPMADBCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x611CE80", Offset = "0x611C280", VA = "0x18611CE80", Slot = "19")]
	public JGJPKKIFJJF BHMNONAONKC(bool CANPDMMBKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x611D9A0", Offset = "0x611CDA0", VA = "0x18611D9A0", Slot = "20")]
	public JGJPKKIFJJF IPGJBOKOOMB(HashSet<Guid> IEGDFIJMHHP, bool CANPDMMBKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x611CD50", Offset = "0x611C150", VA = "0x18611CD50", Slot = "24")]
	public void AEDIPPLEBOK(JGJPKKIFJJF EHDPMADBCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x611E0B0", Offset = "0x611D4B0", VA = "0x18611E0B0", Slot = "23")]
	public void MELJCHGCFJI(JGJPKKIFJJF EHDPMADBCLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class HBIGOHFOHDH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly CNCBMPDPOAH<FNJOAHFIGDA, FNJOAHFIGDA> GGPOKOICMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly CNCBMPDPOAH<FNJOAHFIGDA, FNJOAHFIGDA> AOIPDHEFFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly APBODAALHDH<FNJOAHFIGDA, FNJOAHFIGDA, FNJOAHFIGDA> BMIBPNKLAPO;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x611C1A0", Offset = "0x611B5A0", VA = "0x18611C1A0")]
	public HBIGOHFOHDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
	public void EOPEJCOCBHD(JADPMANMNKI BJMBJJIMGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x611C140", Offset = "0x611B540", VA = "0x18611C140")]
	public void CHBFGIMMGID(FNJOAHFIGDA NCGFJMKBOIN, FNJOAHFIGDA FGOLIAHPGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x611C060", Offset = "0x611B460", VA = "0x18611C060")]
	public void ADONBMDGLBN(FNJOAHFIGDA NCGFJMKBOIN, FNJOAHFIGDA FGOLIAHPGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x611C0C0", Offset = "0x611B4C0", VA = "0x18611C0C0")]
	public void BEEJDOIKMFG(FNJOAHFIGDA OKCAGOMMBIA, FNJOAHFIGDA FANLJCAEFCA, FNJOAHFIGDA FGOLIAHPGNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class IGNLMFHOMKD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private JADPMANMNKI BJMBJJIMGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private BIKKLBJEPFE HFIBHDFMJDD;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public IGNLMFHOMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x611CB00", Offset = "0x611BF00", VA = "0x18611CB00")]
	public void EOPEJCOCBHD(JADPMANMNKI BJMBJJIMGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x611CA80", Offset = "0x611BE80", VA = "0x18611CA80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x611CD30", Offset = "0x611C130", VA = "0x18611CD30")]
	private void NNBKHGGIFFG(ELBGPJKLPID MLFPIJHNEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x611CA90", Offset = "0x611BE90", VA = "0x18611CA90")]
	private void EDJJIGKHNBB(ELBGPJKLPID GFKBOLJIHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x611C980", Offset = "0x611BD80", VA = "0x18611C980")]
	public void DGBDMLMFNJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x611CC30", Offset = "0x611C030", VA = "0x18611CC30")]
	public void JMKBOBGOENL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class OJFJOMIMADL
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MEGIMLDEEIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public BNDLKDEPBDF container;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public MEGIMLDEEIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6121860", Offset = "0x6120C60", VA = "0x186121860")]
		internal JADPMANMNKI PJHFLAFJHJD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6127860", Offset = "0x6126C60", VA = "0x186127860")]
	public static void PNMGFGOHHNN(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x61277E0", Offset = "0x6126BE0", VA = "0x1861277E0")]
	public static void LJBDEKPOKKC(BNDLKDEPBDF CGBKOFIJCLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[UnityEngine.Scripting.Preserve]
internal class CIEHDIFGOMA : IDisposable, ADPAEJLPELH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly Dictionary<int, DPFFGAGNJIB> CBAJGELNOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly LLLKDMGHMAD PGEDIKBDMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private NJADPHJOCMI GOFHMCAABNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private ODMOJDNCEJK EHDPMADBCLO;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x61169C0", Offset = "0x6115DC0", VA = "0x1861169C0")]
	public CIEHDIFGOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6116160", Offset = "0x6115560", VA = "0x186116160", Slot = "7")]
	public void EOPEJCOCBHD(ODMOJDNCEJK EHDPMADBCLO, NJADPHJOCMI GOFHMCAABNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x61161A0", Offset = "0x61155A0", VA = "0x1861161A0", Slot = "5")]
	public void JKKECKFDIFC(DGOMBPPDKHO OJKEEMNFCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6115FF0", Offset = "0x61153F0", VA = "0x186115FF0", Slot = "9")]
	public void CPHHBCEHMOE(DGOMBPPDKHO DIGLANBIACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x61164B0", Offset = "0x61158B0", VA = "0x1861164B0", Slot = "8")]
	public void PEGIKJLGKEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6116670", Offset = "0x6115A70", VA = "0x186116670", Slot = "10")]
	public void PFDIDLAKLGP(DGOMBPPDKHO IKLDKAALMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x61163E0", Offset = "0x61157E0", VA = "0x1861163E0", Slot = "11")]
	public void NBBIDIBFGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6115E40", Offset = "0x6115240", VA = "0x186115E40")]
	private bool CCAFNJBJOPA(DGOMBPPDKHO DFMGIEANCKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class GPPKBHLNIJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal struct KMICMIGMMCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly OENOONMKLAC IPPGNLBCIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly HashSet<Guid> IEGDFIJMHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly OCMPEAPAOIJ PHGGEAEIPGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly OCMPEAPAOIJ JNMAKLBLHAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly bool CANPDMMBKPN;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private bool DEJLJNPGNFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x611F490", Offset = "0x611E890", VA = "0x18611F490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x611F770", Offset = "0x611EB70", VA = "0x18611F770")]
		public KMICMIGMMCJ(OENOONMKLAC IPPGNLBCIEH, HashSet<Guid> IEGDFIJMHHP, bool CANPDMMBKPN, [Optional] OCMPEAPAOIJ PHGGEAEIPGD, [Optional] OCMPEAPAOIJ JNMAKLBLHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x611F320", Offset = "0x611E720", VA = "0x18611F320")]
		public OCMPEAPAOIJ HBIMCCJEPGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x611EF00", Offset = "0x611E300", VA = "0x18611EF00")]
		private OCMPEAPAOIJ BEPGOJDABJK([Out] OCMPEAPAOIJ GJDMJGGJOIH, [Out] OCMPEAPAOIJ GDCCJFFNFBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x611EFC0", Offset = "0x611E3C0", VA = "0x18611EFC0")]
		private OCMPEAPAOIJ CAKKLMCEPNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x611F1B0", Offset = "0x611E5B0", VA = "0x18611F1B0")]
		private void DGLDGKNLLHO(OCMPEAPAOIJ FGNCDJIJHNH, OCMPEAPAOIJ OAAJPNPJMAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x611F5B0", Offset = "0x611E9B0", VA = "0x18611F5B0")]
		private void NCBCAKHHEBN(OCMPEAPAOIJ GJDMJGGJOIH, OCMPEAPAOIJ GDCCJFFNFBI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private JADPMANMNKI BJMBJJIMGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private ODMOJDNCEJK EHDPMADBCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private ADPAEJLPELH NFJCHKBBCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private BIKKLBJEPFE HFIBHDFMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool CPOKOONMMDE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private bool CBCACIFFEBK
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6119770", Offset = "0x6118B70", VA = "0x186119770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private bool MCNBFHACINP
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x611B660", Offset = "0x611AA60", VA = "0x18611B660")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x611B310", Offset = "0x611A710", VA = "0x18611B310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6119850", Offset = "0x6118C50", VA = "0x186119850")]
	public void EOPEJCOCBHD(JADPMANMNKI BJMBJJIMGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6119200", Offset = "0x6118600", VA = "0x186119200")]
	public JGJPKKIFJJF BHMNONAONKC(bool CANPDMMBKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x611A400", Offset = "0x6119800", VA = "0x18611A400")]
	public JGJPKKIFJJF IPGJBOKOOMB(HashSet<Guid> IEGDFIJMHHP, bool CANPDMMBKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x61197C0", Offset = "0x6118BC0", VA = "0x1861197C0")]
	public void EABABKJKGDJ(JGJPKKIFJJF EHDPMADBCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x611B5C0", Offset = "0x611A9C0", VA = "0x18611B5C0")]
	public void MELJCHGCFJI(JGJPKKIFJJF EHDPMADBCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6119740", Offset = "0x6118B40", VA = "0x186119740")]
	public void CAHIFPJNGGJ(JGJPKKIFJJF EHDPMADBCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6119E50", Offset = "0x6119250", VA = "0x186119E50")]
	private void IFFIPCFCAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x611B680", Offset = "0x611AA80", VA = "0x18611B680")]
	private OCMPEAPAOIJ NFMPOEOOGAH(OENOONMKLAC HBIAHPFPLFB, bool CANPDMMBKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x611AD70", Offset = "0x611A170", VA = "0x18611AD70")]
	private static void JJGMNLFLGOF(OENOONMKLAC HBIAHPFPLFB, bool CANPDMMBKPN, OCMPEAPAOIJ NCELHEHEEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6119BA0", Offset = "0x6118FA0", VA = "0x186119BA0")]
	private void HCAEJKJJAHF(OENOONMKLAC HBIAHPFPLFB, bool CANPDMMBKPN, OCMPEAPAOIJ NCELHEHEEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6119DC0", Offset = "0x61191C0", VA = "0x186119DC0")]
	private OCMPEAPAOIJ HIJCGHCHPMJ(OENOONMKLAC IPPGNLBCIEH, HashSet<Guid> IEGDFIJMHHP, bool CANPDMMBKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x611B330", Offset = "0x611A730", VA = "0x18611B330")]
	private bool KPOICGCAIHK(JGJPKKIFJJF NGGGLEMMGDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x611B9F0", Offset = "0x611ADF0", VA = "0x18611B9F0")]
	private bool OEGPKPGHKAD(OCMPEAPAOIJ NCELHEHEEBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6119B80", Offset = "0x6118F80", VA = "0x186119B80")]
	private bool GAENMGBPGDN(JGJPKKIFJJF EHDPMADBCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6119A60", Offset = "0x6118E60", VA = "0x186119A60")]
	private static bool FMHPCILAIJE(OCMPEAPAOIJ NCELHEHEEBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x611A1B0", Offset = "0x61195B0", VA = "0x18611A1B0")]
	public static bool ILNJEDGAICA(OCMPEAPAOIJ NCELHEHEEBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x611AA40", Offset = "0x6119E40", VA = "0x18611AA40")]
	private FNJOAHFIGDA JFNFIGCOCDE(OCMPEAPAOIJ NCELHEHEEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x611B870", Offset = "0x611AC70", VA = "0x18611B870")]
	private FNJOAHFIGDA NGKNNJDFGAJ(OCMPEAPAOIJ NCELHEHEEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x611A040", Offset = "0x6119440", VA = "0x18611A040")]
	private FNJOAHFIGDA IGLHJMOBBNE(OCMPEAPAOIJ NCELHEHEEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6119A20", Offset = "0x6118E20", VA = "0x186119A20")]
	private static Guid FGMLAABHGKK(OCMPEAPAOIJ NCELHEHEEBE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x611B220", Offset = "0x611A620", VA = "0x18611B220")]
	private string KGOPBLIEHDH(OCMPEAPAOIJ NCELHEHEEBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x61198C0", Offset = "0x6118CC0", VA = "0x1861198C0")]
	private bool FGHPEJCLFMI(OENOONMKLAC HBIAHPFPLFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x611AFC0", Offset = "0x611A3C0", VA = "0x18611AFC0")]
	private static void JMPEBKILOAG(OENOONMKLAC IPPGNLBCIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public GPPKBHLNIJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct KAAHNDPMAFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public FNJOAHFIGDA FGOLIAHPGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public FNJOAHFIGDA NCGFJMKBOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int LJPJPKAOCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int FMEDCEFGKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Vector3 HIIINJCHIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Quaternion DBABBCPBBJB;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public HMMBJJIFLJG HNGEFHINOEN
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x611ECA0", Offset = "0x611E0A0", VA = "0x18611ECA0")]
		get
		{
			return default(HMMBJJIFLJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public HMMBJJIFLJG BABLOFIMONB
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x611ED40", Offset = "0x611E140", VA = "0x18611ED40")]
		get
		{
			return default(HMMBJJIFLJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x611ED70", Offset = "0x611E170", VA = "0x18611ED70")]
	public KAAHNDPMAFD(FNJOAHFIGDA FGOLIAHPGNN, FNJOAHFIGDA NCGFJMKBOIN, int LJPJPKAOCFI, int FMEDCEFGKIE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface ODMOJDNCEJK
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	DGOMBPPDKHO DHEBBLCLMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOPEJCOCBHD(ODCBMINKJGA BJMBJJIMGHO);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KHIHMJGIIJL([In] KAAHNDPMAFD FLKOGFDGJDF, bool FOIMKLKODHB = true);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PEJEBFNBDHJ(FNJOAHFIGDA GEDPCEKKFMP);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OJEDJFNGCCG(FNJOAHFIGDA NKKBHFKAFMF, int LJPJPKAOCFI, int FMEDCEFGKIE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LEHPIAMKMGB(FNJOAHFIGDA MILJDCBPPOJ, int IICIOKJAHGL, FNJOAHFIGDA FANLJCAEFCA, int EPEKBCDAPKE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OICKDLJOBLP();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FKIFOFKNNOP(Func<FNJOAHFIGDA, bool> GBMNHNNBKKP);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NMHCHIMBNON(FNJOAHFIGDA EAECAIAEJFE, HashSet<FNJOAHFIGDA> LJAFPEKDEGB);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<FNJOAHFIGDA> GNJPDPHGMCA();

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OMDFBLGPCHM(FNJOAHFIGDA EAECAIAEJFE, [Out] HMMBJJIFLJG MECMCHLNOKL);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OHLNHECKMMF(LLLKDMGHMAD KCNCNEMPBGA);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal delegate bool LLLKDMGHMAD(DGOMBPPDKHO HBIAHPFPLFB);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface DGOMBPPDKHO
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	FNJOAHFIGDA LLJJPPIHBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	DGOMBPPDKHO PLHMPAHPDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	HMMBJJIFLJG ABLGLABJEHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool HLJIMECELGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface DPFFGAGNJIB
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJKLBDDMIFJ(FNJOAHFIGDA NGOCMNDKFBG, HMMBJJIFLJG FGOLIAHPGNN);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJABMKOMDDC(FNJOAHFIGDA NGOCMNDKFBG, HMMBJJIFLJG FGOLIAHPGNN);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IEPPPBILGBC(FNJOAHFIGDA NGOCMNDKFBG, HMMBJJIFLJG FGOLIAHPGNN);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNBFGIMKIBB(FNJOAHFIGDA NGOCMNDKFBG, HMMBJJIFLJG FGOLIAHPGNN);

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DPFFGAGNJIB Instantiate(Transform KDNNBEIJOEO);

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FHLEEDLMEFH();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface NJADPHJOCMI
{
	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOPEJCOCBHD(Transform KDNNBEIJOEO, DPFFGAGNJIB GGJFBLCEPJL);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DPFFGAGNJIB LPBFIIMMCMB();

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IDELKDJHCPK(DPFFGAGNJIB GNGKCOBFFPD);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface NILGCFJHOJA : MJPJDCPKLOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHLFBDJMPMD(Guid NIBPKOOAPBK);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface ADPAEJLPELH
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKKECKFDIFC(DGOMBPPDKHO OJKEEMNFCOC);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EOPEJCOCBHD(ODMOJDNCEJK EHDPMADBCLO, NJADPHJOCMI IIDPCGMHKHN);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PEGIKJLGKEA();

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CPHHBCEHMOE(DGOMBPPDKHO DIGLANBIACD);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PFDIDLAKLGP(DGOMBPPDKHO IKLDKAALMPH);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NBBIDIBFGLI();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class OENOONMKLAC : DGOMBPPDKHO
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class GGNJICLLCDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public HMMBJJIFLJG nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public OENOONMKLAC foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public GGNJICLLCDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x61190D0", Offset = "0x61184D0", VA = "0x1861190D0")]
		internal bool KIBKGKJFNDN(DGOMBPPDKHO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private HMMBJJIFLJG MECMCHLNOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public LinkedList<OENOONMKLAC> JNEPNPFHGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private OENOONMKLAC KIOBINLMKEE;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public HMMBJJIFLJG ABLGLABJEHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x33C57E0", Offset = "0x33C4BE0", VA = "0x1833C57E0", Slot = "6")]
		get
		{
			return default(HMMBJJIFLJG);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6127520", Offset = "0x6126920", VA = "0x186127520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private OENOONMKLAC NCGFJMKBOIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C4690", Offset = "0x7C3A90", VA = "0x1807C4690")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6126910", Offset = "0x6125D10", VA = "0x186126910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DGOMBPPDKHO PLHMPAHPDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7C4690", Offset = "0x7C3A90", VA = "0x1807C4690", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public FNJOAHFIGDA LLJJPPIHBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool HLJIMECELGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6126C10", Offset = "0x6126010", VA = "0x186126C10", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool HJEELCODOAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x61268C0", Offset = "0x6125CC0", VA = "0x1861268C0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	protected OENOONMKLAC BEOJJJNJFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x61269F0", Offset = "0x6125DF0", VA = "0x1861269F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6127730", Offset = "0x6126B30", VA = "0x186127730")]
	public OENOONMKLAC(HMMBJJIFLJG ONJHLNPCPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6126A10", Offset = "0x6125E10", VA = "0x186126A10")]
	public OENOONMKLAC HFLJCFEFFHN(HMMBJJIFLJG HFAPKPOMGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6126FE0", Offset = "0x61263E0", VA = "0x186126FE0")]
	public OENOONMKLAC LEHMMEIGPEJ(HMMBJJIFLJG MNGIIIEFKLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6127550", Offset = "0x6126950", VA = "0x186127550")]
	public OENOONMKLAC PIABDNKCBCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x61273D0", Offset = "0x61267D0", VA = "0x1861273D0")]
	public void OIGNPMFKFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6126B60", Offset = "0x6125F60", VA = "0x186126B60")]
	public OENOONMKLAC JALBADFPMOJ(HMMBJJIFLJG FANLJCAEFCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x6127260", Offset = "0x6126660", VA = "0x186127260")]
	private static void OHLNHECKMMF(OENOONMKLAC LBFLLOCFLFP, LLLKDMGHMAD HOPLFLJKCIJ, bool JOOFOPPHNIM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x61273C0", Offset = "0x61267C0", VA = "0x1861273C0", Slot = "9")]
	public void OHLNHECKMMF(LLLKDMGHMAD KCNCNEMPBGA, bool NPKABOPCNOL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6126C20", Offset = "0x6126020", VA = "0x186126C20")]
	public static string KIJFHAJCMBG(OENOONMKLAC LBFLLOCFLFP, int PMDNMPHMOKA = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6127160", Offset = "0x6126560", VA = "0x186127160")]
	public static OENOONMKLAC LPIHLLLEPKJ(OENOONMKLAC LBFLLOCFLFP, HMMBJJIFLJG EOGDOEHBIHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface BIKKLBJEPFE
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool CBCACIFFEBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool HJDGMNKJCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<ELBGPJKLPID> NNBKHGGIFFG;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<ELBGPJKLPID> EDJJIGKHNBB;

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(JADPMANMNKI BJMBJJIMGHO);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(FNJOAHFIGDA NKKBHFKAFMF, FNJOAHFIGDA IDEJJMEMDDN, int LJPJPKAOCFI, int FMEDCEFGKIE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(FNJOAHFIGDA MILJDCBPPOJ, int IICIOKJAHGL, FNJOAHFIGDA FANLJCAEFCA, int EPEKBCDAPKE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(JGJPKKIFJJF CGGBOHGECKJ, [Optional] ELBGPJKLPID MFJDHEBELOP);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, BIKKLBJEPFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private JADPMANMNKI BJMBJJIMGHO;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool CBCACIFFEBK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x6121590", Offset = "0x6120990", VA = "0x186121590", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool HJDGMNKJCGB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x61215F0", Offset = "0x61209F0", VA = "0x1861215F0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<ELBGPJKLPID> NNBKHGGIFFG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x61214E0", Offset = "0x61208E0", VA = "0x1861214E0", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x61216E0", Offset = "0x6120AE0", VA = "0x1861216E0", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<ELBGPJKLPID> EDJJIGKHNBB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x6121430", Offset = "0x6120830", VA = "0x186121430", Slot = "17")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x6121630", Offset = "0x6120A30", VA = "0x186121630", Slot = "18")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C46A0", Offset = "0x7C3AA0", VA = "0x1807C46A0", Slot = "21")]
		public void SetManager(JADPMANMNKI BJMBJJIMGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6121400", Offset = "0x6120800", VA = "0x186121400")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6120180", Offset = "0x611F580", VA = "0x186120180", Slot = "25")]
		public void RequestMasterConnectNodes(FNJOAHFIGDA EJBPBFPOLGF, int LJPJPKAOCFI, FNJOAHFIGDA NGOCMNDKFBG, int FMEDCEFGKIE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x61202B0", Offset = "0x611F6B0", VA = "0x1861202B0", Slot = "26")]
		public void RequestMasterDisconnectNode(FNJOAHFIGDA GEDPCEKKFMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6120370", Offset = "0x611F770", VA = "0x186120370", Slot = "22")]
		public void RequestMasterModifyNode(FNJOAHFIGDA NKKBHFKAFMF, FNJOAHFIGDA IDEJJMEMDDN, int LJPJPKAOCFI, int FMEDCEFGKIE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x61204A0", Offset = "0x611F8A0", VA = "0x1861204A0", Slot = "23")]
		public void RequestMasterReparentNodes(FNJOAHFIGDA MILJDCBPPOJ, int IICIOKJAHGL, FNJOAHFIGDA FANLJCAEFCA, int EPEKBCDAPKE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x61205D0", Offset = "0x611F9D0", VA = "0x1861205D0", Slot = "27")]
		public void RequestMasterReparentToRoot(FNJOAHFIGDA MILJDCBPPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6120050", Offset = "0x611F450", VA = "0x186120050", Slot = "24")]
		public void RequestDeserializeConnectableGraph(JGJPKKIFJJF CGGBOHGECKJ, [Optional] ELBGPJKLPID MFJDHEBELOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x61209B0", Offset = "0x611FDB0", VA = "0x1861209B0")]
		[MKCFJDAHJKJ]
		private void RpcMasterConnectNodes(FNJOAHFIGDA EJBPBFPOLGF, int LJPJPKAOCFI, FNJOAHFIGDA NGOCMNDKFBG, int FMEDCEFGKIE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6120C70", Offset = "0x6120070", VA = "0x186120C70")]
		[MKCFJDAHJKJ]
		private void RpcMasterDisconnectNode(FNJOAHFIGDA GEDPCEKKFMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6120FB0", Offset = "0x61203B0", VA = "0x186120FB0")]
		[MKCFJDAHJKJ]
		private void RpcMasterReparentNodes(FNJOAHFIGDA MILJDCBPPOJ, int IICIOKJAHGL, FNJOAHFIGDA FANLJCAEFCA, int EPEKBCDAPKE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6120DB0", Offset = "0x61201B0", VA = "0x186120DB0")]
		[MKCFJDAHJKJ]
		private void RpcMasterModifyNode(FNJOAHFIGDA NKKBHFKAFMF, FNJOAHFIGDA IDEJJMEMDDN, int LJPJPKAOCFI, int FMEDCEFGKIE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x61207A0", Offset = "0x611FBA0", VA = "0x1861207A0")]
		[MKCFJDAHJKJ]
		private void RpcConnectNodes(FNJOAHFIGDA EJBPBFPOLGF, int LJPJPKAOCFI, FNJOAHFIGDA NGOCMNDKFBG, int FMEDCEFGKIE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB, EIPIDIDEEBP LKADHEGBDKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6120920", Offset = "0x611FD20", VA = "0x186120920")]
		[MKCFJDAHJKJ]
		private void RpcDisconnectNode(FNJOAHFIGDA GEDPCEKKFMP, EIPIDIDEEBP LKADHEGBDKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6121300", Offset = "0x6120700", VA = "0x186121300")]
		[MKCFJDAHJKJ]
		private void RpcReparentNodes(FNJOAHFIGDA MILJDCBPPOJ, int IICIOKJAHGL, FNJOAHFIGDA FANLJCAEFCA, int EPEKBCDAPKE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB, EIPIDIDEEBP LKADHEGBDKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6121240", Offset = "0x6120640", VA = "0x186121240")]
		[MKCFJDAHJKJ]
		private void RpcModifyNode(FNJOAHFIGDA NKKBHFKAFMF, int LJPJPKAOCFI, int FMEDCEFGKIE, Vector3 HIIINJCHIGN, Quaternion DBABBCPBBJB, EIPIDIDEEBP LKADHEGBDKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x61208E0", Offset = "0x611FCE0", VA = "0x1861208E0")]
		[MKCFJDAHJKJ]
		private void RpcDeserializeConnectableGraph(JGJPKKIFJJF EHDPMADBCLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7DA790", Offset = "0x7D9B90", VA = "0x1807DA790")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, DPFFGAGNJIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x611FED0", Offset = "0x611F2D0", VA = "0x18611FED0", Slot = "4")]
		private void PGJDDFGMICE(FNJOAHFIGDA NGOCMNDKFBG, HMMBJJIFLJG FGOLIAHPGNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x611FBF0", Offset = "0x611EFF0", VA = "0x18611FBF0", Slot = "5")]
		private void JKHPMHAPNBM(FNJOAHFIGDA NGOCMNDKFBG, HMMBJJIFLJG FGOLIAHPGNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x611FA80", Offset = "0x611EE80", VA = "0x18611FA80", Slot = "6")]
		private void EJJEPLKCMCH(FNJOAHFIGDA NGOCMNDKFBG, HMMBJJIFLJG FGOLIAHPGNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x611F890", Offset = "0x611EC90", VA = "0x18611F890", Slot = "7")]
		private void EDLEFNCOJII(FNJOAHFIGDA NGOCMNDKFBG, HMMBJJIFLJG FGOLIAHPGNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x611FE60", Offset = "0x611F260", VA = "0x18611FE60", Slot = "8")]
		private DPFFGAGNJIB JOPEPIKIEAK(Transform KDNNBEIJOEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x611FB90", Offset = "0x611EF90", VA = "0x18611FB90", Slot = "9")]
		private void HBAGOJIIPLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2F0", Offset = "0x7BC6F0", VA = "0x1807BD2F0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class EPEFPJMNPOM
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x268D250", Offset = "0x268C650", VA = "0x18268D250")]
	public static OIBJOJFDPNA<T> LBNKOAIMNBD<T>(this BNDLKDEPBDF CGBKOFIJCLK)
	{
		return null;
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
