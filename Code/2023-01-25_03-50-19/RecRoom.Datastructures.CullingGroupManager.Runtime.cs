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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, NLFKOLIGGGC
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class IMDMICNKFJD<T> : ACDMFDNILMP, global::PJKODMFFAMP<T>, KCOOBFCCFJJ where T : class, OANJEPKEPDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1E29230", Offset = "0x1E28230", VA = "0x181E29230")]
			internal IMDMICNKFJD(int GPAMGAKKDHD, float[] EPAJDFNEHOD, NMCAJMABKIE JHNGLENEEMN = NMCAJMABKIE.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x1E291C0", Offset = "0x1E281C0", VA = "0x181E291C0", Slot = "15")]
			public void HMNAIPBHJIK(T GKCPJCKCENH, float OGEOCIGKOAK, BNNFBOLCMKH MHJAJCDEABJ = BNNFBOLCMKH.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x1E29190", Offset = "0x1E28190", VA = "0x181E29190", Slot = "16")]
			public void HMNAIPBHJIK(T GKCPJCKCENH, Transform ADMLAKEGAAL, float OGEOCIGKOAK, BNNFBOLCMKH MHJAJCDEABJ = BNNFBOLCMKH.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x1E29170", Offset = "0x1E28170", VA = "0x181E29170", Slot = "17")]
			public void FGLEIIFJJEA(T GKCPJCKCENH, [Optional] float? OGEOCIGKOAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1E29150", Offset = "0x1E28150", VA = "0x181E29150", Slot = "18")]
			public void FAHLDBEBGON(T KHLMKNFPJEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1E29210", Offset = "0x1E28210", VA = "0x181E29210", Slot = "19")]
			public DBMDPKLIGOD LHCMGCPFELD(T GKCPJCKCENH)
			{
				return default(DBMDPKLIGOD);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1E29130", Offset = "0x1E28130", VA = "0x181E29130", Slot = "20")]
			public bool EPMNPKEODLK(T GKCPJCKCENH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1E291F0", Offset = "0x1E281F0", VA = "0x181E291F0", Slot = "21")]
			public void KEBKKKAKLDE(T GKCPJCKCENH, BNNFBOLCMKH MEAHDDKNPFN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class ACDMFDNILMP : IDisposable, KCOOBFCCFJJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum NMCAJMABKIE : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class GMJJLAFOLNL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public OANJEPKEPDG HGBOMLOHJNM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public BNNFBOLCMKH NECDPGJCDDA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action MLPBDNGINDO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool BIOPDNIBMGN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int EBAKNIMBLHM;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
				public GMJJLAFOLNL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class KJNOPBFAJLC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public ACDMFDNILMP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public GMJJLAFOLNL trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
				public KJNOPBFAJLC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int OOGMIJDNFCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int GPAMGAKKDHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int EILLENDCLPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool JKEEGJNIPNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup OMHIGGCDJDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] IKHDNIJGPPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] AGJHIGALCPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly KBBKMAONCLF ACNDHAIKGGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<OANJEPKEPDG, int> ONKHLBPLANI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, GMJJLAFOLNL> KPMBEDFPMKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly NMCAJMABKIE JHNGLENEEMN;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int JFAOGIEGAPG
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x67E040", Offset = "0x67D040", VA = "0x18067E040", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int COIEMEHOEDB
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x694790", Offset = "0x693790", VA = "0x180694790", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x60D5FC0", Offset = "0x60D4FC0", VA = "0x1860D5FC0")]
			internal ACDMFDNILMP(int GPAMGAKKDHD, float[] EPAJDFNEHOD, NMCAJMABKIE JHNGLENEEMN = NMCAJMABKIE.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x60D4AF0", Offset = "0x60D3AF0", VA = "0x1860D4AF0")]
			public void FDGAHJJCJNB(bool KFLBLFJIFNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x60D5DE0", Offset = "0x60D4DE0", VA = "0x1860D5DE0", Slot = "7")]
			public DBMDPKLIGOD PMPBEPAMEOL(float NDNEHIEMEBF)
			{
				return default(DBMDPKLIGOD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x60D5130", Offset = "0x60D4130", VA = "0x1860D5130", Slot = "8")]
			public void HMNAIPBHJIK(OANJEPKEPDG GKCPJCKCENH, float OGEOCIGKOAK, BNNFBOLCMKH MHJAJCDEABJ = BNNFBOLCMKH.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x60D51C0", Offset = "0x60D41C0", VA = "0x1860D51C0", Slot = "9")]
			public void HMNAIPBHJIK(OANJEPKEPDG GKCPJCKCENH, Transform ADMLAKEGAAL, float OGEOCIGKOAK, BNNFBOLCMKH MHJAJCDEABJ = BNNFBOLCMKH.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x60D4FB0", Offset = "0x60D3FB0", VA = "0x1860D4FB0")]
			public void HIAIGAKDPIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x60D4B20", Offset = "0x60D3B20", VA = "0x1860D4B20", Slot = "10")]
			public void FGLEIIFJJEA(OANJEPKEPDG GKCPJCKCENH, [Optional] float? OGEOCIGKOAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x60D5680", Offset = "0x60D4680", VA = "0x1860D5680")]
			private void IJNKNIGMKFB(int NPDGHPHAKDK, [Optional] float? OGEOCIGKOAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x60D46C0", Offset = "0x60D36C0", VA = "0x1860D46C0", Slot = "11")]
			public void FAHLDBEBGON(OANJEPKEPDG KHLMKNFPJEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x60D5CB0", Offset = "0x60D4CB0", VA = "0x1860D5CB0", Slot = "12")]
			public DBMDPKLIGOD LHCMGCPFELD(OANJEPKEPDG GKCPJCKCENH)
			{
				return default(DBMDPKLIGOD);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x60D45C0", Offset = "0x60D35C0", VA = "0x1860D45C0", Slot = "13")]
			public bool EPMNPKEODLK(OANJEPKEPDG GKCPJCKCENH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x60D5B20", Offset = "0x60D4B20", VA = "0x1860D5B20", Slot = "14")]
			public void KEBKKKAKLDE(OANJEPKEPDG GKCPJCKCENH, BNNFBOLCMKH JDAMJCLDEMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x60D4320", Offset = "0x60D3320", VA = "0x1860D4320", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x60D3F60", Offset = "0x60D2F60", VA = "0x1860D3F60")]
			private void CEPKDPMCPNI(GMJJLAFOLNL NIOJEKBKMEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x60D4D20", Offset = "0x60D3D20", VA = "0x1860D4D20")]
			private void GIPDCDMNGKN(GMJJLAFOLNL NIOJEKBKMEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x60D5C40", Offset = "0x60D4C40", VA = "0x1860D5C40")]
			private void LGDOIFLEEEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x60D5610", Offset = "0x60D4610", VA = "0x1860D5610")]
			private void IALAMJKANOM(float JOOCLGDKHDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x60D5C10", Offset = "0x60D4C10", VA = "0x1860D5C10")]
			private void LCOAKKFAPLC(GMJJLAFOLNL NIOJEKBKMEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x60D5DD0", Offset = "0x60D4DD0", VA = "0x1860D5DD0")]
			private void PKIOHHANJIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x60D5DC0", Offset = "0x60D4DC0", VA = "0x1860D5DC0")]
			private void MMLAEMCACEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x60D57E0", Offset = "0x60D47E0", VA = "0x1860D57E0")]
			private void JAFBMKFIPBA(CullingGroupEvent AKDNOOEOGJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x60D4BA0", Offset = "0x60D3BA0", VA = "0x1860D4BA0")]
			private void FLJALKCJDNH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct JEBKJEHEOCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort AAEOCCCFMEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type KPBKHKKCCDB;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float KJJELPBNLAJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float GLLDNBAFHCL = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float NEIHEAEAHHM = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float FLENMHEFMDA = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float LNLPFFCBMIE = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float KJEFDKGPHBD = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float GLNDJJCLBPN = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<JEBKJEHEOCN, ACDMFDNILMP> KJFHMHLMCAD;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable HIEOEAFEBKI;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable AIJCIJJFAPN;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static FMJNLFCNDHK HENCGMPIMIL;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static FMJNLFCNDHK AGKFBFLEKEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly FMJNLFCNDHK AIMIOBIFAPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly FMJNLFCNDHK KHLGPKJNNKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly FMJNLFCNDHK OGPEDPNHFFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private MANCEBNIGPM PBEBPNGHMDC;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool KFLBLFJIFNK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public FMJNLFCNDHK CCPPKBAANEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public FMJNLFCNDHK JIANGODIBIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x67F120", Offset = "0x67E120", VA = "0x18067F120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public FMJNLFCNDHK ABHMHDIIBAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6988E0", Offset = "0x6978E0", VA = "0x1806988E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool ADOHMGAGHHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x166C840", Offset = "0x166B840", VA = "0x18166C840", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool LEJGPCJNOMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x67E030", Offset = "0x67D030", VA = "0x18067E030", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7F7EA0", Offset = "0x7F6EA0", VA = "0x1807F7EA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x60D6520", Offset = "0x60D5520", VA = "0x1860D6520", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE885E0", Offset = "0xE875E0", VA = "0x180E885E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60D6E00", Offset = "0x60D5E00", VA = "0x1860D6E00")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x60D6AB0", Offset = "0x60D5AB0", VA = "0x1860D6AB0")]
		private void GEJMFLNBOGD(Scene PPJNHEBGICL, LoadSceneMode HOEJODOFJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60D6D20", Offset = "0x60D5D20", VA = "0x1860D6D20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60D7050", Offset = "0x60D6050", VA = "0x1860D7050")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60D65F0", Offset = "0x60D55F0", VA = "0x1860D65F0")]
		private void DIPMDCGJGNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60D6E20", Offset = "0x60D5E20", VA = "0x1860D6E20")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60D6790", Offset = "0x60D5790", VA = "0x1860D6790")]
		private void DKGFIPCJNED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60D6B10", Offset = "0x60D5B10", VA = "0x1860D6B10")]
		public KCOOBFCCFJJ GetOrCreateCullingGroup(Type DKNKJJCPMNA, int DOJFDCLFFMM, ushort BFOFGHAKNLP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x24F3840", Offset = "0x24F2840", VA = "0x1824F3840")]
		public global::PJKODMFFAMP<T> GetOrCreateCullingGroup<T>(int DOJFDCLFFMM, ushort BFOFGHAKNLP = 0) where T : class, OANJEPKEPDG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x60D6380", Offset = "0x60D5380", VA = "0x1860D6380")]
		private KCOOBFCCFJJ ANDNLBJANLJ(Type DKNKJJCPMNA, int DOJFDCLFFMM, float[] EPAJDFNEHOD, ushort BFOFGHAKNLP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x24F3610", Offset = "0x24F2610", VA = "0x1824F3610")]
		private global::PJKODMFFAMP<T> ANDNLBJANLJ<T>(int DOJFDCLFFMM, float[] EPAJDFNEHOD, ushort BFOFGHAKNLP = 0) where T : class, OANJEPKEPDG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x60D6910", Offset = "0x60D5910", VA = "0x1860D6910")]
		public static DBMDPKLIGOD FindClosestDefaultUpdateLod(float KGJIMLAEIHB)
		{
			return default(DBMDPKLIGOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x60D6D10", Offset = "0x60D5D10", VA = "0x1860D6D10")]
		public static DBMDPKLIGOD MinUpdateLod(DBMDPKLIGOD IKEOBLPFGMA, DBMDPKLIGOD FBPOEFDAPOK)
		{
			return default(DBMDPKLIGOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x60D6D00", Offset = "0x60D5D00", VA = "0x1860D6D00")]
		public static DBMDPKLIGOD MaxUpdateLod(DBMDPKLIGOD IKEOBLPFGMA, DBMDPKLIGOD FBPOEFDAPOK)
		{
			return default(DBMDPKLIGOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60D7480", Offset = "0x60D6480", VA = "0x1860D7480")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KBBKMAONCLF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool OJNHPPINMEH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera FANECOOPBAN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FMJNLFCNDHK IOPOALDCBII
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool NMKNFODNEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	FMJNLFCNDHK HJPGOFKGJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform KPPEPMHFHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KCOOBFCCFJJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int JFAOGIEGAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int COIEMEHOEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DBMDPKLIGOD PMPBEPAMEOL(float NDNEHIEMEBF);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HMNAIPBHJIK(OANJEPKEPDG GKCPJCKCENH, float OGEOCIGKOAK, BNNFBOLCMKH MHJAJCDEABJ = BNNFBOLCMKH.Off);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HMNAIPBHJIK(OANJEPKEPDG GKCPJCKCENH, Transform ADMLAKEGAAL, float OGEOCIGKOAK, BNNFBOLCMKH MHJAJCDEABJ = BNNFBOLCMKH.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGLEIIFJJEA(OANJEPKEPDG GKCPJCKCENH, [Optional] float? OGEOCIGKOAK);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FAHLDBEBGON(OANJEPKEPDG KHLMKNFPJEB);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DBMDPKLIGOD LHCMGCPFELD(OANJEPKEPDG GKCPJCKCENH);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EPMNPKEODLK(OANJEPKEPDG GKCPJCKCENH);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KEBKKKAKLDE(OANJEPKEPDG GKCPJCKCENH, BNNFBOLCMKH MEAHDDKNPFN);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PJKODMFFAMP<T> : KCOOBFCCFJJ where T : class, OANJEPKEPDG
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMNAIPBHJIK(T GKCPJCKCENH, float OGEOCIGKOAK, BNNFBOLCMKH MHJAJCDEABJ = BNNFBOLCMKH.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMNAIPBHJIK(T GKCPJCKCENH, Transform ADMLAKEGAAL, float OGEOCIGKOAK, BNNFBOLCMKH MHJAJCDEABJ = BNNFBOLCMKH.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FGLEIIFJJEA(T GKCPJCKCENH, [Optional] float? OGEOCIGKOAK);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FAHLDBEBGON(T KHLMKNFPJEB);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DBMDPKLIGOD LHCMGCPFELD(T GKCPJCKCENH);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EPMNPKEODLK(T GKCPJCKCENH);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KEBKKKAKLDE(T GKCPJCKCENH, BNNFBOLCMKH MEAHDDKNPFN);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OANJEPKEPDG
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform FLCFNMLPAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(DBMDPKLIGOD NFCEFDMKDGH, DBMDPKLIGOD JCCOFAJKEEA);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool GGGNNFGKGED);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum BNNFBOLCMKH : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum DBMDPKLIGOD
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
public class NALBNNJOGMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private DBMDPKLIGOD AJMPIJJCLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private DBMDPKLIGOD JFFGPOOCEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, DBMDPKLIGOD> CBBPIOMEIIP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool MMFCMIFFGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x60D7C00", Offset = "0x60D6C00", VA = "0x1860D7C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DBMDPKLIGOD EBHIOKMHDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x67E040", Offset = "0x67D040", VA = "0x18067E040")]
		get
		{
			return default(DBMDPKLIGOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DBMDPKLIGOD IBMMILOJDHN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x694790", Offset = "0x693790", VA = "0x180694790")]
		get
		{
			return default(DBMDPKLIGOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60D7E10", Offset = "0x60D6E10", VA = "0x1860D7E10")]
	public bool PAGNFDLBLPI(object KCCFEDJJGAN, DBMDPKLIGOD DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x60D7DB0", Offset = "0x60D6DB0", VA = "0x1860D7DB0")]
	public bool JFPCPHHFBIN(object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x60D7C50", Offset = "0x60D6C50", VA = "0x1860D7C50")]
	private bool ICCNFDCOBAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60D7E80", Offset = "0x60D6E80", VA = "0x1860D7E80")]
	public NALBNNJOGMN()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KJPGGDKBIND
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] CFKIOPKCLEE;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int PODCBGNELNF;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int DIHMJLLDPDD;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger MMOCJBNMKFM;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public KJPGGDKBIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x60D7920", Offset = "0x60D6920", VA = "0x1860D7920")]
	private static string EAILEDEPOEM(byte[] OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x60D75D0", Offset = "0x60D65D0", VA = "0x1860D75D0")]
	public static string AMGIJLDMAAM(byte[] CCFMJPPGPDK, bool IEFNHKOPNBP)
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
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
