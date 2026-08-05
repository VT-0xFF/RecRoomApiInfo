using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Collections;
using RecRoom.Foundation.Service;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_ConfigUI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8BCD540", Offset = "0x8BCC140", VA = "0x188BCD540", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_ConfigUI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] XIOCEUOZJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset MVEDDDGEAHK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3300", Offset = "0x8BD1F00", VA = "0x188BD3300", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8BD30E0", Offset = "0x8BD1CE0", VA = "0x188BD30E0")]
		private void SGYKGOYOYBS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8BD2970", Offset = "0x8BD1570", VA = "0x188BD2970", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8BD29D0", Offset = "0x8BD15D0", VA = "0x188BD29D0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3320", Offset = "0x8BD1F20", VA = "0x188BD3320")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	internal abstract class HEDAYOCBAWA : UXQUGLYUUMG<Enum>, BMLCSNJMCVD, JBAOKNSEEUA, GMOCCNWDLSY
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool SXADSJKGIFM(Type a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8BCCF60", Offset = "0x8BCBB60", VA = "0x188BCCF60")]
		protected HEDAYOCBAWA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	internal abstract class UXQUGLYUUMG<a> : JBAOKNSEEUA, GMOCCNWDLSY where a : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class GWGISWCHLZW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public HYHFVMAQRYT GEJGKTKHVSY;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GWGISWCHLZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x541C1E0", Offset = "0x541ADE0", VA = "0x18541C1E0")]
			internal bool IRUYYTGJONJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x58D3B30", Offset = "0x58D2730", VA = "0x1858D3B30")]
		protected UXQUGLYUUMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6833700", Offset = "0x6832300", VA = "0x186833700")]
		protected void FYZYPKTNRXD(LOHZLRSHLLK a, HYHFVMAQRYT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6833AE0", Offset = "0x68326E0", VA = "0x186833AE0")]
		protected void ILENKZTCCVB(JCYHEBWRITZ<a> a, HYHFVMAQRYT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void MNQSSDEKTDJ(HYHFVMAQRYT a, UHRCGGNMWFD b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal abstract class FMBTPVPTPFF : TBFEWCFQEFH, GMOCCNWDLSY
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public abstract NetworkProperty[] AVCLNYJKGRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract NetworkProperty[] SOYXBOHMOQJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void MNQSSDEKTDJ(HYHFVMAQRYT a, GUQXBFTWZNO b, BUAFEIXMQXY c, UHRCGGNMWFD d);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3BA0F40", Offset = "0x3B9FB40", VA = "0x183BA0F40")]
		protected static b OFLDTKVPCWX<b>(NativeObjectLocalIdArray a, NetworkProperty<b> b) where b : struct
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3BA0D50", Offset = "0x3B9F950", VA = "0x183BA0D50")]
		protected static void NDHGSGDVZZA<d>(NativeObjectLocalIdArray a, NetworkProperty<d> b, d c) where d : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected FMBTPVPTPFF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class KTECAXMNNST<a> : JBAOKNSEEUA, GMOCCNWDLSY where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class GWGISWCHLZW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public HYHFVMAQRYT GEJGKTKHVSY;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GWGISWCHLZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x541C410", Offset = "0x541B010", VA = "0x18541C410")]
			internal bool IRUYYTGJONJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x58D3B30", Offset = "0x58D2730", VA = "0x1858D3B30")]
		protected KTECAXMNNST()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x58D23D0", Offset = "0x58D0FD0", VA = "0x1858D23D0")]
		protected void FYZYPKTNRXD(LOHZLRSHLLK a, HYHFVMAQRYT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x58D35A0", Offset = "0x58D21A0", VA = "0x1858D35A0")]
		protected void ILENKZTCCVB(JCYHEBWRITZ<a> a, HYHFVMAQRYT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void MNQSSDEKTDJ(HYHFVMAQRYT a, UHRCGGNMWFD b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[RegisterService(typeof(GUQXBFTWZNO), new string[] { })]
	internal class ConfigUIService : GUQXBFTWZNO, YGTTGTSBWNM, BMZVOVVGZNC, GAEEWOIWDJG, OBETOEUHEYQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[DependsOn]
		private BUAFEIXMQXY FBTAZDONUSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[DependsOn]
		private UHRCGGNMWFD UUOIBPKGHIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private PropertyDrawerCandidates ZZEQTDWZBVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeObjectLocalIdArray VLRPPDQOVVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private List<HYHFVMAQRYT> IGJVIRVLORM;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NativeObjectLocalIdArray VBCNAZABJAF
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x17CA130", Offset = "0x17C8D30", VA = "0x1817CA130", Slot = "5")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB120", Offset = "0x8BC9D20", VA = "0x188BCB120", Slot = "6")]
		public void InitExternal(BVNDYEZSFBO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB770", Offset = "0x8BCA370", VA = "0x188BCB770", Slot = "7")]
		public void ShutdownInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8BCABD0", Offset = "0x8BC97D0", VA = "0x188BCABD0", Slot = "4")]
		public void AJPFPKZGXVX(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB0B0", Offset = "0x8BC9CB0", VA = "0x188BCB0B0")]
		private void HRYGYLMMCAX(NativeObjectLocalIdArray a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB870", Offset = "0x8BCA470", VA = "0x188BCB870")]
		private void VNEZSQJMPVO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB440", Offset = "0x8BCA040", VA = "0x188BCB440")]
		private void MNQSSDEKTDJ(Candidate a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB040", Offset = "0x8BC9C40", VA = "0x188BCB040", Slot = "8")]
		private void HGJHKCHSQDI(BVNDYEZSFBO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x10EF1C0", Offset = "0x10EDDC0", VA = "0x1810EF1C0", Slot = "9")]
		private void PBSAMQJMUVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBAF0", Offset = "0x8BCA6F0", VA = "0x188BCBAF0")]
		public ConfigUIService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[MatchPropertyDrawer(0)]
	internal class JXDWTHKZZDW : HEDAYOCBAWA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8BCCFA0", Offset = "0x8BCBBA0", VA = "0x188BCCFA0", Slot = "5")]
		public override void MNQSSDEKTDJ(HYHFVMAQRYT a, UHRCGGNMWFD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8BCD050", Offset = "0x8BCBC50", VA = "0x188BCD050", Slot = "7")]
		public override bool SXADSJKGIFM(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8BCCF60", Offset = "0x8BCBB60", VA = "0x188BCCF60")]
		public JXDWTHKZZDW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[MatchPropertyDrawer(0)]
	internal class LVKNTUOZMRH : HEDAYOCBAWA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8BCD3F0", Offset = "0x8BCBFF0", VA = "0x188BCD3F0", Slot = "5")]
		public override void MNQSSDEKTDJ(HYHFVMAQRYT a, UHRCGGNMWFD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8BCD4A0", Offset = "0x8BCC0A0", VA = "0x188BCD4A0", Slot = "7")]
		public override bool SXADSJKGIFM(Type a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8BCCF60", Offset = "0x8BCBB60", VA = "0x188BCCF60")]
		public LVKNTUOZMRH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[ConfigPropertyDrawer(typeof(RenderableColor), 1)]
	internal class WQQKLBRUPAQ : UXQUGLYUUMG<RenderableColor>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD27E0", Offset = "0x8BD13E0", VA = "0x188BD27E0", Slot = "5")]
		public override void MNQSSDEKTDJ(HYHFVMAQRYT a, UHRCGGNMWFD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD2930", Offset = "0x8BD1530", VA = "0x188BD2930")]
		public WQQKLBRUPAQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[MultiPropertyDrawer(2)]
	internal class PFZRDOPMJVK : FMBTPVPTPFF
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public GUQXBFTWZNO JOQNLYHFWSY;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8BCA0F0", Offset = "0x8BC8CF0", VA = "0x188BCA0F0")]
			internal (int, int) VVMYUEOSWDT()
			{
				return default((int, int));
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8BC9FA0", Offset = "0x8BC8BA0", VA = "0x188BC9FA0")]
			internal void VVHRWXUVMSK((int color, int material) value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override NetworkProperty[] AVCLNYJKGRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override NetworkProperty[] SOYXBOHMOQJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8BCD640", Offset = "0x8BCC240", VA = "0x188BCD640", Slot = "9")]
		public override void MNQSSDEKTDJ(HYHFVMAQRYT a, GUQXBFTWZNO b, BUAFEIXMQXY c, UHRCGGNMWFD d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8BCD9F0", Offset = "0x8BCC5F0", VA = "0x188BCD9F0")]
		public PFZRDOPMJVK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ConfigPropertyDrawer(typeof(bool))]
	internal class SIXDGEKLFQZ : KTECAXMNNST<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0ED0", Offset = "0x8BCFAD0", VA = "0x188BD0ED0", Slot = "5")]
		public override void MNQSSDEKTDJ(HYHFVMAQRYT a, UHRCGGNMWFD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0F60", Offset = "0x8BCFB60", VA = "0x188BD0F60")]
		public SIXDGEKLFQZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ConfigPropertyDrawer(typeof(FixedString32Bytes))]
	internal class DDQBTEBGXNP : KTECAXMNNST<FixedString32Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class UVCWZJPGRUD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public HYHFVMAQRYT GEJGKTKHVSY;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UVCWZJPGRUD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8BD25E0", Offset = "0x8BD11E0", VA = "0x188BD25E0")]
			internal string VVMYUEOSWDT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8BD23C0", Offset = "0x8BD0FC0", VA = "0x188BD23C0")]
			internal void VVHRWXUVMSK(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBB70", Offset = "0x8BCA770", VA = "0x188BCBB70", Slot = "5")]
		public override void MNQSSDEKTDJ(HYHFVMAQRYT a, UHRCGGNMWFD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBD00", Offset = "0x8BCA900", VA = "0x188BCBD00")]
		public DDQBTEBGXNP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ConfigPropertyDrawer(typeof(FixedString64Bytes))]
	internal class FHZCISNYWJI : KTECAXMNNST<FixedString64Bytes>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class UVCWZJPGRUD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public HYHFVMAQRYT GEJGKTKHVSY;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UVCWZJPGRUD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8BD2640", Offset = "0x8BD1240", VA = "0x188BD2640")]
			internal string VVMYUEOSWDT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8BD2430", Offset = "0x8BD1030", VA = "0x188BD2430")]
			internal void VVHRWXUVMSK(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC250", Offset = "0x8BCAE50", VA = "0x188BCC250", Slot = "5")]
		public override void MNQSSDEKTDJ(HYHFVMAQRYT a, UHRCGGNMWFD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC3E0", Offset = "0x8BCAFE0", VA = "0x188BCC3E0")]
		public FHZCISNYWJI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ConfigPropertyDrawer(typeof(float3))]
	internal class CQXDSJNGKLQ : KTECAXMNNST<float3>
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class UVCWZJPGRUD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public HYHFVMAQRYT GEJGKTKHVSY;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UVCWZJPGRUD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8BD2530", Offset = "0x8BD1130", VA = "0x188BD2530")]
			internal float VVMYUEOSWDT()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8BD24C0", Offset = "0x8BD10C0", VA = "0x188BD24C0")]
			internal void VVHRWXUVMSK(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8BD2340", Offset = "0x8BD0F40", VA = "0x188BD2340")]
			internal float VVCKZRAYDHB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8BD2330", Offset = "0x8BD0F30", VA = "0x188BD2330")]
			internal void VUXECKHATVS(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8BD26F0", Offset = "0x8BD12F0", VA = "0x188BD26F0")]
			internal float VWIAJFQIHXD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8BD26E0", Offset = "0x8BD12E0", VA = "0x188BD26E0")]
			internal void VWCTLYWKYLU(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8BD2770", Offset = "0x8BD1370", VA = "0x188BD2770")]
			internal float YMEXVFDDASS(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8BD2240", Offset = "0x8BD0E40", VA = "0x188BD2240")]
			internal void UTPPBZPVUYV(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA360", Offset = "0x8BC8F60", VA = "0x188BCA360", Slot = "5")]
		public override void MNQSSDEKTDJ(HYHFVMAQRYT a, UHRCGGNMWFD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA760", Offset = "0x8BC9360", VA = "0x188BCA760")]
		public CQXDSJNGKLQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ConfigPropertyDrawer(typeof(float))]
	internal class KPJDGSMWHNP : KTECAXMNNST<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8BCD0F0", Offset = "0x8BCBCF0", VA = "0x188BCD0F0", Slot = "5")]
		public override void MNQSSDEKTDJ(HYHFVMAQRYT a, UHRCGGNMWFD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8BCD180", Offset = "0x8BCBD80", VA = "0x188BCD180")]
		public KPJDGSMWHNP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ConfigPropertyDrawer(typeof(int))]
	internal class EKFDQFARIES : KTECAXMNNST<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBD40", Offset = "0x8BCA940", VA = "0x188BCBD40", Slot = "5")]
		public override void MNQSSDEKTDJ(HYHFVMAQRYT a, UHRCGGNMWFD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBDD0", Offset = "0x8BCA9D0", VA = "0x188BCBDD0")]
		public EKFDQFARIES()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[ConfigPropertyDrawer(typeof(quaternion))]
	internal class FFMYQXDHHGV : KTECAXMNNST<quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class UVCWZJPGRUD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public HYHFVMAQRYT GEJGKTKHVSY;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UVCWZJPGRUD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8BD26C0", Offset = "0x8BD12C0", VA = "0x188BD26C0")]
			internal float VVMYUEOSWDT()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8BD2520", Offset = "0x8BD1120", VA = "0x188BD2520")]
			internal void VVHRWXUVMSK(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8BD23B0", Offset = "0x8BD0FB0", VA = "0x188BD23B0")]
			internal float VVCKZRAYDHB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8BD2320", Offset = "0x8BD0F20", VA = "0x188BD2320")]
			internal void VUXECKHATVS(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8BD2760", Offset = "0x8BD1360", VA = "0x188BD2760")]
			internal float VWIAJFQIHXD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8BD26D0", Offset = "0x8BD12D0", VA = "0x188BD26D0")]
			internal void VWCTLYWKYLU(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8BD1E80", Offset = "0x8BD0A80", VA = "0x188BD1E80")]
			internal float CQUDQQOGCRZ(int a)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8BD1FE0", Offset = "0x8BD0BE0", VA = "0x188BD1FE0")]
			internal void IEZICTIQFEA(int a, float b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8BCBE10", Offset = "0x8BCAA10", VA = "0x188BCBE10", Slot = "5")]
		public override void MNQSSDEKTDJ(HYHFVMAQRYT a, UHRCGGNMWFD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC210", Offset = "0x8BCAE10", VA = "0x188BCC210")]
		public FFMYQXDHHGV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ConfigPropertyDrawer(typeof(uint))]
	internal class UPKRBABGSPL : KTECAXMNNST<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class UVCWZJPGRUD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public HYHFVMAQRYT GEJGKTKHVSY;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public UVCWZJPGRUD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8BD25A0", Offset = "0x8BD11A0", VA = "0x188BD25A0")]
			internal int VVMYUEOSWDT()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8BD24D0", Offset = "0x8BD10D0", VA = "0x188BD24D0")]
			internal void VVHRWXUVMSK(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1CB0", Offset = "0x8BD08B0", VA = "0x188BD1CB0", Slot = "5")]
		public override void MNQSSDEKTDJ(HYHFVMAQRYT a, UHRCGGNMWFD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1E40", Offset = "0x8BD0A40", VA = "0x188BD1E40")]
		public UPKRBABGSPL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	internal struct Candidate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int drawerIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public NetworkProperty property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public int priority;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class CVQVUCPDWPU
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA7A0", Offset = "0x8BC93A0", VA = "0x188BCA7A0")]
		public static void HZSYKLGVUNY(Type a, Type b)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal struct CommonProperties
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA950", Offset = "0x8BC9550", VA = "0x188BCA950")]
		public static NativeList<NetworkProperty> KKZDCTRSRSJ(NativeObjectLocalIdArray a, BUAFEIXMQXY b)
		{
			return default(NativeList<NetworkProperty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA860", Offset = "0x8BC9460", VA = "0x188BCA860")]
		private static bool GDENDDIKSTK(NetworkProperty a, NativeObjectLocalIdArray b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class UIGNNSHWAYW : HYHFVMAQRYT, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly NetworkProperty GEJGKTKHVSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly BUAFEIXMQXY RJBFJQKSZEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NativeObjectLocalIdArray VLRPPDQOVVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool JDQGFFMCCEG;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8BD17B0", Offset = "0x8BD03B0", VA = "0x188BD17B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DBKUPEYWNFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8BD1810", Offset = "0x8BD0410", VA = "0x188BD1810", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RRObject SPBUUTQFXWO
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8BD16C0", Offset = "0x8BD02C0", VA = "0x188BD16C0", Slot = "8")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Type JGVJNZJVVLT
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8BD1AD0", Offset = "0x8BD06D0", VA = "0x188BD1AD0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action AVHYZZKNVQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8BD1B20", Offset = "0x8BD0720", VA = "0x188BD1B20", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8BD1710", Offset = "0x8BD0310", VA = "0x188BD1710", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1BC0", Offset = "0x8BD07C0", VA = "0x188BD1BC0")]
		public UIGNNSHWAYW(NativeObjectLocalIdArray a, NetworkProperty b, BUAFEIXMQXY c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8BD19C0", Offset = "0x8BD05C0", VA = "0x188BD19C0")]
		private void UACDRGUFSNS(BulkPropertyChangeData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8BD15E0", Offset = "0x8BD01E0", VA = "0x188BD15E0", Slot = "10")]
		public void Get(MutableRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD18A0", Offset = "0x8BD04A0", VA = "0x188BD18A0", Slot = "11")]
		public void Set(ReadOnlyRef value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1510", Offset = "0x8BD0110", VA = "0x188BD1510", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[SpecificPropertyDrawer(1)]
	internal sealed class PSSOSFQLTPB : NKSELHFAGYA, JBAOKNSEEUA, GMOCCNWDLSY
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public HYHFVMAQRYT GEJGKTKHVSY;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8BCD3A0", Offset = "0x8BCBFA0", VA = "0x188BCD3A0")]
			internal bool VVMYUEOSWDT()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8BCD320", Offset = "0x8BCBF20", VA = "0x188BCD320")]
			internal string VVHRWXUVMSK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8BCD290", Offset = "0x8BCBE90", VA = "0x188BCD290")]
			internal void VVCKZRAYDHB(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8BCD1C0", Offset = "0x8BCBDC0", VA = "0x188BCD1C0")]
			internal string VUXECKHATVS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public NetworkProperty NGRPTMWFSVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8BCDB20", Offset = "0x8BCC720", VA = "0x188BCDB20", Slot = "4")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8BCDB90", Offset = "0x8BCC790", VA = "0x188BCDB90", Slot = "5")]
		public void MNQSSDEKTDJ(HYHFVMAQRYT a, UHRCGGNMWFD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public PSSOSFQLTPB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal class GHNEBMGVGQT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly BUAFEIXMQXY FBTAZDONUSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly UHRCGGNMWFD CQDBUXGDREH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Action<Candidate> TLCMPBHCXOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HashSet<HORATOXZIID> VANFWWLVQRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<HORATOXZIID, List<Candidate>> HXCWRYQRTJV;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8BCCE50", Offset = "0x8BCBA50", VA = "0x188BCCE50")]
		public GHNEBMGVGQT(BUAFEIXMQXY a, UHRCGGNMWFD b, Action<Candidate> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC940", Offset = "0x8BCB540", VA = "0x188BCC940")]
		public void IQOGFUXITIZ(NativeList<Candidate> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8BCCC80", Offset = "0x8BCB880", VA = "0x188BCCC80")]
		private void JUUCZORQGCX(HORATOXZIID a, Candidate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8BCCDF0", Offset = "0x8BCB9F0", VA = "0x188BCCDF0")]
		public void UVTWHWKLBVZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC4C0", Offset = "0x8BCB0C0", VA = "0x188BCC4C0")]
		private void HHZCUEDVVSP(HORATOXZIID a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8BCC420", Offset = "0x8BCB020", VA = "0x188BCC420")]
		private void EZHJHNUEKSS(HORATOXZIID a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class AZAQZVCYDIO : IEnumerable<NetworkProperty>, IEnumerable, IEnumerator<NetworkProperty>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private NetworkProperty DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int RPOQDRFWNXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PropertiesByType VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private Type XWCGKVRHPNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Type QHVWIBAAQLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private NativeParallelMultiHashMap<long, int>.Enumerator OKMXNYRHUZP;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private NetworkProperty TZPOFICMKSV
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0xB69740", Offset = "0xB68340", VA = "0x180B69740", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(NetworkProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x8BC9AA0", Offset = "0x8BC86A0", VA = "0x188BC9AA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x1659E00", Offset = "0x1658A00", VA = "0x181659E00")]
			[DebuggerHidden]
			public AZAQZVCYDIO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8BC9F10", Offset = "0x8BC8B10", VA = "0x188BC9F10", Slot = "7")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8BC9AF0", Offset = "0x8BC86F0", VA = "0x188BC9AF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8BC9DD0", Offset = "0x8BC89D0", VA = "0x188BC9DD0")]
			private void QCWGZBRZQOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8BC9E20", Offset = "0x8BC8A20", VA = "0x188BC9E20", Slot = "10")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8BC9E60", Offset = "0x8BC8A60", VA = "0x188BC9E60", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NetworkProperty> XXDDETQUINM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8BC9E60", Offset = "0x8BC8A60", VA = "0x188BC9E60", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator ZFHLTDQPCLO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NativeParallelMultiHashMap<long, int> TTNRBWEEGUB;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE420", Offset = "0x8BCD020", VA = "0x188BCE420")]
		public PropertiesByType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE300", Offset = "0x8BCCF00", VA = "0x188BCE300")]
		[IteratorStateMachine(typeof(AZAQZVCYDIO))]
		public IEnumerable<NetworkProperty> WIHMIXBUBRZ(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8BCDFC0", Offset = "0x8BCCBC0", VA = "0x188BCDFC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE040", Offset = "0x8BCCC40", VA = "0x188BCE040")]
		private long GGQVHARYDTU(NetworkProperty a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE000", Offset = "0x8BCCC00", VA = "0x188BCE000")]
		private long GGQVHARYDTU(Type a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE0C0", Offset = "0x8BCCCC0", VA = "0x188BCE0C0")]
		[CompilerGenerated]
		private object JWEJJXGZZOA(NetworkProperty a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal struct PropertyBitmap : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private NativeBitArray bitmap;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8BCEA10", Offset = "0x8BCD610", VA = "0x188BCEA10")]
		public PropertyBitmap(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE870", Offset = "0x8BCD470", VA = "0x188BCE870")]
		public static PropertyBitmap PGVNMRUBSHX(int a, NativeArray<NetworkProperty> b)
		{
			return default(PropertyBitmap);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE860", Offset = "0x8BCD460", VA = "0x188BCE860")]
		public bool ISEUZOZZVYH(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8BCEA00", Offset = "0x8BCD600", VA = "0x188BCEA00")]
		public void Set(int index, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE6F0", Offset = "0x8BCD2F0", VA = "0x188BCE6F0")]
		public bool All(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE7A0", Offset = "0x8BCD3A0", VA = "0x188BCE7A0")]
		public bool Any(NetworkProperty[] properties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8BCE850", Offset = "0x8BCD450", VA = "0x188BCE850", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal class PropertyDrawerCandidates
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly BUAFEIXMQXY FBTAZDONUSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly List<GMOCCNWDLSY> MVRNQQJDBPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly PropertiesByType TTNRBWEEGUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NativeParallelMultiHashMap<int, int> LFQNKYWVHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private NativeList<int> JCLWNWRDLQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool JDQGFFMCCEG;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public List<GMOCCNWDLSY> ZSHLKNNRHDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0760", Offset = "0x8BCF360", VA = "0x188BD0760")]
		public PropertyDrawerCandidates(BUAFEIXMQXY configPropertyService)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8BCF430", Offset = "0x8BCE030", VA = "0x188BCF430")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0120", Offset = "0x8BCED20", VA = "0x188BD0120")]
		public void PEXOYABZUXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8BCF510", Offset = "0x8BCE110", VA = "0x188BCF510")]
		public NativeList<Candidate> KNJVATGYORP(NativeArray<NetworkProperty> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0580", Offset = "0x8BCF180", VA = "0x188BD0580")]
		private bool ZIYCLALHUVB(GMOCCNWDLSY a, PropertyBitmap b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3EDDDD0", Offset = "0x3EDC9D0", VA = "0x183EDDDD0")]
		private void PBUHYTVZFFY<b, a>(Action<b, a> a) where b : GMOCCNWDLSY where a : Attribute
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8BCFEA0", Offset = "0x8BCEAA0", VA = "0x188BCFEA0")]
		private void KRHJXRCQBDS(Type a, Type b, Type c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE210", Offset = "0x3EDCE10", VA = "0x183EDE210")]
		private c XRJMCCHWLXD<c>(Type a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8BCF340", Offset = "0x8BCDF40", VA = "0x188BCF340")]
		private int DVYQFIXJLNK(GMOCCNWDLSY a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8BCEF30", Offset = "0x8BCDB30", VA = "0x188BCEF30")]
		private void DCORNQNUQLW(JBAOKNSEEUA a, ConfigPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8BCEA60", Offset = "0x8BCD660", VA = "0x188BCEA60")]
		private void CNKIHOCJTYN(BMLCSNJMCVD a, MatchPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BD02C0", Offset = "0x8BCEEC0", VA = "0x188BD02C0")]
		private void POVUKKJRBDT(TBFEWCFQEFH a, MultiPropertyDrawer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8BCFED0", Offset = "0x8BCEAD0", VA = "0x188BCFED0")]
		private void OOJTYHMQSIM(NKSELHFAGYA a, SpecificPropertyDrawer b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal struct PropertyShadowing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly List<GMOCCNWDLSY> drawers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeList<Candidate> unshadowed;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NativeList<Candidate> FHQNJXDCZXZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xBCBE50", Offset = "0xBCAA50", VA = "0x180BCBE50")]
			get
			{
				return default(NativeList<Candidate>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0E80", Offset = "0x8BCFA80", VA = "0x188BD0E80")]
		public PropertyShadowing(List<GMOCCNWDLSY> drawers, NativeArray<Candidate> candidates)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8BD08A0", Offset = "0x8BCF4A0", VA = "0x188BD08A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0B80", Offset = "0x8BCF780", VA = "0x188BD0B80")]
		private NativeList<Candidate> YHFNUBJZDOT(NativeArray<Candidate> a)
		{
			return default(NativeList<Candidate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8BD08E0", Offset = "0x8BCF4E0", VA = "0x188BD08E0")]
		private bool NFFXSTJKKZG(GMOCCNWDLSY a, PropertyBitmap b, NetworkProperty c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0A50", Offset = "0x8BCF650", VA = "0x188BD0A50")]
		private void PREGNFHGVXR(GMOCCNWDLSY a, PropertyBitmap b, NetworkProperty c)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal struct SortCandidatesByPriority : IComparer<Candidate>
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0FA0", Offset = "0x8BCFBA0", VA = "0x188BD0FA0", Slot = "4")]
		public int Compare(Candidate a, Candidate b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0FB0", Offset = "0x8BCFBB0", VA = "0x188BD0FB0")]
		public static void Sort(NativeList<Candidate> candidates)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[AttributeUsage(AttributeTargets.Class)]
	public class SpecificPropertyDrawer : ConfigPropertyDrawerBase
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8BD0FF0", Offset = "0x8BCFBF0", VA = "0x188BD0FF0")]
		public SpecificPropertyDrawer(int Priority = 1)
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
