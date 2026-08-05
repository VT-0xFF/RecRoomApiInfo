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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, PALDPPFGJJL
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class KBDOCGBCMAJ<T> : LGAGENIHJEM, HCEPAGFHOMC<T>, ECODPLJIFEC where T : class, MGJHENFBMOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x451D0E0", Offset = "0x451C4E0", VA = "0x18451D0E0")]
			internal KBDOCGBCMAJ(int BCELGJIFCAG, float[] AEMJECFBDIB, CKCAKLNALPL BMHABDFNFJA = CKCAKLNALPL.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x451D080", Offset = "0x451C480", VA = "0x18451D080", Slot = "10")]
			public void PJLPMKJIOFF(T PBAACPJGKNP, float MINBCCGNENH, NKELFIBCFCE BKNICCFDDJE = NKELFIBCFCE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x451D0B0", Offset = "0x451C4B0", VA = "0x18451D0B0", Slot = "11")]
			public void PJLPMKJIOFF(T PBAACPJGKNP, Transform KBJGBIDNLOD, float MINBCCGNENH, NKELFIBCFCE BKNICCFDDJE = NKELFIBCFCE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x451D060", Offset = "0x451C460", VA = "0x18451D060", Slot = "12")]
			public void MAHJHHAHNPL(T OGJMANGBFEI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class LGAGENIHJEM : IDisposable, ECODPLJIFEC
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum CKCAKLNALPL : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class OCCKBNEJOHH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public MGJHENFBMOI IGMKBIEEBFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public NKELFIBCFCE MMOGMEJICIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action CMCBBCOLEID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool NBELNELJLNO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int LGPOLAJNCMC;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
				public OCCKBNEJOHH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class BDGDGHJIEKJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public LGAGENIHJEM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public OCCKBNEJOHH trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
				public BDGDGHJIEKJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x6DA8EC0", Offset = "0x6DA82C0", VA = "0x186DA8EC0")]
				internal void PIGBBGINCCH()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int BMFAGJLHKFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int BCELGJIFCAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int NBBKLECJEBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool LNIMNIKGCDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup OHGCFCIIOAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] KMJJDKLFNKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] BDDHFFKIMMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly GANGDEEJNMM AJKICPHDFFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<MGJHENFBMOI, int> OFKJLDNBLLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, OCCKBNEJOHH> EHOFLJCHBCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CKCAKLNALPL BMHABDFNFJA;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool MHLFDCHJNLP
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xB81DF0", Offset = "0xB811F0", VA = "0x180B81DF0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x4888D30", Offset = "0x4888130", VA = "0x184888D30", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6DABDB0", Offset = "0x6DAB1B0", VA = "0x186DABDB0")]
			internal LGAGENIHJEM(int BCELGJIFCAG, float[] AEMJECFBDIB, CKCAKLNALPL BMHABDFNFJA = CKCAKLNALPL.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6DAAFB0", Offset = "0x6DAA3B0", VA = "0x186DAAFB0")]
			public void JKEILDOKCED(bool OOMFHMNMHCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6DAB920", Offset = "0x6DAAD20", VA = "0x186DAB920", Slot = "6")]
			public void PJLPMKJIOFF(MGJHENFBMOI PBAACPJGKNP, float MINBCCGNENH, NKELFIBCFCE BKNICCFDDJE = NKELFIBCFCE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6DAB9B0", Offset = "0x6DAADB0", VA = "0x186DAB9B0", Slot = "9")]
			public void PJLPMKJIOFF(MGJHENFBMOI PBAACPJGKNP, Transform KBJGBIDNLOD, float MINBCCGNENH, NKELFIBCFCE BKNICCFDDJE = NKELFIBCFCE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6DAAE00", Offset = "0x6DAA200", VA = "0x186DAAE00")]
			public void IMEMDCGKKLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6DAAFE0", Offset = "0x6DAA3E0", VA = "0x186DAAFE0")]
			private void JLFEMGIOHDN(int AEAHMAMPNLO, [Optional] float? MINBCCGNENH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6DAB110", Offset = "0x6DAA510", VA = "0x186DAB110", Slot = "7")]
			public void MAHJHHAHNPL(MGJHENFBMOI OGJMANGBFEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6DAB510", Offset = "0x6DAA910", VA = "0x186DAB510", Slot = "8")]
			public void NNHJIAHGCGD(MGJHENFBMOI PBAACPJGKNP, NKELFIBCFCE KHICILBNBON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6DAA780", Offset = "0x6DA9B80", VA = "0x186DAA780", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6DAA250", Offset = "0x6DA9650", VA = "0x186DAA250")]
			private void AFDPCKJDOPJ(OCCKBNEJOHH KPGABBMHGDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6DAAB90", Offset = "0x6DA9F90", VA = "0x186DAAB90")]
			private void HLEGEGIIPKE(OCCKBNEJOHH KPGABBMHGDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6DAAF50", Offset = "0x6DAA350", VA = "0x186DAAF50")]
			private void JHLIAHAPPCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6DAA720", Offset = "0x6DA9B20", VA = "0x186DAA720")]
			private void CCCBKMCEEHC(float GJPMFKBAIBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6DAAA50", Offset = "0x6DA9E50", VA = "0x186DAAA50")]
			private void GPAKBEGOKAE(OCCKBNEJOHH KPGABBMHGDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6DAAA40", Offset = "0x6DA9E40", VA = "0x186DAAA40")]
			private void FAEGAPIFBNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6DAB500", Offset = "0x6DAA900", VA = "0x186DAB500")]
			private void MNNIMOBBLFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6DAB600", Offset = "0x6DAAA00", VA = "0x186DAB600")]
			private void OLLAEAFCPOP(CullingGroupEvent CHLIBHHBHDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6DAA5B0", Offset = "0x6DA99B0", VA = "0x186DAA5B0")]
			private void BENFKABPIIP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct KHOGENEJEIA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort KIGIJCBOLGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type NANBLAHLPLJ;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float LFDNOJFMFFJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float KMAKFNNJKNA = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float IHJANEGJNDN = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float LHBLCLBEKKC = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float KGFLAAHPLDF = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float PNAPEPBCEPM = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float DMJFBCIEMCI = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<KHOGENEJEIA, LGAGENIHJEM> HIDKHPNDPJI;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable NAELFDGJBEM;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable ENPOFNFAHMK;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static LKILNMKOKHH HKLMEOCFOBN;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static LKILNMKOKHH LEJFLIJJMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly LKILNMKOKHH DKGNPFDJBKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly LKILNMKOKHH FDOJLDJLHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LKILNMKOKHH PLFDODJOFCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GJOIDBBGEPO KEOKFKKKEBP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool OOMFHMNMHCI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public LKILNMKOKHH FCJKOMLDAAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LKILNMKOKHH PDBEJMNHKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public LKILNMKOKHH IKLEPIBMHPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8AA340", Offset = "0x8A9740", VA = "0x1808AA340", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool PDFHDIIEBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x96BBA0", Offset = "0x96AFA0", VA = "0x18096BBA0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool INPEEMICAOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x927B80", Offset = "0x926F80", VA = "0x180927B80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9229F0", Offset = "0x921DF0", VA = "0x1809229F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6DA91B0", Offset = "0x6DA85B0", VA = "0x186DA91B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6DA98D0", Offset = "0x6DA8CD0", VA = "0x186DA98D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6DA98B0", Offset = "0x6DA8CB0", VA = "0x186DA98B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9270", Offset = "0x6DA8670", VA = "0x186DA9270")]
		private void BNEFFMJOADE(Scene HDJLELFLAEI, LoadSceneMode EEKKEDKPKFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6DA97D0", Offset = "0x6DA8BD0", VA = "0x186DA97D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9D00", Offset = "0x6DA9100", VA = "0x186DA9D00")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9010", Offset = "0x6DA8410", VA = "0x186DA9010")]
		private void AEOOJGLAMKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9AD0", Offset = "0x6DA8ED0", VA = "0x186DA9AD0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9660", Offset = "0x6DA8A60", VA = "0x186DA9660")]
		private void NMGDPPDGIEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9430", Offset = "0x6DA8830", VA = "0x186DA9430")]
		public ECODPLJIFEC GetOrCreateCullingGroup(Type LIOHOLLBPCJ, int ECIKPDJNBHM, ushort MKNLDMCIOBD = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2C7EBD0", Offset = "0x2C7DFD0", VA = "0x182C7EBD0")]
		public HCEPAGFHOMC<T> GetOrCreateCullingGroup<T>(int ECIKPDJNBHM, ushort MKNLDMCIOBD = 0) where T : class, MGJHENFBMOI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6DA98F0", Offset = "0x6DA8CF0", VA = "0x186DA98F0")]
		private ECODPLJIFEC PLDMFBCICOO(Type LIOHOLLBPCJ, int ECIKPDJNBHM, float[] AEMJECFBDIB, ushort MKNLDMCIOBD = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2C7EC80", Offset = "0x2C7E080", VA = "0x182C7EC80")]
		private HCEPAGFHOMC<T> PLDMFBCICOO<T>(int ECIKPDJNBHM, float[] AEMJECFBDIB, ushort MKNLDMCIOBD = 0) where T : class, MGJHENFBMOI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6DA92D0", Offset = "0x6DA86D0", VA = "0x186DA92D0")]
		public static GGHKEJOODBA FindClosestDefaultUpdateLod(float HGFHBAAIFGA)
		{
			return default(GGHKEJOODBA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8D84C0", Offset = "0x8D78C0", VA = "0x1808D84C0")]
		public static GGHKEJOODBA MinUpdateLod(GGHKEJOODBA CGHBMHKMAFN, GGHKEJOODBA IOJCDHINJFI)
		{
			return default(GGHKEJOODBA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6DA9650", Offset = "0x6DA8A50", VA = "0x186DA9650")]
		public static GGHKEJOODBA MaxUpdateLod(GGHKEJOODBA CGHBMHKMAFN, GGHKEJOODBA IOJCDHINJFI)
		{
			return default(GGHKEJOODBA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6DAA150", Offset = "0x6DA9550", VA = "0x186DAA150")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GANGDEEJNMM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool KDPHEAMNLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera AGIOAFFDCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LKILNMKOKHH GMKJFCFDGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool FHOCMLOBKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LKILNMKOKHH JHKCKBLMLPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform ILPEAADKCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ECODPLJIFEC
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool MHLFDCHJNLP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJLPMKJIOFF(MGJHENFBMOI PBAACPJGKNP, float MINBCCGNENH, NKELFIBCFCE BKNICCFDDJE = NKELFIBCFCE.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MAHJHHAHNPL(MGJHENFBMOI OGJMANGBFEI);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NNHJIAHGCGD(MGJHENFBMOI PBAACPJGKNP, NKELFIBCFCE EGNJPLJEOEI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HCEPAGFHOMC<T> : ECODPLJIFEC where T : class, MGJHENFBMOI
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJLPMKJIOFF(T PBAACPJGKNP, float MINBCCGNENH, NKELFIBCFCE BKNICCFDDJE = NKELFIBCFCE.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJLPMKJIOFF(T PBAACPJGKNP, Transform KBJGBIDNLOD, float MINBCCGNENH, NKELFIBCFCE BKNICCFDDJE = NKELFIBCFCE.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MAHJHHAHNPL(T OGJMANGBFEI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MGJHENFBMOI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform ADJOLMKPBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(GGHKEJOODBA JDADDGIEFHK, GGHKEJOODBA DHLGCOJLBKM);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool LNDNKAMNDAA);
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
