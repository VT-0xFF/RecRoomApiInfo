using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, IGCLHBDADKK, LEGAGIOCBAL
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct EGGEBHPODLO : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> HPMNBNLACCC;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x78923C0", Offset = "0x78917C0", VA = "0x1878923C0", Slot = "4")]
			public void Execute(int CJFNAFNJJLB, TransformAccess KHDOKFIGIID)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct GEKFCFICHLL : IEquatable<GEKFCFICHLL>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort ILCJEEKMIEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type NNCBOHCCGMP;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7892530", Offset = "0x7891930", VA = "0x187892530", Slot = "4")]
			public bool Equals(GEKFCFICHLL KNCKFHOKGJM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7892440", Offset = "0x7891840", VA = "0x187892440", Slot = "0")]
			public override bool Equals(object BLFGIKOAKOL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x78925B0", Offset = "0x78919B0", VA = "0x1878925B0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class NPAPIAHFFED<T> : KCGIPOFEFKN, LLMALLIJAEN<T>, FFAJMDDLMGH where T : class, AFLGOOFMPPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x510E970", Offset = "0x510DD70", VA = "0x18510E970")]
			internal NPAPIAHFFED(int EHBFNKMKBMF, float[] KKCINPAKMNL, GMEIJOOMCIM PNMKFODKKED = GMEIJOOMCIM.PlayerHead, bool OMGKHHIEDCK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x510E910", Offset = "0x510DD10", VA = "0x18510E910", Slot = "12")]
			public void JJBKLNLGAIJ(T BLFGIKOAKOL, float JAINCGFCEKN, LFLBFNEONAP JJLLGLEHMEP = LFLBFNEONAP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x510E940", Offset = "0x510DD40", VA = "0x18510E940", Slot = "13")]
			public void JJBKLNLGAIJ(T BLFGIKOAKOL, Transform BCGPJDFEBHF, float JAINCGFCEKN, LFLBFNEONAP JJLLGLEHMEP = LFLBFNEONAP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x510E8F0", Offset = "0x510DCF0", VA = "0x18510E8F0", Slot = "14")]
			public void JEBJOEBLLEI(T OBAMHGICKOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x510E8D0", Offset = "0x510DCD0", VA = "0x18510E8D0", Slot = "15")]
			public bool BBKLNIELDBB(T BLFGIKOAKOL)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class KCGIPOFEFKN : IDisposable, FFAJMDDLMGH
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct LGIGIHNLFDB
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum MONOHACIFLN : byte
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
				public AFLGOOFMPPF FBCEIDKHADO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform IGBFJKOBHIJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float DNCJLMMFDBP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public LFLBFNEONAP GEHLKJFHCIG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public MONOHACIFLN KAFGKIIBACB;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum GMEIJOOMCIM : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class LNIAGFDKCPL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public AFLGOOFMPPF FBCEIDKHADO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public LFLBFNEONAP IJEOMIBMCGF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action KJAJCFBHJHB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool LHDMJDNAHOM;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
				public LNIAGFDKCPL()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int OPFOLNCOPBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool OMGKHHIEDCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool ACJJLPFCEAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup FHPKBNBDFLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] ALHIBAONBHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly LMMBKGMFCNP IAPHFNOPBJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly GMEIJOOMCIM PNMKFODKKED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<AFLGOOFMPPF, int> PIAKGJNEEID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, LNIAGFDKCPL> DPNAGKOOOMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray PLHBKGGGEPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> AFOFMDLPMGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<LGIGIHNLFDB> LDFJGPODLBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool DFENKIMKOCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle CNINKJDDJFJ;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int GDLBNLGPGNB
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x9A91A0", Offset = "0x9A85A0", VA = "0x1809A91A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x9A9250", Offset = "0x9A8650", VA = "0x1809A9250")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int JDEOJKJACKI
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xAE6870", Offset = "0xAE5C70", VA = "0x180AE6870", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xBD35D0", Offset = "0xBD29D0", VA = "0x180BD35D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7894260", Offset = "0x7893660", VA = "0x187894260")]
			internal KCGIPOFEFKN(int EHBFNKMKBMF, float[] KKCINPAKMNL, GMEIJOOMCIM PNMKFODKKED = GMEIJOOMCIM.PlayerHead, bool OMGKHHIEDCK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7892FD0", Offset = "0x78923D0", VA = "0x187892FD0")]
			public void CNABMEAHICP(bool MOJLEMKJLCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x78940B0", Offset = "0x78934B0", VA = "0x1878940B0", Slot = "5")]
			public void JJBKLNLGAIJ(AFLGOOFMPPF BLFGIKOAKOL, float JAINCGFCEKN, LFLBFNEONAP JJLLGLEHMEP = LFLBFNEONAP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x78941B0", Offset = "0x78935B0", VA = "0x1878941B0", Slot = "10")]
			public void JJBKLNLGAIJ(AFLGOOFMPPF BLFGIKOAKOL, Transform BCGPJDFEBHF, float JAINCGFCEKN, LFLBFNEONAP JJLLGLEHMEP = LFLBFNEONAP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7893010", Offset = "0x7892410", VA = "0x187893010")]
			private void DKLBDIFFELK(AFLGOOFMPPF BLFGIKOAKOL, Transform BCGPJDFEBHF, float JAINCGFCEKN, LFLBFNEONAP JJLLGLEHMEP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7894050", Offset = "0x7893450", VA = "0x187894050", Slot = "6")]
			public void JEBJOEBLLEI(AFLGOOFMPPF OBAMHGICKOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7893C10", Offset = "0x7893010", VA = "0x187893C10")]
			private void GLMOHJACCFJ(AFLGOOFMPPF OBAMHGICKOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x78939B0", Offset = "0x7892DB0", VA = "0x1878939B0")]
			private void FKGBKKKAFEM(AFLGOOFMPPF BLFGIKOAKOL, [Optional] float? JAINCGFCEKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7892B30", Offset = "0x7891F30", VA = "0x187892B30", Slot = "11")]
			public bool BBKLNIELDBB(AFLGOOFMPPF BLFGIKOAKOL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "7")]
			public void BFKBLNMOGBB(AFLGOOFMPPF BLFGIKOAKOL, LFLBFNEONAP IFEGMNBDDIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7892F20", Offset = "0x7892320", VA = "0x187892F20")]
			private void CCBMHLMBHHH(AFLGOOFMPPF BLFGIKOAKOL, LFLBFNEONAP IFEGMNBDDIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7892620", Offset = "0x7891A20", VA = "0x187892620")]
			public void AAOLGGFEJGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x78937A0", Offset = "0x7892BA0", VA = "0x1878937A0")]
			public void ELOEEBBOGGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x78926E0", Offset = "0x7891AE0", VA = "0x1878926E0")]
			private void ADAPJGBJDEH(LGIGIHNLFDB NOBKOCLLFNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x78929E0", Offset = "0x7891DE0", VA = "0x1878929E0")]
			private void ALEJIPPDALK(int MJHFBPPAICH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7893400", Offset = "0x7892800", VA = "0x187893400", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7894250", Offset = "0x7893650", VA = "0x187894250")]
			private void KNGGAGLFCEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7893000", Offset = "0x7892400", VA = "0x187893000")]
			private void DADNAEFNDDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7892BF0", Offset = "0x7891FF0", VA = "0x187892BF0")]
			private void BJFMLMJOMEM(CullingGroupEvent PAKAPDAPGND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7893630", Offset = "0x7892A30", VA = "0x187893630")]
			private void EBLHGBHFMBP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float GOABOJCNGMM = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float GPLLECEDCNE = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float FHHHMFOAAKL = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float BKHHGNAHHOI = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float JMGFLHPJFJP = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float PGCHNCDOEID = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float JKDOOFHPMEH = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<GEKFCFICHLL, KCGIPOFEFKN> BEHODJJCBMJ;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable GCGJLFKHDHE;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable EPJJBNHIJJP;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static OPNNLJDPBAB DOHOBKGPBGN;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static OPNNLJDPBAB OEPALJNNGBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly OPNNLJDPBAB LDJHFGBDLOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly OPNNLJDPBAB HLEANHMBMNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly OPNNLJDPBAB FBHGOIHAOIH;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker BCPGFMCGCGH;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker CCIJMFDHJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private LBKCJDEOHAA CLLBLBFEAID;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool MOJLEMKJLCE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool LOAGEPKNJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x9AA370", Offset = "0x9A9770", VA = "0x1809AA370", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x9AA510", Offset = "0x9A9910", VA = "0x1809AA510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public OPNNLJDPBAB DNHAKKPMIHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3A0", Offset = "0x9A97A0", VA = "0x1809AA3A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public OPNNLJDPBAB AELHKFDOGFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public OPNNLJDPBAB ANHFBJLDMKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FDBBOLDOOJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9D6930", Offset = "0x9D5D30", VA = "0x1809D6930", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool EMIKMDMDEID
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB5F800", Offset = "0xB5EC00", VA = "0x180B5F800", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xC51310", Offset = "0xC50710", VA = "0x180C51310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7890F50", Offset = "0x7890350", VA = "0x187890F50", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7891AE0", Offset = "0x7890EE0", VA = "0x187891AE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1D452F0", Offset = "0x1D446F0", VA = "0x181D452F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB4EA40", Offset = "0xB4DE40", VA = "0x180B4EA40")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7890EF0", Offset = "0x78902F0", VA = "0x187890EF0")]
		private void ACCIKPIOMDN(Scene GMKDGAGFJCJ, LoadSceneMode KGLDBFDNHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7891A00", Offset = "0x7890E00", VA = "0x187891A00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7891D90", Offset = "0x7891190", VA = "0x187891D90")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78917B0", Offset = "0x7890BB0", VA = "0x1878917B0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7891650", Offset = "0x7890A50", VA = "0x187891650")]
		private void KOIGMBEJPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7891B00", Offset = "0x7890F00", VA = "0x187891B00")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7891010", Offset = "0x7890410", VA = "0x187891010")]
		private void CCINIDHNJPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x78912E0", Offset = "0x78906E0", VA = "0x1878912E0")]
		public FFAJMDDLMGH GetOrCreateCullingGroup(Type IFLNNIMCHFA, int CHEMOGACDGP, ushort BFFHKFGNGFB = 0, bool OMGKHHIEDCK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x343D0D0", Offset = "0x343C4D0", VA = "0x18343D0D0")]
		public LLMALLIJAEN<T> GetOrCreateCullingGroup<T>(int CHEMOGACDGP, ushort BFFHKFGNGFB = 0, bool OMGKHHIEDCK = false) where T : class, AFLGOOFMPPF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x78914C0", Offset = "0x78908C0", VA = "0x1878914C0")]
		private FFAJMDDLMGH KBBLCMBILNP(Type IFLNNIMCHFA, int CHEMOGACDGP, float[] KKCINPAKMNL, ushort BFFHKFGNGFB = 0, bool OMGKHHIEDCK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x343D190", Offset = "0x343C590", VA = "0x18343D190")]
		private LLMALLIJAEN<T> KBBLCMBILNP<T>(int CHEMOGACDGP, float[] KKCINPAKMNL, ushort BFFHKFGNGFB = 0, bool OMGKHHIEDCK = false) where T : class, AFLGOOFMPPF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7891180", Offset = "0x7890580", VA = "0x187891180")]
		public static FIEJAHACKON FindClosestDefaultUpdateLod(float GAIJLNCFDAB)
		{
			return default(FIEJAHACKON);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9D8000", Offset = "0x9D7400", VA = "0x1809D8000")]
		public static FIEJAHACKON MinUpdateLod(FIEJAHACKON PDELFLJIHFM, FIEJAHACKON FMGLMKPEHCB)
		{
			return default(FIEJAHACKON);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x78919F0", Offset = "0x7890DF0", VA = "0x1878919F0")]
		public static FIEJAHACKON MaxUpdateLod(FIEJAHACKON PDELFLJIHFM, FIEJAHACKON FMGLMKPEHCB)
		{
			return default(FIEJAHACKON);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7892270", Offset = "0x7891670", VA = "0x187892270")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9D6930", Offset = "0x9D5D30", VA = "0x1809D6930", Slot = "11")]
		private bool CBMMHJLPIMM()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LMMBKGMFCNP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool CKIGOPIIEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera CLBPCLIDLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OPNNLJDPBAB FJABJKDKCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool LNINEPCGNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	OPNNLJDPBAB IIECKPCAGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform KPGJOIFELPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FFAJMDDLMGH
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJBKLNLGAIJ(AFLGOOFMPPF BLFGIKOAKOL, float JAINCGFCEKN, LFLBFNEONAP JJLLGLEHMEP = LFLBFNEONAP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JEBJOEBLLEI(AFLGOOFMPPF OBAMHGICKOF);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BFKBLNMOGBB(AFLGOOFMPPF BLFGIKOAKOL, LFLBFNEONAP FHMHODBAECB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LLMALLIJAEN<T> : FFAJMDDLMGH where T : class, AFLGOOFMPPF
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJBKLNLGAIJ(T BLFGIKOAKOL, float JAINCGFCEKN, LFLBFNEONAP JJLLGLEHMEP = LFLBFNEONAP.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJBKLNLGAIJ(T BLFGIKOAKOL, Transform BCGPJDFEBHF, float JAINCGFCEKN, LFLBFNEONAP JJLLGLEHMEP = LFLBFNEONAP.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JEBJOEBLLEI(T OBAMHGICKOF);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BBKLNIELDBB(T BLFGIKOAKOL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AFLGOOFMPPF
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform KHDOKFIGIID
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(FIEJAHACKON EODAOCIBHCJ, FIEJAHACKON HLCKONMPLHI);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool CIDNJAKHCBD);
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
