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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, AOIMPEPBBIL
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class KAFJJKNCKCF<T> : HNJGDDALAMG, GLMMBJBJMEG<T>, AMGCCPCIEKH where T : class, FACFHHGFGIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3B43B80", Offset = "0x3B42D80", VA = "0x183B43B80")]
			internal KAFJJKNCKCF(int GIPHHNOKIAI, float[] BBNCDOCABLM, MCEANMBCNDP DCLGHMPIDLD = MCEANMBCNDP.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3B43B00", Offset = "0x3B42D00", VA = "0x183B43B00", Slot = "10")]
			public void OJOKKDMOJFN(T MFLACBLODGN, float AEKGFLEECNO, HIMOPMHMMMP NMCBABBAIJF = HIMOPMHMMMP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3B43B30", Offset = "0x3B42D30", VA = "0x183B43B30", Slot = "11")]
			public void OJOKKDMOJFN(T MFLACBLODGN, Transform AFODFINCIPG, float AEKGFLEECNO, HIMOPMHMMMP NMCBABBAIJF = HIMOPMHMMMP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3B43B60", Offset = "0x3B42D60", VA = "0x183B43B60", Slot = "12")]
			public void PADFOOPDKDB(T JFCKOKDKNDM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class HNJGDDALAMG : IDisposable, AMGCCPCIEKH
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum MCEANMBCNDP : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class PPJNPFLHCBC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public FACFHHGFGIB DMCMBOAAOKN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public HIMOPMHMMMP DACPBIENDPA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action NLKBBOCEHGP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool JMMGHHNGNOK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int ANPNOFMCDKC;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
				public PPJNPFLHCBC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class NKADNDNNNGG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public HNJGDDALAMG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public PPJNPFLHCBC trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
				public NKADNDNNNGG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x6120D70", Offset = "0x611FF70", VA = "0x186120D70")]
				internal void ABGKJJAKDHM()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int PNHHBJFFBGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int GIPHHNOKIAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int FGDNBAMFLGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool GMBEAIDAPEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup CMLDADGFLBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] CDECPLNEENE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] GDPDBPGMJBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly BOPNLGHAJOA NJKFJGHCCPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<FACFHHGFGIB, int> GLGNECIBMIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, PPJNPFLHCBC> LIHAJPDNJCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly MCEANMBCNDP DCLGHMPIDLD;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool JIPCMALCKOE
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xDE34D0", Offset = "0xDE26D0", VA = "0x180DE34D0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3EDC490", Offset = "0x3EDB690", VA = "0x183EDC490", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6120980", Offset = "0x611FB80", VA = "0x186120980")]
			internal HNJGDDALAMG(int GIPHHNOKIAI, float[] BBNCDOCABLM, MCEANMBCNDP DCLGHMPIDLD = MCEANMBCNDP.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x611FE40", Offset = "0x611F040", VA = "0x18611FE40")]
			public void HLKJHFEPMND(bool OJHHMMMINNN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x61203C0", Offset = "0x611F5C0", VA = "0x1861203C0", Slot = "6")]
			public void OJOKKDMOJFN(FACFHHGFGIB MFLACBLODGN, float AEKGFLEECNO, HIMOPMHMMMP NMCBABBAIJF = HIMOPMHMMMP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x611FFD0", Offset = "0x611F1D0", VA = "0x18611FFD0", Slot = "9")]
			public void OJOKKDMOJFN(FACFHHGFGIB MFLACBLODGN, Transform AFODFINCIPG, float AEKGFLEECNO, HIMOPMHMMMP NMCBABBAIJF = HIMOPMHMMMP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6120830", Offset = "0x611FA30", VA = "0x186120830")]
			public void PAKINMFAOOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x611F280", Offset = "0x611E480", VA = "0x18611F280")]
			private void EKJKENLEDAD(int ILNNGHKJMBD, [Optional] float? AEKGFLEECNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6120450", Offset = "0x611F650", VA = "0x186120450", Slot = "7")]
			public void PADFOOPDKDB(FACFHHGFGIB JFCKOKDKNDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x611FED0", Offset = "0x611F0D0", VA = "0x18611FED0", Slot = "8")]
			public void MBKNMHMDIGF(FACFHHGFGIB MFLACBLODGN, HIMOPMHMMMP MDNIBFLGMNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x611EDE0", Offset = "0x611DFE0", VA = "0x18611EDE0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x611F810", Offset = "0x611EA10", VA = "0x18611F810")]
			private void FJAKDDAPJDK(PPJNPFLHCBC ABADDBGNLJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x611FBA0", Offset = "0x611EDA0", VA = "0x18611FBA0")]
			private void GIICCMDLPIK(PPJNPFLHCBC ABADDBGNLJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x611F220", Offset = "0x611E420", VA = "0x18611F220")]
			private void EHBGHNMEOHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x611FE70", Offset = "0x611F070", VA = "0x18611FE70")]
			private void LGHMFNKBLEN(float HDOBGNHLIBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x611F6D0", Offset = "0x611E8D0", VA = "0x18611F6D0")]
			private void FIGODDAHCAK(PPJNPFLHCBC ABADDBGNLJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x611F0A0", Offset = "0x611E2A0", VA = "0x18611F0A0")]
			private void ECLIJJLJEFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x611FFC0", Offset = "0x611F1C0", VA = "0x18611FFC0")]
			private void OCMBLGPEKEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x611F3B0", Offset = "0x611E5B0", VA = "0x18611F3B0")]
			private void FCCBBGPCMPD(CullingGroupEvent MFFJLEAGDPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x611F0B0", Offset = "0x611E2B0", VA = "0x18611F0B0")]
			private void EFLCGGGNDGN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct NHAIIOHAKPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort BAPAKFFLHGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type GAKEJMFNKOA;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float DBHKKKBJPKH = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float LOLNONPPOAP = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float ANDKPKIDNFH = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float HIMKOFHBKPF = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float OPKHFNFIBFH = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float JANPOJHIGKJ = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float IJOHAACAIIF = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<NHAIIOHAKPD, HNJGDDALAMG> BGEMLAFDHGK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable FFGPEGFNJJB;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable FIEFOAPGHNC;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static DIKKIJJDOON NFPJLAIIGLC;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static DIKKIJJDOON BMGCKMIAMDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly DIKKIJJDOON FGHNGPIADPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly DIKKIJJDOON ONEPNFKGGCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DIKKIJJDOON PODGMLMHGNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EKIPFMKCMNP KEEFIDANNKL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool OJHHMMMINNN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public DIKKIJJDOON MDKBAMFLJBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public DIKKIJJDOON JEIDDMCFHLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DIKKIJJDOON CFGALNDMAEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3D0", Offset = "0x7B95D0", VA = "0x1807BA3D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool MNMLHOGMOMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xC2BC00", Offset = "0xC2AE00", VA = "0x180C2BC00", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool GDIIBNNPOMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x885A60", Offset = "0x884C60", VA = "0x180885A60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x969E00", Offset = "0x969000", VA = "0x180969E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x611DB60", Offset = "0x611CD60", VA = "0x18611DB60", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x611E610", Offset = "0x611D810", VA = "0x18611E610")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x611E5F0", Offset = "0x611D7F0", VA = "0x18611E5F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x611DDA0", Offset = "0x611CFA0", VA = "0x18611DDA0")]
		private void COFFEILCJOP(Scene BABPGNHEAGK, LoadSceneMode GCDFEPGDJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x611E510", Offset = "0x611D710", VA = "0x18611E510", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x611E870", Offset = "0x611DA70", VA = "0x18611E870")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x611E180", Offset = "0x611D380", VA = "0x18611E180")]
		private void HDHJFGLDCPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x611E630", Offset = "0x611D830", VA = "0x18611E630")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x611DC20", Offset = "0x611CE20", VA = "0x18611DC20")]
		private void BNIOCMDDJDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x611DF60", Offset = "0x611D160", VA = "0x18611DF60")]
		public AMGCCPCIEKH GetOrCreateCullingGroup(Type FLMKAPLLKDG, int NEOFIIMLACN, ushort MODHGCAIKIO = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x260EC90", Offset = "0x260DE90", VA = "0x18260EC90")]
		public GLMMBJBJMEG<T> GetOrCreateCullingGroup<T>(int NEOFIIMLACN, ushort MODHGCAIKIO = 0) where T : class, FACFHHGFGIB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x611E320", Offset = "0x611D520", VA = "0x18611E320")]
		private AMGCCPCIEKH LIFODKENINA(Type FLMKAPLLKDG, int NEOFIIMLACN, float[] BBNCDOCABLM, ushort MODHGCAIKIO = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x260ED30", Offset = "0x260DF30", VA = "0x18260ED30")]
		private GLMMBJBJMEG<T> LIFODKENINA<T>(int NEOFIIMLACN, float[] BBNCDOCABLM, ushort MODHGCAIKIO = 0) where T : class, FACFHHGFGIB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x611DE00", Offset = "0x611D000", VA = "0x18611DE00")]
		public static OCINGNKOJDN FindClosestDefaultUpdateLod(float LDHOCBIGDAF)
		{
			return default(OCINGNKOJDN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7E8F60", Offset = "0x7E8160", VA = "0x1807E8F60")]
		public static OCINGNKOJDN MinUpdateLod(OCINGNKOJDN DHIBBENDGJH, OCINGNKOJDN NACEGDNIKCB)
		{
			return default(OCINGNKOJDN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x611E500", Offset = "0x611D700", VA = "0x18611E500")]
		public static OCINGNKOJDN MaxUpdateLod(OCINGNKOJDN DHIBBENDGJH, OCINGNKOJDN NACEGDNIKCB)
		{
			return default(OCINGNKOJDN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x611ECE0", Offset = "0x611DEE0", VA = "0x18611ECE0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BOPNLGHAJOA
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool HAHLPPNDPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera NEKFJAMHDKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DIKKIJJDOON KHBMNGKOBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool MGEDBALLADD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DIKKIJJDOON PGGDAHAONIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform LKFCEPGIEPO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AMGCCPCIEKH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool JIPCMALCKOE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJOKKDMOJFN(FACFHHGFGIB MFLACBLODGN, float AEKGFLEECNO, HIMOPMHMMMP NMCBABBAIJF = HIMOPMHMMMP.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PADFOOPDKDB(FACFHHGFGIB JFCKOKDKNDM);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBKNMHMDIGF(FACFHHGFGIB MFLACBLODGN, HIMOPMHMMMP AEHMHJHJIAI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GLMMBJBJMEG<T> : AMGCCPCIEKH where T : class, FACFHHGFGIB
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJOKKDMOJFN(T MFLACBLODGN, float AEKGFLEECNO, HIMOPMHMMMP NMCBABBAIJF = HIMOPMHMMMP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJOKKDMOJFN(T MFLACBLODGN, Transform AFODFINCIPG, float AEKGFLEECNO, HIMOPMHMMMP NMCBABBAIJF = HIMOPMHMMMP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PADFOOPDKDB(T JFCKOKDKNDM);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FACFHHGFGIB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform ABJBIFMIENO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(OCINGNKOJDN AADGLEEKKEE, OCINGNKOJDN IKOMCBPPDOD);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool MEDFHLPAELI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum HIMOPMHMMMP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum OCINGNKOJDN
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Invalid = -1
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
