LoadPlugin("e:\MIPT\AVS\bin\as_kryukov.dll")
# return PepperNoiser(DirectShowSource(".\streams\dynamic_fade.wmv"))
# return DeNoiser(PepperNoiser(DirectShowSource(".\streams\dynamic_fade.wmv")))
 return DeInterlacer(DirectShowSource(".\streams\Waterfall.mpg"))
