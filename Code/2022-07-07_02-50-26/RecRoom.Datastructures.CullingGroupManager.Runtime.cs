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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, OECBFFHHMBC
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private abstract class NCFNILHCBAN : IDisposable, ANHMFHJPILI
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public abstract int BCJNGJNAKFA
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(Slot = "8")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public abstract int MAEGIHAEBJC
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(Slot = "9")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void Dispose();

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void ILPCEEIGNMH(bool LNJOIIFGAOD);

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
			protected NCFNILHCBAN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class NIFAGJLMBPD<T> : NCFNILHCBAN, global::IHEOOAOJALG<T>, ANHMFHJPILI where T : ADLPAELKFOK
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum LMNIDHMBEBB : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class GBOGBNLKFPG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public T FPCPKPBGFCM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public FIGHCOAOLEE JEIOKLBPMFH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action PIAIBKPCING;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool IKMBKCJOBGP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int AJKNHICCIOI;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
				public GBOGBNLKFPG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class ELFEFHPFIKN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public NIFAGJLMBPD<T> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public GBOGBNLKFPG trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
				public ELFEFHPFIKN()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int HCKEHHJMBLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int KEEPIGHNMOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int HBHOFKMBJKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool HNFBEGJGFGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup NPGGCAOPKII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] FANFJDHOMFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] ALPOBMABCCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly HFABLLIEKOB KJIJKIGPLNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<T, int> IOMLJPILFEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, GBOGBNLKFPG> CEKBBJIAFDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly LMNIDHMBEBB LBOEFNNOFOA;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public override int BCJNGJNAKFA
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x58AED0", Offset = "0x58A0D0", VA = "0x18058AED0", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int MAEGIHAEBJC
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x5AE710", Offset = "0x5AD910", VA = "0x1805AE710", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1F91890", Offset = "0x1F90A90", VA = "0x181F91890")]
			internal NIFAGJLMBPD(int KEEPIGHNMOL, float[] MINLHHDHOCO, LMNIDHMBEBB LBOEFNNOFOA = LMNIDHMBEBB.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1F912A0", Offset = "0x1F904A0", VA = "0x181F912A0", Slot = "10")]
			public override void ILPCEEIGNMH(bool LNJOIIFGAOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1F8FAF0", Offset = "0x1F8ECF0", VA = "0x181F8FAF0", Slot = "11")]
			public BGEFEKIICHP BDEPLJGOMBI(float INHPMCHJNDB)
			{
				return default(BGEFEKIICHP);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1F90870", Offset = "0x1F8FA70", VA = "0x181F90870", Slot = "12")]
			public void FKEGKEHNDJG(T ANFJLMLDELH, float EBBHGKHKOFO, FIGHCOAOLEE GILMLJMHFIG = FIGHCOAOLEE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1F90910", Offset = "0x1F8FB10", VA = "0x181F90910", Slot = "13")]
			public void FKEGKEHNDJG(T ANFJLMLDELH, Transform IAEDKFPONDF, float EBBHGKHKOFO, FIGHCOAOLEE GILMLJMHFIG = FIGHCOAOLEE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1F91420", Offset = "0x1F90620", VA = "0x181F91420", Slot = "14")]
			public void NKCONCAEPNF(T ANFJLMLDELH, [Optional] float? EBBHGKHKOFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1F91720", Offset = "0x1F90920", VA = "0x181F91720")]
			private void PDPHIOJDAHA(int OHJLAHMBLMG, [Optional] float? EBBHGKHKOFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1F8FDD0", Offset = "0x1F8EFD0", VA = "0x181F8FDD0", Slot = "15")]
			public void CDCPBPNLMGM(T MECBIPNLLCG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1F91180", Offset = "0x1F90380", VA = "0x181F91180", Slot = "16")]
			public BGEFEKIICHP IGOMGGBAMIK(T ANFJLMLDELH)
			{
				return default(BGEFEKIICHP);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1F912F0", Offset = "0x1F904F0", VA = "0x181F912F0", Slot = "17")]
			public bool KNLPFOIOFEN(T ANFJLMLDELH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1F91610", Offset = "0x1F90810", VA = "0x181F91610", Slot = "18")]
			public void ONHKABPAELC(T ANFJLMLDELH, FIGHCOAOLEE MAEACPBODOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1F904F0", Offset = "0x1F8F6F0", VA = "0x181F904F0", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1F90DD0", Offset = "0x1F8FFD0", VA = "0x181F90DD0")]
			private void GLJBGONENIM(GBOGBNLKFPG KIMAKPODIEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1F8FB50", Offset = "0x1F8ED50", VA = "0x181F8FB50")]
			private void BHPHCFMECDN(GBOGBNLKFPG KIMAKPODIEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1F90480", Offset = "0x1F8F680", VA = "0x181F90480")]
			private void DGLCPKAOFBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1F8FA80", Offset = "0x1F8EC80", VA = "0x181F8FA80")]
			private void AJBEJOLOOBE(float DEPDIALJLNJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1F90D90", Offset = "0x1F8FF90", VA = "0x181F90D90")]
			private void FPIMPFPGIKL(GBOGBNLKFPG KIMAKPODIEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1F912D0", Offset = "0x1F904D0", VA = "0x181F912D0")]
			private void JFNAEKFHMPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1F913F0", Offset = "0x1F905F0", VA = "0x181F913F0")]
			private void MPCIPJPKOIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1F90170", Offset = "0x1F8F370", VA = "0x181F90170")]
			private void DCGEPECBIHK(CullingGroupEvent NGMDBFBAHKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x1F914A0", Offset = "0x1F906A0", VA = "0x181F914A0")]
			private void NPCDIBPECAH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct DNMHKHGOEHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort KEDHOOOMGDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type KDDAEJOKDMP;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float OGAGNEJJGGI = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float GJAMLBOIGCI = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float NOCHBMJAEII = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float FONFOMEBEEE = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float FKFPDCPKJEB = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float NCDAKLANHDM = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float FKGLJGFKJLE = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<DNMHKHGOEHG, NCFNILHCBAN> PPBICHIDKHD;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable LIDCNPCALGC;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable EAOCNNDOKAA;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static COKNLFJLEMD OBEBILGCJFL;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static COKNLFJLEMD JGFBFJLLICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly COKNLFJLEMD JLOEBIGGGND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly COKNLFJLEMD KJJLJBDBMAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly COKNLFJLEMD IOGJMGMAFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private NOIGHMHHCPP ANODHGEJMGG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool LNJOIIFGAOD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public COKNLFJLEMD ABAPEMMBKFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public COKNLFJLEMD JFAJIOPNKGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x58CDF0", Offset = "0x58BFF0", VA = "0x18058CDF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public COKNLFJLEMD MBNFFFHMMGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5B30C0", Offset = "0x5B22C0", VA = "0x1805B30C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool KIAJKGJMBHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x14AF590", Offset = "0x14AE790", VA = "0x1814AF590", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool ALIJKFOJINP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x77BB70", Offset = "0x77AD70", VA = "0x18077BB70", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x77BBF0", Offset = "0x77ADF0", VA = "0x18077BBF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x51D9DA0", Offset = "0x51D8FA0", VA = "0x1851D9DA0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE5B3A0", Offset = "0xE5A5A0", VA = "0x180E5B3A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x51DA500", Offset = "0x51D9700", VA = "0x1851DA500")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x51D9E40", Offset = "0x51D9040", VA = "0x1851D9E40")]
		private void CHKLPKHJOCL(Scene DMOEDMBHLCJ, LoadSceneMode POGDHLEGDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x51DA450", Offset = "0x51D9650", VA = "0x1851DA450", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x51DA1F0", Offset = "0x51D93F0", VA = "0x1851DA1F0")]
		private void KJNGPKIIADO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x51DA520", Offset = "0x51D9720", VA = "0x1851DA520")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x51D9EA0", Offset = "0x51D90A0", VA = "0x1851D9EA0")]
		private void DKPGBONFPIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x208AA20", Offset = "0x2089C20", VA = "0x18208AA20")]
		public global::IHEOOAOJALG<T> GetOrCreateCullingGroup<T>(int MEGFOBMGBCP, ushort MDHPKPMJPCF = 0) where T : ADLPAELKFOK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x208AAD0", Offset = "0x2089CD0", VA = "0x18208AAD0")]
		private global::IHEOOAOJALG<T> KFPDNNELLLB<T>(int MEGFOBMGBCP, float[] MINLHHDHOCO, ushort MDHPKPMJPCF = 0) where T : ADLPAELKFOK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x51DA000", Offset = "0x51D9200", VA = "0x1851DA000")]
		public static BGEFEKIICHP FindClosestDefaultUpdateLod(float PGINBECKDHL)
		{
			return default(BGEFEKIICHP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x51DA3F0", Offset = "0x51D95F0", VA = "0x1851DA3F0")]
		public static BGEFEKIICHP MinUpdateLod(BGEFEKIICHP FKIOLKMJKDB, BGEFEKIICHP EJONPFGJOBH)
		{
			return default(BGEFEKIICHP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x51DA390", Offset = "0x51D9590", VA = "0x1851DA390")]
		public static BGEFEKIICHP MaxUpdateLod(BGEFEKIICHP FKIOLKMJKDB, BGEFEKIICHP EJONPFGJOBH)
		{
			return default(BGEFEKIICHP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x51DA8B0", Offset = "0x51D9AB0", VA = "0x1851DA8B0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HFABLLIEKOB
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool BIICDAGPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Camera BOPLJGKFAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	COKNLFJLEMD OAKBFFGPGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool LKOGAINGBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	COKNLFJLEMD AFHHJKELOOB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform MJECPHDFILI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ANHMFHJPILI
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int BCJNGJNAKFA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int MAEGIHAEBJC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IHEOOAOJALG<T> : ANHMFHJPILI where T : ADLPAELKFOK
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BGEFEKIICHP BDEPLJGOMBI(float INHPMCHJNDB);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKEGKEHNDJG(T ANFJLMLDELH, float EBBHGKHKOFO, FIGHCOAOLEE GILMLJMHFIG = FIGHCOAOLEE.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FKEGKEHNDJG(T ANFJLMLDELH, Transform IAEDKFPONDF, float EBBHGKHKOFO, FIGHCOAOLEE GILMLJMHFIG = FIGHCOAOLEE.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NKCONCAEPNF(T ANFJLMLDELH, [Optional] float? EBBHGKHKOFO);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CDCPBPNLMGM(T MECBIPNLLCG);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BGEFEKIICHP IGOMGGBAMIK(T ANFJLMLDELH);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KNLPFOIOFEN(T ANFJLMLDELH);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ONHKABPAELC(T ANFJLMLDELH, FIGHCOAOLEE EKNLMHJGDHA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ADLPAELKFOK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform ONMAEMJFLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(BGEFEKIICHP IPHIBDMJGJI, BGEFEKIICHP AAPIPPLIJDO);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool IMGOKHAJJDK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum FIGHCOAOLEE : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum BGEFEKIICHP
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
public class LKCNAHJNIGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private BGEFEKIICHP JMDBKFOJFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private BGEFEKIICHP ODILKOEGMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, BGEFEKIICHP> LGEKOINADPO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool OBMHLBFLKDK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x51DB170", Offset = "0x51DA370", VA = "0x1851DB170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public BGEFEKIICHP OKBLCKANNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x58AED0", Offset = "0x58A0D0", VA = "0x18058AED0")]
		get
		{
			return default(BGEFEKIICHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public BGEFEKIICHP NLGEHMMLCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5AE710", Offset = "0x5AD910", VA = "0x1805AE710")]
		get
		{
			return default(BGEFEKIICHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x51DAF90", Offset = "0x51DA190", VA = "0x1851DAF90")]
	public bool IAAHDADOJIB(object OLHNGKKAKIK, BGEFEKIICHP LDPMPDNIHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x51DB1C0", Offset = "0x51DA3C0", VA = "0x1851DB1C0")]
	public bool NCJLBJNOBLM(object OLHNGKKAKIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x51DB000", Offset = "0x51DA200", VA = "0x1851DB000")]
	private bool IKNPNEDHCNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x51DB220", Offset = "0x51DA420", VA = "0x1851DB220")]
	public LKCNAHJNIGF()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JABMDOENCKP
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] CDGDAHNLLDM;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int FDPMPGKGLAJ;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int LAEDHJMCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger CJEJEKHBKEN;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public JABMDOENCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x51DACD0", Offset = "0x51D9ED0", VA = "0x1851DACD0")]
	private static string DMHFLPDODAP(byte[] DLFOEJDCAKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x51DA9A0", Offset = "0x51D9BA0", VA = "0x1851DA9A0")]
	public static string AJIDJKNPAKB(byte[] NGIBJOEMFPL, bool MFLHBEHGGNL)
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
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
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
