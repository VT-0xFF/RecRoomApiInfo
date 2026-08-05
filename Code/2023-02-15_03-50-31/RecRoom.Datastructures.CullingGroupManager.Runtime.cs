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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, CJEOAEENBFH
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class AHHECAMKNEA<T> : GLMANGGAKEA, global::LGFCHNHAJIC<T>, GNJJFOIGADA where T : class, NLJGMJFEGHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x343A410", Offset = "0x3439810", VA = "0x18343A410")]
			internal AHHECAMKNEA(int ENBEIGKNPHC, float[] HDMBPFICEBH, NCANBEBGANL DHLHPBCHEGA = NCANBEBGANL.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x343A340", Offset = "0x3439740", VA = "0x18343A340", Slot = "15")]
			public void AOHLLDNPMGN(T ADHHHFDPAPI, float IOOOOANBPPM, JANFPIDCDOK FHMBIDJAKMP = JANFPIDCDOK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x343A310", Offset = "0x3439710", VA = "0x18343A310", Slot = "16")]
			public void AOHLLDNPMGN(T ADHHHFDPAPI, Transform LKCKBCPKEGI, float IOOOOANBPPM, JANFPIDCDOK FHMBIDJAKMP = JANFPIDCDOK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x343A3B0", Offset = "0x34397B0", VA = "0x18343A3B0", Slot = "17")]
			public void JGKKHFDLFAG(T ADHHHFDPAPI, [Optional] float? IOOOOANBPPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x343A370", Offset = "0x3439770", VA = "0x18343A370", Slot = "18")]
			public void BCBAFCFKBLF(T BNCCAIGLJMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x343A3D0", Offset = "0x34397D0", VA = "0x18343A3D0", Slot = "19")]
			public LHLIDFNIOKA JJNDGAOIAGC(T ADHHHFDPAPI)
			{
				return default(LHLIDFNIOKA);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x343A390", Offset = "0x3439790", VA = "0x18343A390", Slot = "20")]
			public bool FOGOPKKNGDH(T ADHHHFDPAPI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x343A3F0", Offset = "0x34397F0", VA = "0x18343A3F0", Slot = "21")]
			public void OALFIIGCDLA(T ADHHHFDPAPI, JANFPIDCDOK PHDHCKKFDCD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class GLMANGGAKEA : IDisposable, GNJJFOIGADA
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum NCANBEBGANL : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class LBPBLBEKABI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public NLJGMJFEGHJ MAEACMMEJHE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public JANFPIDCDOK HIICCAKKBFE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action CILINLCEKKO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool EBEAHJPFGFL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int ICGLEEKOOLJ;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
				public LBPBLBEKABI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class PJAGAPHMJAK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public GLMANGGAKEA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public LBPBLBEKABI trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
				public PJAGAPHMJAK()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int MDCLIKLNOHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int ENBEIGKNPHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int LKPMBDDHJLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool NPIEAKJHFPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup OBNDLFADEDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] AHDOMAFOBBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] BKCFAJLIINE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly EJEEAGEIPJL FGFPMOHFMOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<NLJGMJFEGHJ, int> AGONEENOCKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, LBPBLBEKABI> BMCFPMOJAMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly NCANBEBGANL DHLHPBCHEGA;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int EALBEJPBCLD
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int AGNLBCICLAP
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x7532A0", Offset = "0x7526A0", VA = "0x1807532A0", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6459320", Offset = "0x6458720", VA = "0x186459320")]
			internal GLMANGGAKEA(int ENBEIGKNPHC, float[] HDMBPFICEBH, NCANBEBGANL DHLHPBCHEGA = NCANBEBGANL.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6459280", Offset = "0x6458680", VA = "0x186459280")]
			public void PGBOHNLAPOF(bool KHOBADBEHGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6458170", Offset = "0x6457570", VA = "0x186458170", Slot = "7")]
			public LHLIDFNIOKA ELBEDJHIGFE(float KINGLLIJCOO)
			{
				return default(LHLIDFNIOKA);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6457890", Offset = "0x6456C90", VA = "0x186457890", Slot = "8")]
			public void AOHLLDNPMGN(NLJGMJFEGHJ ADHHHFDPAPI, float IOOOOANBPPM, JANFPIDCDOK FHMBIDJAKMP = JANFPIDCDOK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6457440", Offset = "0x6456840", VA = "0x186457440", Slot = "9")]
			public void AOHLLDNPMGN(NLJGMJFEGHJ ADHHHFDPAPI, Transform LKCKBCPKEGI, float IOOOOANBPPM, JANFPIDCDOK FHMBIDJAKMP = JANFPIDCDOK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x64572C0", Offset = "0x64566C0", VA = "0x1864572C0")]
			public void ADMNAJNMMKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6458A40", Offset = "0x6457E40", VA = "0x186458A40", Slot = "10")]
			public void JGKKHFDLFAG(NLJGMJFEGHJ ADHHHFDPAPI, [Optional] float? IOOOOANBPPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6458C40", Offset = "0x6458040", VA = "0x186458C40")]
			private void LAECJKKELEG(int BELCAJFDAHD, [Optional] float? IOOOOANBPPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6457920", Offset = "0x6456D20", VA = "0x186457920", Slot = "11")]
			public void BCBAFCFKBLF(NLJGMJFEGHJ BNCCAIGLJMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6458AC0", Offset = "0x6457EC0", VA = "0x186458AC0", Slot = "12")]
			public LHLIDFNIOKA JJNDGAOIAGC(NLJGMJFEGHJ ADHHHFDPAPI)
			{
				return default(LHLIDFNIOKA);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6458350", Offset = "0x6457750", VA = "0x186458350", Slot = "13")]
			public bool FOGOPKKNGDH(NLJGMJFEGHJ ADHHHFDPAPI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6458DD0", Offset = "0x64581D0", VA = "0x186458DD0", Slot = "14")]
			public void OALFIIGCDLA(NLJGMJFEGHJ ADHHHFDPAPI, JANFPIDCDOK HJFEJJPMHAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6457ED0", Offset = "0x64572D0", VA = "0x186457ED0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6458EC0", Offset = "0x64582C0", VA = "0x186458EC0")]
			private void OEIAJBOMJPA(LBPBLBEKABI LHJJDAFHLGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x64587B0", Offset = "0x6457BB0", VA = "0x1864587B0")]
			private void HOBMLHFHDAI(LBPBLBEKABI LHJJDAFHLGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x64592B0", Offset = "0x64586B0", VA = "0x1864592B0")]
			private void PLIGFJHANAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6458BD0", Offset = "0x6457FD0", VA = "0x186458BD0")]
			private void KKNPLAJMBAL(float KLCEDMFFMFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6458DA0", Offset = "0x64581A0", VA = "0x186458DA0")]
			private void LJOJMCHPDKE(LBPBLBEKABI LHJJDAFHLGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6458460", Offset = "0x6457860", VA = "0x186458460")]
			private void GLMKNEFADFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6458450", Offset = "0x6457850", VA = "0x186458450")]
			private void GFLAOFHPIEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6458470", Offset = "0x6457870", VA = "0x186458470")]
			private void HLBNJOPNBCC(CullingGroupEvent AGHIFFICEAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6457D50", Offset = "0x6457150", VA = "0x186457D50")]
			private void BOMACMGHEBD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct JLAKIFKAABM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort AJPJCDILNKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type PAEIINAFIOI;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float CLBIODFBIKD = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float OIEDLDFKLBE = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float FHFDOEOFHNC = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float CAGJJJDBBDK = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float OLKNFCMNAAA = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float ACMMOFGLFIM = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float FNECMGHBAIA = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<JLAKIFKAABM, GLMANGGAKEA> AENAFKBPDAK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable HBMHAIHBCNF;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable DKMLIGONNAL;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static CBKLEJNNKJH FKHCFFOEMOD;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static CBKLEJNNKJH KGLAKBNHJOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly CBKLEJNNKJH CALMBHCIGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly CBKLEJNNKJH ICGCJJFCKDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly CBKLEJNNKJH FMOOJLPPGNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EJCEALCEAGN BKFKAIEBJKJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool KHOBADBEHGJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public CBKLEJNNKJH LJEKCMNFNGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public CBKLEJNNKJH EDKJDALHGKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6E4130", Offset = "0x6E3530", VA = "0x1806E4130", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CBKLEJNNKJH GDBBPGDKHLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool ILPPLEOINLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x15801F0", Offset = "0x157F5F0", VA = "0x1815801F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool LHGDJOBKBKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x77F530", Offset = "0x77E930", VA = "0x18077F530", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9C88F0", Offset = "0x9C7CF0", VA = "0x1809C88F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6455780", Offset = "0x6454B80", VA = "0x186455780", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F1E090", Offset = "0x1F1D490", VA = "0x181F1E090")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6456200", Offset = "0x6455600", VA = "0x186456200")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x64560A0", Offset = "0x64554A0", VA = "0x1864560A0")]
		private void LIGKPAICFIL(Scene BGCBBDJLHHN, LoadSceneMode PDGDINPCGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6456120", Offset = "0x6455520", VA = "0x186456120", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6456450", Offset = "0x6455850", VA = "0x186456450")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6455850", Offset = "0x6454C50", VA = "0x186455850")]
		private void EHHCCCCKBEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6456220", Offset = "0x6455620", VA = "0x186456220")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x64559F0", Offset = "0x6454DF0", VA = "0x1864559F0")]
		private void FOPALBAGIBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6455D10", Offset = "0x6455110", VA = "0x186455D10")]
		public GNJJFOIGADA GetOrCreateCullingGroup(Type KKPMDCKKDLJ, int IPGEHEJOGGI, ushort EIKDBCLGGON = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2C433E0", Offset = "0x2C427E0", VA = "0x182C433E0")]
		public global::LGFCHNHAJIC<T> GetOrCreateCullingGroup<T>(int IPGEHEJOGGI, ushort EIKDBCLGGON = 0) where T : class, NLJGMJFEGHJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6455F00", Offset = "0x6455300", VA = "0x186455F00")]
		private GNJJFOIGADA JJJBOPMPOCL(Type KKPMDCKKDLJ, int IPGEHEJOGGI, float[] HDMBPFICEBH, ushort EIKDBCLGGON = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2C43490", Offset = "0x2C42890", VA = "0x182C43490")]
		private global::LGFCHNHAJIC<T> JJJBOPMPOCL<T>(int IPGEHEJOGGI, float[] HDMBPFICEBH, ushort EIKDBCLGGON = 0) where T : class, NLJGMJFEGHJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6455B70", Offset = "0x6454F70", VA = "0x186455B70")]
		public static LHLIDFNIOKA FindClosestDefaultUpdateLod(float IEDAJFGALFD)
		{
			return default(LHLIDFNIOKA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6456110", Offset = "0x6455510", VA = "0x186456110")]
		public static LHLIDFNIOKA MinUpdateLod(LHLIDFNIOKA HJGNFNEOPOD, LHLIDFNIOKA CMFNGEOOPOE)
		{
			return default(LHLIDFNIOKA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6456100", Offset = "0x6455500", VA = "0x186456100")]
		public static LHLIDFNIOKA MaxUpdateLod(LHLIDFNIOKA HJGNFNEOPOD, LHLIDFNIOKA CMFNGEOOPOE)
		{
			return default(LHLIDFNIOKA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6456880", Offset = "0x6455C80", VA = "0x186456880")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EJEEAGEIPJL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool ICNHACLOBEN
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera CNPMKIDFCLF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	CBKLEJNNKJH ABACHLIENJK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool MPMLCNIFDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CBKLEJNNKJH AMMKFHGLOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform MCBNNJJLNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GNJJFOIGADA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int EALBEJPBCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int AGNLBCICLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LHLIDFNIOKA ELBEDJHIGFE(float KINGLLIJCOO);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AOHLLDNPMGN(NLJGMJFEGHJ ADHHHFDPAPI, float IOOOOANBPPM, JANFPIDCDOK FHMBIDJAKMP = JANFPIDCDOK.Off);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AOHLLDNPMGN(NLJGMJFEGHJ ADHHHFDPAPI, Transform LKCKBCPKEGI, float IOOOOANBPPM, JANFPIDCDOK FHMBIDJAKMP = JANFPIDCDOK.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JGKKHFDLFAG(NLJGMJFEGHJ ADHHHFDPAPI, [Optional] float? IOOOOANBPPM);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BCBAFCFKBLF(NLJGMJFEGHJ BNCCAIGLJMO);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LHLIDFNIOKA JJNDGAOIAGC(NLJGMJFEGHJ ADHHHFDPAPI);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FOGOPKKNGDH(NLJGMJFEGHJ ADHHHFDPAPI);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OALFIIGCDLA(NLJGMJFEGHJ ADHHHFDPAPI, JANFPIDCDOK PHDHCKKFDCD);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LGFCHNHAJIC<T> : GNJJFOIGADA where T : class, NLJGMJFEGHJ
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOHLLDNPMGN(T ADHHHFDPAPI, float IOOOOANBPPM, JANFPIDCDOK FHMBIDJAKMP = JANFPIDCDOK.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOHLLDNPMGN(T ADHHHFDPAPI, Transform LKCKBCPKEGI, float IOOOOANBPPM, JANFPIDCDOK FHMBIDJAKMP = JANFPIDCDOK.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGKKHFDLFAG(T ADHHHFDPAPI, [Optional] float? IOOOOANBPPM);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BCBAFCFKBLF(T BNCCAIGLJMO);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LHLIDFNIOKA JJNDGAOIAGC(T ADHHHFDPAPI);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FOGOPKKNGDH(T ADHHHFDPAPI);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OALFIIGCDLA(T ADHHHFDPAPI, JANFPIDCDOK PHDHCKKFDCD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NLJGMJFEGHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform LJLOGOIJMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(LHLIDFNIOKA ELKALKBOHEP, LHLIDFNIOKA LBONJHPGLEG);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool HFPGMHEIJMF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum JANFPIDCDOK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum LHLIDFNIOKA
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
public class EIGJECJFIOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private LHLIDFNIOKA LOOCNKEBNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private LHLIDFNIOKA KLDHGDMNHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, LHLIDFNIOKA> KBKLNMADCJP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool EPILLKKPCLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6456FC0", Offset = "0x64563C0", VA = "0x186456FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public LHLIDFNIOKA GAKJFJCBCDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060")]
		get
		{
			return default(LHLIDFNIOKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public LHLIDFNIOKA MFFALMHKPHC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7532A0", Offset = "0x7526A0", VA = "0x1807532A0")]
		get
		{
			return default(LHLIDFNIOKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6457170", Offset = "0x6456570", VA = "0x186457170")]
	public bool NGEDLHPEMJP(object AJDBKDIMOHA, LHLIDFNIOKA JFBPNBNBHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x64571E0", Offset = "0x64565E0", VA = "0x1864571E0")]
	public bool NPEEJGJDMJO(object AJDBKDIMOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6457010", Offset = "0x6456410", VA = "0x186457010")]
	private bool JGJPMNGAMEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6457240", Offset = "0x6456640", VA = "0x186457240")]
	public EIGJECJFIOL()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6456990", Offset = "0x6455D90", VA = "0x186456990")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6456AA0", Offset = "0x6455EA0", VA = "0x186456AA0")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
