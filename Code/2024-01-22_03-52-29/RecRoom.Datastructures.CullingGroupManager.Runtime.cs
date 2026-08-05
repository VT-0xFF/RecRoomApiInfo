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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, MGDBKGBBNLH
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class FKBLCKPHAFP<T> : GGIJEKMBLNB, KANGDHOJFKB<T>, OLHCGEIINID where T : class, FIEBEGLBPNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x36B6370", Offset = "0x36B5770", VA = "0x1836B6370")]
			internal FKBLCKPHAFP(int PFAKCOOOKLG, float[] LAACMOAJHFJ, PJGCFMFJJLM GMPINLPCENF = PJGCFMFJJLM.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x36B62F0", Offset = "0x36B56F0", VA = "0x1836B62F0", Slot = "10")]
			public void DEAIBIAHPPK(T DFFBALIDCLL, float MJHNLFCGBDF, DHCAIOMHELP HCPNGFBDBGN = DHCAIOMHELP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x36B6320", Offset = "0x36B5720", VA = "0x1836B6320", Slot = "11")]
			public void DEAIBIAHPPK(T DFFBALIDCLL, Transform LEIHFDDGCCK, float MJHNLFCGBDF, DHCAIOMHELP HCPNGFBDBGN = DHCAIOMHELP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x36B6350", Offset = "0x36B5750", VA = "0x1836B6350", Slot = "12")]
			public void FKMFNEFKHJM(T JIFBCBOJMPJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class GGIJEKMBLNB : IDisposable, OLHCGEIINID
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum PJGCFMFJJLM : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class FGHDEBNIHNH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public FIEBEGLBPNG PEGLAKOCCNI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public DHCAIOMHELP EEAMNKMPOHJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action LLBNKJJGJGG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool GPLHEFFMCEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int GOBEDCIKOGJ;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
				public FGHDEBNIHNH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class JBIFJIKLLIB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public GGIJEKMBLNB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public FGHDEBNIHNH trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
				public JBIFJIKLLIB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5FDF4E0", Offset = "0x5FDE8E0", VA = "0x185FDF4E0")]
				internal void EPNJMPFJBAC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int LMMDMBCCCKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int PFAKCOOOKLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int BMGOHACPBOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool ENCMOAFILAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup PKMBOGLOOMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] MEFHOMEIBGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] PNOKLMBAFGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly NMIANAIAOFF HLPGFGOCKFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<FIEBEGLBPNG, int> DMNLECHIPMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, FGHDEBNIHNH> JDHLLKONMCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly PJGCFMFJJLM GMPINLPCENF;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool CDHLJOLJFIK
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x1B06AA0", Offset = "0x1B05EA0", VA = "0x181B06AA0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3E5EC30", Offset = "0x3E5E030", VA = "0x183E5EC30", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5FDF0F0", Offset = "0x5FDE4F0", VA = "0x185FDF0F0")]
			internal GGIJEKMBLNB(int PFAKCOOOKLG, float[] LAACMOAJHFJ, PJGCFMFJJLM GMPINLPCENF = PJGCFMFJJLM.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5FDEAA0", Offset = "0x5FDDEA0", VA = "0x185FDEAA0")]
			public void KAKBOHBLPPH(bool MJIFAMDFBLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5FDDCC0", Offset = "0x5FDD0C0", VA = "0x185FDDCC0", Slot = "6")]
			public void DEAIBIAHPPK(FIEBEGLBPNG DFFBALIDCLL, float MJHNLFCGBDF, DHCAIOMHELP HCPNGFBDBGN = DHCAIOMHELP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5FDD8D0", Offset = "0x5FDCCD0", VA = "0x185FDD8D0", Slot = "9")]
			public void DEAIBIAHPPK(FIEBEGLBPNG DFFBALIDCLL, Transform LEIHFDDGCCK, float MJHNLFCGBDF, DHCAIOMHELP HCPNGFBDBGN = DHCAIOMHELP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5FDE180", Offset = "0x5FDD580", VA = "0x185FDE180")]
			public void ELBFBMLLPCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5FDEFC0", Offset = "0x5FDE3C0", VA = "0x185FDEFC0")]
			private void PCHJBGBDDJA(int FGBBDGJMFEH, [Optional] float? MJHNLFCGBDF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5FDE2D0", Offset = "0x5FDD6D0", VA = "0x185FDE2D0", Slot = "7")]
			public void FKMFNEFKHJM(FIEBEGLBPNG JIFBCBOJMPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5FDEAD0", Offset = "0x5FDDED0", VA = "0x185FDEAD0", Slot = "8")]
			public void KPLLBJOLBCE(FIEBEGLBPNG DFFBALIDCLL, DHCAIOMHELP EDKOFMCNOFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5FDDD50", Offset = "0x5FDD150", VA = "0x185FDDD50", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5FDEC30", Offset = "0x5FDE030", VA = "0x185FDEC30")]
			private void OMMFEIIKAGJ(FGHDEBNIHNH GMCFHGJNALG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5FDE6C0", Offset = "0x5FDDAC0", VA = "0x185FDE6C0")]
			private void GGGAHHMDALA(FGHDEBNIHNH GMCFHGJNALG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5FDD550", Offset = "0x5FDC950", VA = "0x185FDD550")]
			private void BMMPNFIAGCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5FDEBD0", Offset = "0x5FDDFD0", VA = "0x185FDEBD0")]
			private void MGBKHKONLDI(float IILLPFGJNOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5FDE960", Offset = "0x5FDDD60", VA = "0x185FDE960")]
			private void GGKBGKIOGJL(FGHDEBNIHNH GMCFHGJNALG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5FDE6B0", Offset = "0x5FDDAB0", VA = "0x185FDE6B0")]
			private void FOPEFLDCNMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5FDEBC0", Offset = "0x5FDDFC0", VA = "0x185FDEBC0")]
			private void LOAKGCFPBKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5FDD5B0", Offset = "0x5FDC9B0", VA = "0x185FDD5B0")]
			private void CEGLAOIKJEO(CullingGroupEvent FMAJPJHAMFI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5FDE010", Offset = "0x5FDD410", VA = "0x185FDE010")]
			private void EJHOCJEACHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct HHLPHHNDDAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort INNEJPEHNOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type IOBOEELNCEK;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float PHGLNCGCGEG = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float NMFIGIGEAED = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float LDPCBMLMKHG = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float GHBPLKHBPGF = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float HLEGLCGFOMI = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float JFPEFGELGGA = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float IAIMEEDNGJP = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<HHLPHHNDDAB, GGIJEKMBLNB> HFLHFAOIGOA;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable DHNGEHHHFAN;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable BHPCLEMBFFP;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static DECPPMKECOG MDNAJGDIHGH;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static DECPPMKECOG KOBCCIFNGEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly DECPPMKECOG JMMBNJAINOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly DECPPMKECOG CEIIBBINMFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DECPPMKECOG LGGBGMAEIOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private DEMHINFLCEG ENBFFDCNMHB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool MJIFAMDFBLI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public DECPPMKECOG GAEBHEBBACM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public DECPPMKECOG MFAKOEECMBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DECPPMKECOG AOCCOCKABLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7940D0", Offset = "0x7934D0", VA = "0x1807940D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool GDKCOIEEJCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xBFC050", Offset = "0xBFB450", VA = "0x180BFC050", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool MGINDFCKMDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7E49A0", Offset = "0x7E3DA0", VA = "0x1807E49A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7E4980", Offset = "0x7E3D80", VA = "0x1807E4980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5FDC2D0", Offset = "0x5FDB6D0", VA = "0x185FDC2D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5FDCD80", Offset = "0x5FDC180", VA = "0x185FDCD80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5FDCD60", Offset = "0x5FDC160", VA = "0x185FDCD60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5FDCC20", Offset = "0x5FDC020", VA = "0x185FDCC20")]
		private void NMGLIINJCAF(Scene ONBCIIKFKKK, LoadSceneMode PEOLLHJDPED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FDCC80", Offset = "0x5FDC080", VA = "0x185FDCC80", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FDCFE0", Offset = "0x5FDC3E0", VA = "0x185FDCFE0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FDC390", Offset = "0x5FDB790", VA = "0x185FDC390")]
		private void BLBOJNPMIGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FDCDA0", Offset = "0x5FDC1A0", VA = "0x185FDCDA0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FDCA90", Offset = "0x5FDBE90", VA = "0x185FDCA90")]
		private void JMLLKHJPJJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5FDC690", Offset = "0x5FDBA90", VA = "0x185FDC690")]
		public OLHCGEIINID GetOrCreateCullingGroup(Type PICIJFKHPMA, int HPFNIONDCOB, ushort KEFIHDICHHJ = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x249B5C0", Offset = "0x249A9C0", VA = "0x18249B5C0")]
		public KANGDHOJFKB<T> GetOrCreateCullingGroup<T>(int HPFNIONDCOB, ushort KEFIHDICHHJ = 0) where T : class, FIEBEGLBPNG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5FDC8B0", Offset = "0x5FDBCB0", VA = "0x185FDC8B0")]
		private OLHCGEIINID JCKNHDLGGPA(Type PICIJFKHPMA, int HPFNIONDCOB, float[] LAACMOAJHFJ, ushort KEFIHDICHHJ = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x249B660", Offset = "0x249AA60", VA = "0x18249B660")]
		private KANGDHOJFKB<T> JCKNHDLGGPA<T>(int HPFNIONDCOB, float[] LAACMOAJHFJ, ushort KEFIHDICHHJ = 0) where T : class, FIEBEGLBPNG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5FDC530", Offset = "0x5FDB930", VA = "0x185FDC530")]
		public static ELKPCEJHCMJ FindClosestDefaultUpdateLod(float IMGCMNCPCLC)
		{
			return default(ELKPCEJHCMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFB0", Offset = "0x7BD3B0", VA = "0x1807BDFB0")]
		public static ELKPCEJHCMJ MinUpdateLod(ELKPCEJHCMJ NDNCIHBLCHP, ELKPCEJHCMJ JPAKOOFMOCI)
		{
			return default(ELKPCEJHCMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5FDCC10", Offset = "0x5FDC010", VA = "0x185FDCC10")]
		public static ELKPCEJHCMJ MaxUpdateLod(ELKPCEJHCMJ NDNCIHBLCHP, ELKPCEJHCMJ JPAKOOFMOCI)
		{
			return default(ELKPCEJHCMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD450", Offset = "0x5FDC850", VA = "0x185FDD450")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NMIANAIAOFF
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool APFEIFOGMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera IDEMAEFPDKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DECPPMKECOG NBJCIHMAEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool FPKIOLHFHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DECPPMKECOG MIMJPOIBDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform FHCFJCKMMJH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OLHCGEIINID
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool CDHLJOLJFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DEAIBIAHPPK(FIEBEGLBPNG DFFBALIDCLL, float MJHNLFCGBDF, DHCAIOMHELP HCPNGFBDBGN = DHCAIOMHELP.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FKMFNEFKHJM(FIEBEGLBPNG JIFBCBOJMPJ);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KPLLBJOLBCE(FIEBEGLBPNG DFFBALIDCLL, DHCAIOMHELP IMFCNJNHIIB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KANGDHOJFKB<T> : OLHCGEIINID where T : class, FIEBEGLBPNG
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEAIBIAHPPK(T DFFBALIDCLL, float MJHNLFCGBDF, DHCAIOMHELP HCPNGFBDBGN = DHCAIOMHELP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DEAIBIAHPPK(T DFFBALIDCLL, Transform LEIHFDDGCCK, float MJHNLFCGBDF, DHCAIOMHELP HCPNGFBDBGN = DHCAIOMHELP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FKMFNEFKHJM(T JIFBCBOJMPJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FIEBEGLBPNG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform FIFLCPFGAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(ELKPCEJHCMJ GHNMBFBCDGF, ELKPCEJHCMJ JNBGDEOKOLP);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool DJGHECGIPOO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum DHCAIOMHELP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum ELKPCEJHCMJ
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
