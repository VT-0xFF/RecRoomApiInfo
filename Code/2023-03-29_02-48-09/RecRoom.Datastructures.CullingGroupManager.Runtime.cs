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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, LCPJFIPJNDD
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class AHPEEAINPLH<T> : KDDOHJLCNJE, global::OPIOPHIJFNH<T>, FOGLMEFJINH where T : class, KJGOLDGANAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2C338D0", Offset = "0x2C326D0", VA = "0x182C338D0")]
			internal AHPEEAINPLH(int AMNNMHKPGOJ, float[] BCHHFMLPFBK, CMAHJNDEONI DEDCPEPAEMK = CMAHJNDEONI.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2C33800", Offset = "0x2C32600", VA = "0x182C33800", Slot = "15")]
			public void AHKNMMEAEHA(T BLIKPCIFNNO, float LMNMELDDGEE, PFBDEHOAOJI ILONCAIAOBN = PFBDEHOAOJI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2C337D0", Offset = "0x2C325D0", VA = "0x182C337D0", Slot = "16")]
			public void AHKNMMEAEHA(T BLIKPCIFNNO, Transform NANPHKJNMMM, float LMNMELDDGEE, PFBDEHOAOJI ILONCAIAOBN = PFBDEHOAOJI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2C33870", Offset = "0x2C32670", VA = "0x182C33870", Slot = "17")]
			public void IDPNBDBOEHK(T BLIKPCIFNNO, [Optional] float? LMNMELDDGEE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2C33890", Offset = "0x2C32690", VA = "0x182C33890", Slot = "18")]
			public void IHKCCNMHHEB(T CHLFBEGLOKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2C33850", Offset = "0x2C32650", VA = "0x182C33850", Slot = "19")]
			public EHKPJAMPICF EMILEILHGAN(T BLIKPCIFNNO)
			{
				return default(EHKPJAMPICF);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2C338B0", Offset = "0x2C326B0", VA = "0x182C338B0", Slot = "20")]
			public bool KBAOKKDEAPL(T BLIKPCIFNNO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2C33830", Offset = "0x2C32630", VA = "0x182C33830", Slot = "21")]
			public void BOFDIKHLAJO(T BLIKPCIFNNO, PFBDEHOAOJI GACJLIBPAEJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class KDDOHJLCNJE : IDisposable, FOGLMEFJINH
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum CMAHJNDEONI : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class OMJPLDDJBDE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public KJGOLDGANAL BLCJDOLCLLF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public PFBDEHOAOJI CHJPDJGKHNH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action NHDDIKKBFNE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool LDDKOBEKGDD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int HGGIJKLHICO;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
				public OMJPLDDJBDE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class FOKAIKLNHGO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public KDDOHJLCNJE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public OMJPLDDJBDE trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
				public FOKAIKLNHGO()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int HIKGPHFCGML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int AMNNMHKPGOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int GCCDCLBLDEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool JFHKLPCKLKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup ILANHAJICNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] CPOOFHGPHLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] EJGAONAHHIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly HMKFNPDOEEN JPLBGCKPACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<KJGOLDGANAL, int> OLCCMBEIPNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, OMJPLDDJBDE> BMPKKHJDMHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly CMAHJNDEONI DEDCPEPAEMK;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int EECKKOJIPKE
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x6DA060", Offset = "0x6D8E60", VA = "0x1806DA060", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int BJKKLPOKJNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x768420", Offset = "0x767220", VA = "0x180768420", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x65F1AA0", Offset = "0x65F08A0", VA = "0x1865F1AA0")]
			internal KDDOHJLCNJE(int AMNNMHKPGOJ, float[] BCHHFMLPFBK, CMAHJNDEONI DEDCPEPAEMK = CMAHJNDEONI.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x65F12A0", Offset = "0x65F00A0", VA = "0x1865F12A0")]
			public void INFGOKLIMGJ(bool KJPLGDJNFFI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x65F18B0", Offset = "0x65F06B0", VA = "0x1865F18B0", Slot = "7")]
			public EHKPJAMPICF LOLMJDBDPBE(float HMDHBIIBBJG)
			{
				return default(EHKPJAMPICF);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x65EFA40", Offset = "0x65EE840", VA = "0x1865EFA40", Slot = "8")]
			public void AHKNMMEAEHA(KJGOLDGANAL BLIKPCIFNNO, float LMNMELDDGEE, PFBDEHOAOJI ILONCAIAOBN = PFBDEHOAOJI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x65EFAD0", Offset = "0x65EE8D0", VA = "0x1865EFAD0", Slot = "9")]
			public void AHKNMMEAEHA(KJGOLDGANAL BLIKPCIFNNO, Transform NANPHKJNMMM, float LMNMELDDGEE, PFBDEHOAOJI ILONCAIAOBN = PFBDEHOAOJI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x65F1430", Offset = "0x65F0230", VA = "0x1865F1430")]
			public void JFPBPEAAHKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x65F0DF0", Offset = "0x65EFBF0", VA = "0x1865F0DF0", Slot = "10")]
			public void IDPNBDBOEHK(KJGOLDGANAL BLIKPCIFNNO, [Optional] float? LMNMELDDGEE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x65F12D0", Offset = "0x65F00D0", VA = "0x1865F12D0")]
			private void JABGCNHNDDL(int CPOAAGLEIPE, [Optional] float? LMNMELDDGEE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x65F0E70", Offset = "0x65EFC70", VA = "0x1865F0E70", Slot = "11")]
			public void IHKCCNMHHEB(KJGOLDGANAL CHLFBEGLOKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x65F08B0", Offset = "0x65EF6B0", VA = "0x1865F08B0", Slot = "12")]
			public EHKPJAMPICF EMILEILHGAN(KJGOLDGANAL BLIKPCIFNNO)
			{
				return default(EHKPJAMPICF);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x65F1620", Offset = "0x65F0420", VA = "0x1865F1620", Slot = "13")]
			public bool KBAOKKDEAPL(KJGOLDGANAL BLIKPCIFNNO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x65F01E0", Offset = "0x65EEFE0", VA = "0x1865F01E0", Slot = "14")]
			public void BOFDIKHLAJO(KJGOLDGANAL BLIKPCIFNNO, PFBDEHOAOJI CCHGJEGKEBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x65F0610", Offset = "0x65EF410", VA = "0x1865F0610", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x65F0A30", Offset = "0x65EF830", VA = "0x1865F0A30")]
			private void HNHLKHKBAND(OMJPLDDJBDE BNGCOIPLDEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x65EFF20", Offset = "0x65EED20", VA = "0x1865EFF20")]
			private void ALCGHHODJJJ(OMJPLDDJBDE BNGCOIPLDEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x65F15B0", Offset = "0x65F03B0", VA = "0x1865F15B0")]
			private void JICDHEOLILJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x65F09C0", Offset = "0x65EF7C0", VA = "0x1865F09C0")]
			private void FEIJEMHJPHB(float IHHMNHHHHPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x65F01B0", Offset = "0x65EEFB0", VA = "0x1865F01B0")]
			private void BDKOJFNEAGE(OMJPLDDJBDE BNGCOIPLDEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x65F1A90", Offset = "0x65F0890", VA = "0x1865F1A90")]
			private void PKCAPJLMMKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x65F1720", Offset = "0x65F0520", VA = "0x1865F1720")]
			private void KOGHPOKJBDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x65F02D0", Offset = "0x65EF0D0", VA = "0x1865F02D0")]
			private void CBPJCJPMCKA(CullingGroupEvent LLLFMPNLGNN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x65F1730", Offset = "0x65F0530", VA = "0x1865F1730")]
			private void LKFJOCIKGMD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct FOPFMJLKPJH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort KMJKBFMBMHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type OIFKFKOEONG;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float POEEGJPLBFA = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float AOJKDHIMEJJ = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float JFOMNBGBNGK = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float IGCHCIMMIPJ = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float FDDPPCHFLMC = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float HNHOBKPKONM = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float JKDPLEBMGFM = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<FOPFMJLKPJH, KDDOHJLCNJE> IHJMDGNLEMC;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable BDKDFBPKFKJ;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable EJCIEKMFIJG;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static CPHLPGCHIIP MGDMGDOHNGN;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static CPHLPGCHIIP HPAKEGPALOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly CPHLPGCHIIP PBLFCMBEDPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly CPHLPGCHIIP PJGNIFJBAFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly CPHLPGCHIIP OJGNDCOBMBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private OMJDCAMIDEI AEDEOEMINFH;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool KJPLGDJNFFI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public CPHLPGCHIIP MIEBBBIBGGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public CPHLPGCHIIP GJDABOBHKPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CPHLPGCHIIP NEJLBAONGJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JDKKPKNDJHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x10B0690", Offset = "0x10AF490", VA = "0x1810B0690", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool ODKLDFKOGBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x894FC0", Offset = "0x893DC0", VA = "0x180894FC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x944F40", Offset = "0x943D40", VA = "0x180944F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x65EE670", Offset = "0x65ED470", VA = "0x1865EE670", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x13E4C00", Offset = "0x13E3A00", VA = "0x1813E4C00")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x65EEF70", Offset = "0x65EDD70", VA = "0x1865EEF70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x65EE740", Offset = "0x65ED540", VA = "0x1865EE740")]
		private void CGIMDJEGOHN(Scene LJBGPBIAJII, LoadSceneMode FOMLKLNHMAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x65EEE90", Offset = "0x65EDC90", VA = "0x1865EEE90", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x65EF1C0", Offset = "0x65EDFC0", VA = "0x1865EF1C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x65EECD0", Offset = "0x65EDAD0", VA = "0x1865EECD0")]
		private void HPIHOLMOELE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x65EEF90", Offset = "0x65EDD90", VA = "0x1865EEF90")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x65EE4F0", Offset = "0x65ED2F0", VA = "0x1865EE4F0")]
		private void AFJNNPNPGEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x65EEAE0", Offset = "0x65ED8E0", VA = "0x1865EEAE0")]
		public FOGLMEFJINH GetOrCreateCullingGroup(Type JHPEMAPOJLO, int JFCCAABGDBO, ushort KNLJIJLOBFI = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x26A2F80", Offset = "0x26A1D80", VA = "0x1826A2F80")]
		public global::OPIOPHIJFNH<T> GetOrCreateCullingGroup<T>(int JFCCAABGDBO, ushort KNLJIJLOBFI = 0) where T : class, KJGOLDGANAL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x65EE7A0", Offset = "0x65ED5A0", VA = "0x1865EE7A0")]
		private FOGLMEFJINH DGDNJLPPONM(Type JHPEMAPOJLO, int JFCCAABGDBO, float[] BCHHFMLPFBK, ushort KNLJIJLOBFI = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x26A2D50", Offset = "0x26A1B50", VA = "0x1826A2D50")]
		private global::OPIOPHIJFNH<T> DGDNJLPPONM<T>(int JFCCAABGDBO, float[] BCHHFMLPFBK, ushort KNLJIJLOBFI = 0) where T : class, KJGOLDGANAL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x65EE940", Offset = "0x65ED740", VA = "0x1865EE940")]
		public static EHKPJAMPICF FindClosestDefaultUpdateLod(float IOKEFBDHOCA)
		{
			return default(EHKPJAMPICF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x65EEE80", Offset = "0x65EDC80", VA = "0x1865EEE80")]
		public static EHKPJAMPICF MinUpdateLod(EHKPJAMPICF HHEPLLIAHEI, EHKPJAMPICF CGBFEIEACOM)
		{
			return default(EHKPJAMPICF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x65EEE70", Offset = "0x65EDC70", VA = "0x1865EEE70")]
		public static EHKPJAMPICF MaxUpdateLod(EHKPJAMPICF HHEPLLIAHEI, EHKPJAMPICF CGBFEIEACOM)
		{
			return default(EHKPJAMPICF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x65EF5F0", Offset = "0x65EE3F0", VA = "0x1865EF5F0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HMKFNPDOEEN
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool NOFPCLMPBED
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera BDFCGNFHHDI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	CPHLPGCHIIP GLIFOAIFAJK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool BMKPAKBAMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CPHLPGCHIIP ODJEDLIEEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform PKJAAIAJDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FOGLMEFJINH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int EECKKOJIPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int BJKKLPOKJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EHKPJAMPICF LOLMJDBDPBE(float HMDHBIIBBJG);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AHKNMMEAEHA(KJGOLDGANAL BLIKPCIFNNO, float LMNMELDDGEE, PFBDEHOAOJI ILONCAIAOBN = PFBDEHOAOJI.Off);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AHKNMMEAEHA(KJGOLDGANAL BLIKPCIFNNO, Transform NANPHKJNMMM, float LMNMELDDGEE, PFBDEHOAOJI ILONCAIAOBN = PFBDEHOAOJI.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IDPNBDBOEHK(KJGOLDGANAL BLIKPCIFNNO, [Optional] float? LMNMELDDGEE);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IHKCCNMHHEB(KJGOLDGANAL CHLFBEGLOKO);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EHKPJAMPICF EMILEILHGAN(KJGOLDGANAL BLIKPCIFNNO);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KBAOKKDEAPL(KJGOLDGANAL BLIKPCIFNNO);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BOFDIKHLAJO(KJGOLDGANAL BLIKPCIFNNO, PFBDEHOAOJI GACJLIBPAEJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OPIOPHIJFNH<T> : FOGLMEFJINH where T : class, KJGOLDGANAL
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHKNMMEAEHA(T BLIKPCIFNNO, float LMNMELDDGEE, PFBDEHOAOJI ILONCAIAOBN = PFBDEHOAOJI.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AHKNMMEAEHA(T BLIKPCIFNNO, Transform NANPHKJNMMM, float LMNMELDDGEE, PFBDEHOAOJI ILONCAIAOBN = PFBDEHOAOJI.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IDPNBDBOEHK(T BLIKPCIFNNO, [Optional] float? LMNMELDDGEE);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IHKCCNMHHEB(T CHLFBEGLOKO);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EHKPJAMPICF EMILEILHGAN(T BLIKPCIFNNO);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KBAOKKDEAPL(T BLIKPCIFNNO);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BOFDIKHLAJO(T BLIKPCIFNNO, PFBDEHOAOJI GACJLIBPAEJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KJGOLDGANAL
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform GPMKACFJLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(EHKPJAMPICF EAIGOHNOLND, EHKPJAMPICF EPFAGMFKNJK);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool CBNEFALBIGO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum PFBDEHOAOJI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum EHKPJAMPICF
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
public class EFLEBOOPJEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EHKPJAMPICF FEFPPFDPNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EHKPJAMPICF PEEJGOJECJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, EHKPJAMPICF> FFHNABBKFII;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool LLIGIPPHBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x65EF930", Offset = "0x65EE730", VA = "0x1865EF930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public EHKPJAMPICF GPNAFNDCCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6DA060", Offset = "0x6D8E60", VA = "0x1806DA060")]
		get
		{
			return default(EHKPJAMPICF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public EHKPJAMPICF CPCNNHGGOJL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x768420", Offset = "0x767220", VA = "0x180768420")]
		get
		{
			return default(EHKPJAMPICF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x65EF860", Offset = "0x65EE660", VA = "0x1865EF860")]
	public bool LLJCPJLNFOC(object INDCJAMMAIN, EHKPJAMPICF NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x65EF8D0", Offset = "0x65EE6D0", VA = "0x1865EF8D0")]
	public bool MIHAOOFDKCE(object INDCJAMMAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x65EF700", Offset = "0x65EE500", VA = "0x1865EF700")]
	private bool DFGDFEDNHLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x65EF980", Offset = "0x65EE780", VA = "0x1865EF980")]
	public EFLEBOOPJEH()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KNPJDABNJNB
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] KJPEJCPNACN;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int ENGDLONOMNK;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int IBOHBKOLMLK;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger BMOFNNOLMPE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KNPJDABNJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x65F1E60", Offset = "0x65F0C60", VA = "0x1865F1E60")]
	private static string NKHPLDDEAIA(byte[] MIECAKFJHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x65F1F70", Offset = "0x65F0D70", VA = "0x1865F1F70")]
	public static string OEIELDLCBEJ(byte[] NJGGJPEFKKD, bool NCDJBNMKDFA)
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
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
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
