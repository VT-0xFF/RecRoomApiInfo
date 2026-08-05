using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BC45E0", Offset = "0x7BC39E0", VA = "0x187BC45E0", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1E06FF0", Offset = "0x1E063F0", VA = "0x181E06FF0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7BC57F0", Offset = "0x7BC4BF0", VA = "0x187BC57F0")]
		private void ECIMOAOBJPP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5C10", Offset = "0x7BC5010", VA = "0x187BC5C10", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5A40", Offset = "0x7BC4E40", VA = "0x187BC5A40", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5C70", Offset = "0x7BC5070", VA = "0x187BC5C70")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(NIDHFPJNBIE), new string[] { })]
[ServiceLifetime(Lifetime.PhotonRoom)]
public class NIDHFPJNBIE : MOHNMGIALGO, CBANIPAPHBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class OHEPLCNPMII : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public NIDHFPJNBIE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public OHEPLCNPMII(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5580", Offset = "0x7BC4980", VA = "0x187BC5580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC57A0", Offset = "0x7BC4BA0", VA = "0x187BC57A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private MHCLBGAKJBO EJMHIJKKJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DMBDJAPHJEC PIPMDKDFHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IDisposable DOKNGMLOIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private IDisposable EABHHMNJDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HashSet<ReflectionProbe> PDNLKNJDGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool FLLBGBDFJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool KMIBMNILPKF;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7BC54F0", Offset = "0x7BC48F0", VA = "0x187BC54F0")]
	[UnityEngine.Scripting.Preserve]
	public NIDHFPJNBIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC52B0", Offset = "0x7BC46B0", VA = "0x187BC52B0", Slot = "4")]
	public void PGJCOANBEKL(APLBLLDKDCG BMEANEKLBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4BC0", Offset = "0x7BC3FC0", VA = "0x187BC4BC0")]
	private void EDEIJPEDNOH(Scene PPGIPANFOCA, LoadSceneMode HGKGHOKBMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4D30", Offset = "0x7BC4130", VA = "0x187BC4D30")]
	private void HLIEPBKOEKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4F30", Offset = "0x7BC4330", VA = "0x187BC4F30")]
	private void NMKBLHLHPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC50F0", Offset = "0x7BC44F0", VA = "0x187BC50F0")]
	private (ReflectionProbe, int) PAMAGDPBKGC()
	{
		return default((ReflectionProbe, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4CB0", Offset = "0x7BC40B0", VA = "0x187BC4CB0")]
	[IteratorStateMachine(typeof(OHEPLCNPMII))]
	private IEnumerator<FBLKJCIOKGP> HJCHGOEIKAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5010", Offset = "0x7BC4410", VA = "0x187BC5010")]
	private void OHKEICELIFJ([CanBeNull] ReflectionProbe KNJMHNHCAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5430", Offset = "0x7BC4830", VA = "0x187BC5430")]
	private void POPIOCCJLPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4EE0", Offset = "0x7BC42E0", VA = "0x187BC4EE0")]
	private void MCAFJKIEJLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4BD0", Offset = "0x7BC3FD0", VA = "0x187BC4BD0", Slot = "5")]
	public void GFJNPMIAIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7BC46B0", Offset = "0x7BC3AB0", VA = "0x187BC46B0")]
	[CompilerGenerated]
	private void CHPJMAMKPOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MHCLBGAKJBO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int? IEHBBDBHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BLMAFBBAECK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHCLGICLCPJ();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HENPAPOPPGO : MHCLBGAKJBO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly string DMBOLIOPNLK;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly string IPJEAFALAPN;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly string FEGLCKHGPAB;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static readonly string ANMJFJFGBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CHDNBFGGGBI ALPCKLKABOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int? IJAJBDMJJNF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int? IEHBBDBHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool BLMAFBBAECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x94FCE0", Offset = "0x94F0E0", VA = "0x18094FCE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x94FCA0", Offset = "0x94F0A0", VA = "0x18094FCA0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	[UnityEngine.Scripting.Preserve]
	public HENPAPOPPGO([NotNull][IBJCGEMJMJL(null)] CHDNBFGGGBI DIKLELHCODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3BA0", Offset = "0x7BC2FA0", VA = "0x187BC3BA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3AA0", Offset = "0x7BC2EA0", VA = "0x187BC3AA0")]
	[HLOHOCOKELO.CMBCHPAFDOL.DIAIOJMELDA]
	[UsedImplicitly]
	public static void DPMEJGCNJCL(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4350", Offset = "0x7BC3750", VA = "0x187BC4350", Slot = "5")]
	public void PHCLGICLCPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3D80", Offset = "0x7BC3180", VA = "0x187BC3D80")]
	private void KNCIFNKCCLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3CA0", Offset = "0x7BC30A0", VA = "0x187BC3CA0")]
	private bool EEDODEIGJKE(string GEKKGANGAMN, [Out] ELDEJEIMAMA CLBAMAFCMOL)
	{
		return default(bool);
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
