using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using UJect;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class TGYWBCNCWWO
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x87FE5A0", Offset = "0x87FD7A0", VA = "0x1887FE5A0")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
	public TGYWBCNCWWO()
	{
	}
}
namespace _AssemblyRegistry.RecRoom_OnlineRestrictions_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87FF2E0", Offset = "0x87FE4E0", VA = "0x1887FF2E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x27815F0", Offset = "0x27807F0", VA = "0x1827815F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.OnlineRestrictions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnityEngine.Scripting.Preserve]
	public class OnlineRestrictions : COPKHIGAUKL
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class FNILLGPMACU<a> where a : Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Func<QYWXHNAXVVA, a> KWAKAXHTRNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public a MLSWMABILCP;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public FNILLGPMACU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4D58940", Offset = "0x4D57B40", VA = "0x184D58940")]
			internal bool TXJQKYVIZOG(QYWXHNAXVVA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BSXDQWQUYFX<a> where a : struct, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Func<a, int> TCBCSWFGSDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Func<QYWXHNAXVVA, a> KWAKAXHTRNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public a MLSWMABILCP;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public BSXDQWQUYFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x712D2C0", Offset = "0x712C4C0", VA = "0x18712D2C0")]
			internal bool OLFNMAFWIGT(QYWXHNAXVVA a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<QYWXHNAXVVA> JBYYCEYBGPY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<QYWXHNAXVVA> UJPSCRYHQFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x87FD2F0", Offset = "0x87FC4F0", VA = "0x1887FD2F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x87FE400", Offset = "0x87FD600", VA = "0x1887FE400")]
		[OCFGNIRMEEE.Root.GameOnly]
		internal static void YLVCABIOKIE(CYZVJPHMMVM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		[UnityEngine.Scripting.Preserve]
		internal OnlineRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87FD050", Offset = "0x87FC250", VA = "0x1887FD050")]
		private bool PBGNGPTXSWS(Func<QYWXHNAXVVA, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x87FCBD0", Offset = "0x87FBDD0", VA = "0x1887FCBD0")]
		private bool NIXFPDOKNZF(Func<QYWXHNAXVVA, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3952D80", Offset = "0x3951F80", VA = "0x183952D80")]
		private bool COHEXWHCJMM<a>(a a, Func<QYWXHNAXVVA, a> b, [Out] OnlineRestrictionsSources c) where a : Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x39530E0", Offset = "0x39522E0", VA = "0x1839530E0")]
		private bool HJPOZERFKPJ<b>(b a, Func<QYWXHNAXVVA, b> b, Func<b, int> c, [Out] OnlineRestrictionsSources d) where b : struct, Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x87FD8D0", Offset = "0x87FCAD0", VA = "0x1887FD8D0", Slot = "4")]
		public bool RWCFYUFIBRD([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x87FB9C0", Offset = "0x87FABC0", VA = "0x1887FB9C0", Slot = "5")]
		public bool AQFVJSLQNQA([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x87FC9A0", Offset = "0x87FBBA0", VA = "0x1887FC9A0", Slot = "6")]
		public bool LIOHBWKKXYW([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x87FC070", Offset = "0x87FB270", VA = "0x1887FC070", Slot = "7")]
		public bool GOHYWFLEULM([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x87FD7C0", Offset = "0x87FC9C0", VA = "0x1887FD7C0", Slot = "8")]
		public bool RQNZAHTCMEE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x87FCD60", Offset = "0x87FBF60", VA = "0x1887FCD60", Slot = "9")]
		public bool OPRQDKIJHEF(PlayerRelationships a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x87FD1E0", Offset = "0x87FC3E0", VA = "0x1887FD1E0", Slot = "10")]
		public bool PUAEGGDGEVE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x87FBF60", Offset = "0x87FB160", VA = "0x1887FBF60", Slot = "11")]
		public bool GHLAAIGXFHN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x87FE0B0", Offset = "0x87FD2B0", VA = "0x1887FE0B0", Slot = "12")]
		public bool VMTPZRPBYHU([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x87FCF40", Offset = "0x87FC140", VA = "0x1887FCF40", Slot = "13")]
		public bool OUPJWFGFNLV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x87FBBF0", Offset = "0x87FADF0", VA = "0x1887FBBF0", Slot = "14")]
		public bool DMAEIMBJRBD([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x87FDB00", Offset = "0x87FCD00", VA = "0x1887FDB00", Slot = "15")]
		public bool STVMTQOWFZO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x87FBE40", Offset = "0x87FB040", VA = "0x1887FBE40", Slot = "16")]
		public bool FNHWYQRNMWW([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x87FDF90", Offset = "0x87FD190", VA = "0x1887FDF90", Slot = "17")]
		public bool UPSEEDUWKAL([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x87FDE70", Offset = "0x87FD070", VA = "0x1887FDE70", Slot = "18")]
		public bool UMBULGZRMVM([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x87FD6A0", Offset = "0x87FC8A0", VA = "0x1887FD6A0", Slot = "19")]
		public bool QMWQSDGISRQ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x87FC180", Offset = "0x87FB380", VA = "0x1887FC180", Slot = "20")]
		public bool GXWWQLQBARZ(CreationRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x87FBD00", Offset = "0x87FAF00", VA = "0x1887FBD00", Slot = "21")]
		public bool ETSYRWSHYGC(DrawingRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x87FB780", Offset = "0x87FA980", VA = "0x1887FB780", Slot = "22")]
		public bool ACMUCEPKJBD([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x87FDC10", Offset = "0x87FCE10", VA = "0x1887FDC10", Slot = "23")]
		public bool UIVOUNLDUSF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x87FC620", Offset = "0x87FB820", VA = "0x1887FC620", Slot = "24")]
		public bool KQRLTOKZTRW([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x87FBAD0", Offset = "0x87FACD0", VA = "0x1887FBAD0", Slot = "25")]
		public bool CGBAWUHDMQQ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x87FC2C0", Offset = "0x87FB4C0", VA = "0x1887FC2C0", Slot = "26")]
		public bool HTAMAETNGUV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x87FCAB0", Offset = "0x87FBCB0", VA = "0x1887FCAB0", Slot = "27")]
		public bool MBPBLBGYXMZ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x87FC860", Offset = "0x87FBA60", VA = "0x1887FC860", Slot = "28")]
		public bool KZNUKXEFQQQ(SharecamVisibleObjects a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x87FE2E0", Offset = "0x87FD4E0", VA = "0x1887FE2E0", Slot = "29")]
		public bool XASZDJGZNVG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x87FE1C0", Offset = "0x87FD3C0", VA = "0x1887FE1C0", Slot = "30")]
		public bool VQLYWTPKFNJ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x87FB8A0", Offset = "0x87FAAA0", VA = "0x1887FB8A0", Slot = "31")]
		public bool ADVUXVFPDZZ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x87FC500", Offset = "0x87FB700", VA = "0x1887FC500", Slot = "32")]
		public bool JRVKIHQEQYQ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x87FDD30", Offset = "0x87FCF30", VA = "0x1887FDD30", Slot = "33")]
		public bool UKHEQVQEFIO(UGCPublishedClubAnnouncements a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x87FD580", Offset = "0x87FC780", VA = "0x1887FD580", Slot = "34")]
		public bool PVRCJHCUNFV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x87FC3E0", Offset = "0x87FB5E0", VA = "0x1887FC3E0", Slot = "35")]
		public bool JGKUYILDZAL([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x87FD9E0", Offset = "0x87FCBE0", VA = "0x1887FD9E0", Slot = "36")]
		public bool SGTGNEYTECA([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x87FC740", Offset = "0x87FB940", VA = "0x1887FC740", Slot = "37")]
		public bool KRWORTUTCJR([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x87FB660", Offset = "0x87FA860", VA = "0x1887FB660", Slot = "38")]
		public bool AACWTEGEVLY([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x87FE4F0", Offset = "0x87FD6F0", VA = "0x1887FE4F0", Slot = "39")]
		public string ZEJVGZACFVE(OnlineRestrictionsSources a)
		{
			return null;
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
