using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.ClusterLODs;
using RecRoom.Configs;
using RecRoom.Core.Creation.Shapes;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging.Attributes;
using RecRoom.ShapeRendering;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ShapeRendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : CGFLIBNDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C8DF10", Offset = "0x7C8CD10", VA = "0x187C8DF10", Slot = "4")]
		public override void EHDMJEMLBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BPEKNCELEHO : IOHMOLEBNPI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte NFODCLGEDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] BKBGMMKNDEH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NPPEOMOFFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB5DD0", Offset = "0xAB4BD0", VA = "0x180AB5DD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB4A980", Offset = "0xB49780", VA = "0x180B4A980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KIFFBEKJFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x935800", Offset = "0x934600", VA = "0x180935800", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9353A0", Offset = "0x9341A0", VA = "0x1809353A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float MBHEKFPLGOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xDA62D0", Offset = "0xDA50D0", VA = "0x180DA62D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x10464E0", Offset = "0x10452E0", VA = "0x1810464E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float BGLJEEDCIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB08D40", Offset = "0xB07B40", VA = "0x180B08D40", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB08D50", Offset = "0xB07B50", VA = "0x180B08D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> PANJEKJFOCF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C83050", Offset = "0x7C81E50", VA = "0x187C83050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> MMAINBHHKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C83210", Offset = "0x7C82010", VA = "0x187C83210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject DIPIAJCGAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8F4270", Offset = "0x8F3070", VA = "0x1808F4270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B30", Offset = "0x8F6930", VA = "0x1808F7B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte FNDMLBPEIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C831C0", Offset = "0x7C81FC0", VA = "0x187C831C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C83390", Offset = "0x7C82190", VA = "0x187C83390")]
	public BPEKNCELEHO(List<PNANCJKHKPO> HCEKKMKELAN, List<PNANCJKHKPO> EBBGAOBLGNJ, List<IDOAIIMFGBF> GFIFOBCOIKB, Material FAGGGCGAPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C830A0", Offset = "0x7C81EA0", VA = "0x187C830A0")]
	private int JBDIOJCFPGG(List<PNANCJKHKPO> OBGKKCDOELJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C82EF0", Offset = "0x7C81CF0", VA = "0x187C82EF0")]
	private void FAFNBOEMLEI(int GNHJMDDKICN, bool BNMEJFFHBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C83240", Offset = "0x7C82040", VA = "0x187C83240")]
	public void PNPGKAHKGHH(Vector3 PJBMLNGNHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C82DF0", Offset = "0x7C81BF0", VA = "0x187C82DF0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C82DB0", Offset = "0x7C81BB0", VA = "0x187C82DB0")]
	public void AFKGCPLPJHB(Transform ELDNLEIHKEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DMJADNCILJE : PFCDHOFMHCL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class HMBHOEKDFBE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public DMJADNCILJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xC3B4C0", Offset = "0xC3A2C0", VA = "0x180C3B4C0")]
		[DebuggerHidden]
		public HMBHOEKDFBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7C8CE80", Offset = "0x7C8BC80", VA = "0x187C8CE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7C8C870", Offset = "0x7C8B670", VA = "0x187C8C870", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7C8C780", Offset = "0x7C8B580", VA = "0x187C8C780")]
		private void GEDOPIMJGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7C8C7D0", Offset = "0x7C8B5D0", VA = "0x187C8C7D0")]
		private void HHOEFEHKFHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7C8C820", Offset = "0x7C8B620", VA = "0x187C8C820")]
		private void KAAGMFPNLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7C8CE30", Offset = "0x7C8BC30", VA = "0x187C8CE30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C8CD80", Offset = "0x7C8BB80", VA = "0x187C8CD80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C8CD80", Offset = "0x7C8BB80", VA = "0x187C8CD80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class IKAAGELBAOD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public DMJADNCILJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xC3B4C0", Offset = "0xC3A2C0", VA = "0x180C3B4C0")]
		[DebuggerHidden]
		public IKAAGELBAOD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D580", Offset = "0x7C8C380", VA = "0x187C8D580", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D110", Offset = "0x7C8BF10", VA = "0x187C8D110", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D070", Offset = "0x7C8BE70", VA = "0x187C8D070")]
		private void GEDOPIMJGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D0C0", Offset = "0x7C8BEC0", VA = "0x187C8D0C0")]
		private void HHOEFEHKFHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D530", Offset = "0x7C8C330", VA = "0x187C8D530", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D480", Offset = "0x7C8C280", VA = "0x187C8D480", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D480", Offset = "0x7C8C280", VA = "0x187C8D480", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly LPPLGFGBCLD PFEGEFINGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<BJOOHBIEDCM> FHBOHIODODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> DFIOLMJOECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer PCCAJOOHMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool OPAIGFINEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool HCPENBFAHMO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<EMPAKPFOAFB> NONHMJBFGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int HAPIFGJLPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C886E0", Offset = "0x7C874E0", VA = "0x187C886E0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IDOAIIMFGBF EDNMBBEAHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C888F0", Offset = "0x7C876F0", VA = "0x187C888F0", Slot = "8")]
		get
		{
			return default(IDOAIIMFGBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> FPEAAAPEKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8F4490", Offset = "0x8F3290", VA = "0x1808F4490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8F4480", Offset = "0x8F3280", VA = "0x1808F4480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C870F0", Offset = "0x7C85EF0", VA = "0x187C870F0")]
	private bool AOJOLFJJHAB(BJOOHBIEDCM CKJIDNLNDHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C87110", Offset = "0x7C85F10", VA = "0x187C87110")]
	private static bool CLBLMINNIAK(BJOOHBIEDCM CKJIDNLNDHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C889B0", Offset = "0x7C877B0", VA = "0x187C889B0")]
	public DMJADNCILJE(LPPLGFGBCLD JOAPLPPIFPC, bool BMPPPKDOEDN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C872D0", Offset = "0x7C860D0", VA = "0x187C872D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C88540", Offset = "0x7C87340", VA = "0x187C88540")]
	public void MDGAONDGEMG(BJOOHBIEDCM CKJIDNLNDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C881D0", Offset = "0x7C86FD0", VA = "0x187C881D0")]
	public void IEINLEAGPOE(BJOOHBIEDCM CKJIDNLNDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C87A60", Offset = "0x7C86860", VA = "0x187C87A60", Slot = "4")]
	public void GFABEEBAMLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C882F0", Offset = "0x7C870F0", VA = "0x187C882F0")]
	public void IGIPDIBMNHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C88010", Offset = "0x7C86E10", VA = "0x187C88010")]
	private void HGKAMDDHJLI(List<BJOOHBIEDCM> FHBOHIODODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C87270", Offset = "0x7C86070", VA = "0x187C87270")]
	private static Material DNANFAAHCFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C87F60", Offset = "0x7C86D60", VA = "0x187C87F60")]
	private void HGKAMDDHJLI(BJOOHBIEDCM CKJIDNLNDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C887A0", Offset = "0x7C875A0", VA = "0x187C887A0")]
	private void MOOMHBPCMFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C874A0", Offset = "0x7C862A0", VA = "0x187C874A0")]
	public void GCDAIGNICHC(bool BDDGACPBFAB, bool HFAOGJDBAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7C871B0", Offset = "0x7C85FB0", VA = "0x187C871B0")]
	protected void DKBFJADJEGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C88720", Offset = "0x7C87520", VA = "0x187C88720")]
	public void MJBKDJMGKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C87130", Offset = "0x7C85F30", VA = "0x187C87130")]
	[IteratorStateMachine(typeof(HMBHOEKDFBE))]
	public IEnumerable<Renderer> DENMCCPECKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C88870", Offset = "0x7C87670", VA = "0x187C88870")]
	[IteratorStateMachine(typeof(IKAAGELBAOD))]
	public IEnumerable<Renderer> OEONKOLJHGG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal class MNOMDOIKFMA : BJOOHBIEDCM
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct OIKHOGIELEK : HHOOJHBBHOL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BBJAJADCNOE KLMHPHDLFFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle JELKNJKJNOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private MEMFDAPCNGG OMFDHGBMGGD;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7C92370", Offset = "0x7C91170", VA = "0x187C92370")]
		public OIKHOGIELEK(BBJAJADCNOE KLMHPHDLFFG, JobHandle JELKNJKJNOO, MEMFDAPCNGG OMFDHGBMGGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7C92340", Offset = "0x7C91140", VA = "0x187C92340", Slot = "4")]
		public BBJAJADCNOE EHCAOMMFNME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7C922F0", Offset = "0x7C910F0", VA = "0x187C922F0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly ELAPOOPPBIK ICCCFEEPBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float NCHBOHCFOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 BNJIOGMNKJL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 KLKDBDKAEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7C90910", Offset = "0x7C8F710", VA = "0x187C90910", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C92240", Offset = "0x7C91040", VA = "0x187C92240")]
	public MNOMDOIKFMA(DMJADNCILJE DOJENPPADJD, ELAPOOPPBIK JOAPLPPIFPC, bool BMPPPKDOEDN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "18")]
	public override bool JPLELIFBGFK(IDOAIIMFGBF DOJENPPADJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C91520", Offset = "0x7C90320", VA = "0x187C91520", Slot = "19")]
	public override int JBDIOJCFPGG(JBNIIDCLNCM DFCGNGEAOFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C916F0", Offset = "0x7C904F0", VA = "0x187C916F0", Slot = "20")]
	public override int JOAJNOOJFIO(JBNIIDCLNCM DFCGNGEAOFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7C90A30", Offset = "0x7C8F830", VA = "0x187C90A30", Slot = "21")]
	public override DJLIDDPAMIF HAJEFBADKFC()
	{
		return default(DJLIDDPAMIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xACAF60", Offset = "0xAC9D60", VA = "0x180ACAF60", Slot = "22")]
	public override float CONDGOLDLIN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7C90E70", Offset = "0x7C8FC70", VA = "0x187C90E70", Slot = "23")]
	public override void IDDHPNGMGNM(JBNIIDCLNCM DFCGNGEAOFE, EPOJNOKMFGO CINOPBJHMJJ, int DHCOFIIDHKP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C91450", Offset = "0x7C90250", VA = "0x187C91450", Slot = "24")]
	public override IDOAIIMFGBF IOAJCHBBPAB()
	{
		return default(IDOAIIMFGBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C92080", Offset = "0x7C90E80", VA = "0x187C92080", Slot = "26")]
	public override EALOACCFPOE PNDFICNLIEB()
	{
		return default(EALOACCFPOE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C918C0", Offset = "0x7C906C0", VA = "0x187C918C0", Slot = "27")]
	public override HHOOJHBBHOL NPDLBCPIJLE(JBNIIDCLNCM DFCGNGEAOFE, JobHandle JELKNJKJNOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public interface JMMMKLFOBBP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DMJADNCILJE FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	BJOOHBIEDCM FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	CFHBGNIHFND FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public class CNJAEOCPGGK : EHONGHPLPEE, IDisposable, JMMMKLFOBBP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct FJNEKMIJHFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CNJAEOCPGGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7C88AA0", Offset = "0x7C878A0", VA = "0x187C88AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7C88FC0", Offset = "0x7C87DC0", VA = "0x187C88FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly EGODAIJGHLL<KLDPLFJBOPH, DMJADNCILJE> DPCBJENGKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly EGODAIJGHLL<OKIHHGKOEFK, BJOOHBIEDCM> FHBOHIODODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly EGODAIJGHLL<LNAOICLPAFJ, CFHBGNIHFND> DMEGJLMOOEE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DMJADNCILJE FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7C86700", Offset = "0x7C85500", VA = "0x187C86700", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public BJOOHBIEDCM FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7C86760", Offset = "0x7C85560", VA = "0x187C86760", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public CFHBGNIHFND FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7C866A0", Offset = "0x7C854A0", VA = "0x187C866A0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool IGMDKHCJOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xCA2000", Offset = "0xCA0E00", VA = "0x180CA2000", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xCA1EC0", Offset = "0xCA0CC0", VA = "0x180CA1EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7C86C40", Offset = "0x7C85A40", VA = "0x187C86C40")]
	public CNJAEOCPGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7C85D60", Offset = "0x7C84B60", VA = "0x187C85D60", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7C86220", Offset = "0x7C85020", VA = "0x187C86220", Slot = "4")]
	public KLDPLFJBOPH IFGKEBOHBHC(LPPLGFGBCLD JOAPLPPIFPC)
	{
		return default(KLDPLFJBOPH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C86230", Offset = "0x7C85030", VA = "0x187C86230", Slot = "5")]
	public KLDPLFJBOPH IFGKEBOHBHC(LPPLGFGBCLD JOAPLPPIFPC, bool BMPPPKDOEDN)
	{
		return default(KLDPLFJBOPH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C867C0", Offset = "0x7C855C0", VA = "0x187C867C0", Slot = "6")]
	public void OFNGKNPGHDO(KLDPLFJBOPH DOJENPPADJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C84C00", Offset = "0x7C83A00", VA = "0x187C84C00", Slot = "7")]
	public void BNCAMMDKGOF(KLDPLFJBOPH DOJENPPADJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7C85440", Offset = "0x7C84240", VA = "0x187C85440", Slot = "8")]
	public OKIHHGKOEFK DBPDJHAGCKD(KLDPLFJBOPH DOJENPPADJD, MPBNEJBMNDN JOAPLPPIFPC)
	{
		return default(OKIHHGKOEFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C84F60", Offset = "0x7C83D60", VA = "0x187C84F60", Slot = "9")]
	public OKIHHGKOEFK BOPCIBCGDBI(KLDPLFJBOPH DOJENPPADJD, ELAPOOPPBIK JOAPLPPIFPC)
	{
		return default(OKIHHGKOEFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C85920", Offset = "0x7C84720", VA = "0x187C85920", Slot = "11")]
	public void DDJELDBFAEN(OKIHHGKOEFK CKJIDNLNDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7C85F50", Offset = "0x7C84D50", VA = "0x187C85F50", Slot = "10")]
	public void FJKHJKACPHB(OKIHHGKOEFK CKJIDNLNDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C861B0", Offset = "0x7C84FB0", VA = "0x187C861B0", Slot = "20")]
	public IEnumerable<Renderer> HNKHPBJAMAO(KLDPLFJBOPH DOJENPPADJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C85CE0", Offset = "0x7C84AE0", VA = "0x187C85CE0", Slot = "12")]
	public LNAOICLPAFJ DMFKNLLJJNE(NLGHHFCMPEI JOAPLPPIFPC)
	{
		return default(LNAOICLPAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C864B0", Offset = "0x7C852B0", VA = "0x187C864B0", Slot = "14")]
	public void JIDCNGKHEJG(LNAOICLPAFJ GJLJFFJALNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7C86AB0", Offset = "0x7C858B0", VA = "0x187C86AB0", Slot = "16")]
	public Task POHHEGDLFAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C86520", Offset = "0x7C85320", VA = "0x187C86520", Slot = "17")]
	public Task NAALLEAMKDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7C84B30", Offset = "0x7C83930", VA = "0x187C84B30", Slot = "18")]
	[AsyncStateMachine(typeof(FJNEKMIJHFH))]
	public Task AOGPMJNIJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C86A20", Offset = "0x7C85820", VA = "0x187C86A20", Slot = "19")]
	public void PJJOFOLNOLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C85EF0", Offset = "0x7C84CF0", VA = "0x187C85EF0", Slot = "13")]
	public void ENBOMGDCKIO(LNAOICLPAFJ GJLJFFJALNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal class GFMMBNIFACC : BJOOHBIEDCM
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private struct PBFPHIEPENL : HHOOJHBBHOL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private BBJAJADCNOE KLMHPHDLFFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JobHandle JELKNJKJNOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private ADLCKPBFFFJ OMFDHGBMGGD;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7C92450", Offset = "0x7C91250", VA = "0x187C92450")]
		public PBFPHIEPENL(BBJAJADCNOE KLMHPHDLFFG, JobHandle JELKNJKJNOO, ADLCKPBFFFJ OMFDHGBMGGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7C92420", Offset = "0x7C91220", VA = "0x187C92420", Slot = "4")]
		public BBJAJADCNOE EHCAOMMFNME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7C923D0", Offset = "0x7C911D0", VA = "0x187C923D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly MPBNEJBMNDN COGAKILOFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] EMMODMHCNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 BNJIOGMNKJL;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 IILLHHLAEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7C89020", Offset = "0x7C87E20", VA = "0x187C89020")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 KLKDBDKAEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C89340", Offset = "0x7C88140", VA = "0x187C89340", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C8B830", Offset = "0x7C8A630", VA = "0x187C8B830")]
	public GFMMBNIFACC(DMJADNCILJE DOJENPPADJD, MPBNEJBMNDN JOAPLPPIFPC, bool ENOMJIHMDIB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7C8A9A0", Offset = "0x7C897A0", VA = "0x187C8A9A0", Slot = "18")]
	public override bool JPLELIFBGFK(IDOAIIMFGBF DOJENPPADJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7C89AC0", Offset = "0x7C888C0", VA = "0x187C89AC0", Slot = "21")]
	public override DJLIDDPAMIF HAJEFBADKFC()
	{
		return default(DJLIDDPAMIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C89460", Offset = "0x7C88260", VA = "0x187C89460")]
	private DJLIDDPAMIF HAJEFBADKFC(IDOAIIMFGBF DOJENPPADJD)
	{
		return default(DJLIDDPAMIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C8B630", Offset = "0x7C8A430", VA = "0x187C8B630")]
	private BIIEOJJLKBI PNDGADBHDHF([In] UniformTRS EFHONKNDDMN, [In] float3 KBLPBKMHEGE)
	{
		return default(BIIEOJJLKBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7C8A750", Offset = "0x7C89550", VA = "0x187C8A750", Slot = "19")]
	public override int JBDIOJCFPGG(JBNIIDCLNCM DFCGNGEAOFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7C8A8F0", Offset = "0x7C896F0", VA = "0x187C8A8F0", Slot = "20")]
	public override int JOAJNOOJFIO(JBNIIDCLNCM DFCGNGEAOFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7C89250", Offset = "0x7C88050", VA = "0x187C89250", Slot = "22")]
	public override float CONDGOLDLIN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7C8AA70", Offset = "0x7C89870", VA = "0x187C8AA70")]
	private int MCHFAFDOGBG(JBNIIDCLNCM DFCGNGEAOFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7C89B00", Offset = "0x7C88900", VA = "0x187C89B00", Slot = "23")]
	public override void IDDHPNGMGNM(JBNIIDCLNCM DFCGNGEAOFE, EPOJNOKMFGO CINOPBJHMJJ, int DHCOFIIDHKP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7C8A680", Offset = "0x7C89480", VA = "0x187C8A680", Slot = "24")]
	public override IDOAIIMFGBF IOAJCHBBPAB()
	{
		return default(IDOAIIMFGBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7C8B470", Offset = "0x7C8A270", VA = "0x187C8B470", Slot = "26")]
	public override EALOACCFPOE PNDFICNLIEB()
	{
		return default(EALOACCFPOE);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7C8ACF0", Offset = "0x7C89AF0", VA = "0x187C8ACF0", Slot = "27")]
	public override HHOOJHBBHOL NPDLBCPIJLE(JBNIIDCLNCM DFCGNGEAOFE, JobHandle JELKNJKJNOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BAPBPLIHMIK
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JMOGEBAFJMJ(IJIMINIKDMH OBDHBADPJNM, Renderer ANNHGGDABAO, int NLPFKGMDHJK);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BKMJFOKGEBK(Renderer ANNHGGDABAO, HKPFFIEJALG ICGIPJGENJM, Vector3 IHNAJKLAENA, Vector3 NBABABJONCA, Vector3 DCGDGGNJFJO, float HDCAALNNBKL, float CIDFJCGBHAA, float KNBLLHGCNEH = -1f, [Optional] Color? EDAHAPFCLBP, [Optional] IReadOnlyList<Camera> GFFOJKBNFGE);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JOFFEEEBKII(Renderer ANNHGGDABAO, int NLPFKGMDHJK);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int EKLLNJNEAIM();

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JNJMPLGIDDP(int HGDOOEOOPIK, IIDEEAJADIF OBDHBADPJNM, Renderer ANNHGGDABAO, int NLPFKGMDHJK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MCPOFNDFMFC : CKINBMACMLL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class JGIINILLAAK : GIIFAPNGELK<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C8DAC0", Offset = "0x7C8C8C0", VA = "0x187C8DAC0")]
		public JGIINILLAAK(string PPKJBGAOBJL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly BAPBPLIHMIK LMLOCINMAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly JMMMKLFOBBP KLNCDPGLBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private MeshRenderer LPBLIPGFHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private JGIINILLAAK IFBAIHJEHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private bool HDOBBGPPJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MeshRenderer IEPOMLKAIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private JGIINILLAAK IOFNEPBNIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool FOHHABLNKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MeshRenderer HHPLKGKNCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private JGIINILLAAK DIJNPNDDPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool NMKHIGJJBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool BBDDFKFCEGM;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x904660", Offset = "0x903460", VA = "0x180904660")]
	public MCPOFNDFMFC(BAPBPLIHMIK JFOKBDEFMBN, JMMMKLFOBBP KLNCDPGLBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7C8E6E0", Offset = "0x7C8D4E0", VA = "0x187C8E6E0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FA80", Offset = "0x7C8E880", VA = "0x187C8FA80")]
	private void IBLPPPJGGBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7C8EA30", Offset = "0x7C8D830", VA = "0x187C8EA30", Slot = "4")]
	public void GPKKKEEKDED(KLDPLFJBOPH DOJENPPADJD, IIDEEAJADIF NCIPABHIJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7C8ED40", Offset = "0x7C8DB40", VA = "0x187C8ED40", Slot = "5")]
	public void GPKKKEEKDED(OKIHHGKOEFK CKJIDNLNDHF, IIDEEAJADIF NCIPABHIJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7C8E110", Offset = "0x7C8CF10", VA = "0x187C8E110", Slot = "6")]
	public void BNGJGGELGPO(OKIHHGKOEFK CKJIDNLNDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7C90590", Offset = "0x7C8F390", VA = "0x187C90590", Slot = "7")]
	public void KOFIBBDGECE(OKIHHGKOEFK CKJIDNLNDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7C907B0", Offset = "0x7C8F5B0", VA = "0x187C907B0", Slot = "24")]
	public void MFNECDFPJCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xEE2200", Offset = "0xEE1000", VA = "0x180EE2200", Slot = "8")]
	public void IGJOAAEJHAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7C8DFA0", Offset = "0x7C8CDA0", VA = "0x187C8DFA0", Slot = "9")]
	public void BDMGPECAHHK(IIDEEAJADIF NCIPABHIJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7C902C0", Offset = "0x7C8F0C0", VA = "0x187C902C0", Slot = "10")]
	public void JMLHJGBNPLA(KLDPLFJBOPH DOJENPPADJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FF60", Offset = "0x7C8ED60", VA = "0x187C8FF60", Slot = "11")]
	public void JMLHJGBNPLA(OKIHHGKOEFK CKJIDNLNDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7C906E0", Offset = "0x7C8F4E0", VA = "0x187C906E0", Slot = "12")]
	public void LEKBBBMCALB(OKIHHGKOEFK CKJIDNLNDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C8E4E0", Offset = "0x7C8D2E0", VA = "0x187C8E4E0", Slot = "13")]
	public void DKINCCFGFAL(OKIHHGKOEFK CKJIDNLNDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C8E270", Offset = "0x7C8D070", VA = "0x187C8E270")]
	private void DDEFENILAKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xFD7D00", Offset = "0xFD6B00", VA = "0x180FD7D00", Slot = "14")]
	public void DDOOHAJBEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C907F0", Offset = "0x7C8F5F0", VA = "0x187C907F0", Slot = "15")]
	public void OJPCMDGIDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C8EF60", Offset = "0x7C8DD60", VA = "0x187C8EF60", Slot = "16")]
	public void HILBOFLDBAB(KLDPLFJBOPH DOJENPPADJD, IJIMINIKDMH OBDHBADPJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C8E890", Offset = "0x7C8D690", VA = "0x187C8E890", Slot = "17")]
	public void EBHBAIFJDKO(OKIHHGKOEFK CKJIDNLNDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C8E960", Offset = "0x7C8D760", VA = "0x187C8E960", Slot = "18")]
	public void GNHFFPFBLEH(OKIHHGKOEFK CKJIDNLNDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0xC65200", Offset = "0xC64000", VA = "0x180C65200", Slot = "19")]
	public void KOINBCBCMIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C8E5B0", Offset = "0x7C8D3B0", VA = "0x187C8E5B0", Slot = "20")]
	public void DPAPHFEGEKJ(IJIMINIKDMH OBDHBADPJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FCF0", Offset = "0x7C8EAF0", VA = "0x187C8FCF0")]
	private void IOFOEAHMBOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F240", Offset = "0x7C8E040", VA = "0x187C8F240", Slot = "21")]
	public void HMAAAGPCFFC(KLDPLFJBOPH DOJENPPADJD, Vector3 IHNAJKLAENA, Vector3 NBABABJONCA, Vector3 DCGDGGNJFJO, float HDCAALNNBKL, float CIDFJCGBHAA, IReadOnlyList<Camera> PGMIBGALBJN, HKPFFIEJALG ICGIPJGENJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F600", Offset = "0x7C8E400", VA = "0x187C8F600", Slot = "22")]
	public void HMAAAGPCFFC(LNAOICLPAFJ GJLJFFJALNO, Vector3 IHNAJKLAENA, Vector3 NBABABJONCA, Vector3 DCGDGGNJFJO, float HDCAALNNBKL, float CIDFJCGBHAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public abstract class BJOOHBIEDCM : ALLJHDJHLPF, EMPAKPFOAFB, FKLAAFPFHDC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly DMJADNCILJE DIPIAJCGAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private int MMNAOPIKGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected Bounds GHKMPJFOJCF;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds JBGKGLCADCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C82B60", Offset = "0x7C81960", VA = "0x187C82B60", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool HCPENBFAHMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xC18730", Offset = "0xC17530", VA = "0x180C18730")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xC185A0", Offset = "0xC173A0", VA = "0x180C185A0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 KLKDBDKAEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int MAKECDBJMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA9F400", Offset = "0xA9E200", VA = "0x180A9F400", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public AKFOGELOCEO IHFCFFGDLDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8F4490", Offset = "0x8F3290", VA = "0x1808F4490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8F4480", Offset = "0x8F3280", VA = "0x1808F4480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool GKDNPLFHAOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1D3E2C0", Offset = "0x1D3D0C0", VA = "0x181D3E2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	protected BJOOHBIEDCM(DMJADNCILJE DOJENPPADJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7C82A30", Offset = "0x7C81830", VA = "0x187C82A30", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "18")]
	public virtual bool JPLELIFBGFK(IDOAIIMFGBF DOJENPPADJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7C82BE0", Offset = "0x7C819E0", VA = "0x187C82BE0", Slot = "10")]
	public int OCAMPLEBMLH(int OINPDPBCNGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int JBDIOJCFPGG(JBNIIDCLNCM DFCGNGEAOFE);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int JOAJNOOJFIO(JBNIIDCLNCM DFCGNGEAOFE);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract DJLIDDPAMIF HAJEFBADKFC();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float CONDGOLDLIN();

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void IDDHPNGMGNM(JBNIIDCLNCM DFCGNGEAOFE, EPOJNOKMFGO CINOPBJHMJJ, int DHCOFIIDHKP = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract IDOAIIMFGBF IOAJCHBBPAB();

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7C82B80", Offset = "0x7C81980", VA = "0x187C82B80", Slot = "13")]
	public Hash128 MAPMLGBPNLE(int DFCGNGEAOFE)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract EALOACCFPOE PNDFICNLIEB();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract HHOOJHBBHOL NPDLBCPIJLE(JBNIIDCLNCM DFCGNGEAOFE, JobHandle JELKNJKJNOO);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7C82BB0", Offset = "0x7C819B0", VA = "0x187C82BB0", Slot = "12")]
	public HHOOJHBBHOL MICHGOBOHEA(int DFCGNGEAOFE)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ShapeRendererConfig : SingletonScriptableObject<ShapeRendererConfig>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C94890", Offset = "0x7C93690", VA = "0x187C94890")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class HGPBLLHJJHO
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class BOFCKIIACBA : IEnumerable<KCGOBKPOOMN>, IEnumerable, IEnumerator<KCGOBKPOOMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private KCGOBKPOOMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private KCGOBKPOOMN System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xC3B4C0", Offset = "0xC3A2C0", VA = "0x180C3B4C0")]
		[DebuggerHidden]
		public BOFCKIIACBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C82BF0", Offset = "0x7C819F0", VA = "0x187C82BF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C82D60", Offset = "0x7C81B60", VA = "0x187C82D60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C82CC0", Offset = "0x7C81AC0", VA = "0x187C82CC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KCGOBKPOOMN> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C82CC0", Offset = "0x7C81AC0", VA = "0x187C82CC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static KCGOBKPOOMN[][] CJFJHOJALCB;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static HHMJFEBPFMD GFPENCMGFKC;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ShapeRendererConfig NFFMGBCCBPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C8C6B0", Offset = "0x7C8B4B0", VA = "0x187C8C6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ComputeShader HHNMEAOBEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7C8C1C0", Offset = "0x7C8AFC0", VA = "0x187C8C1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static SkinnedShapeRenderer KHBHIHILCAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C8B940", Offset = "0x7C8A740", VA = "0x187C8B940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7C8C110", Offset = "0x7C8AF10", VA = "0x187C8C110")]
	public static Mesh GLAJLAKIJFG(GMFMCBMNOIN CACOHNAJPFO, int DFCGNGEAOFE = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7C8BB60", Offset = "0x7C8A960", VA = "0x187C8BB60")]
	public static int DBDALDGMLHM(GMFMCBMNOIN CACOHNAJPFO, int DFCGNGEAOFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7C8BFC0", Offset = "0x7C8ADC0", VA = "0x187C8BFC0")]
	public static HHMJFEBPFMD FCNBNEDFOIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7C8B8E0", Offset = "0x7C8A6E0", VA = "0x187C8B8E0")]
	[IteratorStateMachine(typeof(BOFCKIIACBA))]
	private static IEnumerable<KCGOBKPOOMN> AEIOPIMJMHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C8C400", Offset = "0x7C8B200", VA = "0x187C8C400")]
	public static KCGOBKPOOMN JKCGACBKDNH(GMFMCBMNOIN CACOHNAJPFO, int DFCGNGEAOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C8C6F0", Offset = "0x7C8B4F0", VA = "0x187C8C6F0")]
	public static bool PCNHKHIFDEO(this GMFMCBMNOIN CACOHNAJPFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7C8B9B0", Offset = "0x7C8A7B0", VA = "0x187C8B9B0")]
	public static void CELJMIIJDEN(GMFMCBMNOIN CACOHNAJPFO, float3 ANAOIFFCKHB, [Out] FEOOIPEMODG LGIHEOGBDEO, [Out] float3 GGLNPEOPJLN, [Out] float JODLDIBLAHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7C8BB70", Offset = "0x7C8A970", VA = "0x187C8BB70")]
	public static void ENOPMNEPDOF(Vector3 ANAOIFFCKHB, GMFMCBMNOIN CACOHNAJPFO, [Out] Vector3 GGLNPEOPJLN, [Out] float JODLDIBLAHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7C8C6E0", Offset = "0x7C8B4E0", VA = "0x187C8C6E0")]
	[IDLAPLKHLAA(ECMLOFDPNGP.ExitingPlayMode, 0)]
	[FOAJBIFLHJK(0)]
	private static void OLELIKOECMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7C8C230", Offset = "0x7C8B030", VA = "0x187C8C230")]
	[FOAJBIFLHJK(0)]
	[IDLAPLKHLAA(ECMLOFDPNGP.ExitingPlayMode, 0)]
	private static void HKGJGOOKCOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class PELCJJEANBA : EHONGHPLPEE, IDisposable, JMMMKLFOBBP
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly EGODAIJGHLL<KLDPLFJBOPH, DMJADNCILJE> DPCBJENGKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly EGODAIJGHLL<OKIHHGKOEFK, BJOOHBIEDCM> FHBOHIODODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly EGODAIJGHLL<LNAOICLPAFJ, CFHBGNIHFND> DMEGJLMOOEE;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public DMJADNCILJE FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C92CC0", Offset = "0x7C91AC0", VA = "0x187C92CC0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public BJOOHBIEDCM FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C92D80", Offset = "0x7C91B80", VA = "0x187C92D80", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public CFHBGNIHFND FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C92D20", Offset = "0x7C91B20", VA = "0x187C92D20", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool IGMDKHCJOFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xCA2000", Offset = "0xCA0E00", VA = "0x180CA2000", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xCA1EC0", Offset = "0xCA0CC0", VA = "0x180CA1EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7C92F70", Offset = "0x7C91D70", VA = "0x187C92F70")]
	public PELCJJEANBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7C92950", Offset = "0x7C91750", VA = "0x187C92950", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7C92B10", Offset = "0x7C91910", VA = "0x187C92B10", Slot = "4")]
	public KLDPLFJBOPH IFGKEBOHBHC(LPPLGFGBCLD JOAPLPPIFPC)
	{
		return default(KLDPLFJBOPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C92B10", Offset = "0x7C91910", VA = "0x187C92B10", Slot = "5")]
	public KLDPLFJBOPH IFGKEBOHBHC(LPPLGFGBCLD JOAPLPPIFPC, bool BMPPPKDOEDN)
	{
		return default(KLDPLFJBOPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7C92DE0", Offset = "0x7C91BE0", VA = "0x187C92DE0", Slot = "6")]
	public void OFNGKNPGHDO(KLDPLFJBOPH DOJENPPADJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C92540", Offset = "0x7C91340", VA = "0x187C92540", Slot = "7")]
	public void BNCAMMDKGOF(KLDPLFJBOPH DOJENPPADJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C92700", Offset = "0x7C91500", VA = "0x187C92700", Slot = "8")]
	public OKIHHGKOEFK DBPDJHAGCKD(KLDPLFJBOPH DOJENPPADJD, MPBNEJBMNDN JOAPLPPIFPC)
	{
		return default(OKIHHGKOEFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C925C0", Offset = "0x7C913C0", VA = "0x187C925C0", Slot = "9")]
	public OKIHHGKOEFK BOPCIBCGDBI(KLDPLFJBOPH DOJENPPADJD, ELAPOOPPBIK JOAPLPPIFPC)
	{
		return default(OKIHHGKOEFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C92840", Offset = "0x7C91640", VA = "0x187C92840", Slot = "11")]
	public void DDJELDBFAEN(OKIHHGKOEFK CKJIDNLNDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7C92A40", Offset = "0x7C91840", VA = "0x187C92A40", Slot = "10")]
	public void FJKHJKACPHB(OKIHHGKOEFK CKJIDNLNDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C92AA0", Offset = "0x7C918A0", VA = "0x187C92AA0", Slot = "20")]
	public IEnumerable<Renderer> HNKHPBJAMAO(KLDPLFJBOPH DOJENPPADJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C928D0", Offset = "0x7C916D0", VA = "0x187C928D0", Slot = "12")]
	public LNAOICLPAFJ DMFKNLLJJNE(NLGHHFCMPEI JOAPLPPIFPC)
	{
		return default(LNAOICLPAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C92BB0", Offset = "0x7C919B0", VA = "0x187C92BB0", Slot = "14")]
	public void JIDCNGKHEJG(LNAOICLPAFJ GJLJFFJALNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C92E40", Offset = "0x7C91C40", VA = "0x187C92E40", Slot = "16")]
	public Task POHHEGDLFAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C92C20", Offset = "0x7C91A20", VA = "0x187C92C20", Slot = "17")]
	public Task NAALLEAMKDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C924A0", Offset = "0x7C912A0", VA = "0x187C924A0", Slot = "18")]
	public Task AOGPMJNIJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2437270", Offset = "0x2436070", VA = "0x182437270", Slot = "19")]
	public void PJJOFOLNOLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7C929E0", Offset = "0x7C917E0", VA = "0x187C929E0", Slot = "13")]
	public void ENBOMGDCKIO(LNAOICLPAFJ GJLJFFJALNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface AMBDCOMGJNC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool CCDPBEFDOKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material BGAEEANHFFG();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material DNANFAAHCFD();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material GIDGDPGNNJJ();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BAAEEPLDDDK(BDCLPCNFFNI AIIAALEAOJN);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int AFLIAMJCFLF(OPLNEGJOKGG ACBAFPBLIEB);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MILAKPMFKDL(GameObject JOOHPPHJKMI);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FHIIANFPLOH(GameObject JOOHPPHJKMI, bool INOKNKOEGMB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class IKLDBHLABEM
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static AMBDCOMGJNC MNCBDJMAFIF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static bool CCDPBEFDOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D7F0", Offset = "0x7C8C5F0", VA = "0x187C8D7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D990", Offset = "0x7C8C790", VA = "0x187C8D990")]
	public static void HOCIJICILCA(AMBDCOMGJNC GJCHHAELKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D790", Offset = "0x7C8C590", VA = "0x187C8D790")]
	public static Material BGAEEANHFFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7C87270", Offset = "0x7C86070", VA = "0x187C87270")]
	public static Material DNANFAAHCFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D930", Offset = "0x7C8C730", VA = "0x187C8D930")]
	public static Material GIDGDPGNNJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D720", Offset = "0x7C8C520", VA = "0x187C8D720")]
	public static int BAAEEPLDDDK(BDCLPCNFFNI AIIAALEAOJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D6B0", Offset = "0x7C8C4B0", VA = "0x187C8D6B0")]
	public static int AFLIAMJCFLF(OPLNEGJOKGG ACBAFPBLIEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D9F0", Offset = "0x7C8C7F0", VA = "0x187C8D9F0")]
	public static void MILAKPMFKDL(GameObject JOOHPPHJKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D850", Offset = "0x7C8C650", VA = "0x187C8D850")]
	public static void FHIIANFPLOH(GameObject JOOHPPHJKMI, bool INOKNKOEGMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CFHBGNIHFND : PFCDHOFMHCL
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class JKHGDOCMBDE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CFHBGNIHFND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xC3B4C0", Offset = "0xC3A2C0", VA = "0x180C3B4C0")]
		[DebuggerHidden]
		public JKHGDOCMBDE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7C8DE80", Offset = "0x7C8CC80", VA = "0x187C8DE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7C8DB60", Offset = "0x7C8C960", VA = "0x187C8DB60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7C8DB10", Offset = "0x7C8C910", VA = "0x187C8DB10")]
		private void GEDOPIMJGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7C8DE30", Offset = "0x7C8CC30", VA = "0x187C8DE30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7C8DD80", Offset = "0x7C8CB80", VA = "0x187C8DD80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7C8DD80", Offset = "0x7C8CB80", VA = "0x187C8DD80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly NLGHHFCMPEI MKJJLKEFFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly JMMMKLFOBBP KLNCDPGLBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private BPEKNCELEHO LCNFLIFEHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private List<PNANCJKHKPO> HLHLOPNHPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private List<PNANCJKHKPO> NFHHDCEMHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private GameObject HOCJFFPEKEK;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7C836B0", Offset = "0x7C824B0", VA = "0x187C836B0")]
	public static CFHBGNIHFND AALHPLHJONJ(NLGHHFCMPEI JOAPLPPIFPC, JMMMKLFOBBP KLNCDPGLBDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7C84A50", Offset = "0x7C83850", VA = "0x187C84A50")]
	private CFHBGNIHFND(NLGHHFCMPEI JOAPLPPIFPC, JMMMKLFOBBP KLNCDPGLBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7C845C0", Offset = "0x7C833C0", VA = "0x187C845C0")]
	public void MOHLAAINEEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7C83800", Offset = "0x7C82600", VA = "0x187C83800")]
	[IteratorStateMachine(typeof(JKHGDOCMBDE))]
	public IEnumerable<Renderer> DENMCCPECKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7C83880", Offset = "0x7C82680", VA = "0x187C83880", Slot = "4")]
	public void GFABEEBAMLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7C84590", Offset = "0x7C83390", VA = "0x187C84590")]
	private void MJIIJENMKNP(Vector3 PJBMLNGNHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7C84340", Offset = "0x7C83140", VA = "0x187C84340")]
	public void IGIPDIBMNHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PNANCJKHKPO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private struct HGNKGIEGFHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public EPOJNOKMFGO LKCKDKKDIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public IDOAIIMFGBF JEMDHAPFEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int HHJBPCBLLBA;
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class PLOCHBJNGDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public PNANCJKHKPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public JBNIIDCLNCM lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public List<HGNKGIEGFHA> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public BBJAJADCNOE combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public PLOCHBJNGDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7C93500", Offset = "0x7C92300", VA = "0x187C93500")]
		internal JobHandle HKOLEGPFFOA()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7C934D0", Offset = "0x7C922D0", VA = "0x187C934D0")]
		internal void HBOGFEDCIHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7C93360", Offset = "0x7C92160", VA = "0x187C93360")]
		internal void GENKBHDHNKN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private int[] IOABJJNADNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private FDCBLMGMGLF DDNIGIFEKCO;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static Matrix4x4 EGNIIDOEALJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Mesh GJCBGJJFHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int CAIKGCFBPEH
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE20", Offset = "0x8F9C20", VA = "0x1808FAE20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE10", Offset = "0x8F9C10", VA = "0x1808FAE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7C93D70", Offset = "0x7C92B70", VA = "0x187C93D70")]
	public void GCAGHHGDEPL(List<IDOAIIMFGBF> EAMKGPEKFOJ, Matrix4x4[] ABGLLJCJOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7C93560", Offset = "0x7C92360", VA = "0x187C93560")]
	public static List<PNANCJKHKPO> DCMOGLEGFAE(List<DMJADNCILJE> DOLNEMDPGIG, JBNIIDCLNCM DFCGNGEAOFE, Bounds LCLBKGOJDKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7C93F60", Offset = "0x7C92D60", VA = "0x187C93F60")]
	private JobHandle IAJFACLODGA(BBJAJADCNOE NLEFJHDMIMN, int PKFDHNKJAIP, int NOPKLOBAKNM, JBNIIDCLNCM DFCGNGEAOFE, List<HGNKGIEGFHA> LJKOKHCKPJD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7C93C90", Offset = "0x7C92A90", VA = "0x187C93C90")]
	private void EEDCPMDCLKJ(List<HGNKGIEGFHA> LJKOKHCKPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7C94470", Offset = "0x7C93270", VA = "0x187C94470")]
	private PNANCJKHKPO(List<HGNKGIEGFHA> LJKOKHCKPJD, int PKFDHNKJAIP, int NOPKLOBAKNM, JBNIIDCLNCM DFCGNGEAOFE, Bounds LCLBKGOJDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7C93BF0", Offset = "0x7C929F0", VA = "0x187C93BF0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private MaterialPropertyBlock MJAOCOFLEHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private PNANCJKHKPO KLMHPHDLFFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private List<IDOAIIMFGBF> GFIFOBCOIKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private RenderTexture FKJOAFAKDAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private ComputeBuffer GGBIGDEPOLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private ComputeShader OPGCOAEILNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Matrix4x4[] ILBACPAEMAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int MDJDMAMGPKO;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MeshRenderer HKAIGPEJDHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8F41E0", Offset = "0x8F2FE0", VA = "0x1808F41E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int GFLFDJJDEPP
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7C95600", Offset = "0x7C94400", VA = "0x187C95600")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7C948F0", Offset = "0x7C936F0", VA = "0x187C948F0")]
		public static List<SkinnedShapeRenderer> Create(GameObject DOJENPPADJD, List<PNANCJKHKPO> OBGKKCDOELJ, List<IDOAIIMFGBF> GFIFOBCOIKB, Material FAGGGCGAPOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7C94F10", Offset = "0x7C93D10", VA = "0x187C94F10")]
		public void Init(PNANCJKHKPO KLMHPHDLFFG, List<IDOAIIMFGBF> GFIFOBCOIKB, Material FAGGGCGAPOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7C95560", Offset = "0x7C94360", VA = "0x187C95560")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7C954C0", Offset = "0x7C942C0", VA = "0x187C954C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7C95480", Offset = "0x7C94280", VA = "0x187C95480")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7C953C0", Offset = "0x7C941C0", VA = "0x187C953C0")]
		private void KBLPOLLIGNJ(ScriptableRenderContext MOBMLKIIAJP, Camera[] GPIFMLDIAEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7C94BA0", Offset = "0x7C939A0", VA = "0x187C94BA0")]
		private void GCAGHHGDEPL(CommandBuffer GPGKIICPFEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5B30", VA = "0x1808F6D30")]
		public SkinnedShapeRenderer()
		{
		}
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
