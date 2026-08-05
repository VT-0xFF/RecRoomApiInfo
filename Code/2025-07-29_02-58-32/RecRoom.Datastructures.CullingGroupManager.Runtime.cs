using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Logging.Attributes;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Datastructures_CullingGroupManager_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x82BFAB0", Offset = "0x82BE4B0", VA = "0x1882BFAB0", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, LGLOFHNBLNN, DFEHPODJAJA
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[BurstCompile]
		private struct KBOCCNAAPCG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> GPCDCFCPGFK;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x82BFA30", Offset = "0x82BE430", VA = "0x1882BFA30", Slot = "4")]
			public void Execute(int FILGHJLFKAL, TransformAccess EOBBLENOIHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private struct ACIINLJPAHO : IEquatable<ACIINLJPAHO>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort GMIDHBONPBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type BABIKOFDCOI;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x82BC790", Offset = "0x82BB190", VA = "0x1882BC790", Slot = "4")]
			public bool Equals(ACIINLJPAHO EFNHKCDKOGH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x82BC6A0", Offset = "0x82BB0A0", VA = "0x1882BC6A0", Slot = "0")]
			public override bool Equals(object CEFJEHJNIAP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x82BC810", Offset = "0x82BB210", VA = "0x1882BC810", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class DBLKLKEJMHN<T> : CDEJNOLKEHK, AKOLAIIEOMA<T>, JCLKHJLKHJD where T : class, JGOGLEAHDPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6FEC810", Offset = "0x6FEB210", VA = "0x186FEC810")]
			internal DBLKLKEJMHN(int OEPEFJMHIIE, float[] NCAOLIPKNEJ, JBLGEDFMKNC EAPGKJAKPHO = JBLGEDFMKNC.PlayerHead, bool JAPHLEEIMBD = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6FEC7E0", Offset = "0x6FEB1E0", VA = "0x186FEC7E0", Slot = "12")]
			public void MJGPLOFFIKO(T CEFJEHJNIAP, float DLJDKOFPIMN, OGPMHIGIIEC FHFEHFNOMJA = OGPMHIGIIEC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6FEC7B0", Offset = "0x6FEB1B0", VA = "0x186FEC7B0", Slot = "13")]
			public void MJGPLOFFIKO(T CEFJEHJNIAP, Transform GKDABMHEJMG, float DLJDKOFPIMN, OGPMHIGIIEC FHFEHFNOMJA = OGPMHIGIIEC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6FEC770", Offset = "0x6FEB170", VA = "0x186FEC770", Slot = "14")]
			public void BBOPECIHIDA(T MAOHNDMONHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6FEC790", Offset = "0x6FEB190", VA = "0x186FEC790", Slot = "15")]
			public bool LOPJJGNOIJE(T CEFJEHJNIAP)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class CDEJNOLKEHK : IDisposable, JCLKHJLKHJD
		{
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			private struct DLALLIPJJHM
			{
				[Cpp2IlInjected.Token(Token = "0x2000009")]
				public enum BJNDOEFCLNK : byte
				{
					[Cpp2IlInjected.Token(Token = "0x4000031")]
					Add,
					[Cpp2IlInjected.Token(Token = "0x4000032")]
					UpdateRadius,
					[Cpp2IlInjected.Token(Token = "0x4000033")]
					UpdatePosition,
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					UpdateTrackRate,
					[Cpp2IlInjected.Token(Token = "0x4000035")]
					Remove
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public JGOGLEAHDPN KLFJJPNGIKE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform AMPAFLPNFEK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float JPIOKNBMLCE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public OGPMHIGIIEC EDDGAMALCBB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public BJNDOEFCLNK MMPEDFAPIKH;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public enum JBLGEDFMKNC : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class CONDKHJFEAL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public JGOGLEAHDPN KLFJJPNGIKE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public OGPMHIGIIEC GEAAGLBGCBM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action HPEELKFKIFM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool LCOPOMEJBGB;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
				public CONDKHJFEAL()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int DPLIGPEBLKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool JAPHLEEIMBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool JNAAJFKIBLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup NGKNAFBMGMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] CNOFGJOJAAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly COFLANOMENL JDNAAPNIDID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly JBLGEDFMKNC EAPGKJAKPHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<JGOGLEAHDPN, int> DGACODJHOCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, CONDKHJFEAL> KDKKBBINLHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray LNEEFIFGCBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> DMFNANKLLOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<DLALLIPJJHM> ICJNEGEPNLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool LHALPMOMKPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle HADFHMENAPG;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int EHNIOGMFLFA
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA84180", Offset = "0xA82B80", VA = "0x180A84180", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xA90060", Offset = "0xA8EA60", VA = "0x180A90060")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int FMLLKALAGNN
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xAD35E0", Offset = "0xAD1FE0", VA = "0x180AD35E0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB68BB0", Offset = "0xB675B0", VA = "0x180B68BB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x82BE110", Offset = "0x82BCB10", VA = "0x1882BE110")]
			internal CDEJNOLKEHK(int OEPEFJMHIIE, float[] NCAOLIPKNEJ, JBLGEDFMKNC EAPGKJAKPHO = JBLGEDFMKNC.PlayerHead, bool JAPHLEEIMBD = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x82BCEE0", Offset = "0x82BB8E0", VA = "0x1882BCEE0")]
			public void DKJIBMOHDHF(bool BNIIJGIOPCL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x82BD9D0", Offset = "0x82BC3D0", VA = "0x1882BD9D0", Slot = "5")]
			public void MJGPLOFFIKO(JGOGLEAHDPN CEFJEHJNIAP, float DLJDKOFPIMN, OGPMHIGIIEC FHFEHFNOMJA = OGPMHIGIIEC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x82BDAD0", Offset = "0x82BC4D0", VA = "0x1882BDAD0", Slot = "10")]
			public void MJGPLOFFIKO(JGOGLEAHDPN CEFJEHJNIAP, Transform GKDABMHEJMG, float DLJDKOFPIMN, OGPMHIGIIEC FHFEHFNOMJA = OGPMHIGIIEC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x82BDE70", Offset = "0x82BC870", VA = "0x1882BDE70")]
			private void OJMMFGGKMEO(JGOGLEAHDPN CEFJEHJNIAP, Transform GKDABMHEJMG, float DLJDKOFPIMN, OGPMHIGIIEC FHFEHFNOMJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x82BCAE0", Offset = "0x82BB4E0", VA = "0x1882BCAE0", Slot = "6")]
			public void BBOPECIHIDA(JGOGLEAHDPN MAOHNDMONHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x82BCC00", Offset = "0x82BB600", VA = "0x1882BCC00")]
			private void CGPFJLDAOBD(JGOGLEAHDPN MAOHNDMONHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x82BC880", Offset = "0x82BB280", VA = "0x1882BC880")]
			private void ANBFGLEPPLO(JGOGLEAHDPN CEFJEHJNIAP, [Optional] float? DLJDKOFPIMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x82BD910", Offset = "0x82BC310", VA = "0x1882BD910", Slot = "11")]
			public bool LOPJJGNOIJE(JGOGLEAHDPN CEFJEHJNIAP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
			public void GIAJPAMABJD(JGOGLEAHDPN CEFJEHJNIAP, OGPMHIGIIEC HBADGMFCKPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x82BDDC0", Offset = "0x82BC7C0", VA = "0x1882BDDC0")]
			private void OJMJMDNILOL(JGOGLEAHDPN CEFJEHJNIAP, OGPMHIGIIEC HBADGMFCKPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x82BCB40", Offset = "0x82BB540", VA = "0x1882BCB40")]
			public void BNHABPHNHGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x82BD410", Offset = "0x82BBE10", VA = "0x1882BD410")]
			public void JDEMLAHDPGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x82BD620", Offset = "0x82BC020", VA = "0x1882BD620")]
			private void KLMDPFFGCJE(DLALLIPJJHM HFDMMDBJNBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x82BD150", Offset = "0x82BBB50", VA = "0x1882BD150")]
			private void ENFCPFNKGPA(int GLONFBPLIIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x82BCF20", Offset = "0x82BB920", VA = "0x1882BCF20", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x82BDDB0", Offset = "0x82BC7B0", VA = "0x1882BDDB0")]
			private void OGHFMMLDKDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x82BCF10", Offset = "0x82BB910", VA = "0x1882BCF10")]
			private void DMOGLKJJCMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x82BDB70", Offset = "0x82BC570", VA = "0x1882BDB70")]
			private void NMNNOMKJCMN(CullingGroupEvent LNDBPNAKEFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x82BD2A0", Offset = "0x82BBCA0", VA = "0x1882BD2A0")]
			private void GJHGEBGBJJM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static MEBJEIOEDLD HJHMNJLNNBM;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static MEBJEIOEDLD LHCEACIEEFI;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float FLBEGIOKBHN = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float HBFELMMGPBN = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float LPNFHAFJAPK = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float JOJCFINAKJF = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float EJHIPIDCCPO = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const float CKPFAGEMHDI = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float FDICNOOCCIO = 500f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ACIINLJPAHO, CDEJNOLKEHK> KGLMEBANHFD;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static IDisposable MGKLGKIAOGI;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IDisposable KOEHKGHNFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly HPDJJKCNBLF CFGNFONOHMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HPDJJKCNBLF KCNDDECAFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly HPDJJKCNBLF KNIDNJGKMOI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker OBAGELFODLO;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker NEEMBLNMBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private NNFEFJFFOPD LJANJGIEOGN;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool BNIIJGIOPCL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool HAAHJMNIMKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA88540", Offset = "0xA86F40", VA = "0x180A88540", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA88520", Offset = "0xA86F20", VA = "0x180A88520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public HPDJJKCNBLF DFBPGJJOBIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public HPDJJKCNBLF MMJMPHAODGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public HPDJJKCNBLF HMEIPFPLEEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool IKGGHPFAPBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAB2D40", Offset = "0xAB1740", VA = "0x180AB2D40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool GGINOGKOBFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD49720", Offset = "0xD48120", VA = "0x180D49720", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xE571D0", Offset = "0xE55BD0", VA = "0x180E571D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82BE5F0", Offset = "0x82BCFF0", VA = "0x1882BE5F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8078D90", Offset = "0x8077790", VA = "0x188078D90")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82BF1A0", Offset = "0x82BDBA0", VA = "0x1882BF1A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD35410", Offset = "0xD33E10", VA = "0x180D35410")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x82BF060", Offset = "0x82BDA60", VA = "0x1882BF060")]
		private void OPPOGMKGOKJ(Scene FPJGDNNEOIB, LoadSceneMode JFFMBFIHKJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82BF0C0", Offset = "0x82BDAC0", VA = "0x1882BF0C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x82BF460", Offset = "0x82BDE60", VA = "0x1882BF460")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82BEE50", Offset = "0x82BD850", VA = "0x1882BEE50")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82BE820", Offset = "0x82BD220", VA = "0x1882BE820")]
		private void DIPIIFNLPNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82BF1C0", Offset = "0x82BDBC0", VA = "0x1882BF1C0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x82BE6B0", Offset = "0x82BD0B0", VA = "0x1882BE6B0")]
		private void BBANJJNCAAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x82BEC70", Offset = "0x82BD670", VA = "0x1882BEC70")]
		public JCLKHJLKHJD GetOrCreateCullingGroup(Type NDMCLNKBIOK, int HGKMHHBJBCH, ushort IFJIDAPLLDM = 0, bool JAPHLEEIMBD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5510", Offset = "0x3AA3F10", VA = "0x183AA5510")]
		public AKOLAIIEOMA<T> GetOrCreateCullingGroup<T>(int HGKMHHBJBCH, ushort IFJIDAPLLDM = 0, bool JAPHLEEIMBD = false) where T : class, JGOGLEAHDPN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82BEAE0", Offset = "0x82BD4E0", VA = "0x1882BEAE0")]
		private JCLKHJLKHJD GIENBKDGANC(Type NDMCLNKBIOK, int HGKMHHBJBCH, float[] NCAOLIPKNEJ, ushort IFJIDAPLLDM = 0, bool JAPHLEEIMBD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3AA52E0", Offset = "0x3AA3CE0", VA = "0x183AA52E0")]
		private AKOLAIIEOMA<T> GIENBKDGANC<T>(int HGKMHHBJBCH, float[] NCAOLIPKNEJ, ushort IFJIDAPLLDM = 0, bool JAPHLEEIMBD = false) where T : class, JGOGLEAHDPN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82BE980", Offset = "0x82BD380", VA = "0x1882BE980")]
		public static CNMJFAPGOOG FindClosestDefaultUpdateLod(float FHJMJODODLI)
		{
			return default(CNMJFAPGOOG);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAB35A0", Offset = "0xAB1FA0", VA = "0x180AB35A0")]
		public static CNMJFAPGOOG MinUpdateLod(CNMJFAPGOOG EFFAMNOLDOO, CNMJFAPGOOG GNMCDLKOEMI)
		{
			return default(CNMJFAPGOOG);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82BF050", Offset = "0x82BDA50", VA = "0x1882BF050")]
		public static CNMJFAPGOOG MaxUpdateLod(CNMJFAPGOOG EFFAMNOLDOO, CNMJFAPGOOG GNMCDLKOEMI)
		{
			return default(CNMJFAPGOOG);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82BF8E0", Offset = "0x82BE2E0", VA = "0x1882BF8E0")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAB2D40", Offset = "0xAB1740", VA = "0x180AB2D40", Slot = "11")]
		private bool OELMCBECINB()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface COFLANOMENL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool APGECBGKGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera MAGLNKJFFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	HPDJJKCNBLF AMOHKNAIBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool ODGPDONBHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HPDJJKCNBLF PBPHCKKEEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform MDCPDHOALGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JCLKHJLKHJD
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJGPLOFFIKO(JGOGLEAHDPN CEFJEHJNIAP, float DLJDKOFPIMN, OGPMHIGIIEC FHFEHFNOMJA = OGPMHIGIIEC.Off);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BBOPECIHIDA(JGOGLEAHDPN MAOHNDMONHF);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GIAJPAMABJD(JGOGLEAHDPN CEFJEHJNIAP, OGPMHIGIIEC ICHDFMEGBLI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AKOLAIIEOMA<T> : JCLKHJLKHJD where T : class, JGOGLEAHDPN
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJGPLOFFIKO(T CEFJEHJNIAP, float DLJDKOFPIMN, OGPMHIGIIEC FHFEHFNOMJA = OGPMHIGIIEC.Off);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJGPLOFFIKO(T CEFJEHJNIAP, Transform GKDABMHEJMG, float DLJDKOFPIMN, OGPMHIGIIEC FHFEHFNOMJA = OGPMHIGIIEC.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BBOPECIHIDA(T MAOHNDMONHF);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LOPJJGNOIJE(T CEFJEHJNIAP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JGOGLEAHDPN
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform EOBBLENOIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(CNMJFAPGOOG FPOENPNJHPI, CNMJFAPGOOG OIEELJPGCMK);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool MJDKKJPHIGA);
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
