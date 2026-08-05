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
			[Cpp2IlInjected.Address(RVA = "0x7844C30", Offset = "0x7844030", VA = "0x187844C30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7844DA0", Offset = "0x78441A0", VA = "0x187844DA0", Slot = "4")]
			public bool Equals(GEKFCFICHLL KNCKFHOKGJM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7844CB0", Offset = "0x78440B0", VA = "0x187844CB0", Slot = "0")]
			public override bool Equals(object BLFGIKOAKOL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7844E20", Offset = "0x7844220", VA = "0x187844E20", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class NPAPIAHFFED<T> : KCGIPOFEFKN, LLMALLIJAEN<T>, FFAJMDDLMGH where T : class, AFLGOOFMPPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x50ED960", Offset = "0x50ECD60", VA = "0x1850ED960")]
			internal NPAPIAHFFED(int EHBFNKMKBMF, float[] KKCINPAKMNL, GMEIJOOMCIM PNMKFODKKED = GMEIJOOMCIM.PlayerHead, bool OMGKHHIEDCK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x50ED900", Offset = "0x50ECD00", VA = "0x1850ED900", Slot = "12")]
			public void JJBKLNLGAIJ(T BLFGIKOAKOL, float JAINCGFCEKN, LFLBFNEONAP JJLLGLEHMEP = LFLBFNEONAP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x50ED930", Offset = "0x50ECD30", VA = "0x1850ED930", Slot = "13")]
			public void JJBKLNLGAIJ(T BLFGIKOAKOL, Transform BCGPJDFEBHF, float JAINCGFCEKN, LFLBFNEONAP JJLLGLEHMEP = LFLBFNEONAP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x50ED8E0", Offset = "0x50ECCE0", VA = "0x1850ED8E0", Slot = "14")]
			public void JEBJOEBLLEI(T OBAMHGICKOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x50ED8C0", Offset = "0x50ECCC0", VA = "0x1850ED8C0", Slot = "15")]
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
				[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
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
				[Cpp2IlInjected.Address(RVA = "0x9931A0", Offset = "0x9925A0", VA = "0x1809931A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x993250", Offset = "0x992650", VA = "0x180993250")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int JDEOJKJACKI
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xADE5D0", Offset = "0xADD9D0", VA = "0x180ADE5D0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xBCC3A0", Offset = "0xBCB7A0", VA = "0x180BCC3A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7846AD0", Offset = "0x7845ED0", VA = "0x187846AD0")]
			internal KCGIPOFEFKN(int EHBFNKMKBMF, float[] KKCINPAKMNL, GMEIJOOMCIM PNMKFODKKED = GMEIJOOMCIM.PlayerHead, bool OMGKHHIEDCK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7845840", Offset = "0x7844C40", VA = "0x187845840")]
			public void CNABMEAHICP(bool MOJLEMKJLCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7846920", Offset = "0x7845D20", VA = "0x187846920", Slot = "5")]
			public void JJBKLNLGAIJ(AFLGOOFMPPF BLFGIKOAKOL, float JAINCGFCEKN, LFLBFNEONAP JJLLGLEHMEP = LFLBFNEONAP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7846A20", Offset = "0x7845E20", VA = "0x187846A20", Slot = "10")]
			public void JJBKLNLGAIJ(AFLGOOFMPPF BLFGIKOAKOL, Transform BCGPJDFEBHF, float JAINCGFCEKN, LFLBFNEONAP JJLLGLEHMEP = LFLBFNEONAP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7845880", Offset = "0x7844C80", VA = "0x187845880")]
			private void DKLBDIFFELK(AFLGOOFMPPF BLFGIKOAKOL, Transform BCGPJDFEBHF, float JAINCGFCEKN, LFLBFNEONAP JJLLGLEHMEP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x78468C0", Offset = "0x7845CC0", VA = "0x1878468C0", Slot = "6")]
			public void JEBJOEBLLEI(AFLGOOFMPPF OBAMHGICKOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7846480", Offset = "0x7845880", VA = "0x187846480")]
			private void GLMOHJACCFJ(AFLGOOFMPPF OBAMHGICKOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7846220", Offset = "0x7845620", VA = "0x187846220")]
			private void FKGBKKKAFEM(AFLGOOFMPPF BLFGIKOAKOL, [Optional] float? JAINCGFCEKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x78453A0", Offset = "0x78447A0", VA = "0x1878453A0", Slot = "11")]
			public bool BBKLNIELDBB(AFLGOOFMPPF BLFGIKOAKOL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "7")]
			public void BFKBLNMOGBB(AFLGOOFMPPF BLFGIKOAKOL, LFLBFNEONAP IFEGMNBDDIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7845790", Offset = "0x7844B90", VA = "0x187845790")]
			private void CCBMHLMBHHH(AFLGOOFMPPF BLFGIKOAKOL, LFLBFNEONAP IFEGMNBDDIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7844E90", Offset = "0x7844290", VA = "0x187844E90")]
			public void AAOLGGFEJGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7846010", Offset = "0x7845410", VA = "0x187846010")]
			public void ELOEEBBOGGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7844F50", Offset = "0x7844350", VA = "0x187844F50")]
			private void ADAPJGBJDEH(LGIGIHNLFDB NOBKOCLLFNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7845250", Offset = "0x7844650", VA = "0x187845250")]
			private void ALEJIPPDALK(int MJHFBPPAICH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7845C70", Offset = "0x7845070", VA = "0x187845C70", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7846AC0", Offset = "0x7845EC0", VA = "0x187846AC0")]
			private void KNGGAGLFCEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7845870", Offset = "0x7844C70", VA = "0x187845870")]
			private void DADNAEFNDDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7845460", Offset = "0x7844860", VA = "0x187845460")]
			private void BJFMLMJOMEM(CullingGroupEvent PAKAPDAPGND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7845EA0", Offset = "0x78452A0", VA = "0x187845EA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9943A0", Offset = "0x9937A0", VA = "0x1809943A0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x994540", Offset = "0x993940", VA = "0x180994540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public OPNNLJDPBAB DNHAKKPMIHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9943D0", Offset = "0x9937D0", VA = "0x1809943D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public OPNNLJDPBAB AELHKFDOGFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9944C0", Offset = "0x9938C0", VA = "0x1809944C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public OPNNLJDPBAB ANHFBJLDMKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9943F0", Offset = "0x9937F0", VA = "0x1809943F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FDBBOLDOOJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9C0950", Offset = "0x9BFD50", VA = "0x1809C0950", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool EMIKMDMDEID
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB583E0", Offset = "0xB577E0", VA = "0x180B583E0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xC4B280", Offset = "0xC4A680", VA = "0x180C4B280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7843820", Offset = "0x7842C20", VA = "0x187843820", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7844370", Offset = "0x7843770", VA = "0x187844370")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1D33A60", Offset = "0x1D32E60", VA = "0x181D33A60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB474F0", Offset = "0xB468F0", VA = "0x180B474F0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x78437C0", Offset = "0x7842BC0", VA = "0x1878437C0")]
		private void ACCIKPIOMDN(Scene GMKDGAGFJCJ, LoadSceneMode KGLDBFDNHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7844290", Offset = "0x7843690", VA = "0x187844290", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7844630", Offset = "0x7843A30", VA = "0x187844630")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7844080", Offset = "0x7843480", VA = "0x187844080")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7843F20", Offset = "0x7843320", VA = "0x187843F20")]
		private void KOIGMBEJPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7844390", Offset = "0x7843790", VA = "0x187844390")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x78438E0", Offset = "0x7842CE0", VA = "0x1878438E0")]
		private void CCINIDHNJPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7843BB0", Offset = "0x7842FB0", VA = "0x187843BB0")]
		public FFAJMDDLMGH GetOrCreateCullingGroup(Type IFLNNIMCHFA, int CHEMOGACDGP, ushort BFFHKFGNGFB = 0, bool OMGKHHIEDCK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3428580", Offset = "0x3427980", VA = "0x183428580")]
		public LLMALLIJAEN<T> GetOrCreateCullingGroup<T>(int CHEMOGACDGP, ushort BFFHKFGNGFB = 0, bool OMGKHHIEDCK = false) where T : class, AFLGOOFMPPF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7843D90", Offset = "0x7843190", VA = "0x187843D90")]
		private FFAJMDDLMGH KBBLCMBILNP(Type IFLNNIMCHFA, int CHEMOGACDGP, float[] KKCINPAKMNL, ushort BFFHKFGNGFB = 0, bool OMGKHHIEDCK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3428640", Offset = "0x3427A40", VA = "0x183428640")]
		private LLMALLIJAEN<T> KBBLCMBILNP<T>(int CHEMOGACDGP, float[] KKCINPAKMNL, ushort BFFHKFGNGFB = 0, bool OMGKHHIEDCK = false) where T : class, AFLGOOFMPPF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7843A50", Offset = "0x7842E50", VA = "0x187843A50")]
		public static FIEJAHACKON FindClosestDefaultUpdateLod(float GAIJLNCFDAB)
		{
			return default(FIEJAHACKON);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9C2040", Offset = "0x9C1440", VA = "0x1809C2040")]
		public static FIEJAHACKON MinUpdateLod(FIEJAHACKON PDELFLJIHFM, FIEJAHACKON FMGLMKPEHCB)
		{
			return default(FIEJAHACKON);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7844280", Offset = "0x7843680", VA = "0x187844280")]
		public static FIEJAHACKON MaxUpdateLod(FIEJAHACKON PDELFLJIHFM, FIEJAHACKON FMGLMKPEHCB)
		{
			return default(FIEJAHACKON);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7844AE0", Offset = "0x7843EE0", VA = "0x187844AE0")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9C0950", Offset = "0x9BFD50", VA = "0x1809C0950", Slot = "11")]
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
