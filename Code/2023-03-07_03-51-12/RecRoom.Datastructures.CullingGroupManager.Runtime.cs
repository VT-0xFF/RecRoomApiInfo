using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, LKCOCDLDCAN
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class CIHFDDHFDDJ<T> : PFJMNMHIAAE, global::LOLPAANBDLA<T>, PHNOFPCAHIJ where T : class, KBOBIGJEJBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x4066A20", Offset = "0x4065E20", VA = "0x184066A20")]
			internal CIHFDDHFDDJ(int NPKCEJOBDGO, float[] KDMEHBCHNON, OBJPBMNCPMO CDPFAIPCMLH = OBJPBMNCPMO.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x4066970", Offset = "0x4065D70", VA = "0x184066970", Slot = "15")]
			public void BKCAAEBNAMB(T JGHFLANLLNE, float COJCFIHHPEL, PBCNLFIKHBJ HFEDMGOCEAE = PBCNLFIKHBJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x4066940", Offset = "0x4065D40", VA = "0x184066940", Slot = "16")]
			public void BKCAAEBNAMB(T JGHFLANLLNE, Transform LIMOOMKJBJJ, float COJCFIHHPEL, PBCNLFIKHBJ HFEDMGOCEAE = PBCNLFIKHBJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4066920", Offset = "0x4065D20", VA = "0x184066920", Slot = "17")]
			public void AMDCHGLDEGN(T JGHFLANLLNE, [Optional] float? COJCFIHHPEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x40669C0", Offset = "0x4065DC0", VA = "0x1840669C0", Slot = "18")]
			public void GAMANBAONBG(T COMMLBIKDOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x40669E0", Offset = "0x4065DE0", VA = "0x1840669E0", Slot = "19")]
			public MGNDJKECDKI MAOKNIDBPAB(T JGHFLANLLNE)
			{
				return default(MGNDJKECDKI);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x4066A00", Offset = "0x4065E00", VA = "0x184066A00", Slot = "20")]
			public bool OMGDELIKMGI(T JGHFLANLLNE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x40669A0", Offset = "0x4065DA0", VA = "0x1840669A0", Slot = "21")]
			public void FEAAHCFMCPJ(T JGHFLANLLNE, PBCNLFIKHBJ EJCAELBKKEH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class PFJMNMHIAAE : IDisposable, PHNOFPCAHIJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum OBJPBMNCPMO : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class ADDELNIANDE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public KBOBIGJEJBE IKDMAGMHCBJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public PBCNLFIKHBJ MHMPLCNOCAL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action AKOFPFLADEO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool HGNLNBOCGGE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int JNPBIMHEMIM;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
				public ADDELNIANDE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class EPEAMNCELDH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public PFJMNMHIAAE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public ADDELNIANDE trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
				public EPEAMNCELDH()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int CPCGCLDIMJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int NPKCEJOBDGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int CMFFFGBOHFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool MDPNAAPBFCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup JCPOHCFAOJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] JICCPPDBHPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] EFOPOOAJOED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly BGEFAHDEANI CMMLIBKHPCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<KBOBIGJEJBE, int> JNCBEFDLPDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, ADDELNIANDE> PAELKHKBHMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly OBJPBMNCPMO CDPFAIPCMLH;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int MCDKPACJJOG
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x6E4780", Offset = "0x6E3B80", VA = "0x1806E4780", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int FHBFAPMHJOM
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x7B9670", Offset = "0x7B8A70", VA = "0x1807B9670", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1A00470", Offset = "0x19FF870", VA = "0x181A00470")]
			internal PFJMNMHIAAE(int NPKCEJOBDGO, float[] KDMEHBCHNON, OBJPBMNCPMO CDPFAIPCMLH = OBJPBMNCPMO.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x19FFEA0", Offset = "0x19FF2A0", VA = "0x1819FFEA0")]
			public void ODDIGOJLGKL(bool HBPAJJFPAJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x19FFCC0", Offset = "0x19FF0C0", VA = "0x1819FFCC0", Slot = "7")]
			public MGNDJKECDKI OCKDIIHIKMO(float ACNMABPOPNI)
			{
				return default(MGNDJKECDKI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x19FE8E0", Offset = "0x19FDCE0", VA = "0x1819FE8E0", Slot = "8")]
			public void BKCAAEBNAMB(KBOBIGJEJBE JGHFLANLLNE, float COJCFIHHPEL, PBCNLFIKHBJ HFEDMGOCEAE = PBCNLFIKHBJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x19FE490", Offset = "0x19FD890", VA = "0x1819FE490", Slot = "9")]
			public void BKCAAEBNAMB(KBOBIGJEJBE JGHFLANLLNE, Transform LIMOOMKJBJJ, float COJCFIHHPEL, PBCNLFIKHBJ HFEDMGOCEAE = PBCNLFIKHBJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x19FFB40", Offset = "0x19FEF40", VA = "0x1819FFB40")]
			public void NPJJNHPABNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x19FE410", Offset = "0x19FD810", VA = "0x1819FE410", Slot = "10")]
			public void AMDCHGLDEGN(KBOBIGJEJBE JGHFLANLLNE, [Optional] float? COJCFIHHPEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1A00310", Offset = "0x19FF710", VA = "0x181A00310")]
			private void PKGPGLOFPCI(int GABJOMFFJAI, [Optional] float? COJCFIHHPEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x19FF000", Offset = "0x19FE400", VA = "0x1819FF000", Slot = "11")]
			public void GAMANBAONBG(KBOBIGJEJBE COMMLBIKDOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x19FF9C0", Offset = "0x19FEDC0", VA = "0x1819FF9C0", Slot = "12")]
			public MGNDJKECDKI MAOKNIDBPAB(KBOBIGJEJBE JGHFLANLLNE)
			{
				return default(MGNDJKECDKI);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1A00210", Offset = "0x19FF610", VA = "0x181A00210", Slot = "13")]
			public bool OMGDELIKMGI(KBOBIGJEJBE JGHFLANLLNE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x19FEF10", Offset = "0x19FE310", VA = "0x1819FEF10", Slot = "14")]
			public void FEAAHCFMCPJ(KBOBIGJEJBE JGHFLANLLNE, PBCNLFIKHBJ LKFNKAJBAAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x19FE9E0", Offset = "0x19FDDE0", VA = "0x1819FE9E0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x19FF430", Offset = "0x19FE830", VA = "0x1819FF430")]
			private void GNKIAKDMNID(ADDELNIANDE EFGEHCFCGFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x19FEC80", Offset = "0x19FE080", VA = "0x1819FEC80")]
			private void EDIJMKPEMEA(ADDELNIANDE EFGEHCFCGFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x19FFAD0", Offset = "0x19FEED0", VA = "0x1819FFAD0")]
			private void MPCLHHCIGBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x19FE970", Offset = "0x19FDD70", VA = "0x1819FE970")]
			private void CNMDJIKEPFE(float GKOOKPKALDG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x19FF970", Offset = "0x19FED70", VA = "0x1819FF970")]
			private void IOAENHLPBEL(ADDELNIANDE EFGEHCFCGFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x19FF9B0", Offset = "0x19FEDB0", VA = "0x1819FF9B0")]
			private void KCOJOCFHFPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x19FF9A0", Offset = "0x19FEDA0", VA = "0x1819FF9A0")]
			private void KAFKMGDKPIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x19FFED0", Offset = "0x19FF2D0", VA = "0x1819FFED0")]
			private void OGNMNFKNEHI(CullingGroupEvent NPNPFBBGPGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x19FF7F0", Offset = "0x19FEBF0", VA = "0x1819FF7F0")]
			private void GPFICHPAIEA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct DOLKBHOAEFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort FHNEDOEJMNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type KMMJMIKGBNC;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float CMDGNGFOJAI = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float ENBMMJNKCJO = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float MGDNDONFBGD = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float NDLGKDOBFMA = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float JDOALJHNFJN = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float PJFKBKADOPL = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float MNJEMIJFGPO = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<DOLKBHOAEFO, PFJMNMHIAAE> MABJBAMFAME;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable IFLKDCCKGFI;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable DJHLBCIBPCF;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static EKMBIMLBDEI DOHEOPFDBHK;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static EKMBIMLBDEI IBJMPEOPPGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly EKMBIMLBDEI PEFIGCLMIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly EKMBIMLBDEI BHBHBOIAFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly EKMBIMLBDEI JOALPJALIMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private IPHLGHEAMKL GKJJIEGCLEM;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool HBPAJJFPAJP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public EKMBIMLBDEI PADFFHOOJIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public EKMBIMLBDEI MNCBFHKCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EKMBIMLBDEI GEPDLPGIGPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool KLFEDKAAOKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x1623D60", Offset = "0x1623160", VA = "0x181623D60", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool BBIAAGBGAOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x76D160", Offset = "0x76C560", VA = "0x18076D160", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x76D180", Offset = "0x76C580", VA = "0x18076D180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x19FD040", Offset = "0x19FC440", VA = "0x1819FD040", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x19FD940", Offset = "0x19FCD40", VA = "0x1819FD940")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x19FD920", Offset = "0x19FCD20", VA = "0x1819FD920")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x19FD110", Offset = "0x19FC510", VA = "0x1819FD110")]
		private void EAJIOHBHNKD(Scene LKJCHBJAPLC, LoadSceneMode CMBMANJMAFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x19FD840", Offset = "0x19FCC40", VA = "0x1819FD840", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x19FDB90", Offset = "0x19FCF90", VA = "0x1819FDB90")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x19FD680", Offset = "0x19FCA80", VA = "0x1819FD680")]
		private void LAECGPKEOJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x19FD960", Offset = "0x19FCD60", VA = "0x1819FD960")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x19FD500", Offset = "0x19FC900", VA = "0x1819FD500")]
		private void HMBFOPNKMIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x19FD310", Offset = "0x19FC710", VA = "0x1819FD310")]
		public PHNOFPCAHIJ GetOrCreateCullingGroup(Type JNHPOFHMALO, int LIPIHKMDDBJ, ushort PJPGGENBNBE = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x33D4B60", Offset = "0x33D3F60", VA = "0x1833D4B60")]
		public global::LOLPAANBDLA<T> GetOrCreateCullingGroup<T>(int LIPIHKMDDBJ, ushort PJPGGENBNBE = 0) where T : class, KBOBIGJEJBE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x19FCEA0", Offset = "0x19FC2A0", VA = "0x1819FCEA0")]
		private PHNOFPCAHIJ AOOKGCFEGKB(Type JNHPOFHMALO, int LIPIHKMDDBJ, float[] KDMEHBCHNON, ushort PJPGGENBNBE = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x33D4930", Offset = "0x33D3D30", VA = "0x1833D4930")]
		private global::LOLPAANBDLA<T> AOOKGCFEGKB<T>(int LIPIHKMDDBJ, float[] KDMEHBCHNON, ushort PJPGGENBNBE = 0) where T : class, KBOBIGJEJBE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x19FD170", Offset = "0x19FC570", VA = "0x1819FD170")]
		public static MGNDJKECDKI FindClosestDefaultUpdateLod(float PEILPGGIKLA)
		{
			return default(MGNDJKECDKI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x19FD830", Offset = "0x19FCC30", VA = "0x1819FD830")]
		public static MGNDJKECDKI MinUpdateLod(MGNDJKECDKI HBJLKDJJNMA, MGNDJKECDKI JHMHBGENDJF)
		{
			return default(MGNDJKECDKI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x19FD820", Offset = "0x19FCC20", VA = "0x1819FD820")]
		public static MGNDJKECDKI MaxUpdateLod(MGNDJKECDKI HBJLKDJJNMA, MGNDJKECDKI JHMHBGENDJF)
		{
			return default(MGNDJKECDKI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x19FDFC0", Offset = "0x19FD3C0", VA = "0x1819FDFC0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BGEFAHDEANI
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool ABMGDJLFMAI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera IJDMMMLKMPK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EKMBIMLBDEI KIKMIHJDMOL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool FBGOFMBLGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EKMBIMLBDEI OKMLEKPOJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform KLBHDENMEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PHNOFPCAHIJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int MCDKPACJJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int FHBFAPMHJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MGNDJKECDKI OCKDIIHIKMO(float ACNMABPOPNI);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BKCAAEBNAMB(KBOBIGJEJBE JGHFLANLLNE, float COJCFIHHPEL, PBCNLFIKHBJ HFEDMGOCEAE = PBCNLFIKHBJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BKCAAEBNAMB(KBOBIGJEJBE JGHFLANLLNE, Transform LIMOOMKJBJJ, float COJCFIHHPEL, PBCNLFIKHBJ HFEDMGOCEAE = PBCNLFIKHBJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AMDCHGLDEGN(KBOBIGJEJBE JGHFLANLLNE, [Optional] float? COJCFIHHPEL);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GAMANBAONBG(KBOBIGJEJBE COMMLBIKDOM);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MGNDJKECDKI MAOKNIDBPAB(KBOBIGJEJBE JGHFLANLLNE);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OMGDELIKMGI(KBOBIGJEJBE JGHFLANLLNE);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FEAAHCFMCPJ(KBOBIGJEJBE JGHFLANLLNE, PBCNLFIKHBJ EJCAELBKKEH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LOLPAANBDLA<T> : PHNOFPCAHIJ where T : class, KBOBIGJEJBE
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKCAAEBNAMB(T JGHFLANLLNE, float COJCFIHHPEL, PBCNLFIKHBJ HFEDMGOCEAE = PBCNLFIKHBJ.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BKCAAEBNAMB(T JGHFLANLLNE, Transform LIMOOMKJBJJ, float COJCFIHHPEL, PBCNLFIKHBJ HFEDMGOCEAE = PBCNLFIKHBJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMDCHGLDEGN(T JGHFLANLLNE, [Optional] float? COJCFIHHPEL);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GAMANBAONBG(T COMMLBIKDOM);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MGNDJKECDKI MAOKNIDBPAB(T JGHFLANLLNE);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OMGDELIKMGI(T JGHFLANLLNE);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FEAAHCFMCPJ(T JGHFLANLLNE, PBCNLFIKHBJ EJCAELBKKEH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KBOBIGJEJBE
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform GCKJJOINBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(MGNDJKECDKI GJLONDIJOCN, MGNDJKECDKI HAJFBLJEELF);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool HNLCKLOEHEA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum PBCNLFIKHBJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum MGNDJKECDKI
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GJGPIMDFLJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private MGNDJKECDKI NEOBGLMFFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private MGNDJKECDKI OKNLCAAGMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, MGNDJKECDKI> ALFGNJOFOMA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool JPHLGBLIGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x19FE270", Offset = "0x19FD670", VA = "0x1819FE270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public MGNDJKECDKI LOOPBIFAGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6E4780", Offset = "0x6E3B80", VA = "0x1806E4780")]
		get
		{
			return default(MGNDJKECDKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public MGNDJKECDKI CMLLCJOKJPE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7B9670", Offset = "0x7B8A70", VA = "0x1807B9670")]
		get
		{
			return default(MGNDJKECDKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x19FE2C0", Offset = "0x19FD6C0", VA = "0x1819FE2C0")]
	public bool KLKEPONKDMN(object JCHAGIDHJIB, MGNDJKECDKI FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x19FE330", Offset = "0x19FD730", VA = "0x1819FE330")]
	public bool MHFEDDGBMKF(object JCHAGIDHJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x19FE110", Offset = "0x19FD510", VA = "0x1819FE110")]
	private bool FDFJLDJHIIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x19FE390", Offset = "0x19FD790", VA = "0x1819FE390")]
	public GJGPIMDFLJP()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ABFMAPAPCGL
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] CFDBFPKMJCL;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int NBKCFIGJMGE;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int BKBNJMLFPCH;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger IHOABMABNGK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ABFMAPAPCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x19FCBC0", Offset = "0x19FBFC0", VA = "0x1819FCBC0")]
	private static string OGMGDCCGOFL(byte[] CFEKEMJOJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x19FC870", Offset = "0x19FBC70", VA = "0x1819FC870")]
	public static string DFBBLGFDDMJ(byte[] GJDBLJLIDDI, bool JLJMGNGGBON)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
