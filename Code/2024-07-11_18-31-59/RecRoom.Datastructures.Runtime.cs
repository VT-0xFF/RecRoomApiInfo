using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x68AB770", Offset = "0x68AA170", VA = "0x1868AB770")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D9C0", Offset = "0x87C3C0", VA = "0x18087D9C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x87DA00", Offset = "0x87C400", VA = "0x18087DA00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OGEGJKMLCNM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x14DD360", Offset = "0x14DBD60", VA = "0x1814DD360")]
	public OGEGJKMLCNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, CEAGNJHJOCG, FOEMIFIPDHC, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851290", VA = "0x180852890", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851270", VA = "0x180852870", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x91F460", Offset = "0x91DE60", VA = "0x18091F460", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash BGMAOMLOOIC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8BEAE0", Offset = "0x8BD4E0", VA = "0x1808BEAE0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[ReadOnlyField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	[HideInInspector]
	[ReadOnlyField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68ACB70", Offset = "0x68AB570", VA = "0x1868ACB70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68ACB30", Offset = "0x68AB530", VA = "0x1868ACB30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x68ACBB0", Offset = "0x68AB5B0", VA = "0x1868ACBB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD60", Offset = "0x68AB760", VA = "0x1868ACD60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x68ACCD0", Offset = "0x68AB6D0", VA = "0x1868ACCD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8BEAD0", Offset = "0x8BD4D0", VA = "0x1808BEAD0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA90", Offset = "0x8BD490", VA = "0x1808BEA90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x68ACAF0", Offset = "0x68AB4F0", VA = "0x1868ACAF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x68ACC40", Offset = "0x68AB640", VA = "0x1868ACC40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68AC560", Offset = "0x68AAF60", VA = "0x1868AC560")]
	public void CopyBounds(SavedExtents OKGBBGMIACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68ACA40", Offset = "0x68AB440", VA = "0x1868ACA40")]
	public void SetLocalSpaceBounds(Bounds IFKDOLFNMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xBB0F20", Offset = "0xBAF920", VA = "0x180BB0F20")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68ACA30", Offset = "0x68AB430", VA = "0x1868ACA30")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x68AC590", Offset = "0x68AAF90", VA = "0x1868AC590")]
	private void ECNBNJLLBEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x68AC810", Offset = "0x68AB210", VA = "0x1868AC810")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68ABEF0", Offset = "0x68AA8F0", VA = "0x1868ABEF0")]
	public static void CalculateLocalBoundsFor(GameObject NBDLDMDNCAL, [Out] Bounds IFKDOLFNMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68AC750", Offset = "0x68AB150", VA = "0x1868AC750")]
	private static void IEHMKCEKBOJ(Bounds GANEOONFJPD, Color DDJHOHBDMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68ACA60", Offset = "0x68AB460", VA = "0x1868ACA60")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x850BA0", VA = "0x1808521A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x852910", Offset = "0x851310", VA = "0x180852910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xFD17C0", Offset = "0xFD01C0", VA = "0x180FD17C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4955D50", Offset = "0x4954750", VA = "0x184955D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "4")]
	public virtual void IBAMJKALAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	[OGEGJKMLCNM]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x49558D0", Offset = "0x49542D0", VA = "0x1849558D0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x49540E0", Offset = "0x4952AE0", VA = "0x1849540E0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4955C50", Offset = "0x4954650", VA = "0x184955C50")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class PLJLHLCOBLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public PLJLHLCOBLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4770560", Offset = "0x476EF60", VA = "0x184770560")]
		internal int GBKFKGKKNGO(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[OGEGJKMLCNM]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x380D810", Offset = "0x380C210", VA = "0x18380D810", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x380D870", Offset = "0x380C270", VA = "0x18380D870", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x380D6F0", Offset = "0x380C0F0", VA = "0x18380D6F0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey NDDCLPHCEEO]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x380D7B0", Offset = "0x380C1B0", VA = "0x18380D7B0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x380D5A0", Offset = "0x380BFA0", VA = "0x18380D5A0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x380D260", Offset = "0x380BC60", VA = "0x18380D260", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x380C680", Offset = "0x380B080", VA = "0x18380C680", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x380C650", Offset = "0x380B050", VA = "0x18380C650", Slot = "14")]
	protected virtual string IMEGMNFCIOH(TKeyVal HDDCDBLOLDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x380C4F0", Offset = "0x380AEF0", VA = "0x18380C4F0", Slot = "4")]
	public bool ContainsKey(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x380D420", Offset = "0x380BE20", VA = "0x18380D420", Slot = "5")]
	public bool TryGetValue(TKey NDDCLPHCEEO, [Out] TVal JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x380C550", Offset = "0x380AF50", VA = "0x18380C550", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x380C550", Offset = "0x380AF50", VA = "0x18380C550", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x380D480", Offset = "0x380BE80", VA = "0x18380D480")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NHJHDBAJGNN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class GMBLGKIIJEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float IOIJNMIIHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T JNHPIMBJPMJ;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public GMBLGKIIJEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class IBHPFKJNGPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public IBHPFKJNGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3E1A8C0", Offset = "0x3E192C0", VA = "0x183E1A8C0")]
		internal bool NPHOCHGOIIC(GMBLGKIIJEI sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float HCKDDPKCGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly float KJMCBPIHFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<GMBLGKIIJEI> LFOOMPFBGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CAJPHPCFPPJ<GMBLGKIIJEI> JIIKGPMGFHC;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int GJGOIKGCHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x450C380", Offset = "0x450AD80", VA = "0x18450C380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x450C3F0", Offset = "0x450ADF0", VA = "0x18450C3F0")]
	public NHJHDBAJGNN(float KJHHCJADBDH, float DHJINKLHOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x450B650", Offset = "0x450A050", VA = "0x18450B650")]
	public bool HMBECCONFBC(float HDCBOMJHFCH, T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x450BE00", Offset = "0x450A800", VA = "0x18450BE00")]
	public IEnumerable<T> IOMCBEOMABD(float HDCBOMJHFCH, [Optional] float? IALGELGJOKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x450B9E0", Offset = "0x450A3E0", VA = "0x18450B9E0")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x450C170", Offset = "0x450AB70", VA = "0x18450C170")]
	private void JPNMHHBOHFG(float HDCBOMJHFCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class OKINFAONJHL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct PPDEGLHINBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T JNHPIMBJPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float MOEHEJACJEH;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static float MPGMGLKLEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private List<T> MHBAABDANFO;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private const int PJPGAPLLDJA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private PPDEGLHINBJ[] PFKJAOOHGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int FGHIONIHMHA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float LCLMKPJCKGN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9A3BE0", Offset = "0x9A25E0", VA = "0x1809A3BE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9AC630", Offset = "0x9AB030", VA = "0x1809AC630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4661B60", Offset = "0x4660560", VA = "0x184661B60")]
	public OKINFAONJHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4661BA0", Offset = "0x46605A0", VA = "0x184661BA0")]
	public OKINFAONJHL(int ECGAAJFODGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4661900", Offset = "0x4660300", VA = "0x184661900")]
	public void PBLNBBGFGAP(float HDCBOMJHFCH, T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x46617C0", Offset = "0x46601C0", VA = "0x1846617C0")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4661140", Offset = "0x465FB40", VA = "0x184661140")]
	public bool BCABLAINCKG(float NCEEMEKPLHO, float GEHGKBEMJPC, [Out] T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4660AA0", Offset = "0x465F4A0", VA = "0x184660AA0")]
	public bool ADNNIEHGPNG(float NCEEMEKPLHO, float GEHGKBEMJPC, [Out] T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4661390", Offset = "0x465FD90", VA = "0x184661390")]
	public void DMHNGCDMEIP(float NCEEMEKPLHO, float GEHGKBEMJPC, List<T> PHMDIHEJOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x46616A0", Offset = "0x46600A0", VA = "0x1846616A0")]
	private int ECAMDGGGKKL(int FJGMLNHLPBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x46618B0", Offset = "0x46602B0", VA = "0x1846618B0")]
	private void OKIBDCKHELL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LIADPNCJBOP();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T KCBPOPNLEFI(T JMDCGOKJIDA, float DOGPFNGIKMO);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T GCKOMEIBJIG(T DIAAOCPNHKC, T LLLBDLGIMPP);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T JEGNKKKIMIH(T DIAAOCPNHKC, T LLLBDLGIMPP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class AILGIAAEDNM : OKINFAONJHL<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x862EA0", Offset = "0x8618A0", VA = "0x180862EA0", Slot = "4")]
	protected override Vector3 LIADPNCJBOP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x68A7B20", Offset = "0x68A6520", VA = "0x1868A7B20", Slot = "5")]
	protected override Vector3 KCBPOPNLEFI(Vector3 JMDCGOKJIDA, float DOGPFNGIKMO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x68A7A50", Offset = "0x68A6450", VA = "0x1868A7A50", Slot = "6")]
	protected override Vector3 GCKOMEIBJIG(Vector3 DIAAOCPNHKC, Vector3 LLLBDLGIMPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68A7AA0", Offset = "0x68A64A0", VA = "0x1868A7AA0", Slot = "7")]
	protected override Vector3 JEGNKKKIMIH(Vector3 DIAAOCPNHKC, Vector3 LLLBDLGIMPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x68A7B60", Offset = "0x68A6560", VA = "0x1868A7B60")]
	public AILGIAAEDNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FLHLDIOPFJL
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B16F90", Offset = "0x2B15990", VA = "0x182B16F90")]
	public static KKNLDOICDLK<T1, T2> JGIIBNEOBDO<T1, T2>(T1 BCCJLCECHOM, T2 HEMMFIBMKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B17020", Offset = "0x2B15A20", VA = "0x182B17020")]
	public static PLNCJGBCMBC<T1, T2, T3> JGIIBNEOBDO<T1, T2, T3>(T1 BCCJLCECHOM, T2 HEMMFIBMKDK, T3 EFGMBOCFEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x44E18C0", Offset = "0x44E02C0", VA = "0x1844E18C0")]
	internal static int EPAFINGNDJL(int HEOPLAHHFAB, int GJOFFMCMAIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5C58A20", Offset = "0x5C57420", VA = "0x185C58A20")]
	internal static int EPAFINGNDJL(int HEOPLAHHFAB, int GJOFFMCMAIA, int OAKJCPFALKN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KKNLDOICDLK<T1, T2> : IComparable<KKNLDOICDLK<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 MMILKMINAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 NDNGJEJEBEB;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4187830", Offset = "0x4186230", VA = "0x184187830")]
	public KKNLDOICDLK(T1 BCCJLCECHOM, T2 HEMMFIBMKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4185A60", Offset = "0x4184460", VA = "0x184185A60", Slot = "4")]
	public int CompareTo(KKNLDOICDLK<T1, T2> OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x41868E0", Offset = "0x41852E0", VA = "0x1841868E0", Slot = "0")]
	public override bool Equals(object OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4186DF0", Offset = "0x41857F0", VA = "0x184186DF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4187190", Offset = "0x4185B90", VA = "0x184187190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PLNCJGBCMBC<T1, T2, T3> : IComparable<PLNCJGBCMBC<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T1 MMILKMINAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T2 NDNGJEJEBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T3 GBLLJADMCBN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4771040", Offset = "0x476FA40", VA = "0x184771040")]
	public PLNCJGBCMBC(T1 BCCJLCECHOM, T2 HEMMFIBMKDK, T3 EFGMBOCFEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4770870", Offset = "0x476F270", VA = "0x184770870", Slot = "4")]
	public int CompareTo(PLNCJGBCMBC<T1, T2, T3> OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x47709C0", Offset = "0x476F3C0", VA = "0x1847709C0", Slot = "0")]
	public override bool Equals(object OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4770CE0", Offset = "0x476F6E0", VA = "0x184770CE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4770D80", Offset = "0x476F780", VA = "0x184770D80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T JNHPIMBJPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x22FB360", Offset = "0x22F9D60", VA = "0x1822FB360")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x22FB420", Offset = "0x22F9E20", VA = "0x1822FB420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float MLAFKOALCDL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8BEA30", Offset = "0x8BD430", VA = "0x1808BEA30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4BB6770", Offset = "0x4BB5170", VA = "0x184BB6770")]
	public T FNEDDDIBHBA(float DOGPFNGIKMO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4BB68A0", Offset = "0x4BB52A0", VA = "0x184BB68A0")]
	public T LIEECAELOJE(float DOGPFNGIKMO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T DADNJNHMGGO(T DIAAOCPNHKC, T LLLBDLGIMPP, float DOGPFNGIKMO);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x68A9100", Offset = "0x68A7B00", VA = "0x1868A9100", Slot = "4")]
	protected override float DADNJNHMGGO(float DIAAOCPNHKC, float LLLBDLGIMPP, float DOGPFNGIKMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x68A9140", Offset = "0x68A7B40", VA = "0x1868A9140")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xE6EF40", Offset = "0xE6D940", VA = "0x180E6EF40", Slot = "4")]
	protected override Vector3 DADNJNHMGGO(Vector3 DIAAOCPNHKC, Vector3 LLLBDLGIMPP, float DOGPFNGIKMO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x68ADB70", Offset = "0x68AC570", VA = "0x1868ADB70")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x68A7F20", Offset = "0x68A6920", VA = "0x1868A7F20", Slot = "4")]
	protected override Color DADNJNHMGGO(Color DIAAOCPNHKC, Color LLLBDLGIMPP, float DOGPFNGIKMO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x68A7FE0", Offset = "0x68A69E0", VA = "0x1868A7FE0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JNMGJLGBACE : DLCLPGKFPDM<string>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x68AA540", Offset = "0x68A8F40", VA = "0x1868AA540")]
	public JNMGJLGBACE(int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x68AA4D0", Offset = "0x68A8ED0", VA = "0x1868AA4D0", Slot = "6")]
	protected override uint MNAKOEMGGBL(uint BGMAOMLOOIC, string JMDCGOKJIDA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BMKFGIADLGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IDisposable MJFJCBEEADM;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public BMKFGIADLGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct CAAPJJNLHNO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> IMABLLPDOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int PEIHIHFNBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int LNJGPIPEBPK;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3C078F0", Offset = "0x3C062F0", VA = "0x183C078F0")]
	private CAAPJJNLHNO(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> AICLDAIHHEE, int DLDADAOHCHO, int BPFNHEMHBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x500C190", Offset = "0x500AB90", VA = "0x18500C190")]
	public static CAAPJJNLHNO<T> FJAAFKPDAIA()
	{
		return default(CAAPJJNLHNO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x500D0B0", Offset = "0x500BAB0", VA = "0x18500D0B0")]
	public (int, int, Task<T>) JPFOMCJKBNN(int IEJKLFLAGBB, [Optional] CancellationToken MPLGBOFHPLM, double IOCCJIJEELD = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x500E250", Offset = "0x500CC50", VA = "0x18500E250")]
	public void KIJDNFKPHIA(int IEJKLFLAGBB, int BPFNHEMHBMJ, [In] T ADPMAHMCGNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class CIFEGFPFPGG
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x68A7C40", Offset = "0x68A6640", VA = "0x1868A7C40")]
	public static CAAPJJNLHNO<MOOMEEOMEEK> FJAAFKPDAIA()
	{
		return default(CAAPJJNLHNO<MOOMEEOMEEK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x68A7C90", Offset = "0x68A6690", VA = "0x1868A7C90")]
	public static void KIJDNFKPHIA([In] this CAAPJJNLHNO<MOOMEEOMEEK> HIKEOGPAJAF, int IEJKLFLAGBB, int BPFNHEMHBMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class NOGDILHKBGL<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TVal> MDEEENOGJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<TVal, TKey> AMBOIAGLBDA;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3582A30", Offset = "0x3581430", VA = "0x183582A30", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool HNPAFAKBDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> FBJILCMLFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3D06C40", Offset = "0x3D05640", VA = "0x183D06C40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> PGIKKFOHHOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4533730", Offset = "0x4532130", VA = "0x184533730", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4539E30", Offset = "0x4538830", VA = "0x184539E30", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4539E90", Offset = "0x4538890", VA = "0x184539E90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4539AE0", Offset = "0x45384E0", VA = "0x184539AE0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4539450", Offset = "0x4537E50", VA = "0x184539450", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4539C60", Offset = "0x4538660", VA = "0x184539C60", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4539240", Offset = "0x4537C40", VA = "0x184539240", Slot = "9")]
	public void Add(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x45391F0", Offset = "0x4537BF0", VA = "0x1845391F0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x37DB3F0", Offset = "0x37D9DF0", VA = "0x1837DB3F0", Slot = "8")]
	public bool ContainsKey(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4539530", Offset = "0x4537F30", VA = "0x184539530", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4539B50", Offset = "0x4538550", VA = "0x184539B50", Slot = "10")]
	public bool Remove(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4539BD0", Offset = "0x45385D0", VA = "0x184539BD0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4539CB0", Offset = "0x45386B0", VA = "0x184539CB0", Slot = "11")]
	public bool TryGetValue(TKey NDDCLPHCEEO, [Out] TVal JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x45399E0", Offset = "0x45383E0", VA = "0x1845399E0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4539570", Offset = "0x4537F70", VA = "0x184539570", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] PFKJAOOHGBN, int OMHDEOJLLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x45390B0", Offset = "0x4537AB0", VA = "0x1845390B0")]
	public bool AKPHPFIGELN(TVal NDDCLPHCEEO, [Out] TKey JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4539290", Offset = "0x4537C90", VA = "0x184539290")]
	private void CJHLJHDOGME(TKey NDDCLPHCEEO, TVal GPBAFILNEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x45396C0", Offset = "0x45380C0", VA = "0x1845396C0")]
	private void DMBPGBGBDFN(TKey NDDCLPHCEEO, TVal GPBAFILNEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x45397B0", Offset = "0x45381B0", VA = "0x1845397B0")]
	private bool FIHONAPKJEP(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4539D10", Offset = "0x4538710", VA = "0x184539D10")]
	public NOGDILHKBGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public class HIGMIECILNG<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private HIGMIECILNG<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x38565B0", Offset = "0x3854FB0", VA = "0x1838565B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x3869CF0", Offset = "0x38686F0", VA = "0x183869CF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x386A850", Offset = "0x3869250", VA = "0x18386A850")]
		public Enumerator(HIGMIECILNG<T> PHMDIHEJOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3868FA0", Offset = "0x38679A0", VA = "0x183868FA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3869570", Offset = "0x3867F70", VA = "0x183869570", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x38683B0", Offset = "0x3866DB0", VA = "0x1838683B0")]
		private void LKFPEHKNIBA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T[] GOKDLEPEPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int JHEGPJBDKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int MLNHFJAKLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int DMDAEILPBHA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3D185E0", Offset = "0x3D16FE0", VA = "0x183D185E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3D19530", Offset = "0x3D17F30", VA = "0x183D19530")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3D17B60", Offset = "0x3D16560", VA = "0x183D17B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3D19A80", Offset = "0x3D18480", VA = "0x183D19A80")]
	public HIGMIECILNG(int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D18A00", Offset = "0x3D17400", VA = "0x183D18A00")]
	public void PBLNBBGFGAP(T DOGPFNGIKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3D18590", Offset = "0x3D16F90", VA = "0x183D18590")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D17980", Offset = "0x3D16380", VA = "0x183D17980")]
	public void CFDMGAKBOCA(int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3D19330", Offset = "0x3D17D30", VA = "0x183D19330")]
	public void PGKLAMLJNDJ(T[] PFKJAOOHGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3D17A50", Offset = "0x3D16450", VA = "0x183D17A50")]
	public Enumerator DCPEOMEKOMK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3D197A0", Offset = "0x3D181A0", VA = "0x183D197A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3D197A0", Offset = "0x3D181A0", VA = "0x183D197A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3D17FF0", Offset = "0x3D169F0", VA = "0x183D17FF0")]
	private int GCBALGANIKP(int DHNLEFJCEAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3D185B0", Offset = "0x3D16FB0", VA = "0x183D185B0")]
	private int MFMMGBJNFFA(int DHNLEFJCEAH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class LLNBPHOHMNO<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate Task<TResult> AKDEOCDHLMJ(TRequest GPCNCGBOPJG, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum OEDKJEMJDGI
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class EBKBHGJMDMP
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float IKEDAOAHOHD = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan IAIKPKJLIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int DIJGBCNBBGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public OEDKJEMJDGI EOMEDHLEFLE;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly EBKBHGJMDMP ELIKMDBCIKF;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float BPMKKGOMHCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x37D18C0", Offset = "0x37D02C0", VA = "0x1837D18C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TimeSpan GPPHPNDKNGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x37D1A80", Offset = "0x37D0480", VA = "0x1837D1A80")]
		public EBKBHGJMDMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private readonly struct PFKJFMEHMOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest GPCNCGBOPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken MPLGBOFHPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> KLCFJBFNJKE;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x47611F0", Offset = "0x475FBF0", VA = "0x1847611F0")]
		public PFKJFMEHMOJ(TRequest GPCNCGBOPJG, TaskCompletionSource<TResult> KLCFJBFNJKE, CancellationToken MPLGBOFHPLM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct AANEIBFALJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public LLNBPHOHMNO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3C51780", Offset = "0x3C50180", VA = "0x183C51780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3C51BE0", Offset = "0x3C505E0", VA = "0x183C51BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct MLNAIEAFIFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public LLNBPHOHMNO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private PFKJFMEHMOJ <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x44A8500", Offset = "0x44A6F00", VA = "0x1844A8500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x44A9180", Offset = "0x44A7B80", VA = "0x1844A9180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource CIHCAICIHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<PFKJFMEHMOJ> LKJHDMOCNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly EBKBHGJMDMP EPIPNOBBMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly AKDEOCDHLMJ GCFLFLFKPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task IOBENEJNNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int FDMFJIHCLBE;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x428E160", Offset = "0x428CB60", VA = "0x18428E160")]
	public LLNBPHOHMNO(AKDEOCDHLMJ GCFLFLFKPOA, [Optional] EBKBHGJMDMP EPIPNOBBMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x428C7F0", Offset = "0x428B1F0", VA = "0x18428C7F0")]
	public Task<TResult> DKHIGLLOPPE(TRequest GPCNCGBOPJG, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x428C590", Offset = "0x428AF90", VA = "0x18428C590")]
	private void BLEEADHCKKC(PFKJFMEHMOJ FOIKNMKKKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x428CFD0", Offset = "0x428B9D0", VA = "0x18428CFD0")]
	[AsyncStateMachine(typeof(LLNBPHOHMNO<, >.AANEIBFALJN))]
	private Task LICNHNOGJKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x428DA00", Offset = "0x428C400", VA = "0x18428DA00")]
	private PFKJFMEHMOJ NIHOKLMGKOO()
	{
		return default(PFKJFMEHMOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x428D270", Offset = "0x428BC70", VA = "0x18428D270")]
	[AsyncStateMachine(typeof(LLNBPHOHMNO<, >.MLNAIEAFIFE))]
	private Task NBGALBJACNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x428DDD0", Offset = "0x428C7D0", VA = "0x18428DDD0")]
	private void OLPBGAGFGEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x428CEC0", Offset = "0x428B8C0", VA = "0x18428CEC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class PEGNAEEHKKL<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> CGIFJALMJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> KEAGOEBAADJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3582A30", Offset = "0x3581430", VA = "0x183582A30", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool HNPAFAKBDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2748CD0", Offset = "0x27476D0", VA = "0x182748CD0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x475F440", Offset = "0x475DE40", VA = "0x18475F440", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3C1CF30", Offset = "0x3C1B930", VA = "0x183C1CF30", Slot = "11")]
	public void Add(T JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x475EA70", Offset = "0x475D470", VA = "0x18475EA70")]
	public bool AGNJLLJNDOJ(T JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x475F260", Offset = "0x475DC60", VA = "0x18475F260", Slot = "15")]
	public bool Remove(T JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3BD7C60", Offset = "0x3BD6660", VA = "0x183BD7C60", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3BF0610", Offset = "0x3BEF010", VA = "0x183BF0610", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x475EB60", Offset = "0x475D560", VA = "0x18475EB60", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x475EC00", Offset = "0x475D600", VA = "0x18475EC00", Slot = "13")]
	public bool Contains(T JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x475EC50", Offset = "0x475D650", VA = "0x18475EC50", Slot = "14")]
	public void CopyTo(T[] PFKJAOOHGBN, int OMHDEOJLLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4202B50", Offset = "0x4201550", VA = "0x184202B50", Slot = "6")]
	public int IndexOf(T JNHGHHKKNBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x475EDE0", Offset = "0x475D7E0", VA = "0x18475EDE0", Slot = "7")]
	public void Insert(int DHNLEFJCEAH, T JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x475F060", Offset = "0x475DA60", VA = "0x18475F060", Slot = "8")]
	public void RemoveAt(int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x475F320", Offset = "0x475DD20", VA = "0x18475F320")]
	public PEGNAEEHKKL()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x21A6A60", Offset = "0x21A5460", VA = "0x1821A6A60")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x68AD100", Offset = "0x68ABB00", VA = "0x1868AD100")]
		public SerializedGuid([In] Guid BMIGIGGJPJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x68ACFD0", Offset = "0x68AB9D0", VA = "0x1868ACFD0")]
		public static SerializedGuid LGEFIKAIAMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x68ACF60", Offset = "0x68AB960", VA = "0x1868ACF60")]
		public static SerializedGuid IDICMGFIBGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x68ACDF0", Offset = "0x68AB7F0", VA = "0x1868ACDF0")]
		public bool CFHDDGLKNCC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x68AD0D0", Offset = "0x68ABAD0", VA = "0x1868AD0D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x68AD050", Offset = "0x68ABA50", VA = "0x1868AD050", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x68ACE80", Offset = "0x68AB880", VA = "0x1868ACE80", Slot = "7")]
		public bool Equals(SerializedGuid OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x68ACEC0", Offset = "0x68AB8C0", VA = "0x1868ACEC0", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x68ACF50", Offset = "0x68AB950", VA = "0x1868ACF50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x68ACE50", Offset = "0x68AB850", VA = "0x1868ACE50", Slot = "6")]
		public int CompareTo(SerializedGuid OKGBBGMIACH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class ONFMOOOPGFJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type PNKOJBNOJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string PEDAFBNCNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool HFDNAEDKMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool GDBLJJMDBNI;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x68AB7F0", Offset = "0x68AA1F0", VA = "0x1868AB7F0")]
	public ONFMOOOPGFJ(Type CGDDLPBGNNM, string FBDJFLEOFMI, bool PPHGECCENLH = false, bool GHAEIGGIDIG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class OADONCMLPJG<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct CENCABLHMDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long KLAGOPJFMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long HHKEGHFGPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int JHAPJJJNDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int BPNEAIMIODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool DPKGDAPDGHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string AHDKPNBDPPD;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5104780", Offset = "0x5103180", VA = "0x185104780")]
		public CENCABLHMDP(long KLAGOPJFMBH, int JHAPJJJNDPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5104750", Offset = "0x5103150", VA = "0x185104750")]
		public CENCABLHMDP(long KLAGOPJFMBH, long HHKEGHFGPEN, int JHAPJJJNDPF, int BPNEAIMIODL, bool DPKGDAPDGHN, string AHDKPNBDPPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x51045E0", Offset = "0x5102FE0", VA = "0x1851045E0")]
		public int KDMIGDIIPBB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x51046D0", Offset = "0x51030D0", VA = "0x1851046D0")]
		public int MBLLJLINFID(int FFLLANCAOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x51046F0", Offset = "0x51030F0", VA = "0x1851046F0")]
		public double PNBHBLKJGEA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5104630", Offset = "0x5103030", VA = "0x185104630")]
		public CENCABLHMDP LCENFNDIJHE(long HHKEGHFGPEN, int BPNEAIMIODL)
		{
			return default(CENCABLHMDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class HILOONJJDHL : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct PNBCGELHKKN<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public HILOONJJDHL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<HILOONJJDHL, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private HILOONJJDHL <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x4773360", Offset = "0x4771D60", VA = "0x184773360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3806940", Offset = "0x3805340", VA = "0x183806940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey HJDGBLHMFIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly OADONCMLPJG<TKey> GFNLGFOFJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly CDLNJDLNIPA KBNCOADBJAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<HILOONJJDHL> FCJJODHBCHH;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string AOHCGGKNAML
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x3D19F70", Offset = "0x3D18970", VA = "0x183D19F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<HILOONJJDHL> PEPBBOEMMMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3D19D80", Offset = "0x3D18780", VA = "0x183D19D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public CENCABLHMDP MEJDIPHAJMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3D19FC0", Offset = "0x3D189C0", VA = "0x183D19FC0")]
			[CompilerGenerated]
			get
			{
				return default(CENCABLHMDP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3D19B10", Offset = "0x3D18510", VA = "0x183D19B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3D19FE0", Offset = "0x3D189E0", VA = "0x183D19FE0")]
		internal HILOONJJDHL(OADONCMLPJG<TKey> GFNLGFOFJFM, TKey NDDCLPHCEEO, CDLNJDLNIPA KBNCOADBJAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D19DC0", Offset = "0x3D187C0", VA = "0x183D19DC0")]
		public HILOONJJDHL FINICLOHGIA(TKey NDDCLPHCEEO, [Optional] CDLNJDLNIPA? BALLFEMFJJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x29D20F0", Offset = "0x29D0AF0", VA = "0x1829D20F0")]
		[AsyncStateMachine(typeof(PNBCGELHKKN<>))]
		public Task<T> DOCLEABBBAL<T>(TKey NDDCLPHCEEO, Func<HILOONJJDHL, Task<T>> GPJOKKOGGOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3D19B40", Offset = "0x3D18540", VA = "0x183D19B40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class HPMAGKANJKC : IEnumerable<(TKey, List<TKey>, CENCABLHMDP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CENCABLHMDP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, CENCABLHMDP timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public OADONCMLPJG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, CENCABLHMDP timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private (TKey, List<TKey>, CENCABLHMDP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x21A74B0", Offset = "0x21A5EB0", VA = "0x1821A74B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CENCABLHMDP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x3D55050", Offset = "0x3D53A50", VA = "0x183D55050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x21A75A0", Offset = "0x21A5FA0", VA = "0x1821A75A0")]
		[DebuggerHidden]
		public HPMAGKANJKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3982370", Offset = "0x3980D70", VA = "0x183982370", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3D54B90", Offset = "0x3D53590", VA = "0x183D54B90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3D54B40", Offset = "0x3D53540", VA = "0x183D54B40")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3D55000", Offset = "0x3D53A00", VA = "0x183D55000", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3D54F30", Offset = "0x3D53930", VA = "0x183D54F30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CENCABLHMDP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC930", Offset = "0x3ADB330", VA = "0x183ADC930", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NNLEBBADFID : IEnumerable<(TKey, List<TKey>, CENCABLHMDP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CENCABLHMDP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, CENCABLHMDP timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private HILOONJJDHL timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public HILOONJJDHL <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public OADONCMLPJG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<HILOONJJDHL> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, CENCABLHMDP timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, CENCABLHMDP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x21A74B0", Offset = "0x21A5EB0", VA = "0x1821A74B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CENCABLHMDP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x4532E70", Offset = "0x4531870", VA = "0x184532E70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x21A75A0", Offset = "0x21A5FA0", VA = "0x1821A75A0")]
		[DebuggerHidden]
		public NNLEBBADFID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4532ED0", Offset = "0x45318D0", VA = "0x184532ED0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4532510", Offset = "0x4530F10", VA = "0x184532510", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4532450", Offset = "0x4530E50", VA = "0x184532450")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x45324B0", Offset = "0x4530EB0", VA = "0x1845324B0")]
		private void KNPOGHPBEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4532E20", Offset = "0x4531820", VA = "0x184532E20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4532CE0", Offset = "0x45316E0", VA = "0x184532CE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CENCABLHMDP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4532DE0", Offset = "0x45317E0", VA = "0x184532DE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, CENCABLHMDP, CDLNJDLNIPA> CDDNBOKDIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, CENCABLHMDP, CDLNJDLNIPA> DDIKNNBKHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<OADONCMLPJG<TKey>, CDLNJDLNIPA> EBNPBMEGAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly HILOONJJDHL AMFJIPJPHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool MAFFMBBADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int EHLLNMHLGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch FPCPJEPFGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int MAJPDHANBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string HAFKKLEAJLM;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public HILOONJJDHL FDKCIFMCANG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8555C0", VA = "0x180856BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[NotNull]
	public string AOHCGGKNAML
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x856300", Offset = "0x854D00", VA = "0x180856300")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4602A50", Offset = "0x4601450", VA = "0x184602A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4602AB0", Offset = "0x46014B0", VA = "0x184602AB0")]
	public OADONCMLPJG(TKey PGNFCILIBKB, CDLNJDLNIPA KBNCOADBJAI, [Optional] int? JHAPJJJNDPF, [Optional][CanBeNull] Stopwatch FPCPJEPFGDL, [Optional] Action<TKey, CENCABLHMDP, CDLNJDLNIPA> CDDNBOKDIMA, [Optional] Action<TKey, CENCABLHMDP, CDLNJDLNIPA> DDIKNNBKHHD, [Optional] Action<OADONCMLPJG<TKey>, CDLNJDLNIPA> EBNPBMEGAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4602980", Offset = "0x4601380", VA = "0x184602980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x46028E0", Offset = "0x46012E0", VA = "0x1846028E0")]
	[IteratorStateMachine(typeof(OADONCMLPJG<>.HPMAGKANJKC))]
	public IEnumerable<(TKey, List<TKey>, CENCABLHMDP)> DJMKPDMAODN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4602800", Offset = "0x4601200", VA = "0x184602800")]
	[IteratorStateMachine(typeof(OADONCMLPJG<>.NNLEBBADFID))]
	private IEnumerable<(TKey, List<TKey>, CENCABLHMDP)> DJMKPDMAODN(List<TKey> BECGFNBELMK, HILOONJJDHL DOAFLGODEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4602780", Offset = "0x4601180", VA = "0x184602780")]
	private (long, int) CDBPGJJNNAF()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class CPKOJAAICCF<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut BMENGJPMPIB(OADONCMLPJG<TKey> GFNLGFOFJFM);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	protected CPKOJAAICCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class PJPNOLNCOGB<TKey> : CPKOJAAICCF<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string AEMENILFDFE(TKey NDDCLPHCEEO);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x476BED0", Offset = "0x476A8D0", VA = "0x18476BED0")]
	private static string DJJIKBBNAGO(TKey NDDCLPHCEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x476BDF0", Offset = "0x476A7F0", VA = "0x18476BDF0", Slot = "4")]
	public override string BMENGJPMPIB(OADONCMLPJG<TKey> GFNLGFOFJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x476BCA0", Offset = "0x476A6A0", VA = "0x18476BCA0")]
	public string BMENGJPMPIB(OADONCMLPJG<TKey> GFNLGFOFJFM, [NotNull] AEMENILFDFE NBKHPILOMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string BLLHFJPBMOE(OADONCMLPJG<TKey> GFNLGFOFJFM, [NotNull] AEMENILFDFE NBKHPILOMOL);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0740", Offset = "0x3CBF140", VA = "0x183CC0740")]
	protected PJPNOLNCOGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class LDBDKGIKPEF<TKey> : CPKOJAAICCF<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate string KGBLOFDDKLH(TKey NDDCLPHCEEO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string BOONLBHLOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double GMGPNLBKAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool PFAENIKAPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int BMMMIGBMDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> GOBFALADJGM;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x422BA10", Offset = "0x422A410", VA = "0x18422BA10")]
	private static string DJJIKBBNAGO(TKey NDDCLPHCEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x422BCC0", Offset = "0x422A6C0", VA = "0x18422BCC0")]
	public LDBDKGIKPEF(string BOONLBHLOGE = "F2", double GMGPNLBKAOC = double.MaxValue, bool PFAENIKAPLP = false, int BMMMIGBMDLJ = int.MaxValue, [Optional] ISet<string> GOBFALADJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x422B850", Offset = "0x422A250", VA = "0x18422B850", Slot = "4")]
	public override Dictionary<string, string> BMENGJPMPIB(OADONCMLPJG<TKey> GFNLGFOFJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x422B930", Offset = "0x422A330", VA = "0x18422B930")]
	private bool CMAKGCDIHIB(string FELMDNOFLBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x422B220", Offset = "0x4229C20", VA = "0x18422B220")]
	public Dictionary<string, string> BMENGJPMPIB(OADONCMLPJG<TKey> GFNLGFOFJFM, KGBLOFDDKLH NBKHPILOMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x422BA50", Offset = "0x422A450", VA = "0x18422BA50")]
	private string FBLDDIGEKAC(StringBuilder OOBMNIJGKAM, List<TKey> GFLLMHHAMIJ, KGBLOFDDKLH NBKHPILOMOL, bool DCKCCBMBKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x422B0C0", Offset = "0x4229AC0", VA = "0x18422B0C0")]
	private static void BGBBFIIIAGM(StringBuilder KEOPMHJOBBH, string MECMFGBHOOA, bool JPDDEBGGPGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class FKKEPGGADDP<TKey> : PJPNOLNCOGB<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct DEAPGGLMCPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AEMENILFDFE keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static FKKEPGGADDP<TKey> MJFJCBEEADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] ABPHODNPGAH;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3BE5350", Offset = "0x3BE3D50", VA = "0x183BE5350")]
	private FKKEPGGADDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3BE42C0", Offset = "0x3BE2CC0", VA = "0x183BE42C0", Slot = "5")]
	protected override string BLLHFJPBMOE(OADONCMLPJG<TKey> GFNLGFOFJFM, AEMENILFDFE NBKHPILOMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3BE5110", Offset = "0x3BE3B10", VA = "0x183BE5110")]
	[CompilerGenerated]
	internal static string CFJJJHFDALF(string FKLCPMENCPL, TKey NDDCLPHCEEO, DEAPGGLMCPA P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class COIHLFMDECC : OADONCMLPJG<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class LJLCLGHGGEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<COIHLFMDECC, CDLNJDLNIPA> callback;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public LJLCLGHGGEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x68AB240", Offset = "0x68A9C40", VA = "0x1868AB240")]
		internal void AOBJLOGCGCC(OADONCMLPJG<string> timer, CDLNJDLNIPA log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x68A7DD0", Offset = "0x68A67D0", VA = "0x1868A7DD0")]
	public COIHLFMDECC(CDLNJDLNIPA KBNCOADBJAI, [Optional] string NELDGGFCGBO, [Optional] int? JHAPJJJNDPF, [Optional] Stopwatch FPCPJEPFGDL, [Optional] Action<string, CENCABLHMDP, CDLNJDLNIPA> CDDNBOKDIMA, [Optional] Action<string, CENCABLHMDP, CDLNJDLNIPA> DDIKNNBKHHD, [Optional] Action<COIHLFMDECC, CDLNJDLNIPA> EBNPBMEGAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x68A7D10", Offset = "0x68A6710", VA = "0x1868A7D10")]
	private static Action<OADONCMLPJG<string>, CDLNJDLNIPA> HACHDNNNLLE(Action<COIHLFMDECC, CDLNJDLNIPA> HBBMMHKOEKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class GEKKFPEPFEA
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private class PNLPKPOJFJL : GEKKFPEPFEA
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static GEKKFPEPFEA MJFJCBEEADM
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x68AB860", Offset = "0x68AA260", VA = "0x1868AB860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override float AMJPOMIJLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x98CE80", Offset = "0x98B880", VA = "0x18098CE80", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x68AB960", Offset = "0x68AA360", VA = "0x1868AB960")]
		public PNLPKPOJFJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static GEKKFPEPFEA FIAHPHAFHGL;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static GEKKFPEPFEA ELIKMDBCIKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x68A9180", Offset = "0x68A7B80", VA = "0x1868A9180")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract float AMJPOMIJLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	protected GEKKFPEPFEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface IABENFAMAOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool OJBMAONCMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface GBMNPHMLGKB<T> : IABENFAMAOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> GJLNBAMLKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	MAKKFMNHCEA<T> AOBKCEMGLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class CIBINEPEOEH
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x293B3A0", Offset = "0x2939DA0", VA = "0x18293B3A0")]
	public static GBMNPHMLGKB<TResource> KCLJIOCOKEB<TResource, TId>(this FILEOJEALJN<TId, TResource> MGPCCJLLDAM, TId DKFNFHGODON, [Optional] Func<TId, CancellationToken, Task<TResource>>? FLPMJCBHCGB) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class PDMMMODAIBL
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private sealed class IJINABGMDPL<T> : MDDCCCKDBFD<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override Task<T?> GJLNBAMLKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override MAKKFMNHCEA<T?> AOBKCEMGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3EC1F80", Offset = "0x3EC0980", VA = "0x183EC1F80")]
		public IJINABGMDPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "10")]
		protected override void MDIOCFABDCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private sealed class OEDAMCGCDGP<T> : MDDCCCKDBFD<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly T OBAIELFNFBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly Action<T>? JNKKLOOAFLE;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T> GJLNBAMLKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855360", VA = "0x180856960", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override MAKKFMNHCEA<T> AOBKCEMGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x856AB0", Offset = "0x8554B0", VA = "0x180856AB0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4623470", Offset = "0x4621E70", VA = "0x184623470")]
		public OEDAMCGCDGP(T GDBEHNBLALJ, Action<T>? BDILBDIGJFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x46233C0", Offset = "0x4621DC0", VA = "0x1846233C0", Slot = "10")]
		protected override void MDIOCFABDCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class HPCMBIPFBDO<T> : MDDCCCKDBFD<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> GJLNBAMLKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override MAKKFMNHCEA<T> AOBKCEMGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3D53180", Offset = "0x3D51B80", VA = "0x183D53180")]
		public HPCMBIPFBDO(Exception HBEPHPNHPNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "10")]
		protected override void MDIOCFABDCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class JENNPKJBJKI<T> : MDDCCCKDBFD<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct FIGADIKGLEI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public Task<GBMNPHMLGKB<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private TaskAwaiter<GBMNPHMLGKB<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x3BDB680", Offset = "0x3BDA080", VA = "0x183BDB680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x3BDBB80", Offset = "0x3BDA580", VA = "0x183BDBB80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct BKGHLKIEEDI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public Task<GBMNPHMLGKB<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private TaskAwaiter<GBMNPHMLGKB<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x4E2DE20", Offset = "0x4E2C820", VA = "0x184E2DE20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x4E2E280", Offset = "0x4E2CC80", VA = "0x184E2E280", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly Task<GBMNPHMLGKB<T>> ABMDBAFOLDA;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> GJLNBAMLKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override MAKKFMNHCEA<T> AOBKCEMGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855340", VA = "0x180856940", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4093750", Offset = "0x4092150", VA = "0x184093750")]
		public JENNPKJBJKI(Task<GBMNPHMLGKB<T>> LEDCCMOCHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4093630", Offset = "0x4092030", VA = "0x184093630", Slot = "10")]
		protected override void MDIOCFABDCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4093310", Offset = "0x4091D10", VA = "0x184093310")]
		[AsyncStateMachine(typeof(JENNPKJBJKI<>.FIGADIKGLEI))]
		[CompilerGenerated]
		internal static Task<T> CPEBEHODMBN(Task<GBMNPHMLGKB<T>> LEDCCMOCHJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4093470", Offset = "0x4091E70", VA = "0x184093470")]
		[AsyncStateMachine(typeof(JENNPKJBJKI<>.BKGHLKIEEDI))]
		[CompilerGenerated]
		internal static Task MCKOPPOLCGM(Task<GBMNPHMLGKB<T>> LEDCCMOCHJB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class DNPBNLOHHHF<TIn, TOut> : MDDCCCKDBFD<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct LOAPPFFINDE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x4294C90", Offset = "0x4293690", VA = "0x184294C90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x3C55590", Offset = "0x3C53F90", VA = "0x183C55590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly GBMNPHMLGKB<TIn> GPFBODKIOAJ;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<TOut> GJLNBAMLKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override MAKKFMNHCEA<TOut> AOBKCEMGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855340", VA = "0x180856940", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x57784B0", Offset = "0x5776EB0", VA = "0x1857784B0")]
		public DNPBNLOHHHF(GBMNPHMLGKB<TIn> BIPHMNOOLAG, Func<TIn, TOut> AMBLFAKGKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5778460", Offset = "0x5776E60", VA = "0x185778460", Slot = "10")]
		protected override void MDIOCFABDCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5778110", Offset = "0x5776B10", VA = "0x185778110")]
		[AsyncStateMachine(typeof(DNPBNLOHHHF<, >.LOAPPFFINDE))]
		[CompilerGenerated]
		internal static Task<TOut> HOHFKGAHFIN(Task<TIn> DJMMIEKABGF, Func<TIn, TOut> AMBLFAKGKHE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5BA0", Offset = "0x2CC45A0", VA = "0x182CC5BA0")]
	public static GBMNPHMLGKB<T> ENKECPBOOIC<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5AF0", Offset = "0x2CC44F0", VA = "0x182CC5AF0")]
	public static GBMNPHMLGKB<T> CPNDOIMICJM<T>(T ADPMAHMCGNH, [Optional] Action<T>? BDILBDIGJFD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2B5FCD0", Offset = "0x2B5E6D0", VA = "0x182B5FCD0")]
	public static GBMNPHMLGKB<T> HJMCIEPGHOP<T>(Exception HBEPHPNHPNB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2B5FCD0", Offset = "0x2B5E6D0", VA = "0x182B5FCD0")]
	public static GBMNPHMLGKB<T> LPMMIMKFOPJ<T>(Task<GBMNPHMLGKB<T>> LEDCCMOCHJB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x28C7450", Offset = "0x28C5E50", VA = "0x1828C7450")]
	public static GBMNPHMLGKB<TOut> IKKMMCBJHKI<TOut, TIn>(GBMNPHMLGKB<TIn> IIMJMBJHGDI, Func<TIn, TOut> AMBLFAKGKHE) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public abstract class MDDCCCKDBFD<T> : GBMNPHMLGKB<T>, IABENFAMAOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly string LBMPEFBEIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly AHNPDBJIDJD OGOPNLCHEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool MAFFMBBADNE;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool OJBMAONCMFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xB7F4B0", Offset = "0xB7DEB0", VA = "0x180B7F4B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public abstract Task<T> GJLNBAMLKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public abstract MAKKFMNHCEA<T> AOBKCEMGLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x447D8F0", Offset = "0x447C2F0", VA = "0x18447D8F0")]
	public MDDCCCKDBFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x447D4F0", Offset = "0x447BEF0", VA = "0x18447D4F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void MDIOCFABDCD();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class OBLJHNCCPPP<TTask, T> : MDDCCCKDBFD<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class NEBGBHFDEIJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public NEBGBHFDEIJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3570710", Offset = "0x356F110", VA = "0x183570710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3570C60", Offset = "0x356F660", VA = "0x183570C60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public OBLJHNCCPPP<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public NEBGBHFDEIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x44FEF70", Offset = "0x44FD970", VA = "0x1844FEF70")]
		[AsyncStateMachine(typeof(OBLJHNCCPPP<, >.NEBGBHFDEIJ.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> ECDKOFADJJG(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly Task<T> LEDCCMOCHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	protected readonly CancellationTokenSource NPCICLIMLAO;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public override Task<T> GJLNBAMLKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public override MAKKFMNHCEA<T> AOBKCEMGLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x460BAD0", Offset = "0x460A4D0", VA = "0x18460BAD0")]
	protected OBLJHNCCPPP(TTask LEDCCMOCHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x460B890", Offset = "0x460A290", VA = "0x18460B890", Slot = "10")]
	protected override void MDIOCFABDCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T DOCHOJKICPF(TTask OMBNLOMPPEF);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void GLGFOCIIMBB();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class GNFMNOLIFHP<T> : MDDCCCKDBFD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly PIKIJNPLMPM<Task<T>> KNGNJJGKNLA;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> GJLNBAMLKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1680", Offset = "0x3CD0080", VA = "0x183CD1680", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override MAKKFMNHCEA<T> AOBKCEMGLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3CD16F0", Offset = "0x3CD00F0", VA = "0x183CD16F0")]
	public GNFMNOLIFHP(PIKIJNPLMPM<Task<T>> FOFGABHMNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3CD16D0", Offset = "0x3CD00D0", VA = "0x183CD16D0", Slot = "10")]
	protected override void MDIOCFABDCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class LHFAHALCBEB
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static readonly HashAlgorithmName OGCCNNILNND;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly ThreadLocal<IncrementalHash> CMMFHCKDAGP;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x68AA940", Offset = "0x68A9340", VA = "0x1868AA940")]
	public static int EOPENGOEFIE(this CEAGNJHJOCG PFNNOMPNEPO, IncrementalHash BGMAOMLOOIC, byte[] DDKJPDFNFFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x68AAD80", Offset = "0x68A9780", VA = "0x1868AAD80")]
	public static bool OCCAPKCOBAG([CanBeNull] this CEAGNJHJOCG PFNNOMPNEPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x68AADE0", Offset = "0x68A97E0", VA = "0x1868AADE0")]
	public static bool OCCAPKCOBAG([CanBeNull] this CEAGNJHJOCG PFNNOMPNEPO, [Out] string GGEHLADLJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x68AAA50", Offset = "0x68A9450", VA = "0x1868AAA50")]
	public static bool OCCAPKCOBAG([CanBeNull] this CEAGNJHJOCG PFNNOMPNEPO, IncrementalHash BGMAOMLOOIC, byte[] DDKJPDFNFFD, [Out] string GGEHLADLJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x68AA9C0", Offset = "0x68A93C0", VA = "0x1868AA9C0")]
	private static bool MPGJNMPBAJG(byte[] OMFLMICADGH, Span<byte> EBICLIKEKJG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class LHDMLOIIAOF
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x68AA7F0", Offset = "0x68A91F0", VA = "0x1868AA7F0")]
	public static int IPKIPJBEPHJ(HashAlgorithmName MNIMKJCKKKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x68AA590", Offset = "0x68A8F90", VA = "0x1868AA590")]
	public static int EOPENGOEFIE(this FOEMIFIPDHC DHFJKIPBMFJ, byte[] NMFEPCIMIAN, IncrementalHash BGMAOMLOOIC, byte[] EKFMIPDOAPN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface FOEMIFIPDHC
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash BGMAOMLOOIC);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface CEAGNJHJOCG : FOEMIFIPDHC
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	[CanBeNull]
	byte[] FAKBFMBEEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	[CanBeNull]
	byte[] AAHKDJIIEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class IOJCOBHAGFG
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static bool MMALCHFILNB;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ArrayPool<byte> LFJOBHFHLIP;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly ArrayPool<char> KPHKJMHODKM;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly Encoding BAKLFFLKPIP;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ThreadLocal<Encoder> EEOPNEOPEBO;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE0C0", Offset = "0x2BACAC0", VA = "0x182BAE0C0")]
	public static void CNPAGKBBIPD<T>(this IncrementalHash EJJPKIEAEOJ, [CanBeNull] T INPAFGCEBHH) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE7B0", Offset = "0x2BAD1B0", VA = "0x182BAE7B0")]
	public static void EMLEKPEKODA<T>(this IncrementalHash EJJPKIEAEOJ, [CanBeNull] T DHFJKIPBMFJ) where T : FOEMIFIPDHC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE840", Offset = "0x2BAD240", VA = "0x182BAE840")]
	public static void KDEPAHFAJNG<T>(this IncrementalHash EJJPKIEAEOJ, [CanBeNull] IList<T> AMPDPODCKNI) where T : FOEMIFIPDHC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x68A9B00", Offset = "0x68A8500", VA = "0x1868A9B00")]
	private static bool HOEIECHNKHJ([CanBeNull] FOEMIFIPDHC DHFJKIPBMFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x68A9DC0", Offset = "0x68A87C0", VA = "0x1868A9DC0")]
	public static void LCFNAEKCBPL(this IncrementalHash BGMAOMLOOIC, string? OCIBELDMAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x68A9760", Offset = "0x68A8160", VA = "0x1868A9760")]
	public static void FKEGCHJGIOJ(this IncrementalHash BGMAOMLOOIC, long GFMBFOEFLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x68A9930", Offset = "0x68A8330", VA = "0x1868A9930")]
	public static void GBNCLGONELP(this IncrementalHash BGMAOMLOOIC, int EOHIGKOGJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x68A92F0", Offset = "0x68A7CF0", VA = "0x1868A92F0")]
	public static void DJAPLPKGNGB(this IncrementalHash BGMAOMLOOIC, short EKIDBNIHGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x68A9650", Offset = "0x68A8050", VA = "0x1868A9650")]
	public static void FGLNHDMIGKO(this IncrementalHash BGMAOMLOOIC, byte LGAPMFOONIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x68A9B90", Offset = "0x68A8590", VA = "0x1868A9B90")]
	public static void KNKOIFFHJAH(this IncrementalHash BGMAOMLOOIC, bool JGCDIGHDPJC, bool NFCMLGILAOO = false, bool ADPDFKGHKGK = false, bool LEPLIIGEKNE = false, bool INAJHEFHAGB = false, bool MGFEEBHGLDK = false, bool GNEMENOMHLN = false, bool DNHAFAKMNCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE180", Offset = "0x2BACB80", VA = "0x182BAE180")]
	public static void DLLAPPKCHBA<T>(this IncrementalHash BGMAOMLOOIC, T NKEPPGPEFAC) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x68A94C0", Offset = "0x68A7EC0", VA = "0x1868A94C0")]
	public static void EEPLLLFEHPA(this IncrementalHash BGMAOMLOOIC, float CGKCMNEGKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x68A9D60", Offset = "0x68A8760", VA = "0x1868A9D60")]
	public static void LCEEFBMDLNC(this IncrementalHash BGMAOMLOOIC, ulong HIDLCCHGKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x68A9D00", Offset = "0x68A8700", VA = "0x1868A9D00")]
	public static void KOIGCEAPDPH(this IncrementalHash BGMAOMLOOIC, uint JGPNPJAIALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x68AA1D0", Offset = "0x68A8BD0", VA = "0x1868AA1D0")]
	public static void LGDCCFKHDAM(this IncrementalHash BGMAOMLOOIC, ushort NFMGAKDNKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x68A9520", Offset = "0x68A7F20", VA = "0x1868A9520")]
	public static void FCIPJKPKEKP(this IncrementalHash BGMAOMLOOIC, Vector3 NLCKJNGAHOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class EOCGBMKNDDN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x68A90A0", Offset = "0x68A7AA0", VA = "0x1868A90A0")]
	public EOCGBMKNDDN(string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public abstract class OLMGKNKHOEA<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal class JGFNDJBHLGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TNode HIKEOGPAJAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public TNode BMBBFJPOJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public MKNIGIHFOCE IDOOJPJNKLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<MKNIGIHFOCE> MEBIICEPBCE;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public JGFNDJBHLGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal struct MKNIGIHFOCE : IComparable<MKNIGIHFOCE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int CBHPEKJLLAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public TClaimant JOOMFCKIBIA;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xD87910", Offset = "0xD86310", VA = "0x180D87910")]
		public MKNIGIHFOCE(int CBHPEKJLLAF, TClaimant JOOMFCKIBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x44993B0", Offset = "0x4497DB0", VA = "0x1844993B0")]
		public bool GLMODKNLDMJ([In] MKNIGIHFOCE OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4499410", Offset = "0x4497E10", VA = "0x184499410")]
		public bool JFCICOEJFHD([In] MKNIGIHFOCE OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x44993A0", Offset = "0x4497DA0", VA = "0x1844993A0", Slot = "4")]
		public int CompareTo(MKNIGIHFOCE OKGBBGMIACH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4499420", Offset = "0x4497E20", VA = "0x184499420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public enum CEBFEKJKDCN
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class PMNNDINKMBK : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public OLMGKNKHOEA<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x89FD00", Offset = "0x89E700", VA = "0x18089FD00")]
		[DebuggerHidden]
		public PMNNDINKMBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4772F40", Offset = "0x4771940", VA = "0x184772F40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4773110", Offset = "0x4771B10", VA = "0x184773110", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4773020", Offset = "0x4771A20", VA = "0x184773020", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3983940", Offset = "0x3982340", VA = "0x183983940", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly CAJPHPCFPPJ<JGFNDJBHLGK> GOHLDHFINAI;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly CAJPHPCFPPJ<List<MKNIGIHFOCE>> AKBNLJNBMGA;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static int ELDDLGIECEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	internal readonly Dictionary<TClaimant, TNode> EOPOIOIBAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	internal readonly Dictionary<TNode, JGFNDJBHLGK> DMGOLBKMDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private CEBFEKJKDCN DNCAOAEPAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool LOOMHHLOKGF;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode EJGCADKFNOA(TNode LLENHGPBNOK);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void JPPKKMPMPEF(TNode LLENHGPBNOK, TClaimant FFJFCDDDHHD, TClaimant POAGJKNBNPJ);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x46691F0", Offset = "0x4667BF0", VA = "0x1846691F0")]
	public OLMGKNKHOEA(CEBFEKJKDCN DNCAOAEPAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x4668F60", Offset = "0x4667960", VA = "0x184668F60")]
	public void NJJNMEDKCPE(TNode LLENHGPBNOK, TNode KGHLFFBGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x4667FB0", Offset = "0x46669B0", VA = "0x184667FB0")]
	public void FPDLNKKCFJK(TClaimant JOOMFCKIBIA, TNode LHEKFIAPFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4667CA0", Offset = "0x46666A0", VA = "0x184667CA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x46685D0", Offset = "0x4666FD0", VA = "0x1846685D0")]
	private void LHDCOHMHHHG(TClaimant JOOMFCKIBIA, TNode OOOGHEGGLNM, TNode LHEKFIAPFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4668120", Offset = "0x4666B20", VA = "0x184668120")]
	private int GMKIELAOLGB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4668AC0", Offset = "0x46674C0", VA = "0x184668AC0")]
	private void MOBFJOJEODO(TClaimant JOOMFCKIBIA, TNode BIAKJJCLLID, TNode MODLHPADBNH, int JJCEFAGICFP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x46689F0", Offset = "0x46673F0", VA = "0x1846689F0")]
	private void MLAPOHICBNJ(MKNIGIHFOCE PPMAMEOGFHI, JGFNDJBHLGK EGLLCDAKFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x4667730", Offset = "0x4666130", VA = "0x184667730")]
	private void BJMICDOBFJM(TClaimant JOOMFCKIBIA, TNode BIAKJJCLLID, TNode MODLHPADBNH, int JJCEFAGICFP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4667B70", Offset = "0x4666570", VA = "0x184667B70")]
	private void DBOPOABIABA(MKNIGIHFOCE PPMAMEOGFHI, TNode LLENHGPBNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4668E00", Offset = "0x4667800", VA = "0x184668E00")]
	private void NAKPKGILFEG(MKNIGIHFOCE PPMAMEOGFHI, JGFNDJBHLGK EGLLCDAKFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4667A20", Offset = "0x4666420", VA = "0x184667A20")]
	private void CNDGLHIGANH(JGFNDJBHLGK EGLLCDAKFDC, bool PKNHKGDKIOM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x46686A0", Offset = "0x46670A0", VA = "0x1846686A0")]
	private void MGKIDAKOLDC(JGFNDJBHLGK EGLLCDAKFDC, TNode KGHLFFBGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4668190", Offset = "0x4666B90", VA = "0x184668190")]
	[IteratorStateMachine(typeof(OLMGKNKHOEA<, >.PMNNDINKMBK))]
	private IEnumerable<TNode> IHCDNCHFMJE(TNode BIAKJJCLLID, TNode MODLHPADBNH, bool NNLPMCHFPHJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4667EA0", Offset = "0x46668A0", VA = "0x184667EA0")]
	private JGFNDJBHLGK EHEAPGIABLG(TNode LLENHGPBNOK, TNode BMBBFJPOJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4668280", Offset = "0x4666C80", VA = "0x184668280")]
	private JGFNDJBHLGK IMNJPKNAEMO(TNode LLENHGPBNOK, TNode BMBBFJPOJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4668410", Offset = "0x4666E10", VA = "0x184668410")]
	private void KNIMKAMBEDB(JGFNDJBHLGK EGLLCDAKFDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class DLCLPGKFPDM<T> : IEnumerable<DLCLPGKFPDM<T>.OBDEHHJCNBO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct OBDEHHJCNBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public T JMDCGOKJIDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int DHNLEFJCEAH;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class NBGIDHOAPIM : IEnumerator<OBDEHHJCNBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private DLCLPGKFPDM<T> NAOKJFLCLAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int DHNLEFJCEAH;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x380DEA0", Offset = "0x380C8A0", VA = "0x18380DEA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public OBDEHHJCNBO EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x44F91F0", Offset = "0x44F7BF0", VA = "0x1844F91F0", Slot = "4")]
			get
			{
				return default(OBDEHHJCNBO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x44F9100", Offset = "0x44F7B00", VA = "0x1844F9100")]
		public NBGIDHOAPIM(DLCLPGKFPDM<T> NAOKJFLCLAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x44F9080", Offset = "0x44F7A80", VA = "0x1844F9080", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x38651D0", Offset = "0x3863BD0", VA = "0x1838651D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x939E00", Offset = "0x938800", VA = "0x180939E00", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct NOFLDIHKDIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool DLHNOLAFDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public T JMDCGOKJIDA;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private const int PNEGAMBKAPP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly Dictionary<T, int> IBAMAMICCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private NOFLDIHKDIC[] IHCMEBBLIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int GNMDMHIJCOI;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int IOIECPABLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x891F80", Offset = "0x890980", VA = "0x180891F80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x891580", Offset = "0x88FF80", VA = "0x180891580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3582A30", Offset = "0x3581430", VA = "0x183582A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x5770740", Offset = "0x576F140", VA = "0x185770740")]
	public DLCLPGKFPDM(int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x5770830", Offset = "0x576F230", VA = "0x185770830")]
	public DLCLPGKFPDM(OBDEHHJCNBO[] LMPEAEHMIBH, bool HLDKFPLAGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x5770270", Offset = "0x576EC70", VA = "0x185770270")]
	public int EGHBGNMNINA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x576FE70", Offset = "0x576E870", VA = "0x18576FE70")]
	private int BCNIOLPGFFI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x57704F0", Offset = "0x576EEF0", VA = "0x1857704F0", Slot = "6")]
	protected virtual uint MNAKOEMGGBL(uint BGMAOMLOOIC, T JMDCGOKJIDA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5770510", Offset = "0x576EF10", VA = "0x185770510")]
	public bool ODHBLCILLBD(T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x57703C0", Offset = "0x576EDC0", VA = "0x1857703C0")]
	public int ICKPOHFJOGL(T JMDCGOKJIDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x57705E0", Offset = "0x576EFE0", VA = "0x1857705E0")]
	public T POIMHEEJLCG(int DHNLEFJCEAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x576FBB0", Offset = "0x576E5B0", VA = "0x18576FBB0")]
	public bool AGNJLLJNDOJ(T JMDCGOKJIDA, bool JJAIHJFGNCD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x576FC10", Offset = "0x576E610", VA = "0x18576FC10")]
	public bool AGNJLLJNDOJ(T JMDCGOKJIDA, int DHNLEFJCEAH, bool JJAIHJFGNCD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5770320", Offset = "0x576ED20", VA = "0x185770320")]
	private int HLIPIGFOOOI(int JHEGPJBDKAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x57706A0", Offset = "0x576F0A0", VA = "0x1857706A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x57706A0", Offset = "0x576F0A0", VA = "0x1857706A0", Slot = "4")]
	private IEnumerator<OBDEHHJCNBO> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class CAJPHPCFPPJ<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Stack<T> JOPKJIBCCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly List<T> BNAFAHMPPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int KJLEDNHKEND;

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5016FF0", Offset = "0x50159F0", VA = "0x185016FF0")]
	public static CAJPHPCFPPJ<T> HBPMPABLDNC(int HHGNDILCLEE = 0, int KJLEDNHKEND = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5016D40", Offset = "0x5015740", VA = "0x185016D40")]
	public static CAJPHPCFPPJ<T> BJHJLAFEIHL(int HHGNDILCLEE = 0, int KJLEDNHKEND = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5017840", Offset = "0x5016240", VA = "0x185017840")]
	public CAJPHPCFPPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5017640", Offset = "0x5016040", VA = "0x185017640")]
	public CAJPHPCFPPJ(int HHGNDILCLEE, int KJLEDNHKEND = int.MaxValue, bool BBFPOCCEHDH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x50173D0", Offset = "0x5015DD0", VA = "0x1850173D0")]
	public T MCBLJONGBGM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5017570", Offset = "0x5015F70", VA = "0x185017570")]
	public void NLCHOINDCPP(T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x50172D0", Offset = "0x5015CD0", VA = "0x1850172D0")]
	private void KDIBJKFCPKI(T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5016E30", Offset = "0x5015830", VA = "0x185016E30")]
	private void CAPMIAOOFKN(T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5016E70", Offset = "0x5015870", VA = "0x185016E70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x50170E0", Offset = "0x5015AE0", VA = "0x1850170E0")]
	private void IJHCHEHDLAP(IEnumerable<T> MNHECFLLMJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class MEOFAFIIODC<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Dictionary<int, T> ENCKOMKBEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private T BGCICGMELIJ;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public virtual T MDNMGILJJDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851290", VA = "0x180852890", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x448D8A0", Offset = "0x448C2A0", VA = "0x18448D8A0")]
	public bool MBCOGGKHPPK(T JMDCGOKJIDA, int CBHPEKJLLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x448D9E0", Offset = "0x448C3E0", VA = "0x18448D9E0")]
	public bool NOOCMPIIMHF(int CBHPEKJLLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x448D4A0", Offset = "0x448BEA0", VA = "0x18448D4A0")]
	public T HDKIBNHBHBG(int EFAIDKFIHBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x448D2B0", Offset = "0x448BCB0", VA = "0x18448D2B0")]
	private bool BCHEJMABEAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x448D250", Offset = "0x448BC50", VA = "0x18448D250")]
	public bool AKPHPFIGELN(int CBHPEKJLLAF, [Out] T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x448DA80", Offset = "0x448C480", VA = "0x18448DA80")]
	public MEOFAFIIODC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class FJGCBIBHNKC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	protected struct CICOHLCPCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public T JNHPIMBJPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int CLMJDMFGEEH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	protected readonly List<CICOHLCPCCM> GOKDLEPEPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private T FLCFFHCGPAE;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3582A30", Offset = "0x3581430", VA = "0x183582A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x3BDE250", Offset = "0x3BDCC50", VA = "0x183BDE250")]
	public bool DJONJHALGBO(T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3BDEBD0", Offset = "0x3BDD5D0", VA = "0x183BDEBD0")]
	public void PBLNBBGFGAP(T JMDCGOKJIDA, int CBHPEKJLLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3BDE670", Offset = "0x3BDD070", VA = "0x183BDE670")]
	public bool MFKDEBIIBOM(T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3BDE5E0", Offset = "0x3BDCFE0", VA = "0x183BDE5E0")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3BDEA60", Offset = "0x3BDD460", VA = "0x183BDEA60")]
	public T NIPDGGIOLFB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3BDE0E0", Offset = "0x3BDCAE0", VA = "0x183BDE0E0")]
	protected void ADIMLGACIJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3BDEC80", Offset = "0x3BDD680", VA = "0x183BDEC80")]
	public FJGCBIBHNKC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[SerializeField]
		[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x68ABAF0", Offset = "0x68AA4F0", VA = "0x1868ABAF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x68ABDC0", Offset = "0x68AA7C0", VA = "0x1868ABDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x68ABCD0", Offset = "0x68AA6D0", VA = "0x1868ABCD0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x68ABA40", Offset = "0x68AA440", VA = "0x1868ABA40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x68ABD10", Offset = "0x68AA710", VA = "0x1868ABD10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x68ABC20", Offset = "0x68AA620", VA = "0x1868ABC20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x68AB9B0", Offset = "0x68AA3B0", VA = "0x1868AB9B0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x491B720", Offset = "0x491A120", VA = "0x18491B720", Slot = "4")]
		public virtual T IAEKFCIDOJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class EBAAHAJOGPG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Dictionary<byte, MGEHJFADNFP> LGFHDKPHDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly CAJPHPCFPPJ<MGEHJFADNFP> KMBEOJJMKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly bool FHFADMIJKPL;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public MGEHJFADNFP KMOCFMJFNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x851AF0", VA = "0x1808530F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector2 PFIPJEJHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xD31ED0", Offset = "0xD308D0", VA = "0x180D31ED0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x100EA70", Offset = "0x100D470", VA = "0x18100EA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private Vector2 OIJAPFHDMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x10742F0", Offset = "0x1072CF0", VA = "0x1810742F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 KNABPCAPIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x68A8890", Offset = "0x68A7290", VA = "0x1868A8890")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x856970", Offset = "0x855370", VA = "0x180856970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int BBDCOONMEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x858FA0", Offset = "0x8579A0", VA = "0x180858FA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x858FB0", Offset = "0x8579B0", VA = "0x180858FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x68A8FE0", Offset = "0x68A79E0", VA = "0x1868A8FE0")]
	public EBAAHAJOGPG(Bounds KDCDOPFLHCB, Vector2[] DPJEDCJKKHP, int OJLNBIJKHHG, byte JHEGPJBDKAJ, float GGJDPDBKJBO = 0f, [Optional] CAJPHPCFPPJ<MGEHJFADNFP> KMBEOJJMKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x68A8240", Offset = "0x68A6C40", VA = "0x1868A8240")]
	public void BOBCJIHEMLL(Bounds KDCDOPFLHCB, Vector2[] DPJEDCJKKHP, int OJLNBIJKHHG, byte JHEGPJBDKAJ, float GGJDPDBKJBO = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x68A88B0", Offset = "0x68A72B0", VA = "0x1868A88B0")]
	public MGEHJFADNFP MMNLJMABFJA(byte DHNLEFJCEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x68A87C0", Offset = "0x68A71C0", VA = "0x1868A87C0")]
	public void JGKPHFDIMOO(Vector3 HGDCPNGLIKJ, float NANONHKFLNA, float AAJMFKMAPJC, List<byte> KCPGCDNJEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x68A8740", Offset = "0x68A7140", VA = "0x1868A8740")]
	public void FFGCPAEENBJ(MGEHJFADNFP.LHPOGDFGOMM MPLMFILGECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x68A8EF0", Offset = "0x68A78F0", VA = "0x1868A8EF0")]
	public static int PJBEALCPOAM(Vector2[] DPJEDCJKKHP, int OJLNBIJKHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x68A8CC0", Offset = "0x68A76C0", VA = "0x1868A8CC0")]
	private MGEHJFADNFP PGDKNGDEEDJ(byte DHNLEFJCEAH, MGEHJFADNFP.BKCIFIMDGNF CNKALIILKAB, MGEHJFADNFP BMBBFJPOJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x68A8910", Offset = "0x68A7310", VA = "0x1868A8910")]
	private void MPDBJPKFCLE(MGEHJFADNFP BMBBFJPOJEB, Vector2[] DPJEDCJKKHP, int POFJHEANJLB, int HBFHNOFLBKI, int OEDKEGLIMMN, int BCOADEPLLJB, float GGJDPDBKJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x68A8020", Offset = "0x68A6A20", VA = "0x1868A8020")]
	private void AKODCACBFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x68A86E0", Offset = "0x68A70E0", VA = "0x1868A86E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x68A8760", Offset = "0x68A7160", VA = "0x1868A8760", Slot = "1")]
	~EBAAHAJOGPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class MGEHJFADNFP
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public enum BKCIFIMDGNF
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public enum LHPOGDFGOMM
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public byte CODEDOIEGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Vector3 KNFHACNBEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Vector3 LIFKLMGEOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Vector3 KNPEIHDJEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Vector3 ECFANLHEHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public BKCIFIMDGNF KAMHFFBHMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public MGEHJFADNFP EJAGAMOLJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public List<MGEHJFADNFP> KHBCKHOINMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public bool JOLMKCABECH;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x68AB750", Offset = "0x68AA150", VA = "0x1868AB750")]
	public MGEHJFADNFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x68AB5F0", Offset = "0x68A9FF0", VA = "0x1868AB5F0")]
	public void LGJHIGDGICA(MGEHJFADNFP JPEFLCPGHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
	public void FFGCPAEENBJ(int DBBMHIGAALB, LHPOGDFGOMM MPLMFILGECK, int GHDPCBMOFPP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x68AB390", Offset = "0x68A9D90", VA = "0x1868AB390")]
	public void JGKPHFDIMOO(List<byte> KCPGCDNJEHA, Vector3 HGDCPNGLIKJ, float NANONHKFLNA, float AAJMFKMAPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x68AB2D0", Offset = "0x68A9CD0", VA = "0x1868AB2D0")]
	public bool ENOABKCMGKL(Vector3 FNIJIKICPBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x68AB720", Offset = "0x68AA120", VA = "0x1868AB720")]
	public bool MMLCMIOAFMM(Vector3 FNIJIKICPBL, float LIOGGACPGOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x68AB300", Offset = "0x68A9D00", VA = "0x1868AB300")]
	public void HMCGAKKBHMB()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public struct NNPHAGBPNDM<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private readonly List<Component> CGIFJALMJMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private readonly bool AEJPJHFLJPH;

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x4221960", Offset = "0x4220360", VA = "0x184221960")]
			public NNPHAGBPNDM(List<Component> CGIFJALMJMI, bool AEJPJHFLJPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x4538E20", Offset = "0x4537820", VA = "0x184538E20")]
			public JJBLGBDCGNE<T> DCPEOMEKOMK()
			{
				return default(JJBLGBDCGNE<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x4538E80", Offset = "0x4537880", VA = "0x184538E80", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x4538E80", Offset = "0x4537880", VA = "0x184538E80", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public struct JJBLGBDCGNE<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private readonly List<Component> CGIFJALMJMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly bool AEJPJHFLJPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private int DHNLEFJCEAH;

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public T EBFPDFJFKPC
			{
				[Cpp2IlInjected.Token(Token = "0x6000211")]
				[Cpp2IlInjected.Address(RVA = "0x40A0890", Offset = "0x409F290", VA = "0x1840A0890", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000212")]
				[Cpp2IlInjected.Address(RVA = "0x40A0820", Offset = "0x409F220", VA = "0x1840A0820", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x40A0860", Offset = "0x409F260", VA = "0x1840A0860")]
			public JJBLGBDCGNE(List<Component> CGIFJALMJMI, bool AEJPJHFLJPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x40A0760", Offset = "0x409F160", VA = "0x1840A0760", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x40A0770", Offset = "0x409F170", VA = "0x1840A0770", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x38565F0", Offset = "0x3854FF0", VA = "0x1838565F0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x68AD810", Offset = "0x68AC210", VA = "0x1868AD810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x68AD2C0", Offset = "0x68ABCC0", VA = "0x1868AD2C0")]
		private void HMCGAKKBHMB(GameObject JDNAMEBBFMB, bool AMNFMCIBNPO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x68AD230", Offset = "0x68ABC30", VA = "0x1868AD230")]
		public static void HMCGAKKBHMB(GameObject JDNAMEBBFMB, ToolHierarchyCache MGPCCJLLDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x68AD130", Offset = "0x68ABB30", VA = "0x1868AD130")]
		public void EKBFOMDGHMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2E38890", Offset = "0x2E37290", VA = "0x182E38890")]
		public void LEBBJHKNBKL<T>(Action<T> ENGMCBPHJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2E387F0", Offset = "0x2E371F0", VA = "0x182E387F0")]
		public T IMHGJJDCNHN<T>(bool AEJPJHFLJPH = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2E38AC0", Offset = "0x2E374C0", VA = "0x182E38AC0")]
		public NNPHAGBPNDM<T> NHGLAGFMEFC<T>(bool AEJPJHFLJPH = false) where T : class
		{
			return default(NNPHAGBPNDM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x68AD430", Offset = "0x68ABE30", VA = "0x1868AD430")]
		public List<Component> JLPJGPOMMPK(Type NCMHJNKFAGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x68AD140", Offset = "0x68ABB40", VA = "0x1868AD140", Slot = "4")]
		public bool Equals(ToolHierarchyCache IPBJLCONKPC, ToolHierarchyCache FACAKAOOAJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x68AD1C0", Offset = "0x68ABBC0", VA = "0x1868AD1C0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache MEAFIMADMKA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class DKAOIPEKHDK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int HHGNDILCLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int GPLPBBELLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private List<T> DBMHCDPGPKD;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1680", Offset = "0x3CD0080", VA = "0x183CD1680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T NCDLNIPPHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x576B4C0", Offset = "0x5769EC0", VA = "0x18576B4C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T OAIJJFKKBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x576B290", Offset = "0x5769C90", VA = "0x18576B290")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T AOELINJOHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x576B6C0", Offset = "0x576A0C0", VA = "0x18576B6C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x576B9F0", Offset = "0x576A3F0", VA = "0x18576B9F0")]
	public DKAOIPEKHDK(int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x576B890", Offset = "0x576A290", VA = "0x18576B890")]
	public void PBLNBBGFGAP(T NJICNCJNFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x576B400", Offset = "0x5769E00", VA = "0x18576B400")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x576B310", Offset = "0x5769D10", VA = "0x18576B310")]
	public void EELNHPMEPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x576B460", Offset = "0x5769E60", VA = "0x18576B460")]
	public void JPGLPONFFLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x576B210", Offset = "0x5769C10", VA = "0x18576B210")]
	public void ALCHLDCDNCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class PAOCFNIHNOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct FPAKJFKIPKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int CLMJDMFGEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public T JNHPIMBJPMJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly Dictionary<object, FPAKJFKIPKF> ENCKOMKBEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly EqualityComparer<T> PLDPEIBNFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private T BGCICGMELIJ;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public virtual T MDNMGILJJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8C9DC0", Offset = "0x8C87C0", VA = "0x1808C9DC0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4740C20", Offset = "0x473F620", VA = "0x184740C20", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool BFKHAPKIPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4740BB0", Offset = "0x473F5B0", VA = "0x184740BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public object ELFAFEKBGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8555C0", VA = "0x180856BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x85B4C0", Offset = "0x859EC0", VA = "0x18085B4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4741610", Offset = "0x4740010", VA = "0x184741610")]
	public bool MBCOGGKHPPK(T JMDCGOKJIDA, object EOCJCEFCOOA, int CBHPEKJLLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x47418A0", Offset = "0x47402A0", VA = "0x1847418A0")]
	public bool NOOCMPIIMHF(object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x473DD90", Offset = "0x473C790", VA = "0x18473DD90")]
	public bool AKPHPFIGELN(object EOCJCEFCOOA, [Out] T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4533730", Offset = "0x4532130", VA = "0x184533730")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x473E2A0", Offset = "0x473CCA0", VA = "0x18473E2A0")]
	private bool BCHEJMABEAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4741960", Offset = "0x4740360", VA = "0x184741960")]
	public PAOCFNIHNOE()
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
