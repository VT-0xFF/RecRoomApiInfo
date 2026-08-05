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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, MLNBJLGNJGF
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private abstract class DJPOPOACIJC : IDisposable, ILPGPAKNECF
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public abstract int KMKBNEJECPC
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(Slot = "9")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public abstract int IFDLJOBOAKB
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void Dispose();

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void ABDGJNMBJHB();

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void GEMPJKOLBCH(bool ADBIFABNNGH);

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			protected DJPOPOACIJC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class KANGDFFGDOM<T> : DJPOPOACIJC, global::OOBNBNKOOKI<T>, ILPGPAKNECF where T : PFIJDIGABBI
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum KFHJCBOAAJG : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class BNEDGLMJMNN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public T HPBAFHAKIGP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public JBPNMMKHLAH LODGJMPINDD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action JOHBLAJBOMH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool IEJOAANFCGF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int LEADIMEMNFB;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
				public BNEDGLMJMNN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class LPJGBGMMHGD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public KANGDFFGDOM<T> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public BNEDGLMJMNN trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
				public LPJGBGMMHGD()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int GIONGJCJHEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int ECLLNLJICBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int MOEHNNDFGCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool KCKLADPBJBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup GNIIDFGPBBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] CJBLEGDELEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] CMOHJEDHNPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly GGPIMAGHEEJ LLALMPDIGPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<T, int> IILKBGBFOFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, BNEDGLMJMNN> IIJGOMDJJIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly KFHJCBOAAJG CGDCLDKHAKD;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public override int KMKBNEJECPC
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x5E4ED0", Offset = "0x5E3AD0", VA = "0x1805E4ED0", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int IFDLJOBOAKB
			{
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x608710", Offset = "0x607310", VA = "0x180608710", Slot = "10")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1E246D0", Offset = "0x1E232D0", VA = "0x181E246D0")]
			internal KANGDFFGDOM(int ECLLNLJICBJ, float[] MHDEHICPDJE, KFHJCBOAAJG CGDCLDKHAKD = KFHJCBOAAJG.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1E23640", Offset = "0x1E22240", VA = "0x181E23640", Slot = "11")]
			public override void GEMPJKOLBCH(bool ADBIFABNNGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1E23D20", Offset = "0x1E22920", VA = "0x181E23D20", Slot = "12")]
			public EKAMMBKIPGE LOEACMEPBEP(float CKDDHPPMEOF)
			{
				return default(EKAMMBKIPGE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1E23B30", Offset = "0x1E22730", VA = "0x181E23B30", Slot = "13")]
			public void JNIPLPDFDNO(T HLJJNKOAONN, float MFOJOPJIDAP, JBPNMMKHLAH KCEGBNOPMDJ = JBPNMMKHLAH.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1E236B0", Offset = "0x1E222B0", VA = "0x181E236B0", Slot = "14")]
			public void JNIPLPDFDNO(T HLJJNKOAONN, Transform EMFHJGOKCMF, float MFOJOPJIDAP, JBPNMMKHLAH KCEGBNOPMDJ = JBPNMMKHLAH.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1E227D0", Offset = "0x1E213D0", VA = "0x181E227D0", Slot = "8")]
			public override void ABDGJNMBJHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1E24120", Offset = "0x1E22D20", VA = "0x181E24120", Slot = "15")]
			public void NGAIEGDEMLK(T HLJJNKOAONN, [Optional] float? MFOJOPJIDAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1E22AC0", Offset = "0x1E216C0", VA = "0x181E22AC0")]
			private void DJNBPOMKJII(int BAOHKIGDOBF, [Optional] float? MFOJOPJIDAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1E23D80", Offset = "0x1E22980", VA = "0x181E23D80", Slot = "16")]
			public void MAHLOMNJIKK(T MEHBHNFLAKC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1E23BD0", Offset = "0x1E227D0", VA = "0x181E23BD0", Slot = "17")]
			public EKAMMBKIPGE KHIOJPGGKHC(T HLJJNKOAONN)
			{
				return default(EKAMMBKIPGE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1E229C0", Offset = "0x1E215C0", VA = "0x181E229C0", Slot = "18")]
			public bool DCANMFJPJBH(T HLJJNKOAONN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1E23510", Offset = "0x1E22110", VA = "0x181E23510", Slot = "19")]
			public void EHOBGNANBBP(T HLJJNKOAONN, JBPNMMKHLAH GLPPOFHGMBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1E23020", Offset = "0x1E21C20", VA = "0x181E23020", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1E22C70", Offset = "0x1E21870", VA = "0x181E22C70")]
			private void DMKPICNFHDA(BNEDGLMJMNN EAPCNCBCABO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1E24450", Offset = "0x1E23050", VA = "0x181E24450")]
			private void PHKNKMLJJKL(BNEDGLMJMNN EAPCNCBCABO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1E22C00", Offset = "0x1E21800", VA = "0x181E22C00")]
			private void DKKOOLDJLOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1E22950", Offset = "0x1E21550", VA = "0x181E22950")]
			private void CDKCBKIANML(float KNGIDGOCLLP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1E23670", Offset = "0x1E22270", VA = "0x181E23670")]
			private void HIPPEPCHOAO(BNEDGLMJMNN EAPCNCBCABO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x1E23620", Offset = "0x1E22220", VA = "0x181E23620")]
			private void EHPOMJKMMIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1E23CF0", Offset = "0x1E228F0", VA = "0x181E23CF0")]
			private void KPMJCEDNDML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x1E241A0", Offset = "0x1E22DA0", VA = "0x181E241A0")]
			private void PDLAJLGDHED(CullingGroupEvent NKJFMCNLJMP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1E233A0", Offset = "0x1E21FA0", VA = "0x181E233A0")]
			private void ECPPFLMIBPN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct FENIAKLGLGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort IFBEMDLKBBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type FLIFLKFBEMN;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float CGLMCFKJEJP = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float BAAKKFMCIDF = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float OMJJDFBBFLL = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float IANDMEHNGMA = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float NMOLDKIACNM = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float OFJNFHDBOHP = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float AFGOPNJEJLG = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<FENIAKLGLGN, DJPOPOACIJC> HCBJDPLJNCL;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable CHFPCBPKABB;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable HNPIHBPDECF;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static COJGPCFANME DIGKCFEHIPA;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static COJGPCFANME HNHALFLGNAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly COJGPCFANME CIDBECMGGHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly COJGPCFANME KEIINBGHKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly COJGPCFANME MHIEFEDDAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private ILEKNFOCKKN GGNBJHOIEGL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool ADBIFABNNGH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public COJGPCFANME BFPHMAFLBKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public COJGPCFANME NIDPLEDNBJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public COJGPCFANME DIBGAFFJDMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x60D0C0", Offset = "0x60BCC0", VA = "0x18060D0C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool OLKPOPGECDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x16ED2C0", Offset = "0x16EBEC0", VA = "0x1816ED2C0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool HHOMLIFHJAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7D5E70", Offset = "0x7D4A70", VA = "0x1807D5E70", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7D5EF0", Offset = "0x7D4AF0", VA = "0x1807D5EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5827950", Offset = "0x5826550", VA = "0x185827950", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE6C430", Offset = "0xE6B030", VA = "0x180E6C430")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x58280B0", Offset = "0x5826CB0", VA = "0x1858280B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5827D40", Offset = "0x5826940", VA = "0x185827D40")]
		private void JNIPPCPFIEE(Scene FCFPJLBNMLP, LoadSceneMode DJEGGGAIOHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5828000", Offset = "0x5826C00", VA = "0x185828000", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5828330", Offset = "0x5826F30", VA = "0x185828330")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5827E60", Offset = "0x5826A60", VA = "0x185827E60")]
		private void NDFFKPCHEAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x58280D0", Offset = "0x5826CD0", VA = "0x1858280D0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x58279F0", Offset = "0x58265F0", VA = "0x1858279F0")]
		private void FPOBHOJIIIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28ACF40", Offset = "0x28ABB40", VA = "0x1828ACF40")]
		public global::OOBNBNKOOKI<T> GetOrCreateCullingGroup<T>(int ADGJALDFFCC, ushort DDEMPLNPIEC = 0) where T : PFIJDIGABBI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28ACFF0", Offset = "0x28ABBF0", VA = "0x1828ACFF0")]
		private global::OOBNBNKOOKI<T> MODKBFLAHDB<T>(int ADGJALDFFCC, float[] MHDEHICPDJE, ushort DDEMPLNPIEC = 0) where T : PFIJDIGABBI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5827B50", Offset = "0x5826750", VA = "0x185827B50")]
		public static EKAMMBKIPGE FindClosestDefaultUpdateLod(float OFBCHNLJKCH)
		{
			return default(EKAMMBKIPGE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5827E00", Offset = "0x5826A00", VA = "0x185827E00")]
		public static EKAMMBKIPGE MinUpdateLod(EKAMMBKIPGE MKMOEMIJMAP, EKAMMBKIPGE IPKOAHJMKBE)
		{
			return default(EKAMMBKIPGE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5827DA0", Offset = "0x58269A0", VA = "0x185827DA0")]
		public static EKAMMBKIPGE MaxUpdateLod(EKAMMBKIPGE MKMOEMIJMAP, EKAMMBKIPGE IPKOAHJMKBE)
		{
			return default(EKAMMBKIPGE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x58285B0", Offset = "0x58271B0", VA = "0x1858285B0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GGPIMAGHEEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool CGHHDPNHPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Camera INNJGBNHGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	COJGPCFANME IEFCBEEFHMN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool ABEFKLDJJFO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	COJGPCFANME EJDCNFMMGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform ADFCDICLBNA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ILPGPAKNECF
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int KMKBNEJECPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int IFDLJOBOAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OOBNBNKOOKI<T> : ILPGPAKNECF where T : PFIJDIGABBI
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EKAMMBKIPGE LOEACMEPBEP(float CKDDHPPMEOF);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNIPLPDFDNO(T HLJJNKOAONN, float MFOJOPJIDAP, JBPNMMKHLAH KCEGBNOPMDJ = JBPNMMKHLAH.Off);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JNIPLPDFDNO(T HLJJNKOAONN, Transform EMFHJGOKCMF, float MFOJOPJIDAP, JBPNMMKHLAH KCEGBNOPMDJ = JBPNMMKHLAH.Off);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NGAIEGDEMLK(T HLJJNKOAONN, [Optional] float? MFOJOPJIDAP);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MAHLOMNJIKK(T MEHBHNFLAKC);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EKAMMBKIPGE KHIOJPGGKHC(T HLJJNKOAONN);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DCANMFJPJBH(T HLJJNKOAONN);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EHOBGNANBBP(T HLJJNKOAONN, JBPNMMKHLAH HMGLLPNNLCB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PFIJDIGABBI
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform DMEEHMHNHEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(EKAMMBKIPGE EPKEOEMNOIO, EKAMMBKIPGE DODDDBPKHKH);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool BEKDDDNKDBF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum JBPNMMKHLAH : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum EKAMMBKIPGE
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
public class GAFGMAEONNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private EKAMMBKIPGE LAKDIHOJGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private EKAMMBKIPGE COIOJNIHJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, EKAMMBKIPGE> NKIKJCAPJLB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool MINNDPBDKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5828E60", Offset = "0x5827A60", VA = "0x185828E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public EKAMMBKIPGE CKKPELBEEOP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5E4ED0", Offset = "0x5E3AD0", VA = "0x1805E4ED0")]
		get
		{
			return default(EKAMMBKIPGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public EKAMMBKIPGE LBPPGCPFOGK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x608710", Offset = "0x607310", VA = "0x180608710")]
		get
		{
			return default(EKAMMBKIPGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5828EB0", Offset = "0x5827AB0", VA = "0x185828EB0")]
	public bool JOMHIKHKDFI(object BNKIDKMECMP, EKAMMBKIPGE PDMPLJICJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5828E00", Offset = "0x5827A00", VA = "0x185828E00")]
	public bool GNDHHKOLNLK(object BNKIDKMECMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5828C90", Offset = "0x5827890", VA = "0x185828C90")]
	private bool GAPIDKHCNPD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5828F20", Offset = "0x5827B20", VA = "0x185828F20")]
	public GAFGMAEONNM()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FFJPKCHAMHH
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] JNJHEFFMOCP;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int IPFMGPPGOLG;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int LHFIEOGDAOP;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger AMDHHIFBNAO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public FFJPKCHAMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x58289D0", Offset = "0x58275D0", VA = "0x1858289D0")]
	private static string OFIDAIMKACA(byte[] DBJNEGCCKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x58286A0", Offset = "0x58272A0", VA = "0x1858286A0")]
	public static string MOEDIEOHEKO(byte[] DNJADMBKFKK, bool KBNEPACBOAE)
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

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
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
