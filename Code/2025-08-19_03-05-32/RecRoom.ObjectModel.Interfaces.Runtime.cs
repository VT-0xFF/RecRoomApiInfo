using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Components;
using RecRoom.DataLayer;
using RecRoom.Foundation;
using RecRoom.Foundation.Attributes;
using RecRoom.Foundation.Collections;
using RecRoom.Foundation.Mathematics;
using RecRoom.Foundation.Service;
using RecRoom.Foundation.Transforms;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel.Interop;
using RecRoom.ObjectModel.Serialization;
using RecRoom.ObjectModel.Systems;
using RecRoom.ObjectModel.Transmission;
using RecRoom.RendererV1;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class MUPXUODILAN
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
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

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
	public MUPXUODILAN()
	{
	}
}
namespace _LogRegistration.RecRoom_ObjectModel_Interfaces_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8752B20", Offset = "0x8751920", VA = "0x188752B20", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class HBBTXSTEEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87519B0", Offset = "0x87507B0", VA = "0x1887519B0")]
		public static void WSZMXWPSJBN(this Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8751B30", Offset = "0x8750930", VA = "0x188751B30")]
		public static void WSZMXWPSJBN(this Rigidbody a, Vector3 b, Quaternion c, Vector3 d)
		{
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct NativeObjectLocalIdArray : IReadOnlyList<ObjectLocalId>, IEnumerable<ObjectLocalId>, IEnumerable, IReadOnlyCollection<ObjectLocalId>, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public struct Enumerator : IEnumerator<ObjectLocalId>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly IFXBBMDUCGM objects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private NativeArray<LocalId>.Enumerator enumerator;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public ObjectLocalId Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x8750DD0", Offset = "0x874FBD0", VA = "0x188750DD0", Slot = "4")]
				get
				{
					return default(ObjectLocalId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x8750C60", Offset = "0x874FA60", VA = "0x188750C60", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5306360", Offset = "0x5305160", VA = "0x185306360")]
			public Enumerator(IFXBBMDUCGM objects, NativeArray<LocalId>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8750A40", Offset = "0x874F840", VA = "0x188750A40", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8750B50", Offset = "0x874F950", VA = "0x188750B50", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8750C20", Offset = "0x874FA20", VA = "0x188750C20", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly ObjectServiceHandle handle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private NativeArray<LocalId> localIds;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public ObjectLocalId this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8753940", Offset = "0x8752740", VA = "0x188753940", Slot = "4")]
			get
			{
				return default(ObjectLocalId);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x87539C0", Offset = "0x87527C0", VA = "0x1887539C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private int MZHGZGYRQTQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IFXBBMDUCGM QMAFFUGLXDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8753560", Offset = "0x8752360", VA = "0x188753560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int UFYFSTWLMQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool DGRJVBSKFAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8753410", Offset = "0x8752210", VA = "0x188753410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public NativeArray<LocalId> BQBTCVPYJGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2CE9DA0", Offset = "0x2CE8BA0", VA = "0x182CE9DA0")]
			get
			{
				return default(NativeArray<LocalId>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		internal NativeArray<Entity> XPFQJQYTQPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x87531C0", Offset = "0x8751FC0", VA = "0x1887531C0")]
			get
			{
				return default(NativeArray<Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8753890", Offset = "0x8752690", VA = "0x188753890")]
		public NativeObjectLocalIdArray(int capacity, IFXBBMDUCGM objects, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8753780", Offset = "0x8752580", VA = "0x188753780")]
		public NativeObjectLocalIdArray(ObjectServiceHandle handle, NativeArray<LocalId> localIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8753710", Offset = "0x8752510", VA = "0x188753710")]
		public NativeObjectLocalIdArray(ObjectServiceHandle handle, NativeArray<Entity> localIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8753800", Offset = "0x8752600", VA = "0x188753800")]
		internal NativeObjectLocalIdArray(IFXBBMDUCGM objects, NativeArray<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8753790", Offset = "0x8752590", VA = "0x188753790")]
		internal NativeObjectLocalIdArray(IFXBBMDUCGM objects, NativeArray<LocalId> localIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8753660", Offset = "0x8752460", VA = "0x188753660")]
		public NativeObjectLocalIdArray(IFXBBMDUCGM objects, int length, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x87535B0", Offset = "0x87523B0", VA = "0x1887535B0")]
		public NativeObjectLocalIdArray(NativeObjectLocalIdArray existing, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8752E30", Offset = "0x8751C30", VA = "0x188752E30")]
		public void CopyTo(List<ObjectLocalId> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8753220", Offset = "0x8752020", VA = "0x188753220")]
		public void IVIDKHJPVXF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8752D90", Offset = "0x8751B90", VA = "0x188752D90")]
		public NativeObjectLocalIdArray Clone(Allocator allocator)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8753270", Offset = "0x8752070", VA = "0x188753270")]
		public Span<ObjectLocalId> KYNKOUCLLML()
		{
			return default(Span<ObjectLocalId>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8753450", Offset = "0x8752250", VA = "0x188753450")]
		public NativeObjectLocalIdArray TMUSYMGHOES(int a, int b)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x87530C0", Offset = "0x8751EC0", VA = "0x1887530C0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8753100", Offset = "0x8751F00", VA = "0x188753100")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x87533A0", Offset = "0x87521A0", VA = "0x1887533A0", Slot = "6")]
		private IEnumerator<ObjectLocalId> PBTLYTHADLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x87534F0", Offset = "0x87522F0", VA = "0x1887534F0", Slot = "7")]
		private IEnumerator UYQUPSIMXFE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class WATYIROJHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3E84C40", Offset = "0x3E83A40", VA = "0x183E84C40")]
		public static RentedArray<a> EZCZVLVAUIN<a>(this NativeObjectLocalIdArray a) where a : UnityEngine.Component
		{
			return default(RentedArray<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct NativeObjectLocalIdList : IList<ObjectLocalId>, ICollection<ObjectLocalId>, IEnumerable<ObjectLocalId>, IEnumerable, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public struct Enumerator : IEnumerator<ObjectLocalId>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private readonly IFXBBMDUCGM objects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private NativeArray<LocalId>.Enumerator enumerator;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public ObjectLocalId Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x8750D00", Offset = "0x874FB00", VA = "0x188750D00", Slot = "4")]
				get
				{
					return default(ObjectLocalId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x8750CB0", Offset = "0x874FAB0", VA = "0x188750CB0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5306360", Offset = "0x5305160", VA = "0x185306360")]
			public Enumerator(IFXBBMDUCGM objects, NativeArray<LocalId>.Enumerator enumerator)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8750A80", Offset = "0x874F880", VA = "0x188750A80", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8750AC0", Offset = "0x874F8C0", VA = "0x188750AC0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8750BE0", Offset = "0x874F9E0", VA = "0x188750BE0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly IFXBBMDUCGM objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private NativeList<LocalId> localIds;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ObjectLocalId this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8754490", Offset = "0x8753290", VA = "0x188754490", Slot = "4")]
			get
			{
				return default(ObjectLocalId);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x87545A0", Offset = "0x87533A0", VA = "0x1887545A0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8753AA0", Offset = "0x87528A0", VA = "0x188753AA0", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int UFYFSTWLMQP
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8753AA0", Offset = "0x87528A0", VA = "0x188753AA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public NativeList<LocalId> BQBTCVPYJGY
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xB72150", Offset = "0xB70F50", VA = "0x180B72150")]
			get
			{
				return default(NativeList<LocalId>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8754380", Offset = "0x8753180", VA = "0x188754380")]
		public NativeObjectLocalIdList(IFXBBMDUCGM objects, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8754400", Offset = "0x8753200", VA = "0x188754400")]
		public NativeObjectLocalIdList(IFXBBMDUCGM objects, int length, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8753FB0", Offset = "0x8752DB0", VA = "0x188753FB0")]
		public NativeObjectLocalIdArray JETWRKWBATC()
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8753AF0", Offset = "0x87528F0", VA = "0x188753AF0", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8753B30", Offset = "0x8752930", VA = "0x188753B30", Slot = "13")]
		public bool Contains(ObjectLocalId item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8753BB0", Offset = "0x87529B0", VA = "0x188753BB0", Slot = "14")]
		public void CopyTo(ObjectLocalId[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8753A20", Offset = "0x8752820", VA = "0x188753A20", Slot = "11")]
		public void Add(ObjectLocalId item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8753EE0", Offset = "0x8752CE0", VA = "0x188753EE0", Slot = "7")]
		public void Insert(int index, ObjectLocalId item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x87541E0", Offset = "0x8752FE0", VA = "0x1887541E0", Slot = "15")]
		public bool Remove(ObjectLocalId item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8753E60", Offset = "0x8752C60", VA = "0x188753E60", Slot = "6")]
		public int IndexOf(ObjectLocalId item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8754190", Offset = "0x8752F90", VA = "0x188754190", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8753D90", Offset = "0x8752B90", VA = "0x188753D90", Slot = "18")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8753DD0", Offset = "0x8752BD0", VA = "0x188753DD0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x87540B0", Offset = "0x8752EB0", VA = "0x1887540B0", Slot = "16")]
		private IEnumerator<ObjectLocalId> PBTLYTHADLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x87542A0", Offset = "0x87530A0", VA = "0x1887542A0", Slot = "17")]
		private IEnumerator UYQUPSIMXFE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface XIHGBJDDEER : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ObjectLocalId XJGNOBCSEPC(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface PRESXMCJKTI : IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ServiceLifetime(Lifetime.Application)]
	public interface IHBUUCKTNVY : KCDFURDAGWW, FFSOIOWFVJN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		TOIOMFQGVOU ZVXDBYQEPHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		ObjectServiceHandle XJPEJQJRXTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ServiceLifetime(Lifetime.Application)]
	public interface FFSOIOWFVJN
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool HDBUMCCJOKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ServiceLifetime(Lifetime.Application)]
	public interface FSLCPPMJDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SWMKMGGZZCW(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface VIIRBZTOBSZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool DHKEJKWWFRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool ZVNKQZOWGIB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool VWYVDRUPAWX
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool TXSCABRXJFK
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool TBQRSOFCLBZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void EnableDisableObjectModel(bool enabled);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool PXSSLAHVGYS(ByteString a);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void BeginLoadInstanceScope();

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void EndLoadInstanceScope();

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void NLTSCNILSXZ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ServiceLifetime(Lifetime.Application)]
	public interface PPHCIOWDSWA
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		FCHQYTALOWK ZVXDBYQEPHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		UAKXIWYKHOU ZEUAMDDCFSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		YKVXTTWXELH IDKTKBMBHTC
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		IHBUUCKTNVY UYKDBPFBJXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		GHYGBMJFDMR HOUUCOKEBXX
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		VIIRBZTOBSZ XSGWYWMPNXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		QKTMHUGAQKV CILPGTWAGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		CFWSNMTSYOV QRUUOISXBMY
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		TSMXUIUWALV CGRPUKXEDOU
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		BZGADCICSKQ RJNDZUANLLI
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		VCVVUGNIYDA KUFQDFEYGTF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		MCFDKWZUEJM BSGZKNPNAHP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		IFXBBMDUCGM QMAFFUGLXDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		GDKDINTBVFQ PDCFDEBOIEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		PCMOINDZJPK JXJHKWLTJWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		CFAMWMVINFS FTPOZIQHXQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		XWZBFEEAVJJ KUDTRJPRSMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		UYDNSMPFFCO KSUJHREZDYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		LEPIMHUDGGB SPYDVQOXTQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		RGPWUWVTNVZ QZUUNMVXZRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		BJDLKVYWDKR RABGSXMDNAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		BVIRYCJVSGI LUSHMEERXLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		XETUGOKRZXN YWXVAKRHRST
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		OFREOUEUENL DQESULSSUZR
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		YJFNKXDMHIC PSUVDGMAKQH
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		GRQPXROFRUO NOBXSSBQDUC
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		AQFNVNFACOH HUQKPLTDGNY
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		EXAUPGCZURX XODRHBZUPWW
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		WWHRYNEFNJJ LRDYYITZFFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		TTHWVJUJREK ORVDVGTELFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		NBJXCKRMRKL AOALCRYCIHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		SZFQCFKOOYF CMMWUPHGKOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		FQXOTKNTBHT VUCJHXJIIRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		XCEMBZHBKBS TMIMZGBIMIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		YHANXQPWHRR IEXFJJRICHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		BDOQDYECWIE BCGERLPWQLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		KTTTBDOTNAX NSNWVQTKDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(Slot = "36")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		OEHSBPDDFUE UARBBMRQGDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(Slot = "37")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		EHQQQIWYBZP XJYSBNDJCAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(Slot = "38")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		GCTDGLBCMYO UARBQLCBIPF
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(Slot = "39")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[DebuggerTypeProxy(typeof(ZEXLRNJKHWQ))]
	[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
	public readonly struct ObjectLocalId : IComparable<ObjectLocalId>, IEquatable<ObjectLocalId>
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly ObjectLocalId Invalid;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const int ObjectHandleBits = 8;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const int ObjectHandleOffset = 24;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const int ObjectHandleMask = -16777216;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const int VersionMask = 16777215;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly LocalId localId;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public IFXBBMDUCGM QMAFFUGLXDD
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x87554F0", Offset = "0x87542F0", VA = "0x1887554F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public IHBUUCKTNVY UYKDBPFBJXP
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8755490", Offset = "0x8754290", VA = "0x188755490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public LocalId CPRZRVKKBVV
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8755310", Offset = "0x8754110", VA = "0x188755310")]
			get
			{
				return default(LocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		internal ObjectServiceHandle XJPEJQJRXTX
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8755350", Offset = "0x8754150", VA = "0x188755350")]
			get
			{
				return default(ObjectServiceHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool PEIZIDBQNKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x87551F0", Offset = "0x8753FF0", VA = "0x1887551F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private bool RWKNZQKUIJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8754D90", Offset = "0x8753B90", VA = "0x188754D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8755550", Offset = "0x8754350", VA = "0x188755550")]
		public ObjectLocalId(IFXBBMDUCGM objectSystem, LocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8755610", Offset = "0x8754410", VA = "0x188755610")]
		public ObjectLocalId(ObjectServiceHandle handle, LocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
		public RRObject LXBTFLLPKPC()
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x87556A0", Offset = "0x87544A0", VA = "0x1887556A0")]
		public static implicit operator LocalId(ObjectLocalId objId)
		{
			return default(LocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x87556E0", Offset = "0x87544E0", VA = "0x1887556E0")]
		public static implicit operator Entity(ObjectLocalId objId)
		{
			return default(Entity);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x87550A0", Offset = "0x8753EA0", VA = "0x1887550A0")]
		public static bool GFBRUTYEXQF(ObjectLocalId a, ObjectLocalId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8754DE0", Offset = "0x8753BE0", VA = "0x188754DE0")]
		public static bool CQBJVGKOTGK(ObjectLocalId a, ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8755360", Offset = "0x8754160", VA = "0x188755360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8754F00", Offset = "0x8753D00", VA = "0x188754F00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8754E00", Offset = "0x8753C00", VA = "0x188754E00", Slot = "4")]
		public int CompareTo(ObjectLocalId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "5")]
		public bool Equals(ObjectLocalId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class AVDTKPNFPCI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8750420", Offset = "0x874F220", VA = "0x188750420")]
		public static ObjectNetworkId RYRXUIOMNDS(this ObjectLocalId a)
		{
			return default(ObjectNetworkId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal sealed class ZEXLRNJKHWQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct ObjectServiceHandle : IEquatable<ObjectServiceHandle>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		internal readonly byte handle;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static byte[] handles;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static IFXBBMDUCGM defaultObjectService;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static IHBUUCKTNVY defaultObjectModel;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static IFXBBMDUCGM[] objectServices;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static IHBUUCKTNVY[] objectModels;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static Stack<byte> freeHandles;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public IHBUUCKTNVY UYKDBPFBJXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x87563F0", Offset = "0x87551F0", VA = "0x1887563F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public IFXBBMDUCGM MXNJMXJEVYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x87557D0", Offset = "0x87545D0", VA = "0x1887557D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8756560", Offset = "0x8755360", VA = "0x188756560")]
		static ObjectServiceHandle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2D38590", Offset = "0x2D37390", VA = "0x182D38590")]
		internal ObjectServiceHandle(byte value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7609620", Offset = "0x7608420", VA = "0x187609620", Slot = "4")]
		public bool Equals(ObjectServiceHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8755730", Offset = "0x8754530", VA = "0x188755730", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x10BC830", Offset = "0x10BB630", VA = "0x1810BC830", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8756150", Offset = "0x8754F50", VA = "0x188756150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x87560B0", Offset = "0x8754EB0", VA = "0x1887560B0")]
		private static IFXBBMDUCGM QMDIJNMYSOB(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8755D70", Offset = "0x8754B70", VA = "0x188755D70")]
		private static IHBUUCKTNVY OLQBRFMFOGP(byte a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8755C10", Offset = "0x8754A10", VA = "0x188755C10")]
		private static object MQDWNKIJVUP(byte a, object[] b, object c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8755720", Offset = "0x8754520", VA = "0x188755720")]
		private static int BNLTVGKJKIL(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8755C00", Offset = "0x8754A00", VA = "0x188755C00")]
		private static int JRKAMBIEOZV(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x87564E0", Offset = "0x87552E0", VA = "0x1887564E0")]
		private static (int, int) YAQRVDVYHDD(byte a)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x87564D0", Offset = "0x87552D0", VA = "0x1887564D0")]
		private static byte XQTDJIPPWEU(int a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8755E10", Offset = "0x8754C10", VA = "0x188755E10")]
		internal static ObjectServiceHandle PUOFOOQAOVA(IHBUUCKTNVY a, IFXBBMDUCGM b)
		{
			return default(ObjectServiceHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8756200", Offset = "0x8755000", VA = "0x188756200")]
		internal static void UICJQLYJDWB(ObjectServiceHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x87558B0", Offset = "0x87546B0", VA = "0x1887558B0")]
		private static void JFDBMUOXGXJ(int a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum LoadType
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		SubGraph,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		SceneMainInitial,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		SceneMainJoining,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		SceneAdditive
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface OJMGCXVPMEW
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool WQQEGKELCGY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool RITOMLHLJPX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		bool BRGZQDAQJKV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		bool ZBHZLVCLVIZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		bool LZMFKTGNGQG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface BKNGFKZHTVF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool LTCYZOJHWSY(GDWVOPVZDUV a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool LHRKSFYGVNJ(GDWVOPVZDUV a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool XRJPQHTRMVA(KWXACINWXHP a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface CBYVFBQKVAA : GDWVOPVZDUV, OJMGCXVPMEW
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		int LBPFKEGAQKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FCRIOQNIOFI(EIBHAFKQDLL a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface GDWVOPVZDUV : OJMGCXVPMEW
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public enum PhysicsMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			Environment = 0,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			Decoration = 1,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			Physical_Sticky = 2,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			Physical = 4
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool CNXOFWGVGXY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		bool FYENXZMDXFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		bool SSNUIOCMGXL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface EIBHAFKQDLL
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		bool CLSRYMVGUBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		PrimitiveShapeType SBZIHDDMMGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		QPDBBGASNAV JKCSUSDTABE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		float3 VQBBPYBXSGY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		quaternion JZOPJQMDSFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		float3 GLTCDKGXFXV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		RenderableMaterial KDKSVXRWXGW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		RenderableColor QNWAOOGPRMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		float CGEBPJJUTLY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		float3 ISFZHFQQDHR
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		float YCJEZHFHCJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		ShapeConfigFlags IFSMXXDVHYY
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface YQDFESMNSQR
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		float3 CXGUXRWHWJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		float3 NPJLVZIDVVG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		quaternion CELDCDKPAES(float3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface QPDBBGASNAV
	{
		[Cpp2IlInjected.Token(Token = "0x17000061")]
		bool KSEWULZLSFV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		bool UVZZVPJBLWA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		bool JOARVOKDODV
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		float UICZSISISIQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		int BNOEBGSTAXC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		int HAQNVDKPIDQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OJDUALWFJZH(YQDFESMNSQR a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public class MVOGMWZPRNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public MVOGMWZPRNH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[ServiceLifetime(Lifetime.Application)]
	public interface YHZPQCZJYRQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		Guid ZZGDKUVKCGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task XQCSAZNBAVQ(Guid a, Guid b, Guid c);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task OBXRISAJIKP(Guid a, Guid[] b, Guid c);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Guid YIBJSPSCDVQ(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task NXETXYRXNHS(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool JLXYKLNXOZF(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool ZRRTLSROCTR(MXDWVDSNRSJ a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void FIATIALNVVG(Guid a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void SXMFEDOAZXH(Guid a, ObjectNetworkId b);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void NFARGABAOHP(ObjectNetworkId a);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void CDKXZWFGBMN(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[ServiceLifetime(Lifetime.Application)]
	public interface HPVINTYYXZH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[ServiceLifetime(Lifetime.Application)]
	public interface MYEBKLPMHZD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "0")]
		void HGDGELCZKNI(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[ServiceLifetime(Lifetime.Application)]
	public interface UAKXIWYKHOU
	{
		[Cpp2IlInjected.Token(Token = "0x17000068")]
		MYEBKLPMHZD KWMDLLYLUZB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		DHROBKAWKUQ CAVVRTHMIDK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		LPPLBGAGQVZ MYLVKUNYCMZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		TMFDCYBQNDN KEWKZYNPSEX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		FBXOULORZSF ZANRQDIZVEL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		TEJZBLDISRC LWIOAZPPALC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		RKELXLUBIUC CDIEOXPWWDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		QJLDFKAVQJD YIXEHMHCYYY
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[ServiceLifetime(Lifetime.Application)]
	public interface DHROBKAWKUQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000070")]
		string MSONLZKGCCX
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[ServiceLifetime(Lifetime.Application)]
	public interface LKZCFVTRURB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NDTYNMOQLSJ(Action a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool VTIZTIKXTMS(string a);

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int BUCKMWIGAPM(string a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool UKGGEJMXDAI([Out] bool a);

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool WSVJXTVKFRZ([Out] bool a);

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool QIKONNIELKN([Out] int a);

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool GSJEKDASAOO([Out] bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[ServiceLifetime(Lifetime.Application)]
	public interface LPPLBGAGQVZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "0")]
		void XLGLNIEOGME(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[ServiceLifetime(Lifetime.Application)]
	public interface TMFDCYBQNDN
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		protected static readonly Guid VPLZQKPUVBM;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		static readonly Guid IPEMCODKOTX;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		static readonly Guid MWEOEBJQQPB;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		static readonly Guid HEPWSRAVIKJ;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		bool WVWHRNBXAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		bool MRJHPTOECAY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		bool JTDJDCTDWVR
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "2")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		bool NTIMCANZBKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x87698A0", Offset = "0x87686A0", VA = "0x1887698A0", Slot = "4")]
		string[] ULDLZDBLSVJ(SerializedDataWrapper a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TFOXADQXTMH();

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8769940", Offset = "0x8768740", VA = "0x188769940", Slot = "6")]
		Guid YBCLFVZXNGK(Guid a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		int SFSZPFSNMMU(SerializedDataWrapper a);

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void GTNRWEXDMSO(SerializedDataWrapper a, NativeArray<ViewDescriptor> b, NativeList<UniformTRS> c);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "9")]
		int DYFCRJKEPSS(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool XULEYQQPBZZ(string a, [Out] Guid b);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		string UBAEEYAQNIY(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool XFCGUBOSTWN(RRObjectPrefabData a, [Out] LocalId b);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		RentedArray<byte[]> XUCFEHGCWXU(NativeArray<ViewDescriptor> a);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ZJJYGFHDVST(byte[] a);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		GameObject BNYFQWVSUVN(string a);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void VMNBRAAYGHY(Transform a, RRObjectPrefabData b, JSEALEMQFTE c);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool EMHUDSXPSOZ(SerializedDataWrapper a, NativeParallelHashMap<Guid, LocalId> b, [Out] Exception c);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void YGNFKNINIIZ(SerializedDataWrapper a, NativeParallelHashMap<Guid, LocalId> b, [Out] NativeArray<LocalId> c, [Out] NativeArray<LocalId> d, [Out] NativeArray<AuthoredLocalPoseData> e, Allocator f);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "19")]
		void CAKBQGBYGCS(SerializedDataWrapper a, NativeArray<int> b, ODUSMGRZXRA<GameObject> c, RentedArray<GameObject> d, LoadType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void GLECVCGQFRQ();

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "21")]
		void MJKKEHPWFYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "22")]
		void RZCVVHTPVZQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "23")]
		bool RBGLLABBUEL(SerializedDataWrapper a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "24")]
		BKNGFKZHTVF HDYBEKTGWRR(SerializedDataWrapper a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "25")]
		void UAGZTUJFSVZ(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "26")]
		bool VXYJUEXKOCF(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8769970", Offset = "0x8768770", VA = "0x188769970")]
		static TMFDCYBQNDN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[ServiceLifetime(Lifetime.Application)]
	public interface XNDTXVRYLQV
	{
		[Cpp2IlInjected.Token(Token = "0x17000075")]
		long LRKOMCQRUTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		long VZHSCBBQBSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "1")]
			get
			{
				return default(long);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface FBXOULORZSF
	{
		[Cpp2IlInjected.Token(Token = "0x17000077")]
		bool SCUFOCJJZIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		bool KFZBVYMRAGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		int QDBBTAYBQOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		int ROQRHDMODIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		int XGARBZOEMRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		bool SZTRSEDLJIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		int MOIQMUZNHTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "23")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "6")]
		void HTMEYXHNCSW(AKIAFFFHFEZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
		void EGOKUAHDKSS(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "8")]
		bool HRBFDKCIBCG(PlayerId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "9")]
		void YYURBTEIQKW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "10")]
		void SOPREBXMSTR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void VZHPQWPRYUO(Action<object> a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void LPVSUMBXNYD(Action<object> a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "13")]
		void TQLEXUDSQAL(NativeArray<ViewId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "14")]
		void KGINPBNHRQR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "15")]
		void NVNGLQXMQEN(OutOfBandMessageType a, ReadOnlySpan<byte> b, PlayerId c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "16")]
		void NVNGLQXMQEN(OutOfBandMessageType a, ReadOnlySpan<byte> b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "17")]
		void NVNGLQXMQEN(OutOfBandMessageType a, ReadOnlySpan<byte> b, ReadOnlySpan<byte> c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "18")]
		void SFKWKZCUMFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "19")]
		void VUTBQMUFMDB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "20")]
		void OTWBNRPGJCQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "21")]
		void EUIGOYEGXRN(Dictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "22")]
		void OTZWOOIGEOI(NativeList<ObjectNetworkId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "24")]
		void XWJZUIQDAIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "25")]
		void JFXICGQVWSD(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "26")]
		void TXWPTSKXGBT(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "27")]
		void WKTEJEZQWEQ(PlayerId a, object b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "28")]
		void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "29")]
		void YZZBTCWIEAS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class VNAGHAYRKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8769D40", Offset = "0x8768B40", VA = "0x188769D40")]
		public static NetworkPauseScope SZOYLHIIMCZ(this FBXOULORZSF a, object b)
		{
			return default(NetworkPauseScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct NetworkPauseScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private FBXOULORZSF dependencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private object token;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x87546A0", Offset = "0x87534A0", VA = "0x1887546A0")]
		public NetworkPauseScope(FBXOULORZSF dependencies, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8754650", Offset = "0x8753450", VA = "0x188754650", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface PCGEVNEUCVU
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public delegate void ApplyNetworkTransform(ViewId viewId, NetworkTransformSyncData syncData, int sender);

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "0")]
		void Pause(ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "1")]
		void LCSWQUFWCVC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "2")]
		void WVPJQLJWLCH(GJPMAIILVKQ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[ServiceLifetime(Lifetime.Application)]
	public interface UAAJUBKMMIR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface MGOIFTIJFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YJHWLBRGTTX();
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[ServiceLifetime(Lifetime.Application)]
	public interface TEJZBLDISRC
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct LoadScreenScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TEJZBLDISRC notifications;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8752A10", Offset = "0x8751810", VA = "0x188752A10")]
			public LoadScreenScope(TEJZBLDISRC notifications, string title, string subtitle)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x87529B0", Offset = "0x87517B0", VA = "0x1887529B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public struct FadeScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TEJZBLDISRC notifications;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Task task;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x87517A0", Offset = "0x87505A0", VA = "0x1887517A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "0")]
		void MLBMDFNDCHA(string a, float b = 5f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "1")]
		void NUTUVTSDSBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CPJRYZCGMYR(bool a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "3")]
		void NFYIGYETOVU(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class WOVDMKDFDUS
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8769F50", Offset = "0x8768D50", VA = "0x188769F50")]
		public static TEJZBLDISRC.LoadScreenScope LQJAXKSHRJT(this TEJZBLDISRC a, string b, string c)
		{
			return default(TEJZBLDISRC.LoadScreenScope);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[ServiceLifetime(Lifetime.Application)]
	public interface YTXODHLSEXE
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int XVOEUPPQORG(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DTWZFMWZATT(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool PBWVXOAGHKC(int a);

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "3")]
		object IEXASJFHLRA(ObjectLocalId a, GameObject b, Action<ObjectLocalId, int> c);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VLYWPFLYNMP(GameObject a, object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface XMCAGQEOBPH
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		IOWPMDUEFAI KMNOYMTEYAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ERTRAOZNVKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool OJFXTTCVRVE(NetworkCreatorId a, RolePermission b);

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void VPDPWXXPKEY(PlayerId a, AccountRoleTypeNetworked b);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[ServiceLifetime(Lifetime.Application)]
	public interface IRCSQGZUMYN
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void VVUFAYMMXPR(object a, NativeList<byte> b);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		object Deserialize(NativeArray<byte> data);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[ServiceLifetime(Lifetime.Application)]
	public interface LBDUBLJRXCO
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		bool KMQRASKGGTN
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Delegate EKHVLJYGTJR(QRQMRHQLAIR a, Action<QRQMRHQLAIR> b);

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MIZKLUAGNEG(QRQMRHQLAIR a, Delegate b);

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Delegate TEQNVLKCWCS(QRQMRHQLAIR a, Action<QRQMRHQLAIR> b);

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PYRQGZRQQLY(QRQMRHQLAIR a, Delegate b);

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool KIZZGSRSATH(QRQMRHQLAIR a);

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "6")]
		QRQMRHQLAIR HGKHAVRIDRT(GameObject a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface VEDDNCWIPBI
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		int PQRDIKDTBSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		int OOLCSDCUEYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		bool SCUFOCJJZIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		bool XSPNOENTKSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		bool NSHXSPHFLRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ObjectLocalId ZJSWGWCCPUM(int a);

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void CPSQDHPFHGQ(GameObject a, JobHandle b);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface IOWPMDUEFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool EIAKAKPXJZI(AccountRoleTypeNetworked a, RolePermission b);
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface RKELXLUBIUC
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		bool DHKEJKWWFRZ
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[ServiceLifetime(Lifetime.Application)]
	public interface OOQDSSIXXBW
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		EMNTPPJGFOH ELLNDEOQKHQ
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		QQYEJPPXQBH CRUHLWUHSQA
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		bool AWWLSCJSIBO
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QDNJXMKLAXQ(Transform a);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PESQLPTDRMO(Transform a, SelectionEffectType b);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SGVYXBMJRHY(Transform a, OutlineEffectType b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[ServiceLifetime(Lifetime.Application)]
	public interface QJLDFKAVQJD
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action SPJWYTCSMHR;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ZGZVRKWYOID
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KQZDLBUCRRF();
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[ServiceLifetime(Lifetime.Application)]
	public interface NEAURAPWNKW
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QRABHYFKZSA(GameObject a, ObjectPolicyUserConfigurableFlags b, CircuitsTransformBehavior c);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool XQTXYWWFHUH(ObjectLocalId a, bool b, float3 c, quaternion d);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool DPQYMXCWZHA(NativeObjectLocalIdArray a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GVGGRVZELSO(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MPOGPIXLRUE(RRObject a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NBKGMQLUFNT(NativeObjectLocalIdArray a);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void GEBNFAKFHSI(SerializedDataWrapper a, ReadOnlySpan<Guid> b, ReadOnlySpan<int> c, RentedArray<GameObject> d);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void QCGHIAIKRZW(EWAFJUGBLPN a);

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void XVNEUZCPMAN(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b);

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void ITWXHCMBQZG(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void XXREAOWOYTW(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct NativeArrayPinnedMemory : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly NativeArray<byte> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly GCHandle handle;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8752CE0", Offset = "0x8751AE0", VA = "0x188752CE0")]
		public NativeArrayPinnedMemory(ReadOnlyMemory<byte> memory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8752CB0", Offset = "0x8751AB0", VA = "0x188752CB0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum SerializedAssetVersion
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		V0PreObjectModel = 0,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		V1ObjectModelHierarchy = 1,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		V2ObjectModelHierarchy = 2,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		V3Entities050 = 3,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		V4Entities050Compressed = 4,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		V5BumpObjectModelVersionMay2024 = 5,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		V6Entities100 = 6,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		OldestCompatibleVersion = 3,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		LatestVersion = 6
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct SerializedDataWrapper
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public ByteString serializedOMData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public object persistenceViewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public object connectableGraphData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IEnumerable<string> legacyTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public bool isLatestDeprecatedVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public PBWKXABXJCX.EditReadyPreference? loadEditReadyPreference;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8769820", Offset = "0x8768620", VA = "0x188769820")]
		public SerializedDataWrapper(ByteString serializedOMData, [Optional] object persistenceViewData, [Optional] object connectableGraphData, [Optional] IEnumerable<string> legacyTags, bool isLatestDeprecatedVersion = true, [Optional] PBWKXABXJCX.EditReadyPreference? loadEditReadyPreference)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct SerializedObjectModelData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public object objectModelData;
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct ViewDescriptor
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[Flags]
		public enum Flags
		{
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			IsInvalid = 1,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			IsStudioPrefab = 2,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			IsBetaOnly = 4,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			IsDevOnly = 8,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			IsR1Only = 0x10,
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			IsR1Upgrade = 0x20,
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			IsAllowedDevOnly = 0x40
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public RRObjectPrefabData prefabData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public Guid persistenceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Guid costumeKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid objectBoardGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Guid circuitParentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Flags flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Color32 colorOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int spawnableToolType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public GameTeam teamOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int entityIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int transformIndex;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Guid YPZSXEAAVCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x5573C40", Offset = "0x5572A40", VA = "0x185573C40")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool HVUMVZLLWJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x8769DD0", Offset = "0x8768BD0", VA = "0x188769DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool FNFHMJLEHBV
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x8769DE0", Offset = "0x8768BE0", VA = "0x188769DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public bool XYVHCUNDGPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x8769DF0", Offset = "0x8768BF0", VA = "0x188769DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public bool VVOBPERACDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x8769E00", Offset = "0x8768C00", VA = "0x188769E00")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public readonly struct HistoryAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal readonly HistoryMarker start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		internal readonly HistoryMarker end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal readonly uint sequenceId;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8751C60", Offset = "0x8750A60", VA = "0x188751C60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public readonly struct UndoAction
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		internal readonly HistoryAction action;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8769420", Offset = "0x8768220", VA = "0x188769420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public readonly struct RedoAction
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal readonly HistoryAction action;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8769420", Offset = "0x8768220", VA = "0x188769420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public readonly struct GotoMarker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		internal readonly uint sequenceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		internal readonly bool isAtStart;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8751930", Offset = "0x8750730", VA = "0x188751930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct HistoryMarker
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		internal int offset;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8751EC0", Offset = "0x8750CC0", VA = "0x188751EC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface WUAXEQLCBDR
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		CTEAUNRVZEC YWDKRTOZIIP
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public interface MXDWVDSNRSJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public interface KFFCJWGWUHZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class WCWLRBZCSZN
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3E85CE0", Offset = "0x3E84AE0", VA = "0x183E85CE0")]
		public static RRObject LXBTFLLPKPC<a>(this a a) where a : MXDWVDSNRSJ
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8769ED0", Offset = "0x8768CD0", VA = "0x188769ED0")]
		public static MonoBehaviour JQJARPNZVIX(this MXDWVDSNRSJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8769E10", Offset = "0x8768C10", VA = "0x188769E10")]
		public static GameObject GameObject(this MXDWVDSNRSJ localId)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public interface ZIGAGCXSDBG : MXDWVDSNRSJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(ObjectLocalId objectId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public interface TNQYBIBGKWM : MXDWVDSNRSJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface YONCIKKMAZO
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public delegate void ParentsChangedCallback(ObjectIdBulkPropertyChangeData changeData);

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event ParentsChangedCallback YRPDOCLJOMA;
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public interface UZHHWMKAIBY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public interface ZYJFBKSFGTX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public interface GWJELEULZNY
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Transform GetTransform();

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Collider GetCollider();

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MoveToObject(ObjectLocalId newObject);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NotifyIsUniform(bool isUniform);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DestroyCollider();

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UBTDRQKQJTV(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public interface XPPGVCHTKPF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnRootRBEXChanged(GDYMXZWVLQY newRootWithUnityRigidbody);
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public interface GDYMXZWVLQY
	{
		[Cpp2IlInjected.Token(Token = "0x17000090")]
		GameObject VCJTFQOHKYC
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		Transform LUTJRPOGMJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		IQLOSMXEQPE NCAKKTRQRTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		bool AWPKMTHCTYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MNHHALHXJJZ(IQLOSMXEQPE a);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "5")]
		RigidbodyExData GetData();
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class FVPLKWTDCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8751400", Offset = "0x8750200", VA = "0x188751400")]
		public static void ZBXUCNONGBJ(this GDYMXZWVLQY a, JSEALEMQFTE b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public interface IQLOSMXEQPE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000094")]
		ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		Rigidbody LYLSFVCJLUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		GDYMXZWVLQY WPHJRVAMLEP
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		GameObject FEVRUSAGTIG
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		Transform ZCGASSMNTRL
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		IQLOSMXEQPE IGSJTJYCBZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(Slot = "24")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		IQLOSMXEQPE NKNEDPIWGGX
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		int PBJRUJQBWLA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		bool MGSTXVDYFSV
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		bool KIZZGSRSATH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		bool OJMGCEJESPL
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		TPQHYBXVCEA QLLABUJCDCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "32")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		XPPHMJGPLLF YWDVVAZVJEI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "34")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		float GEKAIAQUVBG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(Slot = "36")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		Vector3 SNLHSEGSKSZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(Slot = "37")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(Slot = "38")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		Vector3 VGNNJDXULRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(Slot = "39")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(Slot = "40")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		Vector3 DVFUTEPXRTY
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(Slot = "41")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(Slot = "42")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		Vector3 JEKLOACQCVU
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(Slot = "43")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(Slot = "44")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		bool TJHSJXBZSHO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(Slot = "45")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		bool ROVHRCIFMSP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(Slot = "46")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		bool KEAWZTBWULA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(Slot = "47")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		bool IEPPXZXXNHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(Slot = "48")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		Vector3 NZUWMXHMJWA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(Slot = "49")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		Vector3 NNNLMOORXBG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(Slot = "50")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		Vector3 AXEUGRGNYUG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(Slot = "51")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(Slot = "52")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		Vector3 QNINAVWDIHT
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(Slot = "53")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		float SAZWGGEAXTR
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(Slot = "54")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		float ZEFMEOEDTOY
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(Slot = "55")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(Slot = "56")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		Vector3 LWRFODEVPFY
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(Slot = "57")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		Quaternion SCLNYIMJZCE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(Slot = "58")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		float ZAPFRGRGMIF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(Slot = "60")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(Slot = "61")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		float XTVIJLVUJGZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(Slot = "62")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(Slot = "63")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		bool DAKABLWZVQI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "64")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "65")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		TransformTrackRate KOGAJYHNSCI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "66")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "67")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		bool IXMTAWZSMUU
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(Slot = "68")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		Transform EOCZPHKJMMS
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(Slot = "69")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		Vector3 VTURVASEHGS
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(Slot = "70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(Slot = "71")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		float QIBDAKMVXVC
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(Slot = "72")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(Slot = "73")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		float PXKDFCBPUTF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(Slot = "74")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(Slot = "75")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		Quaternion JVZSZDWWIJF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(Slot = "76")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "77")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		Vector3 CXGUXRWHWJH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "78")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(Slot = "79")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		Quaternion ULETLHGROGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(Slot = "80")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(Slot = "81")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		RigidbodyConstraints ZZNDPAKCEMV
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(Slot = "82")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(Slot = "83")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		bool RKTBCNSWZAS
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(Slot = "84")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(Slot = "85")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		CollisionDetectionMode XYZAJUGOTHR
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(Slot = "86")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(Slot = "87")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		bool FNMQUUFGQCR
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(Slot = "88")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event RbexAction ZRLWMSYFNVF;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event RbexAction JLBGDFBJARL;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event RbexAction UMZJHLNJBPU;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event RbexAction ETFLWCFXNGJ;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event RbexAction EPAOJVVYLSY;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event RbexAction PBQNRLTAUNN;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event RbexAction JUWIFCNHEWK;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexParentChangeAction ZODFISIYOEV;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<UpdateLOD, UpdateLOD> EOUEQDCPNZX;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		IQLOSMXEQPE OYWOMKKTERP(int a);

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void AVHYVADFBGQ((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "89")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "90")]
		void OnEnable();

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "91")]
		void OnDisable();

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "92")]
		void OnDestroy();

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "93")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "94")]
		void SetParent(IQLOSMXEQPE value, bool isPhysicallyDetachedOnly = false);

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "95")]
		void YOFMLZKPSCK(object a);

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "96")]
		void UCELSNIOQFX(object a);

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "97")]
		Vector3 FEHJGEGGUAI(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "98")]
		Vector3 DXKAJEUUKVM(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "99")]
		void OEVZVDJNBBF();

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "100")]
		void FEVTTANKFOW();

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "101")]
		void TTNPXHXBYBD();

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "102")]
		void IQLJSAKGEXJ(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "103")]
		void GLRZINOHTSW(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "104")]
		void IZZUETQUKXR(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "105")]
		void DWZRKRYIUGD(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "106")]
		void DQNDSWQYHNI(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "107")]
		void IBZFDEMKQUN(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "108")]
		Vector3 VEEYJMDVERW(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "109")]
		Vector3 XZKDQDAYVGE(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "110")]
		void NZGXMTNXECX();

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "111")]
		void VFVBMKGJZHZ(IQLOSMXEQPE a, object b);

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "112")]
		void ZDSSQHNPIDG(object a);

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "113")]
		void BBFCKZSWOKY();

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "114")]
		void EYRUDYQSZWH();

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "115")]
		void QBUPGVAOESG();

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "116")]
		bool MDBNRHUMEYC();

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "117")]
		void SPPGBOIMTQW();

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "118")]
		void RXVDHDMKVUD(object a);

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "119")]
		void QNGWBZMYCDG(object a);

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "120")]
		void XJYMLZNFAFU(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "121")]
		void LWPWQHEQIJU(Vector3 a, Quaternion b);

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "122")]
		void GGYCUEPSVTM(Vector3 a, Quaternion b);

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "123")]
		bool YQCDODQXNWV(float a);

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "124")]
		void LGICOBXFXFI(object a);

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "125")]
		void CBUALXGSVRB(object a);

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "126")]
		void RHVNAXHJIII(object a);

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "127")]
		void ZXDRGCLXBDF(object a);

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "128")]
		void SWTRTRDVTVD(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "129")]
		void EHXZYDRIIFF(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "130")]
		void VVMMMZDTOAY(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(Slot = "131")]
		void USHIUMMKMCU(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(Slot = "132")]
		bool JTKFPPLCFRL(Vector3 a, [Out] RaycastHit b, float c);

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(Slot = "133")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public interface XPPHMJGPLLF
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class FUAAIOUPFHG : XPPHMJGPLLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public FUAAIOUPFHG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "0")]
		void RDQDWJPTOVM(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "1")]
		void NXCIYSUJHCV(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "2")]
		void UNIGKBLBMRZ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "3")]
		void JYGHDIKZIIO(Vector3 a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public interface TPQHYBXVCEA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Vector3 CIOGGOYMFEG();

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Vector3 ZJETCNNRZNT();

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool LSGXQNWZLLO(float a, float b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void RbexAction(GDYMXZWVLQY thisRigidbodyEx);
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum RbexCallbackType
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		ChildAdded,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		ChildRemoved,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		ParentChanged,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		HierarchyMassUpdated,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		SleepChanged,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		DistanceBandChanged,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		IsKinematicChanged,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Discontinuity,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Destroyed,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		COUNT
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public enum RbexImpulseType
	{
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Additive,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Override,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Reflective,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		FullOverride
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public delegate void RbexParentChangeAction(GDYMXZWVLQY thisRigidbodyEx, bool isPhysicallyDetachedOnly = false);
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public enum RbexRotationType
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Additive,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Override,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Reflective
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct RigidbodyExData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public object photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Vector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Vector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public RbexInterpolationMode physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public bool hasPrecomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public bool hasCustomCenterOfMass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public readonly struct RRObject : IEquatable<RRObject>
	{
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly RRObject Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public GameObject VCJTFQOHKYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x8767A00", Offset = "0x8766800", VA = "0x188767A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public ObjectNetworkId CAJPOHAFBEO
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x8767F60", Offset = "0x8766D60", VA = "0x188767F60")]
			get
			{
				return default(ObjectNetworkId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public ObjectType JSRHWHSPYOY
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x8767B90", Offset = "0x8766990", VA = "0x188767B90")]
			get
			{
				return default(ObjectType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public RRObjectPrefabData LGJNEPSEDEN
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x8767510", Offset = "0x8766310", VA = "0x188767510")]
			get
			{
				return default(RRObjectPrefabData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public bool HFIUFVFSANI
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x87684F0", Offset = "0x87672F0", VA = "0x1887684F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public bool LBFWPBJLFRQ
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x8767950", Offset = "0x8766750", VA = "0x188767950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool CLSRYMVGUBI
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x8767DA0", Offset = "0x8766BA0", VA = "0x188767DA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public bool EZGAVBYTDFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x8767840", Offset = "0x8766640", VA = "0x188767840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public bool SGYYTLCUHTK
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x8767C30", Offset = "0x8766A30", VA = "0x188767C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public bool MFEDPYDAHBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x87681B0", Offset = "0x8766FB0", VA = "0x1887681B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public bool QLACNXCMHBV
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x8767770", Offset = "0x8766570", VA = "0x188767770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public bool NWJECTGEANY
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x87679C0", Offset = "0x87667C0", VA = "0x1887679C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public bool JHYAUGZPDWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x8767D60", Offset = "0x8766B60", VA = "0x188767D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public bool CUBFFNAAAZU
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x8768000", Offset = "0x8766E00", VA = "0x188768000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public bool GISSFYSVNIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x8767F20", Offset = "0x8766D20", VA = "0x188767F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public bool XXAOBGTBOFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x8767CA0", Offset = "0x8766AA0", VA = "0x188767CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public bool QQRKASRPEYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x87677B0", Offset = "0x87665B0", VA = "0x1887677B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public bool LEQBXCOZKNB
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x8768340", Offset = "0x8767140", VA = "0x188768340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public bool RKECNROGDJX
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x87677F0", Offset = "0x87665F0", VA = "0x1887677F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public bool YFIFPDFKLZO
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x8768300", Offset = "0x8767100", VA = "0x188768300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public bool EIQYUAQRGWL
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x87682C0", Offset = "0x87670C0", VA = "0x1887682C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public RRObjectCircuitBoard GZYULUQHSIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectCircuitBoard);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public RRObjectIdentity HIWLSQYHTOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectIdentity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public RRObjectPhysics PDCFDEBOIEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectPhysics);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public RRObjectPlayerInteraction RZCYHIKXNKO
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectPlayerInteraction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public RRObjectPolicy CQWAPISIRVD
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectPolicy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public RRObjectReferenceGroup GKWURQNOADJ
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectReferenceGroup);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public RRObjectRenderEffects JJFNAAIGIRN
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectRenderEffects);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public RRObjectReplicatedObject PRZPSWWUZYV
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectReplicatedObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public RRObjectReplicator AGJUNNTNUKG
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectReplicator);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public RRObjectScope JXJHKWLTJWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectScope);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public RRObjectToolCleanup BLHLGSTYBBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectToolCleanup);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public RRObjectUserTags ZJBEPSFGXIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectUserTags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public RRObjectAIMetadata QDVJZKSMMNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectAIMetadata);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public RRObjectDeformable IQAJXNQKHMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectDeformable);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public RRObjectObjectInteractionFilter JLFZAWVEWAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectObjectInteractionFilter);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool HFWNYWTCPPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x8767860", Offset = "0x8766660", VA = "0x188767860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public bool WHOMZAJFPJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x8767E60", Offset = "0x8766C60", VA = "0x188767E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public bool ZWBSJIXGZSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x87673A0", Offset = "0x87661A0", VA = "0x1887673A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool PEIZIDBQNKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x8767830", Offset = "0x8766630", VA = "0x188767830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool BZHILOKAKVR
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x8768480", Offset = "0x8767280", VA = "0x188768480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public bool LSYDXMBVXZE
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x87673E0", Offset = "0x87661E0", VA = "0x1887673E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public bool BURRSGENTQJ
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x87681E0", Offset = "0x8766FE0", VA = "0x1887681E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public RRObjectTransform ZCGASSMNTRL
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public RRObjectHierarchy RJNDZUANLLI
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		private IFXBBMDUCGM QMAFFUGLXDD
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x87554F0", Offset = "0x87542F0", VA = "0x1887554F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xE23440", Offset = "0xE22240", VA = "0x180E23440")]
		public static implicit operator RRObject(ObjectLocalId objectId)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8767CE0", Offset = "0x8766AE0", VA = "0x188767CE0")]
		public RRObjectContainer MGKBDIHNMAG()
		{
			return default(RRObjectContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x87684C0", Offset = "0x87672C0", VA = "0x1887684C0")]
		public RRObjectShape ZDEBYNDWACY()
		{
			return default(RRObjectShape);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8767ED0", Offset = "0x8766CD0", VA = "0x188767ED0")]
		public RRObjectConnectable SCAGCNFJHUX()
		{
			return default(RRObjectConnectable);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8767EA0", Offset = "0x8766CA0", VA = "0x188767EA0")]
		public RRObjectPlayer RZCLJBLHIWO()
		{
			return default(RRObjectPlayer);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8767970", Offset = "0x8766770", VA = "0x188767970")]
		public RRObjectPlayerInteractionFilter KEYBIJFWXTB()
		{
			return default(RRObjectPlayerInteractionFilter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x87674C0", Offset = "0x87662C0", VA = "0x1887674C0")]
		public RRObjectStudioObject CSMJQGIUGCK()
		{
			return default(RRObjectStudioObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8767C50", Offset = "0x8766A50", VA = "0x188767C50")]
		public RRObjectElementSnapPoint MCNOONNKECH()
		{
			return default(RRObjectElementSnapPoint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8767E10", Offset = "0x8766C10", VA = "0x188767E10")]
		public RRObjectElement PYZEBYIQFYR()
		{
			return default(RRObjectElement);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8767DC0", Offset = "0x8766BC0", VA = "0x188767DC0")]
		public RRObjectTerrain PWAHATDKLTS()
		{
			return default(RRObjectTerrain);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8768380", Offset = "0x8767180", VA = "0x188768380")]
		public void XSNEPIBPFJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8767640", Offset = "0x8766440", VA = "0x188767640")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8768220", Offset = "0x8767020", VA = "0x188768220")]
		public void VMNBCQOLEDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8767420", Offset = "0x8766220", VA = "0x188767420")]
		public bool CIMWKSBSHPV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8768040", Offset = "0x8766E40", VA = "0x188768040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObject(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8758D80", Offset = "0x8757B80", VA = "0x188758D80")]
		public static implicit operator bool(RRObject value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xE23440", Offset = "0xE22240", VA = "0x180E23440")]
		public static implicit operator ObjectLocalId(RRObject value)
		{
			return default(ObjectLocalId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x875A080", Offset = "0x8758E80", VA = "0x18875A080")]
		public static bool GFBRUTYEXQF(RRObject a, RRObject b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8754DE0", Offset = "0x8753BE0", VA = "0x188754DE0")]
		public static bool CQBJVGKOTGK(RRObject a, RRObject b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x87676E0", Offset = "0x87664E0", VA = "0x1887676E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObject other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public readonly struct RRObjectAIMetadata : IEquatable<RRObjectAIMetadata>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		private XCEMBZHBKBS FRPZZRYLIPC
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x87572C0", Offset = "0x87560C0", VA = "0x1887572C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x87571B0", Offset = "0x8755FB0", VA = "0x1887571B0")]
		public void QCEKXJKPDEM(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8757860", Offset = "0x8756660", VA = "0x188757860")]
		public bool YSDIJLJYQOB([Out] uint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8757760", Offset = "0x8756560", VA = "0x188757760")]
		public bool YGOGOEMAYAJ([Out] uint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x87574C0", Offset = "0x87562C0", VA = "0x1887574C0")]
		public void UFDQYRLFHKT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8757650", Offset = "0x8756450", VA = "0x188757650")]
		[CanBeNull]
		public string WKSQQBYOKQH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8757340", Offset = "0x8756140", VA = "0x188757340")]
		public bool UBSVOXDVDMA([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x87575B0", Offset = "0x87563B0", VA = "0x1887575B0")]
		public void VRJLQHHKQEN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectAIMetadata(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8757110", Offset = "0x8755F10", VA = "0x188757110", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectAIMetadata other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public readonly struct RRObjectCircuitBoard : IEquatable<RRObjectCircuitBoard>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		private QKTMHUGAQKV GWKPJCMMKBQ
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x8758140", Offset = "0x8756F40", VA = "0x188758140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		private XCEMBZHBKBS TMIMZGBIMIH
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x8758230", Offset = "0x8757030", VA = "0x188758230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public bool JQARSGFVHAW
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x87581A0", Offset = "0x8756FA0", VA = "0x1887581A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public bool BLVMGXMCWDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8758290", Offset = "0x8757090", VA = "0x188758290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		public bool DLJYFMXXKTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x8758080", Offset = "0x8756E80", VA = "0x188758080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		public Guid IECTTBUGBDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x8757E60", Offset = "0x8756C60", VA = "0x188757E60")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		public Guid SQMEOXSHHQG
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x8757EE0", Offset = "0x8756CE0", VA = "0x188757EE0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		public Guid XWUYJRYYHXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x8757960", Offset = "0x8756760", VA = "0x188757960")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		public RRObjectHierarchy RJNDZUANLLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8757DC0", Offset = "0x8756BC0", VA = "0x188757DC0")]
		public bool HFQDCBZDTDD([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8757B70", Offset = "0x8756970", VA = "0x188757B70")]
		public bool BYWLKJAIVFH([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8757F60", Offset = "0x8756D60", VA = "0x188757F60")]
		public void NVIRLHBYLOI(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x87582D0", Offset = "0x87570D0", VA = "0x1887582D0")]
		public void ZXASDWABFPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8757C10", Offset = "0x8756A10", VA = "0x188757C10")]
		public Guid DXJHWXEXTQZ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectCircuitBoard(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8757D30", Offset = "0x8756B30", VA = "0x188757D30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectCircuitBoard other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public readonly struct RRObjectConnectable : IEquatable<RRObjectConnectable>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		private TSMXUIUWALV OJOWCNCPGYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x8758D20", Offset = "0x8757B20", VA = "0x188758D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public Vector3 CRUEWVRZDET
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x8758810", Offset = "0x8757610", VA = "0x188758810")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		public Quaternion DZTGMNLIYAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x8758B40", Offset = "0x8757940", VA = "0x188758B40")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		public RRObject OTGFECOHVUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x8758C90", Offset = "0x8757A90", VA = "0x188758C90")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8758A70", Offset = "0x8757870", VA = "0x188758A70")]
		public NativeObjectLocalIdArray PLBBDCBLAJC(Allocator a)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8758620", Offset = "0x8757420", VA = "0x188758620")]
		public bool FZMMUTVRQUP(RRObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x87586C0", Offset = "0x87574C0", VA = "0x1887586C0")]
		public void HYIAXAAWGWP(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8758960", Offset = "0x8757760", VA = "0x188758960")]
		public void PDOUWKJXJJK(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x87583D0", Offset = "0x87571D0", VA = "0x1887583D0")]
		public void CCXGYYUKRQB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectConnectable(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8758D80", Offset = "0x8757B80", VA = "0x188758D80")]
		public static implicit operator bool(RRObjectConnectable value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xE23440", Offset = "0xE22240", VA = "0x180E23440")]
		public static implicit operator ObjectLocalId(RRObjectConnectable value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8758590", Offset = "0x8757390", VA = "0x188758590", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectConnectable other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public readonly struct RRObjectContainer : IEquatable<RRObjectContainer>
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public static readonly RRObjectContainer Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		private BZGADCICSKQ EMVQUKNXSKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x8759350", Offset = "0x8758150", VA = "0x188759350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		[Obsolete("Use RRObjectHierarchy.GetChildren() instead")]
		public Span<RRObject> GYIVLHUMCMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x87593B0", Offset = "0x87581B0", VA = "0x1887593B0")]
			get
			{
				return default(Span<RRObject>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x87594B0", Offset = "0x87582B0", VA = "0x1887594B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x87592D0", Offset = "0x87580D0", VA = "0x1887592D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public RRObjectTransform ZCGASSMNTRL
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public RRObjectHierarchy RJNDZUANLLI
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8758E30", Offset = "0x8757C30", VA = "0x188758E30")]
		public void HZPNXIPUFGN(RRObjectContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectContainer(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8758D80", Offset = "0x8757B80", VA = "0x188758D80")]
		public static implicit operator bool(RRObjectContainer value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8758DA0", Offset = "0x8757BA0", VA = "0x188758DA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectContainer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xE23440", Offset = "0xE22240", VA = "0x180E23440")]
		public static implicit operator RRObject(RRObjectContainer self)
		{
			return default(RRObject);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public struct RRObjectCreationParameters : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private Dictionary<int, object> map;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private EENTYBRXPZV wrapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool isReadOnly;

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		public RRObject Object
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			[CompilerGenerated]
			readonly get
			{
				return default(RRObject);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		public CreationInstantiationKey this[CreationInstantiationKey key]
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x8759850", Offset = "0x8758650", VA = "0x188759850")]
			readonly set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8759780", Offset = "0x8758580", VA = "0x188759780")]
		internal RRObjectCreationParameters(RRObject obj, bool isReadOnly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8759530", Offset = "0x8758330", VA = "0x188759530", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x3CB5070", Offset = "0x3CB3E70", VA = "0x183CB5070")]
		public void TMPIJJBLESA<a>(CreationInstantiationKey a, a b, [Optional] a c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x87596D0", Offset = "0x87584D0", VA = "0x1887596D0")]
		public void Remove(CreationInstantiationKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xB72150", Offset = "0xB70F50", VA = "0x180B72150")]
		public Dictionary<int, object> LHTGFPYOUWP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8759660", Offset = "0x8758460", VA = "0x188759660")]
		private readonly void EHTOBKZVMBB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class CKINITSJFSS
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8750720", Offset = "0x874F520", VA = "0x188750720")]
		public static RRObjectCreationParameters ROFRCIGGTUH(this RRObject a)
		{
			return default(RRObjectCreationParameters);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct RRObjectDeformable : IEquatable<RRObjectDeformable>
	{
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private static readonly Log log;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly RRObjectDeformable Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		private bool GISSFYSVNIW
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x8759C00", Offset = "0x8758A00", VA = "0x188759C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		public Vector3 BEEOYRSDSKV
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x8759B50", Offset = "0x8758950", VA = "0x188759B50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x8759D20", Offset = "0x8758B20", VA = "0x188759D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8759A50", Offset = "0x8758850", VA = "0x188759A50")]
		public Vector3 FLSDIAWCUZV()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8759C40", Offset = "0x8758A40", VA = "0x188759C40")]
		public void TGADTQAWQCX([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8759AD0", Offset = "0x87588D0", VA = "0x188759AD0")]
		public void IVNRTCGDWGV([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8759910", Offset = "0x8758710", VA = "0x188759910")]
		public bool CMBZIHWLDNI([In] Vector3 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectDeformable(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x87599C0", Offset = "0x87587C0", VA = "0x1887599C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectDeformable other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8759CC0", Offset = "0x8758AC0", VA = "0x188759CC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public readonly struct RRObjectDesync : IEquatable<RRObjectDesync>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8759E00", Offset = "0x8758C00", VA = "0x188759E00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectDesync other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct RRObjectElement : IEquatable<RRObjectElement>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		private KTTTBDOTNAX NSNWVQTKDLA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x875AA70", Offset = "0x8759870", VA = "0x18875AA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public bool HDBCFYNSIBR
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x875A900", Offset = "0x8759700", VA = "0x18875A900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		public bool IYTAQOMONEZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x875A4D0", Offset = "0x87592D0", VA = "0x18875A4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		public ElementGroupStatusData ABNIGOISQQU
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x875A600", Offset = "0x8759400", VA = "0x18875A600")]
			get
			{
				return default(ElementGroupStatusData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public bool TVDALMXYBMC
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x875AA30", Offset = "0x8759830", VA = "0x18875AA30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		public bool FOZSNGRGZMB
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x875A870", Offset = "0x8759670", VA = "0x18875A870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		public bool YPSMCWKLVQH
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x875A740", Offset = "0x8759540", VA = "0x18875A740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x875A7D0", Offset = "0x87595D0", VA = "0x18875A7D0")]
		public bool IDDHBLSBWNY(RRObjectElement a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x875AAD0", Offset = "0x87598D0", VA = "0x18875AAD0")]
		public bool YBRLPNCYECD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x875A280", Offset = "0x8759080", VA = "0x18875A280")]
		public bool DIBRBOXEBDW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x875A3B0", Offset = "0x87591B0", VA = "0x18875A3B0")]
		public ReadOnlySpan<ObjectLocalId> GBJRYBLIQCR()
		{
			return default(ReadOnlySpan<ObjectLocalId>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectElement(ObjectLocalId localId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x875A080", Offset = "0x8758E80", VA = "0x18875A080")]
		public static bool GFBRUTYEXQF(RRObjectElement a, RRObjectElement b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8754DE0", Offset = "0x8753BE0", VA = "0x188754DE0")]
		public static bool CQBJVGKOTGK(RRObjectElement a, RRObjectElement b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x875A320", Offset = "0x8759120", VA = "0x18875A320", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectElement other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public readonly struct RRObjectElementSnapPoint : IEquatable<RRObjectElementSnapPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public static readonly RRObjectElementSnapPoint Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		private KTTTBDOTNAX QQDQVPURIRY
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x8759EF0", Offset = "0x8758CF0", VA = "0x188759EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		public bool ZLIAFLHYGZX
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x8759E90", Offset = "0x8758C90", VA = "0x188759E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		public RRObjectTransform ZCGASSMNTRL
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x875A090", Offset = "0x8758E90", VA = "0x18875A090")]
		public bool IDDHBLSBWNY(RRObjectElementSnapPoint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8759F50", Offset = "0x8758D50", VA = "0x188759F50")]
		public bool DJFDQTCFOTO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x875A1A0", Offset = "0x8758FA0", VA = "0x18875A1A0")]
		public bool RQVXUCTMCWK([Out] RRObjectElementSnapPoint a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x875A130", Offset = "0x8758F30", VA = "0x18875A130")]
		public void PHLMBCICBDN(ElementSnapPointRuntimeFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectElementSnapPoint(ObjectLocalId localId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x875A080", Offset = "0x8758E80", VA = "0x18875A080")]
		public static bool GFBRUTYEXQF(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8754DE0", Offset = "0x8753BE0", VA = "0x188754DE0")]
		public static bool CQBJVGKOTGK(RRObjectElementSnapPoint a, RRObjectElementSnapPoint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8759FF0", Offset = "0x8758DF0", VA = "0x188759FF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectElementSnapPoint other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public readonly struct RRObjectHierarchy : IEquatable<RRObjectHierarchy>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		private BZGADCICSKQ EMVQUKNXSKN
		{
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x875AF20", Offset = "0x8759D20", VA = "0x18875AF20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public ObjectLocalId FKSNBRQTHPA
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x875AF80", Offset = "0x8759D80", VA = "0x18875AF80")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public RRObject IGSJTJYCBZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x875B110", Offset = "0x8759F10", VA = "0x18875B110")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		public RRObject NKNEDPIWGGX
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x875AC70", Offset = "0x8759A70", VA = "0x18875AC70")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x875B1A0", Offset = "0x8759FA0", VA = "0x18875B1A0")]
		public Span<RRObject> OAKDFYPPCSK()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x875AD00", Offset = "0x8759B00", VA = "0x18875AD00")]
		public Span<RRObject> EQOVXXZHPQR()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x875AB70", Offset = "0x8759970", VA = "0x18875AB70")]
		public Span<RRObject> CKDXTDCAATG()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x875B010", Offset = "0x8759E10", VA = "0x18875B010")]
		public Span<RRObject> LFJOITZNVGO()
		{
			return default(Span<RRObject>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x875B3B0", Offset = "0x875A1B0", VA = "0x18875B3B0")]
		public bool SetParent(RRObject parent, bool worldPositionStays = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x875B4E0", Offset = "0x875A2E0", VA = "0x18875B4E0")]
		public bool VBQIFQZDXVK(RRObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x875B2A0", Offset = "0x875A0A0", VA = "0x18875B2A0")]
		public RRObject PMCIWUVFEGM(uint a)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x875AE90", Offset = "0x8759C90", VA = "0x18875AE90")]
		public RRObjectContainer FDUTCSWPXQQ()
		{
			return default(RRObjectContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectHierarchy(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8758D80", Offset = "0x8757B80", VA = "0x188758D80")]
		public static implicit operator bool(RRObjectHierarchy value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x875AE00", Offset = "0x8759C00", VA = "0x18875AE00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectHierarchy other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public readonly struct RRObjectIdentity : IEquatable<RRObjectIdentity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		public string EXGJUDSWVUT
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x875BA60", Offset = "0x875A860", VA = "0x18875BA60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		public string ONEBJROYIEU
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x875B580", Offset = "0x875A380", VA = "0x18875B580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		public string YQOVSGFLILD
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x875B8F0", Offset = "0x875A6F0", VA = "0x18875B8F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		public string WSZBXKLEIXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x875B650", Offset = "0x875A450", VA = "0x18875B650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x875B9A0", Offset = "0x875A7A0", VA = "0x18875B9A0")]
		public bool UBSVOXDVDMA([Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectIdentity(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x875B5C0", Offset = "0x875A3C0", VA = "0x18875B5C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectIdentity other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public readonly struct RRObjectInternal : IEquatable<RRObjectInternal>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x875BAF0", Offset = "0x875A8F0", VA = "0x18875BAF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectInternal other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public readonly struct RRObjectMagneticAnchor : IEquatable<RRObjectMagneticAnchor>
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[Flags]
		public enum ConnectResult
		{
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			SUCCESS = 0,
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			ANCHOR_A_INVALID = 1,
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			ANCHOR_B_INVALID = 2,
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			ANCHOR_A_ALREADY_CONNECTED = 4,
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			ANCHOR_B_ALREADY_CONNECTED = 8
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static Log log;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static readonly RRObjectMagneticAnchor Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		private IFXBBMDUCGM QMAFFUGLXDD
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x87554F0", Offset = "0x87542F0", VA = "0x1887554F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager YONVSXFRQLZ
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x875C930", Offset = "0x875B730", VA = "0x18875C930")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x875C660", Offset = "0x875B460", VA = "0x18875C660")]
		public float WIUTULBCUAV()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x875BE80", Offset = "0x875AC80", VA = "0x18875BE80")]
		public void SYUZHNFKWZH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x875C6B0", Offset = "0x875B4B0", VA = "0x18875C6B0")]
		public static ConnectResult XOOKOOCENJQ(RRObjectMagneticAnchor a, RRObjectMagneticAnchor b)
		{
			return default(ConnectResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x875C0A0", Offset = "0x875AEA0", VA = "0x18875C0A0")]
		public bool URZOVBFPAFL([Out] GameObject a, [Out] GameObject b, [Out] RRObject c, [Out] RRObject d, [Out] Vector3 e, [Out] Vector3 f, [Out] Vector3 g, [Out] RRObject h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x875BC10", Offset = "0x875AA10", VA = "0x18875BC10")]
		public bool GUHGWKBBDLV([Out] GameObject a, [Out] GameObject b, [Out] RRObject c, [Out] RRObject d, [Out] Vector3 e, [Out] Vector3 f, [Out] Vector3 g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x875C960", Offset = "0x875B760", VA = "0x18875C960")]
		private void ZJWDXIZHQHQ(Entity a, EntityManager b, MagneticAnchorData c, [Out] GameObject d, [Out] GameObject e, [Out] RRObject f, [Out] RRObject g, [Out] Vector3 h, [Out] Vector3 i, [Out] Vector3 j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectMagneticAnchor(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x875BB80", Offset = "0x875A980", VA = "0x18875BB80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectMagneticAnchor other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x875C040", Offset = "0x875AE40", VA = "0x18875C040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public readonly struct RRObjectNetworkComponents : IEquatable<RRObjectNetworkComponents>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x875CDB0", Offset = "0x875BBB0", VA = "0x18875CDB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectNetworkComponents other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public readonly struct RRObjectObjectInteractionFilter : IEquatable<RRObjectObjectInteractionFilter>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		private OEHSBPDDFUE QQDQVPURIRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x875CF60", Offset = "0x875BD60", VA = "0x18875CF60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		public InteractionFilterMode CPOFFPFYKSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x875D3B0", Offset = "0x875C1B0", VA = "0x18875D3B0")]
			get
			{
				return default(InteractionFilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x875D3F0", Offset = "0x875C1F0", VA = "0x18875D3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public RentedArray<string> NGNDPEQIRHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x875D0E0", Offset = "0x875BEE0", VA = "0x18875D0E0")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x875D290", Offset = "0x875C090", VA = "0x18875D290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public RentedArray<string> JEJVSMSHWHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x875CFC0", Offset = "0x875BDC0", VA = "0x18875CFC0")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x875CE40", Offset = "0x875BC40", VA = "0x18875CE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectObjectInteractionFilter(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x875D200", Offset = "0x875C000", VA = "0x18875D200", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectObjectInteractionFilter other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public readonly struct RRObjectPhysics : IEquatable<RRObjectPhysics>
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly ComponentTypeSet RequiredComponents;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly RRObjectPhysics Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		public Collider QGDHXNNZOWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x875E240", Offset = "0x875D040", VA = "0x18875E240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		public CollisionLayerEnum BWYBAYEVXVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x875D8F0", Offset = "0x875C6F0", VA = "0x18875D8F0")]
			get
			{
				return default(CollisionLayerEnum);
			}
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x875D4E0", Offset = "0x875C2E0", VA = "0x18875D4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		public CollisionMode SODGWLXYPZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x875D870", Offset = "0x875C670", VA = "0x18875D870")]
			get
			{
				return default(CollisionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x875DFF0", Offset = "0x875CDF0", VA = "0x18875DFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		public GrabbableMode VJQCVZYECBA
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x875D8B0", Offset = "0x875C6B0", VA = "0x18875D8B0")]
			get
			{
				return default(GrabbableMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x875DFA0", Offset = "0x875CDA0", VA = "0x18875DFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		public float UYZTJFHANOT
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x875D830", Offset = "0x875C630", VA = "0x18875D830")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x875D5D0", Offset = "0x875C3D0", VA = "0x18875D5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		public bool CNXOFWGVGXY
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x875D930", Offset = "0x875C730", VA = "0x18875D930")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x875D530", Offset = "0x875C330", VA = "0x18875D530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		public bool AANWXGCRHAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x875D730", Offset = "0x875C530", VA = "0x18875D730")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x875DF00", Offset = "0x875CD00", VA = "0x18875DF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public bool AYGXSUUIDWA
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x875D7B0", Offset = "0x875C5B0", VA = "0x18875D7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x875E040", Offset = "0x875CE40", VA = "0x18875E040")]
		public static bool YFLFPDTQBCO(RRObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x875DCC0", Offset = "0x875CAC0", VA = "0x18875DCC0")]
		public static bool UYCPXVCHFQY(RRObject a, [Out] RRObjectPhysics b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x875D9A0", Offset = "0x875C7A0", VA = "0x18875D9A0")]
		public bool QSPTVGBOGVP([Out] GWJELEULZNY a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x875DB10", Offset = "0x875C910", VA = "0x18875DB10")]
		public bool SMRSLLHJOWY([Out] ObjectLocalId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x875DC00", Offset = "0x875CA00", VA = "0x18875DC00")]
		public bool SOUFUEJZLXX(PhysicsModelEnumFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x875D6B0", Offset = "0x875C4B0", VA = "0x18875D6B0")]
		public void HXSZNZATZIN(PhysicsModelEnumFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x875D440", Offset = "0x875C240", VA = "0x18875D440")]
		public void AMMJHBAGHWY(PhysicsModelEnumFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectPhysics(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x875D620", Offset = "0x875C420", VA = "0x18875D620", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectPhysics other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x875DC60", Offset = "0x875CA60", VA = "0x18875DC60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public readonly struct RRObjectPlayer : IEquatable<RRObjectPlayer>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		public bool KTECGXTXWWT
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x875F5B0", Offset = "0x875E3B0", VA = "0x18875F5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectPlayer(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x875F520", Offset = "0x875E320", VA = "0x18875F520", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectPlayer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public readonly struct RRObjectPlayerInteraction : IEquatable<RRObjectPlayerInteraction>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		private CFAMWMVINFS FTPOZIQHXQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x875F4C0", Offset = "0x875E2C0", VA = "0x18875F4C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x875F3D0", Offset = "0x875E1D0", VA = "0x18875F3D0")]
		public void PPYCVIOSXCG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectPlayerInteraction(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x875F340", Offset = "0x875E140", VA = "0x18875F340", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectPlayerInteraction other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public readonly struct RRObjectPlayerInteractionFilter : IEquatable<RRObjectPlayerInteractionFilter>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		private VCVVUGNIYDA KUFQDFEYGTF
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x875F0A0", Offset = "0x875DEA0", VA = "0x18875F0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public InteractionFilterMode CCUNNSFMSIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x875E570", Offset = "0x875D370", VA = "0x18875E570")]
			get
			{
				return default(InteractionFilterMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x875ED50", Offset = "0x875DB50", VA = "0x18875ED50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public bool OJJUOBCBHLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x875E670", Offset = "0x875D470", VA = "0x18875E670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x875E8B0", Offset = "0x875D6B0", VA = "0x18875E8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public RentedArray<string> OAMDQUMDLNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x875EC30", Offset = "0x875DA30", VA = "0x18875EC30")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x875F220", Offset = "0x875E020", VA = "0x18875F220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public RentedArray<string> UCJIMYCSRXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x875E790", Offset = "0x875D590", VA = "0x18875E790")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x875EB10", Offset = "0x875D910", VA = "0x18875EB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public RentedArray<string> CQTELYTNXJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x875EF80", Offset = "0x875DD80", VA = "0x18875EF80")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x875F100", Offset = "0x875DF00", VA = "0x18875F100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public RentedArray<string> MCGQDTIQJNM
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x875E9F0", Offset = "0x875D7F0", VA = "0x18875E9F0")]
			get
			{
				return default(RentedArray<string>);
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x875EE60", Offset = "0x875DC60", VA = "0x18875EE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x875E950", Offset = "0x875D750", VA = "0x18875E950")]
		public bool HDOCPHCGFUC(ObjectLocalId a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectPlayerInteractionFilter(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xE23440", Offset = "0xE22240", VA = "0x180E23440")]
		public static implicit operator ObjectLocalId(RRObjectPlayerInteractionFilter value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x875E700", Offset = "0x875D500", VA = "0x18875E700", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectPlayerInteractionFilter other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public readonly struct RRObjectPolicy : IEquatable<RRObjectPolicy>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		public bool MAAEMMKIEXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x87604B0", Offset = "0x875F2B0", VA = "0x1887604B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		public bool OBBKQBQCWCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x8760390", Offset = "0x875F190", VA = "0x188760390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public bool QQARVSRXZUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x8760120", Offset = "0x875EF20", VA = "0x188760120")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x8760170", Offset = "0x875EF70", VA = "0x188760170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		public bool EWZIOAXLOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x875FB30", Offset = "0x875E930", VA = "0x18875FB30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public bool KEAMBRQRUYA
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x875F6A0", Offset = "0x875E4A0", VA = "0x18875F6A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public bool PSYTGJNTPXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x875F650", Offset = "0x875E450", VA = "0x18875F650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public bool QYQNIYPVKGX
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x875F8A0", Offset = "0x875E6A0", VA = "0x18875F8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public bool CGRPKBHFDWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x875FD30", Offset = "0x875EB30", VA = "0x18875FD30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool AASKPFRRELM
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x87604F0", Offset = "0x875F2F0", VA = "0x1887604F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool ZWMRMHFVLKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x875F8F0", Offset = "0x875E6F0", VA = "0x18875F8F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public bool EAOXGXRVOQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x875FCE0", Offset = "0x875EAE0", VA = "0x18875FCE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public bool VEXRHFETTFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x875F780", Offset = "0x875E580", VA = "0x18875F780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		public bool RITOMLHLJPX
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x875F9E0", Offset = "0x875E7E0", VA = "0x18875F9E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public bool BRGZQDAQJKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x875F860", Offset = "0x875E660", VA = "0x18875F860")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x875FC80", Offset = "0x875EA80", VA = "0x18875FC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public bool LXHZNDGOQSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x875F600", Offset = "0x875E400", VA = "0x18875F600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		public NavMeshGenerationMode YUAIMDAAXMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x875F740", Offset = "0x875E540", VA = "0x18875F740")]
			get
			{
				return default(NavMeshGenerationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x875F6F0", Offset = "0x875E4F0", VA = "0x18875F6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public bool YEVFQXGXRMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x87601E0", Offset = "0x875EFE0", VA = "0x1887601E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public CircuitsTransformBehavior EXVNXALHMXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x875FDC0", Offset = "0x875EBC0", VA = "0x18875FDC0")]
			get
			{
				return default(CircuitsTransformBehavior);
			}
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x87600D0", Offset = "0x875EED0", VA = "0x1887600D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		public bool BKFFHBZVBXX
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x875F9A0", Offset = "0x875E7A0", VA = "0x18875F9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public Vector3 VADZNPUXIUQ
		{
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x875FAB0", Offset = "0x875E8B0", VA = "0x18875FAB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		public Vector3 BUMZAFMWQYG
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x87603E0", Offset = "0x875F1E0", VA = "0x1887603E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		public bool YDEUWHWMJEV
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x875FE00", Offset = "0x875EC00", VA = "0x18875FE00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		public bool OZZZIYHBUHB
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x875FB80", Offset = "0x875E980", VA = "0x18875FB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		private EntityManager YONVSXFRQLZ
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x875C930", Offset = "0x875B730", VA = "0x18875C930")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x875F940", Offset = "0x875E740", VA = "0x18875F940")]
		public bool IVXGGZUSPYZ(ObjectPolicyEnum a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x8760300", Offset = "0x875F100", VA = "0x188760300")]
		public void UJXQFFWENSR(ObjectPolicyEnum a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x8760190", Offset = "0x875EF90", VA = "0x188760190")]
		public bool TERGRJPVJVR(ObjectPolicyUserConfigurableFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x875FA30", Offset = "0x875E830", VA = "0x18875FA30")]
		public void MIJJGVHHLRN(ObjectPolicyUserConfigurableFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x875FD80", Offset = "0x875EB80", VA = "0x18875FD80")]
		public ObjectPolicyUserConfigurableFlags QCGPCBYVOWY()
		{
			return default(ObjectPolicyUserConfigurableFlags);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x8760460", Offset = "0x875F260", VA = "0x188760460")]
		public bool ZAIBPMBBOQI(ObjectPolicyUserConfigurableFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectPolicy(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x875F7D0", Offset = "0x875E5D0", VA = "0x18875F7D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectPolicy other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public readonly struct RRObjectReferenceGroup : IEquatable<RRObjectReferenceGroup>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		private LEPIMHUDGGB SPYDVQOXTQW
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x8761030", Offset = "0x875FE30", VA = "0x188761030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8760DF0", Offset = "0x875FBF0", VA = "0x188760DF0")]
		public bool MISCOMXZETQ(ReferenceGroupKind a, List<RRObject> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x8760540", Offset = "0x875F340", VA = "0x188760540")]
		public int AJMBQFVFNMT(ReferenceGroupKind a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x8760BB0", Offset = "0x875F9B0", VA = "0x188760BB0")]
		public void HFHXAALVKIF(List<RRObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x8760700", Offset = "0x875F500", VA = "0x188760700")]
		public int CEFOTAJSKFG(RRObject a, ReferenceGroupKind b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x8760CC0", Offset = "0x875FAC0", VA = "0x188760CC0")]
		public RRObject HFUJJFVFNLX(int a, ReferenceGroupKind b)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x87608E0", Offset = "0x875F6E0", VA = "0x1887608E0")]
		public void DEUMCULOXRI(RRObject a, ReferenceGroupKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x8760650", Offset = "0x875F450", VA = "0x188760650")]
		public bool BJRXIMAFKZE(RRObject a, ReferenceGroupKind b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8760F20", Offset = "0x875FD20", VA = "0x188760F20")]
		public void OXXACXZQRHX(ReferenceGroupKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8760830", Offset = "0x875F630", VA = "0x188760830")]
		public bool CJMWLQZLLHD(RRObject a, ReferenceGroupKind b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x8760AA0", Offset = "0x875F8A0", VA = "0x188760AA0")]
		public bool FZCVURSHNDL(ReferenceGroupKind a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectReferenceGroup(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8760A10", Offset = "0x875F810", VA = "0x188760A10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectReferenceGroup other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public readonly struct RRObjectRenderEffects : IEquatable<RRObjectRenderEffects>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x8761090", Offset = "0x875FE90", VA = "0x188761090")]
		public void BXFWOOLOIVK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x87611B0", Offset = "0x875FFB0", VA = "0x1887611B0")]
		public void UHTMCDNKMNK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x3CB58A0", Offset = "0x3CB46A0", VA = "0x183CB58A0")]
		public a IWZLSMQFHHA<a>() where a : struct
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectRenderEffects(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8761120", Offset = "0x875FF20", VA = "0x188761120", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectRenderEffects other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public readonly struct RRObjectReplicatedObject : IEquatable<RRObjectReplicatedObject>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000176")]
		public bool OYYFUYTYIKX
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x8761240", Offset = "0x8760040", VA = "0x188761240")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x8761390", Offset = "0x8760190", VA = "0x188761390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		public bool GHCVNPTNVGM
		{
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x8761310", Offset = "0x8760110", VA = "0x188761310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		public int DLDOVBSMONP
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x87613E0", Offset = "0x87601E0", VA = "0x1887613E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x8761420", Offset = "0x8760220", VA = "0x188761420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectReplicatedObject(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x8761280", Offset = "0x8760080", VA = "0x188761280", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectReplicatedObject other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public readonly struct RRObjectReplicator : IEquatable<RRObjectReplicator>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		public int CIGKYRMCYQG
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x8761580", Offset = "0x8760380", VA = "0x188761580")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x87616A0", Offset = "0x87604A0", VA = "0x1887616A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		public int RWLORVJMRWU
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x87614B0", Offset = "0x87602B0", VA = "0x1887614B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x8761600", Offset = "0x8760400", VA = "0x188761600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public uint GGUJFTYIDVA
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x87615C0", Offset = "0x87603C0", VA = "0x1887615C0")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x8761650", Offset = "0x8760450", VA = "0x188761650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectReplicator(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x87614F0", Offset = "0x87602F0", VA = "0x1887614F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectReplicator other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public readonly struct RRObjectScope : IEquatable<RRObjectScope>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		private PCMOINDZJPK YZXOFIUUNAA
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x8761BF0", Offset = "0x87609F0", VA = "0x188761BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		private BVIRYCJVSGI LUSHMEERXLU
		{
			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x8761ED0", Offset = "0x8760CD0", VA = "0x188761ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public bool YETJCOYQDVK
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x87617C0", Offset = "0x87605C0", VA = "0x1887617C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public bool CKMNEJMFWXT
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x87618F0", Offset = "0x87606F0", VA = "0x1887618F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public bool JEBPVYJDWXA
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x8761A20", Offset = "0x8760820", VA = "0x188761A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public bool QRAIRCCKDZI
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x87616F0", Offset = "0x87604F0", VA = "0x1887616F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public bool UIXBCWWXDTO
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x8761CC0", Offset = "0x8760AC0", VA = "0x188761CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public bool LLEKBFYDDGX
		{
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x8761B60", Offset = "0x8760960", VA = "0x188761B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public bool VUNCNELCGCN
		{
			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x87620A0", Offset = "0x8760EA0", VA = "0x1887620A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public bool GGGEZEHNSVS
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x8761F30", Offset = "0x8760D30", VA = "0x188761F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public bool QLOMWMYBKJN
		{
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x8761DA0", Offset = "0x8760BA0", VA = "0x188761DA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8761C50", Offset = "0x8760A50", VA = "0x188761C50")]
		public bool RRPHMCJRWDI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x8761850", Offset = "0x8760650", VA = "0x188761850")]
		public RRObject AYMMLDVOXZG(RRObject a)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8761A50", Offset = "0x8760850", VA = "0x188761A50")]
		public ObjectLocalId MHPXWJSDUEE()
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8761CF0", Offset = "0x8760AF0", VA = "0x188761CF0")]
		public bool WSZAEAGRFRW(ObjectLocalId a, [Out] ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectScope(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x8758D80", Offset = "0x8757B80", VA = "0x188758D80")]
		public static implicit operator bool(RRObjectScope value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x8761990", Offset = "0x8760790", VA = "0x188761990", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectScope other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public readonly struct RRObjectShape : IEquatable<RRObjectShape>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly RRObjectShape Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public EShapeType SBZIHDDMMGM
		{
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x8763460", Offset = "0x8762260", VA = "0x188763460")]
			get
			{
				return default(EShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public RenderableColor QNWAOOGPRMS
		{
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x8763050", Offset = "0x8761E50", VA = "0x188763050")]
			get
			{
				return default(RenderableColor);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x8763090", Offset = "0x8761E90", VA = "0x188763090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public RenderableMaterial KDKSVXRWXGW
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x87633D0", Offset = "0x87621D0", VA = "0x1887633D0")]
			get
			{
				return default(RenderableMaterial);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x8762FC0", Offset = "0x8761DC0", VA = "0x188762FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public float GBMOQRLISTM
		{
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x8763010", Offset = "0x8761E10", VA = "0x188763010")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x87634F0", Offset = "0x87622F0", VA = "0x1887634F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public Vector3 PVKAIXMDSPN
		{
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x87632D0", Offset = "0x87620D0", VA = "0x1887632D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x87630E0", Offset = "0x8761EE0", VA = "0x1887630E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public float YCJEZHFHCJP
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x8763280", Offset = "0x8762080", VA = "0x188763280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public ShapeConfigFlags IFSMXXDVHYY
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x8763240", Offset = "0x8762040", VA = "0x188763240")]
			get
			{
				return default(ShapeConfigFlags);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x87631F0", Offset = "0x8761FF0", VA = "0x1887631F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public bool SCLLBHDVYKG
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x8763540", Offset = "0x8762340", VA = "0x188763540")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x8763580", Offset = "0x8762380", VA = "0x188763580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public RRObjectTransform ZCGASSMNTRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public RRObjectHierarchy RJNDZUANLLI
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x8763410", Offset = "0x8762210", VA = "0x188763410")]
		public RRObjectShapePrimitive PXFJNEVGJPG()
		{
			return default(RRObjectShapePrimitive);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x87634A0", Offset = "0x87622A0", VA = "0x1887634A0")]
		public RRObjectShapeSpline XEWLCNDBVDA()
		{
			return default(RRObjectShapeSpline);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x8762F70", Offset = "0x8761D70", VA = "0x188762F70")]
		private bool AFDNCIYOEMK(ShapeConfigFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x8763350", Offset = "0x8762150", VA = "0x188763350")]
		public void MBNZXBGAFTV(ShapeConfigFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectShape(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x8758D80", Offset = "0x8757B80", VA = "0x188758D80")]
		public static implicit operator bool(RRObjectShape value)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x8754DE0", Offset = "0x8753BE0", VA = "0x188754DE0")]
		public static bool CQBJVGKOTGK(RRObjectShape a, RRObjectShape b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x8763160", Offset = "0x8761F60", VA = "0x188763160", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectShape other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public readonly struct RRObjectShapePrimitive : IEquatable<RRObjectShapePrimitive>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public RRObjectShape RFYZWZQREQI
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectShape);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		public PrimitiveShapeType SFRVHRRRFXS
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x8762240", Offset = "0x8761040", VA = "0x188762240")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectShapePrimitive(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x8758D80", Offset = "0x8757B80", VA = "0x188758D80")]
		public static implicit operator bool(RRObjectShapePrimitive value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x8762280", Offset = "0x8761080", VA = "0x188762280", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectShapePrimitive other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public readonly struct RRObjectShapeSpline : IEquatable<RRObjectShapeSpline>
	{
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly RRObjectShapeSpline Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		private YJFNKXDMHIC PSUVDGMAKQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x8762510", Offset = "0x8761310", VA = "0x188762510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public RRObjectShape RFYZWZQREQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectShape);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public SplineParameters CKJXVHAPUFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x8762950", Offset = "0x8761750", VA = "0x188762950")]
			get
			{
				return default(SplineParameters);
			}
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x8762D40", Offset = "0x8761B40", VA = "0x188762D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		public IEnumerable<RRObjectSplinePoint> KXQUJRGQFQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x8762310", Offset = "0x8761110", VA = "0x188762310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		public RRObjectSplinePoint this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x8762E60", Offset = "0x8761C60", VA = "0x188762E60")]
			get
			{
				return default(RRObjectSplinePoint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		public int ODIIXCYNYBM
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x8762690", Offset = "0x8761490", VA = "0x188762690")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		public RRObjectTransform ZCGASSMNTRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x8762B20", Offset = "0x8761920", VA = "0x188762B20")]
		public RRObjectSplinePoint TIHQEOECWVV(float3? a, [Optional] quaternion? b, [Optional] Vector3? c)
		{
			return default(RRObjectSplinePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x8762720", Offset = "0x8761520", VA = "0x188762720")]
		public RRObjectSplinePoint Insert(int index, float3? position, [Optional] quaternion? rotation, [Optional] Vector3? scale)
		{
			return default(RRObjectSplinePoint);
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x8762A80", Offset = "0x8761880", VA = "0x188762A80")]
		public void PSNHEXCBCXI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x8762570", Offset = "0x8761370", VA = "0x188762570")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectShapeSpline(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x8758D80", Offset = "0x8757B80", VA = "0x188758D80")]
		public static implicit operator bool(RRObjectShapeSpline value)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x875A080", Offset = "0x8758E80", VA = "0x18875A080")]
		public static bool GFBRUTYEXQF(RRObjectShapeSpline a, RRObjectShapeSpline b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x8762600", Offset = "0x8761400", VA = "0x188762600", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectShapeSpline other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public readonly struct RRObjectSplinePoint : IEquatable<RRObjectSplinePoint>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		public RRObjectShapeSpline JKCSUSDTABE
		{
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x87638F0", Offset = "0x87626F0", VA = "0x1887638F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public float3 CXGUXRWHWJH
		{
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x8763720", Offset = "0x8762520", VA = "0x188763720")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x87636C0", Offset = "0x87624C0", VA = "0x1887636C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public quaternion ULETLHGROGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x8763890", Offset = "0x8762690", VA = "0x188763890")]
			get
			{
				return default(quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x8763670", Offset = "0x8762470", VA = "0x188763670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public float3 NPJLVZIDVVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x8763780", Offset = "0x8762580", VA = "0x188763780")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x8763830", Offset = "0x8762630", VA = "0x188763830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public FractionalIndex ZFMCEUROCTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x87637E0", Offset = "0x87625E0", VA = "0x1887637E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x87638E0", Offset = "0x87626E0", VA = "0x1887638E0")]
		public void YHMYEUMCFFO(RRObjectShapeSpline a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectSplinePoint(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x87635E0", Offset = "0x87623E0", VA = "0x1887635E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectSplinePoint other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public readonly struct RRObjectStudioObject : IEquatable<RRObjectStudioObject>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public bool UCTNCRSOLHS
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x8763A00", Offset = "0x8762800", VA = "0x188763A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectStudioObject(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x8763970", Offset = "0x8762770", VA = "0x188763970", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectStudioObject other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public readonly struct RRObjectTerrain : IEquatable<RRObjectTerrain>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly RRObjectTerrain Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		private GCTDGLBCMYO UARBQLCBIPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x87643A0", Offset = "0x87631A0", VA = "0x1887643A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public uint RSDPWQUKWGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0x8764550", Offset = "0x8763350", VA = "0x188764550")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x8763AC0", Offset = "0x87628C0", VA = "0x188763AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public TerrainLayerRoughness ZUGFPJPTYDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0x8764510", Offset = "0x8763310", VA = "0x188764510")]
			get
			{
				return default(TerrainLayerRoughness);
			}
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0x8763FB0", Offset = "0x8762DB0", VA = "0x188763FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public float BYCNDXSFCAP
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x87642D0", Offset = "0x87630D0", VA = "0x1887642D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0x8764350", Offset = "0x8763150", VA = "0x188764350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public float JNTATVDNWKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0x8764310", Offset = "0x8763110", VA = "0x188764310")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x8763F60", Offset = "0x8762D60", VA = "0x188763F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public TerrainPlayAreaShape BGREKEQBMIR
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x8763E10", Offset = "0x8762C10", VA = "0x188763E10")]
			get
			{
				return default(TerrainPlayAreaShape);
			}
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x8764000", Offset = "0x8762E00", VA = "0x188764000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		public float SXNWGRWDEXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x8764590", Offset = "0x8763390", VA = "0x188764590")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x8764050", Offset = "0x8762E50", VA = "0x188764050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		public float RBDDVBQUGLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x87644C0", Offset = "0x87632C0", VA = "0x1887644C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public float DWAKQFGVYOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x8764290", Offset = "0x8763090", VA = "0x188764290")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public float JKKGDJFKQBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x8763E50", Offset = "0x8762C50", VA = "0x188763E50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x8763C20", Offset = "0x8762A20", VA = "0x188763C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public RenderableColor FLBQLYDHRJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x8763F20", Offset = "0x8762D20", VA = "0x188763F20")]
			get
			{
				return default(RenderableColor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x8763C70", Offset = "0x8762A70", VA = "0x188763C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public RenderableColor EWKHREVNTLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x8763CC0", Offset = "0x8762AC0", VA = "0x188763CC0")]
			get
			{
				return default(RenderableColor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x8763A70", Offset = "0x8762870", VA = "0x188763A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public float SHSMDMYIIME
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x8764210", Offset = "0x8763010", VA = "0x188764210")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x8764610", Offset = "0x8763410", VA = "0x188764610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public TerrainWaterMaterial SHPYQDTHUEL
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x8764250", Offset = "0x8763050", VA = "0x188764250")]
			get
			{
				return default(TerrainWaterMaterial);
			}
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x87640A0", Offset = "0x8762EA0", VA = "0x1887640A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public WaterOverrides RLCZEMMTABN
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0x87645D0", Offset = "0x87633D0", VA = "0x1887645D0")]
			get
			{
				return default(WaterOverrides);
			}
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0x8763D00", Offset = "0x8762B00", VA = "0x188763D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public ReadOnlySpan<TerrainGenerationLayer> BBKJVRMUCXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0x8764400", Offset = "0x8763200", VA = "0x188764400")]
			get
			{
				return default(ReadOnlySpan<TerrainGenerationLayer>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x8763B10", Offset = "0x8762910", VA = "0x188763B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public ReadOnlySpan<TerrainCustomMaterialLayer> WHGUCKBMCZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x8763D50", Offset = "0x8762B50", VA = "0x188763D50")]
			get
			{
				return default(ReadOnlySpan<TerrainCustomMaterialLayer>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x87640F0", Offset = "0x8762EF0", VA = "0x1887640F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectTerrain(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xE23440", Offset = "0xE22240", VA = "0x180E23440")]
		public static implicit operator ObjectLocalId(RRObjectTerrain value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x8763E90", Offset = "0x8762C90", VA = "0x188763E90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectTerrain other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public readonly struct RRObjectToolCleanup : IEquatable<RRObjectToolCleanup>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		private AQFNVNFACOH BTJIIBDXGJA
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x8765150", Offset = "0x8763F50", VA = "0x188765150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public bool PNGENHLKHBT
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x8764B10", Offset = "0x8763910", VA = "0x188764B10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0x8764ED0", Offset = "0x8763CD0", VA = "0x188764ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public bool WMGYTMWFCME
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0x8764B60", Offset = "0x8763960", VA = "0x188764B60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x8764AB0", Offset = "0x87638B0", VA = "0x188764AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public float XUGOSONBTBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x8765200", Offset = "0x8764000", VA = "0x188765200")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x8764D50", Offset = "0x8763B50", VA = "0x188764D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public bool HWWNUIUNFUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x8764FB0", Offset = "0x8763DB0", VA = "0x188764FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x87647B0", Offset = "0x87635B0", VA = "0x1887647B0")]
		public void CBGFCMHPCME(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x8764C40", Offset = "0x8763A40", VA = "0x188764C40")]
		public bool NBHYDVMNWJZ([Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x87648E0", Offset = "0x87636E0", VA = "0x1887648E0")]
		public void ForceCleanup(bool forceImmediate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x87651B0", Offset = "0x8763FB0", VA = "0x1887651B0")]
		public bool TXYKBUZXDQX(ToolCleanupFlags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x8764F30", Offset = "0x8763D30", VA = "0x188764F30")]
		public void REVHYPANCPG(ToolCleanupFlags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8764660", Offset = "0x8763460", VA = "0x188764660")]
		public void BQPGWHBABSF(float a, float b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8765000", Offset = "0x8763E00", VA = "0x188765000")]
		public void RTFUNRYBEIK(float3 a, quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x8764DA0", Offset = "0x8763BA0", VA = "0x188764DA0")]
		public bool PDGMKTPVQDH([Out] float3 a, [Out] quaternion b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x8764980", Offset = "0x8763780", VA = "0x188764980")]
		public bool IQPIBSZYYRR([Out] float a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x8764BB0", Offset = "0x87639B0", VA = "0x188764BB0")]
		public void MCLYPXUNCMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectToolCleanup(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x8764850", Offset = "0x8763650", VA = "0x188764850", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectToolCleanup other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public readonly struct RRObjectTransform : IEquatable<RRObjectTransform>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		private EXAUPGCZURX ULVXDDWATYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x8766480", Offset = "0x8765280", VA = "0x188766480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public Vector3 CXGUXRWHWJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0x8766390", Offset = "0x8765190", VA = "0x188766390")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0x87662C0", Offset = "0x87650C0", VA = "0x1887662C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public Quaternion ULETLHGROGA
		{
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0x8766B30", Offset = "0x8765930", VA = "0x188766B30")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x8765EB0", Offset = "0x8764CB0", VA = "0x188765EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public Vector3 VTURVASEHGS
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x8765680", Offset = "0x8764480", VA = "0x188765680")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x8765DA0", Offset = "0x8764BA0", VA = "0x188765DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public Quaternion JVZSZDWWIJF
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0x8767030", Offset = "0x8765E30", VA = "0x188767030")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0x8765990", Offset = "0x8764790", VA = "0x188765990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public float QIBDAKMVXVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x8766C80", Offset = "0x8765A80", VA = "0x188766C80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x8765240", Offset = "0x8764040", VA = "0x188765240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public float PXKDFCBPUTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0x8766D20", Offset = "0x8765B20", VA = "0x188766D20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public Matrix4x4 TGPXKBXVQCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0x8765E70", Offset = "0x8764C70", VA = "0x188765E70")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public RRObjectHierarchy RJNDZUANLLI
		{
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObjectHierarchy);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		private IFXBBMDUCGM QMAFFUGLXDD
		{
			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x87554F0", Offset = "0x87542F0", VA = "0x1887554F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x8765D50", Offset = "0x8764B50", VA = "0x188765D50")]
		public RRTransform IAAPLBJRSCB()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x8765F80", Offset = "0x8764D80", VA = "0x188765F80")]
		public void KPQDTEWAURN([Out] Matrix4x4 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x8766600", Offset = "0x8765400", VA = "0x188766600")]
		public void QMCDHUBAEYN([In] Vector3 localPosition, [In] Quaternion localRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x8766540", Offset = "0x8765340", VA = "0x188766540")]
		public void QMCDHUBAEYN([In] RigidTransform parentFromLocal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x8765BB0", Offset = "0x87649B0", VA = "0x188765BB0")]
		public void HOTMANMFBUN([Out] RigidTransform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x8766DC0", Offset = "0x8765BC0", VA = "0x188766DC0")]
		public void VSXFFBUTKPU([In] Vector3 worldPosition, [In] Quaternion worldRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x8766EC0", Offset = "0x8765CC0", VA = "0x188766EC0")]
		public void VSXFFBUTKPU([In] RigidTransform worldFromLocal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x8765820", Offset = "0x8764620", VA = "0x188765820")]
		public void DRHBNDRKBNA([Out] Vector3 a, [Out] Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x8765770", Offset = "0x8764570", VA = "0x188765770")]
		public void DRHBNDRKBNA([Out] RigidTransform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x8766A40", Offset = "0x8765840", VA = "0x188766A40")]
		public UniformTRS TCFKTXBTWFE()
		{
			return default(UniformTRS);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x8766A70", Offset = "0x8765870", VA = "0x188766A70")]
		public void TCFKTXBTWFE([Out] UniformTRS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x8765C60", Offset = "0x8764A60", VA = "0x188765C60")]
		public UniformTRS HZTMSETEVVZ()
		{
			return default(UniformTRS);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x8765C90", Offset = "0x8764A90", VA = "0x188765C90")]
		public void HZTMSETEVVZ([Out] UniformTRS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x8765440", Offset = "0x8764240", VA = "0x188765440")]
		public Vector3 COOVVXFFXGX()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x8766700", Offset = "0x8765500", VA = "0x188766700")]
		public void SetLocalPosition([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x8766130", Offset = "0x8764F30", VA = "0x188766130")]
		public Vector3 MZMGMKHIXDK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x87668A0", Offset = "0x87656A0", VA = "0x1887668A0")]
		public void SetWorldPosition([In] Vector3 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x87652F0", Offset = "0x87640F0", VA = "0x1887652F0")]
		public Quaternion CELDCDKPAES()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x87667D0", Offset = "0x87655D0", VA = "0x1887667D0")]
		public void SetLocalRotation([In] Quaternion value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x8765530", Offset = "0x8764330", VA = "0x188765530")]
		public Quaternion DCURWOMIKIB()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x8766970", Offset = "0x8765770", VA = "0x188766970")]
		public void SetWorldRotation([In] Quaternion value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x8766220", Offset = "0x8765020", VA = "0x188766220")]
		public float NESBOXSENCO()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x8766F80", Offset = "0x8765D80", VA = "0x188766F80")]
		public void WXTZSIJIBSC(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x8765A60", Offset = "0x8764860", VA = "0x188765A60")]
		public float GBHKHOJZBUB()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x8765B00", Offset = "0x8764900", VA = "0x188765B00")]
		public void GEXZGCCIDZL(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x87660A0", Offset = "0x8764EA0", VA = "0x1887660A0")]
		public Vector3 MUVVYPFABJC([In] Vector3 direction)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectTransform(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x8765900", Offset = "0x8764700", VA = "0x188765900", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectTransform other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public readonly struct RRObjectUserTags : IEquatable<RRObjectUserTags>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		private TTHWVJUJREK ORVDVGTELFB
		{
			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x8767180", Offset = "0x8765F80", VA = "0x188767180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public RRObject MDARDOCKORS
		{
			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		private PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x87571A0", Offset = "0x8755FA0", VA = "0x1887571A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x8767270", Offset = "0x8766070", VA = "0x188767270")]
		public void KSDPMRMBJHU(string a, NativeObjectLocalIdList b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRObjectUserTags(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x87671E0", Offset = "0x8765FE0", VA = "0x1887671E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRObjectUserTags other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x8757320", Offset = "0x8756120", VA = "0x188757320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public readonly struct RRScene : IEquatable<RRScene>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public NetworkCreatorId MIESNHTBXVS
		{
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x8769330", Offset = "0x8768130", VA = "0x188769330")]
			get
			{
				return default(NetworkCreatorId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRScene(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x87692A0", Offset = "0x87680A0", VA = "0x1887692A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRScene other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public readonly struct RRSceneEntityRemap : IEquatable<RRSceneEntityRemap>
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		public struct RetainScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private ObjectLocalId localId;

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x8769780", Offset = "0x8768580", VA = "0x188769780")]
			public RetainScope(ObjectLocalId localId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x87696F0", Offset = "0x87684F0", VA = "0x1887696F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x87688A0", Offset = "0x87676A0", VA = "0x1887688A0")]
		public RetainScope XISPWYHSVAC()
		{
			return default(RetainScope);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x8768660", Offset = "0x8767460", VA = "0x188768660")]
		public EntityRemapArray OYYMSJUCYFZ(Allocator a = Allocator.Temp)
		{
			return default(EntityRemapArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x8768750", Offset = "0x8767550", VA = "0x188768750")]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> RZVHFZVUOYP(Allocator a = Allocator.Temp)
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x87689E0", Offset = "0x87677E0", VA = "0x1887689E0")]
		public NativeArray<ObjectNetworkId> YJSBOBVCHQI(Allocator a = Allocator.Temp)
		{
			return default(NativeArray<ObjectNetworkId>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x8768930", Offset = "0x8767730", VA = "0x188768930")]
		public NativeArray<ObjectNetworkId> XPTNAMWTXKN(Allocator a = Allocator.Temp)
		{
			return default(NativeArray<ObjectNetworkId>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x8768B50", Offset = "0x8767950", VA = "0x188768B50")]
		public NativeObjectLocalIdArray ZNKHPBIBCMT(Allocator a = Allocator.Temp)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x8768A90", Offset = "0x8767890", VA = "0x188768A90")]
		public NativeObjectLocalIdArray YNKFRKHLCDA(Allocator a = Allocator.Temp)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x87685A0", Offset = "0x87673A0", VA = "0x1887685A0")]
		public NativeObjectLocalIdArray MQYBJWETSVC(Allocator a = Allocator.Temp)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRSceneEntityRemap(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x8768510", Offset = "0x8767310", VA = "0x188768510", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRSceneEntityRemap other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x8768880", Offset = "0x8767680", VA = "0x188768880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public struct SceneLoadResultMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public int objectCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public int removeCount;
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public readonly struct RRSceneLoadOperation : IEquatable<RRSceneLoadOperation>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public RRSceneEntityRemap OBJZUUKZLUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRSceneEntityRemap);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public RRSceneLoadResult FKHMXBGPVWG
		{
			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRSceneLoadResult);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public RRScene BFBURDFRFXT
		{
			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRScene);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x8768F70", Offset = "0x8767D70", VA = "0x188768F70")]
		public bool RRCZNYTQABK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x8769010", Offset = "0x8767E10", VA = "0x188769010")]
		public bool RYISCVKTXMQ([Out] Exception a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRSceneLoadOperation(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xE23440", Offset = "0xE22240", VA = "0x180E23440")]
		public static implicit operator ObjectLocalId(RRSceneLoadOperation value)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x8768EE0", Offset = "0x8767CE0", VA = "0x188768EE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRSceneLoadOperation other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x8768880", Offset = "0x8767680", VA = "0x188768880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public readonly struct RRSceneLoadOperationSubgraph : IDisposable, IEquatable<RRSceneLoadOperationSubgraph>
	{
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static readonly Log log;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public static readonly RRSceneLoadOperationSubgraph Null;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public RRSceneLoadOperation OWGPXQYHHAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRSceneLoadOperation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public RRSceneEntityRemap OBJZUUKZLUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(RRSceneEntityRemap);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x8768D70", Offset = "0x8767B70", VA = "0x188768D70")]
		public void MBSCRISZQAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x8768C10", Offset = "0x8767A10", VA = "0x188768C10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRSceneLoadOperationSubgraph(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x8768CE0", Offset = "0x8767AE0", VA = "0x188768CE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "5")]
		public bool Equals(RRSceneLoadOperationSubgraph other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x8768DF0", Offset = "0x8767BF0", VA = "0x188768DF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public readonly struct RRSceneLoadResult : IEquatable<RRSceneLoadResult>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly ObjectLocalId objectId;

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public bool UZKYUOUBILF
		{
			[Cpp2IlInjected.Token(Token = "0x60004EC")]
			[Cpp2IlInjected.Address(RVA = "0x8769180", Offset = "0x8767F80", VA = "0x188769180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public ObjectLocalId IVAUJLECKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60004EE")]
			[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x13F0310", Offset = "0x13EF110", VA = "0x1813F0310")]
		public RRSceneLoadResult(ObjectLocalId localId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x87551C0", Offset = "0x8753FC0", VA = "0x1887551C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x8769210", Offset = "0x8768010", VA = "0x188769210", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x8754EF0", Offset = "0x8753CF0", VA = "0x188754EF0", Slot = "4")]
		public bool Equals(RRSceneLoadResult other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x8768880", Offset = "0x8767680", VA = "0x188768880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public static class DKLNTGXCGNF
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		private struct EntityGuidInterop
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public Guid guid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public ObjectGuid objectGuid;
		}

		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private struct ObjectGuid
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public int value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public int creator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int magic;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int reserved;

			[Cpp2IlInjected.Token(Token = "0x60004F5")]
			[Cpp2IlInjected.Address(RVA = "0x8754730", Offset = "0x8753530", VA = "0x188754730")]
			public bool RKOXVFKXGMK([Out] ObjectNetworkId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0x87547D0", Offset = "0x87535D0", VA = "0x1887547D0")]
			public ObjectGuid(ObjectNetworkId networkId)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x8750800", Offset = "0x874F600", VA = "0x188750800")]
		public static Guid LAYNCMAFJKT(this ObjectNetworkId a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x87507E0", Offset = "0x874F5E0", VA = "0x1887507E0")]
		public static bool BRIEJAATMPJ(this Guid a, [Out] ObjectNetworkId b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	internal static class IPRASTAHCGF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x8751F20", Offset = "0x8750D20", VA = "0x188751F20")]
		public static PPHCIOWDSWA VVMOCOFCZRB(this ObjectLocalId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x87520F0", Offset = "0x8750EF0", VA = "0x1887520F0")]
		public static SZFQCFKOOYF World(this ObjectLocalId id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x8752150", Offset = "0x8750F50", VA = "0x188752150")]
		public static EntityManager YONVSXFRQLZ(this ObjectLocalId a)
		{
			return default(EntityManager);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x3992060", Offset = "0x3990E60", VA = "0x183992060")]
		internal static bool VMMJVWLJIFR<a>(this ObjectLocalId a, bool b) where a : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x8751FB0", Offset = "0x8750DB0", VA = "0x188751FB0")]
		public static bool WZTCFPLCWEY(this ObjectLocalId a, NetworkProperty b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x3992160", Offset = "0x3990F60", VA = "0x183992160")]
		public static bool YYWCCJYZURD<b>(this ObjectLocalId a) where b : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x3991D40", Offset = "0x3990B40", VA = "0x183991D40")]
		public static bool RYGCSHMRXLJ<c>(this ObjectLocalId a) where c : struct, IBufferElementData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x3991B40", Offset = "0x3990940", VA = "0x183991B40")]
		[MustUseRefValueWithoutStoring]
		internal static NativeArray<T> RHNPXELMQJM<T>(this ObjectLocalId a, Allocator b) where T : struct, IBufferElementData
		{
			return default(NativeArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x3991450", Offset = "0x3990250", VA = "0x183991450")]
		[MustUseRefValueWithoutStoring]
		public static T GOLDKTRQLQG<T>(this ObjectLocalId a) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x3991040", Offset = "0x398FE40", VA = "0x183991040")]
		[MustUseRefValueWithoutStoring]
		public static d GMVAGROLODM<d>(this ObjectLocalId a) where d : struct, IComponentData
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x3991820", Offset = "0x3990620", VA = "0x183991820")]
		public static bool RBEPABJHSGA<e>(this ObjectLocalId a, [Out] e b) where e : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x3990EB0", Offset = "0x398FCB0", VA = "0x183990EB0")]
		public static f EYLJVCFKNMJ<f>(this ObjectLocalId a) where f : struct, IComponentData
		{
			return (f)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x3990CA0", Offset = "0x398FAA0", VA = "0x183990CA0")]
		public static g CQVYEYNWVXK<g>(this ObjectLocalId a) where g : class, IComponentData
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	internal static class ALCVTKFVCIO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[DefaultMember("Item")]
	public struct EntityRemapArray : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private NativeObjectLocalIdArray src;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private NativeArray<EntityRemapUtility.EntityRemapInfo> srcToDst;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x6638530", Offset = "0x6637330", VA = "0x186638530")]
		public EntityRemapArray(NativeObjectLocalIdArray src, NativeArray<EntityRemapUtility.EntityRemapInfo> srcToDst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x8750A00", Offset = "0x874F800", VA = "0x188750A00")]
		public LocalId XJGNOBCSEPC(LocalId a)
		{
			return default(LocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x87509A0", Offset = "0x874F7A0", VA = "0x1887509A0")]
		public LocalId XJGNOBCSEPC(int a)
		{
			return default(LocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x8750930", Offset = "0x874F730", VA = "0x188750930", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface XCEMBZHBKBS
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool YGOGOEMAYAJ(ObjectLocalId a, [Out] uint b);

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool YSDIJLJYQOB(ObjectLocalId a, [Out] uint b);

		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void QCEKXJKPDEM(ObjectLocalId a, uint b);

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TLGOOVOILQR(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		string WKSQQBYOKQH(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UFDQYRLFHKT(ObjectLocalId a, string b);

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool UBSVOXDVDMA(ObjectLocalId a, [Out] string b);

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void VRJLQHHKQEN(ObjectLocalId a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface QKTMHUGAQKV
	{
		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		Guid ZZGDKUVKCGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		Guid IHVALVVXITC
		{
			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool JQARSGFVHAW(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task EXDUQXNZPDQ(RRObject a);

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Guid DXJHWXEXTQZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NVIRLHBYLOI(ObjectLocalId a, Guid b);

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZXASDWABFPO(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task XOQBSCRITMP(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void ASSXDOZKWQK(ObjectLocalId a, ObjectNetworkId b);
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface HKUNFWESBMV
	{
		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		Guid ZZGDKUVKCGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PSQJYCNNMCD(NativeList<Guid> a, NativeList<Guid> b, NativeList<FixedString64Bytes> c);
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface RGPWUWVTNVZ
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NativeObjectLocalIdArray MULCEHMGBLI(Allocator a);

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NativeObjectLocalIdArray ZODNPPBSDVJ(Allocator a);

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ZOFNJBYZXFA(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool GHCVNPTNVGM(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool MHINUSTNUUK(ObjectLocalId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool OYYFUYTYIKX(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void MXFSFWOIATF(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ObjectLocalId EVNXIIGDLEO(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void JOIJASUUQCG(NativeObjectLocalIdArray a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool WTMTUCUIZMR(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void BDNCKIAUQTN(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(Slot = "11")]
		int GVGPHRMWRXU();

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void OFECMCIKJJT(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface TSMXUIUWALV
	{
		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<ObjectLocalId, ObjectLocalId> TVDEDBHEKRJ;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<ObjectLocalId, ObjectLocalId> CZKPLFYCAWJ;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action<ObjectLocalId, ObjectLocalId, ObjectLocalId> TKZBPRHBVML;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<ObjectLocalId> XDSUVTGRHNY;

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool FZMMUTVRQUP(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(Slot = "9")]
		ObjectLocalId CSPHYGWZCKP(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(Slot = "10")]
		NativeObjectLocalIdArray PLBBDCBLAJC(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ObjectLocalId XMCQSFPZHUL(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void HYIAXAAWGWP(ObjectLocalId a, Vector3 b, Quaternion c);

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void PDOUWKJXJJK(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool KBPUQJEYJLM(ObjectLocalId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool OAKXLCUNZKU(ObjectLocalId a, [Out] RigidTransform b);

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(Slot = "16")]
		float3 XHNNZAXAZFS(RRObjectConnectable a);

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(Slot = "17")]
		quaternion GLACIXMBOFD(RRObjectConnectable a);
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public static class OHKWOXMAKQN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface JRIVMXHNTMB
	{
		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		object ARBLXFXOOYD
		{
			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface CFWSNMTSYOV
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MMAQBFJWIEZ(ObjectLocalId a, EWAFJUGBLPN b);

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void TQWLNZJZGDE(EWAFJUGBLPN a);

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool XXWLJQAEWEY(ObjectLocalId a, [Out] EWAFJUGBLPN b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface EHQQQIWYBZP
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BVKFGQXOTUQ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NativeArray<ObjectLocalId> YJSPJDVUWHQ();
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[Flags]
	public enum DescendantFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		IncludeSelf = 1,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		IncludeChildren = 2,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		IncludeDescendants = 6,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		IncludeMask = 7,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		Disembodied = 8,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		Embodied = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		IgnoreEmbodiment = 0x18,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		EmbodimentMask = 0x18,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		Runtime = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Authored = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		AuthoredAndRuntime = 0x60,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		HierarchyMask = 0x60,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		HintInputsAreDisjoint = 0x80
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface KTTTBDOTNAX
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public ref struct SnapPointPreviewInformation
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public ReadOnlySpan<ObjectLocalId> MyPoints;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public ReadOnlySpan<ObjectLocalId> NearbyPoints;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public ObjectLocalId ProposedSnapPointSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public ObjectLocalId ProposedSnapPointOther;
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool STXLRMUZGXG(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ZHFATBNJWAC(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool ZYSQQKTDMJE(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool BSXMTETYPEZ(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool YPSMCWKLVQH(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool FOZSNGRGZMB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ObjectLocalId ILBBNBJVUJJ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ReadOnlySpan<ObjectLocalId> XPUHJFCXNJR(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(Slot = "8")]
		ReadOnlySpan<ObjectLocalId> SLBMPYLWQBI(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(Slot = "9")]
		SnapPointPreviewInformation LGSDPPFJRBU(ObjectLocalId a, float b, float c);

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool HBTTRRYXYTI(ObjectLocalId a, [Out] ElementGroupStatusData b);

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void ZBPZVKSZKKC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void PFWELKLGXPD(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public readonly struct GameConfig<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly T defaultValue;

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x5191400", Offset = "0x5190200", VA = "0x185191400")]
		public GameConfig(T defaultValue, [Optional][CallerMemberName] string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[Obfuscation(ApplyToMembers = false)]
	public static class GameConfigs
	{
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public static readonly GameConfig<int> VJAMSLMPDLR;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static readonly GameConfig<int> FOUMJTCWKDR;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public static readonly GameConfig<int> RTERKLLOTUB;
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum GameConfigState
	{
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Disabled,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Enabled,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		Indeterminate
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public static class ZCDTTUAJOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x1533FB0", Offset = "0x1532DB0", VA = "0x181533FB0")]
		public static bool IsEnabled(this GameConfigState state)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x1957770", Offset = "0x1956570", VA = "0x181957770")]
		public static bool CKXZRFOLEWX(this GameConfigState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x31E1CF0", Offset = "0x31E0AF0", VA = "0x1831E1CF0")]
		public static bool BFDKLPSNLQM(this GameConfigState a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x1533FC0", Offset = "0x1532DC0", VA = "0x181533FC0")]
		public static bool IGIAUFBKXYZ(this GameConfigState a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface PBWKXABXJCX
	{
		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		public enum State
		{
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			Unloaded,
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			Loading,
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			Loaded,
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			Error
		}

		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		public enum EditReadyPreference
		{
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			Default,
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			NeverEditReady,
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			AlwaysEditReady
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		State QPYRKVAGBLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		bool CJVIDEOJLDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		bool MRKQWDMPDWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		EditReadyPreference DOKGPROGSLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[ServiceLifetime(Lifetime.Application)]
	public interface YKVXTTWXELH
	{
		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		GameConfigState QNWMZLNXQJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		GameConfigState LUBMAOTWKKI
		{
			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		GameConfigState QSNWEVSAPCT
		{
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		GameConfigState BLWAZTTLFVI
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		GameConfigState ZUBBKABHSBH
		{
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		GameConfigState VNRJDSMVVFZ
		{
			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		GameConfigState RIMJKRMYJKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		GameConfigState LONVUCYLFXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		GameConfigState POOMKDBNPGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		GameConfigState PDCFDEBOIEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		GameConfigState ZCRBGZNOHUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		GameConfigState QXGSERAGFMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		GameConfigState BFUODMXVYEW
		{
			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		GameConfigState OUNCVNYKVAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		GameConfigState KGBKKQMJWZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		GameConfigState VHQKTMJQCVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000200")]
		GameConfigState SVGNMZHFFGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		GameConfigState INCVVAVGVOI
		{
			[Cpp2IlInjected.Token(Token = "0x600056A")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		GameConfigState FTCGMCCQKLL
		{
			[Cpp2IlInjected.Token(Token = "0x600056B")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		GameConfigState EGERWWHFSZN
		{
			[Cpp2IlInjected.Token(Token = "0x600056C")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int Get(GameConfig<int> config);
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface BZGADCICSKQ
	{
		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event YONCIKKMAZO.ParentsChangedCallback YRPDOCLJOMA;

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ObjectLocalId YVLRESRTARH(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(Slot = "3")]
		NativeObjectLocalIdArray WQAYXURXVEK(Allocator a);

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(Slot = "4")]
		FractionalIndex MUTLGZDAVOL(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool QXAYLRPEUDE(IEnumerable<ObjectLocalId> a);

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(Slot = "6")]
		FractionalIndex Move(ObjectLocalId parent, ObjectLocalId src, bool isBefore, ObjectLocalId target);

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ObjectLocalId FNNREFPRWPL(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool SetParent(ObjectLocalId localId, ObjectLocalId parent, bool worldPositionStays = false);

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool BLSRRQDBSXT(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool EYCZEKKYUES(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(Slot = "11")]
		[Obsolete("Use IHierarchyService.GetChildren() instead")]
		NativeObjectLocalIdArray QYQHHDVKBNL(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool SCHYEYDLLWW(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		NativeObjectLocalIdArray NQNOBYSJRCL(NativeObjectLocalIdArray a, DescendantFlags b, Allocator c);

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool VBQIFQZDXVK(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		ObjectLocalId GFUXHYTJHOD(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool LHJLUBCCTIS(ObjectLocalId a, ObjectLocalId b, [Out] ObjectLocalId c);

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ObjectLocalId QNLCKNLICGN(ObjectLocalId[] a);

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		ObjectLocalId PMCIWUVFEGM(ObjectLocalId a, uint b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public static class LSJYEHWVGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x87524D0", Offset = "0x87512D0", VA = "0x1887524D0")]
		public static bool MGSTXVDYFSV(this BZGADCICSKQ a, ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x8752540", Offset = "0x8751340", VA = "0x188752540")]
		public static NativeObjectLocalIdArray NQNOBYSJRCL(this BZGADCICSKQ a, ObjectLocalId b, DescendantFlags c, Allocator d)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x8752450", Offset = "0x8751250", VA = "0x188752450")]
		public static NativeObjectLocalIdArray EQOVXXZHPQR(this BZGADCICSKQ a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x8752490", Offset = "0x8751290", VA = "0x188752490")]
		public static NativeObjectLocalIdArray LFJOITZNVGO(this BZGADCICSKQ a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x8752410", Offset = "0x8751210", VA = "0x188752410")]
		public static NativeObjectLocalIdArray CPMGBAWUOPT(this BZGADCICSKQ a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x87523D0", Offset = "0x87511D0", VA = "0x1887523D0")]
		public static NativeObjectLocalIdArray CKDXTDCAATG(this BZGADCICSKQ a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x87527D0", Offset = "0x87515D0", VA = "0x1887527D0")]
		public static NativeObjectLocalIdArray OAKDFYPPCSK(this BZGADCICSKQ a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x8752930", Offset = "0x8751730", VA = "0x188752930")]
		public static NativeObjectLocalIdArray VNMLFKALUBO(this BZGADCICSKQ a, ObjectLocalId b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x8752810", Offset = "0x8751610", VA = "0x188752810")]
		public static NativeObjectLocalIdArray VNMLFKALUBO(this BZGADCICSKQ a, NativeObjectLocalIdArray b, Allocator c)
		{
			return default(NativeObjectLocalIdArray);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface RICTBNCIKVM
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x87570B0", Offset = "0x8755EB0", VA = "0x1887570B0", Slot = "0")]
		Task<RRSceneLoadOperation> LoadMain(SerializedDataWrapper serializedDataWrapper, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "1")]
		void IJENLLNVSJO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface YHANXQPWHRR
	{
		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event YONCIKKMAZO.ParentsChangedCallback YRPDOCLJOMA;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ObjectLocalId FNNREFPRWPL(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ReadOnlySpan<ObjectLocalId> LJRUSWLQKUV();

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ReadOnlySpan<ObjectLocalId> ZKWYRFXDONE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool UJOCRWMWURL(ObjectLocalId a, ObjectLocalId b, [Out] FractionalIndex c);

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool KBLDVVMOFPW(ObjectLocalId a, ObjectLocalId b, [Out] FractionalIndex c);

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool DXPOWOGXGWA(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool BLSRRQDBSXT(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(Slot = "9")]
		FractionalIndex SJGACPGLQYX(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ZFMABQZXVTW
	{
		[Cpp2IlInjected.Token(Token = "0x17000204")]
		bool FQWQRUNMVEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		bool RYHHHFPPMKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		bool NAFHRBQWMAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface IJPWYARILBE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface FKPHJWQMEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HGHAXGESENF(ObjectLocalId a, NetworkProperty b);

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MQTUULYUOEC(ObjectLocalId a, NetworkProperty b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface OEHSBPDDFUE
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RentedArray<string> LBVJLSOZDON(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RentedArray<string> IIJNKEASWEK(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EKVXDTNSRLE(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FWDEHHGMCRP(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool AAEKKNGNHOE(ObjectLocalId a, ObjectLocalId b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface VCVVUGNIYDA
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		InteractionFilterMode GMINCBEXDAY(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EJWWTXMRAAQ(ObjectLocalId a, InteractionFilterMode b);

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool XFFOQZEDHFS(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XMPLLAVZGVS(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RentedArray<string> MQSNXFFIMAU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void VFKYDYJZMTK(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		RentedArray<string> NOXHPPCCBFI(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void RPXANKSRUZQ(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		RentedArray<string> PBWCOJUDVEW(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void FYOFYDCLAKK(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		RentedArray<string> CNWMEXOMPVK(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void GHLFXFILTGM(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool HDOCPHCGFUC(ObjectLocalId a, ObjectLocalId b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface OFREOUEUENL
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Raycast([In] float3 origin, [In] float3 direction, float maxDistance, [Out] RayIntersection intersection, [Out] ObjectLocalId spline);

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int OverlapSphere([In] float3 origin, float radius, List<ObjectLocalId> localIds);

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int UNFONQJHDLO(Plane[] a, float3 b, float3 c, quaternion d, List<ObjectLocalId> e);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface NYTDCIFHOIP
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Raycast([In] NativeArray<Entity> entities, [In] float3 origin, [In] float3 direction, [In] NativeArray<RayIntersection> outRayIntersections);

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NativeList<Entity> OverlapSphere([In] NativeArray<Entity> entities, [In] float3 origin, float radius);

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NativeList<Entity> UNFONQJHDLO([In] NativeArray<Entity> entities, [In] NativeArray<float4> frustumPlanes);
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public struct PhysicsSceneColliderHandle : VJTUBMNJJFG, IEquatable<PhysicsSceneColliderHandle>
	{
		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0xDB2230", Offset = "0xDB1030", VA = "0x180DB2230", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x15B1800", Offset = "0x15B0600", VA = "0x1815B1800", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		public int Version
		{
			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x30206B0", Offset = "0x301F4B0", VA = "0x1830206B0", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x30206C0", Offset = "0x301F4C0", VA = "0x1830206C0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x8757010", Offset = "0x8755E10", VA = "0x188757010", Slot = "8")]
		public bool Equals(PhysicsSceneColliderHandle other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8757060", Offset = "0x8755E60", VA = "0x188757060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public struct RayIntersection
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public float distance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float3 normal;
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface QVHAUZWHZIW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface IFXBBMDUCGM
	{
		[Cpp2IlInjected.Token(Token = "0x17000209")]
		PPHCIOWDSWA VVMOCOFCZRB
		{
			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		ObjectServiceHandle XJPEJQJRXTX
		{
			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		int AGSTDBHEBXV
		{
			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		int YVUUYTWZTBI
		{
			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		int SWOYJWRUHSA
		{
			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		int XYQNQELPUJH
		{
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		int OIPKUUGCBVE
		{
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<NativeObjectLocalIdArray, NativeArray<RRObjectPrefabData>> BPDSLNANJTB;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event Action<NativeObjectLocalIdArray> JBNTICZYHDJ;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(Slot = "11")]
		NativeObjectLocalIdArray SKVNGVXKTAY();

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(Slot = "12")]
		ObjectType NDPDQPASSQG(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(Slot = "13")]
		RRObjectPrefabData BSGRMTQEBQD(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void KQPDOAJBBHB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(Slot = "15")]
		RRObject Embody(ObjectLocalId localId);

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool HFWNYWTCPPK(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool DWWHRYTNZAU(ObjectLocalId a, [Out] Transform b);

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(Slot = "18")]
		ObjectLocalId HKHTFBTSQSF(ObjectNetworkId a);

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(Slot = "19")]
		bool NPWGZBCSYYC(ObjectNetworkId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(Slot = "20")]
		ObjectNetworkId RYRXUIOMNDS(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(Slot = "21")]
		NativeObjectLocalIdArray HKHTFBTSQSF(NativeArray<ObjectNetworkId> a, Allocator b, bool c = true);

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool XDXMLWUPMEG(NativeArray<ObjectCreationData> a, NativeArray<ObjectNetworkId> b, NativeArray<Entity> c, RentedArray<EENTYBRXPZV> d);

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(Slot = "23")]
		RRObject QUVPVDAFKUP();

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(Slot = "24")]
		RRObject CreateObject(RRObjectPrefabData prefabType, [Optional] CreationInstantiationParameters instantiationParameters);

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(Slot = "25")]
		RRObjectContainer WQJSHVOYMEC();

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(Slot = "26")]
		RRObjectShapeSpline ZVUKUSNFYIW();

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(Slot = "27")]
		RRObjectShapePrimitive ACVDJXYFIJC(PrimitiveShapeType a);

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void TOEZZUKKOGY(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void VMNBCQOLEDH(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(Slot = "30")]
		bool CIMWKSBSHPV(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		NativeObjectLocalIdArray CKGAWMQWAKJ(NativeObjectLocalIdArray a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(Slot = "32")]
		bool Exists(ObjectLocalId localId);

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(Slot = "33")]
		bool WVTWNEPXJKJ(ObjectLocalId a, ComponentTypeSet b);

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(Slot = "34")]
		ObjectLocalId LFKDPOZYASY(Transform a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public static class PGDVZSGYZTH
	{
		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x8756570", Offset = "0x8755370", VA = "0x188756570")]
		internal static ObjectLocalId CXYLGCSOTIQ(this Entity a, IFXBBMDUCGM b)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x8756880", Offset = "0x8755680", VA = "0x188756880")]
		public static RRObject KVCYOSESDOW(this IFXBBMDUCGM a, LocalId b)
		{
			return default(RRObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x8756620", Offset = "0x8755420", VA = "0x188756620")]
		public static ObjectLocalId HKHTFBTSQSF(this IFXBBMDUCGM a, LocalId b)
		{
			return default(ObjectLocalId);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x8756C20", Offset = "0x8755A20", VA = "0x188756C20")]
		public static ObjectNetworkId RYRXUIOMNDS(this IFXBBMDUCGM a, LocalId b)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x87566D0", Offset = "0x87554D0", VA = "0x1887566D0")]
		public static RRObjectContainer IXTSSUROYBM(this IFXBBMDUCGM a, RigidTransform b)
		{
			return default(RRObjectContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x8756A70", Offset = "0x8755870", VA = "0x188756A70")]
		public static RRObjectShapePrimitive OVJNIMVDHVC(this IFXBBMDUCGM a, PrimitiveShapeType b, RigidTransform c)
		{
			return default(RRObjectShapePrimitive);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x87568C0", Offset = "0x87556C0", VA = "0x1887568C0")]
		public static RRObjectShapeSpline OUFSCRVHUOO(this IFXBBMDUCGM a, RigidTransform b)
		{
			return default(RRObjectShapeSpline);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x8756890", Offset = "0x8755690", VA = "0x188756890")]
		private static void MHQOCSYLDKM(RRObject a, RigidTransform b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	internal interface ROIFPKDZPJD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface PCMOINDZJPK
	{
		[Cpp2IlInjected.Token(Token = "0x17000210")]
		bool FLWKBLMOVFV
		{
			[Cpp2IlInjected.Token(Token = "0x60005E5")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		ObjectLocalId ZMKJLLMVTFR
		{
			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		RRObject NYUUWTMEVAW
		{
			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event ScopeChangedEventHandler OKQCGSLVXIH;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ObjectLocalId GFUXHYTJHOD(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool LHJLUBCCTIS(ObjectLocalId a, ObjectLocalId b, [Out] ObjectLocalId c);

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void WMUSECIJDVZ();

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void WCFPASZXSJL();

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool YETJCOYQDVK(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool LLEKBFYDDGX(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public delegate void ScopeChangedEventHandler(RRObject oldScope, RRObject newScope);
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public static class XBHWLNYCUUW
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x876A0C0", Offset = "0x8768EC0", VA = "0x18876A0C0")]
		public static bool KUOQAOIPPAG(this PCMOINDZJPK a, RRObject b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x8769FE0", Offset = "0x8768DE0", VA = "0x188769FE0")]
		public static bool FSZHEZXIVUX(this PCMOINDZJPK a, ObjectLocalId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x876A110", Offset = "0x8768F10", VA = "0x18876A110")]
		public static bool QRAIRCCKDZI(this PCMOINDZJPK a, ObjectLocalId b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface FQXOTKNTBHT
	{
		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ERBMCBRYWGL(NativeList<RRObjectPrefabData> a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface LEPIMHUDGGB
	{
		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool MISCOMXZETQ(RRObject a, ReferenceGroupKind b, List<RRObject> c);

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int AJMBQFVFNMT(RRObject a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HFHXAALVKIF(RRObject a, List<RRObject> b);

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int CEFOTAJSKFG(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RRObject HFUJJFVFNLX(RRObject a, int b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void DEUMCULOXRI(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool BJRXIMAFKZE(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void OXXACXZQRHX(RRObject a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool CJMWLQZLLHD(RRObject a, RRObject b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void QOUOCDUBJEG(Entity a, Entity b, ReferenceGroupKind c);

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void XQZPZVKNBHK(Entity a, ReferenceGroupKind b);

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool FZCVURSHNDL(RRObject a, ReferenceGroupKind b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface BJDLKVYWDKR
	{
		[Cpp2IlInjected.Token(Token = "0x17000213")]
		RRScene BOZWASYBGCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NetworkCreatorId AHGZBMZFRDU(RRScene a);

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RRScene EJIGKZCFWKT();

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RRScene QQSMWCELFTB();
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface BVIRYCJVSGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool WSZAEAGRFRW(ObjectLocalId a, [Out] ObjectLocalId b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface XETUGOKRZXN
	{
		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<ObjectLocalId> DHLVKSGDHEY;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BXFWOOLOIVK(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void UHTMCDNKMNK(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void KCYCRVSVDRI(ObjectLocalId a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface YJFNKXDMHIC
	{
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ObjectLocalId> QZHTQMRLYQQ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ObjectLocalId BBFVSLEJLUE(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int VXYKYLFZXRO(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(Slot = "3")]
		SplineParameters JMEQHRKKWCZ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VQOGOLKSJMF(ObjectLocalId a, SplineParameters b);

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ObjectLocalId IKODQURQZRJ(ObjectLocalId a, [Optional] float3? b, [Optional] quaternion? c, [Optional] float3? d);

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ObjectLocalId MZUUWTMADEM(ObjectLocalId a, int b, [Optional] float3? c, [Optional] quaternion? d, [Optional] float3? e);

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void FBWTDEHBBYK(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void VGGXMNBEKMJ(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface JCSJQBBYZPB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface GCTDGLBCMYO
	{
		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CIKUSFGFKGN(ObjectLocalId a, ReadOnlySpan<TerrainGenerationLayer> b);

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EZQRAKNVNRU(ObjectLocalId a, ReadOnlySpan<TerrainCustomMaterialLayer> b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface GRQPXROFRUO
	{
		[Cpp2IlInjected.Token(Token = "0x17000214")]
		bool BJWULGWJHGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IPLPTTVELMK();

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CSMMTQIUCYL();

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NJAWGWNRNFR();

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NBKTGJFXAMM();

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void DLXHGRLWPXK();

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void AUNYAIGAGML();

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void NZRPDXHIYQV();

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void IKZDVZDBVLZ();

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void PDNMTGPIGJP();

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void IIJQIMXZCJD();

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void DVCEOICXAAE();

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void LMPWZAQBNXL();
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface AQFNVNFACOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NBHYDVMNWJZ(ObjectLocalId a, [Out] int b);

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CBGFCMHPCME(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ForceCleanup(ObjectLocalId target, bool forceImmediate);

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BQPGWHBABSF(ObjectLocalId a, float b, float c, float d);

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool IQPIBSZYYRR(ObjectLocalId a, [Out] float b, [Out] float c);

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void RTFUNRYBEIK(ObjectLocalId a, float3 b, quaternion c);

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool PDGMKTPVQDH(ObjectLocalId a, [Out] float3 b, [Out] quaternion c);

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void MCLYPXUNCMW(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface EXAUPGCZURX
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetLocalPosition(Entity entity, [In] float3 value);

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float3 COOVVXFFXGX(Entity a);

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetLocalRotation(Entity entity, [In] quaternion value);

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(Slot = "3")]
		quaternion CELDCDKPAES(Entity a);

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void QMCDHUBAEYN(Entity a, [In] float3 position, [In] quaternion rotation);

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HOTMANMFBUN(Entity a, [Out] RigidTransform b);

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void VSXFFBUTKPU(Entity a, [In] float3 position, [In] quaternion rotation);

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void DRHBNDRKBNA(Entity a, [Out] float3 b, [Out] quaternion c);

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void DRHBNDRKBNA(Entity a, [Out] RigidTransform b);

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void WXTZSIJIBSC(Entity a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(Slot = "10")]
		float NESBOXSENCO(Entity a);

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void SetWorldPosition(Entity entity, [In] float3 value);

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(Slot = "12")]
		float3 MZMGMKHIXDK(Entity a);

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void SetWorldRotation(Entity entity, [In] quaternion value);

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		quaternion DCURWOMIKIB(Entity a);

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void GEXZGCCIDZL(Entity a, float b);

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		float GBHKHOJZBUB(Entity a);

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void HUIKELURUBJ(Entity a, [Out] float4x4 b);

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void PVTRLXFTSAP(Entity a, [In] float4x4 localToWorld);

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void NotifyTransformParentChanged(Entity entity);

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void KEQBESCBJWM(Entity a, Entity b, Entity c);
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public static class IMEGGIHZIHR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface WWHRYNEFNJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TTVXFKFBYQF(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface TTHWVJUJREK
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HLENENOQUMN(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ANNRQNZYAOH(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NYBWTYKTUGR(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TPAGMQWDKID(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void TCSLSGGGECG(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AJYLICHLQLC(ObjectLocalId a, RentedArray<string> b);

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(Slot = "6")]
		int OAZZFKSANIQ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		int AOQXFLGVHFH(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		int JVUMJIDIGWT(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		ODUSMGRZXRA<string> NJXAGNKDYON(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool LBCWVCLXOSR(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ODUSMGRZXRA<string> ACJGTGTHEEH(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool RNGYEPRNQNQ(ObjectLocalId a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void QXXXYVMSGMO(string a, NativeObjectLocalIdList b);

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(Slot = "14")]
		ObjectLocalId ZKATAHIJAQT(string a);

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void OCGCPNWKOMH(string a, NativeObjectLocalIdList b);

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void KSDPMRMBJHU(ObjectLocalId a, string b, NativeObjectLocalIdList c);

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ODUSMGRZXRA<string> CWRKPVMMZHU();
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public static class LXPXONRCVSZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface MXCBASDOTYO
	{
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(Slot = "0")]
		World BHLEEXEVQES(string a = "Main");

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(Slot = "1")]
		World WQTZMRVYYOZ(string a = "Shadow");

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(Slot = "2")]
		World SSWVLQYAHYQ(string a = "Deserialization");

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(Slot = "3")]
		World WMSPTSCMQEX(string a = "Serialization");
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface SZFQCFKOOYF
	{
		[Cpp2IlInjected.Token(Token = "0x17000215")]
		World MOULEUIPSUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000216")]
		World AUZAHXTSZHD
		{
			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		EntityManager YONVSXFRQLZ
		{
			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		bool EBUTVQAGWPR
		{
			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ComponentSystemBase NVIUTOFZJFC(Type a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public static class EUGLEVERSCK
	{
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x87508A0", Offset = "0x874F6A0", VA = "0x1887508A0")]
		public static ComponentSystemBase KIHKRYHZSIY(this World a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x37FCB80", Offset = "0x37FB980", VA = "0x1837FCB80")]
		public static a NVIUTOFZJFC<a>(this SZFQCFKOOYF a) where a : ComponentSystemBase
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface VLAIPEDRVTI
	{
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EKSNPCRQBJX(NativeListAsync<Entity> a);

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BDNCBVAQUDM(CollisionIslandGeneratorState a);

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EECJXJNDBTH(NativeListAsync<Entity> a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YRPBKYWLLTD();

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void XCIXGNNNWOM(Entity a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface MCFDKWZUEJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool ALTXVDBBLWD(Collider a, [Out] ObjectLocomotionSettings b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface GDKDINTBVFQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Collider UAYTYMFDOKN(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GameObject EZHOUXNNXBI(ObjectLocalId a, GameObject b, Vector3 c, Quaternion d);

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void XPTNEJVYIJO(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(Slot = "3")]
		a ZVCPAVTFKJW<a>(GameObject a) where a : Collider;

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IYNKCQTFIUW(Collider a);

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		GameObject KOZTXHSPZAE<b>(string a) where b : Collider;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		GWJELEULZNY RNQPTLWTUIL(ObjectLocalId a, ObjectLocalId b, PrimitiveShapeType c, float3 d, quaternion e, float3 f);

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool QSPTVGBOGVP(ObjectLocalId a, [Out] GWJELEULZNY b);

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool OAZKAKEXVJT(ObjectLocalId a, [Out] ObjectLocalId b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public enum ColliderType
	{
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		Sphere,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		Mesh,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		CapsuleX,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		CapsuleY,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		CapsuleZ,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		COUNT
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface XKJPFXFNYIO
	{
		[Cpp2IlInjected.Token(Token = "0x20000D8")]
		public struct ShapePrefab
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public int shapeType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public GameObject prefab;
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CKVANKNDVNG(ObjectLocalId a, CollisionLayerEnum b, bool c, PhysicsModelEnumFlags d);

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ZNDMJTYMHYC(ObjectLocalId a, CollisionLayerEnum b, bool c, bool d, bool e);

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MRVQTLEHMIH RFETYEWVXLO(ObjectLocalId a, List<ObjectLocalId> b);

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GWJELEULZNY EYXMZYTUCBB(GameObject a, GameObject b);

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZPBPYCDMPWJ(GameObject a, List<GameObject> b);

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void YZJRDAIFFYD(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "6")]
		a ZVCPAVTFKJW<a>(GameObject a) where a : Collider;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void IYNKCQTFIUW(Collider a);

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(Slot = "8")]
		GameObject LMECVTFRUPE<b>(string a) where b : Collider;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool SHOBHDWVWZX(Collider a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool VQKZXQCLNJB(ObjectLocalId a, [Out] ObjectLocomotionSettings b);

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		NativeArray<ColliderType> MTZMPVTJNGT(Allocator a = Allocator.TempJob);

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Mesh[] JHJKLEUHWUL();
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface UYDNSMPFFCO
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UBMOPDDJDKA(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AHKDMPERGNB(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int KQVVGCMFDFS(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ObjectLocalId OYWOMKKTERP(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(Slot = "4")]
		NativeObjectLocalIdArray EWRCSIOGPIZ(ObjectLocalId a, Allocator b = Allocator.Temp);

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UWQAKQMQYTZ(ObjectLocalId a, object b, ObjectLocalId c);

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void TPEELOKVEZW(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool PGRACBIWTRO(ObjectLocalId a, [Out] ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void OICFQWUNFSU(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool OJTPJINMRTY(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void OTPFPMNHZEJ(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool SMVKBIBJLCH(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void NJWZXAXBHOW(ObjectLocalId a, (Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(Slot = "13")]
		bool SMOBDQSPXBV(ObjectLocalId a, [Out] quaternion b, [Out] float3 c);

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void GSRZWFQWYOW(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
		float3 UWPWAVCBDEE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		float3 LFMOMQJRDHB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void KEPEOGEHDBZ(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void YQGNZUKGCWU(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		float GSKCPCCBOPP(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(Slot = "20")]
		float ANPSCFGBFAG(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void TIICNKTDISC(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void UGMISUPSMDB(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(Slot = "23")]
		CollisionDetectionMode KPGRMSZVBYN(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void FNAFEQCEXPL(ObjectLocalId a, CollisionDetectionMode b);

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(Slot = "25")]
		TransformTrackRate PXCJSYTVSSS(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void COZNJGTTIRA(ObjectLocalId a, TransformTrackRate b);

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool PNKRTMNHDMK(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void FHTRGDWJPAW(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(Slot = "29")]
		ObjectLocalId YVLRESRTARH(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void KGTCCNENHVH(ObjectLocalId a, ObjectLocalId b);

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		ObjectLocalId FNNREFPRWPL(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void SetParent(ObjectLocalId localId, ObjectLocalId value);

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(Slot = "33")]
		RbexInterpolationMode ZWCVXFAGUZF(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void IIGHMFOQJST(ObjectLocalId a, RbexInterpolationMode b);

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		bool SPQFOYTLRCQ(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void HBQZUUXIZFG(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(Slot = "37")]
		bool CCNFICONXBB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void DNSRSBDHFQH(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(Slot = "39")]
		RigidbodyConstraints QGYGLAECSOE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(Slot = "40")]
		void UKUSMOWRNAQ(ObjectLocalId a, RigidbodyConstraints b);

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(Slot = "41")]
		float FQDPNXJDTZB(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(Slot = "42")]
		void VXXVHXZHUZJ(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(Slot = "43")]
		float WNBEYBTVQKP(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(Slot = "44")]
		void VIUVAFFOFXV(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(Slot = "45")]
		bool VOZWHYTNDBS(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void AFUEUZMGQLG(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(Slot = "47")]
		bool JBTEAYRUXBD(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void DTWFOJDFQHH(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void DVMRXEZEAKB(ObjectLocalId a, int b);

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(Slot = "50")]
		TPQHYBXVCEA TPFVQHFDBMP(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void JZTVJBMJQPJ(ObjectLocalId a, TPQHYBXVCEA b);

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(Slot = "52")]
		XPPHMJGPLLF WARHIJVGCMG(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void IXHKCEURPNM(ObjectLocalId a, XPPHMJGPLLF b);

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(Slot = "54")]
		float RLBJNCIBMRM(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void CFKGKVQOXTQ(ObjectLocalId a, float b);

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(Slot = "56")]
		void SKZEXLVEPXJ(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void BOUHRKCOZQA(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(Slot = "58")]
		bool BJCILAHAQCP(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void RPIRGFPZVBP(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(Slot = "60")]
		void TJKSOISTQNC(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(Slot = "61")]
		bool NDNGYPRZTCL(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(Slot = "62")]
		bool MWVGJUHMLFN(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(Slot = "63")]
		Rigidbody GURMMGSWWQE(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(Slot = "64")]
		void MVGAHYJXROI(ObjectLocalId a, Rigidbody b);

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(Slot = "65")]
		void RHVNAXHJIII(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(Slot = "66")]
		void ZXDRGCLXBDF(ObjectLocalId a, object b);

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(Slot = "67")]
		bool DDXDXLACSBU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(Slot = "68")]
		void RCCOPDHKGCB(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(Slot = "69")]
		void TABTCSDMDBL(ObjectLocalId a, float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(Slot = "70")]
		bool ORLWEOMCIUA(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(Slot = "71")]
		bool SCRAELRDSNS(ObjectLocalId a, [Out] float3 b);

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(Slot = "72")]
		bool IXMTAWZSMUU(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(Slot = "73")]
		void QCUUUNSQYIL(ObjectLocalId a, object b, bool c);

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(Slot = "74")]
		void GREMRZNLTRX(ObjectLocalId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(Slot = "75")]
		void NJIRVZLNYCP(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(Slot = "76")]
		bool XXWCABSZBIE(ObjectLocalId a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface PAPHYNEOVHM
	{
		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZRFBBUKZKFK(Entity a);

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PPKPTMHGTLG(Entity a);

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void QHSJTZZIMGU(Entity a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface CFAMWMVINFS
	{
		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YYOYUEMBSNH(ObjectLocalId a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public delegate void BulkPropertyChangeCallback(BulkPropertyChangeData propertyChangeData);
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public readonly ref struct BulkPropertyChangeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly NativeObjectLocalIdArray objectIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly NativeArray<byte> prev;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly NativeArray<byte> curr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private readonly NetworkProperty property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly int propertySize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly Type propertyType;

		[Cpp2IlInjected.Token(Token = "0x17000219")]
		public NativeObjectLocalIdArray MGRJYEUFYYG
		{
			[Cpp2IlInjected.Token(Token = "0x60006D0")]
			[Cpp2IlInjected.Address(RVA = "0x42E9660", Offset = "0x42E8460", VA = "0x1842E9660")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		public int UFYFSTWLMQP
		{
			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0x87506C0", Offset = "0x874F4C0", VA = "0x1887506C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		public NetworkProperty DETGYEJXBPU
		{
			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0xAEE0C0", Offset = "0xAECEC0", VA = "0x180AEE0C0")]
			get
			{
				return default(NetworkProperty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x87506E0", Offset = "0x874F4E0", VA = "0x1887506E0")]
		public BulkPropertyChangeData(NativeObjectLocalIdArray objectIds, NativeArray<byte> prev, NativeArray<byte> curr, NetworkProperty property, int propertySize, Type propertyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x36D1DC0", Offset = "0x36D0BC0", VA = "0x1836D1DC0")]
		public NativeArray<a> LWKTEGACZTC<a>() where a : struct
		{
			return default(NativeArray<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x36D1CE0", Offset = "0x36D0AE0", VA = "0x1836D1CE0")]
		public NativeArray<b> HWZWBMPRLKW<b>() where b : struct
		{
			return default(NativeArray<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x36D1AC0", Offset = "0x36D08C0", VA = "0x1836D1AC0")]
		public (NativeObjectLocalIdArray, NativeArray<T>, NativeArray<T>) Get<T>() where T : struct
		{
			return default((NativeObjectLocalIdArray, NativeArray<T>, NativeArray<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x4ADFA50", Offset = "0x4ADE850", VA = "0x184ADFA50")]
		public ObjectIdBulkPropertyChangeData PXWTTCRRXYE()
		{
			return default(ObjectIdBulkPropertyChangeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public interface TREUMRAPIDL
	{
		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		string BJKGHCEYMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60006D7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		TREUMRAPIDL DDIRQYWSWLY
		{
			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		IEnumerable<TREUMRAPIDL> TMRIVESCZEL
		{
			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface FMNNIKHOIUY
	{
		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		TREUMRAPIDL OTSQPXLUWHU
		{
			[Cpp2IlInjected.Token(Token = "0x60006DA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		NativeArray<NetworkProperty> LYTNBSSWRZJ
		{
			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CVQGURGEWOT(NetworkProperty a, [Out] TREUMRAPIDL b);

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PUOFOOQAOVA(NetworkProperty a, BulkPropertyChangeCallback b);

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void UICJQLYJDWB(NetworkProperty a, BulkPropertyChangeCallback b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface XWZBFEEAVJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PUOFOOQAOVA(NetworkProperty a, BulkPropertyChangeCallback b);

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UICJQLYJDWB(NetworkProperty a, BulkPropertyChangeCallback b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public static class USFDMFKYFOZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface LVNKUOOAFFM
	{
		[Cpp2IlInjected.Token(Token = "0x17000221")]
		bool BRADKMDWHLK
		{
			[Cpp2IlInjected.Token(Token = "0x60006E1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60006E2")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		ReplicationData DNIYEBXMBPV
		{
			[Cpp2IlInjected.Token(Token = "0x60006E3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GZMIGIOSOPG(NetworkCreatorId a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool CQXSHYENVWV(ObjectNetworkId a, NetworkProperty b);

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SYNBLCDHCJE(NativeArray<ObjectNetworkId> a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public static class STTHBOQBOZW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public readonly ref struct ObjectIdBulkPropertyChangeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly BulkPropertyChangeData data;

		[Cpp2IlInjected.Token(Token = "0x17000223")]
		public NativeObjectLocalIdArray MGRJYEUFYYG
		{
			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0x42E9660", Offset = "0x42E8460", VA = "0x1842E9660")]
			get
			{
				return default(NativeObjectLocalIdArray);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x8754D60", Offset = "0x8753B60", VA = "0x188754D60")]
		public ObjectIdBulkPropertyChangeData(BulkPropertyChangeData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x8754C30", Offset = "0x8753A30", VA = "0x188754C30")]
		public NativeObjectLocalIdArray LWKTEGACZTC()
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x8754B00", Offset = "0x8753900", VA = "0x188754B00")]
		public NativeObjectLocalIdArray HWZWBMPRLKW()
		{
			return default(NativeObjectLocalIdArray);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x8754810", Offset = "0x8753610", VA = "0x188754810")]
		public (NativeObjectLocalIdArray, NativeObjectLocalIdArray, NativeObjectLocalIdArray) Get()
		{
			return default((NativeObjectLocalIdArray, NativeObjectLocalIdArray, NativeObjectLocalIdArray));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public static class WKIHVPPSUVQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public readonly struct ReplicationData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly NativeBitArray bitArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private readonly NativeParallelHashMap<ObjectNetworkId, int> bitOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly NativeParallelHashSet<NetworkCreatorId> denyCreatorIds;

		[Cpp2IlInjected.Token(Token = "0x17000224")]
		public bool GDGEUHMAOHV
		{
			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0x87696B0", Offset = "0x87684B0", VA = "0x1887696B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		public bool BRADKMDWHLK
		{
			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x8769680", Offset = "0x8768480", VA = "0x188769680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x87696D0", Offset = "0x87684D0", VA = "0x1887696D0")]
		public ReplicationData(NativeBitArray bitArray, NativeParallelHashMap<ObjectNetworkId, int> bitOffsets, NativeParallelHashSet<NetworkCreatorId> denyCreatorIds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x87694B0", Offset = "0x87682B0", VA = "0x1887694B0")]
		public bool CQXSHYENVWV(ObjectNetworkId a, NetworkProperty b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface ETJUKXVFZVF
	{
		[Cpp2IlInjected.Token(Token = "0x17000226")]
		OutlineEffectType VUEZVWMVIEG
		{
			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[ServiceLifetime(Lifetime.LoadInstance)]
	public interface MIBKHDOSYST
	{
		[Cpp2IlInjected.Token(Token = "0x17000227")]
		int LBPFKEGAQKL
		{
			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000228")]
		int VXSPUWKJYCC
		{
			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AXEHTXGLRMG(ObjectLocalId a, MutableRef b);

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RootHandle XDXIMTINPPK();

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		RootHandle DYXVUPGMTIL();
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface YWLPRIDMLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DGCZBONWQRO(World a);

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void TOGVCQXDEPG(World a);

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ComponentSystemBase RMQTVLSHULV(World a);

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TFVXRFQJVGL(World a);

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EXNMXFCAHLU(World a);

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LVEHDKOHDED(World a);

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void XIYMDYMKHXA(World a);

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		NativeParallelHashSet<ComponentTypeIndex> ZRRMRIKOLOB();
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface NBJXCKRMRKL
	{
		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BZWIZDISAHP(ObjectLocalId a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public readonly struct BulkInstantiationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly IEnumerable<InstantiationRequest> requests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly IReadOnlyList<GameObject> instantiations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly IReadOnlyList<int> requestIndexByInstantiation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly IReadOnlyList<(ObjectNetworkId, ObjectNetworkId)> srcDstNetworkIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly int rootCount;
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public struct InventionParameters
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public InventionIdData id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public InventionInstanceIdData instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public bool overwriteIdData;

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x8752380", Offset = "0x8751180", VA = "0x188752380")]
		public InventionParameters(long id, Guid instanceId, bool overwriteIdData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[ServiceLifetime(Lifetime.Application)]
	public interface GHYGBMJFDMR
	{
		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RRSceneLoadOperation HLUULBJCESD(SerializedDataWrapper a, int b = 0, bool c = false);

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(Slot = "1")]
		RRSceneLoadOperationSubgraph SNWPCGZBFOT(SerializedDataWrapper a, ObjectLocalId b, [In] UniformTRS parentFromWorldTransform, QYGQDFVECJC c, [Optional] InventionParameters d, bool e = true, bool f = false, bool g = false, bool h = false);

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PGZJQBLRFAP DVPTGPMSUBY();

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PGZJQBLRFAP DMSQHJBLQCE(NativeObjectLocalIdArray a, [In] UniformTRS serializedSceneFromCommonParentOfSerializedRoots, [Optional] QYGQDFVECJC b);

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool RRCZNYTQABK(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool RYISCVKTXMQ(ObjectLocalId a, [Out] Exception b);

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(Slot = "6")]
		NativeArray<ObjectNetworkId> YJSBOBVCHQI(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(Slot = "7")]
		NativeArray<ObjectNetworkId> XPTNAMWTXKN(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(Slot = "8")]
		NativeObjectLocalIdArray ZNKHPBIBCMT(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		NativeObjectLocalIdArray YNKFRKHLCDA(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		NativeObjectLocalIdArray QASGEEJZAFM(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		NativeArray<EntityRemapUtility.EntityRemapInfo> RZVHFZVUOYP(ObjectLocalId a, Allocator b);

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool ERLLNXVPKKR(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int UDENGVPYTLD(ObjectLocalId a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[ServiceLifetime(Lifetime.Application)]
	public interface JTKDNJUPETU
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xF93E70", Offset = "0xF92C70", VA = "0x180F93E70", Slot = "0")]
		bool JWCZNXMOHLN(object a, GJPMAIILVKQ b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public static class BUJITBBUVPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x87505E0", Offset = "0x874F3E0", VA = "0x1887505E0")]
		public static bool JWCZNXMOHLN(this JTKDNJUPETU a, object b, [Out] GJPMAIILVKQ c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public enum GamePropertyKey : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		MaxPlayers = 255,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		IsVisible = 254,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		IsOpen = 253,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		PlayerCount = 252,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		Removed = 251,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		PropsListedInLobby = 250,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		CleanupCacheOnLeave = 249,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		MasterClientId = 248,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		ExpectedUsers = 247,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		PlayerTtl = 246,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		EmptyRoomTtl = 245,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		HasDedicatedMaster = 87
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public interface GJPMAIILVKQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000229")]
		NetworkEventType QCFSUOQZRCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		PlayerId QMPBGCEBLTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022B")]
		bool FEENKQCDBVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022C")]
		bool CAKZGGDAFGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object QRSVHRQTYMF();

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool OALOSAVRTZT([Out] PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "6")]
		(PlayerId, object) HNGGQCKABCV()
		{
			return default((PlayerId, object));
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "7")]
		(ObjectNetworkId, PlayerId) MPLCDMPYYAZ()
		{
			return default((ObjectNetworkId, PlayerId));
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "8")]
		ZPKLXYDUXOG<(ObjectNetworkId, PlayerId)> OMZLIAQFCLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "9")]
		(OutOfBandMessageType, byte[]) NPDLQOAJRKU()
		{
			return default((OutOfBandMessageType, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "10")]
		(PacketSource, byte[]) NOOJPMVSJKD()
		{
			return default((PacketSource, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0", Slot = "11")]
		a EBMWESRKLGC<a>()
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public static class UFTGZPUSSVA
	{
		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x8769B70", Offset = "0x8768970", VA = "0x188769B70")]
		public static bool PISZJTHUUCF(this GJPMAIILVKQ a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public interface CBGPEORZFNO : ZPKLXYDUXOG<NetworkTransformSyncData>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public interface ZPKLXYDUXOG<a>
	{
		[Cpp2IlInjected.Token(Token = "0x1700022D")]
		a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		int UFYFSTWLMQP
		{
			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public enum NetworkEventType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		BulkInstantiate = 1,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		BulkDestroy = 2,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		OMSendPacket = 4,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		RR_OutOfBandMessage = 5,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		RR_FastForwardMarker = 6,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		RR_SelfJoinMarker = 7,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		RR_DebugOp = 10,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		RR_CachedEvent = 11,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		RRRoomRequestEvent = 20,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		RRRoomRequestFailedResponseEvent = 21,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		RRBufferedRoomEvent = 22,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		RRClearBufferedRoomEvent = 23,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		RR_CreationOp = 24,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		RR_CreationOpResponse = 25,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		RR_CreationOp_Unchecked = 26,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		RR_MasterLockBlockComplete = 27,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		RR_NetworkSynchronization = 28,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		RR_NetworkInstantiate = 29,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		RR_BulkInstantiate = 31,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		RR_Destroy = 32,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		RR_BulkDestroy = 33,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		RR_TransferOwnership = 34,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		RR_OwnershipUpdate = 35,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		RR_RPC = 36,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		RR_JoinRequest = 100,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		RR_JoinResponse = 101,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		RR_RoomUpdate = 102,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		RR_PlayerUpdate = 103,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		RR_RemotePlayerJoined = 104,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		RR_RemotePlayerLeft = 105,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		RR_Leave = 106,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		RPC = 200,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		SendSerialize = 201,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Instantiation = 202,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		CloseConnection = 203,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Destroy = 204,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		RemoveCachedRPCs = 205,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		SendSerializeReliable = 206,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		DestroyPlayer = 207,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		OwnershipRequest = 209,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		OwnershipTransfer = 210,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		VacantViewIds = 211,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		OwnershipUpdate = 212,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		AuthEvent = 223,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		LobbyStats = 224,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		AppStats = 226,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		Match = 227,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		QueueState = 228,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		GameListUpdate = 229,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		GameList = 230,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		CacheSliceChanged = 250,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		ErrorInfo = 251,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		PropertiesChanged = 253,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Leave = 254,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Join = 255
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public enum OutOfBandMessageType : uint
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		None = 0u,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		NetworkTransformInitializationData = 1314146628u,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		RestoreCreationData = 1380140064u,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		OldestCachedPacketId = 1329811529u,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		SnapshotPublished = 1397773634u,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		SnapshotPayload = 1397771332u,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		SnapshotClear = 1129337683u,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		RequestNetworkTransformInitialization = 1380865097u
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public static class FVBNDFHMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x8750EA0", Offset = "0x874FCA0", VA = "0x188750EA0")]
		public static ObjectNetworkId BQXLTSPPHVA(this ObjectNetworkIdComponentData a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x8750ED0", Offset = "0x874FCD0", VA = "0x188750ED0")]
		public static ObjectNetworkId LKNTJQRDBMY([In] this ObjectNetworkIdComponentData data)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x8591D80", Offset = "0x8590B80", VA = "0x188591D80")]
		public static ObjectNetworkId FPFLPYSBQYF(this ObjectNetworkIdComponentData a)
		{
			return default(ObjectNetworkId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x8591D80", Offset = "0x8590B80", VA = "0x188591D80")]
		public static ViewId MTUFWRVPEBU(this ObjectNetworkIdComponentData a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0x8751230", Offset = "0x8750030", VA = "0x188751230")]
		public static FixedString64Bytes TUMPLITSPCO(this NetworkCreatorId a)
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x8750F10", Offset = "0x874FD10", VA = "0x188750F10")]
		public static FixedString64Bytes PLEGQLQZEJL(this ObjectNetworkId a)
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x87511A0", Offset = "0x874FFA0", VA = "0x1887511A0")]
		public static FixedString32Bytes TUMPLITSPCO(this Entity a)
		{
			return default(FixedString32Bytes);
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface NQCAMTPGKJK : AKIAFFFHFEZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public enum OpCode
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		End,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Create,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		Destroy,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		SetProp,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		Event,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		COUNT
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface GITSWUVCFEG
	{
		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<object> TVWGNDQRMBQ;

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "2")]
		void AWFJNTYYDHK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "3")]
		void QSOPDUGNHRW(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		void LKJEVOHWZRM(OutOfBandMessageType a, ReadOnlySpan<byte> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface GDEXLANQWPU
	{
		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PacketSource WLZYIDARIBR(ReadOnlySpan<byte> a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface MDJLEMKMODB
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YYURBTEIQKW(PacketSource a, ReadOnlySpan<byte> b);

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SIKQNPCFFKM(ReadOnlySpan<PacketSource> a);
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public struct Chunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public PacketSource source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public ReadOnlyMemory<byte> payload;
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public struct PacketSource
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static PacketSource SnapshotPacketSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public NetworkCreatorId creatorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int packetId;

		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		public static NetworkCreatorId CFZWGOEBBGV
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0x8756C90", Offset = "0x8755A90", VA = "0x188756C90")]
			get
			{
				return default(NetworkCreatorId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x55733C0", Offset = "0x55721C0", VA = "0x1855733C0")]
		public PacketSource(NetworkCreatorId creatorId, int packetId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x8756DF0", Offset = "0x8755BF0", VA = "0x188756DF0")]
		public static bool GFBRUTYEXQF([In] PacketSource lhs, [In] PacketSource rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x8756CE0", Offset = "0x8755AE0", VA = "0x188756CE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x8756E80", Offset = "0x8755C80", VA = "0x188756E80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x8756EF0", Offset = "0x8755CF0", VA = "0x188756EF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x8756EE0", Offset = "0x8755CE0", VA = "0x188756EE0")]
		public void KAKPPNOMYGN([Out] NetworkCreatorId a, [Out] int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	public static class WQXVYVCOAAR
	{
	}
}
namespace RecRoom.ObjectModel.Interop
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	public struct InstantiationRequest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public string prefabName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Vector3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public Vector3 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int photonViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CreationInstantiationParameters parameters;

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x8752260", Offset = "0x8751060", VA = "0x188752260", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecRoom.ObjectModel.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	public enum DeserializationOperationType
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Player,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Scene,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		SubgraphAdditive,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		SubgraphRestore,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		RestoreCreationData,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		InventionPreview
	}
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	public static class LVNPNUQEFNR
	{
		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x8752980", Offset = "0x8751780", VA = "0x188752980")]
		public static bool EEWLAJSBJDT(this DeserializationOperationType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x87529A0", Offset = "0x87517A0", VA = "0x1887529A0")]
		public static bool EEZQNQTPCVH(this DeserializationOperationType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x8752970", Offset = "0x8751770", VA = "0x188752970")]
		public static bool CHTHMAXOYUT(this DeserializationOperationType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[Flags]
	public enum DeserializePhases
	{
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		ParseProtobuf = 1,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		PreInstantiate = 2,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		BulkInstantiate = 4,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		PostInstantiate = 8,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		NotifyInstantiated = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		DisposeProtobuf = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		NotifyCompleted = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		WorldPhasesClient = 0x7B,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		WorldPhases = 0x7B,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		AdditivePhases = 0x7B,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		RestoreCreationData = 0x2B
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	public interface QYGQDFVECJC
	{
		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool FWRHZDNATQB([In] Guid src, [Out] Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[Flags]
	public enum WorldDeserializePhases
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		Parse = 1,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		PreInstantiate = 2,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		BulkInstantiate = 4,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		PostInstantiate = 0x18,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		LoadCompleted = 0x60,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		All = 0x7F
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	public interface PGZJQBLRFAP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000230")]
		XIHGBJDDEER WPCPLWVWBIL
		{
			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ByteString UCRPRMJUHNT();
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public enum SerializationOperationType
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		World,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		Subgraph
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[TypeManager.ForcedStableTypeHash(8944033191217631913uL)]
	public struct LocalBoundsData : ICleanupComponentData, IComponentData, IEquatable<LocalBoundsData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public float3 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public float3 extents;

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x8752AA0", Offset = "0x87518A0", VA = "0x188752AA0", Slot = "4")]
		public bool Equals(LocalBoundsData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface BDOQDYECWIE
	{
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ReadOnlySpan<ObjectLocalId> JONOKACOBLC(ObjectLocalId a);

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MVXPUPKHDVU(ObjectLocalId a, [Out] ObjectLocalId b);
	}
}
namespace RecRoom.ObjectModel.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface OBTYFUQXNUM
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool NVRMYSKQWMX(long a);

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EJNKYHSQUGB(NativeParallelHashSet<long> a);

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EAWBZAVWEMX(World a, NativeParallelHashMap<Guid, long> b);

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool LIOCARLOXTC(ObjectNetworkId a);

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool APGAMDCRQVN(ObjectNetworkId a, [Out] Guid b, [Out] long c);

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void KUXLSOYYCBU(ObjectNetworkId a, Guid b, long c);

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool OXJVJHOIDZL(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool QGPMKKONXBY(Guid a, [Out] int b, [Out] int c);

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void YIMWDDIEICJ(Guid a, int b, int c);

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void DMCUEJONTCG(Guid a);
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
