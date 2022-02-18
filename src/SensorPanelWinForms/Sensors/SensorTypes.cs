public enum SensorTypes
{
    //MOBO
    MOBONAME, //Value.SMOBONAME
    BIOSVERSION, //Value.SBIOSVER
    TEMP_MOBO, //Value.TMOBO
    TEMP_MOBO_CHIP, //Value.TCHIP


    //CPU
    CPU_NAME, //ProcessorNameString --- NOT AIDA64
    TEMP_CPU, //Value.TCPU
    TEMP_CPU_DIODE, //Value.TCPUDIO
    CPU_USAGE, //Value.SCPUUTI

    //GPU
    TEMP_GPU, //Value.TGPU1DIO
    GPU_USAGE, //Value.SGPU1UTI

    //RAM
    RAM_USAGE, //Value.SMEMUTI
    RAM_USED, //Value.SUSEDMEM
    RAM_FREE //Value.SFREEMEM
};
