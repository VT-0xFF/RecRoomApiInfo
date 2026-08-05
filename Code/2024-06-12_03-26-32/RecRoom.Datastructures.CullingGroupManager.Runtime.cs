using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, OCPFCAEFKCD
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class OFMNNGIGIGE<T> : HEGMGALJAPG, EHDBGPKCEGH<T>, KCBEDPNLCFC where T : class, AHPBPMBKKIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x4587B70", Offset = "0x4586770", VA = "0x184587B70")]
			internal OFMNNGIGIGE(int PMENEPOCEMI, float[] IMDAKOLLAMB, CJHPMEDLMFK KKKEIFJDEGP = CJHPMEDLMFK.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x4587B40", Offset = "0x4586740", VA = "0x184587B40", Slot = "10")]
			public void MPFJKDGCCNN(T HAHECKLGOJC, float HNLLDLBIGBG, EHMENGICDDK KIALMAEPDDG = EHMENGICDDK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x4587B10", Offset = "0x4586710", VA = "0x184587B10", Slot = "11")]
			public void MPFJKDGCCNN(T HAHECKLGOJC, Transform KOJHHJLHAPP, float HNLLDLBIGBG, EHMENGICDDK KIALMAEPDDG = EHMENGICDDK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4587AF0", Offset = "0x45866F0", VA = "0x184587AF0", Slot = "12")]
			public void IFPALOLJLCH(T NECMONALJMI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class HEGMGALJAPG : IDisposable, KCBEDPNLCFC
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum CJHPMEDLMFK : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class OOMBEMEKNIP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public AHPBPMBKKIF NPFANBOBOND;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public EHMENGICDDK HDHDCBGELDM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action ACIFJEKMGOH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool MOILIPFGCGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int HDEPOMLIBHF;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
				public OOMBEMEKNIP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class HEDGIKLFMNM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public HEGMGALJAPG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public OOMBEMEKNIP trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
				public HEDGIKLFMNM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x689E8E0", Offset = "0x689D4E0", VA = "0x18689E8E0")]
				internal void AIPPJPGOBIC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int EGICNHDKAOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int PMENEPOCEMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int PGIFPPFBGCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool JAMLMCMFMMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup HJJJAFOMJDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] GPGFHKOHIFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] MOBNBCPBKBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly EKOCBJMLELA KHAIJLCNIAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<AHPBPMBKKIF, int> AOFOOLCELIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, OOMBEMEKNIP> PFMOKJNCJNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CJHPMEDLMFK KKKEIFJDEGP;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool KPJHPNGPJID
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xF299A0", Offset = "0xF285A0", VA = "0x180F299A0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x4475160", Offset = "0x4473D60", VA = "0x184475160", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x68A05F0", Offset = "0x689F1F0", VA = "0x1868A05F0")]
			internal HEGMGALJAPG(int PMENEPOCEMI, float[] IMDAKOLLAMB, CJHPMEDLMFK KKKEIFJDEGP = CJHPMEDLMFK.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x689EF60", Offset = "0x689DB60", VA = "0x18689EF60")]
			public void DMLHIGABBLI(bool PPPMKKGEHAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x68A0070", Offset = "0x689EC70", VA = "0x1868A0070", Slot = "6")]
			public void MPFJKDGCCNN(AHPBPMBKKIF HAHECKLGOJC, float HNLLDLBIGBG, EHMENGICDDK KIALMAEPDDG = EHMENGICDDK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x68A0100", Offset = "0x689ED00", VA = "0x1868A0100", Slot = "9")]
			public void MPFJKDGCCNN(AHPBPMBKKIF HAHECKLGOJC, Transform KOJHHJLHAPP, float HNLLDLBIGBG, EHMENGICDDK KIALMAEPDDG = EHMENGICDDK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x689EA30", Offset = "0x689D630", VA = "0x18689EA30")]
			public void BOOFLLCDGIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x689F250", Offset = "0x689DE50", VA = "0x18689F250")]
			private void EEEKDKFPHJF(int OPDMGNJCACB, [Optional] float? HNLLDLBIGBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x689F8D0", Offset = "0x689E4D0", VA = "0x18689F8D0", Slot = "7")]
			public void IFPALOLJLCH(AHPBPMBKKIF NECMONALJMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x68A0500", Offset = "0x689F100", VA = "0x1868A0500", Slot = "8")]
			public void PHLGINFMCGL(AHPBPMBKKIF HAHECKLGOJC, EHMENGICDDK JLDKKLAEGPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x689EF90", Offset = "0x689DB90", VA = "0x18689EF90", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x689FCD0", Offset = "0x689E8D0", VA = "0x18689FCD0")]
			private void IMGCGFEBGFL(OOMBEMEKNIP HCBCMKLHHGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x689EB80", Offset = "0x689D780", VA = "0x18689EB80")]
			private void BPPOBMLOGAP(OOMBEMEKNIP HCBCMKLHHGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x689F870", Offset = "0x689E470", VA = "0x18689F870")]
			private void GBLBKOPPKKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x689F6A0", Offset = "0x689E2A0", VA = "0x18689F6A0")]
			private void ENOHCJFIILB(float HHCAAOJDKHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x689EE20", Offset = "0x689DA20", VA = "0x18689EE20")]
			private void CIBBFMAIONH(OOMBEMEKNIP HCBCMKLHHGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x68A0060", Offset = "0x689EC60", VA = "0x1868A0060")]
			private void LJIMLEMPBHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x689FCC0", Offset = "0x689E8C0", VA = "0x18689FCC0")]
			private void IMDGPFGHOIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x689F380", Offset = "0x689DF80", VA = "0x18689F380")]
			private void EKHGIGLGGHO(CullingGroupEvent FLBKNOAAAIE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x689F700", Offset = "0x689E300", VA = "0x18689F700")]
			private void FKAILNOCHPE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct GMGNPKOFCAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort ABAPDHCCBMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type DHMLGACCNHL;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float NFCGOAMNDIF = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float JPBBAAOFPCK = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float NBGBIFIPFHJ = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float KCEMAOAHKJK = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float ENAMJKDNCBF = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float JKFIJANCFLN = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float PMJNILDGKFO = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<GMGNPKOFCAP, HEGMGALJAPG> NEAAKEKGHMO;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable KNEOFJFEDJC;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable KJLHJKLIEDE;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static DEHOLECDIJP GHPNMGLGGED;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static DEHOLECDIJP AIKEGKDLONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly DEHOLECDIJP KJMDJHKKGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly DEHOLECDIJP JNCNGOIMPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DEHOLECDIJP PIIFLJLHKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GNHKJFLENJL FJBLKKEGKPD;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool PPPMKKGEHAM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public DEHOLECDIJP GPACJBDOMJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public DEHOLECDIJP NOHFIELFEON
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DEHOLECDIJP JGFPKICJCLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool MNJLDCGPKIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xF6D820", Offset = "0xF6C420", VA = "0x180F6D820", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JFNDPNLPPLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9B1E90", Offset = "0x9B0A90", VA = "0x1809B1E90", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA07C40", Offset = "0xA06840", VA = "0x180A07C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x689D660", Offset = "0x689C260", VA = "0x18689D660", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x689DF30", Offset = "0x689CB30", VA = "0x18689DF30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x689DF10", Offset = "0x689CB10", VA = "0x18689DF10")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x689DDD0", Offset = "0x689C9D0", VA = "0x18689DDD0")]
		private void NHGCNFEALDL(Scene BIGDMHGNNKD, LoadSceneMode CMLBPDKMHGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x689DE30", Offset = "0x689CA30", VA = "0x18689DE30", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x689E370", Offset = "0x689CF70", VA = "0x18689E370")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x689D720", Offset = "0x689C320", VA = "0x18689D720")]
		private void CHJHKGLMIIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x689E130", Offset = "0x689CD30", VA = "0x18689E130")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x689DA20", Offset = "0x689C620", VA = "0x18689DA20")]
		private void GIOKHDOMALN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x689DBA0", Offset = "0x689C7A0", VA = "0x18689DBA0")]
		public KCBEDPNLCFC GetOrCreateCullingGroup(Type HMOKGCJPNGE, int GLLOEFJNFNM, ushort LBJLDPIIKEP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2929C50", Offset = "0x2928850", VA = "0x182929C50")]
		public EHDBGPKCEGH<T> GetOrCreateCullingGroup<T>(int GLLOEFJNFNM, ushort LBJLDPIIKEP = 0) where T : class, AHPBPMBKKIF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x689DF50", Offset = "0x689CB50", VA = "0x18689DF50")]
		private KCBEDPNLCFC PIEKPAINLCG(Type HMOKGCJPNGE, int GLLOEFJNFNM, float[] IMDAKOLLAMB, ushort LBJLDPIIKEP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2929D00", Offset = "0x2928900", VA = "0x182929D00")]
		private EHDBGPKCEGH<T> PIEKPAINLCG<T>(int GLLOEFJNFNM, float[] IMDAKOLLAMB, ushort LBJLDPIIKEP = 0) where T : class, AHPBPMBKKIF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x689D8C0", Offset = "0x689C4C0", VA = "0x18689D8C0")]
		public static PHMIKAKJJJM FindClosestDefaultUpdateLod(float JEDDLPAKEFC)
		{
			return default(PHMIKAKJJJM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x871270", Offset = "0x86FE70", VA = "0x180871270")]
		public static PHMIKAKJJJM MinUpdateLod(PHMIKAKJJJM AKCOFADFDEN, PHMIKAKJJJM BBGDFNAHNDG)
		{
			return default(PHMIKAKJJJM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x689DDC0", Offset = "0x689C9C0", VA = "0x18689DDC0")]
		public static PHMIKAKJJJM MaxUpdateLod(PHMIKAKJJJM AKCOFADFDEN, PHMIKAKJJJM BBGDFNAHNDG)
		{
			return default(PHMIKAKJJJM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x689E7E0", Offset = "0x689D3E0", VA = "0x18689E7E0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EKOCBJMLELA
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool LNCOKACJINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera MAJHODODLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DEHOLECDIJP CMECDLCGMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool NKDEDDLNKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DEHOLECDIJP MDHOOAJAAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform IKJJGACBOMN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KCBEDPNLCFC
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool KPJHPNGPJID
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MPFJKDGCCNN(AHPBPMBKKIF HAHECKLGOJC, float HNLLDLBIGBG, EHMENGICDDK KIALMAEPDDG = EHMENGICDDK.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IFPALOLJLCH(AHPBPMBKKIF NECMONALJMI);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PHLGINFMCGL(AHPBPMBKKIF HAHECKLGOJC, EHMENGICDDK JOHDMNMBEAM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EHDBGPKCEGH<T> : KCBEDPNLCFC where T : class, AHPBPMBKKIF
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPFJKDGCCNN(T HAHECKLGOJC, float HNLLDLBIGBG, EHMENGICDDK KIALMAEPDDG = EHMENGICDDK.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MPFJKDGCCNN(T HAHECKLGOJC, Transform KOJHHJLHAPP, float HNLLDLBIGBG, EHMENGICDDK KIALMAEPDDG = EHMENGICDDK.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IFPALOLJLCH(T NECMONALJMI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AHPBPMBKKIF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform KHIOEALLADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(PHMIKAKJJJM DGFKPDOHAJL, PHMIKAKJJJM GKENGHGOOOF);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool JABMDCHHMKH);
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
