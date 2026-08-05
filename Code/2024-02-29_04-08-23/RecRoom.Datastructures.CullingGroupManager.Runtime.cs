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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, DODDKKLBDDP
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class JCPNHGDFALP<T> : BNOOMCIMPDI, LIGBJGCCHLG<T>, AFLEKNEEHDF where T : class, FMFFPEPNOGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3A1F780", Offset = "0x3A1E580", VA = "0x183A1F780")]
			internal JCPNHGDFALP(int IIALJOFPJCI, float[] OBPCJNJONED, NHKFOGIHLGL PKPFCALBDAH = NHKFOGIHLGL.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3A1F700", Offset = "0x3A1E500", VA = "0x183A1F700", Slot = "10")]
			public void ANMBPKAMKOK(T NHLNHJGAONN, float LLPCJKICLFP, FHGPIDLFGGI JGBGMNBJLGM = FHGPIDLFGGI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3A1F730", Offset = "0x3A1E530", VA = "0x183A1F730", Slot = "11")]
			public void ANMBPKAMKOK(T NHLNHJGAONN, Transform KKNIKIGLDDE, float LLPCJKICLFP, FHGPIDLFGGI JGBGMNBJLGM = FHGPIDLFGGI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3A1F760", Offset = "0x3A1E560", VA = "0x183A1F760", Slot = "12")]
			public void JJGPDDBMEBN(T PMBNMEFNKEM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class BNOOMCIMPDI : IDisposable, AFLEKNEEHDF
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum NHKFOGIHLGL : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class EBHJADLGFMK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public FMFFPEPNOGI FELLAFAONPG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public FHGPIDLFGGI KHALAKAOIKN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action LGIGLCAAAPI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool LKLNOKCMLCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int CCEAOHGDFHD;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
				public EBHJADLGFMK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class BMDPPMOBKNA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public BNOOMCIMPDI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public EBHJADLGFMK trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
				public BMDPPMOBKNA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5FC4460", Offset = "0x5FC3260", VA = "0x185FC4460")]
				internal void POPAJIFJDCH()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int EGHMCECCGIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int IIALJOFPJCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int ILMMPAFNNBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool OADMEOKPNBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup CGKANCPOHOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] IGOJDMDOFDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] BBLJEJNNCOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly DPALIBGNILE ADOCEOOMFBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<FMFFPEPNOGI, int> CADOKFKMEEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, EBHJADLGFMK> KBKIKDJCBCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly NHKFOGIHLGL PKPFCALBDAH;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool FBGCIJMJEAB
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xD50D50", Offset = "0xD4FB50", VA = "0x180D50D50")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3E3F1A0", Offset = "0x3E3DFA0", VA = "0x183E3F1A0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6150", Offset = "0x5FC4F50", VA = "0x185FC6150")]
			internal BNOOMCIMPDI(int IIALJOFPJCI, float[] OBPCJNJONED, NHKFOGIHLGL PKPFCALBDAH = NHKFOGIHLGL.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5BF0", Offset = "0x5FC49F0", VA = "0x185FC5BF0")]
			public void LEAMOGPLNNI(bool CNHKBPCNOAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5FC4700", Offset = "0x5FC3500", VA = "0x185FC4700", Slot = "6")]
			public void ANMBPKAMKOK(FMFFPEPNOGI NHLNHJGAONN, float LLPCJKICLFP, FHGPIDLFGGI JGBGMNBJLGM = FHGPIDLFGGI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5FC4790", Offset = "0x5FC3590", VA = "0x185FC4790", Slot = "9")]
			public void ANMBPKAMKOK(FMFFPEPNOGI NHLNHJGAONN, Transform KKNIKIGLDDE, float LLPCJKICLFP, FHGPIDLFGGI JGBGMNBJLGM = FHGPIDLFGGI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5FC45B0", Offset = "0x5FC33B0", VA = "0x185FC45B0")]
			public void AKPEGILEBKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5D60", Offset = "0x5FC4B60", VA = "0x185FC5D60")]
			private void NBNCIBGGEPM(int ENPOKNEMOMH, [Optional] float? LLPCJKICLFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5800", Offset = "0x5FC4600", VA = "0x185FC5800", Slot = "7")]
			public void JJGPDDBMEBN(FMFFPEPNOGI PMBNMEFNKEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6000", Offset = "0x5FC4E00", VA = "0x185FC6000", Slot = "8")]
			public void OLDAJKGJFOG(FMFFPEPNOGI NHLNHJGAONN, FHGPIDLFGGI FFMGMKFAHGL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5FC4B90", Offset = "0x5FC3990", VA = "0x185FC4B90", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5470", Offset = "0x5FC4270", VA = "0x185FC5470")]
			private void IIKAEJLLIOO(EBHJADLGFMK BPCLPJOEIBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5FC51D0", Offset = "0x5FC3FD0", VA = "0x185FC51D0")]
			private void FNCAJMMKAEG(EBHJADLGFMK BPCLPJOEIBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5170", Offset = "0x5FC3F70", VA = "0x185FC5170")]
			private void FLOGENOHHBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5FC60F0", Offset = "0x5FC4EF0", VA = "0x185FC60F0")]
			private void PEDEGDFMFHL(float KNBDFHCBHGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5C20", Offset = "0x5FC4A20", VA = "0x185FC5C20")]
			private void MMLBHFNMCOC(EBHJADLGFMK BPCLPJOEIBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5FC4B80", Offset = "0x5FC3980", VA = "0x185FC4B80")]
			private void BPFDKLLOLFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5BE0", Offset = "0x5FC49E0", VA = "0x185FC5BE0")]
			private void KNPEFIBKAPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5FC4E50", Offset = "0x5FC3C50", VA = "0x185FC4E50")]
			private void FHIFFHDNGCI(CullingGroupEvent NNHFFLALGOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5E90", Offset = "0x5FC4C90", VA = "0x185FC5E90")]
			private void OAIIOJDJNKP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct CPLFEJHEKAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort HGCCDFCBDCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type CANMNDHBCFD;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float JKCOAHLAEGC = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float OPDJCENPJKD = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float JAFPEJMKMDC = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float PNEBFLIEBMO = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float BBDECOGDJFI = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float OPNLFFALHED = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float JPCPNNCJKJB = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<CPLFEJHEKAP, BNOOMCIMPDI> IPGABBGMMGL;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable BMFIAPOPKNI;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable NPPJLHJKDDC;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static BHHPLLLFBGO KCJJAGKJAOE;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static BHHPLLLFBGO JPDIFNPBGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly BHHPLLLFBGO JPEEKPDPNEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly BHHPLLLFBGO PPKIOEHNDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly BHHPLLLFBGO PLFODIGFIID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private JAAHELMEOKP PEDLDOELEJF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool CNHKBPCNOAG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public BHHPLLLFBGO OJKCLDOPGPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public BHHPLLLFBGO NEBEFCLEBHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public BHHPLLLFBGO OFNGLDBNODJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x1807A8200", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool PPAFNGAGJCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xC0C4C0", Offset = "0xC0B2C0", VA = "0x180C0C4C0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool IELHHNDPJFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x800F00", Offset = "0x7FFD00", VA = "0x180800F00", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x800B30", Offset = "0x7FF930", VA = "0x180800B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6540", Offset = "0x5FC5340", VA = "0x185FC6540", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6FF0", Offset = "0x5FC5DF0", VA = "0x185FC6FF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6FD0", Offset = "0x5FC5DD0", VA = "0x185FC6FD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6E90", Offset = "0x5FC5C90", VA = "0x185FC6E90")]
		private void NCJDNMPIKLG(Scene HDHKKHFDKEN, LoadSceneMode EAPOADFKJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6EF0", Offset = "0x5FC5CF0", VA = "0x185FC6EF0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7250", Offset = "0x5FC6050", VA = "0x185FC7250")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6B00", Offset = "0x5FC5900", VA = "0x185FC6B00")]
		private void KBMPPKGFLEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7010", Offset = "0x5FC5E10", VA = "0x185FC7010")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6600", Offset = "0x5FC5400", VA = "0x185FC6600")]
		private void CEINMBPFEMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5FC68E0", Offset = "0x5FC56E0", VA = "0x185FC68E0")]
		public AFLEKNEEHDF GetOrCreateCullingGroup(Type FHPKBCAEMAJ, int JLFCLMEEGIC, ushort AFKNIJHDJNL = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x25921A0", Offset = "0x2590FA0", VA = "0x1825921A0")]
		public LIGBJGCCHLG<T> GetOrCreateCullingGroup<T>(int JLFCLMEEGIC, ushort AFKNIJHDJNL = 0) where T : class, FMFFPEPNOGI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6CA0", Offset = "0x5FC5AA0", VA = "0x185FC6CA0")]
		private AFLEKNEEHDF LONMJGKAJDK(Type FHPKBCAEMAJ, int JLFCLMEEGIC, float[] OBPCJNJONED, ushort AFKNIJHDJNL = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x25922E0", Offset = "0x25910E0", VA = "0x1825922E0")]
		private LIGBJGCCHLG<T> LONMJGKAJDK<T>(int JLFCLMEEGIC, float[] OBPCJNJONED, ushort AFKNIJHDJNL = 0) where T : class, FMFFPEPNOGI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6780", Offset = "0x5FC5580", VA = "0x185FC6780")]
		public static AMOHOHNPBGH FindClosestDefaultUpdateLod(float EPKGJFHGLEG)
		{
			return default(AMOHOHNPBGH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7D6F60", Offset = "0x7D5D60", VA = "0x1807D6F60")]
		public static AMOHOHNPBGH MinUpdateLod(AMOHOHNPBGH MIODCHKMLPF, AMOHOHNPBGH AKFJPOEGBBG)
		{
			return default(AMOHOHNPBGH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6E80", Offset = "0x5FC5C80", VA = "0x185FC6E80")]
		public static AMOHOHNPBGH MaxUpdateLod(AMOHOHNPBGH MIODCHKMLPF, AMOHOHNPBGH AKFJPOEGBBG)
		{
			return default(AMOHOHNPBGH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5FC76C0", Offset = "0x5FC64C0", VA = "0x185FC76C0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DPALIBGNILE
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool GOBKOLFCIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera MOAPIDKPFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	BHHPLLLFBGO FCBDNGLPBHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool KJPAOOBAIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BHHPLLLFBGO ONKBKEGDNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform BPAGGDMBLBK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AFLEKNEEHDF
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool FBGCIJMJEAB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANMBPKAMKOK(FMFFPEPNOGI NHLNHJGAONN, float LLPCJKICLFP, FHGPIDLFGGI JGBGMNBJLGM = FHGPIDLFGGI.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJGPDDBMEBN(FMFFPEPNOGI PMBNMEFNKEM);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OLDAJKGJFOG(FMFFPEPNOGI NHLNHJGAONN, FHGPIDLFGGI NOHGFNODEED);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LIGBJGCCHLG<T> : AFLEKNEEHDF where T : class, FMFFPEPNOGI
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANMBPKAMKOK(T NHLNHJGAONN, float LLPCJKICLFP, FHGPIDLFGGI JGBGMNBJLGM = FHGPIDLFGGI.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANMBPKAMKOK(T NHLNHJGAONN, Transform KKNIKIGLDDE, float LLPCJKICLFP, FHGPIDLFGGI JGBGMNBJLGM = FHGPIDLFGGI.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJGPDDBMEBN(T PMBNMEFNKEM);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FMFFPEPNOGI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform PFIKOEBPDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(AMOHOHNPBGH CLIAGDNIEBC, AMOHOHNPBGH FGMBHENNCGO);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool MAAMCGOAHPL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum FHGPIDLFGGI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum AMOHOHNPBGH
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
