using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : KBDNGCLCFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5F667C0", Offset = "0x5F655C0", VA = "0x185F667C0", Slot = "4")]
		public override void NLHDMBJLIGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : MLJNMKFIGMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private EENLKAGMGJE bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EENLKAGMGJE bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5F6A100", Offset = "0x5F68F00", VA = "0x185F6A100", Slot = "5")]
		public override void JHOHBHCKFCE(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5F6A140", Offset = "0x5F68F40", VA = "0x185F6A140")]
		private void PHCLPOGNBJN(JIGNBFODIDF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5F69F90", Offset = "0x5F68D90", VA = "0x185F69F90")]
		private void HKHMGINCELK(JIGNBFODIDF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5F6A2B0", Offset = "0x5F690B0", VA = "0x185F6A2B0", Slot = "6")]
		public override void PPJLFIMLGNK(JIGNBFODIDF registry, [In] LCAIGHCIJNG filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "8")]
		public override void MFEEKKLICMI(NMNCJDKLJOJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F6A5F0", Offset = "0x5F693F0", VA = "0x185F6A5F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class BHDMJPEPJHI : NKLFMJNLLPE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class BAKJLKAACFE : IEnumerable<NMNMIBDPDJO>, IEnumerable, IEnumerator<NMNMIBDPDJO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private NMNMIBDPDJO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private MIGCCDNHDEL localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public MIGCCDNHDEL <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BHDMJPEPJHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private NEPAPILBIHM <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private OEAIGCFLLHH.LDHNKJFFHJJ <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private NMNMIBDPDJO System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x947C30", Offset = "0x946A30", VA = "0x180947C30")]
		[DebuggerHidden]
		public BAKJLKAACFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5F53D50", Offset = "0x5F52B50", VA = "0x185F53D50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5F53870", Offset = "0x5F52670", VA = "0x185F53870", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5F53C30", Offset = "0x5F52A30", VA = "0x185F53C30")]
		private void ONJBEDHNBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5F53D00", Offset = "0x5F52B00", VA = "0x185F53D00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5F53C50", Offset = "0x5F52A50", VA = "0x185F53C50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NMNMIBDPDJO> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5F53C50", Offset = "0x5F52A50", VA = "0x185F53C50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly KNPFMNBIIDA PGKJJCPHNLC;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly KNPFMNBIIDA KCLINEOFFHL;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly KNPFMNBIIDA KKFGKOHIBFC;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly KNPFMNBIIDA ELACOHEPNFI;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly KNPFMNBIIDA AINAOLEMIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private OJKBFKGCFKK KKBJMJIMAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private ODIANNFGKAF BIBHPACHOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private DFABAHDIACI PMFFKJBIAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private MOHCHFKKEOL ADOCEOOMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private DKBBMGDJMLO BOMIMJDMIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly GLNICPJCMKM AOLJGMLHFFF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NJDBJPCDOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7BB220", Offset = "0x7BA020", VA = "0x1807BB220", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7BADA0", Offset = "0x7B9BA0", VA = "0x1807BADA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<NMNMIBDPDJO, NMNMIBDPDJO> BHBOMMFJFHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5F542E0", Offset = "0x5F530E0", VA = "0x185F542E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F55C30", Offset = "0x5F54A30", VA = "0x185F55C30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<NMNMIBDPDJO, NMNMIBDPDJO> BFHILKDNPBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F56C20", Offset = "0x5F55A20", VA = "0x185F56C20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F53DB0", Offset = "0x5F52BB0", VA = "0x185F53DB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<NMNMIBDPDJO, NMNMIBDPDJO, NMNMIBDPDJO> KEMGJCBHNAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5F560A0", Offset = "0x5F54EA0", VA = "0x185F560A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5F55FF0", Offset = "0x5F54DF0", VA = "0x185F55FF0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5F584F0", Offset = "0x5F572F0", VA = "0x185F584F0")]
	public BHDMJPEPJHI(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5F554F0", Offset = "0x5F542F0", VA = "0x185F554F0", Slot = "11")]
	public void FCIFMHNEBDM(GameObject IPHCMOEHILB, NNJEBNGKOCO DLJLNBICLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5F55010", Offset = "0x5F53E10", VA = "0x185F55010", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F55CE0", Offset = "0x5F54AE0", VA = "0x185F55CE0", Slot = "21")]
	public bool FOMHKFNGDIK(NACHLOGOMCG ECIIMDOKNPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5F56900", Offset = "0x5F55700", VA = "0x185F56900")]
	private void JBEFIIEHENK(MIGCCDNHDEL BDOJJGEGGMI, MIGCCDNHDEL OAFFMKENDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5F54390", Offset = "0x5F53190", VA = "0x185F54390")]
	private void APBEAOLPICC(MIGCCDNHDEL BDOJJGEGGMI, MIGCCDNHDEL DJELJAKIGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5F55270", Offset = "0x5F54070", VA = "0x185F55270")]
	private void ENEPCDMPNDM(MIGCCDNHDEL BDOJJGEGGMI, MIGCCDNHDEL DJELJAKIGMI, MIGCCDNHDEL OAFFMKENDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5F56150", Offset = "0x5F54F50", VA = "0x185F56150")]
	private void HBOABFNLDKF(MIGCCDNHDEL BDOJJGEGGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "12")]
	public void LLIADGIKINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5F57D50", Offset = "0x5F56B50", VA = "0x185F57D50", Slot = "13")]
	public void NLHDMBJLIGN(NMNMIBDPDJO LGCKGKGAGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "14")]
	public void GLLKHIKCFCF(NMNMIBDPDJO LGCKGKGAGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5F56CD0", Offset = "0x5F55AD0", VA = "0x185F56CD0", Slot = "16")]
	public void JOAFMADFFGJ(NMNMIBDPDJO LGCKGKGAGHK, NMNMIBDPDJO EGPCCONFKKI, Vector3 JCHLCJBNBDI, Quaternion JHGEDFGCAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5F56E30", Offset = "0x5F55C30", VA = "0x185F56E30")]
	public void JOAFMADFFGJ(MIGCCDNHDEL BIFNKFCMILB, MIGCCDNHDEL EGPCCONFKKI, Vector3 JCHLCJBNBDI, Quaternion JHGEDFGCAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5F56870", Offset = "0x5F55670", VA = "0x185F56870")]
	public void IONKIJFJDJN(NMNMIBDPDJO LGCKGKGAGHK, float FIDHJLMONDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5F55E40", Offset = "0x5F54C40", VA = "0x185F55E40", Slot = "17")]
	public void GCOJJLCBECB(NMNMIBDPDJO MPJDPKIIPIL, int GBHMMDGMIOM, NMNMIBDPDJO ENEIIOEOMIG, int GBKOMGKDMHK, Vector3 JCHLCJBNBDI, Quaternion JHGEDFGCAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5F56B70", Offset = "0x5F55970", VA = "0x185F56B70")]
	private float JFCCHIKJJAD(MIGCCDNHDEL BIFNKFCMILB, MIGCCDNHDEL AJKCELPHOFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5F55D10", Offset = "0x5F54B10", VA = "0x185F55D10")]
	public void GCOJJLCBECB(MIGCCDNHDEL BIFNKFCMILB, MIGCCDNHDEL AJKCELPHOFC, Vector3 JCHLCJBNBDI, Quaternion JHGEDFGCAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5F55F90", Offset = "0x5F54D90", VA = "0x185F55F90")]
	public void GCOJJLCBECB(MIGCCDNHDEL BIFNKFCMILB, MIGCCDNHDEL AJKCELPHOFC, Vector3 JCHLCJBNBDI, Quaternion JHGEDFGCAEH, float FIDHJLMONDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5F55760", Offset = "0x5F54560", VA = "0x185F55760", Slot = "18")]
	public void FFDJEDMIAFA(NMNMIBDPDJO LGCKGKGAGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5F572C0", Offset = "0x5F560C0", VA = "0x185F572C0")]
	public bool LMEHONEFJPA(MIGCCDNHDEL IOGJGBJCGKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5F57B40", Offset = "0x5F56940", VA = "0x185F57B40", Slot = "15")]
	public void NEDMNKHPNNF(NMNMIBDPDJO LGCKGKGAGHK, HashSet<NMNMIBDPDJO> LGHLFAFHBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "19")]
	public IJKINIBHBHA KFDFMBOIBFH(bool DBBDMHLJILF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "20")]
	public IJKINIBHBHA PCOGCLMJJMD(HashSet<Guid> CFFHAHOIMKH, bool DBBDMHLJILF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5F54270", Offset = "0x5F53070", VA = "0x185F54270", Slot = "22")]
	public void AMJJIKLBIIF(IJKINIBHBHA DOAPLFMMIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5F56670", Offset = "0x5F55470", VA = "0x185F56670", Slot = "23")]
	public void IEIDNLDBDON(IJKINIBHBHA DOAPLFMMIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5F55CF0", Offset = "0x5F54AF0", VA = "0x185F55CF0", Slot = "24")]
	public void GAEHFCFMCGF(IJKINIBHBHA DOAPLFMMIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5F558D0", Offset = "0x5F546D0", VA = "0x185F558D0")]
	private void FFLDPFFHEBL(MIGCCDNHDEL BIFNKFCMILB, MIGCCDNHDEL AJKCELPHOFC, Vector3 JCHLCJBNBDI, Quaternion JHGEDFGCAEH, float FIDHJLMONDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5F53E60", Offset = "0x5F52C60", VA = "0x185F53E60")]
	private void ADOKDLBKICE(MIGCCDNHDEL BIFNKFCMILB, MIGCCDNHDEL PKMANOIKNOC, Vector3 JCHLCJBNBDI, Quaternion JHGEDFGCAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5F55200", Offset = "0x5F54000", VA = "0x185F55200")]
	private void EBMKBEGMFDN(MIGCCDNHDEL BIFNKFCMILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5F565E0", Offset = "0x5F553E0", VA = "0x185F565E0")]
	[IteratorStateMachine(typeof(BAKJLKAACFE))]
	public IEnumerable<NMNMIBDPDJO> HMKILKPEENL(MIGCCDNHDEL IOGJGBJCGKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5F57890", Offset = "0x5F56690", VA = "0x185F57890")]
	internal NMNMIBDPDJO MMNMJNHEFED(MIGCCDNHDEL IOGJGBJCGKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5F57100", Offset = "0x5F55F00", VA = "0x185F57100")]
	internal MIGCCDNHDEL KOLHFGBFEBP(NMNMIBDPDJO LGCKGKGAGHK)
	{
		return default(MIGCCDNHDEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5F545B0", Offset = "0x5F533B0", VA = "0x185F545B0")]
	private bool CDFLOBDEIFP(NACHLOGOMCG ECIIMDOKNPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5F579D0", Offset = "0x5F567D0", VA = "0x185F579D0")]
	private bool MPAKPNPPGCK(NACHLOGOMCG ECIIMDOKNPG, [Out] NMNMIBDPDJO AJKCELPHOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5F57550", Offset = "0x5F56350", VA = "0x185F57550")]
	private NMNMIBDPDJO MMNMJNHEFED(NACHLOGOMCG ECIIMDOKNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5F54B80", Offset = "0x5F53980", VA = "0x185F54B80")]
	private NMNMIBDPDJO DDEPHPPGMFM(NACHLOGOMCG ECIIMDOKNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5F54EA0", Offset = "0x5F53CA0", VA = "0x185F54EA0")]
	private NMNMIBDPDJO DPDHCFFBNDB(NACHLOGOMCG ECIIMDOKNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5F58340", Offset = "0x5F57140", VA = "0x185F58340")]
	private static Guid PEMEHPDBDPA(NACHLOGOMCG ECIIMDOKNPG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5F571D0", Offset = "0x5F55FD0", VA = "0x185F571D0")]
	private string LJHMBDDBPME(NACHLOGOMCG ECIIMDOKNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5F566E0", Offset = "0x5F554E0", VA = "0x185F566E0")]
	private void ILCLPMDIOBE(NMNMIBDPDJO BIFNKFCMILB, NMNMIBDPDJO PKMANOIKNOC, RigidTransform LDOMCECECHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5F54D10", Offset = "0x5F53B10", VA = "0x185F54D10")]
	private void DEMKJJJFCML(NMNMIBDPDJO PKMANOIKNOC, NMNMIBDPDJO BIFNKFCMILB, RigidTransform LDOMCECECHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5F56B10", Offset = "0x5F55910", VA = "0x185F56B10")]
	private void JEFDCODKNJC(NMNMIBDPDJO MGPBFMAKCJE, NMNMIBDPDJO BIFNKFCMILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5F56F70", Offset = "0x5F55D70", VA = "0x185F56F70")]
	private void KDLCCHCBDCD(NMNMIBDPDJO BIFNKFCMILB, NMNMIBDPDJO AJKCELPHOFC, RigidTransform LDOMCECECHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5F57A30", Offset = "0x5F56830", VA = "0x185F57A30")]
	private void NBKDFPAAGJP(MIGCCDNHDEL IOGJGBJCGKK, NMNMIBDPDJO LGCKGKGAGHK, MIGCCDNHDEL DJELJAKIGMI, MIGCCDNHDEL OAFFMKENDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5F58060", Offset = "0x5F56E60", VA = "0x185F58060")]
	private void NPFGELAEIDL(MIGCCDNHDEL IOGJGBJCGKK, NMNMIBDPDJO LGCKGKGAGHK, NMNMIBDPDJO NGKOCMIIAHD, NMNMIBDPDJO BIEFPFAGGLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BOCMBHOLBMI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MFJFNEJAODP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public IBPIJCMLLGH container;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public MFJFNEJAODP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5F66890", Offset = "0x5F65690", VA = "0x185F66890")]
		internal BHDMJPEPJHI CODIIFCJDOD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5F58560", Offset = "0x5F57360", VA = "0x185F58560")]
	public static void ABJGALHAFIK(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5F586E0", Offset = "0x5F574E0", VA = "0x185F586E0")]
	public static void OBNOGPNCFNO(IBPIJCMLLGH PPDHICBEIFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class HBMAENOCLJC : IKEKLLAMJLB, DNOBKEJGNCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly RigidbodyEx NPOMGMGDKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly BHDMJPEPJHI BMBELBBEHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly NGEECNPKEIN BKGPILCEAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly GIPICFCOEFO ADOCEOOMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly JCCFGGGBDJO[] ONHJHFALOJK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MIGCCDNHDEL AMEJLJKIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(MIGCCDNHDEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NMNMIBDPDJO FNJEIPCGPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5F5BA50", Offset = "0x5F5A850", VA = "0x185F5BA50", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NMNMIBDPDJO FCLMPJBMJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5F5B1A0", Offset = "0x5F59FA0", VA = "0x185F5B1A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 NLAMPGIADCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5F5AFA0", Offset = "0x5F59DA0", VA = "0x185F5AFA0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Quaternion EAPKGAOFAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5F5B800", Offset = "0x5F5A600", VA = "0x185F5B800", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool LODPHFFFKGE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5F5AF30", Offset = "0x5F59D30", VA = "0x185F5AF30", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IEnumerable<NMNMIBDPDJO> AAIMHDCLFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5F5A0A0", Offset = "0x5F58EA0", VA = "0x185F5A0A0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Obsolete]
	public bool MFDMOIODONL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x819140", Offset = "0x817F40", VA = "0x180819140", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x819150", Offset = "0x817F50", VA = "0x180819150", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Transform EHAKBGMPING
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5F5BC60", Offset = "0x5F5AA60", VA = "0x185F5BC60", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public GameObject MNCNLOJBGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x220A230", Offset = "0x2209030", VA = "0x18220A230", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string GMLPMAJDOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5F5B980", Offset = "0x5F5A780", VA = "0x185F5B980", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid MKCJKMELIKM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5F5BAB0", Offset = "0x5F5A8B0", VA = "0x185F5BAB0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int LIBBNOAOHDM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5F5BB90", Offset = "0x5F5A990", VA = "0x185F5BB90", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool BHMDDPGHDAL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private bool MCEANPLKDAH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5F5A8C0", Offset = "0x5F596C0", VA = "0x185F5A8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event ICAHPKCJALP EAJAEEAPPAB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5F59F50", Offset = "0x5F58D50", VA = "0x185F59F50", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5F5AE70", Offset = "0x5F59C70", VA = "0x185F5AE70", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event ICAHPKCJALP MOPBMFKEPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5F5AED0", Offset = "0x5F59CD0", VA = "0x185F5AED0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5F5B210", Offset = "0x5F5A010", VA = "0x185F5B210", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event ICAHPKCJALP MDGDLMDCJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5F5B560", Offset = "0x5F5A360", VA = "0x185F5B560", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5F5AE10", Offset = "0x5F59C10", VA = "0x185F5AE10", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event EJJPJPHFLPF PEOPBDMPPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5F5B2C0", Offset = "0x5F5A0C0", VA = "0x185F5B2C0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5F5A910", Offset = "0x5F59710", VA = "0x185F5A910", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B880", Offset = "0x5F5A680", VA = "0x185F5B880")]
	public HBMAENOCLJC(MIGCCDNHDEL GDLGHGPGIOA, RigidbodyEx NPOMGMGDKBM, NGEECNPKEIN BKGPILCEAML, JCCFGGGBDJO[] ONHJHFALOJK, GIPICFCOEFO ADOCEOOMFBH, NKLFMJNLLPE BMBELBBEHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B7D0", Offset = "0x5F5A5D0", VA = "0x185F5B7D0", Slot = "19")]
	public void PALKBNKHAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "21")]
	public void PEKHJLOCFKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6630", Offset = "0x5DF5430", VA = "0x185DF6630", Slot = "22")]
	public void EDEFMLGLBGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B080", Offset = "0x5F59E80", VA = "0x185F5B080", Slot = "20")]
	public void KJBAIGHFNON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B5C0", Offset = "0x5F5A3C0", VA = "0x185F5B5C0", Slot = "25")]
	public void OKMFJNHNFFP(int NDFKLLHMKEI, NMNMIBDPDJO ENEIIOEOMIG, int IAGGJFALECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B0D0", Offset = "0x5F59ED0", VA = "0x185F5B0D0", Slot = "26")]
	public void KOAHDGPIFGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5F5A0D0", Offset = "0x5F58ED0", VA = "0x185F5A0D0", Slot = "27")]
	public void GNCAGBKJLCD(int NDFKLLHMKEI, NMNMIBDPDJO MPJDPKIIPIL, int BCPBDIPHKKA, [Optional] Vector3? JOBJIFEFMBJ, [Optional] Quaternion? FEEAIHHJNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B000", Offset = "0x5F59E00", VA = "0x185F5B000", Slot = "28")]
	public void KEIAKMFKMGM(NMNMIBDPDJO MPJDPKIIPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5F5A9B0", Offset = "0x5F597B0", VA = "0x185F5A9B0", Slot = "31")]
	public void IANIMBCHINB(Vector3 EJMMMHBDPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5F5A5B0", Offset = "0x5F593B0", VA = "0x185F5A5B0", Slot = "29")]
	public void HBPLPCOJHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B360", Offset = "0x5F5A160", VA = "0x185F5B360", Slot = "30")]
	public void NCBFLMMMAIF(int ENPOKNEMOMH, Vector3 OBIONJJHEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5F5A4E0", Offset = "0x5F592E0", VA = "0x185F5A4E0", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int NDFKLLHMKEI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5F5A3B0", Offset = "0x5F591B0", VA = "0x185F5A3B0", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int NDFKLLHMKEI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7F4600", Offset = "0x7F3400", VA = "0x1807F4600", Slot = "42")]
	public Color GetConnectionSlotColor(int NDFKLLHMKEI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5F5A000", Offset = "0x5F58E00", VA = "0x185F5A000", Slot = "43")]
	public bool CanConnectTo(int NDFKLLHMKEI, NMNMIBDPDJO IEGHKLBOPIG, int BMLMCEEFMNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "44")]
	public void ParentChanged(int NDFKLLHMKEI, NMNMIBDPDJO LNJFPAMCDDA, int PLPBHGJCECD, Vector3 JHJBGADMPCK, Quaternion KBJIJPOJLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "45")]
	public void ChildAdded(int NDFKLLHMKEI, NMNMIBDPDJO MPFFDKEKJAP, int HIEMPBBBBIB, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "46")]
	public void ChildRemoved(int NDFKLLHMKEI, NMNMIBDPDJO DMDOJLFKIDL, int FCCBAPMDONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "47")]
	public void ConnectionModified(int NDFKLLHMKEI, NMNMIBDPDJO ENEIIOEOMIG, int IAGGJFALECJ, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B860", Offset = "0x5F5A660", VA = "0x185F5B860", Slot = "48")]
	public void RootChanged(NMNMIBDPDJO BCCMHPGFDIC, NMNMIBDPDJO IEAIAKBGDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5F59FB0", Offset = "0x5F58DB0", VA = "0x185F59FB0", Slot = "23")]
	public void ANHGIFPFJAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5F5B270", Offset = "0x5F5A070", VA = "0x185F5B270", Slot = "24")]
	public void MCDIBKHJIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5F5ADC0", Offset = "0x5F59BC0", VA = "0x185F5ADC0")]
	private void IIFJIANHIPK(bool EKFPLJIGCJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[HLLKJAAFIAG(typeof(OKBDJMLILFD), new string[] { })]
public class OGPOPNFCBPL : OKBDJMLILFD, JOMLNLBCPPN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class GAHMFECOEKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public OGPOPNFCBPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public OEAIGCFLLHH localIds;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public GAHMFECOEKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5F58F40", Offset = "0x5F57D40", VA = "0x185F58F40")]
		internal void KKACGJINKFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly KNPFMNBIIDA PGKJJCPHNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[PIIHNFKILAB]
	private IAGILOKACFE BBHBOBFDCMB;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public object CFGICOALJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5F67840", Offset = "0x5F66640", VA = "0x185F67840", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5F678D0", Offset = "0x5F666D0", VA = "0x185F678D0", Slot = "6")]
	public void InitReferences(IIHLCNFMGKJ AOLJGMLHFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5F676D0", Offset = "0x5F664D0", VA = "0x185F676D0", Slot = "5")]
	public void DPAINDDOFAF(OEAIGCFLLHH IMKJMOFIELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public OGPOPNFCBPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[HLLKJAAFIAG(typeof(NKLFMJNLLPE), new string[] { "Ignore", "Mock" })]
public class DKDGBDIILOJ : NKLFMJNLLPE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool NJDBJPCDOCO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<NMNMIBDPDJO, NMNMIBDPDJO> BHBOMMFJFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5F58BD0", Offset = "0x5F579D0", VA = "0x185F58BD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5F58C80", Offset = "0x5F57A80", VA = "0x185F58C80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<NMNMIBDPDJO, NMNMIBDPDJO> BFHILKDNPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5F58E90", Offset = "0x5F57C90", VA = "0x185F58E90", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5F58B20", Offset = "0x5F57920", VA = "0x185F58B20", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<NMNMIBDPDJO, NMNMIBDPDJO, NMNMIBDPDJO> KEMGJCBHNAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5F58DE0", Offset = "0x5F57BE0", VA = "0x185F58DE0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5F58D30", Offset = "0x5F57B30", VA = "0x185F58D30", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "11")]
	public void FCIFMHNEBDM(GameObject IPHCMOEHILB, NNJEBNGKOCO DLJLNBICLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "12")]
	public void LLIADGIKINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "13")]
	public void NLHDMBJLIGN(NMNMIBDPDJO LGCKGKGAGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "14")]
	public void GLLKHIKCFCF(NMNMIBDPDJO LGCKGKGAGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "15")]
	public void NEDMNKHPNNF(NMNMIBDPDJO LGCKGKGAGHK, HashSet<NMNMIBDPDJO> LGHLFAFHBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "16")]
	public void JOAFMADFFGJ(NMNMIBDPDJO LGCKGKGAGHK, NMNMIBDPDJO EGPCCONFKKI, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "17")]
	public void GCOJJLCBECB(NMNMIBDPDJO LGCKGKGAGHK, int MALDGHPGCJJ, NMNMIBDPDJO PKMANOIKNOC, int PLPBHGJCECD, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "18")]
	public void FFDJEDMIAFA(NMNMIBDPDJO LGCKGKGAGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "19")]
	public IJKINIBHBHA KFDFMBOIBFH(bool DBBDMHLJILF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "20")]
	public IJKINIBHBHA PCOGCLMJJMD(HashSet<Guid> CFFHAHOIMKH, bool DBBDMHLJILF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "21")]
	public bool FOMHKFNGDIK(NACHLOGOMCG ECIIMDOKNPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "22")]
	public void AMJJIKLBIIF(IJKINIBHBHA DOAPLFMMIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "23")]
	public void IEIDNLDBDON(IJKINIBHBHA DOAPLFMMIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "24")]
	public void GAEHFCFMCGF(IJKINIBHBHA DOAPLFMMIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public DKDGBDIILOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NMNMIBDPDJO : DNOBKEJGNCF, IEquatable<NMNMIBDPDJO>
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DNOBKEJGNCF
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	NMNMIBDPDJO FNJEIPCGPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform EHAKBGMPING
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	GameObject MNCNLOJBGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string GMLPMAJDOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Guid MKCJKMELIKM
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	int LIBBNOAOHDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	MIGCCDNHDEL AMEJLJKIEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool BHMDDPGHDAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int NDFKLLHMKEI);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int NDFKLLHMKEI);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int NDFKLLHMKEI);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int NDFKLLHMKEI, NMNMIBDPDJO IEGHKLBOPIG, int OPHNCLPJFKG);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int NDFKLLHMKEI, NMNMIBDPDJO LNJFPAMCDDA, int PLPBHGJCECD, Vector3 JHJBGADMPCK, Quaternion KBJIJPOJLJF);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int NDFKLLHMKEI, NMNMIBDPDJO MPFFDKEKJAP, int HIEMPBBBBIB, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int NDFKLLHMKEI, NMNMIBDPDJO DMDOJLFKIDL, int FCCBAPMDONJ);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int NDFKLLHMKEI, NMNMIBDPDJO ENEIIOEOMIG, int JDFANNOFBMM, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(NMNMIBDPDJO BCCMHPGFDIC, NMNMIBDPDJO IEAIAKBGDDO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[PFENABFDEFA(DCCNCNLIDJL.OMRoom)]
public interface NKLFMJNLLPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool NJDBJPCDOCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<NMNMIBDPDJO, NMNMIBDPDJO> BHBOMMFJFHI;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<NMNMIBDPDJO, NMNMIBDPDJO> BFHILKDNPBO;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<NMNMIBDPDJO, NMNMIBDPDJO, NMNMIBDPDJO> KEMGJCBHNAO;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FCIFMHNEBDM(GameObject IPHCMOEHILB, NNJEBNGKOCO DLJLNBICLFE);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LLIADGIKINC();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NLHDMBJLIGN(NMNMIBDPDJO LGCKGKGAGHK);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GLLKHIKCFCF(NMNMIBDPDJO LGCKGKGAGHK);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NEDMNKHPNNF(NMNMIBDPDJO LGCKGKGAGHK, HashSet<NMNMIBDPDJO> LGHLFAFHBCH);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JOAFMADFFGJ(NMNMIBDPDJO LGCKGKGAGHK, NMNMIBDPDJO EGPCCONFKKI, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GCOJJLCBECB(NMNMIBDPDJO LGCKGKGAGHK, int MALDGHPGCJJ, NMNMIBDPDJO PKMANOIKNOC, int PLPBHGJCECD, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FFDJEDMIAFA(NMNMIBDPDJO LGCKGKGAGHK);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IJKINIBHBHA KFDFMBOIBFH(bool DBBDMHLJILF);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IJKINIBHBHA PCOGCLMJJMD(HashSet<Guid> CFFHAHOIMKH, bool DBBDMHLJILF);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool FOMHKFNGDIK(NACHLOGOMCG ECIIMDOKNPG);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AMJJIKLBIIF(IJKINIBHBHA DOAPLFMMIBD);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IEIDNLDBDON(IJKINIBHBHA DOAPLFMMIBD);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GAEHFCFMCGF(IJKINIBHBHA DOAPLFMMIBD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MOHCHFKKEOL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool JBGIEENIBLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NMNMIBDPDJO DPDHCFFBNDB(int EDDNGIOLOLF);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NMNMIBDPDJO DDEPHPPGMFM(Guid FDIKEOHKFPP);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DMKNMMGBOJO(NMNMIBDPDJO LGCKGKGAGHK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KKBJBHFEAGA();

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FJJCOKKPGNE(NMNMIBDPDJO BKGPILCEAML);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
public interface GIPICFCOEFO
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MCEANPLKDAH(NGEECNPKEIN BKGPILCEAML);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HABGKKDHCKE(NGEECNPKEIN BKGPILCEAML);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string JKJHNIGCFNL(NGEECNPKEIN BKGPILCEAML);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid ANIJAKCJLEB(NGEECNPKEIN BKGPILCEAML);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int BOPDKFJKPCP(NGEECNPKEIN BKGPILCEAML);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KNBPKCOGAPK(NGEECNPKEIN BKGPILCEAML);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate void ICAHPKCJALP(NMNMIBDPDJO MPJDPKIIPIL, int LFGPNOFBOAD, NMNMIBDPDJO ENEIIOEOMIG, int BEKKKKJPAJM, [Optional] Vector3? JOBJIFEFMBJ, [Optional] Quaternion? FEEAIHHJNHC);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void EJJPJPHFLPF(NMNMIBDPDJO BCCMHPGFDIC, NMNMIBDPDJO IEAIAKBGDDO);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NGEECNPKEIN : NMNMIBDPDJO, DNOBKEJGNCF, IEquatable<NMNMIBDPDJO>
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IKEKLLAMJLB : DNOBKEJGNCF
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	NMNMIBDPDJO FCLMPJBMJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	IEnumerable<NMNMIBDPDJO> AAIMHDCLFFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Vector3 NLAMPGIADCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	Quaternion EAPKGAOFAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool LODPHFFFKGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool MFDMOIODONL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event ICAHPKCJALP EAJAEEAPPAB;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event ICAHPKCJALP MOPBMFKEPCC;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event ICAHPKCJALP MDGDLMDCJAG;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event EJJPJPHFLPF PEOPBDMPPIF;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PALKBNKHAGA();

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KJBAIGHFNON();

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PEKHJLOCFKC();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EDEFMLGLBGB();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void ANHGIFPFJAM();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MCDIBKHJIPA();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OKMFJNHNFFP(int NDFKLLHMKEI, NMNMIBDPDJO ENEIIOEOMIG, int IAGGJFALECJ);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KOAHDGPIFGJ();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void GNCAGBKJLCD(int NDFKLLHMKEI, NMNMIBDPDJO MPJDPKIIPIL, int BCPBDIPHKKA, [Optional] Vector3? JOBJIFEFMBJ, [Optional] Quaternion? FEEAIHHJNHC);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KEIAKMFKMGM(NMNMIBDPDJO MPJDPKIIPIL);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void HBPLPCOJHEG();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NCBFLMMMAIF(int ENPOKNEMOMH, Vector3 OBIONJJHEHM);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void IANIMBCHINB(Vector3 EJMMMHBDPGO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JCCFGGGBDJO
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Vector3 EDBNGDFABJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NNJEBNGKOCO
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool HDGJELOHLMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	FEBLAMBEGIC FJDCPLAMLCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ConnectableConfigData : ScriptableObject, NNJEBNGKOCO
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		[FormerlySerializedAs("linkVisualPrefab")]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x822960", Offset = "0x821760", VA = "0x180822960", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public FEBLAMBEGIC LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5F58A20", Offset = "0x5F57820", VA = "0x185F58A20")]
		public static ConnectableConfigData AJPPEBKFFCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5F58AD0", Offset = "0x5F578D0", VA = "0x185F58AD0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual PFNMDLOPAMP, bool AAFEDGOMIDK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct IKIAFOJMKNP : IEquatable<IKIAFOJMKNP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public NMNMIBDPDJO LGCKGKGAGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int PEMFBDPGJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int JDFANNOFBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Vector3 JOBJIFEFMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Quaternion FEEAIHHJNHC;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5F5C510", Offset = "0x5F5B310", VA = "0x185F5C510")]
	public IKIAFOJMKNP(NMNMIBDPDJO LGCKGKGAGHK, int PEMFBDPGJNP, int JDFANNOFBMM, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5F5C600", Offset = "0x5F5B400", VA = "0x185F5C600")]
	public IKIAFOJMKNP(NMNMIBDPDJO LGCKGKGAGHK, int PEMFBDPGJNP, int JDFANNOFBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5F5C570", Offset = "0x5F5B370", VA = "0x185F5C570")]
	public IKIAFOJMKNP(NMNMIBDPDJO LGCKGKGAGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5F5C0A0", Offset = "0x5F5AEA0", VA = "0x185F5C0A0", Slot = "4")]
	public bool Equals(IKIAFOJMKNP FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5F5C150", Offset = "0x5F5AF50", VA = "0x185F5C150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[UnityEngine.Scripting.Preserve]
public class AOCBKBNIEHA : HCNCFLMLPOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Transform PFIKOEBPDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private FEBLAMBEGIC LHKHCGKBACL;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5A78750", Offset = "0x5A77550", VA = "0x185A78750", Slot = "4")]
	public void FCIFMHNEBDM(Transform PFIKOEBPDGA, FEBLAMBEGIC LHKHCGKBACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5F537A0", Offset = "0x5F525A0", VA = "0x185F537A0", Slot = "5")]
	public FEBLAMBEGIC GCHCNINJHPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5F53750", Offset = "0x5F52550", VA = "0x185F53750", Slot = "6")]
	public void CAIGOJPDCAL(FEBLAMBEGIC FGFLIKDEODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public AOCBKBNIEHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal class JDLLPBFINFI : IDisposable, BKMNPGIEMIF
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class INCNKEFKGGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NMNMIBDPDJO oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NMNMIBDPDJO newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public INCNKEFKGGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5F5C6A0", Offset = "0x5F5B4A0", VA = "0x185F5C6A0")]
		internal bool DOMFNJMFHCJ(MEHCIIICPAE node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly GEJCOFJPKGC MAANLFNLDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IPPMNANNPPN IJGCGICDHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private HFGOEGAMMEB BPGGEGPGKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool AAFEDGOMIDK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public MEHCIIICPAE CGOAPMHKIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5F62BC0", Offset = "0x5F619C0", VA = "0x185F62BC0")]
	public bool MAFJFPFBOOG([In] JKHGPPOCEIJ OMHIFBJFAGA, bool KLJJKIFGAMK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5F61400", Offset = "0x5F60200", VA = "0x185F61400")]
	private bool IIGDIFKDNMP([In] JKHGPPOCEIJ OMHIFBJFAGA, bool KLJJKIFGAMK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5F641E0", Offset = "0x5F62FE0", VA = "0x185F641E0")]
	public JDLLPBFINFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5F60580", Offset = "0x5F5F380", VA = "0x185F60580", Slot = "5")]
	public void FCIFMHNEBDM(NKLFMJNLLPE IEHBMNBOFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5F61300", Offset = "0x5F60100", VA = "0x185F61300", Slot = "17")]
	public void HCGGNCECMJB(GNFAOMPPBAI IDFHKFHMFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5F628C0", Offset = "0x5F616C0", VA = "0x185F628C0", Slot = "12")]
	public void LBJAAKIANGK(Func<NMNMIBDPDJO, bool> MIMDIFBMLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5F628D0", Offset = "0x5F616D0", VA = "0x185F628D0")]
	private void LBJAAKIANGK(GEJCOFJPKGC ACNLHBNEANJ, Func<NMNMIBDPDJO, bool> MIMDIFBMLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5F5F580", Offset = "0x5F5E380", VA = "0x185F5F580", Slot = "11")]
	public void AIAGHKHBKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5F64010", Offset = "0x5F62E10", VA = "0x185F64010", Slot = "8")]
	public bool OCPEIEFDGNJ(NMNMIBDPDJO IAKCMLPNGBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5F60C30", Offset = "0x5F5FA30", VA = "0x185F60C30")]
	private bool GFNALEPDABF(NMNMIBDPDJO JKLGODJJFLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5F5FEB0", Offset = "0x5F5ECB0", VA = "0x185F5FEB0")]
	private static bool DKEBJNFLEAD(NMNMIBDPDJO JKLGODJJFLF, GEJCOFJPKGC OGHKFELAPJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5F5FF60", Offset = "0x5F5ED60", VA = "0x185F5FF60")]
	private void DKFDGJMMFNF(Transform NCNDIDFBBKA, GEJCOFJPKGC DECJFKPCDHG, GEJCOFJPKGC[] FIAAMIBFLFJ, NMNMIBDPDJO NEJCFGLIGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5F63EC0", Offset = "0x5F62CC0", VA = "0x185F63EC0")]
	private IKIAFOJMKNP OCDIEFCFCBF(Transform NAPEODGENJN, IKIAFOJMKNP DEKPALHGHDL)
	{
		return default(IKIAFOJMKNP);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5F5FBD0", Offset = "0x5F5E9D0", VA = "0x185F5FBD0")]
	private static bool CHKCNGHNFBG(GEJCOFJPKGC OGHKFELAPJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5F61F60", Offset = "0x5F60D60", VA = "0x185F61F60")]
	private string JKJHNIGCFNL(NMNMIBDPDJO LGCKGKGAGHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5F5FA30", Offset = "0x5F5E830", VA = "0x185F5FA30")]
	private string BOPDKFJKPCP(NMNMIBDPDJO LGCKGKGAGHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5F60610", Offset = "0x5F5F410", VA = "0x185F60610")]
	private void GEBIFEFEAGI([In] JKHGPPOCEIJ OMHIFBJFAGA, bool BECNKAICFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5F62030", Offset = "0x5F60E30", VA = "0x185F62030")]
	private void KCCBFGOJEFE(NMNMIBDPDJO BIFNKFCMILB, bool BECNKAICFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5F622F0", Offset = "0x5F610F0", VA = "0x185F622F0")]
	private void KPPNEGBNNMN(NMNMIBDPDJO IIPELLDHGFE, int BCPBDIPHKKA, NMNMIBDPDJO PKMANOIKNOC, int IAGGJFALECJ, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC, bool BECNKAICFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5F62C10", Offset = "0x5F61A10", VA = "0x185F62C10")]
	private void MDIEPDACFLD(NMNMIBDPDJO DFEPBEBLAAB, int BCPBDIPHKKA, int IAGGJFALECJ, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC, bool GJGOLMAPMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5F61E80", Offset = "0x5F60C80", VA = "0x185F61E80", Slot = "9")]
	public bool JHJABEELFDC(NMNMIBDPDJO DFEPBEBLAAB, int BCPBDIPHKKA, int IAGGJFALECJ, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5F619D0", Offset = "0x5F607D0", VA = "0x185F619D0")]
	private bool IIKNOIPEKMB(NMNMIBDPDJO DFEPBEBLAAB, int BCPBDIPHKKA, int IAGGJFALECJ, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5F5F8B0", Offset = "0x5F5E6B0", VA = "0x185F5F8B0")]
	private static void BKEMBFDIFLB(NMNMIBDPDJO DFEPBEBLAAB, int BCPBDIPHKKA, int IAGGJFALECJ, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC, GEJCOFJPKGC NNINCIENAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5F61C00", Offset = "0x5F60A00", VA = "0x185F61C00")]
	private void ILCLPMDIOBE(NMNMIBDPDJO IIPELLDHGFE, int MALDGHPGCJJ, NMNMIBDPDJO PKMANOIKNOC, int PLPBHGJCECD, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5F60350", Offset = "0x5F5F150", VA = "0x185F60350")]
	private void DNFJJMINCDO(GEJCOFJPKGC ACNLHBNEANJ, NMNMIBDPDJO NGKOCMIIAHD, NMNMIBDPDJO BIEFPFAGGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5F603C0", Offset = "0x5F5F1C0", VA = "0x185F603C0")]
	private void DNFJJMINCDO(NMNMIBDPDJO LGCKGKGAGHK, NMNMIBDPDJO NGKOCMIIAHD, NMNMIBDPDJO BIEFPFAGGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5F63D50", Offset = "0x5F62B50", VA = "0x185F63D50")]
	private void NPFGELAEIDL(NMNMIBDPDJO LGCKGKGAGHK, NMNMIBDPDJO NGKOCMIIAHD, NMNMIBDPDJO BIEFPFAGGLB, bool ONEFLNNHPMB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5F63DC0", Offset = "0x5F62BC0", VA = "0x185F63DC0")]
	private void NPFGELAEIDL(GEJCOFJPKGC ADCDJFADKCK, NMNMIBDPDJO NEJCFGLIGFC, NMNMIBDPDJO IEAIAKBGDDO, bool ONEFLNNHPMB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5F5FD90", Offset = "0x5F5EB90", VA = "0x185F5FD90")]
	private void DEMKJJJFCML(NMNMIBDPDJO BIFNKFCMILB, int BCPBDIPHKKA, NMNMIBDPDJO PKMANOIKNOC, int PLPBHGJCECD, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5F61D20", Offset = "0x5F60B20", VA = "0x185F61D20")]
	private void JEFDCODKNJC(MEHCIIICPAE AJKCELPHOFC, MEHCIIICPAE JADCINBMEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5F637A0", Offset = "0x5F625A0", VA = "0x185F637A0", Slot = "18")]
	public NMNMIBDPDJO MMMEDHKDFDM(NMNMIBDPDJO LGCKGKGAGHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5F63900", Offset = "0x5F62700", VA = "0x185F63900", Slot = "13")]
	public void NEDMNKHPNNF(NMNMIBDPDJO LGCKGKGAGHK, HashSet<NMNMIBDPDJO> DILAGPGCCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5F5F670", Offset = "0x5F5E470", VA = "0x185F5F670", Slot = "14")]
	public List<NMNMIBDPDJO> BHFKLFMHAIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5F5F5A0", Offset = "0x5F5E3A0", VA = "0x185F5F5A0")]
	protected MEHCIIICPAE BBOPHFGGBAM(MEHCIIICPAE ACNLHBNEANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5F63CB0", Offset = "0x5F62AB0", VA = "0x185F63CB0")]
	protected GEJCOFJPKGC[] NMDGKKCMIIF(GEJCOFJPKGC OGHKFELAPJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5F60430", Offset = "0x5F5F230", VA = "0x185F60430")]
	protected bool EIBANBFOPLG(NMNMIBDPDJO LGCKGKGAGHK, [Out] GEJCOFJPKGC ACNLHBNEANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5F5FAA0", Offset = "0x5F5E8A0", VA = "0x185F5FAA0", Slot = "15")]
	public bool CAHPOBGAFDA(NMNMIBDPDJO LGCKGKGAGHK, [Out] IKIAFOJMKNP HHKADLJHNBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5F60540", Offset = "0x5F5F340", VA = "0x185F60540")]
	protected GEJCOFJPKGC EOMABDKMFFM(IKIAFOJMKNP DPHNBGLGPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5F62200", Offset = "0x5F61000", VA = "0x185F62200", Slot = "10")]
	public bool KKOPCEOKKBB(NMNMIBDPDJO IIPELLDHGFE, int MALDGHPGCJJ, NMNMIBDPDJO PKMANOIKNOC, int PLPBHGJCECD, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5F63210", Offset = "0x5F62010", VA = "0x185F63210")]
	private bool MMLMCEJGNIO(NMNMIBDPDJO IIPELLDHGFE, int MALDGHPGCJJ, NMNMIBDPDJO PKMANOIKNOC, int PLPBHGJCECD, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5F61330", Offset = "0x5F60130", VA = "0x185F61330")]
	private static bool HPGJGNODLDC(GEJCOFJPKGC CCJGJIIFDCC, IKIAFOJMKNP MFPAELJLLHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5F62BC0", Offset = "0x5F619C0", VA = "0x185F62BC0", Slot = "7")]
	private bool LMBPBEAEANP([In] JKHGPPOCEIJ OMHIFBJFAGA, bool KLJJKIFGAMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[UnityEngine.Scripting.Preserve]
internal class OOKHHAKLFPJ : NKLFMJNLLPE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly IBPIJCMLLGH PPDHICBEIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly HFGOEGAMMEB BPGGEGPGKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly KKLONBBNMIA NLJAABHOGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly JAMJBHOINPG OHDFDMKHEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly BKMNPGIEMIF DOAPLFMMIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal LCNPMGNFFOF ADOCEOOMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal PCFAIIMFINE KMLMAPIMMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal IPPMNANNPPN MLBFLJMEBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal bool AAFEDGOMIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool FEOAPAJJMOM;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool PGABAHOBJDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1668BD0", Offset = "0x16679D0", VA = "0x181668BD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1668C20", Offset = "0x1667A20", VA = "0x181668C20")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NJDBJPCDOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x1668BF0", Offset = "0x16679F0", VA = "0x181668BF0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1668C00", Offset = "0x1667A00", VA = "0x181668C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<NMNMIBDPDJO, NMNMIBDPDJO> BHBOMMFJFHI
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5F67A80", Offset = "0x5F66880", VA = "0x185F67A80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5F685B0", Offset = "0x5F673B0", VA = "0x185F685B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<NMNMIBDPDJO, NMNMIBDPDJO> BFHILKDNPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5F68D70", Offset = "0x5F67B70", VA = "0x185F68D70", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5F67990", Offset = "0x5F66790", VA = "0x185F67990", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<NMNMIBDPDJO, NMNMIBDPDJO, NMNMIBDPDJO> KEMGJCBHNAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5F68A30", Offset = "0x5F67830", VA = "0x185F68A30", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5F68790", Offset = "0x5F67590", VA = "0x185F68790", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5F69220", Offset = "0x5F68020", VA = "0x185F69220")]
	public OOKHHAKLFPJ(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5F67E10", Offset = "0x5F66C10", VA = "0x185F67E10", Slot = "11")]
	public void FCIFMHNEBDM(GameObject IPHCMOEHILB, NNJEBNGKOCO DLJLNBICLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5F67C30", Offset = "0x5F66A30", VA = "0x185F67C30", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5F69000", Offset = "0x5F67E00", VA = "0x185F69000", Slot = "12")]
	public void LLIADGIKINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5F691E0", Offset = "0x5F67FE0", VA = "0x185F691E0", Slot = "13")]
	public void NLHDMBJLIGN(NMNMIBDPDJO LGCKGKGAGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5F689D0", Offset = "0x5F677D0", VA = "0x185F689D0", Slot = "14")]
	public void GLLKHIKCFCF(NMNMIBDPDJO LGCKGKGAGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5F55CE0", Offset = "0x5F54AE0", VA = "0x185F55CE0", Slot = "21")]
	public bool FOMHKFNGDIK(NACHLOGOMCG ECIIMDOKNPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5F68BA0", Offset = "0x5F679A0", VA = "0x185F68BA0")]
	internal bool IIGDIFKDNMP([In] JKHGPPOCEIJ OMHIFBJFAGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5F69050", Offset = "0x5F67E50", VA = "0x185F69050")]
	internal bool MMLMCEJGNIO([In] JKHGPPOCEIJ OMHIFBJFAGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5F68A90", Offset = "0x5F67890", VA = "0x185F68A90")]
	internal bool HCFALODAOEJ([In] JKHGPPOCEIJ OMHIFBJFAGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5F67AE0", Offset = "0x5F668E0", VA = "0x185F67AE0")]
	internal bool CPCJLDKBBAB([In] JKHGPPOCEIJ OMHIFBJFAGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5F687F0", Offset = "0x5F675F0", VA = "0x185F687F0")]
	internal void GHPIKIPAGMM(NMNMIBDPDJO LGCKGKGAGHK, int GCPPEAAAHKF, bool KLJJKIFGAMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5F689D0", Offset = "0x5F677D0", VA = "0x185F689D0")]
	internal bool OLIOOJGKEHJ(NMNMIBDPDJO PMBNMEFNKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5F67CD0", Offset = "0x5F66AD0", VA = "0x185F67CD0")]
	internal bool EMOCEHHFLME(NMNMIBDPDJO DFEPBEBLAAB, int BCPBDIPHKKA, int IAGGJFALECJ, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5F690E0", Offset = "0x5F67EE0", VA = "0x185F690E0", Slot = "15")]
	public void NEDMNKHPNNF(NMNMIBDPDJO LGCKGKGAGHK, HashSet<NMNMIBDPDJO> LGHLFAFHBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5F68DD0", Offset = "0x5F67BD0", VA = "0x185F68DD0", Slot = "16")]
	public void JOAFMADFFGJ(NMNMIBDPDJO DFEPBEBLAAB, NMNMIBDPDJO EGPCCONFKKI, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5F68650", Offset = "0x5F67450", VA = "0x185F68650", Slot = "17")]
	public void GCOJJLCBECB(NMNMIBDPDJO IIPELLDHGFE, int MALDGHPGCJJ, NMNMIBDPDJO PKMANOIKNOC, int PLPBHGJCECD, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5F683E0", Offset = "0x5F671E0", VA = "0x185F683E0", Slot = "18")]
	public void FFDJEDMIAFA(NMNMIBDPDJO IIPELLDHGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5F68C60", Offset = "0x5F67A60", VA = "0x185F68C60")]
	public void JFLCPBDPHIP([Optional] OENHMOLNHKP NJAFCDKPCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5F679F0", Offset = "0x5F667F0", VA = "0x185F679F0", Slot = "22")]
	public void AMJJIKLBIIF(IJKINIBHBHA DOAPLFMMIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5F68FE0", Offset = "0x5F67DE0", VA = "0x185F68FE0", Slot = "19")]
	public IJKINIBHBHA KFDFMBOIBFH(bool DBBDMHLJILF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5F69200", Offset = "0x5F68000", VA = "0x185F69200", Slot = "20")]
	public IJKINIBHBHA PCOGCLMJJMD(HashSet<Guid> CFFHAHOIMKH, bool DBBDMHLJILF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5F68610", Offset = "0x5F67410", VA = "0x185F68610", Slot = "24")]
	public void GAEHFCFMCGF(IJKINIBHBHA DOAPLFMMIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5F68AF0", Offset = "0x5F678F0", VA = "0x185F68AF0", Slot = "23")]
	public void IEIDNLDBDON(IJKINIBHBHA DOAPLFMMIBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class HFGOEGAMMEB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly FOEHHLKMAJF<NMNMIBDPDJO, NMNMIBDPDJO> BHBOMMFJFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly FOEHHLKMAJF<NMNMIBDPDJO, NMNMIBDPDJO> BFHILKDNPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly BHDPFIKFABK<NMNMIBDPDJO, NMNMIBDPDJO, NMNMIBDPDJO> KEMGJCBHNAO;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5F5BDC0", Offset = "0x5F5ABC0", VA = "0x185F5BDC0")]
	public HFGOEGAMMEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
	public void FCIFMHNEBDM(OOKHHAKLFPJ IEHBMNBOFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5F5BC80", Offset = "0x5F5AA80", VA = "0x185F5BC80")]
	public void CEMIHFLCBPA(NMNMIBDPDJO AJKCELPHOFC, NMNMIBDPDJO BIFNKFCMILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5F5BD60", Offset = "0x5F5AB60", VA = "0x185F5BD60")]
	public void PKAEHCKGDHM(NMNMIBDPDJO AJKCELPHOFC, NMNMIBDPDJO BIFNKFCMILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5F5BCE0", Offset = "0x5F5AAE0", VA = "0x185F5BCE0")]
	public void IHJJFKAKCJE(NMNMIBDPDJO MGPBFMAKCJE, NMNMIBDPDJO PKMANOIKNOC, NMNMIBDPDJO BIFNKFCMILB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class KKLONBBNMIA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private OOKHHAKLFPJ IEHBMNBOFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private PCFAIIMFINE KMLMAPIMMEL;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public KKLONBBNMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5F64670", Offset = "0x5F63470", VA = "0x185F64670")]
	public void FCIFMHNEBDM(OOKHHAKLFPJ IEHBMNBOFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5F64560", Offset = "0x5F63360", VA = "0x185F64560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5F647A0", Offset = "0x5F635A0", VA = "0x185F647A0")]
	private void JMDJHGJJEAG(OENHMOLNHKP ACNHNLBOPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5F644F0", Offset = "0x5F632F0", VA = "0x185F644F0")]
	private void CHKLGPCKCOG(OENHMOLNHKP NNJNINFCJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5F647C0", Offset = "0x5F635C0", VA = "0x185F647C0")]
	public void NIOCFGJIBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5F64570", Offset = "0x5F63370", VA = "0x185F64570")]
	public void EECOIHGBABP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class CCLLPBFKLGK
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class CBJMCIPKCMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IBPIJCMLLGH container;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public CBJMCIPKCMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5F58730", Offset = "0x5F57530", VA = "0x185F58730")]
		internal OOKHHAKLFPJ CODIIFCJDOD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5F587A0", Offset = "0x5F575A0", VA = "0x185F587A0")]
	public static void ABJGALHAFIK(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5F589A0", Offset = "0x5F577A0", VA = "0x185F589A0")]
	public static void OBNOGPNCFNO(IBPIJCMLLGH PPDHICBEIFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[UnityEngine.Scripting.Preserve]
internal class MMDPOPGOPFL : IDisposable, IPPMNANNPPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly Dictionary<int, FEBLAMBEGIC> BCJGJIPFOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly GNFAOMPPBAI MCEKCHAEMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private HCNCFLMLPOK DHOELIAHPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private BKMNPGIEMIF DOAPLFMMIBD;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5F674C0", Offset = "0x5F662C0", VA = "0x185F674C0")]
	public MMDPOPGOPFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5F66ED0", Offset = "0x5F65CD0", VA = "0x185F66ED0", Slot = "7")]
	public void FCIFMHNEBDM(BKMNPGIEMIF DOAPLFMMIBD, HCNCFLMLPOK DHOELIAHPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5F66F10", Offset = "0x5F65D10", VA = "0x185F66F10", Slot = "5")]
	public void FKHGDGJLIHI(MEHCIIICPAE LHPOFNIENAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5F66940", Offset = "0x5F65740", VA = "0x185F66940", Slot = "9")]
	public void ALKKOJKAGFK(MEHCIIICPAE PPHDAECNPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5F67150", Offset = "0x5F65F50", VA = "0x185F67150", Slot = "8")]
	public void FLAKNECKJAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5F66AB0", Offset = "0x5F658B0", VA = "0x185F66AB0", Slot = "10")]
	public void BPJLMEMIMDA(MEHCIIICPAE CNLHIMCHGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5F66E00", Offset = "0x5F65C00", VA = "0x185F66E00", Slot = "11")]
	public void DCLNPCMIIJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5F67310", Offset = "0x5F66110", VA = "0x185F67310")]
	private bool NHALPCCOBIK(MEHCIIICPAE PIOMDGMHEIP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class JAMJBHOINPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal struct PJKKKJMBFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly GEJCOFJPKGC OLJEHBPDBLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly HashSet<Guid> CFFHAHOIMKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly NACHLOGOMCG JAAGAEGFFAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly NACHLOGOMCG AOBHHIIMCIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly bool DBBDMHLJILF;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private bool IPEPGMNCHFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x5F69D60", Offset = "0x5F68B60", VA = "0x185F69D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5F69E80", Offset = "0x5F68C80", VA = "0x185F69E80")]
		public PJKKKJMBFBL(GEJCOFJPKGC OLJEHBPDBLF, HashSet<Guid> CFFHAHOIMKH, bool DBBDMHLJILF, [Optional] NACHLOGOMCG JAAGAEGFFAM, [Optional] NACHLOGOMCG AOBHHIIMCIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5F69780", Offset = "0x5F68580", VA = "0x185F69780")]
		public NACHLOGOMCG FILLENIGNNA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5F69AB0", Offset = "0x5F688B0", VA = "0x185F69AB0")]
		private NACHLOGOMCG ICCHJLDHDJH([Out] NACHLOGOMCG IBKPCEDHDAB, [Out] NACHLOGOMCG FDBIEKLHHPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5F69B70", Offset = "0x5F68970", VA = "0x185F69B70")]
		private NACHLOGOMCG KFDNICHMCOH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5F69610", Offset = "0x5F68410", VA = "0x185F69610")]
		private void ENKHMHJJAOO(NACHLOGOMCG AKPAANMLODO, NACHLOGOMCG BKAJKCGMEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5F698F0", Offset = "0x5F686F0", VA = "0x185F698F0")]
		private void FOLKOJJFMNH(NACHLOGOMCG IBKPCEDHDAB, NACHLOGOMCG FDBIEKLHHPP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private OOKHHAKLFPJ IEHBMNBOFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private BKMNPGIEMIF DOAPLFMMIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private IPPMNANNPPN IJGCGICDHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private PCFAIIMFINE KMLMAPIMMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool DEFCBKMMEEK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private bool BACEEBAGOIP
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x5F5EEF0", Offset = "0x5F5DCF0", VA = "0x185F5EEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private bool PGABAHOBJDN
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5F5E110", Offset = "0x5F5CF10", VA = "0x185F5E110")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5F5D880", Offset = "0x5F5C680", VA = "0x185F5D880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5F5D8A0", Offset = "0x5F5C6A0", VA = "0x185F5D8A0")]
	public void FCIFMHNEBDM(OOKHHAKLFPJ IEHBMNBOFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5F5E590", Offset = "0x5F5D390", VA = "0x185F5E590")]
	public IJKINIBHBHA KFDFMBOIBFH(bool DBBDMHLJILF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5F5EF40", Offset = "0x5F5DD40", VA = "0x185F5EF40")]
	public IJKINIBHBHA PCOGCLMJJMD(HashSet<Guid> CFFHAHOIMKH, bool DBBDMHLJILF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5F5C980", Offset = "0x5F5B780", VA = "0x185F5C980")]
	public void AMJJIKLBIIF(IJKINIBHBHA DOAPLFMMIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5F5E460", Offset = "0x5F5D260", VA = "0x185F5E460")]
	public void IEIDNLDBDON(IJKINIBHBHA DOAPLFMMIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5F5D6D0", Offset = "0x5F5C4D0", VA = "0x185F5D6D0")]
	public void DIIHAPOAINL(IJKINIBHBHA DOAPLFMMIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5F5D910", Offset = "0x5F5C710", VA = "0x185F5D910")]
	private void FEDLBINPMEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5F5E150", Offset = "0x5F5CF50", VA = "0x185F5E150")]
	private NACHLOGOMCG HPKCBBNFFND(GEJCOFJPKGC ACNLHBNEANJ, bool DBBDMHLJILF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5F5DEC0", Offset = "0x5F5CCC0", VA = "0x185F5DEC0")]
	private static void GGMKMFEJOAD(GEJCOFJPKGC ACNLHBNEANJ, bool DBBDMHLJILF, NACHLOGOMCG ECIIMDOKNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5F5C760", Offset = "0x5F5B560", VA = "0x185F5C760")]
	private void AEGBFIGAJAP(GEJCOFJPKGC ACNLHBNEANJ, bool DBBDMHLJILF, NACHLOGOMCG ECIIMDOKNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5F5E500", Offset = "0x5F5D300", VA = "0x185F5E500")]
	private NACHLOGOMCG IOKHOIBDLFC(GEJCOFJPKGC OLJEHBPDBLF, HashSet<Guid> CFFHAHOIMKH, bool DBBDMHLJILF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5F5D440", Offset = "0x5F5C240", VA = "0x185F5D440")]
	private bool DCHHHKJLPJG(IJKINIBHBHA EKLJNOFLOMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5F5CDD0", Offset = "0x5F5BBD0", VA = "0x185F5CDD0")]
	private bool CDFLOBDEIFP(NACHLOGOMCG ECIIMDOKNPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5F5E130", Offset = "0x5F5CF30", VA = "0x185F5E130")]
	private bool HNMMLHOAFFL(IJKINIBHBHA DOAPLFMMIBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5F5E340", Offset = "0x5F5D140", VA = "0x185F5E340")]
	private static bool IAGHDBMBCPP(NACHLOGOMCG ECIIMDOKNPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5F5DC70", Offset = "0x5F5CA70", VA = "0x185F5DC70")]
	public static bool FOMHKFNGDIK(NACHLOGOMCG ECIIMDOKNPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5F5EBC0", Offset = "0x5F5D9C0", VA = "0x185F5EBC0")]
	private NMNMIBDPDJO MMNMJNHEFED(NACHLOGOMCG ECIIMDOKNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5F5D700", Offset = "0x5F5C500", VA = "0x185F5D700")]
	private NMNMIBDPDJO DPDHCFFBNDB(NACHLOGOMCG ECIIMDOKNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5F5DB00", Offset = "0x5F5C900", VA = "0x185F5DB00")]
	private NMNMIBDPDJO FIFDLNLEHMF(NACHLOGOMCG ECIIMDOKNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5F58340", Offset = "0x5F57140", VA = "0x185F58340")]
	private static Guid PEMEHPDBDPA(NACHLOGOMCG ECIIMDOKNPG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5F5EAD0", Offset = "0x5F5D8D0", VA = "0x185F5EAD0")]
	private string LJHMBDDBPME(NACHLOGOMCG ECIIMDOKNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5F5CA10", Offset = "0x5F5B810", VA = "0x185F5CA10")]
	private bool BBBIHMHGANB(GEJCOFJPKGC ACNLHBNEANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5F5CB70", Offset = "0x5F5B970", VA = "0x185F5CB70")]
	private static void BJACOOGMAJL(GEJCOFJPKGC OLJEHBPDBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public JAMJBHOINPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct JKHGPPOCEIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public NMNMIBDPDJO BIFNKFCMILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public NMNMIBDPDJO AJKCELPHOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int BCPBDIPHKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int IAGGJFALECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Vector3 JOBJIFEFMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Quaternion FEEAIHHJNHC;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public IKIAFOJMKNP PFNNHHJCKGB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5F643B0", Offset = "0x5F631B0", VA = "0x185F643B0")]
		get
		{
			return default(IKIAFOJMKNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IKIAFOJMKNP HNPNAEGMCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5F64450", Offset = "0x5F63250", VA = "0x185F64450")]
		get
		{
			return default(IKIAFOJMKNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5F64480", Offset = "0x5F63280", VA = "0x185F64480")]
	public JKHGPPOCEIJ(NMNMIBDPDJO BIFNKFCMILB, NMNMIBDPDJO AJKCELPHOFC, int BCPBDIPHKKA, int IAGGJFALECJ, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface BKMNPGIEMIF
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	MEHCIIICPAE CGOAPMHKIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCIFMHNEBDM(NKLFMJNLLPE IEHBMNBOFCL);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MAFJFPFBOOG([In] JKHGPPOCEIJ OMHIFBJFAGA, bool KLJJKIFGAMK = true);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OCPEIEFDGNJ(NMNMIBDPDJO IAKCMLPNGBO);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JHJABEELFDC(NMNMIBDPDJO DFEPBEBLAAB, int BCPBDIPHKKA, int IAGGJFALECJ, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KKOPCEOKKBB(NMNMIBDPDJO IIPELLDHGFE, int MALDGHPGCJJ, NMNMIBDPDJO PKMANOIKNOC, int PLPBHGJCECD, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AIAGHKHBKBA();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LBJAAKIANGK(Func<NMNMIBDPDJO, bool> MIMDIFBMLPH);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NEDMNKHPNNF(NMNMIBDPDJO LGCKGKGAGHK, HashSet<NMNMIBDPDJO> DILAGPGCCHA);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<NMNMIBDPDJO> BHFKLFMHAIA();

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool CAHPOBGAFDA(NMNMIBDPDJO LGCKGKGAGHK, [Out] IKIAFOJMKNP HHKADLJHNBH);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HCGGNCECMJB(GNFAOMPPBAI IDFHKFHMFGD);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal delegate bool GNFAOMPPBAI(MEHCIIICPAE ACNLHBNEANJ);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface MEHCIIICPAE
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	NMNMIBDPDJO LKGOICJPGGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	MEHCIIICPAE DIOGANGKEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	IKIAFOJMKNP KNIEOPBGNEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool GDCNLLGOHKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface FEBLAMBEGIC
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFGFMMMFKEL(NMNMIBDPDJO ENEIIOEOMIG, IKIAFOJMKNP BIFNKFCMILB);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IOCNAJOFMBH(NMNMIBDPDJO ENEIIOEOMIG, IKIAFOJMKNP BIFNKFCMILB);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GPHONFMJCJO(NMNMIBDPDJO ENEIIOEOMIG, IKIAFOJMKNP BIFNKFCMILB);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EEOPKMKMFBD(NMNMIBDPDJO ENEIIOEOMIG, IKIAFOJMKNP BIFNKFCMILB);

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FEBLAMBEGIC Instantiate(Transform PFIKOEBPDGA);

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ECEAPGIDAKG();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface HCNCFLMLPOK
{
	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCIFMHNEBDM(Transform PFIKOEBPDGA, FEBLAMBEGIC LHKHCGKBACL);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FEBLAMBEGIC GCHCNINJHPD();

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CAIGOJPDCAL(FEBLAMBEGIC FGFLIKDEODE);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface LCNPMGNFFOF : MOHCHFKKEOL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OKGKFBJAEBB(Guid OMHIEBFNMIB);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface IPPMNANNPPN
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKHGDGJLIHI(MEHCIIICPAE LHPOFNIENAJ);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FCIFMHNEBDM(BKMNPGIEMIF DOAPLFMMIBD, HCNCFLMLPOK IIEBKPAMBEN);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FLAKNECKJAN();

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ALKKOJKAGFK(MEHCIIICPAE PPHDAECNPLI);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BPJLMEMIMDA(MEHCIIICPAE CNLHIMCHGHI);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DCLNPCMIIJE();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class GEJCOFJPKGC : MEHCIIICPAE
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class OGJLGPKAECG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public IKIAFOJMKNP nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public GEJCOFJPKGC foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public OGJLGPKAECG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5F675A0", Offset = "0x5F663A0", VA = "0x185F675A0")]
		internal bool LDFNGAEJBOB(MEHCIIICPAE x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private IKIAFOJMKNP HHKADLJHNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public LinkedList<GEJCOFJPKGC> CGEECCJFLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private GEJCOFJPKGC AJNNNPKHPDL;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IKIAFOJMKNP KNIEOPBGNEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x32BD600", Offset = "0x32BC400", VA = "0x1832BD600", Slot = "6")]
		get
		{
			return default(IKIAFOJMKNP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5F59BE0", Offset = "0x5F589E0", VA = "0x185F59BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private GEJCOFJPKGC AJKCELPHOFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1F0", Offset = "0x7ABFF0", VA = "0x1807AD1F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x5F59C10", Offset = "0x5F58A10", VA = "0x185F59C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public MEHCIIICPAE DIOGANGKEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1F0", Offset = "0x7ABFF0", VA = "0x1807AD1F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NMNMIBDPDJO LKGOICJPGGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool GDCNLLGOHKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x5F59E90", Offset = "0x5F58C90", VA = "0x185F59E90", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GKEBIEHGIHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x5F59CF0", Offset = "0x5F58AF0", VA = "0x185F59CF0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	protected GEJCOFJPKGC ADCDJFADKCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x5F599E0", Offset = "0x5F587E0", VA = "0x185F599E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5F59EA0", Offset = "0x5F58CA0", VA = "0x185F59EA0")]
	public GEJCOFJPKGC(IKIAFOJMKNP AKOPEKHKPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5F59D40", Offset = "0x5F58B40", VA = "0x185F59D40")]
	public GEJCOFJPKGC POLLOHFPCNE(IKIAFOJMKNP FHFFGBNNHBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5F596F0", Offset = "0x5F584F0", VA = "0x185F596F0")]
	public GEJCOFJPKGC GKCBNALCFHL(IKIAFOJMKNP DBOMALOGKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5F59A00", Offset = "0x5F58800", VA = "0x185F59A00")]
	public GEJCOFJPKGC JJGPDDBMEBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5F59030", Offset = "0x5F57E30", VA = "0x185F59030")]
	public void BBGCGJHDDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5F59540", Offset = "0x5F58340", VA = "0x185F59540")]
	public GEJCOFJPKGC EBCOOJFHPCB(IKIAFOJMKNP PKMANOIKNOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5F59870", Offset = "0x5F58670", VA = "0x185F59870")]
	private static void HCGGNCECMJB(GEJCOFJPKGC PEJKAKOEJAB, GNFAOMPPBAI EJLMAECJKCH, bool FGGHCEGBAKM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5F599D0", Offset = "0x5F587D0", VA = "0x185F599D0", Slot = "9")]
	public void HCGGNCECMJB(GNFAOMPPBAI IDFHKFHMFGD, bool ONEFLNNHPMB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5F59180", Offset = "0x5F57F80", VA = "0x185F59180")]
	public static string CKKGHPLPGGI(GEJCOFJPKGC PEJKAKOEJAB, int OCFGNBFHNAN = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5F595F0", Offset = "0x5F583F0", VA = "0x185F595F0")]
	public static GEJCOFJPKGC EOMABDKMFFM(GEJCOFJPKGC PEJKAKOEJAB, IKIAFOJMKNP AKEIKLEFCCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface PCFAIIMFINE
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool BACEEBAGOIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool JBGIEENIBLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<OENHMOLNHKP> JMDJHGJJEAG;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<OENHMOLNHKP> CHKLGPCKCOG;

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(OOKHHAKLFPJ IEHBMNBOFCL);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(NMNMIBDPDJO DFEPBEBLAAB, NMNMIBDPDJO EGPCCONFKKI, int BCPBDIPHKKA, int IAGGJFALECJ, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(NMNMIBDPDJO IIPELLDHGFE, int MALDGHPGCJJ, NMNMIBDPDJO PKMANOIKNOC, int PLPBHGJCECD, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(IJKINIBHBHA HOIHOBFGHFC, [Optional] OENHMOLNHKP NJAFCDKPCNP);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, PCFAIIMFINE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private OOKHHAKLFPJ IEHBMNBOFCL;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool BACEEBAGOIP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x5F665C0", Offset = "0x5F653C0", VA = "0x185F665C0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool JBGIEENIBLH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x5F66620", Offset = "0x5F65420", VA = "0x185F66620", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<OENHMOLNHKP> JMDJHGJJEAG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x5F66510", Offset = "0x5F65310", VA = "0x185F66510", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x5F66710", Offset = "0x5F65510", VA = "0x185F66710", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<OENHMOLNHKP> CHKLGPCKCOG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x5F66460", Offset = "0x5F65260", VA = "0x185F66460", Slot = "17")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x5F66660", Offset = "0x5F65460", VA = "0x185F66660", Slot = "18")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7AD180", Offset = "0x7ABF80", VA = "0x1807AD180", Slot = "21")]
		public void SetManager(OOKHHAKLFPJ IEHBMNBOFCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5F66430", Offset = "0x5F65230", VA = "0x185F66430")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5F651B0", Offset = "0x5F63FB0", VA = "0x185F651B0", Slot = "25")]
		public void RequestMasterConnectNodes(NMNMIBDPDJO MPJDPKIIPIL, int BCPBDIPHKKA, NMNMIBDPDJO ENEIIOEOMIG, int IAGGJFALECJ, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5F652E0", Offset = "0x5F640E0", VA = "0x185F652E0", Slot = "26")]
		public void RequestMasterDisconnectNode(NMNMIBDPDJO IAKCMLPNGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5F653A0", Offset = "0x5F641A0", VA = "0x185F653A0", Slot = "22")]
		public void RequestMasterModifyNode(NMNMIBDPDJO DFEPBEBLAAB, NMNMIBDPDJO EGPCCONFKKI, int BCPBDIPHKKA, int IAGGJFALECJ, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5F654D0", Offset = "0x5F642D0", VA = "0x185F654D0", Slot = "23")]
		public void RequestMasterReparentNodes(NMNMIBDPDJO IIPELLDHGFE, int MALDGHPGCJJ, NMNMIBDPDJO PKMANOIKNOC, int PLPBHGJCECD, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5F65600", Offset = "0x5F64400", VA = "0x185F65600", Slot = "27")]
		public void RequestMasterReparentToRoot(NMNMIBDPDJO IIPELLDHGFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5F65080", Offset = "0x5F63E80", VA = "0x185F65080", Slot = "24")]
		public void RequestDeserializeConnectableGraph(IJKINIBHBHA HOIHOBFGHFC, [Optional] OENHMOLNHKP NJAFCDKPCNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5F659E0", Offset = "0x5F647E0", VA = "0x185F659E0")]
		[NOHNHKMJDGM]
		private void RpcMasterConnectNodes(NMNMIBDPDJO MPJDPKIIPIL, int BCPBDIPHKKA, NMNMIBDPDJO ENEIIOEOMIG, int IAGGJFALECJ, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5F65CA0", Offset = "0x5F64AA0", VA = "0x185F65CA0")]
		[NOHNHKMJDGM]
		private void RpcMasterDisconnectNode(NMNMIBDPDJO IAKCMLPNGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5F65FE0", Offset = "0x5F64DE0", VA = "0x185F65FE0")]
		[NOHNHKMJDGM]
		private void RpcMasterReparentNodes(NMNMIBDPDJO IIPELLDHGFE, int MALDGHPGCJJ, NMNMIBDPDJO PKMANOIKNOC, int PLPBHGJCECD, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5F65DE0", Offset = "0x5F64BE0", VA = "0x185F65DE0")]
		[NOHNHKMJDGM]
		private void RpcMasterModifyNode(NMNMIBDPDJO DFEPBEBLAAB, NMNMIBDPDJO EGPCCONFKKI, int BCPBDIPHKKA, int IAGGJFALECJ, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5F657D0", Offset = "0x5F645D0", VA = "0x185F657D0")]
		[NOHNHKMJDGM]
		private void RpcConnectNodes(NMNMIBDPDJO MPJDPKIIPIL, int BCPBDIPHKKA, NMNMIBDPDJO ENEIIOEOMIG, int IAGGJFALECJ, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC, NNKNPEJMHGL HOCECPFEJHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5F65950", Offset = "0x5F64750", VA = "0x185F65950")]
		[NOHNHKMJDGM]
		private void RpcDisconnectNode(NMNMIBDPDJO IAKCMLPNGBO, NNKNPEJMHGL HOCECPFEJHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5F66330", Offset = "0x5F65130", VA = "0x185F66330")]
		[NOHNHKMJDGM]
		private void RpcReparentNodes(NMNMIBDPDJO IIPELLDHGFE, int MALDGHPGCJJ, NMNMIBDPDJO PKMANOIKNOC, int PLPBHGJCECD, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC, NNKNPEJMHGL HOCECPFEJHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5F66270", Offset = "0x5F65070", VA = "0x185F66270")]
		[NOHNHKMJDGM]
		private void RpcModifyNode(NMNMIBDPDJO DFEPBEBLAAB, int BCPBDIPHKKA, int IAGGJFALECJ, Vector3 JOBJIFEFMBJ, Quaternion FEEAIHHJNHC, NNKNPEJMHGL HOCECPFEJHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5F65910", Offset = "0x5F64710", VA = "0x185F65910")]
		[NOHNHKMJDGM]
		private void RpcDeserializeConnectableGraph(IJKINIBHBHA DOAPLFMMIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7C5C70", Offset = "0x7C4A70", VA = "0x1807C5C70")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, FEBLAMBEGIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x5F648C0", Offset = "0x5F636C0", VA = "0x185F648C0", Slot = "4")]
		private void AFPFAHAPPGD(NMNMIBDPDJO ENEIIOEOMIG, IKIAFOJMKNP BIFNKFCMILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5F64AB0", Offset = "0x5F638B0", VA = "0x185F64AB0", Slot = "5")]
		private void KDEDCADFNJD(NMNMIBDPDJO ENEIIOEOMIG, IKIAFOJMKNP BIFNKFCMILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5F64F70", Offset = "0x5F63D70", VA = "0x185F64F70", Slot = "6")]
		private void PGMDBGNPONB(NMNMIBDPDJO ENEIIOEOMIG, IKIAFOJMKNP BIFNKFCMILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5F64D80", Offset = "0x5F63B80", VA = "0x185F64D80", Slot = "7")]
		private void NCNCBIPHHAP(NMNMIBDPDJO ENEIIOEOMIG, IKIAFOJMKNP BIFNKFCMILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5F64A40", Offset = "0x5F63840", VA = "0x185F64A40", Slot = "8")]
		private FEBLAMBEGIC FFMLCKIJLMM(Transform PFIKOEBPDGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x5F64D20", Offset = "0x5F63B20", VA = "0x185F64D20", Slot = "9")]
		private void MJEAFJLEEDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class DENJHIILKDN
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x259D240", Offset = "0x259C040", VA = "0x18259D240")]
	public static EFBJNCEKMLK<T> HOHOPODPCOP<T>(this IBPIJCMLLGH PPDHICBEIFC)
	{
		return null;
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
